module TestDiagnostics

open System
open System.Threading.Tasks
open FSharp.MCP.DevKit.FsAutoComplete

// Simple test to check if diagnostics events are firing
let testDiagnosticsEvents () =
    async {
        let config = FsAutoCompleteWrapperConfig.Default
        let logger = Microsoft.Extensions.Logging.Abstractions.NullLogger<FsAutoCompleteWrapper>.Instance
        let wrapper = new FsAutoCompleteWrapper(config, logger)

        // Subscribe to events
        let mutable receivedEvents = []
        wrapper.WrapperEvents.Add(fun event ->
            receivedEvents <- event :: receivedEvents
            printfn "Received event: %A" event
        )

        // Start wrapper
        let! startResult = wrapper.StartAsync()
        printfn "Start result: %A" startResult

        // Try to open a file with errors
        let filePath = @"c:\Users\ehotw\Documents\GitHub\FSharp.MCP.DevKit\tests\DiagnosticTest.fs"
        let fileContent = System.IO.File.ReadAllText(filePath)

        let openResult = wrapper.DidOpenTextDocument($"file:///{filePath.Replace("\\", "/")}", fileContent, 1)
        printfn "Open result: %A" openResult

        // Wait a bit for diagnostics
        do! Async.Sleep(5000)

        printfn "Total events received: %d" receivedEvents.Length
        for event in List.rev receivedEvents do
            printfn "Event: %A" event

        wrapper.Dispose()
    }

// Run the test
testDiagnosticsEvents() |> Async.RunSynchronously
