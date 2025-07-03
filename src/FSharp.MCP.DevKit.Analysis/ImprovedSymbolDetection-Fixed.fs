namespace FSharp.MCP.DevKit.Analysis

open System
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Text
open FSharp.Compiler.Symbols

module ImprovedSymbolDetection =

    type ImprovedSymbolInfo =
        { Name: string
          StartLine: int
          StartColumn: int
          EndLine: int
          EndColumn: int
          SymbolKind: string
          FullTypeName: string option
          Signature: string option
          Documentation: string option
          Confidence: float } // How confident we are in this match

    type PositionTolerance =
        { LineRadius: int // Lines to search around target
          ColumnRadius: int // Columns to search around target
          UseSemanticSearch: bool } // Use AST traversal for fuzzy matching

    let defaultTolerance =
        { LineRadius = 1
          ColumnRadius = 3
          UseSemanticSearch = true }

    type ImprovedSymbolDetectionService(checker: FSharpChecker, tolerance: PositionTolerance) =

        /// AST-aware symbol detection using GetSymbolUseAtLocation
        member this.GetSymbolAtPositionAST(sourceCode: string, lineNumber: int, columnNumber: int) =
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
                    // First try: Exact position using F# Compiler Service's intelligent positioning
                    let position = mkPos lineNumber columnNumber

                    match checkFileResults.GetSymbolUseAtLocation(lineNumber, columnNumber, "", []) with
                    | Some symbolUse ->
                        let symbolInfo = this.CreateSymbolInfo symbolUse 1.0
                        Ok symbolInfo
                    | None -> Error "No symbol found at exact position"
                | _ -> Error "Type checking failed"
            with ex ->
                Error(sprintf "Failed to get symbol: %s" ex.Message)

        /// Create symbol info from F# compiler symbol use
        member private this.CreateSymbolInfo (symbolUse: FSharpSymbolUse) (confidence: float) =
            { Name = symbolUse.Symbol.DisplayName
              StartLine = symbolUse.Range.StartLine
              StartColumn = symbolUse.Range.StartColumn
              EndLine = symbolUse.Range.EndLine
              EndColumn = symbolUse.Range.EndColumn
              SymbolKind = this.GetSymbolKind symbolUse.Symbol
              FullTypeName =
                try
                    Some(symbolUse.Symbol.FullName)
                with _ ->
                    None
              Signature = Some(this.ExtractSignature symbolUse)
              Documentation = this.ExtractDocumentation symbolUse
              Confidence = confidence }

        /// Get symbol kind from F# symbol
        member private _.GetSymbolKind(symbol: FSharpSymbol) =
            match symbol with
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

        /// Extract signature from symbol use
        member private _.ExtractSignature(symbolUse: FSharpSymbolUse) =
            try
                match symbolUse.Symbol with
                | :? FSharpMemberOrFunctionOrValue as v ->
                    let typeStr = v.FullType.Format(symbolUse.DisplayContext)
                    sprintf "%s : %s" v.DisplayName typeStr
                | :? FSharpEntity as e -> sprintf "type %s" e.DisplayName
                | _ -> sprintf "%s : <unknown>" symbolUse.Symbol.DisplayName
            with _ ->
                sprintf "%s : <error>" symbolUse.Symbol.DisplayName

        /// Extract documentation from symbol
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

        /// Fuzzy symbol detection with tolerance-based search
        member this.GetSymbolAtPositionFuzzy(sourceCode: string, lineNumber: int, columnNumber: int) =
            // Try exact position first
            match this.GetSymbolAtPositionAST(sourceCode, lineNumber, columnNumber) with
            | Ok symbol -> Ok symbol
            | Error _ when tolerance.UseSemanticSearch ->
                // Try positions around the target with decreasing confidence
                let mutable result = None
                let mutable confidence = 0.9

                for lineOffset in -tolerance.LineRadius .. tolerance.LineRadius do
                    for colOffset in -tolerance.ColumnRadius .. tolerance.ColumnRadius do
                        if result.IsNone && (lineOffset <> 0 || colOffset <> 0) then
                            let newLine = lineNumber + lineOffset
                            let newCol = columnNumber + colOffset

                            if newLine > 0 && newCol > 0 then
                                match this.GetSymbolAtPositionAST(sourceCode, newLine, newCol) with
                                | Ok symbol ->
                                    // Adjust confidence based on distance
                                    let distance = abs lineOffset + abs colOffset
                                    let adjustedConfidence = confidence - (float distance * 0.1)

                                    result <-
                                        Some
                                            { symbol with
                                                Confidence = adjustedConfidence }
                                | Error _ -> ()

                match result with
                | Some symbol -> Ok symbol
                | None -> Error "No symbol found within tolerance range"
            | Error msg -> Error msg

        /// Main API method - try fuzzy search if available, fallback to exact
        member this.GetSymbolAtPosition(sourceCode: string, lineNumber: int, columnNumber: int) =
            if tolerance.UseSemanticSearch then
                this.GetSymbolAtPositionFuzzy(sourceCode, lineNumber, columnNumber)
            else
                this.GetSymbolAtPositionAST(sourceCode, lineNumber, columnNumber)

    // Factory functions
    let createImprovedSymbolDetectionService () =
        let checker = FSharpChecker.Create(keepAssemblyContents = true)
        ImprovedSymbolDetectionService(checker, defaultTolerance)

    let createWithTolerance (tolerance: PositionTolerance) =
        let checker = FSharpChecker.Create(keepAssemblyContents = true)
        ImprovedSymbolDetectionService(checker, tolerance)
