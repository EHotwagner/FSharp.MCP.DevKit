namespace FSharp.MCP.DevKit.FsAutoComplete

open System
open System.IO
open System.Text
open System.Text.Json
open System.Threading
open System.Threading.Tasks
open System.Collections.Concurrent
open System.Collections.Generic
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete.LspTypes

/// Pending request information for correlation
type PendingRequest =
    { RequestId: int
      Method: string
      SentAt: DateTime
      CompletionSource: TaskCompletionSource<JsonRpcResponse>
      CancellationToken: CancellationToken }

/// LSP message parser result
type LspParseResult =
    | Request of JsonRpcRequest
    | Response of JsonRpcResponse
    | Notification of JsonRpcNotification
    | ParseError of error: string

/// LSP communication events
type LspCommunicationEvent =
    | MessageSent of method: string * id: int option
    | MessageReceived of LspParseResult
    | ConnectionLost of reason: string
    | ParseError of content: string * error: string
    | RequestTimeout of requestId: int * method: string
    | RequestCompleted of requestId: int * method: string * success: bool

/// Handles LSP message formatting, parsing, and communication
type LspCommunication(logger: ILogger) =
    let mutable nextRequestId = 1
    let mutable writer: StreamWriter option = None
    let mutable reader: StreamReader option = None
    let mutable isConnected = false
    let mutable readerTask: Task option = None
    let mutable cleanupTimer: Timer option = None

    // Request correlation
    let pendingRequests = ConcurrentDictionary<int, PendingRequest>()

    // Events
    let communicationEvents = Event<LspCommunicationEvent>()

    /// Event fired for communication events
    [<CLIEvent>]
    member _.CommunicationEvents = communicationEvents.Publish

    /// Whether the communication is currently connected
    member _.IsConnected = isConnected

    /// Get count of pending requests (for debugging)
    member _.PendingRequestCount = pendingRequests.Count

    /// Initialize communication with the given streams
    member this.Initialize(inputStream: StreamWriter, outputStream: StreamReader) =
        try
            writer <- Some inputStream
            reader <- Some outputStream
            isConnected <- true

            // Start the message reading task
            this.StartMessageReaderTask()

            // Start cleanup timer for timed-out requests (check every 30 seconds)
            cleanupTimer <-
                Some(
                    new Timer(
                        this.CleanupTimedOutRequests,
                        null,
                        TimeSpan.FromSeconds(30.0),
                        TimeSpan.FromSeconds(30.0)
                    )
                )

            logger.LogInformation("LSP communication initialized")
            Ok()
        with ex ->
            logger.LogError(ex, "Failed to initialize LSP communication")
            Error ex.Message

    /// Disconnect and cleanup
    member this.Disconnect() =
        try
            isConnected <- false

            // Cancel all pending requests
            let pendingKeys = pendingRequests.Keys |> Seq.toArray

            for requestId in pendingKeys do
                match pendingRequests.TryRemove(requestId) with
                | true, pending -> pending.CompletionSource.TrySetCanceled() |> ignore
                | false, _ -> ()

            // Cleanup resources
            cleanupTimer |> Option.iter (fun timer -> timer.Dispose())
            cleanupTimer <- None

            writer |> Option.iter (fun w -> w.Dispose())
            reader |> Option.iter (fun r -> r.Dispose())
            writer <- None
            reader <- None

            // Wait for reader task to complete (with timeout)
            readerTask
            |> Option.iter (fun task ->
                try
                    if not task.IsCompleted then
                        task.Wait(TimeSpan.FromSeconds(5.0)) |> ignore
                with _ ->
                    ())

            readerTask <- None

            logger.LogInformation("LSP communication disconnected")
            Ok()
        with ex ->
            logger.LogError(ex, "Error during LSP communication disconnect")
            Error ex.Message

    /// Send an LSP request and return a task that completes when the response is received
    member this.SendRequestAsync(method: string, parameters: obj option, ?cancellationToken: CancellationToken) =
        let ct = defaultArg cancellationToken CancellationToken.None

        if not isConnected then
            logger.LogWarning("Cannot send request '{Method}': not connected", method)
            Task.FromResult(Error "Not connected")
        else
            try
                let requestId = Interlocked.Increment(&nextRequestId)
                logger.LogDebug("Sending LSP request: {Method} with ID {RequestId}", method, requestId)

                let request: JsonRpcRequest =
                    { JsonRpc = "2.0"
                      Id = requestId
                      Method = method
                      Params = parameters }

                let completionSource = TaskCompletionSource<JsonRpcResponse>()

                let pendingRequest =
                    { RequestId = requestId
                      Method = method
                      SentAt = DateTime.UtcNow
                      CompletionSource = completionSource
                      CancellationToken = ct }

                // Store the pending request before sending
                pendingRequests.[requestId] <- pendingRequest

                match this.SendMessage(request) with
                | Ok _ ->
                    logger.LogDebug("Successfully sent LSP request: {Method} with ID {RequestId}", method, requestId)
                    communicationEvents.Trigger(MessageSent(method, Some requestId))

                    // Set up cancellation handling
                    if ct.CanBeCanceled then
                        ct.Register(fun () ->
                            match pendingRequests.TryRemove(requestId) with
                            | true, pending -> pending.CompletionSource.TrySetCanceled() |> ignore
                            | false, _ -> ())
                        |> ignore

                    // Return task that converts JsonRpcResponse to Result
                    task {
                        try
                            let! response = completionSource.Task
                            communicationEvents.Trigger(RequestCompleted(requestId, method, true))
                            return Ok response
                        with
                        | :? OperationCanceledException ->
                            logger.LogWarning("LSP request cancelled: {Method} with ID {RequestId}", method, requestId)
                            communicationEvents.Trigger(RequestCompleted(requestId, method, false))
                            return Error "Request was cancelled"
                        | ex ->
                            logger.LogError(ex, "LSP request failed: {Method} with ID {RequestId}", method, requestId)
                            communicationEvents.Trigger(RequestCompleted(requestId, method, false))
                            return Error $"Request failed: {ex.Message}"
                    }
                | Error err ->
                    // Remove from pending requests since send failed
                    pendingRequests.TryRemove(requestId) |> ignore
                    Task.FromResult(Error err)

            with ex ->
                logger.LogError(ex, "Error sending LSP request: {Method}", method)
                Task.FromResult(Error ex.Message)

    /// Send an LSP notification (no response expected)
    member this.SendNotification(method: string, parameters: obj option) =
        if not isConnected then
            Error "Not connected"
        else
            try
                let notification: JsonRpcNotification =
                    { JsonRpc = "2.0"
                      Method = method
                      Params = parameters }

                match this.SendMessage(notification) with
                | Ok _ ->
                    communicationEvents.Trigger(MessageSent(method, None))
                    Ok()
                | Error err -> Error err

            with ex ->
                logger.LogError(ex, "Error sending LSP notification: {Method}", method)
                Error ex.Message

    /// Send a raw LSP message
    member private this.SendMessage(message: obj) =
        match writer with
        | Some w when isConnected ->
            try
                let json =
                    JsonSerializer.Serialize(message, JsonSerializerOptions(WriteIndented = false))

                let contentLength = Encoding.UTF8.GetByteCount(json)

                // Write LSP message with proper headers
                w.Write($"Content-Length: {contentLength}\r\n\r\n{json}")
                w.Flush()

                logger.LogTrace("Sent LSP message: {Content}", json)
                Ok()

            with
            | :? ObjectDisposedException ->
                isConnected <- false
                Error "Connection disposed"
            | :? IOException as ex ->
                isConnected <- false
                communicationEvents.Trigger(ConnectionLost ex.Message)
                Error $"IO error: {ex.Message}"
            | ex -> Error $"Error sending message: {ex.Message}"
        | _ -> Error "Not connected or writer not available"

    /// Start the background message reader task
    member private this.StartMessageReaderTask() =
        let readerLoop () =
            task {
                try
                    match reader with
                    | Some r ->
                        while isConnected && not r.EndOfStream do
                            try
                                let! messageResult = this.ReadLspMessageAsync(r)

                                match messageResult with
                                | Ok message ->
                                    communicationEvents.Trigger(MessageReceived message)
                                    this.HandleReceivedMessage(message)
                                | Error err ->
                                    logger.LogWarning("Failed to parse LSP message: " + err)
                                    communicationEvents.Trigger(ParseError("", err))

                            with
                            | :? EndOfStreamException ->
                                logger.LogInformation("LSP stream ended")
                                isConnected <- false
                                communicationEvents.Trigger(ConnectionLost "Stream ended")
                            | :? IOException as ex ->
                                logger.LogWarning(ex, "IO error reading LSP messages")
                                isConnected <- false
                                communicationEvents.Trigger(ConnectionLost ex.Message)
                            | ex ->
                                logger.LogError(ex, "Error reading LSP message")
                                do! Task.Delay(1000) // Brief delay before continuing
                    | None -> logger.LogError("Reader not available")

                with ex ->
                    logger.LogError(ex, "Fatal error in LSP message reader")
                    isConnected <- false
                    communicationEvents.Trigger(ConnectionLost ex.Message)
            }

        readerTask <- Some(Task.Run(System.Func<Task>(fun () -> readerLoop () :> Task)))

    /// Handle a received LSP message
    member private this.HandleReceivedMessage(message: LspParseResult) =
        match message with
        | LspParseResult.Response response ->
            match response.Id with
            | Some requestId ->
                match pendingRequests.TryRemove(requestId) with
                | true, pending ->
                    pending.CompletionSource.TrySetResult(response) |> ignore
                    logger.LogTrace("Completed request {RequestId} for method {Method}", requestId, pending.Method)
                | false, _ -> logger.LogWarning("Received response for unknown request ID: {RequestId}", requestId)
            | None -> logger.LogWarning("Received response without request ID")
        | LspParseResult.Request request ->
            logger.LogWarning("Received unexpected request from fsautocomplete: {Method}", request.Method)
        | LspParseResult.Notification notification ->
            logger.LogTrace("Received notification: {Method}", notification.Method)
        // Notifications are handled by the event system
        | LspParseResult.ParseError(error) -> logger.LogError("Failed to parse LSP message: {Error}", error)

    /// Read a single LSP message from the stream
    member private this.ReadLspMessageAsync(reader: StreamReader) =
        task {
            try
                // Read headers - skip any non-LSP lines until we find a Content-Length header
                let mutable contentLength = 0
                let mutable foundHeader = false
                let mutable errorResult = None

                // Keep reading lines until we find a Content-Length header
                while not foundHeader && errorResult.IsNone do
                    let! currentLine = reader.ReadLineAsync()

                    if currentLine = null then
                        errorResult <- Some "End of stream reached before finding Content-Length header"
                    else if currentLine.StartsWith("Content-Length:") then
                        let lengthStr = currentLine.Substring(15).Trim()

                        match Int32.TryParse(lengthStr) with
                        | true, length ->
                            contentLength <- length
                            foundHeader <- true
                        | false, _ -> logger.LogWarning("Invalid Content-Length header format: {Header}", currentLine)
                    elif not (String.IsNullOrWhiteSpace(currentLine)) then
                        // Log non-LSP output for debugging but continue searching
                        logger.LogDebug("Skipping non-LSP line from server output: {Line}", currentLine)

                // Check if we encountered an error during header reading
                match errorResult with
                | Some error -> return Error error
                | None ->
                    // Read the empty line that follows the Content-Length header
                    let! emptyLine = reader.ReadLineAsync()

                    if not (String.IsNullOrWhiteSpace(emptyLine)) then
                        logger.LogWarning("Expected empty line after Content-Length header, got: {Line}", emptyLine)

                    if contentLength = 0 then
                        return Error "No valid Content-Length header found"
                    else
                        // Read the message content
                        let buffer = Array.zeroCreate<char> contentLength
                        let mutable totalRead = 0
                        let mutable readError = None

                        while totalRead < contentLength && readError.IsNone do
                            let! bytesRead = reader.ReadAsync(buffer, totalRead, contentLength - totalRead)

                            if bytesRead = 0 then
                                readError <- Some "Unexpected end of stream while reading message content"
                            else
                                totalRead <- totalRead + bytesRead

                        match readError with
                        | Some err -> return Error err
                        | None ->
                            let content = new string (buffer, 0, totalRead)
                            logger.LogTrace("Received LSP message: {Content}", content)
                            return this.ParseLspMessage(content)

            with ex ->
                return Error $"Error reading LSP message: {ex.Message}"
        }

    /// Parse LSP message JSON content
    member private this.ParseLspMessage(content: string) =
        try
            let doc = JsonDocument.Parse(content)
            let root = doc.RootElement

            // Check if it's a request, response, or notification
            let mutable idElement = Unchecked.defaultof<JsonElement>
            let mutable methodElement = Unchecked.defaultof<JsonElement>
            let mutable resultElement = Unchecked.defaultof<JsonElement>
            let mutable errorElement = Unchecked.defaultof<JsonElement>

            let hasId = root.TryGetProperty("id", &idElement)
            let hasMethod = root.TryGetProperty("method", &methodElement)
            let hasResult = root.TryGetProperty("result", &resultElement)
            let hasError = root.TryGetProperty("error", &errorElement)

            if hasMethod && hasId then
                // Request
                let request = JsonSerializer.Deserialize<JsonRpcRequest>(content)
                Ok(Request request)
            elif hasId && (hasResult || hasError) then
                // Response
                let response = JsonSerializer.Deserialize<JsonRpcResponse>(content)
                Ok(Response response)
            elif hasMethod then
                // Notification
                let notification = JsonSerializer.Deserialize<JsonRpcNotification>(content)
                Ok(Notification notification)
            else
                Error "Invalid JSON-RPC message format"

        with ex ->
            let error = $"JSON parse error: {ex.Message}"
            communicationEvents.Trigger(ParseError(content, error))
            Error error

    /// Cleanup timed-out requests (called by timer)
    member private this.CleanupTimedOutRequests(_: obj) =
        try
            let now = DateTime.UtcNow
            let timeoutThreshold = TimeSpan.FromMinutes(2.0) // 2 minute timeout
            let timedOutRequests = ResizeArray<KeyValuePair<int, PendingRequest>>()

            // Find timed-out requests
            for kvp in pendingRequests do
                if now - kvp.Value.SentAt > timeoutThreshold then
                    timedOutRequests.Add(kvp)

            // Remove and cancel timed-out requests
            for kvp in timedOutRequests do
                match pendingRequests.TryRemove(kvp.Key) with
                | true, pending ->
                    pending.CompletionSource.TrySetException(
                        TimeoutException($"Request {kvp.Key} ({pending.Method}) timed out")
                    )
                    |> ignore

                    communicationEvents.Trigger(RequestTimeout(kvp.Key, pending.Method))

                    logger.LogWarning(
                        "Request {RequestId} ({Method}) timed out after {Elapsed}",
                        kvp.Key,
                        pending.Method,
                        now - pending.SentAt
                    )
                | false, _ -> ()

        with ex ->
            logger.LogError(ex, "Error during request cleanup")

    /// Create default client capabilities for FsAutoComplete
    static member CreateDefaultCapabilities() =
        { TextDocument =
            Some
                { PublishDiagnostics =
                    Some
                        { RelatedInformation = Some true
                          TagSupport = Some { ValueSet = [| DiagnosticTag.Unnecessary; DiagnosticTag.Deprecated |] }
                          VersionSupport = Some true
                          CodeDescriptionSupport = Some true
                          DataSupport = Some true }
                  Synchronization =
                    Some
                        { DynamicRegistration = Some false
                          WillSave = Some false
                          WillSaveWaitUntil = Some false
                          DidSave = Some true }
                  Completion = Some { DynamicRegistration = Some false }
                  Hover = Some { DynamicRegistration = Some false }
                  SignatureHelp = Some { DynamicRegistration = Some false }
                  Definition = Some { DynamicRegistration = Some false }
                  References = Some { DynamicRegistration = Some false }
                  DocumentHighlight = Some { DynamicRegistration = Some false }
                  DocumentSymbol = Some { DynamicRegistration = Some false }
                  CodeAction = Some { DynamicRegistration = Some false }
                  CodeLens = Some { DynamicRegistration = Some false }
                  Formatting = Some { DynamicRegistration = Some false }
                  RangeFormatting = Some { DynamicRegistration = Some false }
                  OnTypeFormatting = Some { DynamicRegistration = Some false }
                  Rename = Some { DynamicRegistration = Some false }
                  DocumentLink = Some { DynamicRegistration = Some false } }
          Workspace =
            Some
                { ApplyEdit = Some false
                  WorkspaceEdit = Some { DocumentChanges = Some false }
                  DidChangeConfiguration = Some { DynamicRegistration = Some false }
                  DidChangeWatchedFiles = Some { DynamicRegistration = Some false }
                  Symbol = Some { DynamicRegistration = Some false }
                  ExecuteCommand = Some { DynamicRegistration = Some false } } }

    interface IDisposable with
        member this.Dispose() = this.Disconnect() |> ignore

    /// Dispose method for cleanup
    member this.Dispose() = (this :> IDisposable).Dispose()
