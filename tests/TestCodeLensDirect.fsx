// Minimal CodeLens test - directly test FsAutoComplete
#r "nuget: Microsoft.Extensions.Logging, 9.0.0"
#r "nuget: Microsoft.Extensions.Logging.Console, 9.0.0"
#r "../src/FSharp.MCP.DevKit.FsAutoComplete/bin/Debug/net10.0/FSharp.MCP.DevKit.FsAutoComplete.dll"

open System
open System.IO
open System.Threading
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete

// Create a logger
let loggerFactory = LoggerFactory.Create(fun builder ->
    builder.AddConsole().SetMinimumLevel(LogLevel.Debug) |> ignore
)

let logger = loggerFactory.CreateLogger<FsAutoCompleteWrapper>()

// Test function
let testDirectCodeLens () = async {
    try
        printfn "🧪 Testing CodeLens directly with FsAutoCompleteWrapper..."

        // Configure the wrapper
        let config = FsAutoCompleteWrapperConfig.Default

        // Create wrapper
        use wrapper = new FsAutoCompleteWrapper(config, logger)

        printfn "🚀 Starting FsAutoComplete..."
        let! startResult = wrapper.StartAsync(CancellationToken.None)

        match startResult with
        | Ok() ->
            printfn "✅ FsAutoComplete started successfully"

            // Create a test file URI
            let testFile = Path.Combine(__SOURCE_DIRECTORY__, "tests", "test_codelens.fs")
            let fileUri = $"file:///{testFile.Replace('\\', '/')}"

            printfn "📄 Testing CodeLens for: %s" fileUri

            // Test CodeLens
            let codeLensResult = wrapper.GetCodeLens(fileUri)

            match codeLensResult with
            | Ok(lenses) ->
                printfn "🎯 Got %d CodeLens items" (Array.length lenses)

                for i, lens in Array.indexed lenses do
                    printfn "  Lens %d: Range [%d:%d-%d:%d]"
                        i
                        lens.Range.Start.Line
                        lens.Range.Start.Character
                        lens.Range.End.Line
                        lens.Range.End.Character

                    match lens.Command with
                    | Some cmd ->
                        printfn "    Command: %s" cmd.Title
                    | None ->
                        printfn "    No command (needs resolve)"

                        // Try to resolve
                        let resolveResult = wrapper.ResolveCodeLens(lens)
                        match resolveResult with
                        | Ok(resolved) ->
                            match resolved.Command with
                            | Some cmd -> printfn "    Resolved: %s" cmd.Title
                            | None -> printfn "    Still no command after resolve"
                        | Error(err) ->
                            printfn "    Resolve failed: %s" err

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
printfn "🚀 Starting direct CodeLens test..."
testDirectCodeLens() |> Async.RunSynchronously
printfn "✨ Test completed!"
