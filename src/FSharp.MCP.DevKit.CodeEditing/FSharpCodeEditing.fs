namespace FSharp.MCP.DevKit.CodeEditing

open System
open System.ComponentModel
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.Communication.IPC
open FSharp.MCP.DevKit.Core
open FSharp.MCP.DevKit.Analysis
open ModelContextProtocol.Server
open Fantomas.Core

module FSharpCodeEditing =

    /// Helper function to format diagnostic information into readable error messages
    let private formatErrorWithDiagnostics (baseError: string) (response: PipeResponse) =
        match response.Diagnostics with
        | Some diagnostics when diagnostics.Length > 0 ->
            let diagnosticMessages =
                diagnostics
                |> Array.map (fun d -> $"{d.Severity} at line {d.StartLine}: {d.Message}")
                |> String.concat "\n"

            $"{baseError}\n\nDiagnostics:\n{diagnosticMessages}"
        | _ -> baseError

    /// Validates that a file has a supported F# file extension
    let private validateFSharpFileType (filePath: string) =
        let extension = System.IO.Path.GetExtension(filePath).ToLowerInvariant()

        match extension with
        | ".fsx"
        | ".fs"
        | ".fsi" -> Ok()
        | _ -> Error(sprintf "Error: '%s' is not a supported F# file type. Expected .fsx, .fs, or .fsi file." filePath)

    /// Service that manages the FSI pipe server and client
    type FsiMcpService(logger: ILogger<FsiMcpService>) =
        let mutable fsiService: FsiService option = None
        let mutable pipeServer: PipeServer option = None
        let mutable pipeClient: PipeClient option = None
        let config = FsiConfig.defaultConfig
        let pipeConfig = PipeConfig.defaultConfig

        /// Default timeout for FSI operations (30 seconds)
        let mutable defaultTimeout = TimeSpan.FromSeconds(30.0)

        /// Set the default timeout for FSI operations
        member this.SetDefaultTimeout(timeout: TimeSpan) = defaultTimeout <- timeout

        /// Get the current default timeout
        member this.DefaultTimeout = defaultTimeout

        /// Start the FSI service and pipe server
        member this.StartFsi() =
            try
                if fsiService.IsNone then
                    let fsi = new FsiService(config)
                    fsi.Start()

                    // Initialize with common namespaces
                    fsi.ExecuteInteraction("open System") |> ignore
                    fsi.ExecuteInteraction("open System.IO") |> ignore
                    fsi.ExecuteInteraction("open System.Collections.Generic") |> ignore

                    let server = new PipeServer(pipeConfig, fsi)
                    server.Start()

                    let client = new PipeClient(pipeConfig)

                    fsiService <- Some fsi
                    pipeServer <- Some server
                    pipeClient <- Some client

                    logger.LogInformation(
                        "FSI service started successfully with pipe name: {PipeName}",
                        pipeConfig.PipeName
                    )
            with ex ->
                logger.LogError(ex, "Failed to start FSI service")
                reraise ()

        /// Stop the FSI service and pipe server
        member this.StopFsi() =
            try
                match pipeServer with
                | Some server ->
                    server.Stop()
                    (server :> IDisposable).Dispose()
                | None -> ()

                match fsiService with
                | Some fsi -> fsi.Stop()
                | None -> ()

                pipeServer <- None
                pipeClient <- None
                fsiService <- None

                logger.LogInformation("FSI service stopped")
            with ex ->
                logger.LogError(ex, "Error stopping FSI service")

        /// Get the pipe client for executing commands
        member this.GetClient() =
            match pipeClient with
            | Some client -> client
            | None ->
                this.StartFsi()
                pipeClient.Value

        /// Check if FSI is running
        member this.IsRunning =
            match fsiService with
            | Some fsi -> fsi.IsRunning
            | None -> false

        interface IDisposable with
            member this.Dispose() = this.StopFsi()

    /// REPL and Interactive Development Tools
    [<McpServerToolType>]
    type FSharpREPLTools =

        [<McpServerTool; Description("Execute F# code in FSI session")>]
        static member ``fsi-execute``
            (
                fsiService: FsiMcpService,
                [<Description("F# code to execute")>] code: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.ExecuteCode(code, timeout)

                if response.IsSuccess then
                    let output =
                        if String.IsNullOrEmpty(response.Output) then
                            "Code executed successfully"
                        else
                            response.Output

                    Console.WriteLine($"FSI Execute: {code}")
                    Console.WriteLine($"FSI Output: {output}")
                    return output
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            "Execution failed"
                        else
                            response.Errors

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    Console.WriteLine($"FSI Execute: {code}")
                    Console.WriteLine($"FSI Error: {errorMessage}")
                    return errorMessage
            }

        [<McpServerTool; Description("Evaluate F# expression and return typed result")>]
        static member ``fsi-evaluate``
            (
                fsiService: FsiMcpService,
                [<Description("F# expression to evaluate")>] expression: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.EvaluateExpression(expression, timeout)

                if response.IsSuccess then
                    Console.WriteLine($"FSI Evaluate: {expression}")
                    Console.WriteLine($"FSI Result: {response.Output}")
                    return response.Output
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            "Expression evaluation failed"
                        else
                            response.Errors

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    Console.WriteLine($"FSI Evaluate: {expression}")
                    Console.WriteLine($"FSI Error: {errorMessage}")
                    return errorMessage
            }

        [<McpServerTool; Description("Get current FSI session bindings and state")>]
        static member ``fsi-get-state``
            (
                fsiService: FsiMcpService,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.GetState(timeout)

                if response.IsSuccess then
                    return response.Output
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            "Failed to get FSI state"
                        else
                            $"Error getting FSI state: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

        [<McpServerTool; Description("Reset FSI session, clearing all state")>]
        static member ``fsi-reset``
            (
                fsiService: FsiMcpService,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.Reset(timeout)

                if response.IsSuccess then
                    return "FSI session reset successfully"
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            "Failed to reset FSI session"
                        else
                            $"Error resetting FSI session: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

        [<McpServerTool; Description("Check FSI server availability")>]
        static member ``fsi-status``(fsiService: FsiMcpService) : Task<string> =
            task {
                let client = fsiService.GetClient()

                return
                    if client.IsServerAvailable() then
                        "FSI server is running and accessible"
                    else
                        "FSI server is not accessible"
            }

    /// Environment and Package Management Tools
    [<McpServerToolType>]
    type FSharpEnvironmentTools =

        [<McpServerTool; Description("Load F# script into FSI session")>]
        static member ``fsi-load-script``
            (
                fsiService: FsiMcpService,
                [<Description("Path to the F# script file to load")>] filePath: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.LoadScript(filePath, timeout)

                if response.IsSuccess then
                    let result = $"Script loaded successfully: {filePath}"
                    Console.WriteLine($"FSI Load Script: {filePath}")
                    Console.WriteLine($"FSI Result: {result}")
                    return result
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            $"Failed to load script: {filePath}"
                        else
                            $"Error loading script: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    Console.WriteLine($"FSI Load Script: {filePath}")
                    Console.WriteLine($"FSI Error: {errorMessage}")
                    return errorMessage
            }

        [<McpServerTool; Description("Add .NET assembly reference to FSI")>]
        static member ``fsi-reference-assembly``
            (
                fsiService: FsiMcpService,
                [<Description("Path to the assembly or assembly name to reference")>] assemblyPath: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.ReferenceAssembly(assemblyPath, timeout)

                if response.IsSuccess then
                    return $"Assembly referenced successfully: {assemblyPath}"
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            $"Failed to reference assembly: {assemblyPath}"
                        else
                            $"Error referencing assembly: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

        [<McpServerTool; Description("Add NuGet package reference to FSI")>]
        static member ``fsi-reference-nuget``
            (
                fsiService: FsiMcpService,
                [<Description("NuGet package name (e.g. 'Newtonsoft.Json' or 'FSharp.Data, 4.2.7')")>] packageName:
                    string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.ReferenceNugetPackage(packageName, timeout)

                if response.IsSuccess then
                    return $"NuGet package referenced successfully: {packageName}"
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            $"Failed to reference NuGet package: {packageName}"
                        else
                            $"Error referencing NuGet package: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

        [<McpServerTool; Description("Add directory to FSI search path")>]
        static member ``fsi-add-path``
            (
                fsiService: FsiMcpService,
                [<Description("Directory path to add to F# search path")>] path: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.AddSearchPath(path, timeout)

                if response.IsSuccess then
                    return $"Search path added successfully: {path}"
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            $"Failed to add search path: {path}"
                        else
                            $"Error adding search path: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

    /// Code Analysis and Validation Tools
    [<McpServerToolType>]
    type FSharpAnalysisTools =

        [<McpServerTool; Description("Parse and validate F# code for errors")>]
        static member ``code-validate``
            (
                fsiService: FsiMcpService,
                [<Description("F# code to parse and check")>] code: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.ParseAndCheck(code, timeout)

                if response.IsSuccess then
                    match response.Diagnostics with
                    | Some diagnostics when diagnostics.Length > 0 ->
                        let diagnosticStrings =
                            diagnostics
                            |> Array.map (fun d -> $"{d.Severity} at line {d.StartLine}: {d.Message}")

                        let diagnosticStr = String.Join("\n", diagnosticStrings)
                        return $"Code parsed successfully with diagnostics:\n{diagnosticStr}"
                    | _ -> return "Code parsed successfully with no diagnostics"
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            "Code parsing failed"
                        else
                            $"Error parsing code: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

        [<McpServerTool; Description("Analyze F# file structure and diagnostics")>]
        static member ``file-analyze``
            (fsiService: FsiMcpService, [<Description("Path to the F# script file to analyze")>] filePath: string)
            : Task<string> =
            task {
                try
                    let client = fsiService.GetClient()

                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        match validateFSharpFileType filePath with
                        | Error errorMsg -> return errorMsg
                        | Ok() ->
                            let sourceCode = System.IO.File.ReadAllText(filePath)
                            let! parseResult = client.ParseAndCheck(sourceCode)

                            if parseResult.IsSuccess then
                                let lineCount = sourceCode.Split([| '\n' |], StringSplitOptions.None).Length
                                let charCount = sourceCode.Length

                                let analysisResult =
                                    sprintf "File: %s\nLines: %d\nCharacters: %d\n" filePath lineCount charCount

                                match parseResult.Diagnostics with
                                | Some diagnostics ->
                                    let errorCount =
                                        diagnostics
                                        |> Array.filter (fun d -> d.Severity.ToString() = "Error")
                                        |> Array.length

                                    let warningCount =
                                        diagnostics
                                        |> Array.filter (fun d -> d.Severity.ToString() = "Warning")
                                        |> Array.length

                                    let diagnosticSummary = sprintf "Errors: %d, Warnings: %d" errorCount warningCount

                                    if diagnostics.Length > 0 then
                                        let topIssues =
                                            diagnostics
                                            |> Array.take (min 5 diagnostics.Length)
                                            |> Array.map (fun d ->
                                                sprintf
                                                    "  %s at line %d: %s"
                                                    (d.Severity.ToString())
                                                    d.StartLine
                                                    d.Message)
                                            |> String.concat "\n"

                                        let moreMsg =
                                            if diagnostics.Length > 5 then
                                                sprintf "\n  ... and %d more issues" (diagnostics.Length - 5)
                                            else
                                                ""

                                        return
                                            sprintf
                                                "%s%s\n\nTop Issues:\n%s%s"
                                                analysisResult
                                                diagnosticSummary
                                                topIssues
                                                moreMsg
                                    else
                                        return sprintf "%s%s\n\nNo issues found." analysisResult diagnosticSummary
                                | None -> return sprintf "%sNo diagnostics available." analysisResult
                            else
                                return sprintf "Error analyzing file: %s" parseResult.Errors
                with ex ->
                    return sprintf "Error analyzing code structure: %s" ex.Message
            }

    /// System and Server Management Tools
    [<McpServerToolType>]
    type SystemManagementTools =

        [<McpServerTool; Description("Terminate all MCP server processes")>]
        static member ``server-kill-all``(fsiService: FsiMcpService) : Task<string> =
            task {
                try
                    let mutable output = System.Text.StringBuilder()
                    output.AppendLine("=== Killing MCP Server Processes ===") |> ignore

                    let mutable totalKilled = 0

                    // Kill FSharp.MCP.DevKit processes
                    try
                        let processes = System.Diagnostics.Process.GetProcessesByName("FSharp.MCP.DevKit")

                        if processes.Length > 0 then
                            output.AppendLine($"\nFound {processes.Length} FSharp.MCP.DevKit process(es)")
                            |> ignore

                            for proc in processes do
                                try
                                    output.AppendLine($"   - Killing process ID {proc.Id}") |> ignore
                                    proc.Kill()
                                    proc.WaitForExit(5000) |> ignore
                                    totalKilled <- totalKilled + 1
                                    output.AppendLine($"   ✓ Successfully killed process ID {proc.Id}") |> ignore
                                with ex ->
                                    output.AppendLine($"   ✗ Failed to kill process ID {proc.Id}: {ex.Message}")
                                    |> ignore
                        else
                            output.AppendLine("\nNo FSharp.MCP.DevKit processes found") |> ignore

                    with ex ->
                        output.AppendLine($"\nError during process cleanup: {ex.Message}") |> ignore

                    // Summary
                    output.AppendLine($"\n=== Summary ===") |> ignore

                    if totalKilled > 0 then
                        output.AppendLine($"✅ Successfully killed {totalKilled} MCP server process(es)")
                        |> ignore

                        output.AppendLine($"MCP server processes have been terminated.") |> ignore
                    else
                        output.AppendLine($"ℹ️  No MCP server processes were running") |> ignore

                    return output.ToString()

                with ex ->
                    return sprintf "Error during MCP server cleanup: %s" ex.Message
            }
