namespace FSharp.MCP.DevKit.Communication.IPC

open System
open System.IO
open System.IO.Pipes
open System.Text
open System.Threading
open System.Threading.Tasks
open System.Text.Json
open FSharp.MCP.DevKit.Core
open System.Text.Json.Serialization
open FSharp.Compiler.CodeAnalysis

/// JSON serialization options for pipe communication
module JsonOptions =
    let options =
        let opts = JsonSerializerOptions()
        opts.PropertyNamingPolicy <- JsonNamingPolicy.CamelCase
        opts.WriteIndented <- false
        opts.DefaultIgnoreCondition <- JsonIgnoreCondition.WhenWritingNull
        opts.ReferenceHandler <- ReferenceHandler.IgnoreCycles
        opts

/// Represents a single diagnostic message (error or warning)
type PipeDiagnostic =
    { FileName: string
      StartLine: int
      EndLine: int
      StartColumn: int
      EndColumn: int
      Severity: string
      Message: string }

/// Represents a command sent through the named pipe
type PipeCommand =
    { CommandType: string
      Code: string
      RequestId: string
      Timestamp: DateTime }

/// Represents a response sent through the named pipe
type PipeResponse =
    { RequestId: string
      IsSuccess: bool
      Output: string
      [<JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)>]
      Errors: string // This is for backward compatibility, new diagnostics are in Diagnostics field
      [<JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)>]
      Diagnostics: PipeDiagnostic[] option
      Value: obj option
      ExecutionTime: TimeSpan option
      Timestamp: DateTime }

/// Configuration for named pipe communication
type PipeConfig =
    {
        /// Name of the named pipe
        PipeName: string
        /// Maximum number of concurrent connections
        MaxConnections: int
        /// Timeout for pipe operations in seconds
        TimeoutSeconds: int
        /// Buffer size for pipe communication
        BufferSize: int
        /// FSI display configuration
        FsiDisplayConfig: FsiDisplayConfig
    }

/// FSI display settings configuration
and FsiDisplayConfig =
    {
        /// Maximum number of characters to display
        PrintSize: int
        /// Maximum number of items in collections to display
        PrintLength: int
        /// Maximum nesting depth for data structures
        PrintDepth: int
        /// Maximum line width for pretty printing
        PrintWidth: int
    }

/// Default pipe configuration
module PipeConfig =
    let defaultFsiDisplayConfig =
        { PrintSize = 50000 // Increased from ~10,000 default
          PrintLength = 500 // Increased from ~100 default
          PrintDepth = 10 // Increased from ~3 default
          PrintWidth = 120 // Better line width for modern displays
        }

    let defaultConfig =
        { PipeName = "FSI_REPL_Pipe"
          MaxConnections = 10
          TimeoutSeconds = 30
          BufferSize = 4096
          FsiDisplayConfig = defaultFsiDisplayConfig }

/// Named pipe server for FSI communication
type PipeServer(config: PipeConfig, fsiService: FsiService) =
    let mutable isRunning = false
    let mutable cancellationTokenSource: CancellationTokenSource option = None
    let mutable serverTasks: Task list = []

    /// Process a command received through the pipe
    member private this.ProcessCommand
        (command: PipeCommand, cancellationToken: CancellationToken)
        : Async<PipeResponse> =
        async {
            try
                let! result =
                    match command.CommandType.ToUpper() with
                    | "EXEC" -> async { return fsiService.ExecuteInteraction(command.Code) }
                    | "EVAL" -> async { return fsiService.EvaluateExpression(command.Code) }
                    | "LOAD" -> async { return fsiService.ExecuteInteraction($"#load \"{command.Code}\"") }
                    | "PARSE" -> async { return fsiService.ParseAndCheck(command.Code) }
                    | "RESET" ->
                        fsiService.Reset()

                        async {
                            return
                                { Output = "FSI session reset"
                                  Errors = null
                                  Diagnostics = [||]
                                  IsSuccess = true
                                  Value = None
                                  ExecutionTime = None }
                        }
                    | "RESTART" ->
                        fsiService.Restart()

                        async {
                            return
                                { Output = "FSI session restarted"
                                  Errors = null
                                  Diagnostics = [||]
                                  IsSuccess = true
                                  Value = None
                                  ExecutionTime = None }
                        }
                    | "STATE" ->
                        let state = fsiService.GetState()

                        async {
                            return
                                { Output = state
                                  Errors = null
                                  Diagnostics = [||]
                                  IsSuccess = true
                                  Value = None
                                  ExecutionTime = None }
                        }
                    | "REFERENCE_NUGET" -> async { return fsiService.ReferenceNugetPackage(command.Code) }
                    // | "REFERENCE_PAKET" -> async { return fsiService.ReferencePaketPackage(command.Code) } // Disabled: Paket not working
                    | "REFERENCE_ASSEMBLY" -> async { return fsiService.ReferenceAssembly(command.Code) }
                    | "ADD_PATH" -> async { return fsiService.AddSearchPath(command.Code) }
                    | "QUIT" ->
                        async {
                            return
                                { Output = "Quit acknowledged"
                                  Errors = null
                                  Diagnostics = [||]
                                  IsSuccess = true
                                  Value = None
                                  ExecutionTime = None }
                        }
                    | _ ->
                        async {
                            return
                                { Output = ""
                                  Errors = $"Unknown command type: {command.CommandType}"
                                  Diagnostics = [||]
                                  IsSuccess = false
                                  Value = None
                                  ExecutionTime = None }
                        }

                let diagnostics =
                    result.Diagnostics
                    |> Array.map (fun d ->
                        { FileName = d.FileName
                          StartLine = d.StartLine
                          EndLine = d.EndLine
                          StartColumn = d.StartColumn
                          EndColumn = d.EndColumn
                          Severity = d.Severity.ToString()
                          Message = d.Message })
                    |> Some

                return
                    { RequestId = command.RequestId
                      IsSuccess = result.IsSuccess
                      Output = result.Output
                      Errors = result.Errors // Keep for compatibility
                      Diagnostics = diagnostics
                      Value = result.Value
                      ExecutionTime = result.ExecutionTime
                      Timestamp = DateTime.Now }
            with ex ->
                return
                    { RequestId = command.RequestId
                      IsSuccess = false
                      Output = ""
                      Errors = ex.Message
                      Diagnostics = None
                      Value = None
                      ExecutionTime = None
                      Timestamp = DateTime.Now }
        }

    /// Handle a single client connection
    member private this.HandleClient
        (pipeStream: NamedPipeServerStream, cancellationToken: CancellationToken)
        : Task<unit> =
        async {
            try
                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                printfn $"[{timestamp}] Client connected to pipe: {config.PipeName}"

                while pipeStream.IsConnected && not cancellationToken.IsCancellationRequested do
                    try
                        // Read command
                        let buffer = Array.zeroCreate config.BufferSize

                        let! bytesRead =
                            pipeStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)
                            |> Async.AwaitTask

                        if bytesRead > 0 then
                            let jsonString = Encoding.UTF8.GetString(buffer, 0, bytesRead)

                            let preview =
                                if jsonString.Length > 100 then
                                    jsonString.[..99] + "..."
                                else
                                    jsonString

                            let timestamp = DateTime.Now.ToString("HH:mm:ss")
                            printfn $"[{timestamp}] Received command: {preview}"

                            let command =
                                JsonSerializer.Deserialize<PipeCommand>(jsonString, JsonOptions.options)

                            // Process command with a linked token source for per-request cancellation
                            use requestCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken)
                            let! response = this.ProcessCommand(command, requestCts.Token)

                            // Send response
                            let responseJson = JsonSerializer.Serialize(response, JsonOptions.options)
                            let responseBytes = Encoding.UTF8.GetBytes(responseJson)

                            do!
                                pipeStream.WriteAsync(responseBytes, 0, responseBytes.Length, cancellationToken)
                                |> Async.AwaitTask

                            do! pipeStream.FlushAsync(cancellationToken) |> Async.AwaitTask

                            let timestamp = DateTime.Now.ToString("HH:mm:ss")
                            printfn $"[{timestamp}] Sent response for request: {response.RequestId}"

                            // Check for quit command
                            if command.CommandType.ToUpper() = "QUIT" then
                                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                                printfn $"[{timestamp}] Quit command received, disconnecting client"
                                () // Exit the loop
                        else
                            // Client disconnected
                            ()
                    with
                    | :? OperationCanceledException -> ()
                    | ex ->
                        let timestamp = DateTime.Now.ToString("HH:mm:ss")
                        printfn $"[{timestamp}] Error handling client: {ex.Message}"
                        ()

                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                printfn $"[{timestamp}] Client disconnected from pipe: {config.PipeName}"
            with ex ->
                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                printfn $"[{timestamp}] Error in client handler: {ex.Message}"
        }
        |> Async.StartAsTask

    /// Start the named pipe server
    member this.Start() =
        if isRunning then
            failwith "Pipe server is already running"

        let cts = new CancellationTokenSource()
        cancellationTokenSource <- Some cts
        isRunning <- true

        let timestamp = DateTime.Now.ToString("HH:mm:ss")
        printfn $"[{timestamp}] Starting named pipe server: {config.PipeName}"

        // Create multiple server instances for concurrent connections
        let tasks =
            [ 1 .. config.MaxConnections ]
            |> List.map (fun i ->
                Task.Run(fun () ->
                    (task {
                        while not cts.Token.IsCancellationRequested do
                            try
                                use pipeStream =
                                    new NamedPipeServerStream(
                                        config.PipeName,
                                        PipeDirection.InOut,
                                        config.MaxConnections,
                                        PipeTransmissionMode.Byte,
                                        PipeOptions.Asynchronous
                                    )

                                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                                printfn $"[{timestamp}] Pipe server instance {i} waiting for connection..."

                                do! pipeStream.WaitForConnectionAsync(cts.Token) |> Async.AwaitTask

                                do! this.HandleClient(pipeStream, cts.Token) |> Async.AwaitTask

                            with
                            | :? OperationCanceledException -> ()
                            | ex ->
                                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                                printfn $"[{timestamp}] Error in pipe server instance {i}: {ex.Message}"
                                do! Async.Sleep(1000) // Wait before retrying
                    })
                    :> Task))

        serverTasks <- tasks
        let timestamp = DateTime.Now.ToString("HH:mm:ss")
        printfn $"[{timestamp}] Named pipe server started with {config.MaxConnections} connection slots"

    /// Stop the named pipe server
    member this.Stop() =
        if isRunning then
            let timestamp = DateTime.Now.ToString("HH:mm:ss")
            printfn $"[{timestamp}] Stopping named pipe server..."

            match cancellationTokenSource with
            | Some cts ->
                cts.Cancel()
                cts.Dispose()
                cancellationTokenSource <- None
            | None -> ()

            // Wait for all tasks to complete
            try
                Task.WaitAll(Array.ofList serverTasks, 5000) |> ignore
            with ex ->
                let timestamp = DateTime.Now.ToString("HH:mm:ss")
                printfn $"[{timestamp}] Warning: Some server tasks didn't complete cleanly: {ex.Message}"

            serverTasks <- []
            isRunning <- false
            let timestamp = DateTime.Now.ToString("HH:mm:ss")
            printfn $"[{timestamp}] Named pipe server stopped"

    /// Check if the server is running
    member this.IsRunning = isRunning

    interface IDisposable with
        member this.Dispose() = this.Stop()

/// Named pipe client for FSI communication
type PipeClient(config: PipeConfig) =

    /// Send a command to the FSI server and wait for response
    member this.SendCommand(commandType: string, code: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        async {
            let actualTimeout =
                defaultArg timeout (TimeSpan.FromSeconds(float config.TimeoutSeconds))

            let requestId = Guid.NewGuid().ToString()

            let command =
                { CommandType = commandType
                  Code = code
                  RequestId = requestId
                  Timestamp = DateTime.Now }

            try
                use pipeClient =
                    new NamedPipeClientStream(".", config.PipeName, PipeDirection.InOut)

                // Create a cancellation token for the entire operation with timeout
                use cts = new CancellationTokenSource(actualTimeout)

                // Connect with timeout
                do! pipeClient.ConnectAsync(cts.Token) |> Async.AwaitTask

                // Send command
                let commandJson = JsonSerializer.Serialize(command, JsonOptions.options)
                let commandBytes = Encoding.UTF8.GetBytes(commandJson)

                do!
                    pipeClient.WriteAsync(commandBytes, 0, commandBytes.Length, cts.Token)
                    |> Async.AwaitTask

                do! pipeClient.FlushAsync(cts.Token) |> Async.AwaitTask

                // Read response with timeout
                let buffer = Array.zeroCreate config.BufferSize
                let! bytesRead = pipeClient.ReadAsync(buffer, 0, buffer.Length, cts.Token) |> Async.AwaitTask

                let responseJson = Encoding.UTF8.GetString(buffer, 0, bytesRead)

                let response =
                    JsonSerializer.Deserialize<PipeResponse>(responseJson, JsonOptions.options)

                return response
            with
            | :? OperationCanceledException ->
                return
                    { RequestId = requestId
                      IsSuccess = false
                      Output = ""
                      Errors = $"Operation timed out after {actualTimeout.TotalSeconds} seconds"
                      Diagnostics = None
                      Value = None
                      ExecutionTime = Some actualTimeout
                      Timestamp = DateTime.Now }
            | ex ->
                return
                    { RequestId = requestId
                      IsSuccess = false
                      Output = ""
                      Errors = $"Connection error: {ex.Message}"
                      Diagnostics = None
                      Value = None
                      ExecutionTime = None
                      Timestamp = DateTime.Now }
        }

    /// Execute F# code
    member this.ExecuteCode(code: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("EXEC", code, ?timeout = timeout)

    /// Evaluate F# expression
    member this.EvaluateExpression(expression: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("EVAL", expression, ?timeout = timeout)

    /// Load F# script
    member this.LoadScript(scriptPath: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("LOAD", scriptPath, ?timeout = timeout)

    /// Parse and check F# code
    member this.ParseAndCheck(code: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("PARSE", code, ?timeout = timeout)

    /// Reset FSI session
    member this.Reset(?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("RESET", "", ?timeout = timeout)

    /// Restart FSI session (stop and start fresh)
    member this.Restart(?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("RESTART", "", ?timeout = timeout)

    /// Get FSI state
    member this.GetState(?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("STATE", "", ?timeout = timeout)

    /// Reference NuGet package
    member this.ReferenceNugetPackage(packageName: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("REFERENCE_NUGET", packageName, ?timeout = timeout)

    // /// Reference Paket package (Disabled: Paket integration not working)
    // member this.ReferencePaketPackage(packageName: string, ?timeout: TimeSpan) : Async<PipeResponse> =
    //     this.SendCommand("REFERENCE_PAKET", packageName, ?timeout = timeout)

    /// Reference assembly
    member this.ReferenceAssembly(assemblyPath: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("REFERENCE_ASSEMBLY", assemblyPath, ?timeout = timeout)

    /// Add search path
    member this.AddSearchPath(path: string, ?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("ADD_PATH", path, ?timeout = timeout)

    /// Send quit command
    member this.Quit(?timeout: TimeSpan) : Async<PipeResponse> =
        this.SendCommand("QUIT", "", ?timeout = timeout)

    /// Check if the server is accessible
    member this.IsServerAvailable() : bool =
        try
            use pipeClient =
                new NamedPipeClientStream(".", config.PipeName, PipeDirection.InOut)

            let connectTask = pipeClient.ConnectAsync(1000)
            connectTask.Wait()
            true
        with _ ->
            false
