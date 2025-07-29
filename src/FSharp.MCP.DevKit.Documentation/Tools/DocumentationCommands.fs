// FSharp.MCP.DevKit.Documentation/Tools/DocumentationCommands.fs
// MCP command interface for documentation generation

namespace FSharp.MCP.DevKit.Documentation.Tools

open System
open System.IO
open FSharp.MCP.DevKit.Documentation.Tools.DocGenerator
open FSharp.MCP.DevKit.Documentation.Tools.ProjectAnalyzer
open FSharp.MCP.DevKit.Documentation.Tools.LibraryResearch

module DocumentationCommands =

    // === COMMAND TYPES ===

    type DocCommand =
        | GeneratePackageDoc of packageName: string * outputDir: string option * overwrite: bool
        | GenerateProjectDoc of projectPath: string * outputDir: string option * overwrite: bool
        | ResearchLibrary of libraryName: string * outputDir: string option
        | ListCachedPackages of searchTerm: string option
        | ShowPackageInfo of packageName: string
        | ShowConfig
        | SetOutputDir of outputDir: string

    type CommandResult =
        | Success of message: string * details: string option
        | Error of message: string
        | Info of message: string * data: string

    // === GLOBAL CONFIGURATION ===

    let mutable globalConfig = defaultConfig

    let updateGlobalConfig (newConfig: DocGenConfig) : unit = globalConfig <- newConfig

    let setOutputDirectory (outputDir: string) : unit =
        globalConfig <-
            { globalConfig with
                OutputDirectory = outputDir }

    // === COMMAND IMPLEMENTATIONS ===

    // Helper function to create configuration from global config and options
    let private createConfig (outputDir: string option) (overwrite: bool) : DocGenConfig =
        { globalConfig with
            OutputDirectory = outputDir |> Option.defaultValue globalConfig.OutputDirectory
            OverwriteExisting = overwrite }

    // Helper function to format package documentation statistics
    let private formatPackageDocStats (result: DocGenerationResult) : string =
        $"""📁 Output: {result.OutputPath}
📊 Statistics:
  - Version: {result.Version}
  - Types: {result.TypesDocumented}
  - Methods: {result.MethodsDocumented}
  - Properties: {result.PropertiesDocumented}
  - Has XML Docs: {result.HasXmlDocs}
  - Generation Time: {result.GenerationTime.TotalSeconds:F2} seconds"""

    // Helper function to handle package documentation result
    let private handlePackageDocResult
        (packageName: string)
        (result: Result<DocGenerationResult, string>)
        : CommandResult =
        match result with
        | Ok docResult ->
            let message = $"✅ Successfully generated documentation for '{packageName}'"
            let details = formatPackageDocStats docResult
            CommandResult.Success(message, Some details)
        | Result.Error err -> Error $"❌ Failed to generate documentation for '{packageName}': {err}"

    // Helper function to handle project documentation result
    let private handleProjectDocResult
        (projectPath: string)
        (result: Result<ProjectDocResult, string>)
        : CommandResult =
        match result with
        | Ok projectResult ->
            let summary = generateProjectDocumentationSummary projectResult

            let message =
                $"✅ Successfully generated documentation for project '{projectResult.ProjectInfo.ProjectName}'"

            CommandResult.Success(message, Some summary)
        | Result.Error err -> Error $"❌ Failed to generate documentation for project '{projectPath}': {err}"

    let generatePackageDocumentation
        (packageName: string)
        (outputDir: string option)
        (overwrite: bool)
        : CommandResult =
        try
            let config = createConfig outputDir overwrite
            let result = generateDocumentationForPackage packageName config
            handlePackageDocResult packageName result
        with ex ->
            Error $"❌ Unexpected error: {ex.Message}"

    let generateProjectDocumentation
        (projectPath: string)
        (outputDir: string option)
        (overwrite: bool)
        : CommandResult =
        try
            let config = createConfig outputDir overwrite
            let result = generateDocumentationForProject projectPath config
            handleProjectDocResult projectPath result
        with ex ->
            Error $"❌ Unexpected error: {ex.Message}"

    let listCachedPackages (searchTerm: string option) : CommandResult =
        try
            let packages =
                match searchTerm with
                | Some term -> searchPackagesInCache term
                | None -> listAllPackagesInCache ()

            if packages.IsEmpty then
                let searchText =
                    searchTerm |> Option.map (fun s -> $" matching '{s}'") |> Option.defaultValue ""

                CommandResult.Info($"No packages found{searchText} in local NuGet cache", "")
            else
                let packageList =
                    packages
                    |> List.map (fun (name, versions) ->
                        let versionText =
                            if versions.Length = 1 then
                                versions.Head
                            else
                                $"{versions.Length} versions (latest: {versions |> List.last})"

                        $"📦 {name} - {versionText}")
                    |> String.concat "\n"

                let message =
                    match searchTerm with
                    | Some term -> $"Found {packages.Length} packages matching '{term}'"
                    | None -> $"Found {packages.Length} packages in local cache"

                CommandResult.Info(message, packageList)

        with ex ->
            Error $"❌ Error listing packages: {ex.Message}"

    let showPackageInfo (packageName: string) : CommandResult =
        try
            match findPackageInCache packageName with
            | None -> Error $"❌ Package '{packageName}' not found in local NuGet cache"
            | Some packageVersion ->
                let versions = getPackageVersions packageName
                let assemblies = findAssembliesInPackage packageVersion.Path

                let info =
                    $"""📦 Package: {packageName}
📋 Current Version: {packageVersion.Version}
📅 Last Modified: {packageVersion.LastModified.ToString("yyyy-MM-dd HH:mm:ss")}
📁 Path: {packageVersion.Path}
🔢 Available Versions: {versions.Length} ({String.concat ", " versions})
🗂️ Assemblies Found: {assemblies.Length}"""

                let assemblyList =
                    if assemblies.IsEmpty then
                        "\n⚠️  No assemblies found"
                    else
                        assemblies
                        |> List.map (fun asm ->
                            let xmlExists = findXmlDocumentationFile asm |> Option.isSome
                            let xmlText = if xmlExists then " (with XML docs)" else ""
                            $"   - {Path.GetFileName asm}{xmlText}")
                        |> String.concat "\n"
                        |> fun list -> $"\nAssemblies:\n{list}"

                CommandResult.Info($"Package information for '{packageName}'", info + assemblyList)

        with ex ->
            Error $"❌ Error getting package info: {ex.Message}"

    let showCurrentConfig () : CommandResult =
        let configInfo =
            $"""📋 Current Documentation Configuration:

🗂️  Output Directory: {globalConfig.OutputDirectory}
📝 Include XML Docs: {globalConfig.IncludeXmlDocs}
🔄 Overwrite Existing: {globalConfig.OverwriteExisting}
📊 Max Types Per Package: {globalConfig.MaxTypesPerPackage
                           |> Option.map string
                           |> Option.defaultValue "No limit"}
📄 Markdown Format: {globalConfig.MarkdownFormat}
🗃️  NuGet Cache: {getGlobalNuGetCachePath ()}"""

        CommandResult.Info("Current configuration", configInfo)

    // === LIBRARY RESEARCH COMMANDS ===

    /// Research a library and generate overview documentation
    let researchLibrary (libraryName: string) (outputDir: string option) : CommandResult =

        try
            let actualOutputDir = outputDir |> Option.defaultValue globalConfig.OutputDirectory

            match LibraryResearch.generateLibraryOverview libraryName actualOutputDir None with
            | Result.Ok filePath ->
                let message = sprintf "✅ Successfully researched and documented '%s'" libraryName

                let details =
                    sprintf
                        """📁 Overview file: %s
    📊 Research Summary:
      - Generated comprehensive library overview
      - Included example usage patterns  
      - Added namespace tree template
      - Provided quick reference links
      - Created AI agent usage guide

    💡 Next Steps:
      - Use 'docGen "%s"' for detailed API documentation
      - Use search tools to find specific methods
      - Reference the official documentation links"""
                        filePath
                        libraryName

                CommandResult.Success(message, Some details)

            | Result.Error err -> CommandResult.Error(sprintf "❌ Research failed: %s" err)

        with ex ->
            CommandResult.Error(sprintf "❌ Unexpected error: %s" ex.Message)

    // === COMMAND EXECUTION ===

    let executeCommand (command: DocCommand) : CommandResult =
        match command with
        | GeneratePackageDoc(packageName, outputDir, overwrite) ->
            generatePackageDocumentation packageName outputDir overwrite

        | GenerateProjectDoc(projectPath, outputDir, overwrite) ->
            generateProjectDocumentation projectPath outputDir overwrite

        | ResearchLibrary(libraryName, outputDir) -> researchLibrary libraryName outputDir

        | ListCachedPackages searchTerm -> listCachedPackages searchTerm

        | ShowPackageInfo packageName -> showPackageInfo packageName

        | ShowConfig -> showCurrentConfig ()

        | SetOutputDir outputDir ->
            try
                setOutputDirectory outputDir
                CommandResult.Success($"✅ Output directory set to: {outputDir}", None)
            with ex ->
                Error $"❌ Failed to set output directory: {ex.Message}"

    // === CONVENIENCE FUNCTIONS FOR FSI ===

    let docGen (packageName: string) : unit =
        let result = executeCommand (GeneratePackageDoc(packageName, None, false))

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    let docGenProject (projectPath: string) : unit =
        let result = executeCommand (GenerateProjectDoc(projectPath, None, false))

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    /// Research and document a library overview
    let researchLib (libraryName: string) : unit =
        let result = executeCommand (ResearchLibrary(libraryName, None))

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    let docList (searchTerm: string option) : unit =
        let result = executeCommand (ListCachedPackages searchTerm)

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    let docInfo (packageName: string) : unit =
        let result = executeCommand (ShowPackageInfo packageName)

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    let docConfig () : unit =
        let result = executeCommand ShowConfig

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    let docSetOutputDir (outputDir: string) : unit =
        let result = executeCommand (SetOutputDir outputDir)

        match result with
        | Success(msg, details) ->
            printfn "%s" msg
            details |> Option.iter (printfn "%s")
        | Error msg -> printfn "%s" msg
        | Info(msg, data) -> printfn "%s\n%s" msg data

    // === MARKDOWN SEARCH COMMANDS ===

    /// Search for identifiers in generated documentation
    let searchDocumentation (searchTerm: string) (docsDir: string option) : CommandResult =
        try
            let searchDir = docsDir |> Option.defaultValue globalConfig.OutputDirectory

            if not (Directory.Exists searchDir) then
                Error $"Documentation directory does not exist: {searchDir}"
            else
                match DocGenerator.searchMarkdownDocumentation searchTerm searchDir with
                | Ok results ->
                    if results.IsEmpty then
                        CommandResult.Info("No matches found", $"No matches for '{searchTerm}' in {searchDir}")
                    else
                        let formatted = DocGenerator.formatSearchResults results

                        let fileCount =
                            results |> List.map (fun r -> r.FileName) |> List.distinct |> List.length

                        CommandResult.Success($"Found {results.Length} matches in {fileCount} files", Some formatted)
                | FSharp.Core.Result.Error err -> Error $"Search failed: {err}"
        with ex ->
            Error $"Search error: {ex.Message}"

    /// Quick search returning just file paths (for programmatic use)
    let quickSearchFiles (searchTerm: string) (docsDir: string option) : string list =
        let searchDir = docsDir |> Option.defaultValue globalConfig.OutputDirectory
        // Simplified implementation - could be enhanced to return actual file paths
        match DocGenerator.searchMarkdownDocumentation searchTerm searchDir with
        | Ok results -> results |> List.map (fun r -> r.FilePath) |> List.distinct
        | FSharp.Core.Result.Error _ -> []

    /// List all available documentation packages
    let listDocumentationPackages (docsDir: string option) : CommandResult =
        try
            let searchDir = docsDir |> Option.defaultValue globalConfig.OutputDirectory

            if not (Directory.Exists searchDir) then
                Error $"Documentation directory does not exist: {searchDir}"
            else
                let packageDirs =
                    Directory.GetDirectories(searchDir)
                    |> Array.map Path.GetFileName
                    |> Array.filter (fun name -> not (name.StartsWith(".")))
                    |> Array.sort

                if packageDirs.Length = 0 then
                    CommandResult.Info("No documentation packages found", $"Directory {searchDir} contains no packages")
                else
                    let packageList =
                        packageDirs
                        |> Array.map (fun pkg ->
                            let pkgPath = Path.Combine(searchDir, pkg)
                            let readmePath = Path.Combine(pkgPath, "README.md")

                            let typeCount =
                                if File.Exists readmePath then
                                    try
                                        let content = File.ReadAllText(readmePath)
                                        let lines = content.Split('\n')

                                        lines
                                        |> Array.filter (fun line -> line.StartsWith("- [") && line.Contains(".md"))
                                        |> Array.length
                                    with _ ->
                                        0
                                else
                                    0

                            $"  - {pkg} ({typeCount} types)")
                        |> String.concat "\n"

                    CommandResult.Success($"Found {packageDirs.Length} documentation packages", Some packageList)
        with ex ->
            Error $"Error listing packages: {ex.Message}"
