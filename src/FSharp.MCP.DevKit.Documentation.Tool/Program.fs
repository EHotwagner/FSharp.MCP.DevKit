// FSharp.MCP.DevKit.Documentation.Tool/Program.fs
// Command-line interface for the F# Documentation Generator

open System
open System.IO
open FSharp.MCP.DevKit.Documentation.Tools.DocumentationCommands

let printUsage () =
    printfn
        """
F# MCP DevKit Documentation Generator v1.0.0

USAGE:
    fsharp-docgen <command> [options]

COMMANDS:
    package <name>                Generate documentation for a NuGet package
    project <path>                Generate documentation for an F# project
    list [search-term]            List packages in local NuGet cache
    info <package-name>           Show information about a package
    config                        Show current configuration
    set-output <directory>        Set output directory

OPTIONS:
    --output, -o <directory>      Output directory (overrides default)
    --overwrite, -f               Overwrite existing documentation
    --help, -h                    Show this help message

EXAMPLES:
    fsharp-docgen package Newtonsoft.Json
    fsharp-docgen project MyProject.fsproj --output ./docs --overwrite
    fsharp-docgen list json
    fsharp-docgen info FSharp.Core
    fsharp-docgen set-output ./api-docs

For more information, visit: https://github.com/ehotw/FSharp.MCP.DevKit
"""

let parseArgs (args: string[]) : DocCommand option * bool * string option =
    let mutable command = None
    let mutable showHelp = false
    let mutable outputDir = None
    let mutable overwrite = false
    let mutable i = 0

    while i < args.Length do
        match args.[i].ToLower() with
        | "--help"
        | "-h" ->
            showHelp <- true
            i <- i + 1
        | "--output"
        | "-o" when i + 1 < args.Length ->
            outputDir <- Some args.[i + 1]
            i <- i + 2
        | "--overwrite"
        | "-f" ->
            overwrite <- true
            i <- i + 1
        | "package" when i + 1 < args.Length ->
            command <- Some(GeneratePackageDoc(args.[i + 1], outputDir, overwrite))
            i <- i + 2
        | "project" when i + 1 < args.Length ->
            command <- Some(GenerateProjectDoc(args.[i + 1], outputDir, overwrite))
            i <- i + 2
        | "list" ->
            let searchTerm =
                if i + 1 < args.Length && not (args.[i + 1].StartsWith("-")) then
                    Some args.[i + 1]
                else
                    None

            command <- Some(ListCachedPackages searchTerm)
            i <- if searchTerm.IsSome then i + 2 else i + 1
        | "info" when i + 1 < args.Length ->
            command <- Some(ShowPackageInfo args.[i + 1])
            i <- i + 2
        | "config" ->
            command <- Some ShowConfig
            i <- i + 1
        | "set-output" when i + 1 < args.Length ->
            command <- Some(SetOutputDir args.[i + 1])
            i <- i + 2
        | _ ->
            printfn "Unknown argument: %s" args.[i]
            showHelp <- true
            i <- i + 1

    (command, showHelp, outputDir)

let printResult (result: CommandResult) =
    match result with
    | Success(message, details) ->
        printfn "%s" message
        details |> Option.iter (printfn "\n%s")
        0
    | Error message ->
        eprintfn "%s" message
        1
    | Info(message, data) ->
        printfn "%s" message

        if not (String.IsNullOrEmpty data) then
            printfn "\n%s" data

        0

[<EntryPoint>]
let main args =
    try
        if args.Length = 0 then
            printUsage ()
            0
        else
            let (command, showHelp, outputDir) = parseArgs args

            if showHelp then
                printUsage ()
                0
            else
                match command with
                | None ->
                    printfn "No valid command specified."
                    printUsage ()
                    1
                | Some cmd ->
                    // Update global output directory if specified
                    outputDir |> Option.iter docSetOutputDir

                    let result = executeCommand cmd
                    printResult result

    with ex ->
        eprintfn "Unexpected error: %s" ex.Message
        eprintfn "Stack trace: %s" ex.StackTrace
        1
