namespace FSharp.MCP.DevKit.Server

open System
open System.ComponentModel
open System.Diagnostics
open System.IO
open System.Text
open System.Text.Json
open System.Text.Json.Serialization
open System.Threading
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open ModelContextProtocol.Server
open FSharp.MCP.DevKit.FsAutoComplete
open FSharp.MCP.DevKit.FsAutoComplete.LspTypes

/// Service to manage FsAutoComplete wrapper instances for MCP tools
type FsAutoCompleteService(logger: ILogger<FsAutoCompleteService>) =
    let mutable wrapperInstance: FsAutoCompleteWrapper option = None
    let mutable isDisposed = false
    let diagnosticEvents = Event<string * Diagnostic[]>()

    /// Event fired when diagnostics are received for a file
    [<CLIEvent>]
    member _.DiagnosticsReceived = diagnosticEvents.Publish

    /// Get or create the wrapper instance
    member this.GetOrCreateWrapper(?rootPath: string) =
        if isDisposed then
            Result.Error "Service has been disposed"
        else
            match wrapperInstance with
            | Some wrapper when wrapper.IsReady || wrapper.State = FsAutoCompleteState.Starting -> Result.Ok wrapper
            | Some wrapper when
                (match wrapper.State with
                 | FsAutoCompleteState.Error _ -> true
                 | _ -> false)
                ->
                // Dispose the failed wrapper and create a new one
                (wrapper :> IDisposable).Dispose()
                wrapperInstance <- None
                this.CreateNewWrapper(?rootPath = rootPath)
            | _ -> this.CreateNewWrapper(?rootPath = rootPath)

    /// Create a new wrapper instance
    member private this.CreateNewWrapper(?rootPath: string) =
        try
            let config =
                { FsAutoCompleteWrapperConfig.Default with
                    WorkspaceRoot = rootPath }

            // Create a compatible logger for the wrapper
            let wrapperLogger =
                { new ILogger<FsAutoCompleteWrapper> with
                    member _.BeginScope<'TState>(state: 'TState) = logger.BeginScope(state)
                    member _.IsEnabled(logLevel: LogLevel) = logger.IsEnabled(logLevel)

                    member _.Log<'TState>
                        (
                            logLevel: LogLevel,
                            eventId: EventId,
                            state: 'TState,
                            ex: Exception,
                            formatter: Func<'TState, Exception, string>
                        ) =
                        logger.Log(logLevel, eventId, state, ex, formatter) }

            let wrapper = new FsAutoCompleteWrapper(config, wrapperLogger)

            // Subscribe to diagnostic events
            wrapper.WrapperEvents.Add(fun event ->
                match event with
                | FsAutoCompleteEvent.DiagnosticsReceived(uri, diagnostics) ->
                    diagnosticEvents.Trigger(uri, diagnostics)
                | _ -> ())

            wrapperInstance <- Some wrapper
            Result.Ok wrapper
        with ex ->
            logger.LogError(ex, "Failed to create FsAutoComplete wrapper")
            Result.Error $"Failed to create wrapper: {ex.Message}"

    /// Start the wrapper if not already started
    member this.StartWrapperAsync(?rootPath: string, ?timeout: int) =
        async {
            let timeoutSpan =
                timeout
                |> Option.map (fun t -> TimeSpan.FromSeconds(float t))
                |> Option.defaultValue (TimeSpan.FromSeconds(30.0))

            match this.GetOrCreateWrapper(?rootPath = rootPath) with
            | Result.Ok wrapper ->
                if wrapper.IsReady then
                    return Result.Ok "FsAutoComplete is already running and ready"
                else
                    use cts = new CancellationTokenSource(timeoutSpan)

                    try
                        let! result = wrapper.StartAsync(cts.Token)

                        match result with
                        | Result.Ok _ ->
                            logger.LogInformation("FsAutoComplete started successfully")
                            return Result.Ok "FsAutoComplete started successfully"
                        | Result.Error err ->
                            logger.LogError("Failed to start FsAutoComplete: {Error}", err)
                            return Result.Error $"Failed to start FsAutoComplete: {err}"
                    with
                    | :? OperationCanceledException -> return Result.Error "FsAutoComplete startup timed out"
                    | ex ->
                        logger.LogError(ex, "Exception starting FsAutoComplete")
                        return Result.Error $"Exception starting FsAutoComplete: {ex.Message}"
            | Result.Error err -> return Result.Error err
        }

    /// Stop the wrapper
    member this.StopWrapperAsync(?timeout: int) =
        async {
            let timeoutSpan =
                timeout
                |> Option.map (fun t -> TimeSpan.FromSeconds(float t))
                |> Option.defaultValue (TimeSpan.FromSeconds(30.0))

            match wrapperInstance with
            | Some wrapper ->
                use cts = new CancellationTokenSource(timeoutSpan)

                try
                    let! result = wrapper.StopAsync(cts.Token)
                    wrapperInstance <- None

                    match result with
                    | Result.Ok _ ->
                        logger.LogInformation("FsAutoComplete stopped successfully")
                        return Result.Ok "FsAutoComplete stopped successfully"
                    | Result.Error err ->
                        logger.LogWarning("Error stopping FsAutoComplete: {Error}", err)
                        return Result.Error $"Error stopping FsAutoComplete: {err}"
                with
                | :? OperationCanceledException -> return Result.Error "FsAutoComplete stop operation timed out"
                | ex ->
                    logger.LogError(ex, "Exception stopping FsAutoComplete")
                    return Result.Error $"Exception stopping FsAutoComplete: {ex.Message}"
            | None -> return Result.Ok "FsAutoComplete is not running"
        }

    /// Get wrapper status
    member this.GetStatus() =
        match wrapperInstance with
        | Some wrapper ->
            match wrapper.State with
            | FsAutoCompleteState.NotStarted -> "Not started"
            | FsAutoCompleteState.Starting -> "Starting..."
            | FsAutoCompleteState.Initializing -> "Initializing..."
            | FsAutoCompleteState.Ready -> "Ready"
            | FsAutoCompleteState.Error err -> $"Error: {err}"
            | FsAutoCompleteState.Disposed -> "Disposed"
        | None -> "Not initialized"

    /// Get current wrapper instance if available and ready
    member this.GetReadyWrapper() =
        match wrapperInstance with
        | Some wrapper when wrapper.IsReady -> Some wrapper
        | _ -> None

    /// Get diagnostics for a file
    member this.GetDiagnosticsForFile(uri: string) =
        match this.GetReadyWrapper() with
        | Some wrapper ->
            wrapper.GetDiagnostics(uri)
            |> Option.map (fun fileDiags -> fileDiags.AllDiagnostics)
            |> Option.defaultValue [||]
        | None -> [||]

    /// Get all cached files
    member this.GetCachedFiles() =
        match this.GetReadyWrapper() with
        | Some wrapper -> wrapper.GetCachedFiles()
        | None -> [||]

    /// Open a document in FsAutoComplete
    member this.OpenDocumentAsync(filePath: string) =
        async {
            match this.GetReadyWrapper() with
            | Some wrapper ->
                try
                    if File.Exists(filePath) then
                        let content = File.ReadAllText(filePath)
                        let normalizedPath = filePath.Replace("\\", "/")
                        let uri = $"file:///{normalizedPath}"
                        let result = wrapper.DidOpenTextDocument(uri, content, 1)

                        match result with
                        | Result.Ok _ -> return Result.Ok $"Document opened: {filePath}"
                        | Result.Error err -> return Result.Error $"Failed to open document: {err}"
                    else
                        return Result.Error $"File not found: {filePath}"
                with ex ->
                    return Result.Error $"Exception opening document: {ex.Message}"
            | None -> return Result.Error "FsAutoComplete is not ready"
        }

    /// Wait for diagnostics to be published for a specific file
    member this.WaitForDiagnosticsAsync(filePath: string, timeout: TimeSpan) =
        async {
            let normalizedPath = filePath.Replace("\\", "/")
            let uri = $"file:///{normalizedPath}"

            // Check if diagnostics are already available
            let existingDiagnostics = this.GetDiagnosticsForFile(uri)

            if existingDiagnostics.Length > 0 then
                return Some existingDiagnostics
            else
                // Set up event-based waiting
                let tcs = TaskCompletionSource<Diagnostic[] option>()
                let cts = new CancellationTokenSource(timeout)

                // Cancel the task if timeout expires
                cts.Token.Register(fun () ->
                    if not tcs.Task.IsCompleted then
                        tcs.TrySetResult(None) |> ignore)
                |> ignore

                let mutable subscription: IDisposable option = None

                try
                    // Subscribe to diagnostic events for this specific URI
                    subscription <-
                        Some(
                            this.DiagnosticsReceived.Subscribe(fun (eventUri, diagnostics) ->
                                if eventUri = uri && not tcs.Task.IsCompleted then
                                    tcs.TrySetResult(Some diagnostics) |> ignore)
                        )

                    // Also try to trigger diagnostic publication by making a small change
                    match this.GetReadyWrapper() with
                    | Some wrapper ->
                        try
                            let content = File.ReadAllText(filePath)
                            // Force a content change to trigger diagnostics
                            let result1 = wrapper.DidChangeTextDocument(uri, 2, content + " ")
                            do! Async.Sleep(50) // Brief delay
                            let result2 = wrapper.DidChangeTextDocument(uri, 3, content)

                            // Also send a small content change that might trigger analysis
                            if result1.IsOk && result2.IsOk then
                                // Send another small change to ensure analysis
                                let result3 = wrapper.DidChangeTextDocument(uri, 4, content)
                                ()
                        with ex ->
                            () // Continue even if triggering fails
                    | None -> ()

                    // Start a fallback polling mechanism
                    let pollAsync =
                        async {
                            let mutable attempts = 0
                            let maxAttempts = int (timeout.TotalMilliseconds / 200.0) // Check every 200ms

                            while attempts < maxAttempts && not tcs.Task.IsCompleted do
                                do! Async.Sleep(200)
                                attempts <- attempts + 1

                                let diagnostics = this.GetDiagnosticsForFile(uri)

                                if diagnostics.Length > 0 && not tcs.Task.IsCompleted then
                                    tcs.TrySetResult(Some diagnostics) |> ignore
                        // Don't return empty array prematurely - let the full timeout expire
                        // This allows FsAutoComplete more time to analyze complex files
                        }

                    // Start polling in background
                    Async.Start(pollAsync, cts.Token)

                    // Wait for either event or timeout
                    let! result = tcs.Task |> Async.AwaitTask
                    return result

                finally
                    subscription |> Option.iter (fun s -> s.Dispose())
                    cts.Dispose()
        }

    interface IDisposable with
        member this.Dispose() =
            if not isDisposed then
                isDisposed <- true
                wrapperInstance |> Option.iter (fun w -> (w :> IDisposable).Dispose())
                wrapperInstance <- None

/// Event arguments for diagnostics received from FsAutoComplete
type DiagnosticsReceivedEventArgs(uri: string, diagnostics: Diagnostic[]) =
    member this.Uri = uri
    member this.Diagnostics = diagnostics

/// MCP Tools for FsAutoComplete Language Server integration
[<McpServerToolType>]
type FsAutoCompleteTools(fsacService: FsAutoCompleteService) =

    [<McpServerTool; Description("Start FsAutoComplete language server for real-time F# diagnostics")>]
    member this.StartFsAutoComplete
        (rootPath: string, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
        task {
            let! result =
                fsacService.StartWrapperAsync(rootPath, ?timeout = timeoutSeconds)
                |> Async.StartAsTask

            match result with
            | Result.Ok msg -> return msg
            | Result.Error err -> return err
        }

    [<McpServerTool; Description("Start FsAutoComplete with full workspace support and file watching")>]
    member this.StartFsAutoCompleteWithWorkspace
        (
            rootPath: string,
            [<Description("Enable automatic project loading and file watching")>] autoLoad: bool,
            [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
        ) : Task<string> =
        task {
            let! result =
                fsacService.StartWrapperAsync(rootPath, ?timeout = timeoutSeconds)
                |> Async.StartAsTask

            match result with
            | Result.Ok msg -> return $"{msg} (autoLoad: {autoLoad})"
            | Result.Error err -> return err
        }

    [<McpServerTool; Description("Check F# file for errors and get real-time diagnostics")>]
    member this.CheckFile
        (filePath: string, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
        task {
            let timeout = defaultArg timeoutSeconds 30

            // Try to ensure project context is loaded
            try
                let fileDir = Path.GetDirectoryName(filePath)

                let projectFiles =
                    Directory.GetFiles(fileDir, "*.fsproj", SearchOption.AllDirectories)

                if projectFiles.Length > 0 then
                    // Load the project first to ensure proper context
                    let projectPath = projectFiles.[0]
                    let! projectLoadResult = this.LoadProject(projectPath)
                    // Log project loading result but continue regardless
                    ()
            with ex ->
                // Continue even if project loading fails
                ()

            let! result = fsacService.OpenDocumentAsync(filePath) |> Async.StartAsTask

            match result with
            | Result.Ok msg ->
                // Wait for diagnostics to be published by FsAutoComplete
                let! diagnostics = fsacService.WaitForDiagnosticsAsync(filePath, TimeSpan.FromSeconds(float timeout))

                match diagnostics with
                | Some diags when diags.Length > 0 ->
                    let diagSummary =
                        diags
                        |> Array.map (fun d ->
                            let severity =
                                match d.Severity with
                                | Some DiagnosticSeverity.Error -> "Error"
                                | Some DiagnosticSeverity.Warning -> "Warning"
                                | Some DiagnosticSeverity.Information -> "Info"
                                | Some DiagnosticSeverity.Hint -> "Hint"
                                | _ -> "Unknown"

                            $"{severity} at line {d.Range.Start.Line + 1}: {d.Message}")
                        |> String.concat "\n"

                    return $"{msg}. Found {diags.Length} diagnostic(s):\n{diagSummary}"
                | Some diags -> return $"{msg}. No diagnostics found."
                | None -> return $"{msg}. Diagnostic collection timed out after {timeout} seconds."
            | Result.Error err -> return err
        }

    [<McpServerTool; Description("Get F# signature information at a specific position")>]
    member this.GetSignature
        (
            filePath: string,
            line: int,
            character: int,
            [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
        ) : Task<string> =
        task {
            match fsacService.GetReadyWrapper() with
            | Some wrapper ->
                try
                    // First ensure the document is opened
                    let! openResult = fsacService.OpenDocumentAsync(filePath) |> Async.StartAsTask

                    match openResult with
                    | Result.Ok _ ->
                        // Convert file path to URI format
                        let normalizedPath = filePath.Replace("\\", "/")
                        let uri = $"file:///{normalizedPath}"

                        // Get hover information (contains type information)
                        let hoverResult = wrapper.GetHover(uri, line, character)

                        match hoverResult with
                        | Result.Ok response ->
                            // Extract meaningful information from the response
                            let responseStr =
                                match response with
                                | Some obj -> obj.ToString()
                                | None -> "No hover information available"

                            return $"Type information at {filePath}:{line}:{character} - {responseStr}"
                        | Result.Error err -> return $"Failed to get signature information: {err}"
                    | Result.Error err -> return $"Failed to open document: {err}"
                with ex ->
                    return $"Exception getting signature: {ex.Message}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }

    [<McpServerTool; Description("Get status of FsAutoComplete language server")>]
    member this.GetStatus() : string = fsacService.GetStatus()

    [<McpServerTool; Description("Stop FsAutoComplete language server")>]
    member this.StopFsAutoComplete
        ([<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
        task {
            let! result = fsacService.StopWrapperAsync(?timeout = timeoutSeconds) |> Async.StartAsTask

            match result with
            | Result.Ok msg -> return msg
            | Result.Error err -> return err
        }

    [<McpServerTool; Description("Get structured diagnostic information from the last file check")>]
    member this.GetDiagnostics(format: string) : string =
        let files = fsacService.GetCachedFiles()

        if files.Length = 0 then
            "No cached diagnostic information available"
        else
            let summary =
                files
                |> Array.map (fun file ->
                    let diagnostics = fsacService.GetDiagnosticsForFile(file)
                    $"{file}: {diagnostics.Length} diagnostics")
                |> String.concat "; "

            $"Cached diagnostics ({format}): {summary}"

    [<McpServerTool; Description("Get F# documentation information at a specific position for InfoPanel display")>]
    member this.GetDocumentation
        (
            filePath: string,
            line: int,
            character: int,
            [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
        ) : Task<string> =
        task {
            match fsacService.GetReadyWrapper() with
            | Some wrapper ->
                try
                    // First ensure the document is opened
                    let! openResult = fsacService.OpenDocumentAsync(filePath) |> Async.StartAsTask

                    match openResult with
                    | Result.Ok _ ->
                        // Convert file path to URI format
                        let normalizedPath = filePath.Replace("\\", "/")
                        let uri = $"file:///{normalizedPath}"

                        // Get hover information (contains documentation)
                        let hoverResult = wrapper.GetHover(uri, line, character)

                        match hoverResult with
                        | Result.Ok response ->
                            // Extract meaningful information from the response
                            let responseStr =
                                match response with
                                | Some obj -> obj.ToString()
                                | None -> "No documentation available"

                            return $"Documentation at {filePath}:{line}:{character} - {responseStr}"
                        | Result.Error err -> return $"Failed to get documentation: {err}"
                    | Result.Error err -> return $"Failed to open document: {err}"
                with ex ->
                    return $"Exception getting documentation: {ex.Message}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }

    [<McpServerTool; Description("Debug information about FsAutoComplete client state")>]
    member this.GetFsAutoCompleteDebugInfo() : string =
        let status = fsacService.GetStatus()
        let files = fsacService.GetCachedFiles()
        $"Status: {status}, Cached files: {files.Length}"

    [<McpServerTool; Description("Discover available F# projects and solutions in a directory")>]
    member this.WorkspacePeek
        (rootPath: string, deep: int, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int) : Task<
                                                                                                                                string
                                                                                                                             >
        =
        task {
            try
                let searchPattern = if deep > 0 then "**/*.fsproj" else "*.fsproj"

                let projects =
                    if Directory.Exists(rootPath) then
                        let allProjects =
                            Directory.GetFiles(rootPath, "*.fsproj", SearchOption.AllDirectories)

                        if allProjects.Length > 0 && deep > 0 then
                            allProjects |> Array.take (min allProjects.Length deep)
                        else
                            allProjects
                    else
                        [||]

                let slnFiles =
                    if Directory.Exists(rootPath) then
                        let allSolutions =
                            Directory.GetFiles(rootPath, "*.sln", SearchOption.AllDirectories)

                        if allSolutions.Length > 0 && deep > 0 then
                            allSolutions |> Array.take (min allSolutions.Length deep)
                        else
                            allSolutions
                    else
                        [||]

                return $"Found {projects.Length} F# projects and {slnFiles.Length} solutions in {rootPath}"
            with ex ->
                return $"Error peeking workspace: {ex.Message}"
        }

    [<McpServerTool; Description("Load multiple F# projects or solution for comprehensive analysis")>]
    member this.WorkspaceLoad
        (filePaths: string array, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
        task {
            match fsacService.GetReadyWrapper() with
            | Some wrapper ->
                let validPaths =
                    filePaths
                    |> Array.filter (fun path ->
                        File.Exists(path) && (path.EndsWith(".fsproj") || path.EndsWith(".sln")))

                let pathList = String.concat ", " validPaths
                return $"Would load {validPaths.Length} projects/solutions: {pathList}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }

    [<McpServerTool; Description("Load a single F# project for analysis")>]
    member this.LoadProject
        (projectPath: string, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
        task {
            match fsacService.GetReadyWrapper() with
            | Some wrapper ->
                if File.Exists(projectPath) && projectPath.EndsWith(".fsproj") then
                    try
                        // FsAutoComplete discovers projects automatically when files are opened
                        // To load a project, we need to open at least one file from it
                        let projectDir = Path.GetDirectoryName(projectPath)
                        let fsFiles = Directory.GetFiles(projectDir, "*.fs", SearchOption.AllDirectories)
                        let fsxFiles = Directory.GetFiles(projectDir, "*.fsx", SearchOption.AllDirectories)
                        let allFiles = Array.append fsFiles fsxFiles

                        if allFiles.Length > 0 then
                            // Open the first file to trigger project loading
                            let firstFile = allFiles.[0]
                            let! openResult = fsacService.OpenDocumentAsync(firstFile) |> Async.StartAsTask

                            match openResult with
                            | Result.Ok msg ->
                                // Wait a moment for project loading to complete
                                do! Task.Delay(1000)
                                return $"Project loaded: {projectPath}. Opened initial file: {firstFile}. {msg}"
                            | Result.Error err -> return $"Failed to load project {projectPath}: {err}"
                        else
                            return $"No F# files found in project directory: {projectDir}"
                    with ex ->
                        return $"Exception loading project {projectPath}: {ex.Message}"
                else
                    return $"Project file not found or invalid: {projectPath}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }

    [<McpServerTool; Description("Get current workspace and project loading status")>]
    member this.GetWorkspaceStatus() : string =
        let status = fsacService.GetStatus()
        let files = fsacService.GetCachedFiles()
        $"Workspace Status: {status}, Active files: {files.Length}"

    [<McpServerTool;
      Description("Get hover information (type signatures, documentation) at a specific position in F# source code")>]
    member this.GetHover
        (
            filePath: string,
            line: int,
            character: int,
            [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
        ) : Task<string> =
        task {
            match fsacService.GetReadyWrapper() with
            | Some wrapper ->
                try
                    // First ensure the document is opened
                    let! openResult = fsacService.OpenDocumentAsync(filePath) |> Async.StartAsTask

                    match openResult with
                    | Result.Ok _ ->
                        // Convert file path to URI format
                        let normalizedPath = filePath.Replace("\\", "/")
                        let uri = $"file:///{normalizedPath}"

                        // Get hover information from the language server
                        let hoverResult = wrapper.GetHover(uri, line, character)

                        match hoverResult with
                        | Result.Ok response ->
                            match response with
                            | Some hoverData ->
                                // Try to parse the hover response to extract meaningful information
                                let hoverStr = hoverData.ToString()

                                // Look for common patterns in hover responses
                                if hoverStr.Contains("\"contents\"") then
                                    // Parse JSON response to extract hover contents
                                    try
                                        let jsonDoc = System.Text.Json.JsonDocument.Parse(hoverStr)
                                        let root = jsonDoc.RootElement
                                        let mutable contentsElement = Unchecked.defaultof<System.Text.Json.JsonElement>
                                        let mutable valueElement = Unchecked.defaultof<System.Text.Json.JsonElement>

                                        if root.TryGetProperty("contents", &contentsElement) then
                                            if contentsElement.TryGetProperty("value", &valueElement) then
                                                let content = valueElement.GetString()
                                                return $"Hover info at {filePath}:{line}:{character}:\n{content}"
                                            else
                                                return
                                                    $"Hover info at {filePath}:{line}:{character}: {contentsElement.GetRawText()}"
                                        else
                                            return $"Hover info at {filePath}:{line}:{character}: {hoverStr}"
                                    with ex ->
                                        return
                                            $"Hover info at {filePath}:{line}:{character}: {hoverStr} (parse error: {ex.Message})"
                                else
                                    return $"Hover info at {filePath}:{line}:{character}: {hoverStr}"
                            | None -> return $"No hover information available at {filePath}:{line}:{character}"
                        | Result.Error err -> return $"Failed to get hover information: {err}"
                    | Result.Error err -> return $"Failed to open document: {err}"
                with ex ->
                    return $"Exception getting hover information: {ex.Message}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }
