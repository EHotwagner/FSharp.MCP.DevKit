// Test CodeLens via MCP Functions
#r "nuget: Microsoft.Extensions.Logging, 9.0.0"
#r "nuget: Microsoft.Extensions.Logging.Console, 9.0.0"
#r "../src/FSharp.MCP.DevKit.FsAutoComplete/bin/Debug/net10.0/FSharp.MCP.DevKit.FsAutoComplete.dll"
#r "../src/FSharp.MCP.DevKit.Core/bin/Debug/net10.0/FSharp.MCP.DevKit.Core.dll"

open System
open System.IO
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete

printfn "🧪 Testing CodeLens via MCP functions..."

// Use the MCP functions directly
let testMcpCodeLens () = async {
    try
        printfn "🚀 Testing MCP CodeLens functions..."

        // Create a test F# file path
        let testFile = Path.Combine(__SOURCE_DIRECTORY__, "test_codelens.fs")
        printfn "📄 Test file: %s" testFile

        // Check if file exists and create simple content if needed
        if not (File.Exists testFile) then
            let content = """module Test
let add x y = x + y
let result = add 1 2"""
            File.WriteAllText(testFile, content)
            printfn "✅ Created test file"

        // Convert to proper file URI for FsAutoComplete
        let fileUri = testFile.Replace('\\', '/') |> sprintf "file:///%s"
        printfn "🔗 File URI: %s" fileUri

        // Test the MCP tools directly
        printfn "🔍 Testing GetCodeLens..."
        let! result1 = McpFsAutoCompleteTools.getCodeLens(fileUri, 30) |> Async.AwaitTask

        match result1 with
        | Ok content ->
            printfn "✅ GetCodeLens succeeded!"
            printfn "📄 Content: %s" content
        | Error error ->
            printfn "❌ GetCodeLens failed: %s" error

        printfn "🔍 Testing GetDetailedCodeLens..."
        let! result2 = McpFsAutoCompleteTools.getDetailedCodeLens(fileUri, 30) |> Async.AwaitTask

        match result2 with
        | Ok content ->
            printfn "✅ GetDetailedCodeLens succeeded!"
            printfn "📄 Content: %s" content
        | Error error ->
            printfn "❌ GetDetailedCodeLens failed: %s" error

    with
    | ex ->
        printfn "💥 Exception: %s" ex.Message
        printfn "Stack trace: %s" ex.StackTrace
}

// Run the test
testMcpCodeLens() |> Async.RunSynchronously
printfn "✨ MCP CodeLens test completed!"
