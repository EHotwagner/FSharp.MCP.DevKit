namespace FSharp.MCP.DevKit.Analysis

open System

module FSharpCodeAnalysis =

    /// Validates that new code can be safely inserted without breaking F# syntax
    let validateInsertionContext (existingLines: string[]) (insertAtLine: int) (newCodeLines: string[]) =
        if insertAtLine <= 0 || insertAtLine > existingLines.Length + 1 then
            Error(sprintf "Invalid line number %d. File has %d lines." insertAtLine existingLines.Length)
        else
            // Check if we're trying to insert in the middle of a multi-line construct
            let lineBeforeInsertion =
                if insertAtLine > 1 && insertAtLine <= existingLines.Length then
                    Some(existingLines.[insertAtLine - 2].Trim())
                else
                    None

            let lineAfterInsertion =
                if insertAtLine <= existingLines.Length then
                    Some(existingLines.[insertAtLine - 1].Trim())
                else
                    None

            // Check for dangerous insertion points
            match lineBeforeInsertion, lineAfterInsertion with
            | Some before, Some after when before.EndsWith("=") && after.StartsWith("|") ->
                Error("Cannot insert code in the middle of a discriminated union definition")
            | Some before, Some after when before.Contains("type") && before.EndsWith("=") && after.StartsWith("|") ->
                Error("Cannot insert code in the middle of a type definition")
            | Some before, Some after when before.EndsWith("{") && after.StartsWith("}") ->
                Error("Cannot insert code in the middle of a record definition")
            | _ -> Ok()
