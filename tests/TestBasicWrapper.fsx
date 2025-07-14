// Test just the basic wrapper functionality
#r "nuget: Microsoft.Extensions.Logging, 9.0.0"
#r "../src/FSharp.MCP.DevKit.FsAutoComplete/bin/Debug/net10.0/FSharp.MCP.DevKit.FsAutoComplete.dll"

open System
open System.Threading
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete

printfn "🧪 Testing basic wrapper functionality..."

let runBasicTest () = async {
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
            printfn "✅ FsAutoComplete started successfully!"
            return true
        | Error(err) ->
            printfn "❌ Failed to start FsAutoComplete: %s" err
            return false

    with
    | ex ->
        printfn "💥 Exception: %s" ex.Message
        return false
}

// Run the test
let success = runBasicTest() |> Async.RunSynchronously
printfn "✨ Basic test result: %b" success
