namespace FSharp.MCP.DevKit.Core

open System
open System.IO
open System.Text
open System.Threading
open System.Threading.Tasks
open System.Reflection
open FSharp.Compiler.Interactive.Shell
open FSharp.Compiler.Diagnostics


/// Represents the result of an FSI evaluation
type FsiResult =
    { Output: string
      Errors: string
      IsSuccess: bool
      Value: obj option
      ExecutionTime: TimeSpan option
      Diagnostics: FSharpDiagnostic[] }

/// Configuration for the FSI session
type FsiConfig =
    {
        /// Working directory for the FSI session
        WorkingDirectory: string option
        /// Additional command line arguments
        Arguments: string list
        /// Timeout for operations (default: 30 seconds)
        Timeout: TimeSpan
        /// Whether to capture timing information
        CaptureTimings: bool
        /// Whether to make generated code collectible (for memory efficiency)
        Collectible: bool
        /// Whether to use non-interactive mode
        NonInteractive: bool
        /// Whether to suppress logo and startup messages
        NoLogo: bool
        /// Whether to enable Paket dependency manager integration
        EnablePaket: bool
        /// FSI print settings
        PrintSize: int option
        PrintLength: int option
        PrintDepth: int option
        PrintWidth: int option
    }

/// Default FSI configuration
module FsiConfig =
    let defaultConfig =
        { WorkingDirectory = None
          Arguments = []
          Timeout = TimeSpan.FromSeconds(30.0)
          CaptureTimings = false
          Collectible = false
          NonInteractive = true
          NoLogo = true
          EnablePaket = true // Enable Paket by default
          PrintSize = Some 1000000
          PrintLength = Some 10000000
          PrintDepth = Some 200
          PrintWidth = Some 2000 }

/// FSI Service wrapper class using F# Compiler Services
type FsiService(config: FsiConfig) =
    let mutable fsiSession: FsiEvaluationSession option = None
    let mutable isStarted = false
    let mutable isDisposed = false
    let mutable outStream: StringWriter option = None
    let mutable errStream: StringWriter option = None
    let mutable sbOut: StringBuilder option = None
    let mutable sbErr: StringBuilder option = None

    /// Start the FSI session
    member this.Start() =
        if isStarted then
            failwith "FSI session is already started"

        try
            // Initialize output and input streams
            let sbOutNew = new StringBuilder()
            let sbErrNew = new StringBuilder()
            let inStream = new StringReader("")
            let outStreamNew = new StringWriter(sbOutNew)
            let errStreamNew = new StringWriter(sbErrNew)

            sbOut <- Some sbOutNew
            sbErr <- Some sbErrNew
            outStream <- Some outStreamNew
            errStream <- Some errStreamNew

            // Build command line arguments (including print settings for hosted FSI sessions)
            let fsiArgs =
                [ if config.NonInteractive then
                      Some "--noninteractive"
                  else
                      None
                  if config.NoLogo then Some "--nologo" else None
                  // Enable Paket dependency manager if requested
                  if config.EnablePaket then
                      Some "--compilertool:paket"
                  else
                      None
                  // Note: FSI hosted sessions have limited support for print settings via command line
                  // These arguments may not work as expected in hosted environments
                  config.PrintSize |> Option.map (fun size -> $"--define:FSI_PRINTSIZE={size}")
                  config.PrintLength
                  |> Option.map (fun length -> $"--define:FSI_PRINTLENGTH={length}") ]
                |> List.choose id

            let allArgs = "fsi.exe" :: fsiArgs @ config.Arguments
            let argv = Array.ofList allArgs

            // Debug: Print the command line arguments being used
            printfn "FSI Command line arguments: %A" argv

            // Get FSI configuration
            let fsiConfig: FsiEvaluationSessionHostConfig =
                FsiEvaluationSession.GetDefaultConfiguration()

            // Set working directory if specified
            match config.WorkingDirectory with
            | Some dir -> Environment.CurrentDirectory <- dir
            | None -> ()

            // Create FSI session
            let session =
                FsiEvaluationSession.Create(
                    fsiConfig,
                    argv,
                    inStream,
                    outStreamNew,
                    errStreamNew,
                    collectible = config.Collectible
                )

            fsiSession <- Some session
            isStarted <- true



        with ex ->
            failwith $"Failed to start FSI session: {ex.Message}"

    /// Get current output and clear buffers
    member private this.GetAndClearOutput() =
        let rawOutput =
            match sbOut with
            | Some sb ->
                let result = sb.ToString()
                sb.Clear() |> ignore
                result
            | None -> ""

        let errors =
            match sbErr with
            | Some sb ->
                let result = sb.ToString()
                sb.Clear() |> ignore
                result
            | None -> ""

        (rawOutput, errors)

    /// Execute F# code using EvalInteraction (for statements, declarations, directives)
    member this.ExecuteInteraction(code: string) : FsiResult =
        if not isStarted then
            failwith "FSI session not started. Call Start() first."

        match fsiSession with
        | None -> failwith "FSI session not available"
        | Some session ->
            let startTime = DateTime.Now

            try
                let _, checkResults, _ = session.ParseAndCheckInteraction(code)
                let diagnostics = checkResults.Diagnostics

                let hasErrors =
                    diagnostics
                    |> Array.exists (fun d -> d.Severity = FSharpDiagnosticSeverity.Error)

                if hasErrors then
                    let (output, errors) = this.GetAndClearOutput()

                    { Output = output
                      Errors = errors
                      IsSuccess = false
                      Value = None
                      ExecutionTime =
                        if config.CaptureTimings then
                            Some(DateTime.Now - startTime)
                        else
                            None
                      Diagnostics = diagnostics }
                else
                    session.EvalInteraction(code)
                    let (output, errors) = this.GetAndClearOutput()
                    let success = String.IsNullOrEmpty(errors) && not hasErrors

                    { Output = output
                      Errors = errors
                      IsSuccess = success
                      Value = None
                      ExecutionTime =
                        if config.CaptureTimings then
                            Some(DateTime.Now - startTime)
                        else
                            None
                      Diagnostics = diagnostics }
            with ex ->
                let (output, errors) = this.GetAndClearOutput()

                { Output = output
                  Errors = errors + "" + ex.Message
                  IsSuccess = false
                  Value = None
                  ExecutionTime =
                    if config.CaptureTimings then
                        Some(DateTime.Now - startTime)
                    else
                        None
                  Diagnostics = [||] }

    /// Evaluate F# expression and return its value
    member this.EvaluateExpression(expression: string) : FsiResult =
        if not isStarted then
            failwith "FSI session not started. Call Start() first."

        match fsiSession with
        | None -> failwith "FSI session not available"
        | Some session ->
            let startTime = DateTime.Now

            try
                let _, checkResults, _ = session.ParseAndCheckInteraction(expression)
                let diagnostics = checkResults.Diagnostics

                let hasErrors =
                    diagnostics
                    |> Array.exists (fun d -> d.Severity = FSharpDiagnosticSeverity.Error)

                if hasErrors then
                    let (output, errors) = this.GetAndClearOutput()

                    { Output = output
                      Errors = errors
                      IsSuccess = false
                      Value = None
                      ExecutionTime =
                        if config.CaptureTimings then
                            Some(DateTime.Now - startTime)
                        else
                            None
                      Diagnostics = diagnostics }
                else
                    let result = session.EvalExpression(expression)
                    let (output, errors) = this.GetAndClearOutput()
                    let value = result |> Option.map (fun v -> v.ReflectionValue)
                    let success = String.IsNullOrEmpty(errors) && not hasErrors

                    { Output = output
                      Errors = errors
                      IsSuccess = success
                      Value = value
                      ExecutionTime =
                        if config.CaptureTimings then
                            Some(DateTime.Now - startTime)
                        else
                            None
                      Diagnostics = diagnostics }
            with ex ->
                let (output, errors) = this.GetAndClearOutput()

                { Output = output
                  Errors = errors + "" + ex.Message
                  IsSuccess = false
                  Value = None
                  ExecutionTime =
                    if config.CaptureTimings then
                        Some(DateTime.Now - startTime)
                    else
                        None
                  Diagnostics = [||] }

    /// Execute an F# script from a file
    member this.ExecuteScript(filePath: string, ?cancellationToken: CancellationToken) : Task<FsiResult> =
        task {
            if not isStarted then
                return
                    { Output = ""
                      Errors = "FSI session not started. Call Start() first."
                      IsSuccess = false
                      Value = None
                      ExecutionTime = None
                      Diagnostics = [||] }
            else
                let token = cancellationToken |> Option.defaultValue CancellationToken.None
                use cts = CancellationTokenSource.CreateLinkedTokenSource(token)
                cts.CancelAfter(config.Timeout)

                match fsiSession with
                | None ->
                    return
                        { Output = ""
                          Errors = "FSI session not available"
                          IsSuccess = false
                          Value = None
                          ExecutionTime = None
                          Diagnostics = [||] }
                | Some session ->
                    let stopwatch = System.Diagnostics.Stopwatch.StartNew()

                    try
                        let! (result, diagnostics) =
                            Task.Run((fun () -> session.EvalScriptNonThrowing(filePath)), cts.Token)

                        stopwatch.Stop()

                        let executionTime =
                            if config.CaptureTimings then
                                Some stopwatch.Elapsed
                            else
                                None

                        let (output, errors) = this.GetAndClearOutput()

                        match result with
                        | Choice1Of2() ->
                            let hasErrors =
                                diagnostics
                                |> Array.exists (fun d -> d.Severity = FSharpDiagnosticSeverity.Error)

                            return
                                { Output = output
                                  Errors = errors
                                  IsSuccess = not hasErrors
                                  Value = None
                                  ExecutionTime = executionTime
                                  Diagnostics = diagnostics }
                        | Choice2Of2 ex ->
                            return
                                { Output = output
                                  Errors = errors + "" + ex.Message
                                  IsSuccess = false
                                  Value = None
                                  ExecutionTime = executionTime
                                  Diagnostics = diagnostics }
                    with
                    | :? OperationCanceledException as ex ->
                        stopwatch.Stop()
                        let (output, errors) = this.GetAndClearOutput()

                        return
                            { Output = output
                              Errors = errors + "" + ex.Message
                              IsSuccess = false
                              Value = None
                              ExecutionTime =
                                if config.CaptureTimings then
                                    Some stopwatch.Elapsed
                                else
                                    None
                              Diagnostics = [||] }
                    | ex ->
                        stopwatch.Stop()
                        let (output, errors) = this.GetAndClearOutput()

                        return
                            { Output = output
                              Errors = errors + "" + ex.Message
                              IsSuccess = false
                              Value = None
                              ExecutionTime =
                                if config.CaptureTimings then
                                    Some stopwatch.Elapsed
                                else
                                    None
                              Diagnostics = [||] }
        }

    /// Execute F# code (alias for ExecuteInteraction for backward compatibility)
    member this.Execute(code: string, ?cancellationToken: CancellationToken) : Task<FsiResult> =
        let token = cancellationToken |> Option.defaultValue CancellationToken.None
        this.ExecuteInteractionAsync(code, token)

    /// Reference a NuGet package using #r "nuget:" directive
    member this.ReferenceNugetPackage(packageName: string, ?version: string, ?usePackageTargets: bool) : FsiResult =
        let versionPart =
            match version with
            | Some v -> $",{v}"
            | None -> ""

        let targetsPart =
            match usePackageTargets with
            | Some true -> ",usepackagetargets=true"
            | Some false -> ",usepackagetargets=false"
            | None -> ""

        let refCommand = $"#r \"nuget:{packageName}{versionPart}{targetsPart}\""
        this.ExecuteInteraction(refCommand)

    // /// Reference a package using Paket syntax (fallback to NuGet if Paket not available)
    // /// NOTE: Currently disabled - Paket dependency manager not properly registered in FSI
    // member this.ReferencePaketPackage(packageName: string) : FsiResult =
    //     // Parse packageName for version if provided (e.g., "Newtonsoft.Json, 13.0.3")
    //     let (name, version) =
    //         if packageName.Contains(",") then
    //             let parts = packageName.Split([| ',' |], 2)
    //             let name = parts.[0].Trim()
    //             let version = if parts.Length > 1 then Some(parts.[1].Trim()) else None
    //             (name, version)
    //         else
    //             (packageName.Trim(), None)

    //     // Try Paket syntax first, fallback to NuGet if it fails
    //     let versionPart =
    //         match version with
    //         | Some v -> $", {v}"
    //         | None -> ""

    //     let paketCommand = $"#r \"paket: nuget {name}{versionPart}\""
    //     let result = this.ExecuteInteraction(paketCommand)

    //     if not result.IsSuccess then
    //         // Fallback to regular NuGet syntax
    //         printfn "Paket syntax failed, falling back to NuGet syntax"
    //         this.ReferenceNugetPackage(name, ?version = version)
    //     else
    //         result

    /// Reference an assembly file using #r directive
    member this.ReferenceAssembly(assemblyPath: string) : FsiResult =
        let refCommand = $"#r \"{assemblyPath}\""
        this.ExecuteInteraction(refCommand)

    /// Add an assembly search path using #I directive
    member this.AddSearchPath(path: string) : FsiResult =
        let pathCommand = $"#I \"{path}\""
        this.ExecuteInteraction(pathCommand)

    /// Get help for a function using #help directive
    member this.GetHelp(?functionName: string) : FsiResult =
        let helpCommand =
            match functionName with
            | Some fn -> $"#help {fn}"
            | None -> "#help"

        this.ExecuteInteraction(helpCommand)

    /// Enable or disable timing information using #time directive
    member this.SetTiming(enabled: bool) : FsiResult =
        let timeCommand = if enabled then "#time \"on\"" else "#time \"off\""
        this.ExecuteInteraction(timeCommand)

    /// Reset the FSI session (dispose and recreate)
    member this.Reset() : unit =
        this.Stop()
        Thread.Sleep(1000) // Give it a moment
        this.Start()

    /// Restart the FSI session (stop and start again)
    member this.Restart() =
        if isStarted then
            this.Stop()

        this.Start()


    /// Send raw input to FSI (useful for multi-line input or special cases)
    member this.SendRawInput(input: string) : FsiResult = this.ExecuteInteraction(input)

    /// Get current FSI state information
    member this.GetState() : string =
        try
            // Get basic information about the FSI state
            let assembliesResult =
                this.EvaluateExpression(
                    "System.AppDomain.CurrentDomain.GetAssemblies() |> Array.map (fun a -> a.GetName().Name) |> Array.length"
                )

            let assemblyCount =
                if assembliesResult.IsSuccess then
                    assembliesResult.Output
                else
                    "Unknown"

            // Try to get some bound values count (this is approximate)
            let bindingsResult =
                this.EvaluateExpression(
                    "let mutable count = 0 in System.AppDomain.CurrentDomain.GetAssemblies() |> Array.iter (fun _ -> count <- count + 1); count"
                )

            let bindingsInfo =
                if bindingsResult.IsSuccess then
                    bindingsResult.Output
                else
                    "Unknown"

            $"FSI Session State:\n- Loaded Assemblies: {assemblyCount}\n- Session Active: {isStarted}\n- Bindings Info: {bindingsInfo}"
        with ex ->
            $"Error getting FSI state: {ex.Message}"

    /// Parse and check F# code in the current FSI context
    /// Note: Complex compiler objects (AST, type info) removed from Value field to prevent JSON serialization issues
    member this.ParseAndCheck(code: string) : FsiResult =
        if not isStarted then
            failwith "FSI session not started. Call Start() first."

        match fsiSession with
        | None -> failwith "FSI session not available"
        | Some session ->
            try
                // Use a timeout to prevent hanging
                use cts = new CancellationTokenSource(TimeSpan.FromSeconds(30.0))

                let task =
                    Task.Run(fun () ->
                        let parseResults, checkResults, _checkProjectResults =
                            session.ParseAndCheckInteraction(code)

                        (parseResults, checkResults))

                if task.Wait(30000) then // 30 second timeout
                    let parseResults, checkResults = task.Result
                    let diagnostics = checkResults.Diagnostics

                    let hasErrors =
                        diagnostics
                        |> Array.exists (fun d -> d.Severity = FSharpDiagnosticSeverity.Error)

                    { Output =
                        $"Parse completed successfully. Check results: {checkResults.HasFullTypeCheckInfo}. Diagnostics: {diagnostics.Length}"
                      Errors = String.Join("\n", diagnostics |> Array.map (fun d -> $"{d.Severity}: {d.Message}"))
                      IsSuccess = not hasErrors
                      Value = None // Don't serialize complex compiler objects
                      ExecutionTime = None
                      Diagnostics = diagnostics }
                else
                    cts.Cancel()

                    { Output = ""
                      Errors = "Parse and check operation timed out after 30 seconds"
                      IsSuccess = false
                      Value = None
                      ExecutionTime = None
                      Diagnostics = [||] }
            with
            | :? OperationCanceledException ->
                { Output = ""
                  Errors = "Parse and check operation was cancelled due to timeout"
                  IsSuccess = false
                  Value = None
                  ExecutionTime = None
                  Diagnostics = [||] }
            | ex ->
                { Output = ""
                  Errors = ex.Message
                  IsSuccess = false
                  Value = None
                  ExecutionTime = None
                  Diagnostics = [||] }

    /// Check if the FSI session is running
    member this.IsRunning = isStarted && not isDisposed

    /// Stop the FSI session
    member this.Stop() =
        if isStarted then
            match fsiSession with
            | Some session ->
                try
                    (session :> IDisposable).Dispose()
                with _ ->
                    ()

                fsiSession <- None
            | None -> ()

            // Dispose streams
            match outStream with
            | Some stream ->
                try
                    stream.Dispose()
                with _ ->
                    ()

                outStream <- None
            | None -> ()

            match errStream with
            | Some stream ->
                try
                    stream.Dispose()
                with _ ->
                    ()

                errStream <- None
            | None -> ()

            sbOut <- None
            sbErr <- None
            isStarted <- false

    /// Execute F# code and capture the result
    member this.ExecuteInteractionAsync(code: string, cancellationToken: CancellationToken) : Task<FsiResult> =
        task {
            if not isStarted || isDisposed then
                return
                    { Output = ""
                      Errors = "FSI session not started or has been disposed."
                      IsSuccess = false
                      Value = None
                      ExecutionTime = None
                      Diagnostics = [||] }
            else
                let stopwatch = System.Diagnostics.Stopwatch.StartNew()
                let session = fsiSession.Value

                try
                    this.GetAndClearOutput() |> ignore

                    let _, checkResults, _ = session.ParseAndCheckInteraction(code)
                    let initialDiagnostics = checkResults.Diagnostics

                    let hasParseErrors =
                        initialDiagnostics
                        |> Array.exists (fun d -> d.Severity = FSharpDiagnosticSeverity.Error)

                    if hasParseErrors then
                        stopwatch.Stop()
                        let (output, errors) = this.GetAndClearOutput()

                        return
                            { Output = output
                              Errors = errors
                              IsSuccess = false
                              Value = None
                              ExecutionTime =
                                if config.CaptureTimings then
                                    Some stopwatch.Elapsed
                                else
                                    None
                              Diagnostics = initialDiagnostics }
                    else
                        let! (choice, executionDiagnostics) =
                            Task.Run((fun () -> session.EvalInteractionNonThrowing(code)), cancellationToken)

                        stopwatch.Stop()
                        let (output, errors) = this.GetAndClearOutput()

                        let _, postCheckResults, _ = session.ParseAndCheckInteraction("")
                        let postDiagnostics = postCheckResults.Diagnostics

                        let allDiagnostics =
                            Array.concat [ initialDiagnostics; executionDiagnostics; postDiagnostics ]

                        match choice with
                        | Choice1Of2 _ ->
                            let hasExecutionErrors =
                                postDiagnostics
                                |> Array.exists (fun d -> d.Severity = FSharpDiagnosticSeverity.Error)

                            return
                                { Output = output
                                  Errors = errors
                                  IsSuccess = String.IsNullOrEmpty(errors) && not hasExecutionErrors
                                  Value = None
                                  ExecutionTime =
                                    if config.CaptureTimings then
                                        Some stopwatch.Elapsed
                                    else
                                        None
                                  Diagnostics = allDiagnostics }
                        | Choice2Of2 ex ->
                            return
                                { Output = output
                                  Errors = errors + "" + ex.Message
                                  IsSuccess = false
                                  Value = None
                                  ExecutionTime =
                                    if config.CaptureTimings then
                                        Some stopwatch.Elapsed
                                    else
                                        None
                                  Diagnostics = allDiagnostics }
                with
                | :? OperationCanceledException as ex ->
                    stopwatch.Stop()
                    let (output, errors) = this.GetAndClearOutput()

                    return
                        { Output = output
                          Errors = errors + "" + ex.Message
                          IsSuccess = false
                          Value = None
                          ExecutionTime =
                            if config.CaptureTimings then
                                Some stopwatch.Elapsed
                            else
                                None
                          Diagnostics = [||] }
                | ex ->
                    stopwatch.Stop()
                    let (output, errors) = this.GetAndClearOutput()

                    return
                        { Output = output
                          Errors = errors + "" + ex.Message
                          IsSuccess = false
                          Value = None
                          ExecutionTime =
                            if config.CaptureTimings then
                                Some stopwatch.Elapsed
                            else
                                None
                          Diagnostics = [||] }
        }

    /// Parse FSI result to extract diagnostic information
    member this.ParseResult(result: FsiResult) : Map<string, obj> =
        // Extract diagnostics information
        let diagnosticsMap =
            result.Diagnostics
            |> Array.indexed
            |> Array.fold
                (fun (acc: Map<string, obj>) (i, diagnostic) ->
                    let diagKey = $"diagnostic_{i}"

                    let diagInfo =
                        (diagnostic.Severity.ToString(),
                         diagnostic.Message,
                         diagnostic.StartLine,
                         diagnostic.StartColumn)

                    acc.Add(diagKey, box diagInfo))
                Map.empty

        // Add execution metadata
        let withExecutionTime =
            match result.ExecutionTime with
            | Some time -> diagnosticsMap.Add("execution_time", box time)
            | None -> diagnosticsMap

        let withValue =
            match result.Value with
            | Some value -> withExecutionTime.Add("result_value", value)
            | None -> withExecutionTime

        // Add final metadata
        withValue
        |> Map.add "is_success" (box result.IsSuccess)
        |> Map.add "output" (box result.Output)
        |> Map.add "errors" (box result.Errors)

module FsiHelpers =

    /// Create a new FSI service with default configuration
    let createDefault () = new FsiService(FsiConfig.defaultConfig)

    /// Create a new FSI service with custom configuration
    let createWithConfig config = new FsiService(config)

    /// Create FSI service configured for a specific working directory
    let createForDirectory workingDir =
        let config =
            { FsiConfig.defaultConfig with
                WorkingDirectory = Some workingDir }

        new FsiService(config)

    /// Create FSI service with timing enabled
    let createWithTiming () =
        let config =
            { FsiConfig.defaultConfig with
                CaptureTimings = true }

        new FsiService(config)

    /// Create FSI service with collectible code generation
    let createCollectible () =
        let config =
            { FsiConfig.defaultConfig with
                Collectible = true }

        new FsiService(config)
