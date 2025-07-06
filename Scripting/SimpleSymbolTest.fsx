// Simple test for SmartSymbolDetectionService
#r "nuget: FSharp.Compiler.Service"
#load "../src/FSharp.MCP.DevKit.Analysis/SmartSymbolDetectionService.fs"

open FSharp.MCP.DevKit.Analysis.SmartSymbolDetection

printfn "Starting SmartSymbolDetectionService test..."

try
    // Load the analysis module

    printfn "Successfully loaded SmartSymbolDetectionService module"

    printfn "Opened namespace successfully"

    let service = createSymbolDetectionService ()
    printfn "Created symbol detection service successfully"

    let simpleCode = """let x = 42"""
    printfn "Testing with simple code: %s" simpleCode

    match service.GetAllSymbols(simpleCode) with
    | Ok symbols ->
        printfn "SUCCESS: Found %d symbols" symbols.Length

        for sym in symbols do
            printfn "  Symbol: %s (%s) at line %d" sym.Name sym.SymbolKind sym.StartLine
            printfn "    Full name: %s" (sym.FullTypeName |> Option.defaultValue "None")
            printfn "    Signature: %s" (sym.Signature |> Option.defaultValue "None")
            printfn "    Range: (%d,%d) to (%d,%d)" sym.StartLine sym.StartColumn sym.EndLine sym.EndColumn
            printfn ""
    | Error msg -> printfn "ERROR: %s" msg

    // Test with a more structured module
    let moduleCode =
        """
module TestModule =
    let x = 42
    let y = "hello"
"""

    printfn "Testing with module code:"

    match service.GetAllSymbols(moduleCode) with
    | Ok symbols ->
        printfn "Found %d symbols in module:" symbols.Length

        for sym in symbols do
            printfn "  %s (%s) - %s" sym.Name sym.SymbolKind (sym.FullTypeName |> Option.defaultValue "no type")
    | Error msg -> printfn "Module test error: %s" msg

    // Test with custom type and value
    let customTypeCode =
        """
type Person = { Name: string; Age: int }
let john = { Name = "John"; Age = 30 }
let getName person = person.Name
"""

    printfn "\nTesting with custom type and value:"
    printfn "Code: %s" customTypeCode

    match service.GetAllSymbols(customTypeCode) with
    | Ok symbols ->
        printfn "Found %d symbols with custom type:" symbols.Length

        for sym in symbols do
            printfn "  Symbol: %s (%s) at line %d" sym.Name sym.SymbolKind sym.StartLine
            printfn "    Full name: %s" (sym.FullTypeName |> Option.defaultValue "None")
            printfn "    Signature: %s" (sym.Signature |> Option.defaultValue "None")
            printfn "    Range: (%d,%d) to (%d,%d)" sym.StartLine sym.StartColumn sym.EndLine sym.EndColumn
            printfn ""
    | Error msg -> printfn "Custom type test error: %s" msg

    // Test specific position lookup on the custom value
    printfn "Testing position-specific symbol detection on 'john' value:"
    let johnResult = service.WhatIsAt(customTypeCode, 3, 5) // Should be around 'john'
    printfn "  At line 3, col 5: %s" johnResult

    let nameResult = service.WhatIsAt(customTypeCode, 4, 15) // Should be around 'person' parameter
    printfn "  At line 4, col 15: %s" nameResult

    printfn "Test completed successfully"

with ex ->
    printfn "EXCEPTION: %s" ex.Message
    printfn "Stack trace: %s" ex.StackTrace
