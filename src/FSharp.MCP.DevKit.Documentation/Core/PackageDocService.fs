// FSharp.MCP.DevKit.Documentation/Core/PackageDocService.fs
namespace FSharp.MCP.DevKit.Documentation.Core

open System
open System.IO
open System.Threading.Tasks
open FSharp.MCP.DevKit.Documentation.Model
open FSharp.MCP.DevKit.Documentation.NuGet

/// Core service for generating package documentation
module PackageDocService =

    let private tempDownloadPath = Path.Combine(Path.GetTempPath(), "nuget-docs")

    /// Generate documentation for a package by name (uses global cache)
    let fromPackageAsync (packageName: string) (version: string) : Task<Result<PackageDocumentation, DocError>> =
        task {
            try
                // Get package from global cache instead of downloading
                let cacheResult = PackageDownloader.getPackageFromCache packageName

                match cacheResult with
                | Error err -> return Error err
                | Ok download ->
                    // Create package info
                    let packageInfo =
                        { Name = packageName
                          Version = version
                          Dependencies = [] // TODO: Extract from package
                          Source = Online "https://api.nuget.org/v3/index.json" }

                    // Parse XML documentation if available
                    let xmlDocs =
                        match download.XmlDocPath with
                        | Some xmlPath -> XmlDocumentationParser.parseXmlDocFile xmlPath
                        | Option.None -> Map.empty<string, XmlDocumentation>

                    // Analyze all assemblies
                    let mutable allNodes = []
                    let mutable allAssemblies = []

                    for assemblyPath in download.AssemblyPaths do
                        match AssemblyAnalyzer.analyzeAssembly assemblyPath packageInfo xmlDocs with
                        | Ok nodes ->
                            allNodes <- allNodes @ nodes

                            let assemblyInfo =
                                { Name = Path.GetFileNameWithoutExtension(assemblyPath)
                                  FullName = assemblyPath
                                  Location = assemblyPath
                                  Package = packageInfo }

                            allAssemblies <- assemblyInfo :: allAssemblies
                        | Error err -> printfn "Warning: Failed to analyze assembly %s: %A" assemblyPath err

                    let documentation =
                        { Package = packageInfo
                          Assemblies = List.rev allAssemblies
                          RootNodes = allNodes }

                    return Ok documentation

            with ex ->
                return Error(ParseError($"Failed to process package {packageName}:{version}", ex))
        }

    /// Synchronous wrapper for fromPackageAsync
    let fromPackage (packageName: string) (version: string) : Result<PackageDocumentation, DocError> =
        (fromPackageAsync packageName version).Result

    /// Generate documentation for a local package file
    let fromLocalPackage (packagePath: string) : Result<PackageDocumentation, DocError> =
        try
            if not (File.Exists(packagePath)) then
                Error(PackageNotFound packagePath)
            else
                // Create extraction directory
                let fileName = Path.GetFileNameWithoutExtension(packagePath)
                let extractPath = Path.Combine(tempDownloadPath, $"local-{fileName}")
                Directory.CreateDirectory(extractPath) |> ignore

                // Extract the package
                match PackageDownloader.extractLocalPackage packagePath extractPath with
                | Error err -> Error err
                | Ok download ->
                    // Create package info
                    let packageInfo =
                        { Name = fileName
                          Version = "local"
                          Dependencies = []
                          Source = LocalFile packagePath }

                    // Parse XML documentation if available
                    let xmlDocs =
                        match download.XmlDocPath with
                        | Some xmlPath -> XmlDocumentationParser.parseXmlDocFile xmlPath
                        | Option.None -> Map.empty

                    // Analyze all assemblies
                    let mutable allNodes = []
                    let mutable allAssemblies = []

                    for assemblyPath in download.AssemblyPaths do
                        match AssemblyAnalyzer.analyzeAssembly assemblyPath packageInfo xmlDocs with
                        | Ok nodes ->
                            allNodes <- allNodes @ nodes

                            let assemblyInfo =
                                { Name = Path.GetFileNameWithoutExtension(assemblyPath)
                                  FullName = assemblyPath
                                  Location = assemblyPath
                                  Package = packageInfo }

                            allAssemblies <- assemblyInfo :: allAssemblies
                        | Error err -> printfn "Warning: Failed to analyze assembly %s: %A" assemblyPath err

                    let documentation =
                        { Package = packageInfo
                          Assemblies = List.rev allAssemblies
                          RootNodes = allNodes }

                    Ok documentation

        with ex ->
            Error(ParseError($"Failed to process local package {packagePath}", ex))

    /// Generate documentation for an assembly directly
    let fromAssembly (assemblyPath: string) : Result<PackageDocumentation, DocError> =
        try
            if not (File.Exists(assemblyPath)) then
                Error(PackageNotFound assemblyPath)
            else
                let fileName = Path.GetFileNameWithoutExtension(assemblyPath)

                let packageInfo =
                    { Name = fileName
                      Version = "assembly"
                      Dependencies = []
                      Source = LocalFile assemblyPath }

                // Look for XML documentation file next to assembly
                let xmlDocPath = Path.ChangeExtension(assemblyPath, ".xml")

                let xmlDocs =
                    if File.Exists(xmlDocPath) then
                        XmlDocumentationParser.parseXmlDocFile xmlDocPath
                    else
                        Map.empty<string, XmlDocumentation>

                // Analyze the assembly
                match AssemblyAnalyzer.analyzeAssembly assemblyPath packageInfo xmlDocs with
                | Ok nodes ->
                    let assemblyInfo =
                        { Name = fileName
                          FullName = assemblyPath
                          Location = assemblyPath
                          Package = packageInfo }

                    let documentation =
                        { Package = packageInfo
                          Assemblies = [ assemblyInfo ]
                          RootNodes = nodes }

                    Ok documentation
                | Error err -> Error err

        with ex ->
            Error(AssemblyLoadFailed(assemblyPath, ex))
