// FSharp.MCP.DevKit.Documentation/NuGet/PackageDownloader.fs
namespace FSharp.MCP.DevKit.Documentation.NuGet

open System
open System.IO
open NuGet.Packaging
open FSharp.MCP.DevKit.Documentation.Model

/// Package discovery result from global cache
type DownloadResult =
    { PackagePath: string
      XmlDocPath: string option
      AssemblyPaths: string list }

/// NuGet package cache analyzer - focuses on packages already in global cache
module PackageDownloader =

    /// Find a package in the user's global NuGet cache
    let findPackageInCache (packageName: string) : string option =
        try
            let globalPackagesPath =
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                |> fun userProfile -> Path.Combine(userProfile, ".nuget", "packages")

            let packageDir = Path.Combine(globalPackagesPath, packageName.ToLower())

            if Directory.Exists(packageDir) then
                let versions = Directory.GetDirectories(packageDir)

                if versions.Length > 0 then
                    // Take the latest version (alphabetically last)
                    let latestVersion = versions |> Array.last
                    Some latestVersion
                else
                    None
            else
                None
        with ex ->
            printfn "⚠ Error accessing global cache for %s: %s" packageName ex.Message
            None

    /// Find all assemblies in a package directory
    let findAssembliesInPackage (packagePath: string) : string list =
        try
            let libFolders =
                [ Path.Combine(packagePath, "lib"); Path.Combine(packagePath, "ref") ]

            let assemblies = ResizeArray<string>()

            for libFolder in libFolders do
                if Directory.Exists(libFolder) then
                    let dllFiles = Directory.GetFiles(libFolder, "*.dll", SearchOption.AllDirectories)
                    assemblies.AddRange(dllFiles)

            assemblies |> Seq.toList
        with ex ->
            printfn "⚠ Error finding assemblies in %s: %s" packagePath ex.Message
            []

    /// Find XML documentation in a package directory
    let findXmlDocsInPackage (packagePath: string) : string option =
        try
            let libFolders =
                [ Path.Combine(packagePath, "lib"); Path.Combine(packagePath, "ref") ]

            let mutable result = None

            for libFolder in libFolders do
                if Directory.Exists(libFolder) && result.IsNone then
                    let xmlFiles = Directory.GetFiles(libFolder, "*.xml", SearchOption.AllDirectories)

                    if xmlFiles.Length > 0 then
                        result <- Some xmlFiles.[0]

            result
        with ex ->
            printfn "⚠ Error finding XML docs in %s: %s" packagePath ex.Message
            None

    /// Get package information from global cache (replaces downloadPackage)
    let getPackageFromCache (packageName: string) : Result<DownloadResult, DocError> =
        match findPackageInCache packageName with
        | Some packagePath ->
            let assemblyPaths = findAssembliesInPackage packagePath
            let xmlDocPath = findXmlDocsInPackage packagePath

            let result =
                { PackagePath = packagePath
                  XmlDocPath = xmlDocPath
                  AssemblyPaths = assemblyPaths }

            Ok result
        | None -> Error(PackageNotFound $"Package {packageName} not found in global cache")

    /// List all available packages in the global cache
    let listAvailablePackages () : string list =
        try
            let globalPackagesPath =
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                |> fun userProfile -> Path.Combine(userProfile, ".nuget", "packages")

            if Directory.Exists(globalPackagesPath) then
                Directory.GetDirectories(globalPackagesPath)
                |> Array.map Path.GetFileName
                |> Array.toList
            else
                []
        with ex ->
            printfn "⚠ Error listing packages in global cache: %s" ex.Message
            []

    /// Extract assemblies from a local .nupkg file
    let extractLocalPackage (packagePath: string) (extractPath: string) : Result<DownloadResult, DocError> =
        try
            if not (File.Exists(packagePath)) then
                Error(PackageNotFound packagePath)
            else
                Directory.CreateDirectory(extractPath) |> ignore

                let assemblyPaths = ResizeArray<string>()
                let mutable xmlDocPath = None

                using (new PackageArchiveReader(packagePath)) (fun packageReader ->
                    // Get lib files (assemblies)
                    let libItems = packageReader.GetLibItems()

                    for libItem in libItems do
                        for file in libItem.Items do
                            if file.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) then
                                let fileName = Path.GetFileName(file)
                                let fullExtractPath = Path.Combine(extractPath, fileName)
                                use entryStream = packageReader.GetStream(file)
                                use fileStream = File.Create(fullExtractPath)
                                entryStream.CopyTo(fileStream)
                                assemblyPaths.Add(fullExtractPath)
                            elif file.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) then
                                let fileName = Path.GetFileName(file)
                                let fullExtractPath = Path.Combine(extractPath, fileName)
                                use entryStream = packageReader.GetStream(file)
                                use fileStream = File.Create(fullExtractPath)
                                entryStream.CopyTo(fileStream)
                                xmlDocPath <- Some fullExtractPath)

                let result =
                    { PackagePath = packagePath
                      XmlDocPath = xmlDocPath
                      AssemblyPaths = assemblyPaths |> Seq.toList }

                Ok result
        with ex ->
            Error(ParseError($"Failed to extract local package {packagePath}", ex))
