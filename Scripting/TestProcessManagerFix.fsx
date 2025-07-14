#r "nuget: Microsoft.Extensions.Logging.Abstractions"
#I "c:\\Users\\ehotw\\Documents\\GitHub\\FSharp.MCP.DevKit\\src\\FSharp.MCP.DevKit.FsAutoComplete\\bin\\Debug\\net10.0"
#r "FSharp.MCP.DevKit.FsAutoComplete.dll"

open System
open System.Diagnostics
open System.Threading
open FSharp.MCP.DevKit.FsAutoComplete

// Test the ProcessManager with improved timeout handling
let testProcessManager () =
    let config = FsAutoCompleteConfig.Default

    let logger =
        { new Microsoft.Extensions.Logging.ILogger with
            member _.BeginScope(state) = null
            member _.IsEnabled(level) = true

            member _.Log(level, eventId, state, ex, formatter) =
                printfn $"[{level}] {formatter.Invoke(state, ex)}" }

    use processManager = new ProcessManager(config, logger)

    printfn "Testing ProcessManager with 5 second timeout..."

    use cts = new CancellationTokenSource(TimeSpan.FromSeconds(5.0))

    let result = processManager.StartAsync(cts.Token) |> Async.RunSynchronously

    match result with
    | Result.Ok processId ->
        printfn $"SUCCESS: FsAutoComplete started with PID {processId}"
        printfn "Process should be running in background now."

        // Test if process is still running
        System.Threading.Thread.Sleep(1000)

        if processManager.IsRunning then
            printfn "Process is still running - this is correct for LSP servers"
        else
            printfn "Process has stopped - this might be unexpected"

        // Stop the process
        let stopResult = processManager.StopAsync() |> Async.RunSynchronously

        match stopResult with
        | Result.Ok _ -> printfn "Process stopped successfully"
        | Result.Error err -> printfn $"Error stopping process: {err}"

    | Result.Error err -> printfn $"FAILED: {err}"

testProcessManager ()
