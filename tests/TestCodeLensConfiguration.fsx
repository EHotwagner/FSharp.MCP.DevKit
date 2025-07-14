// Test CodeLens with proper configuration
#r "nuget: Expecto"
#load "../src/FSharp.MCP.DevKit.Server/Program.fs"

open System
open System.IO
open FSharp.MCP.DevKit.FsAutoComplete

// Test function
let testFunction x = x + 1

// Another function that references testFunction
let anotherFunction () = testFunction 42

printfn "Testing CodeLens functionality..."

// Create test file content for CodeLens
let testContent = """
module TestModule

let testFunc x = x + 1

let callTestFunc () = testFunc 42
"""

// Test with proper configuration
let testCodeLensWithConfig () = async {
    try
        // Start FsAutoComplete with workspace support and CodeLens enabled
        let! result = FsAutoCompleteService.startWithWorkspace __SOURCE_DIRECTORY__ true 30

        match result with
        | Ok() ->
            printfn "✓ FsAutoComplete started successfully with workspace support"

            // Create a test file
            let testFile = Path.Combine(__SOURCE_DIRECTORY__, "test_codelens.fs")
            File.WriteAllText(testFile, testContent)

            try
                // Test getting CodeLens for the file
                let! codeLensResult = FsAutoCompleteService.getCodeLens testFile 30

                match codeLensResult with
                | Ok(lenses) when Array.length lenses > 0 ->
                    printfn "✓ Got %d CodeLens items:" (Array.length lenses)
                    for lens in lenses do
                        printfn "  - Range: %A" lens.Range
                        match lens.Command with
                        | Some cmd -> printfn "    Command: %s" cmd.Title
                        | None -> printfn "    No command (needs resolve)"

                | Ok(lenses) ->
                    printfn "⚠ Got empty CodeLens array - may need configuration"

                | Error(err) ->
                    printfn "✗ CodeLens failed: %s" err

            finally
                // Clean up test file
                if File.Exists(testFile) then File.Delete(testFile)

        | Error(err) ->
            printfn "✗ Failed to start FsAutoComplete: %s" err

    with
    | ex ->
        printfn "✗ Exception during CodeLens test: %s" ex.Message
}

// Run the test
testCodeLensWithConfig() |> Async.RunSynchronously

printfn "\nNow testing individual CodeLens resolve..."

// Test CodeLens resolve
let testCodeLensResolve () = async {
    try
        let testFile = Path.Combine(__SOURCE_DIRECTORY__, "test_resolve.fs")
        File.WriteAllText(testFile, testContent)

        try
            // First get unresolved CodeLens
            let! codeLensResult = FsAutoCompleteService.getCodeLens testFile 30

            match codeLensResult with
            | Ok(lenses) when Array.length lenses > 0 ->
                printfn "Testing resolve for %d lenses..." (Array.length lenses)

                for i, lens in Array.indexed lenses do
                    let! resolveResult = FsAutoCompleteService.resolveCodeLens testFile i 30

                    match resolveResult with
                    | Ok(resolved) ->
                        printfn "✓ Lens %d resolved:" i
                        match resolved.Command with
                        | Some cmd -> printfn "  Command: %s" cmd.Title
                        | None -> printfn "  Still no command"

                    | Error(err) ->
                        printfn "✗ Lens %d resolve failed: %s" i err

            | Ok(_) ->
                printfn "⚠ No lenses to resolve"

            | Error(err) ->
                printfn "✗ Failed to get initial CodeLens: %s" err

        finally
            if File.Exists(testFile) then File.Delete(testFile)

    with
    | ex ->
        printfn "✗ Exception during resolve test: %s" ex.Message
}

testCodeLensResolve() |> Async.RunSynchronously

printfn "\nCodeLens configuration test completed!"
