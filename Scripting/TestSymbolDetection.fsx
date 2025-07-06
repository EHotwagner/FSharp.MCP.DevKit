// Test script for SmartSymbolDetectionService
#r "nuget: FSharp.Compiler.Service"

open System
open System.IO

// Load the analysis module
#load "../src/FSharp.MCP.DevKit.Analysis/SmartSymbolDetectionService.fs"

open FSharp.MCP.DevKit.Analysis.SmartSymbolDetection

printfn "=== Testing SmartSymbolDetectionService ==="

let service = createSymbolDetectionService ()

let testCode =
    """
module TestModule =
    type Person = { Name: string; Age: int }

    let createPerson name age = { Name = name; Age = age }

    let john = createPerson "John" 30

    let getPersonInfo person =
        sprintf "%s is %d years old" person.Name person.Age

    type Color = Red | Green | Blue

    let favoriteColor = Red
"""

printfn "Test code:"
printfn "%s" testCode
printfn ""

// Test 1: Get all symbols
printfn "=== Test 1: Get all symbols ==="

match service.GetAllSymbols(testCode) with
| Ok symbols ->
    printfn "Found %d symbols total" symbols.Length

    // Group by symbol kind
    symbols
    |> Array.groupBy (fun s -> s.SymbolKind)
    |> Array.iter (fun (kind, syms) ->
        let names = syms |> Array.map (fun s -> s.Name) |> Array.distinct
        printfn "  %s (%d): %s" kind syms.Length (String.concat ", " names))

    printfn ""

    // Show detailed info for first few symbols
    printfn "Sample symbol details:"

    symbols
    |> Array.take (min 5 symbols.Length)
    |> Array.iter (fun sym ->
        printfn
            "  - %s '%s' at (%d,%d) to (%d,%d)"
            sym.SymbolKind
            sym.Name
            sym.StartLine
            sym.StartColumn
            sym.EndLine
            sym.EndColumn

        match sym.Signature with
        | Some signature -> printfn "    Signature: %s" signature
        | None -> printfn "    No signature"

        match sym.Documentation with
        | Some doc -> printfn "    Doc: %s" doc
        | None -> printfn "    No documentation")

| Error msg -> printfn "Error getting symbols: %s" msg

printfn ""

// Test 2: Symbol at specific positions
printfn "=== Test 2: Symbol at specific positions ==="

let testPositions =
    [ (3, 10, "Person type definition")
      (5, 9, "createPerson function")
      (7, 9, "john value")
      (9, 9, "getPersonInfo function")
      (10, 30, "person parameter")
      (12, 10, "Color union type")
      (14, 9, "favoriteColor value") ]

for (line, col, description) in testPositions do
    let result = service.WhatIsAt(testCode, line, col)
    printfn "Line %d, Col %d (%s): %s" line col description result

printfn ""

// Test 3: Get signature at position
printfn "=== Test 3: Get signature at position ==="

for (line, col, description) in testPositions do
    match service.GetSignatureAtPosition(testCode, line, col) with
    | Ok signature -> printfn "Line %d, Col %d: %s" line col signature
    | Error msg -> printfn "Line %d, Col %d: Error - %s" line col msg

printfn ""

// Test 4: Run the built-in demonstration
printfn "=== Test 4: Built-in demonstration ==="
demonstrateUsage ()

printfn ""
printfn "=== Testing complete ==="
