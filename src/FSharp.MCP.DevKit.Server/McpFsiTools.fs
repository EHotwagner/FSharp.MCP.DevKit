namespace FSharp.MCP.DevKit.Server

open System
open System.ComponentModel
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.Communication.IPC
open FSharp.MCP.DevKit.Core
open FSharp.MCP.DevKit.Analysis
open ModelContextProtocol.Server
open Fantomas.Core

/// Module containing MCP server tools for F# Interactive code management
///
/// Recent improvements (June 2025):
/// - Fixed critical error string injection bug in all code insertion functions
/// - Added unified code insertion function (InsertCodeUnified) with comprehensive features:
///   * Pre-formatting of new code
///   * Safe line number validation
///   * Optional AST validation
///   * Post-insertion document formatting
///   * Atomic file operations with backup/rollback
/// - Updated line splitting to preserve empty lines (StringSplitOptions.None)
/// - Enhanced error handling to prevent malformed code injection
module McpFsiTools =

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

    /// Safely splits text while preserving line endings and empty lines
    let private splitLinesPreservingLineEndings (text: string) =
        if String.IsNullOrEmpty(text) then
            [||]
        else
            // Handle different line ending types properly
            text.Split([| "\r\n"; "\n"; "\r" |], StringSplitOptions.None)

    /// Safely joins lines back together with consistent line endings
    let private joinLinesWithConsistentEndings (lines: string[]) = String.Join("\n", lines)

    /// Validates that new code can be safely inserted without breaking F# syntax
    let private validateInsertionContext (existingLines: string[]) (insertAtLine: int) (newCodeLines: string[]) =
        if insertAtLine <= 0 || insertAtLine > existingLines.Length + 1 then
            Error(sprintf "Invalid line number %d. File has %d lines." insertAtLine existingLines.Length)
        else
            // Check if we're trying to insert in the middle of a multi-line construct
            let lineBeforeInsertion =
                if insertAtLine > 1 && insertAtLine <= existingLines.Length then
                    Some(existingLines.[insertAtLine - 2].Trim())
                else
                    None

            let lineAfterInsertion =
                if insertAtLine <= existingLines.Length then
                    Some(existingLines.[insertAtLine - 1].Trim())
                else
                    None

            // Check for dangerous insertion points
            match lineBeforeInsertion, lineAfterInsertion with
            | Some before, Some after when before.EndsWith("=") && after.StartsWith("|") ->
                Error("Cannot insert code in the middle of a discriminated union definition")
            | Some before, Some after when before.Contains("type") && before.EndsWith("=") && after.StartsWith("|") ->
                Error("Cannot insert code in the middle of a type definition")
            | Some before, Some after when before.EndsWith("{") && after.StartsWith("}") ->
                Error("Cannot insert code in the middle of a record definition")
            | _ -> Ok()

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

    /// MCP FSI Tools that provide F# Interactive functionality through named pipes
    [<McpServerToolType>]
    type FSharpInteractiveTools =

        [<McpServerTool; Description("Execute F# code in FSI and return the result")>]
        static member ExecuteFSharpCode
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

        [<McpServerTool; Description("Execute F# code in FSI and return the result with detailed error information")>]
        static member ExecuteFSharpCodeDetailed
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
                    // Detailed error reporting
                    let errorDetails =
                        [ yield $"=== EXECUTION FAILED ==="
                          yield $"Code: {code}"
                          yield $"IsSuccess: {response.IsSuccess}"
                          yield $"Output: '{response.Output}'"
                          yield $"Errors: '{response.Errors}'"
                          yield $"RequestId: {response.RequestId}"
                          yield $"Timestamp: {response.Timestamp}"
                          match response.ExecutionTime with
                          | Some time -> yield $"ExecutionTime: {time.TotalMilliseconds}ms"
                          | None -> yield "ExecutionTime: Not available"
                          match response.Diagnostics with
                          | Some diags ->
                              yield $"Diagnostics: {diags.Length} items"

                              for diag in diags do
                                  yield $"  - {diag.Severity}: {diag.Message} at line {diag.StartLine}"
                          | None -> yield "Diagnostics: None"
                          yield $"=========================" ]
                        |> String.concat "\n"

                    Console.WriteLine($"FSI Execute: {code}")
                    Console.WriteLine($"FSI Detailed Error: {errorDetails}")
                    return errorDetails
            }

        [<McpServerTool; Description("Evaluate F# expression and return the result with type information")>]
        static member EvaluateFSharpExpression
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

        [<McpServerTool; Description("Load an F# script file using #load directive")>]
        static member LoadFSharpScript
            (
                fsiService: FsiMcpService,
                [<Description("Path to the F# script file to load")>] scriptPath: string,
                [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
            ) : Task<string> =
            task {
                let client = fsiService.GetClient()

                let timeout =
                    match timeoutSeconds with
                    | Some seconds -> TimeSpan.FromSeconds(float seconds)
                    | None -> fsiService.DefaultTimeout

                let! response = client.LoadScript(scriptPath, timeout)

                if response.IsSuccess then
                    let result = $"Script loaded successfully: {scriptPath}"
                    Console.WriteLine($"FSI Load Script: {scriptPath}")
                    Console.WriteLine($"FSI Result: {result}")
                    return result
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            $"Failed to load script: {scriptPath}"
                        else
                            $"Error loading script: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    Console.WriteLine($"FSI Load Script: {scriptPath}")
                    Console.WriteLine($"FSI Error: {errorMessage}")
                    return errorMessage
            }

        [<McpServerTool; Description("Reference a .NET assembly using #r directive")>]
        static member ReferenceAssembly
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

        [<McpServerTool; Description("Reference a NuGet package using #r \"nuget: PackageName\" directive")>]
        static member ReferenceNuGetPackage
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

        [<McpServerTool; Description("Add a directory to the F# search path using #I directive")>]
        static member AddSearchPath
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

        [<McpServerTool; Description("Parse and check F# code for syntax and type errors")>]
        static member ParseAndCheckFSharpCode
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

        [<McpServerTool; Description("Reset the F# Interactive session, clearing all bindings and state")>]
        static member ResetFSISession
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

        [<McpServerTool; Description("Get the current state and bindings in the F# Interactive session")>]
        static member GetFSIState
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

        [<McpServerTool; Description("Check if the F# Interactive server is running and accessible")>]
        static member CheckFSIServerStatus(fsiService: FsiMcpService) : Task<string> =
            task {
                let client = fsiService.GetClient()

                return
                    if client.IsServerAvailable() then
                        "FSI server is running and accessible"
                    else
                        "FSI server is not accessible"
            }

    /// MCP Tools for Safe Code Injection - extending FSharpInteractiveTools
    [<McpServerToolType>]
    type CodeInjectionTools =

        [<McpServerTool; Description("Parse source code to analyze its structure before injection")>]
        static member ParseSourceToAST
            (fsiService: FsiMcpService, [<Description("F# source code to parse")>] sourceCode: string)
            : Task<string> =
            task {
                try
                    let client = fsiService.GetClient()
                    let! parseResult = client.ParseAndCheck(sourceCode)

                    if parseResult.IsSuccess then
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

                            let infoCount =
                                diagnostics
                                |> Array.filter (fun d -> d.Severity.ToString() = "Info")
                                |> Array.length

                            let summary =
                                sprintf
                                    "Parse successful. Errors: %d, Warnings: %d, Info: %d"
                                    errorCount
                                    warningCount
                                    infoCount

                            if diagnostics.Length > 0 then
                                let diagnosticDetails =
                                    diagnostics
                                    |> Array.map (fun d ->
                                        sprintf "%s at line %d: %s" (d.Severity.ToString()) d.StartLine d.Message)
                                    |> String.concat "\n"

                                return sprintf "%s\n\nDiagnostics:\n%s" summary diagnosticDetails
                            else
                                return summary
                        | None -> return "Parse successful with no diagnostics"
                    else
                        return sprintf "Parse failed: %s" parseResult.Errors
                with ex ->
                    return sprintf "Error parsing source code: %s" ex.Message
            }

        [<McpServerTool; Description("Analyze the structure of an existing F# script file")>]
        static member AnalyzeCodeStructure
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
                                        return
                                            sprintf
                                                "%s%s\n\nNo issues found - file is ready for code injection."
                                                analysisResult
                                                diagnosticSummary
                                | None ->
                                    return
                                        sprintf
                                            "%sNo diagnostics available\n\nFile appears to be valid for code injection."
                                            analysisResult
                            else
                                return sprintf "Error analyzing file: %s" parseResult.Errors
                with ex ->
                    return sprintf "Error analyzing code structure: %s" ex.Message
            }

        [<McpServerTool;
          Description("Preview what the code will look like after injection without actually writing to file")>]
        static member PreviewCodeInjection
            (
                fsiService: FsiMcpService,
                [<Description("F# code to inject")>] newCode: string,
                [<Description("Path to the target script file")>] filePath: string,
                [<Description("Line number where to insert the code (1-based, optional)")>] ?insertAtLine: int,
                [<Description("Column position for indentation (1-based, optional)")>] ?insertAtColumn: int
            ) : Task<string> =
            task {
                try
                    // Validate file type first
                    let fileTypeValidation =
                        if System.IO.File.Exists(filePath) then
                            validateFSharpFileType filePath
                        else
                            // For new files, validate based on the provided path extension
                            validateFSharpFileType filePath

                    match fileTypeValidation with
                    | Error errorMsg -> return errorMsg
                    | Ok() ->

                        // Read the existing file content
                        let existingCode =
                            if System.IO.File.Exists(filePath) then
                                System.IO.File.ReadAllText(filePath)
                            else
                                ""

                        // Determine insertion point
                        let combinedCode =
                            match insertAtLine with
                            | Some lineNum ->
                                let lines = splitLinesPreservingLineEndings existingCode

                                if lineNum <= 0 || lineNum > lines.Length + 1 then
                                    sprintf "Error: Invalid line number %d. File has %d lines." lineNum lines.Length
                                else
                                    let newCodeLines = splitLinesPreservingLineEndings newCode

                                    // Apply column positioning if specified
                                    let indentedNewCodeLines =
                                        match insertAtColumn with
                                        | Some column when column > 1 ->
                                            let indent = String.replicate (column - 1) " "

                                            newCodeLines
                                            |> Array.mapi (fun i line ->
                                                if i = 0 then indent + line.TrimStart()
                                                else if String.IsNullOrWhiteSpace(line) then line
                                                else indent + line)
                                        | _ -> newCodeLines

                                    let beforeLines = lines |> Array.take (lineNum - 1)
                                    let afterLines = lines |> Array.skip (lineNum - 1)
                                    let allLines = Array.concat [ beforeLines; indentedNewCodeLines; afterLines ]
                                    joinLinesWithConsistentEndings allLines
                            | None ->
                                // FIXED: Append to end with proper spacing, matching InsertCodeUnified behavior
                                let combined =
                                    if String.IsNullOrWhiteSpace(existingCode) then
                                        newCode
                                    else
                                        existingCode.TrimEnd() + "\n\n" + newCode

                                combined

                        let previewTitle =
                            match insertAtLine, insertAtColumn with
                            | Some line, Some col ->
                                sprintf "Preview of code injection into %s at line %d, column %d:" filePath line col
                            | Some line, None -> sprintf "Preview of code injection into %s at line %d:" filePath line
                            | None, Some col ->
                                sprintf "Preview of code injection into %s (end of file, column %d):" filePath col
                            | None, None -> sprintf "Preview of code injection into %s:" filePath

                        return sprintf "%s\n\n%s" previewTitle combinedCode

                with ex ->
                    return sprintf "Error previewing code injection: %s" ex.Message
            }



        [<McpServerTool; Description("Format an entire F# script file using Fantomas")>]
        static member FormatFile
            (fsiService: FsiMcpService, [<Description("Path to the F# script file to format")>] filePath: string)
            : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        match validateFSharpFileType filePath with
                        | Error errorMsg -> return errorMsg
                        | Ok() ->
                            let sourceCode = System.IO.File.ReadAllText(filePath)

                            try
                                let! formatResult =
                                    CodeFormatter.FormatDocumentAsync(filePath.EndsWith(".fsi"), sourceCode)

                                let formattedContent = formatResult.Code

                                if formattedContent <> sourceCode then
                                    System.IO.File.WriteAllText(filePath, formattedContent)
                                    return sprintf "File %s has been formatted by Fantomas" filePath
                                else
                                    return sprintf "File %s was already properly formatted" filePath
                            with ex ->
                                return sprintf "Error formatting file %s: %s" filePath ex.Message
                with ex ->
                    return sprintf "Error accessing file %s: %s" filePath ex.Message
            }

    /// MCP Build and Deployment Tools
    [<McpServerToolType>]
    type KillMCPServer =

        [<McpServerTool; Description("Kill all MCP server processes")>]
        static member KillAll(fsiService: FsiMcpService) : Task<string> =
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

                        // Kill dotnet processes running FSharp.MCP.DevKit
                        let dotnetProcesses = System.Diagnostics.Process.GetProcessesByName("dotnet")
                        let mutable foundDotnetMcp = false

                        for proc in dotnetProcesses do
                            try
                                let cmdLine = proc.StartInfo.Arguments

                                if cmdLine.Contains("FSharp.MCP.DevKit") then
                                    if not foundDotnetMcp then
                                        output.AppendLine($"\nFound dotnet process(es) running FSharp.MCP.DevKit")
                                        |> ignore

                                        foundDotnetMcp <- true

                                    output.AppendLine($"   - Killing dotnet process ID {proc.Id}") |> ignore
                                    proc.Kill()
                                    proc.WaitForExit(5000) |> ignore
                                    totalKilled <- totalKilled + 1

                                    output.AppendLine($"   ✓ Successfully killed dotnet process ID {proc.Id}")
                                    |> ignore
                            with ex ->
                                output.AppendLine(
                                    $"   ✗ Error checking/killing dotnet process ID {proc.Id}: {ex.Message}"
                                )
                                |> ignore

                        if not foundDotnetMcp then
                            output.AppendLine("\nNo dotnet processes running FSharp.MCP.DevKit found")
                            |> ignore

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


        [<McpServerTool; Description("Delete specific lines from an F# file")>]
        static member DeleteLines
            (
                fsiService: FsiMcpService,
                [<Description("Path to the target F# file (.fsx, .fs, .fsi)")>] filePath: string,
                [<Description("Starting line number to delete (1-based)")>] startLine: int,
                [<Description("Ending line number to delete (1-based, inclusive)")>] endLine: int
            ) : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        match validateFSharpFileType filePath with
                        | Error errorMsg -> return errorMsg
                        | Ok() ->

                            let lines = System.IO.File.ReadAllLines(filePath)
                            let totalLines = lines.Length

                            if startLine <= 0 || endLine <= 0 || startLine > totalLines || endLine > totalLines then
                                return
                                    sprintf
                                        "Error: Invalid line range %d-%d. File has %d lines."
                                        startLine
                                        endLine
                                        totalLines
                            elif startLine > endLine then
                                return
                                    sprintf "Error: Start line %d cannot be greater than end line %d." startLine endLine
                            else
                                let beforeLines = lines |> Array.take (startLine - 1)
                                let afterLines = lines |> Array.skip endLine
                                let newContent = Array.concat [ beforeLines; afterLines ]

                                System.IO.File.WriteAllLines(filePath, newContent)
                                let deletedCount = endLine - startLine + 1

                                return
                                    sprintf "Deleted %d lines (%d-%d) from %s" deletedCount startLine endLine filePath

                with ex ->
                    return sprintf "Error deleting lines: %s" ex.Message
            }

        [<McpServerTool; Description("Replace text in a specific line range with new content")>]
        static member ReplaceTextRange
            (
                fsiService: FsiMcpService,
                [<Description("Path to the target script file")>] filePath: string,
                [<Description("Starting line number to replace (1-based)")>] startLine: int,
                [<Description("Ending line number to replace (1-based, inclusive)")>] endLine: int,
                [<Description("New content to replace with")>] newContent: string
            ) : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        let lines = System.IO.File.ReadAllLines(filePath)
                        let totalLines = lines.Length

                        if startLine <= 0 || endLine <= 0 || startLine > totalLines || endLine > totalLines then
                            return
                                sprintf
                                    "Error: Invalid line range %d-%d. File has %d lines."
                                    startLine
                                    endLine
                                    totalLines
                        elif startLine > endLine then
                            return sprintf "Error: Start line %d cannot be greater than end line %d." startLine endLine
                        else
                            let beforeLines = lines |> Array.take (startLine - 1)
                            let afterLines = lines |> Array.skip endLine

                            // FIXED: Preserve empty lines in new content by NOT using RemoveEmptyEntries
                            let newContentLines = splitLinesPreservingLineEndings newContent

                            let newLines = Array.concat [ beforeLines; newContentLines; afterLines ]

                            let finalContent = joinLinesWithConsistentEndings newLines
                            System.IO.File.WriteAllText(filePath, finalContent, System.Text.Encoding.UTF8)
                            let replacedCount = endLine - startLine + 1
                            let addedCount = newContentLines.Length

                            return
                                sprintf
                                    "Replaced %d lines (%d-%d) with %d lines in %s"
                                    replacedCount
                                    startLine
                                    endLine
                                    addedCount
                                    filePath

                with ex ->
                    return sprintf "Error replacing text range: %s" ex.Message
            }

        [<McpServerTool; Description("Search and replace text patterns in a file using string replacement")>]
        static member SearchAndReplace
            (
                fsiService: FsiMcpService,
                [<Description("Path to the target script file")>] filePath: string,
                [<Description("Text pattern to search for")>] searchPattern: string,
                [<Description("Replacement text")>] replacement: string,
                [<Description("Replace all occurrences (default: true)")>] ?replaceAll: bool
            ) : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        let content = System.IO.File.ReadAllText(filePath)
                        let shouldReplaceAll = defaultArg replaceAll true

                        let newContent, replacementCount =
                            if shouldReplaceAll then
                                // Count occurrences before replacing
                                let mutable count = 0
                                let mutable pos = 0

                                while pos < content.Length do
                                    let index = content.IndexOf(searchPattern, pos)

                                    if index >= 0 then
                                        count <- count + 1
                                        pos <- index + searchPattern.Length
                                    else
                                        pos <- content.Length

                                let newContent = content.Replace(searchPattern, replacement)
                                newContent, count
                            else if content.Contains(searchPattern) then
                                let index = content.IndexOf(searchPattern)
                                let before = content.Substring(0, index)
                                let after = content.Substring(index + searchPattern.Length)
                                before + replacement + after, 1
                            else
                                content, 0

                        if replacementCount > 0 then
                            System.IO.File.WriteAllText(filePath, newContent)
                            let mode = if shouldReplaceAll then "all" else "first"

                            return
                                sprintf
                                    "Replaced %d occurrence(s) of '%s' with '%s' (%s mode) in %s"
                                    replacementCount
                                    searchPattern
                                    replacement
                                    mode
                                    filePath
                        else
                            return sprintf "No occurrences of '%s' found in %s" searchPattern filePath

                with ex ->
                    return sprintf "Error during search and replace: %s" ex.Message
            }

        [<McpServerTool; Description("Move a block of code from one location to another within a file")>]
        static member MoveCodeBlock
            (
                fsiService: FsiMcpService,
                [<Description("Path to the target script file")>] filePath: string,
                [<Description("Starting line of code block to move (1-based)")>] fromStartLine: int,
                [<Description("Ending line of code block to move (1-based, inclusive)")>] fromEndLine: int,
                [<Description("Target line number where to insert the moved block (1-based)")>] targetLine: int
            ) : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        let lines = System.IO.File.ReadAllLines(filePath)
                        let totalLines = lines.Length

                        if
                            fromStartLine <= 0
                            || fromEndLine <= 0
                            || fromStartLine > totalLines
                            || fromEndLine > totalLines
                        then
                            return
                                sprintf
                                    "Error: Invalid source range %d-%d. File has %d lines."
                                    fromStartLine
                                    fromEndLine
                                    totalLines
                        elif fromStartLine > fromEndLine then
                            return
                                sprintf
                                    "Error: Start line %d cannot be greater than end line %d."
                                    fromStartLine
                                    fromEndLine
                        elif targetLine <= 0 || targetLine > totalLines + 1 then
                            return sprintf "Error: Invalid target line %d. File has %d lines." targetLine totalLines
                        else
                            // Extract the code block to move
                            let codeBlock =
                                lines
                                |> Array.skip (fromStartLine - 1)
                                |> Array.take (fromEndLine - fromStartLine + 1)

                            // Remove the code block from original position
                            let beforeBlock = lines |> Array.take (fromStartLine - 1)
                            let afterBlock = lines |> Array.skip fromEndLine
                            let linesWithoutBlock = Array.concat [ beforeBlock; afterBlock ]

                            // Adjust target line if it's after the removed block
                            let adjustedTargetLine =
                                if targetLine > fromEndLine then
                                    targetLine - (fromEndLine - fromStartLine + 1)
                                elif targetLine > fromStartLine then
                                    fromStartLine
                                else
                                    targetLine

                            // Insert the code block at the target position
                            let beforeTarget = linesWithoutBlock |> Array.take (adjustedTargetLine - 1)
                            let afterTarget = linesWithoutBlock |> Array.skip (adjustedTargetLine - 1)
                            let finalLines = Array.concat [ beforeTarget; codeBlock; afterTarget ]

                            System.IO.File.WriteAllLines(filePath, finalLines)
                            let blockSize = fromEndLine - fromStartLine + 1

                            return
                                sprintf
                                    "Moved %d lines from %d-%d to line %d in %s"
                                    blockSize
                                    fromStartLine
                                    fromEndLine
                                    adjustedTargetLine
                                    filePath

                with ex ->
                    return sprintf "Error moving code block: %s" ex.Message
            }

        [<McpServerTool; Description("Get specific lines from a file for inspection")>]
        static member GetLines
            (
                fsiService: FsiMcpService,
                [<Description("Path to the target script file")>] filePath: string,
                [<Description("Starting line number (1-based)")>] startLine: int,
                [<Description("Ending line number (1-based, inclusive, optional)")>] ?endLine: int
            ) : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        let lines = System.IO.File.ReadAllLines(filePath)
                        let totalLines = lines.Length
                        let actualEndLine = defaultArg endLine startLine

                        if
                            startLine <= 0
                            || actualEndLine <= 0
                            || startLine > totalLines
                            || actualEndLine > totalLines
                        then
                            return
                                sprintf
                                    "Error: Invalid line range %d-%d. File has %d lines."
                                    startLine
                                    actualEndLine
                                    totalLines
                        elif startLine > actualEndLine then
                            return
                                sprintf
                                    "Error: Start line %d cannot be greater than end line %d."
                                    startLine
                                    actualEndLine
                        else
                            let selectedLines =
                                lines
                                |> Array.skip (startLine - 1)
                                |> Array.take (actualEndLine - startLine + 1)

                            let numberedLines =
                                selectedLines
                                |> Array.mapi (fun i line -> sprintf "%d: %s" (startLine + i) line)

                            let result = String.Join("\n", numberedLines)
                            return sprintf "Lines %d-%d from %s:\n%s" startLine actualEndLine filePath result

                with ex ->
                    return sprintf "Error getting lines: %s" ex.Message
            }

        [<McpServerTool; Description("Count total lines in a file")>]
        static member CountLines
            (fsiService: FsiMcpService, [<Description("Path to the target script file")>] filePath: string)
            : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        let lines = System.IO.File.ReadAllLines(filePath)
                        let totalLines = lines.Length
                        let totalChars = System.IO.File.ReadAllText(filePath).Length
                        return sprintf "File %s has %d lines and %d characters" filePath totalLines totalChars

                with ex ->
                    return sprintf "Error counting lines: %s" ex.Message
            }

        [<McpServerTool; Description("Search for text patterns in an F# file and return line numbers")>]
        static member SearchInFile
            (
                fsiService: FsiMcpService,
                [<Description("Path to the target F# file (.fsx, .fs, .fsi)")>] filePath: string,
                [<Description("Text pattern to search for")>] searchPattern: string,
                [<Description("Case sensitive search (default: false)")>] ?caseSensitive: bool
            ) : Task<string> =
            task {
                try
                    if not (System.IO.File.Exists(filePath)) then
                        return sprintf "Error: File not found: %s" filePath
                    else
                        match validateFSharpFileType filePath with
                        | Error errorMsg -> return errorMsg
                        | Ok() ->

                            let lines = System.IO.File.ReadAllLines(filePath)
                            let isCaseSensitive = defaultArg caseSensitive false

                            let comparison =
                                if isCaseSensitive then
                                    StringComparison.Ordinal
                                else
                                    StringComparison.OrdinalIgnoreCase

                            let matches =
                                lines
                                |> Array.mapi (fun i line -> (i + 1, line))
                                |> Array.filter (fun (_, line) -> line.Contains(searchPattern, comparison))

                            let limitedMatches =
                                if matches.Length > 20 then
                                    matches |> Array.take 20
                                else
                                    matches

                            if limitedMatches.Length > 0 then
                                let matchStrings =
                                    limitedMatches
                                    |> Array.map (fun (lineNum, line) -> sprintf "%d: %s" lineNum (line.Trim()))

                                let result = String.Join("\n", matchStrings)

                                let moreMsg =
                                    if matches.Length > 20 then
                                        "\n... (showing first 20 matches)"
                                    else
                                        ""

                                return
                                    sprintf
                                        "Found %d occurrence(s) of '%s' in %s:%s\n%s"
                                        matches.Length
                                        searchPattern
                                        filePath
                                        moreMsg
                                        result
                            else
                                return sprintf "No occurrences of '%s' found in %s" searchPattern filePath

                with ex ->
                    return sprintf "Error searching in file: %s" ex.Message
            }

        [<McpServerTool>]
        [<Description("Unified code insertion with pre-format, validation, post-format, and atomic write operations for F# files")>]
        static member InsertCode
            (
                fsiService: FsiMcpService,
                [<Description("F# code to insert")>] newCode: string,
                [<Description("Path to the target F# file (.fsx, .fs, .fsi)")>] filePath: string,
                [<Description("Line number where to insert the code (1-based)")>] insertAtLine: int,
                [<Description("Column position for indentation (1-based, optional - if not provided, preserves existing indentation)")>] insertAtColumn:
                    int,
                [<Description("Whether to format the code (default: true)")>] ?shouldFormat: bool,
                [<Description("Whether to validate the code before insertion (default: true)")>] ?shouldValidate: bool
            ) : Task<string> =
            task {
                try
                    let shouldFormat = defaultArg shouldFormat true
                    let shouldValidate = defaultArg shouldValidate true
                    let client = fsiService.GetClient()

                    // Validate file type first
                    match validateFSharpFileType filePath with
                    | Error errorMsg -> return errorMsg
                    | Ok() ->

                        // Step 1: Read existing file content
                        let existingCode =
                            if System.IO.File.Exists(filePath) then
                                System.IO.File.ReadAllText(filePath)
                            else
                                ""

                        // Step 2: Pre-format new code if requested
                        let! preformattedNewCode =
                            if shouldFormat then
                                task {
                                    try
                                        let! formatResult = CodeFormatter.FormatDocumentAsync(false, newCode)
                                        return formatResult.Code
                                    with _ ->
                                        return newCode // Fallback to original if formatting fails
                                }
                            else
                                Task.FromResult(newCode)

                        // Step 3: Validate and combine code safely with optional column positioning
                        let validateAndCombine () =
                            let lines = splitLinesPreservingLineEndings existingCode

                            if insertAtLine <= 0 || insertAtLine > lines.Length + 1 then
                                Error(
                                    sprintf
                                        "Error: Invalid line number %d. File has %d lines."
                                        insertAtLine
                                        lines.Length
                                )
                            else
                                // Split the new code into lines
                                let newCodeLines = splitLinesPreservingLineEndings preformattedNewCode

                                // Apply column positioning/indentation if specified
                                let indentedNewCodeLines =
                                    if insertAtColumn > 1 then
                                        let indent = String.replicate (insertAtColumn - 1) " "

                                        newCodeLines
                                        |> Array.mapi (fun i line ->
                                            if i = 0 then
                                                // First line: preserve any existing indentation in the new code
                                                indent + line.TrimStart()
                                            else if
                                                // Subsequent lines: add the base indent but preserve relative indentation
                                                String.IsNullOrWhiteSpace(line)
                                            then
                                                line // Keep empty lines as-is
                                            else
                                                indent + line)
                                    else
                                        newCodeLines // No column specified, use original indentation

                                // Validate insertion context (but don't fail on it, just warn)
                                let contextWarning =
                                    match validateInsertionContext lines insertAtLine indentedNewCodeLines with
                                    | Error msg -> Some msg
                                    | Ok() -> None

                                let beforeLines = lines |> Array.take (insertAtLine - 1)
                                let afterLines = lines |> Array.skip (insertAtLine - 1)
                                let allLines = Array.concat [ beforeLines; indentedNewCodeLines; afterLines ]
                                let combinedCode = joinLinesWithConsistentEndings allLines

                                Ok(combinedCode, contextWarning)

                        let combinedResult = validateAndCombine ()

                        match combinedResult with
                        | Error errorMsg -> return errorMsg
                        | Ok(combinedCode, contextWarning) ->
                            // Step 4: Validate combined code if requested (but don't fail, just report)
                            let! validationResult =
                                if shouldValidate then
                                    task {
                                        let! parseResult = client.ParseAndCheck(combinedCode)

                                        if not parseResult.IsSuccess then
                                            return sprintf " (validation failed: %s)" parseResult.Errors
                                        else
                                            match parseResult.Diagnostics with
                                            | Some diagnostics ->
                                                let errors =
                                                    diagnostics
                                                    |> Array.filter (fun d -> d.Severity.ToString() = "Error")

                                                let warnings =
                                                    diagnostics
                                                    |> Array.filter (fun d -> d.Severity.ToString() = "Warning")

                                                let infos =
                                                    diagnostics
                                                    |> Array.filter (fun d -> d.Severity.ToString() = "Info")

                                                // Build diagnostic summary (but don't fail on errors)
                                                let parts =
                                                    [ if errors.Length > 0 then
                                                          yield sprintf "%d error(s)" errors.Length
                                                      if warnings.Length > 0 then
                                                          yield sprintf "%d warning(s)" warnings.Length
                                                      if infos.Length > 0 then
                                                          yield sprintf "%d info message(s)" infos.Length ]

                                                if parts.Length > 0 then
                                                    return sprintf " (found %s)" (String.concat ", " parts)
                                                else
                                                    return ""
                                            | None -> return ""
                                    }
                                else
                                    Task.FromResult("")

                            // Combine context warning and validation summary
                            let allWarnings =
                                [ match contextWarning with
                                  | Some warning -> yield sprintf " (context warning: %s)" warning
                                  | None -> ()

                                  if not (String.IsNullOrEmpty(validationResult)) then
                                      yield validationResult ]

                            let combinedDiagnostics = String.concat "" allWarnings

                            // Step 5: Format entire document if requested
                            let! finalCode =
                                if shouldFormat then
                                    task {
                                        try
                                            let! formatResult =
                                                CodeFormatter.FormatDocumentAsync(
                                                    filePath.EndsWith(".fsi"),
                                                    combinedCode
                                                )

                                            return formatResult.Code
                                        with _ ->
                                            return combinedCode // Fallback to unformatted if document formatting fails
                                    }
                                else
                                    Task.FromResult(combinedCode)

                            // Step 6: Atomic write operation with backup
                            let writeFileSafely () =
                                try
                                    let backupPath = filePath + ".backup"
                                    let tempPath = filePath + ".tmp"

                                    // Create backup if file exists
                                    if System.IO.File.Exists(filePath) then
                                        System.IO.File.Copy(filePath, backupPath, true)

                                    // Write to temp file
                                    System.IO.File.WriteAllText(tempPath, finalCode)

                                    // Atomic move
                                    if System.IO.File.Exists(filePath) then
                                        System.IO.File.Delete(filePath)

                                    System.IO.File.Move(tempPath, filePath)

                                    // Clean up backup
                                    if System.IO.File.Exists(backupPath) then
                                        System.IO.File.Delete(backupPath)

                                    Ok()
                                with ex ->
                                    Error ex.Message

                            match writeFileSafely () with
                            | Ok() ->
                                let locationMsg = sprintf "line %d" insertAtLine

                                let columnMsg =
                                    if insertAtColumn > 1 then
                                        sprintf " at column %d" insertAtColumn
                                    else
                                        ""

                                let formatMsg = if shouldFormat then " and formatted" else ""

                                let validationMsg =
                                    if shouldValidate then
                                        " (validated)"
                                    else
                                        " (no validation)"

                                return
                                    sprintf
                                        "Code successfully inserted%s into %s at %s%s%s%s"
                                        formatMsg
                                        filePath
                                        locationMsg
                                        columnMsg
                                        validationMsg
                                        combinedDiagnostics
                            | Error errorMsg -> return sprintf "Failed to write file: %s" errorMsg

                with ex ->
                    return sprintf "Error during unified code insertion: %s" ex.Message
            }

        [<McpServerTool; Description("Restart the F# Interactive session (stop and start fresh, better than reset)")>]
        static member RestartFSISession
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

                let! response = client.Restart(timeout)

                if response.IsSuccess then
                    return "FSI session restarted successfully"
                else
                    let baseError =
                        if String.IsNullOrEmpty(response.Errors) then
                            "Failed to restart FSI session"
                        else
                            $"Error restarting FSI session: {response.Errors}"

                    let errorMessage = formatErrorWithDiagnostics baseError response
                    return errorMessage
            }

// NOTE: Paket integration is currently disabled due to technical limitations
// The Paket dependency manager is not properly registered in FSI despite --compilertool:paket argument
// Full Paket features (GitHub sourcing, file-specific downloads) are not supported
// Use ReferenceNuGetPackage for standard package management instead

// [<McpServerTool;
//   Description("Reference a package using Paket syntax #r \"paket: nuget PackageName\" (fallback to NuGet if Paket not available)")>]
// static member ReferencePaketPackage
//     (
//         fsiService: FsiMcpService,
//         [<Description("Package name (e.g. 'FSharp.Data' or 'Newtonsoft.Json, 4.2.7')")>] packageName: string,
//         [<Description("Timeout in seconds (optional, default: 30)")>] ?timeoutSeconds: int
//     ) : Task<string> =
//     task {
//         let client = fsiService.GetClient()

//         let timeout =
//             match timeoutSeconds with
//             | Some seconds -> TimeSpan.FromSeconds(float seconds)
//             | None -> fsiService.DefaultTimeout

//         let! response = client.ReferencePaketPackage(packageName, timeout)

//         if response.IsSuccess then
//             return $"Package referenced successfully using Paket syntax: {packageName}"
//         else
//             let baseError =
//                 if String.IsNullOrEmpty(response.Errors) then
//                     $"Failed to reference package with Paket: {packageName}"
//                 else
//                     $"Error referencing package with Paket: {response.Errors}"

//             let errorMessage = formatErrorWithDiagnostics baseError response
//             return errorMessage
//     }
