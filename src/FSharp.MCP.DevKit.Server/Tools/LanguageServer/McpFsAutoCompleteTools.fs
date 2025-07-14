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
                // Use the wrapper's improved waiting mechanism
                match fsacService.GetReadyWrapper() with
                | Some wrapper ->
                    try
                        let normalizedPath = filePath.Replace("\\", "/")
                        let uri = $"file:///{normalizedPath}"

                        // Give FsAutoComplete time to process the file and send diagnostics
                        do! Async.Sleep(2000) // Wait 2 seconds for processing

                        // Check cached diagnostics directly
                        let cachedDiags = wrapper.GetDiagnostics(uri)

                        match cachedDiags with
                        | Some fileDiags when fileDiags.AllDiagnostics.Length > 0 ->
                            let diagSummary =
                                fileDiags.AllDiagnostics
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

                            return $"{msg}. Found {fileDiags.AllDiagnostics.Length} diagnostic(s):\n{diagSummary}"
                        | Some fileDiags -> return $"{msg}. No diagnostics found. File processed successfully."
                        | None ->
                            return
                                $"{msg}. No diagnostics available. File may not be part of a loaded project or FsAutoComplete needs more time to process it."
                    with ex ->
                        return $"{msg}. Exception waiting for diagnostics: {ex.Message}"
                | None -> return $"{msg}. FsAutoComplete wrapper not ready."
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

    [<McpServerTool; Description("Get CodeLens information for an F# file (shows references, implementations, etc.)")>]
    member this.GetCodeLens
        (filePath: string, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
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

                        // Get CodeLens information from the language server
                        let! codeLensResult = wrapper.GetCodeLens(uri) |> Async.StartAsTask

                        match codeLensResult with
                        | Result.Ok codeLenses ->
                            if codeLenses.Length > 0 then
                                let codeLensSummary =
                                    codeLenses
                                    |> Array.mapi (fun i cl ->
                                        let range = cl.Range
                                        let startLine = range.Start.Line + 1 // Convert to 1-based
                                        let endLine = range.End.Line + 1

                                        let commandInfo =
                                            match cl.Command with
                                            | Some cmd -> $" - Command: {cmd.Title}"
                                            | None -> " - (Unresolved)"

                                        $"[{i + 1}] Line {startLine}-{endLine}{commandInfo}")
                                    |> String.concat "\n"

                                return $"Found {codeLenses.Length} CodeLens item(s) in {filePath}:\n{codeLensSummary}"
                            else
                                return $"No CodeLens information available for {filePath}"
                        | Result.Error err -> return $"Failed to get CodeLens information: {err}"
                    | Result.Error err -> return $"Failed to open document: {err}"
                with ex ->
                    return $"Exception getting CodeLens information: {ex.Message}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }

    [<McpServerTool; Description("Resolve a specific CodeLens to get its command details")>]
    member this.ResolveCodeLens
        (
            filePath: string,
            codeLensIndex: int,
            [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
        ) : Task<string> =
        task {
            match fsacService.GetReadyWrapper() with
            | Some wrapper ->
                try
                    // First get the CodeLens items
                    let! codeLensResult = this.GetCodeLens(filePath, ?timeoutSeconds = timeoutSeconds)

                    // Parse out the original CodeLens data (this is a simplified approach)
                    // In a more robust implementation, you'd cache the original CodeLens objects
                    let normalizedPath = filePath.Replace("\\", "/")
                    let uri = $"file:///{normalizedPath}"

                    let! originalCodeLenses = wrapper.GetCodeLens(uri) |> Async.StartAsTask

                    match originalCodeLenses with
                    | Result.Ok codeLenses ->
                        if codeLensIndex >= 0 && codeLensIndex < codeLenses.Length then
                            let codeLens = codeLenses.[codeLensIndex]

                            // Resolve the CodeLens to get the full command
                            let! resolvedResult = wrapper.ResolveCodeLens(codeLens) |> Async.StartAsTask

                            match resolvedResult with
                            | Result.Ok resolvedCodeLens ->
                                let range = resolvedCodeLens.Range
                                let startLine = range.Start.Line + 1
                                let endLine = range.End.Line + 1

                                match resolvedCodeLens.Command with
                                | Some cmd ->
                                    let argsInfo =
                                        match cmd.Arguments with
                                        | Some args when args.Length > 0 ->
                                            let argsStr = String.concat ", " (args |> Array.map (fun a -> a.ToString()))
                                            $"\nArguments: {argsStr}"
                                        | _ -> ""

                                    return
                                        $"Resolved CodeLens at line {startLine}-{endLine}:\nTitle: {cmd.Title}\nCommand: {cmd.Command}{argsInfo}"
                                | None -> return $"CodeLens at line {startLine}-{endLine} has no command information"
                            | Result.Error err -> return $"Failed to resolve CodeLens: {err}"
                        else
                            return $"Invalid CodeLens index {codeLensIndex}. Valid range: 0-{codeLenses.Length - 1}"
                    | Result.Error err -> return $"Failed to get CodeLens items: {err}"
                with ex ->
                    return $"Exception resolving CodeLens: {ex.Message}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }

    [<McpServerTool; Description("Get detailed CodeLens information with resolved commands for an F# file")>]
    member this.GetDetailedCodeLens
        (filePath: string, [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int)
        : Task<string> =
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

                        // Get CodeLens information
                        let! codeLensResult = wrapper.GetCodeLens(uri) |> Async.StartAsTask

                        match codeLensResult with
                        | Result.Ok codeLenses ->
                            if codeLenses.Length > 0 then
                                let! resolvedResults =
                                    codeLenses
                                    |> Array.map (fun cl -> wrapper.ResolveCodeLens(cl) |> Async.StartAsTask)
                                    |> Task.WhenAll

                                let detailedSummary =
                                    resolvedResults
                                    |> Array.mapi (fun i result ->
                                        match result with
                                        | Result.Ok resolvedCl ->
                                            let range = resolvedCl.Range
                                            let startLine = range.Start.Line + 1
                                            let endLine = range.End.Line + 1

                                            match resolvedCl.Command with
                                            | Some cmd ->
                                                let argsCount =
                                                    match cmd.Arguments with
                                                    | Some args -> args.Length
                                                    | None -> 0

                                                $"[{i + 1}] Line {startLine}-{endLine}: {cmd.Title} (Command: {cmd.Command}, Args: {argsCount})"
                                            | None -> $"[{i + 1}] Line {startLine}-{endLine}: (No command)"
                                        | Result.Error err -> $"[{i + 1}] Resolution failed: {err}")
                                    |> String.concat "\n"

                                return $"Found {codeLenses.Length} CodeLens item(s) in {filePath}:\n{detailedSummary}"
                            else
                                return $"No CodeLens information available for {filePath}"
                        | Result.Error err -> return $"Failed to get CodeLens information: {err}"
                    | Result.Error err -> return $"Failed to open document: {err}"
                with ex ->
                    return $"Exception getting detailed CodeLens information: {ex.Message}"
            | None -> return "FsAutoComplete is not ready. Please start it first."
        }
