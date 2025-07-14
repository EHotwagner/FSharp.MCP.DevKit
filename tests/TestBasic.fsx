// Basic FsAutoComplete test
#r "nuget: Microsoft.Extensions.Logging, 9.0.0"
#r "../src/FSharp.MCP.DevKit.FsAutoComplete/bin/Debug/net10.0/FSharp.MCP.DevKit.FsAutoComplete.dll"

open System
open System.Threading
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete

printfn "🧪 Basic FsAutoComplete test..."

let testBasicFunctionality () =
    try
        printfn "✅ DLL loaded successfully"

        // Create basic logger
        let loggerFactory = LoggerFactory.Create(fun _ -> ())
        let logger = loggerFactory.CreateLogger<FsAutoCompleteWrapper>()
        printfn "✅ Logger created"

        // Create wrapper
        let config = FsAutoCompleteWrapperConfig.Default
        use wrapper = new FsAutoCompleteWrapper(config, logger)
        printfn "✅ Wrapper created"

        // Start the wrapper
        printfn "🚀 Starting FsAutoComplete..."
        let startResult = wrapper.StartAsync(CancellationToken.None) |> Async.RunSynchronously

        match startResult with
        | Ok() ->
            printfn "✅ FsAutoComplete started successfully"

            // Test a simple operation
            let testFile = __SOURCE_DIRECTORY__ + "/test_codelens.fs"
            let fileUri = $"file:///{testFile.Replace('\\', '/')}"
            printfn "🔍 Testing CodeLens for: %s" fileUri

            // Test CodeLens
            printfn "🔍 Calling GetCodeLens..."
            let codeLensTask = wrapper.GetCodeLens(fileUri)
            let codeLensResult = codeLensTask |> Async.RunSynchronously
            match codeLensResult with
            | Ok(lenses) ->
                printfn "🎯 Got %d CodeLens items" (Array.length lenses)
                for lens in lenses do
                    printfn "  - Range: [%d:%d-%d:%d]"
                        lens.Range.Start.Line lens.Range.Start.Character
                        lens.Range.End.Line lens.Range.End.Character
            | Error(err) ->
                printfn "❌ CodeLens failed: %s" err

        | Error(err) ->
            printfn "❌ Failed to start: %s" err

        printfn "🎯 Basic test completed successfully!"

    with
    | ex ->
        printfn "💥 Exception: %s" ex.Message
        printfn "Stack trace: %s" ex.StackTrace

testBasicFunctionality()
printfn "✨ Test finished!"
