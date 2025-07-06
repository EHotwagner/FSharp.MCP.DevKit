// Test custom type symbol detection
#r "nuget: FSharp.Compiler.Service"
#load "../src/FSharp.MCP.DevKit.Analysis/SmartSymbolDetectionService.fs"

open FSharp.MCP.DevKit.Analysis.SmartSymbolDetection

let service = createSymbolDetectionService ()

let customTypeCode =
    """type Person = { Name: string; Age: int }
let john = { Name = "John"; Age = 30 }
let getName person = person.Name"""

printfn "=== Custom Type Symbol Detection Test ==="
printfn "Code:\n%s\n" customTypeCode

match service.GetAllSymbols(customTypeCode) with
| Ok symbols ->
    printfn "Found %d symbols:" symbols.Length

    symbols
    |> Array.iteri (fun i sym ->
        printfn "%d. Symbol: '%s' (%s)" (i + 1) sym.Name sym.SymbolKind
        printfn "   Position: Line %d, Cols %d-%d" sym.StartLine sym.StartColumn sym.EndColumn
        printfn "   Full Type: %s" (sym.FullTypeName |> Option.defaultValue "None")
        printfn "   Signature: %s" (sym.Signature |> Option.defaultValue "None")
        printfn "")

    // Test finding john specifically
    let johnSymbols = symbols |> Array.filter (fun s -> s.Name = "john")
    printfn "Symbols named 'john': %d" johnSymbols.Length

    for j in johnSymbols do
        printfn "  john: %s at line %d" j.SymbolKind j.StartLine

| Error msg -> printfn "Error: %s" msg

// Test position lookup
printfn "\n=== Position-based lookups ==="

let testPositions =
    [ (1, 6, "Person type"); (2, 5, "john variable"); (3, 12, "person parameter") ]

for (line, col, desc) in testPositions do
    let result = service.WhatIsAt(customTypeCode, line, col)
    printfn "Line %d, Col %d (%s): %s" line col desc result
