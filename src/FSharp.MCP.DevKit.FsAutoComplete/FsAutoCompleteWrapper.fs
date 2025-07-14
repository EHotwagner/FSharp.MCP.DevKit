namespace FSharp.MCP.DevKit.FsAutoComplete

open System
open System.IO
open System.Threading
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete.LspTypes

/// FsAutoComplete wrapper configuration
type FsAutoCompleteWrapperConfig =
    { ProcessConfig: FsAutoCompleteConfig
      DiagnosticsConfig: DiagnosticsCacheConfig
      InitializationTimeout: TimeSpan
      RequestTimeout: TimeSpan
      WorkspaceRoot: string option }

    static member Default =
        { ProcessConfig = FsAutoCompleteConfig.Default
          DiagnosticsConfig = DiagnosticsCacheConfig.Default
          InitializationTimeout = TimeSpan.FromSeconds(60.0)
          RequestTimeout = TimeSpan.FromSeconds(60.0)
          WorkspaceRoot = None }

/// FsAutoComplete server state
type FsAutoCompleteState =
    | NotStarted
    | Starting
    | Initializing
    | Ready
    | Error of string
    | Disposed

/// Events emitted by the FsAutoComplete wrapper
type FsAutoCompleteEvent =
    | StateChanged of oldState: FsAutoCompleteState * newState: FsAutoCompleteState
    | DiagnosticsReceived of uri: string * diagnostics: Diagnostic[]
    | ProcessRestarted of attempt: int
    | InitializationCompleted of capabilities: obj option
    | RequestCompleted of requestId: int * method: string * success: bool

/// Main wrapper for FsAutoComplete language server
type FsAutoCompleteWrapper(config: FsAutoCompleteWrapperConfig, logger: ILogger<FsAutoCompleteWrapper>) =
    let mutable currentState = NotStarted
    let mutable processManager: ProcessManager option = None
    let mutable lspCommunication: LspCommunication option = None
    let mutable diagnosticsCache: DiagnosticsCache option = None
    let mutable serverCapabilities: obj option = None
    let mutable isDisposed = false

    // Events
    let wrapperEvents = Event<FsAutoCompleteEvent>()

    /// Event fired when wrapper state changes
    [<CLIEvent>]
    member _.WrapperEvents = wrapperEvents.Publish

    /// Current state of the wrapper
    member _.State = currentState

    /// Whether the server is ready for requests
    member _.IsReady = currentState = Ready

    /// Get cached diagnostics for a file
    member _.GetDiagnostics(uri: string) =
        diagnosticsCache |> Option.bind (fun cache -> cache.GetDiagnostics(uri))

    /// Get all cached file URIs
    member _.GetCachedFiles() =
        diagnosticsCache
        |> Option.map (fun cache -> cache.CachedFiles)
        |> Option.defaultValue [||]

    /// Get cache summary statistics
    member _.GetCacheSummary() =
        diagnosticsCache |> Option.map (fun cache -> cache.GetCacheSummary())

    /// Start the FsAutoComplete server
    member this.StartAsync(?cancellationToken: CancellationToken) : Async<Result<unit, string>> =
        async {
            if isDisposed then
                return Result.Error "Wrapper has been disposed"
            elif currentState <> NotStarted then
                return Result.Error $"Cannot start from state: {currentState}"
            else
                try
                    this.SetState(Starting)
                    let ct = defaultArg cancellationToken CancellationToken.None

                    logger.LogInformation("Starting FsAutoComplete wrapper...")

                    // Initialize components using regular logger
                    let procMgr = new ProcessManager(config.ProcessConfig, logger)
                    let lspComm = new LspCommunication(logger)
                    let diagCache = new DiagnosticsCache(config.DiagnosticsConfig, logger)

                    processManager <- Some procMgr
                    lspCommunication <- Some lspComm
                    diagnosticsCache <- Some diagCache

                    // Set up event handlers
                    this.SetupEventHandlers(procMgr, lspComm, diagCache)

                    // Create a timeout cancellation token for initialization
                    use timeoutCts = new CancellationTokenSource(config.InitializationTimeout)

                    use combinedCts =
                        CancellationTokenSource.CreateLinkedTokenSource(ct, timeoutCts.Token)

                    let timeoutCt = combinedCts.Token

                    try
                        // Start the process
                        let! processResult = procMgr.StartAsync(timeoutCt)

                        match processResult with
                        | Result.Ok processId ->
                            logger.LogInformation("FsAutoComplete process started with PID: {ProcessId}", processId)

                            // Initialize LSP communication
                            match procMgr.StandardInput, procMgr.StandardOutput with
                            | Some stdin, Some stdout ->
                                match lspComm.Initialize(stdin, stdout) with
                                | Result.Ok _ ->
                                    this.SetState(Initializing)

                                    // Send initialize request
                                    let! initResult = this.InitializeServerAsync(timeoutCt)

                                    match initResult with
                                    | Result.Ok capabilities ->
                                        serverCapabilities <- capabilities
                                        this.SetState(Ready)
                                        wrapperEvents.Trigger(InitializationCompleted capabilities)
                                        logger.LogInformation("FsAutoComplete wrapper is ready")
                                        return Result.Ok()
                                    | Result.Error err ->
                                        this.SetState(Error err)
                                        return Result.Error err

                                | Result.Error err ->
                                    this.SetState(Error err)
                                    return Result.Error err
                            | _ ->
                                let err = "Failed to get process streams"
                                this.SetState(Error err)
                                return Result.Error err

                        | Result.Error err ->
                            this.SetState(Error err)
                            return Result.Error err
                    with
                    | :? OperationCanceledException when timeoutCts.Token.IsCancellationRequested ->
                        let err =
                            $"FsAutoComplete initialization timed out after {config.InitializationTimeout.TotalSeconds} seconds"

                        logger.LogError("FsAutoComplete initialization timed out")
                        this.SetState(Error err)
                        return Result.Error err
                    | :? OperationCanceledException ->
                        let err = "FsAutoComplete initialization was cancelled"
                        logger.LogWarning("FsAutoComplete initialization was cancelled")
                        this.SetState(Error err)
                        return Result.Error err

                with ex ->
                    let err = $"Exception starting wrapper: {ex.Message}"
                    logger.LogError(ex, "Exception starting FsAutoComplete wrapper")
                    this.SetState(Error err)
                    return Result.Error err
        }

    /// Stop the FsAutoComplete server
    member this.StopAsync(?cancellationToken: CancellationToken) =
        async {
            let ct = defaultArg cancellationToken CancellationToken.None

            try
                logger.LogInformation("Stopping FsAutoComplete wrapper...")

                // Stop components in reverse order
                lspCommunication |> Option.iter (fun comm -> comm.Disconnect() |> ignore)

                match processManager with
                | Some procMgr ->
                    let! result = procMgr.StopAsync(ct)
                    result |> Result.iter (fun _ -> logger.LogInformation("Process stopped"))
                | None -> ()

                // Cleanup
                lspCommunication |> Option.iter (fun comm -> comm.Dispose())
                processManager |> Option.iter (fun mgr -> mgr.Dispose())
                diagnosticsCache |> Option.iter (fun cache -> cache.Dispose())

                processManager <- None
                lspCommunication <- None
                diagnosticsCache <- None
                serverCapabilities <- None

                this.SetState(NotStarted)
                logger.LogInformation("FsAutoComplete wrapper stopped")

                return Result.Ok()

            with ex ->
                logger.LogError(ex, "Error stopping FsAutoComplete wrapper")
                return Result.Error ex.Message
        }

    /// Restart the FsAutoComplete server
    member this.RestartAsync(?cancellationToken: CancellationToken) =
        async {
            let ct = defaultArg cancellationToken CancellationToken.None

            logger.LogInformation("Restarting FsAutoComplete wrapper...")
            let! stopResult = this.StopAsync(ct)

            match stopResult with
            | Result.Ok _ ->
                do! Async.Sleep(1000) // Brief delay before restart
                return! this.StartAsync(ct)
            | Result.Error err -> return Result.Error err
        }

    /// Open a text document
    member this.DidOpenTextDocument(uri: string, text: string, version: int) =
        match lspCommunication with
        | Some comm when this.IsReady ->
            let docItem: TextDocumentItem =
                { Uri = uri
                  LanguageId = "fsharp"
                  Version = version
                  Text = text }

            let parameters: DidOpenTextDocumentParams = { TextDocument = docItem }
            let result = comm.SendNotification("textDocument/didOpen", Some(box parameters))

            match result with
            | Result.Ok _ ->
                logger.LogDebug("Opened document: {Uri} (version {Version})", uri, version)
                Result.Ok()
            | Result.Error err ->
                logger.LogWarning("Failed to open document {Uri}: {Error}", uri, err)
                Result.Error err

        | _ -> Result.Error "Server not ready or communication not available"

    /// Close a text document
    member this.DidCloseTextDocument(uri: string) =
        match lspCommunication with
        | Some comm when this.IsReady ->
            let parameters: DidCloseTextDocumentParams = { TextDocument = { Uri = uri } }

            let result = comm.SendNotification("textDocument/didClose", Some(box parameters))

            match result with
            | Result.Ok _ ->
                logger.LogDebug("Closed document: {Uri}", uri)
                // Clear diagnostics for closed document
                diagnosticsCache
                |> Option.iter (fun cache -> cache.ClearDiagnostics(uri) |> ignore)

                Result.Ok()
            | Result.Error err ->
                logger.LogWarning("Failed to close document {Uri}: {Error}", uri, err)
                Result.Error err

        | _ -> Result.Error "Server not ready or communication not available"

    /// Change text document content
    member this.DidChangeTextDocument(uri: string, version: int, text: string) =
        match lspCommunication with
        | Some comm when this.IsReady ->
            let change: TextDocumentContentChangeEvent =
                { Range = None // Full document change
                  RangeLength = None
                  Text = text }

            let parameters: DidChangeTextDocumentParams =
                { TextDocument = { Uri = uri; Version = version }
                  ContentChanges = [| change |] }

            let result = comm.SendNotification("textDocument/didChange", Some(box parameters))

            match result with
            | Result.Ok _ ->
                logger.LogDebug("Changed document: {Uri} (version {Version})", uri, version)
                Result.Ok()
            | Result.Error err ->
                logger.LogWarning("Failed to change document {Uri}: {Error}", uri, err)
                Result.Error err

        | _ -> Result.Error "Server not ready or communication not available"

    /// Get hover information
    member this.GetHover(uri: string, line: int, character: int) =
        match lspCommunication with
        | Some comm when this.IsReady ->
            let parameters: TextDocumentPositionParams =
                { TextDocument = { Uri = uri }
                  Position = { Line = line; Character = character } }

            try
                let responseTask = comm.SendRequestAsync("textDocument/hover", Some(box parameters))
                let responseResult = responseTask.Result // Block synchronously for MCP server

                match responseResult with
                | Result.Ok response ->
                    wrapperEvents.Trigger(RequestCompleted(response.Id.Value, "textDocument/hover", true))
                    Result.Ok response.Result
                | Result.Error err ->
                    logger.LogWarning("Hover request failed: {Error}", err)
                    Result.Error err
            with ex ->
                logger.LogError(ex, "Exception during hover request")
                Result.Error $"Exception: {ex.Message}"

        | _ -> Result.Error "Server not ready or communication not available"

    /// Get definition
    member this.GetDefinition(uri: string, line: int, character: int) =
        match lspCommunication with
        | Some comm when this.IsReady ->
            let parameters: TextDocumentPositionParams =
                { TextDocument = { Uri = uri }
                  Position = { Line = line; Character = character } }

            try
                let responseTask =
                    comm.SendRequestAsync("textDocument/definition", Some(box parameters))

                let responseResult = responseTask.Result // Block synchronously for MCP server

                match responseResult with
                | Result.Ok response ->
                    wrapperEvents.Trigger(RequestCompleted(response.Id.Value, "textDocument/definition", true))
                    Result.Ok response.Result
                | Result.Error err ->
                    logger.LogWarning("Definition request failed: {Error}", err)
                    Result.Error err
            with ex ->
                logger.LogError(ex, "Exception during definition request")
                Result.Error $"Exception: {ex.Message}"

        | _ -> Result.Error "Server not ready or communication not available"

    /// Initialize the LSP server
    member private this.InitializeServerAsync(ct: CancellationToken) =
        async {
            match lspCommunication with
            | Some comm ->
                let initParams: InitializeParams =
                    { ProcessId = Some(System.Diagnostics.Process.GetCurrentProcess().Id)
                      RootPath = config.WorkspaceRoot
                      RootUri =
                        config.WorkspaceRoot
                        |> Option.map (fun path -> "file://" + path.Replace("\\", "/"))
                      InitializationOptions = None
                      Capabilities = LspCommunication.CreateDefaultCapabilities() }

                try
                    let responseTask = comm.SendRequestAsync("initialize", Some(box initParams), ct)
                    let! responseResult = responseTask |> Async.AwaitTask

                    match responseResult with
                    | Result.Ok response ->
                        // Send initialized notification
                        let notifyResult = comm.SendNotification("initialized", Some(box {| |}))

                        match notifyResult with
                        | Result.Ok _ -> return Result.Ok response.Result
                        | Result.Error err -> return Result.Error $"Failed to send initialized notification: {err}"

                    | Result.Error err -> return Result.Error $"Initialize request failed: {err}"
                with ex ->
                    return Result.Error $"Exception during initialization: {ex.Message}"

            | None -> return Result.Error "LSP communication not available"
        }

    /// Set up event handlers for components
    member private this.SetupEventHandlers
        (procMgr: ProcessManager, lspComm: LspCommunication, diagCache: DiagnosticsCache)
        =
        // Process manager events
        procMgr.ProcessEvents.Add(fun event ->
            match event with
            | ProcessManagerEvent.ProcessExited(code, reason) ->
                logger.LogWarning("FsAutoComplete process exited: {Reason}", reason)
                this.SetState(Error $"Process exited: {reason}")
            | ProcessManagerEvent.ProcessRestarted(attempt, maxAttempts) ->
                logger.LogInformation("Process restarted (attempt {Attempt}/{MaxAttempts})", attempt, maxAttempts)
                wrapperEvents.Trigger(ProcessRestarted attempt)
            | ProcessManagerEvent.ProcessFailed error ->
                logger.LogError("Process failed: {Error}", error)
                this.SetState(Error error)
            | _ -> ())

        // LSP communication events
        lspComm.CommunicationEvents.Add(fun event ->
            match event with
            | LspCommunicationEvent.MessageReceived(Notification notification) ->
                this.HandleNotification(notification, diagCache)
            | LspCommunicationEvent.ConnectionLost reason ->
                logger.LogError("LSP connection lost: {Reason}", reason)
                this.SetState(Error $"Connection lost: {reason}")
            | LspCommunicationEvent.ParseError(content, error) -> logger.LogWarning("LSP parse error: {Error}", error)
            | _ -> ())

        // Diagnostics cache events
        diagCache.CacheEvents.Add(fun event ->
            match event with
            | DiagnosticsCacheEvent.DiagnosticsUpdated(uri, count) ->
                logger.LogTrace("Diagnostics updated for {Uri}: {Count} diagnostics", uri, count)

                match diagCache.GetDiagnostics(uri) with
                | Some fileDiags -> wrapperEvents.Trigger(DiagnosticsReceived(uri, fileDiags.AllDiagnostics))
                | None -> ()
            | DiagnosticsCacheEvent.CacheOverflow droppedFiles ->
                logger.LogWarning("Diagnostics cache overflow: dropped {Count} files", droppedFiles.Length)
            | _ -> ())

    /// Handle LSP notifications
    member private this.HandleNotification(notification: JsonRpcNotification, diagCache: DiagnosticsCache) =
        match notification.Method with
        | "textDocument/publishDiagnostics" ->
            try
                match notification.Params with
                | Some parameters ->
                    let publishDiags =
                        System.Text.Json.JsonSerializer.Deserialize<PublishDiagnosticsParams>(parameters.ToString())

                    logger.LogDebug(
                        "Received publishDiagnostics for {Uri} with {Count} diagnostics",
                        publishDiags.Uri,
                        publishDiags.Diagnostics.Length
                    )

                    diagCache.UpdateDiagnosticsFromNotification(publishDiags)
                | None -> logger.LogWarning("Received publishDiagnostics notification without parameters")
            with ex ->
                logger.LogError(ex, "Error handling publishDiagnostics notification")

        | method -> logger.LogTrace("Received unhandled notification: {Method}", method)

    /// Set the current state and fire events
    member private this.SetState(newState: FsAutoCompleteState) =
        let oldState = currentState
        currentState <- newState

        if oldState <> newState then
            logger.LogDebug("State changed: {OldState} -> {NewState}", oldState, newState)
            wrapperEvents.Trigger(StateChanged(oldState, newState))

    /// Request CodeLens for a document
    member this.GetCodeLens(uri: string) =
        match lspCommunication with
        | Some comm ->
            let codeLensParams: CodeLensParams =
                { TextDocument = { Uri = uri }
                  WorkDoneToken = None
                  PartialResultToken = None }

            try
                let ct = CancellationToken.None
                let responseTask = comm.SendRequestAsync("textDocument/codeLens", Some(box codeLensParams), ct)
                
                async {
                    let! responseResult = responseTask |> Async.AwaitTask
                    match responseResult with
                    | Result.Ok response ->
                        try
                            let codeLenses = System.Text.Json.JsonSerializer.Deserialize<CodeLens[]>(response.Result.ToString())
                            return Result.Ok codeLenses
                        with ex ->
                            logger.LogError(ex, "Failed to deserialize CodeLens response")
                            return Result.Error $"Deserialization error: {ex.Message}"
                    | Result.Error err -> 
                        logger.LogError("CodeLens request failed: {Error}", err)
                        return Result.Error err
                }
            with ex ->
                logger.LogError(ex, "Exception in GetCodeLens")
                async.Return (Result.Error $"Exception: {ex.Message}")
        | None -> async.Return (Result.Error "LSP communication not available")

    /// Resolve a CodeLens (get the command)
    member this.ResolveCodeLens(codeLens: CodeLens) =
        match lspCommunication with
        | Some comm ->
            try
                let ct = CancellationToken.None
                let responseTask = comm.SendRequestAsync("codeLens/resolve", Some(box codeLens), ct)
                
                async {
                    let! responseResult = responseTask |> Async.AwaitTask
                    match responseResult with
                    | Result.Ok response ->
                        try
                            let resolvedCodeLens = System.Text.Json.JsonSerializer.Deserialize<CodeLens>(response.Result.ToString())
                            return Result.Ok resolvedCodeLens
                        with ex ->
                            logger.LogError(ex, "Failed to deserialize resolved CodeLens")
                            return Result.Error $"Deserialization error: {ex.Message}"
                    | Result.Error err -> 
                        logger.LogError("CodeLens resolve failed: {Error}", err)
                        return Result.Error err
                }
            with ex ->
                logger.LogError(ex, "Exception in ResolveCodeLens")
                async.Return (Result.Error $"Exception: {ex.Message}")
        | None -> async.Return (Result.Error "LSP communication not available")

    interface IDisposable with
        member this.Dispose() =
            if not isDisposed then
                isDisposed <- true
                this.StopAsync() |> Async.RunSynchronously |> ignore
