// Smart Symbol Detection - Production Ready Version
// This can be integrated into your MCP F# tools

namespace FSharp.MCP.DevKit.Analysis

open System
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Text
open FSharp.Compiler.Symbols

module SmartSymbolDetection =

    type SymbolInfo =
        { Name: string
          StartLine: int
          StartColumn: int
          EndLine: int
          EndColumn: int
          SymbolKind: string
          FullTypeName: string option
          Signature: string option
          Documentation: string option }

    type SymbolDetectionService(checker: FSharpChecker) =

        /// Extract all symbols from F# source code using compiler services
        member this.GetAllSymbols(sourceCode: string) =
            try
                let sourceText = SourceText.ofString sourceCode
                let fileName = "temp.fsx"

                let projOptions, _ =
                    checker.GetProjectOptionsFromScript(fileName, sourceText, assumeDotNetFramework = false)
                    |> Async.RunSynchronously

                let _, checkFileAnswer =
                    checker.ParseAndCheckFileInProject(fileName, 0, sourceText, projOptions)
                    |> Async.RunSynchronously

                match checkFileAnswer with
                | FSharpCheckFileAnswer.Succeeded checkFileResults ->
                    let allSymbolUses = checkFileResults.GetAllUsesOfAllSymbolsInFile()

                    let symbols =
                        allSymbolUses
                        |> Seq.map (fun symbolUse ->
                            { Name = symbolUse.Symbol.DisplayName
                              StartLine = symbolUse.Range.StartLine
                              StartColumn = symbolUse.Range.StartColumn
                              EndLine = symbolUse.Range.EndLine
                              EndColumn = symbolUse.Range.EndColumn
                              SymbolKind =
                                match symbolUse.Symbol with
                                | :? FSharpMemberOrFunctionOrValue as v when v.IsFunction -> "Function"
                                | :? FSharpMemberOrFunctionOrValue as v when v.IsMutable -> "MutableValue"
                                | :? FSharpMemberOrFunctionOrValue as v when v.IsProperty -> "Property"
                                | :? FSharpMemberOrFunctionOrValue -> "Value"
                                | :? FSharpEntity as e when e.IsClass -> "Class"
                                | :? FSharpEntity as e when e.IsInterface -> "Interface"
                                | :? FSharpEntity as e when e.IsFSharpRecord -> "Record"
                                | :? FSharpEntity as e when e.IsFSharpUnion -> "Union"
                                | :? FSharpEntity -> "Type"
                                | _ -> "Unknown"
                              FullTypeName =
                                try
                                    Some(symbolUse.Symbol.FullName)
                                with _ ->
                                    None
                              Signature = Some(this.ExtractSignature(symbolUse))
                              Documentation = this.ExtractDocumentation(symbolUse) })
                        |> Seq.toArray

                    Ok symbols
                | _ -> Error "Type checking failed"
            with ex ->
                Error(sprintf "Failed to get symbols: %s" ex.Message)

        /// Find the best matching symbol at a specific position
        member _.FindSymbolAtPosition(symbols: SymbolInfo[], lineNumber: int, columnNumber: int) =
            symbols
            |> Array.filter (fun s ->
                s.StartLine <= lineNumber
                && lineNumber <= s.EndLine
                && s.StartColumn <= columnNumber
                && columnNumber <= s.EndColumn)
            |> Array.sortBy (fun s ->
                // Prefer smaller ranges (more specific symbols)
                (s.EndLine - s.StartLine) * 1000 + (s.EndColumn - s.StartColumn))
            |> Array.tryHead

        /// Get symbol at position - the main API method
        member this.GetSymbolAtPosition(sourceCode: string, lineNumber: int, columnNumber: int) =
            match this.GetAllSymbols(sourceCode) with
            | Ok symbols ->
                match this.FindSymbolAtPosition(symbols, lineNumber, columnNumber) with
                | Some symbol -> Ok symbol
                | None -> Error "No symbol found at position"
            | Error msg -> Error msg

        /// Quick utility method - returns a simple string description
        member this.WhatIsAt(sourceCode: string, lineNumber: int, columnNumber: int) =
            match this.GetSymbolAtPosition(sourceCode, lineNumber, columnNumber) with
            | Ok symbol -> sprintf "%s '%s'" symbol.SymbolKind symbol.Name
            | Error msg -> sprintf "Error: %s" msg

        /// Get symbol signature at a specific position - convenience method
        member this.GetSignatureAtPosition(sourceCode: string, lineNumber: int, columnNumber: int) =
            match this.GetSymbolAtPosition(sourceCode, lineNumber, columnNumber) with
            | Ok symbol ->
                match symbol.Signature with
                | Some signature -> Ok signature
                | None -> Error "No signature available for symbol"
            | Error msg -> Error msg

        /// Extract signature information from a symbol
        member private _.ExtractSignature(symbolUse: FSharpSymbolUse) =
            try
                match symbolUse.Symbol with
                | :? FSharpMemberOrFunctionOrValue as v ->
                    try
                        let typeStr = v.FullType.Format(symbolUse.DisplayContext)

                        match v with
                        | _ when v.IsFunction ->
                            // For functions, get parameter names if available
                            let paramNames =
                                v.CurriedParameterGroups
                                |> Seq.collect (fun group -> group |> Seq.map (fun p -> p.DisplayName))
                                |> Seq.toList

                            if paramNames.Length > 0 then
                                sprintf "%s %s : %s" v.DisplayName (String.concat " " paramNames) typeStr
                            else
                                sprintf "%s : %s" v.DisplayName typeStr
                        | _ when v.IsProperty -> sprintf "property %s : %s" v.DisplayName typeStr
                        | _ when v.IsMutable -> sprintf "mutable %s : %s" v.DisplayName typeStr
                        | _ -> sprintf "val %s : %s" v.DisplayName typeStr
                    with _ ->
                        sprintf "%s : <type unavailable>" v.DisplayName
                | :? FSharpEntity as e ->
                    try
                        match e with
                        | _ when e.IsFSharpRecord ->
                            let fields =
                                e.FSharpFields
                                |> Seq.map (fun f ->
                                    sprintf "%s: %s" f.Name (f.FieldType.Format(symbolUse.DisplayContext)))
                                |> String.concat "; "

                            sprintf "type %s = { %s }" e.DisplayName fields
                        | _ when e.IsFSharpUnion ->
                            let cases =
                                e.UnionCases
                                |> Seq.map (fun c ->
                                    if c.Fields.Count > 0 then
                                        let fields =
                                            c.Fields
                                            |> Seq.map (fun f -> f.FieldType.Format(symbolUse.DisplayContext))
                                            |> String.concat " * "

                                        sprintf "%s of %s" c.Name fields
                                    else
                                        c.Name)
                                |> String.concat " | "

                            sprintf "type %s = %s" e.DisplayName cases
                        | _ when e.IsClass -> sprintf "type %s = class ... end" e.DisplayName
                        | _ when e.IsInterface -> sprintf "type %s = interface ... end" e.DisplayName
                        | _ -> sprintf "type %s" e.DisplayName
                    with _ ->
                        sprintf "type %s : <signature unavailable>" e.DisplayName
                | _ -> sprintf "%s : <unknown signature>" symbolUse.Symbol.DisplayName
            with _ ->
                None
                |> Option.defaultValue (sprintf "%s : <error extracting signature>" symbolUse.Symbol.DisplayName)

        /// Extract documentation from a symbol
        member private _.ExtractDocumentation(symbolUse: FSharpSymbolUse) =
            try
                match symbolUse.Symbol with
                | :? FSharpMemberOrFunctionOrValue as v ->
                    match v.XmlDoc with
                    | FSharpXmlDoc.FromXmlText xmlDoc when not xmlDoc.IsEmpty ->
                        xmlDoc.GetElaboratedXmlLines() |> String.concat "\n" |> Some
                    | _ -> None
                | :? FSharpEntity as e ->
                    match e.XmlDoc with
                    | FSharpXmlDoc.FromXmlText xmlDoc when not xmlDoc.IsEmpty ->
                        xmlDoc.GetElaboratedXmlLines() |> String.concat "\n" |> Some
                    | _ -> None
                | _ -> None
            with _ ->
                None

    // Factory function for easy instantiation
    let createSymbolDetectionService () =
        let checker = FSharpChecker.Create(keepAssemblyContents = true)
        SymbolDetectionService(checker)

    // Example usage and tests
    let demonstrateUsage () =
        let service = createSymbolDetectionService ()

        let testCode =
            """
module Example =
    type Person = { Name: string; Age: int }

    let createPerson name age = { Name = name; Age = age }

    let john = createPerson "John" 30

    let getPersonInfo person =
        sprintf "%s is %d years old" person.Name person.Age
"""

        printfn "=== Smart Symbol Detection Service Demo ==="
        printfn "Code:%s" testCode

        // Get all symbols
        match service.GetAllSymbols(testCode) with
        | Ok symbols ->
            printfn "\nFound symbols by type:"

            symbols
            |> Array.groupBy (fun s -> s.SymbolKind)
            |> Array.iter (fun (kind, syms) ->
                let uniqueNames = syms |> Array.map (fun s -> s.Name) |> Array.distinct
                printfn "  %s: %s" kind (String.concat ", " uniqueNames))

            // Test specific positions
            let testPositions =
                [ (3, 10, "Should find 'Person' type")
                  (5, 9, "Should find 'createPerson' function")
                  (7, 9, "Should find 'john' value")
                  (9, 9, "Should find 'getPersonInfo' function")
                  (10, 50, "Should find 'person' parameter") ]

            printfn "\nTesting specific positions:"

            for (line, col, expected) in testPositions do
                let result = service.WhatIsAt(testCode, line, col)
                printfn "  Line %d, Col %d (%s): %s" line col expected result

        | Error msg -> printfn "Error: %s" msg
