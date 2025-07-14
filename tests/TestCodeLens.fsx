#r "nuget: Microsoft.Extensions.Logging, 9.0.0"
#load "../src/FSharp.MCP.DevKit.Server/McpFsAutoCompleteTools.fs"

open System
open System.IO
open Microsoft.Extensions.Logging

// Create a simple logger
let loggerFactory = LoggerFactory.Create(fun builder ->
    builder.AddConsole().SetMinimumLevel(LogLevel.Debug) |> ignore
)

let logger = loggerFactory.CreateLogger("CodeLensTest")

// Test function
let testCodeLensFeature () = async {
    try
        printfn "🧪 Testing CodeLens functionality..."

        // Start FsAutoComplete with workspace support
        let workspaceRoot = __SOURCE_DIRECTORY__
        printfn "📁 Using workspace root: %s" workspaceRoot

        let! startResult = FSharp.MCP.DevKit.Server.FsAutoCompleteService.startWithWorkspace workspaceRoot true 60

        match startResult with
        | Ok() ->
            printfn "✅ FsAutoComplete started successfully"

            // Test file path
            let testFile = Path.Combine(__SOURCE_DIRECTORY__, "test_codelens.fs")
            printfn "📄 Testing with file: %s" testFile

            // Test CodeLens request
            let! codeLensResult = FSharp.MCP.DevKit.Server.FsAutoCompleteService.getCodeLens testFile 30

            match codeLensResult with
            | Ok(lenses) ->
                printfn "🎯 Got %d CodeLens items" (Array.length lenses)

                if Array.length lenses > 0 then
                    for i, lens in Array.indexed lenses do
                        printfn "  Lens %d:" i
                        printfn "    Range: Line %d, Col %d-%d"
                            lens.Range.Start.Line
                            lens.Range.Start.Character
                            lens.Range.End.Character

                        match lens.Command with
                        | Some cmd ->
                            printfn "    Command: %s" cmd.Title
                        | None ->
                            printfn "    No command (needs resolve)"

                            // Try to resolve this lens
                            let! resolveResult = FSharp.MCP.DevKit.Server.FsAutoCompleteService.resolveCodeLens testFile i 30

                            match resolveResult with
                            | Ok(resolved) ->
                                match resolved.Command with
                                | Some cmd -> printfn "    Resolved: %s" cmd.Title
                                | None -> printfn "    Still no command after resolve"
                            | Error(err) ->
                                printfn "    Resolve failed: %s" err
                else
                    printfn "⚠️  No CodeLens items returned. This might indicate:"
                    printfn "    - CodeLens is not properly configured"
                    printfn "    - The file doesn't have eligible symbols"
                    printfn "    - FsAutoComplete doesn't support CodeLens for this setup"

            | Error(err) ->
                printfn "❌ CodeLens request failed: %s" err

        | Error(err) ->
            printfn "❌ Failed to start FsAutoComplete: %s" err

    with
    | ex ->
        printfn "💥 Exception: %s" ex.Message
        printfn "Stack trace: %s" ex.StackTrace
}

// Run the test
printfn "🚀 Starting CodeLens test..."
testCodeLensFeature() |> Async.RunSynchronously
printfn "✨ Test completed!"
