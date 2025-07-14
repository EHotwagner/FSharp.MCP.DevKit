// Fresh CodeLens test
#r "nuget: Microsoft.Extensions.Logging, 9.0.0"
#r "../src/FSharp.MCP.DevKit.FsAutoComplete/bin/Debug/net10.0/FSharp.MCP.DevKit.FsAutoComplete.dll"

open System
open System.IO
open System.Threading
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete

printfn "🧪 Fresh CodeLens test starting..."

let runTest () = async {
    try
        // Create logger
        let loggerFactory = LoggerFactory.Create(fun _ -> ())
        let logger = loggerFactory.CreateLogger<FsAutoCompleteWrapper>()
        printfn "✅ Logger created"

        // Create configuration and wrapper
        let config = FsAutoCompleteWrapperConfig.Default
        use wrapper = new FsAutoCompleteWrapper(config, logger)
        printfn "✅ Wrapper created"

        // Start FsAutoComplete
        printfn "🚀 Starting FsAutoComplete..."
        let! startResult = wrapper.StartAsync(CancellationToken.None)

        match startResult with
        | Ok() ->
            printfn "✅ FsAutoComplete started"

            // Wait a moment for initialization
            do! Async.Sleep(2000)
            printfn "⏱️ Waited for initialization"

            // Create test file content
            let testContent = """module TestCodeLens
let add x y = x + y
let result = add 1 2"""

            let testFile = Path.Combine(__SOURCE_DIRECTORY__, "test_fresh.fs")
            File.WriteAllText(testFile, testContent)
            printfn "📄 Created test file: %s" testFile

            let fileUri = testFile.Replace('\\', '/') |> sprintf "file:///%s"
            printfn "🔗 File URI: %s" fileUri

            // Open the document in FsAutoComplete
            let openResult = wrapper.DidOpenTextDocument(fileUri, testContent, 1)
            printfn "📂 Document opened"

            // Wait for processing
            do! Async.Sleep(1000)

            // Test CodeLens
            printfn "🔍 Requesting CodeLens..."
            let! codeLensResult = wrapper.GetCodeLens(fileUri)

            match codeLensResult with
            | Ok(lenses) ->
                printfn "🎯 Success! Got %d CodeLens items" (Array.length lenses)
                for i, lens in Array.indexed lenses do
                    printfn "  Lens %d: Range [%d:%d-%d:%d]"
                        i
                        lens.Range.Start.Line lens.Range.Start.Character
                        lens.Range.End.Line lens.Range.End.Character
                    match lens.Command with
                    | Some cmd -> printfn "    Command: %s" cmd.Title
                    | None -> printfn "    No command (needs resolve)"
            | Error(err) ->
                printfn "❌ CodeLens failed: %s" err

        | Error(err) ->
            printfn "❌ Failed to start FsAutoComplete: %s" err

    with
    | ex ->
        printfn "💥 Exception: %s" ex.Message
        printfn "Stack: %s" ex.StackTrace
}

// Run the test
runTest() |> Async.RunSynchronously
printfn "✨ Fresh test completed!"
