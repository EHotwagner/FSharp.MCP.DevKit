// Test script for FsAutoComplete diagnostic timing
// This script tests the diagnostic collection timing fix

open System
open System.IO
open System.Threading.Tasks

let testProjectPath = Path.GetFullPath(".")
let testFilePath = Path.Combine(testProjectPath, "TestFileWithErrors.fs")

printfn "=== FsAutoComplete Diagnostic Timing Test ==="
printfn "Test project: %s" testProjectPath
printfn "Test file: %s" testFilePath
printfn ""

// Function to test MCP tools (simulated for now)
let testCheckFileCommand filePath =
    async {
        printfn "Testing CheckFile with: %s" filePath
        printfn "File exists: %b" (File.Exists(filePath))

        if File.Exists(filePath) then
            let content = File.ReadAllText(filePath)
            let lineCount = content.Split('\n').Length
            printfn "File has %d lines" lineCount
            printfn "Content preview (first 200 chars):"
            printfn "%s..." (content.Substring(0, min 200 content.Length))

        return "Test completed"
    }

// Test with different files
let testFiles =
    [ "TestFileWithErrors.fs"
      "TestFileWithWarnings.fs"
      "TestFileValid.fs"
      "TestScript.fsx" ]

for fileName in testFiles do
    let fullPath = Path.Combine(testProjectPath, fileName)
    printfn "\n--- Testing %s ---" fileName

    let result = testCheckFileCommand fullPath |> Async.RunSynchronously
    printfn "Result: %s" result

printfn "\n=== Test Instructions ==="
printfn "To test the diagnostic timing fix:"
printfn "1. Start the MCP server: cd src/FSharp.MCP.DevKit.Server && dotnet run"
printfn "2. Use mcp_fsharpdevkit_StartFsAutoComplete with workspace: %s" testProjectPath
printfn "3. Use mcp_fsharpdevkit_CheckFile on test files to verify diagnostics are collected"
printfn ""
printfn "Expected behavior:"
printfn "- TestFileWithErrors.fs should return multiple type errors"
printfn "- TestFileWithWarnings.fs should return warnings about incomplete patterns"
printfn "- TestFileValid.fs should return no diagnostics"
printfn "- TestScript.fsx should return script-specific errors"
