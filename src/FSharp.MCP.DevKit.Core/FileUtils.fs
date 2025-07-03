namespace FSharp.MCP.DevKit.Core

open System
open System.IO

module FileUtils =

    /// Safely splits text while preserving line endings and empty lines
    let splitLinesPreservingLineEndings (text: string) =
        if String.IsNullOrEmpty(text) then
            [||]
        else
            // Handle different line ending types properly without creating empty strings
            text.Split([| "\r\n"; "\n"; "\r" |], StringSplitOptions.None)

    /// Safely joins lines back together with consistent line endings
    let joinLinesWithConsistentEndings (lines: string[]) = String.Join("\n", lines)

    /// Enhanced atomic write with better error handling and UTF-8 encoding
    let writeFileSafely (filePath: string) (finalCode: string) =
        try
            let backupPath = filePath + ".backup"
            let tempPath = filePath + ".tmp"

            if File.Exists(filePath) then
                File.Copy(filePath, backupPath, true)

            File.WriteAllText(tempPath, finalCode, System.Text.Encoding.UTF8)

            if File.Exists(filePath) then
                File.Delete(filePath)

            File.Move(tempPath, filePath)

            // Clean up backup file on success
            if File.Exists(backupPath) then
                File.Delete(backupPath)

            Ok("File written successfully")

        with ex ->
            // Restore backup if it exists
            let backupPath = filePath + ".backup"

            if File.Exists(backupPath) then
                File.Copy(backupPath, filePath, true)
                File.Delete(backupPath)

            Error(sprintf "Failed to write file: %s" ex.Message)

    /// Validates F# file extensions
    let isValidFSharpFile (filePath: string) =
        let extension = Path.GetExtension(filePath).ToLowerInvariant()
        extension = ".fs" || extension = ".fsx" || extension = ".fsi"
