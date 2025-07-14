// Debug script to test FsAutoComplete diagnostics capture
open System
open System.IO

// Add reference to our FsAutoComplete client
#r "nuget: Newtonsoft.Json"
#I "../src/FSharp.MCP.DevKit.FsAutoComplete/bin/Debug/net10.0"
#r "FSharp.MCP.DevKit.FsAutoComplete.dll"

open FSharp.MCP.DevKit.FsAutoComplete

let testClient = new FsAutoCompleteClient()

// Subscribe to diagnostics events
testClient.DiagnosticsReceived.Add(fun args ->
    printfn "=== DIAGNOSTICS RECEIVED ==="
    printfn "URI: %s" args.Uri
    printfn "Diagnostics count: %d" args.Diagnostics.Length

    for diag in args.Diagnostics do
        printfn "  [%A] Line %d: %s" diag.Severity (diag.Range.Start.Line + 1) diag.Message

    printfn "==========================")

// Test the diagnostics capture
async {
    try
        printfn "Starting FsAutoComplete..."

        match! testClient.StartAsync() with
        | Ok _ ->
            printfn "FsAutoComplete started successfully"

            // Initialize with workspace
            match! testClient.InitializeAsync(Some "c:\\Users\\ehotw\\Documents\\GitHub\\FSharp.MCP.DevKit") with
            | Ok _ ->
                printfn "FsAutoComplete initialized"

                // Open a file with errors
                let testFilePath =
                    "c:\\Users\\ehotw\\Documents\\GitHub\\FSharp.MCP.DevKit\\Scripting\\TestErrors.fsx"

                let fileContent = File.ReadAllText(testFilePath)

                let uri =
                    "file:///c:/Users/ehotw/Documents/GitHub/FSharp.MCP.DevKit/Scripting/TestErrors.fsx"

                printfn "Opening file: %s" testFilePath

                match! testClient.DidOpenTextDocumentAsync(uri, fileContent, 1) with
                | Ok _ ->
                    printfn "File opened successfully"

                    // Wait for diagnostics
                    printfn "Waiting for diagnostics..."
                    do! Async.Sleep(5000)

                    // Check last diagnostics
                    match testClient.LastDiagnostics with
                    | Some(diagUri, diags) ->
                        printfn "Last diagnostics found:"
                        printfn "  URI: %s" diagUri
                        printfn "  Count: %d" diags.Length
                    | None -> printfn "No diagnostics captured"

                | Error err -> printfn "Failed to open file: %s" err
            | Error err -> printfn "Failed to initialize: %s" err
        | Error err -> printfn "Failed to start: %s" err
    with ex ->
        printfn "Error: %s" ex.Message
}
|> Async.RunSynchronously

testClient.Dispose()
