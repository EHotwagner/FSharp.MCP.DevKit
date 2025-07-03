// FSharp.MCP.DevKit.Documentation/Tools/ProjectAnalyzer.fs
// Analyzes F# project files to extract NuGet package references

namespace FSharp.MCP.DevKit.Documentation.Tools

open System
open System.IO
open System.Xml.Linq
open FSharp.MCP.DevKit.Documentation.Tools.DocGenerator

module ProjectAnalyzer =

    // === PROJECT ANALYSIS TYPES ===

    type PackageReference =
        { Name: string
          Version: string option
          IsPrivate: bool }

    type ProjectInfo =
        { ProjectPath: string
          PackageReferences: PackageReference list
          TargetFramework: string option
          ProjectName: string }

    type ProjectDocResult =
        { ProjectInfo: ProjectInfo
          DocumentationResults: (string * Result<DocGenerationResult, string>) list
          TotalPackages: int
          SuccessfulDocs: int
          FailedDocs: int
          TotalGenerationTime: TimeSpan }

    // === PROJECT FILE PARSING ===

    let parseProjectFile (projectPath: string) : Result<ProjectInfo, string> =
        try
            if not (File.Exists projectPath) then
                Error $"Project file not found: {projectPath}"
            else
                let doc = XDocument.Load(projectPath)
                let projectName = Path.GetFileNameWithoutExtension(projectPath)

                // Extract target framework
                let targetFramework =
                    doc.Descendants(XName.Get("TargetFramework"))
                    |> Seq.tryHead
                    |> Option.map (fun elem -> elem.Value)

                // Extract package references
                let packageReferences =
                    doc.Descendants(XName.Get("PackageReference"))
                    |> Seq.choose (fun elem ->
                        let includeAttr = elem.Attribute(XName.Get("Include"))

                        if includeAttr <> null then
                            let packageName = includeAttr.Value

                            let version =
                                elem.Attribute(XName.Get("Version"))
                                |> Option.ofObj
                                |> Option.map (fun attr -> attr.Value)

                            let isPrivate =
                                elem.Attribute(XName.Get("PrivateAssets"))
                                |> Option.ofObj
                                |> Option.map (fun attr -> attr.Value = "all")
                                |> Option.defaultValue false

                            Some
                                { Name = packageName
                                  Version = version
                                  IsPrivate = isPrivate }
                        else
                            None)
                    |> List.ofSeq

                let projectInfo =
                    { ProjectPath = projectPath
                      PackageReferences = packageReferences
                      TargetFramework = targetFramework
                      ProjectName = projectName }

                Ok projectInfo

        with ex ->
            Error $"Error parsing project file '{projectPath}': {ex.Message}"

    // === BATCH DOCUMENTATION GENERATION ===

    let generateDocumentationForProject
        (projectPath: string)
        (config: DocGenConfig)
        : Result<ProjectDocResult, string> =
        try
            let startTime = DateTime.Now

            match parseProjectFile projectPath with
            | Error err -> Error err
            | Ok projectInfo ->

                printfn "📁 Analyzing project: %s" projectInfo.ProjectName
                printfn "🎯 Target Framework: %s" (projectInfo.TargetFramework |> Option.defaultValue "Unknown")
                printfn "📦 Found %d package references" projectInfo.PackageReferences.Length

                // Filter out private assets (like analyzers, build tools)
                let packagesToDocument =
                    projectInfo.PackageReferences |> List.filter (fun pkg -> not pkg.IsPrivate)

                printfn "📝 Will generate docs for %d packages (excluding private assets)" packagesToDocument.Length

                if packagesToDocument.IsEmpty then
                    let result =
                        { ProjectInfo = projectInfo
                          DocumentationResults = []
                          TotalPackages = 0
                          SuccessfulDocs = 0
                          FailedDocs = 0
                          TotalGenerationTime = TimeSpan.Zero }

                    Ok result
                else
                    // Generate documentation for each package
                    let documentationResults =
                        packagesToDocument
                        |> List.map (fun pkg ->
                            printfn "📖 Generating docs for: %s" pkg.Name
                            let result = generateDocumentationForPackage pkg.Name config
                            (pkg.Name, result))

                    let endTime = DateTime.Now
                    let totalTime = endTime - startTime

                    let successfulDocs =
                        documentationResults
                        |> List.filter (fun (_, result) ->
                            match result with
                            | Ok _ -> true
                            | Error _ -> false)
                        |> List.length

                    let failedDocs = documentationResults.Length - successfulDocs

                    let result =
                        { ProjectInfo = projectInfo
                          DocumentationResults = documentationResults
                          TotalPackages = packagesToDocument.Length
                          SuccessfulDocs = successfulDocs
                          FailedDocs = failedDocs
                          TotalGenerationTime = totalTime }

                    Ok result

        with ex ->
            Error $"Error generating documentation for project '{projectPath}': {ex.Message}"

    // === REPORTING ===

    let generateProjectDocumentationSummary (result: ProjectDocResult) : string =
        let successfulPackages =
            result.DocumentationResults
            |> List.choose (fun (name, docResult) ->
                match docResult with
                | Ok docGen -> Some(name, docGen)
                | Error _ -> None)

        let failedPackages =
            result.DocumentationResults
            |> List.choose (fun (name, docResult) ->
                match docResult with
                | Error err -> Some(name, err)
                | Ok _ -> None)

        let successSection =
            if successfulPackages.IsEmpty then
                ""
            else
                let successList =
                    successfulPackages
                    |> List.map (fun (name, docGen) ->
                        $"- **{name}** (v{docGen.Version}): {docGen.TypesDocumented} types, {docGen.MethodsDocumented} methods, {docGen.PropertiesDocumented} properties")
                    |> String.concat "\n"

                $"""
## ✅ Successfully Generated Documentation

{successList}"""

        let failureSection =
            if failedPackages.IsEmpty then
                ""
            else
                let failureList =
                    failedPackages
                    |> List.map (fun (name, err) -> $"- **{name}**: {err}")
                    |> String.concat "\n"

                $"""
## ❌ Failed to Generate Documentation

{failureList}"""

        let totalStats =
            successfulPackages
            |> List.fold
                (fun (types, methods, props) (_, docGen) ->
                    (types + docGen.TypesDocumented,
                     methods + docGen.MethodsDocumented,
                     props + docGen.PropertiesDocumented))
                (0, 0, 0)

        let (totalTypes, totalMethods, totalProperties) = totalStats

        $"""# Documentation Generation Summary

**Project:** {result.ProjectInfo.ProjectName}
**Target Framework:** {result.ProjectInfo.TargetFramework |> Option.defaultValue "Unknown"}
**Generation Time:** {result.TotalGenerationTime.TotalSeconds:F2} seconds

## 📊 Statistics

- **Total Packages:** {result.TotalPackages}
- **Successful:** {result.SuccessfulDocs}
- **Failed:** {result.FailedDocs}
- **Total Types Documented:** {totalTypes}
- **Total Methods Documented:** {totalMethods}
- **Total Properties Documented:** {totalProperties}{successSection}{failureSection}"""

    // === PACKAGE DISCOVERY UTILITIES ===

    let listAllPackagesInCache () : (string * string list) list =
        try
            let globalPackagesPath = getGlobalNuGetCachePath ()

            if Directory.Exists(globalPackagesPath) then
                Directory.GetDirectories(globalPackagesPath)
                |> Array.map (fun packageDir ->
                    let packageName = Path.GetFileName(packageDir)

                    let versions =
                        Directory.GetDirectories(packageDir)
                        |> Array.map Path.GetFileName
                        |> Array.toList
                        |> List.sort

                    (packageName, versions))
                |> Array.toList
            else
                []
        with ex ->
            printfn "Error listing packages in cache: %s" ex.Message
            []

    let searchPackagesInCache (searchTerm: string) : (string * string list) list =
        listAllPackagesInCache ()
        |> List.filter (fun (packageName, _) -> packageName.ToLower().Contains(searchTerm.ToLower()))

    let getPackageVersions (packageName: string) : string list =
        match findPackageInCache packageName with
        | None -> []
        | Some packageVersion ->
            try
                let packageDir = Path.GetDirectoryName(packageVersion.Path)

                Directory.GetDirectories(packageDir)
                |> Array.map Path.GetFileName
                |> Array.toList
                |> List.sort
            with _ ->
                [ packageVersion.Version ]
