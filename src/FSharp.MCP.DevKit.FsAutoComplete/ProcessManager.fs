namespace FSharp.MCP.DevKit.FsAutoComplete

open System
open System.Diagnostics
open System.IO
open System.Threading
open System.Threading.Tasks
open Microsoft.Extensions.Logging

/// Result type for process operations
type ProcessResult<'T> = Result<'T, string>

/// Process health status
type ProcessHealth =
    | Healthy
    | Unhealthy of reason: string
    | Dead

/// Configuration for FsAutoComplete process
type FsAutoCompleteConfig =
    { WorkingDirectory: string option
      EnvironmentVariables: Map<string, string>
      Arguments: string[]
      StartupTimeout: TimeSpan
      HealthCheckInterval: TimeSpan
      MaxRestartAttempts: int
      RestartDelay: TimeSpan }

    static member Default =
        { WorkingDirectory = None
          EnvironmentVariables = Map.empty
          Arguments = [||]
          StartupTimeout = TimeSpan.FromSeconds(30.0)
          HealthCheckInterval = TimeSpan.FromSeconds(5.0)
          MaxRestartAttempts = 3
          RestartDelay = TimeSpan.FromSeconds(2.0) }

/// Events emitted by the process manager
type ProcessManagerEvent =
    | ProcessStarted of processId: int
    | ProcessExited of exitCode: int * reason: string
    | ProcessRestarted of attempt: int * maxAttempts: int
    | ProcessFailed of error: string
    | HealthCheckFailed of reason: string

/// Manages the FsAutoComplete process lifecycle
type ProcessManager(config: FsAutoCompleteConfig, logger: ILogger) =
    let mutable currentProcess: Process option = None
    let mutable restartAttempts = 0
    let mutable isDisposed = false
    let mutable healthCheckCts: CancellationTokenSource option = None

    // Events
    let processEvents = Event<ProcessManagerEvent>()

    /// Event fired when process state changes
    [<CLIEvent>]
    member _.ProcessEvents = processEvents.Publish

    /// Current process health status
    member _.Health =
        match currentProcess with
        | Some proc when not proc.HasExited -> Healthy
        | Some proc -> Dead
        | None -> Dead

    /// Whether the process is currently running
    member _.IsRunning =
        match currentProcess with
        | Some proc -> not proc.HasExited
        | None -> false

    /// Current process ID (if running)
    member _.ProcessId =
        currentProcess
        |> Option.bind (fun p -> if not p.HasExited then Some p.Id else None)

    /// Standard input stream (if process is running)
    member _.StandardInput =
        currentProcess
        |> Option.bind (fun p -> if not p.HasExited then Some p.StandardInput else None)

    /// Standard output stream (if process is running)
    member _.StandardOutput =
        currentProcess
        |> Option.bind (fun p -> if not p.HasExited then Some p.StandardOutput else None)

    /// Standard error stream (if process is running)
    member _.StandardError =
        currentProcess
        |> Option.bind (fun p -> if not p.HasExited then Some p.StandardError else None)

    /// Start the FsAutoComplete process
    member this.StartAsync(?cancellationToken: CancellationToken) =
        async {
            if isDisposed then
                return Error "ProcessManager has been disposed"
            else
                let ct = defaultArg cancellationToken CancellationToken.None

                if ct.IsCancellationRequested then
                    return Error "Start operation was cancelled"
                else
                    try
                        // Stop any existing process first
                        let! stopResult = this.StopAsync(ct)

                        match stopResult with
                        | Ok _ -> ()
                        | Error err -> logger.LogWarning("Error stopping existing process: {Error}", err)

                        // Check cancellation after stopping existing process
                        if ct.IsCancellationRequested then
                            return Error "Start operation was cancelled"
                        else
                            logger.LogInformation("Starting FsAutoComplete process...")

                            let startInfo = ProcessStartInfo()
                            startInfo.FileName <- "fsautocomplete"
                            startInfo.Arguments <- String.concat " " config.Arguments
                            startInfo.UseShellExecute <- false
                            startInfo.RedirectStandardInput <- true
                            startInfo.RedirectStandardOutput <- true
                            startInfo.RedirectStandardError <- true
                            startInfo.CreateNoWindow <- true

                            // Set working directory if specified
                            config.WorkingDirectory
                            |> Option.iter (fun wd -> startInfo.WorkingDirectory <- wd)

                            // Set environment variables
                            config.EnvironmentVariables
                            |> Map.iter (fun key value -> startInfo.EnvironmentVariables.[key] <- value)

                            let proc = Process.Start(startInfo)

                            if proc = null then
                                return Error "Failed to start FsAutoComplete process"
                            else
                                currentProcess <- Some proc
                                restartAttempts <- 0

                                // Set up process exit handler
                                proc.EnableRaisingEvents <- true
                                proc.Exited.Add(fun _ -> this.HandleProcessExit(proc))

                                // For LSP servers, we don't need to wait for completion - just verify startup
                                if proc.HasExited then
                                    return Error $"Process exited immediately with code {proc.ExitCode}"
                                else
                                    // Give the process a brief moment to stabilize
                                    do! Async.Sleep(200)

                                    // Check if cancelled or process died during startup
                                    if ct.IsCancellationRequested then
                                        try
                                            if not proc.HasExited then
                                                proc.Kill()
                                                proc.Dispose()

                                            currentProcess <- None
                                        with _ ->
                                            ()

                                        return Error "Start operation was cancelled"
                                    elif proc.HasExited then
                                        return Error $"Process exited during startup with code {proc.ExitCode}"
                                    else
                                        logger.LogInformation(
                                            "FsAutoComplete process started successfully, PID: {ProcessId}",
                                            proc.Id
                                        )

                                        processEvents.Trigger(ProcessStarted proc.Id)

                                        // Start health monitoring
                                        this.StartHealthMonitoring(ct)

                                        return Ok proc.Id

                    with ex ->
                        logger.LogError(ex, "Exception starting FsAutoComplete process")
                        return Error $"Exception starting FsAutoComplete: {ex.Message}"
        }

    /// Stop the FsAutoComplete process
    member this.StopAsync(?cancellationToken: CancellationToken) : Async<Result<unit, string>> =
        async {
            let ct = defaultArg cancellationToken CancellationToken.None

            // Stop health monitoring
            healthCheckCts |> Option.iter (fun cts -> cts.Cancel())
            healthCheckCts <- None

            match currentProcess with
            | Some proc ->
                try
                    if not proc.HasExited then
                        logger.LogInformation("Stopping FsAutoComplete process {ProcessId}...", proc.Id)

                        // Try graceful shutdown first
                        try
                            proc.StandardInput.Close()
                            let! exited = this.WaitForExit(proc, TimeSpan.FromSeconds(5.0), ct)

                            if not exited then
                                logger.LogWarning("Process did not exit gracefully, killing...")
                                proc.Kill()
                                let! _ = this.WaitForExit(proc, TimeSpan.FromSeconds(5.0), ct)
                                ()
                        with ex ->
                            logger.LogWarning(ex, "Error during graceful shutdown, killing process")
                            proc.Kill()

                    proc.Dispose()
                    currentProcess <- None
                    logger.LogInformation("FsAutoComplete process stopped")

                    return Ok()

                with ex ->
                    logger.LogError(ex, "Exception stopping FsAutoComplete process")
                    return Error ex.Message
            | None -> return Ok()
        }

    /// Restart the FsAutoComplete process
    member this.RestartAsync(?cancellationToken: CancellationToken) =
        async {
            let ct = defaultArg cancellationToken CancellationToken.None

            if restartAttempts >= config.MaxRestartAttempts then
                let msg = $"Maximum restart attempts ({config.MaxRestartAttempts}) exceeded"
                logger.LogError(msg)
                processEvents.Trigger(ProcessFailed msg)
                return Error msg
            else
                restartAttempts <- restartAttempts + 1

                logger.LogInformation(
                    "Restarting FsAutoComplete process (attempt {Attempt}/{MaxAttempts})",
                    restartAttempts,
                    config.MaxRestartAttempts
                )

                processEvents.Trigger(ProcessRestarted(restartAttempts, config.MaxRestartAttempts))

                do! Async.Sleep(int config.RestartDelay.TotalMilliseconds)

                return! this.StartAsync(ct)
        }

    /// Wait for process to exit
    member private this.WaitForExit(proc: Process, timeout: TimeSpan, ct: CancellationToken) =
        async {
            let endTime = DateTime.UtcNow.Add(timeout)

            while DateTime.UtcNow < endTime
                  && not ct.IsCancellationRequested
                  && not proc.HasExited do
                do! Async.Sleep(100)

            return proc.HasExited
        }

    /// Handle process exit event
    member private this.HandleProcessExit(proc: Process) =
        let exitCode = proc.ExitCode

        let reason =
            if exitCode = 0 then
                "Normal exit"
            else
                $"Exit code: {exitCode}"

        logger.LogWarning("FsAutoComplete process exited: {Reason}", reason)
        processEvents.Trigger(ProcessExited(exitCode, reason))

        // Attempt automatic restart if not disposed and not at max attempts
        if not isDisposed && restartAttempts < config.MaxRestartAttempts then
            Task.Run<unit>(fun () ->
                async {
                    let! result = this.RestartAsync()

                    match result with
                    | Ok _ -> ()
                    | Error err -> logger.LogError("Failed to restart process: {Error}", err)
                }
                |> Async.StartAsTask)
            |> ignore

    /// Start health monitoring
    member private this.StartHealthMonitoring(ct: CancellationToken) =
        let cts = CancellationTokenSource.CreateLinkedTokenSource(ct)
        healthCheckCts <- Some cts

        let healthCheckLoop () =
            async {
                while not cts.Token.IsCancellationRequested do
                    try
                        match this.Health with
                        | Healthy -> ()
                        | Unhealthy reason ->
                            logger.LogWarning("Health check failed: {Reason}", reason)
                            processEvents.Trigger(HealthCheckFailed reason)
                        | Dead ->
                            logger.LogError("Process is dead")
                            processEvents.Trigger(HealthCheckFailed "Process is dead")

                        do! Async.Sleep(int config.HealthCheckInterval.TotalMilliseconds)
                    with ex ->
                        logger.LogError(ex, "Error during health check")
                        do! Async.Sleep(int config.HealthCheckInterval.TotalMilliseconds)
            }

        Async.Start(healthCheckLoop (), cts.Token)

    interface IDisposable with
        member this.Dispose() =
            if not isDisposed then
                isDisposed <- true

                // Stop health monitoring
                healthCheckCts |> Option.iter (fun cts -> cts.Cancel())

                // Stop process
                this.StopAsync() |> Async.RunSynchronously |> ignore

    /// Public dispose method for explicit cleanup
    member this.Dispose() = (this :> IDisposable).Dispose()
