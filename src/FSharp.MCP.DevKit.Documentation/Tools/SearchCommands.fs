// FSharp.MCP.DevKit.Documentation/Tools/SearchCommands.fs
// MCP command interface for enhanced search and documentation tools

namespace FSharp.MCP.DevKit.Documentation.Tools

open System
open System.IO
open FSharp.MCP.DevKit.Documentation.Search.SearchService
open FSharp.MCP.DevKit.Documentation.Search.ContextAwareSearch
open FSharp.MCP.DevKit.Documentation.Tools.EnhancedDocGenerator

/// MCP commands for search and enhanced documentation generation
module SearchCommands =

    /// Search command types
    type SearchCommand =
        | SearchAPI of query: string * projectPath: string
        | SearchWithContext of query: string * currentFiles: string[] * projectPath: string
        | GetTypeInfo of typeName: string * projectPath: string
        | GetMethodInfo of typeName: string * projectPath: string
        | GetBatchTypeInfo of typeNames: string[] * projectPath: string
        | GetBatchMethodInfo of typeNames: string[] * projectPath: string
        | FindRelatedAPIs of typeName: string * projectPath: string
        | GetUsagePatterns of typeName: string * projectPath: string
        | GetProjectOverview of projectPath: string
        | ValidateDocumentation of projectPath: string
        | GetSearchRecommendations of currentFiles: string[] * projectPath: string

    /// Enhanced documentation generation commands
    type EnhancedDocCommand =
        | GenerateProjectDocumentationEnhanced of projectPath: string * outputDir: string option
        | InitializeProjectDocs of projectPath: string
        | BuildSearchIndex of projectPath: string * outputDir: string option

    /// Search command results
    type SearchCommandResult =
        | SearchResults of results: ApiSearchResult[]
        | TypeInfoResult of typeInfo: TypeSummary
        | MethodInfoResult of methods: MethodSummary[]
        | BatchTypeInfoResult of typeInfos: Map<string, TypeSummary>
        | BatchMethodInfoResult of methodInfos: Map<string, MethodSummary[]>
        | UsagePatternsResult of patterns: UseCaseSummary[]
        | ProjectOverviewResult of projectInfo: ProjectInfo * stats: IndexStats
        | ValidationResult of isUpToDate: bool * lastGenerated: DateTime
        | SuccessMessage of message: string
        | ErrorMessage of error: string

    /// Execute search command
    let executeSearchCommand (command: SearchCommand) : SearchCommandResult =
        match command with
        | SearchAPI (query, projectPath) ->
            match searchAPI query projectPath with
            | Ok results -> SearchResults results
            | Error err -> ErrorMessage err

        | SearchWithContext (query, currentFiles, projectPath) ->
            match searchWithContext query currentFiles projectPath with
            | Ok results -> SearchResults results
            | Error err -> ErrorMessage err

        | GetTypeInfo (typeName, projectPath) ->
            match getTypeInfoCached typeName projectPath with
            | Ok typeInfo -> TypeInfoResult typeInfo
            | Error err -> ErrorMessage err

        | GetMethodInfo (typeName, projectPath) ->
            match getMethodInfo typeName projectPath with
            | Ok methods -> MethodInfoResult methods
            | Error err -> ErrorMessage err

        | GetBatchTypeInfo (typeNames, projectPath) ->
            match getMultipleTypeInfo typeNames projectPath with
            | Ok typeInfos -> BatchTypeInfoResult typeInfos
            | Error err -> ErrorMessage err

        | GetBatchMethodInfo (typeNames, projectPath) ->
            match getMultipleMethodInfo typeNames projectPath with
            | Ok methodInfos -> BatchMethodInfoResult methodInfos
            | Error err -> ErrorMessage err

        | FindRelatedAPIs (typeName, projectPath) ->
            match findRelatedAPIs typeName projectPath with
            | Ok results -> SearchResults results
            | Error err -> ErrorMessage err

        | GetUsagePatterns (typeName, projectPath) ->
            match getUsagePatterns typeName projectPath with
            | Ok patterns -> UsagePatternsResult patterns
            | Error err -> ErrorMessage err

        | GetProjectOverview projectPath ->
            match getProjectOverview projectPath with
            | Ok (projectInfo, stats) -> ProjectOverviewResult (projectInfo, stats)
            | Error err -> ErrorMessage err

        | ValidateDocumentation projectPath ->
            match validateDocumentation projectPath with
            | Ok (isUpToDate, lastGenerated) -> ValidationResult (isUpToDate, lastGenerated)
            | Error err -> ErrorMessage err

        | GetSearchRecommendations (currentFiles, projectPath) ->
            let context = analyzeCurrentContext currentFiles
            match getSearchRecommendations context projectPath with
            | Ok results -> SearchResults results
            | Error err -> ErrorMessage err

    /// Execute enhanced documentation command
    let executeEnhancedDocCommand (command: EnhancedDocCommand) : SearchCommandResult =
        match command with
        | GenerateProjectDocumentationEnhanced (projectPath, outputDir) ->
            let config =
                match outputDir with
                | Some dir -> { defaultEnhancedConfig projectPath with OutputDirectory = Some dir }
                | None -> defaultEnhancedConfig projectPath

            match generateProjectDocumentationEnhanced config with
            | Ok result -> SuccessMessage result.Message
            | Error err -> ErrorMessage err

        | InitializeProjectDocs projectPath ->
            try
                let projectDir = Path.GetDirectoryName(projectPath)
                let docsDir = Path.Combine(projectDir, "docs")
                let projectName = Path.GetFileNameWithoutExtension(projectPath)

                createStandardDirectoryStructure docsDir
                let templateFiles = generateProjectDocumentationTemplates docsDir projectName

                SuccessMessage $"Project documentation structure initialized with {templateFiles.Length} template files"
            with
            | ex -> ErrorMessage $"Failed to initialize project docs: {ex.Message}"

        | BuildSearchIndex (projectPath, outputDir) ->
            // This would need to be implemented to rebuild just the search index
            ErrorMessage "BuildSearchIndex command not yet implemented"

    /// Format search results for display
    let formatSearchResults (results: ApiSearchResult[]) : string =
        if Array.isEmpty results then
            "No results found."
        else
            let formattedResults =
                results
                |> Array.mapi (fun i result ->
                    let elementType =
                        match result.ElementType with
                        | TypeElement -> "Type"
                        | MethodElement -> "Method"
                        | PropertyElement -> "Property"
                        | EventElement -> "Event"
                        | FieldElement -> "Field"

                    let matchType =
                        match result.MatchType with
                        | ExactMatch -> "Exact"
                        | SemanticMatch -> "Semantic"
                        | KeywordMatch -> "Keyword"
                        | UseCaseMatch -> "Use Case"

                    $"""{i + 1}. **{result.FullName}** ({elementType})
   - **Purpose**: {if String.IsNullOrEmpty(result.Purpose) then "No description available" else result.Purpose}
   - **Relevance**: {result.RelevanceScore:F2} ({matchType} match)
   - **Documentation**: {result.DocumentationPath}
""")
                |> String.concat "\n"

            $"""Found {results.Length} result(s):

{formattedResults}"""

    /// Format type information for display
    let formatTypeInfo (typeInfo: TypeSummary) : string =
        $"""**{typeInfo.FullName}** ({typeInfo.Kind})

**Package**: {typeInfo.Package}
**Namespace**: {typeInfo.Namespace}
**Purpose**: {if String.IsNullOrEmpty(typeInfo.Purpose) then "No description available" else typeInfo.Purpose}

**Key Methods**: {if Array.isEmpty typeInfo.KeyMethods then "None documented" else String.concat ", " typeInfo.KeyMethods}
**Key Properties**: {if Array.isEmpty typeInfo.KeyProperties then "None documented" else String.concat ", " typeInfo.KeyProperties}

**Documentation**: {typeInfo.DocumentationPath}
**Has XML Docs**: {if typeInfo.HasXmlDocs then "✅ Yes" else "❌ No"}
**Popularity Score**: {typeInfo.Popularity}
"""

    /// Format method information for display
    let formatMethodInfo (methods: MethodSummary[]) : string =
        if Array.isEmpty methods then
            "No methods found."
        else
            let formattedMethods =
                methods
                |> Array.mapi (fun i method ->
                    let staticLabel = if method.IsStatic then " (static)" else ""
                    $"""{i + 1}. **{method.Name}**{staticLabel}
   - **Return Type**: {method.ReturnType}
   - **Purpose**: {if String.IsNullOrEmpty(method.Purpose) then "No description available" else method.Purpose}
   - **Documentation**: {method.DocumentationPath}
   - **Has XML Docs**: {if method.HasXmlDocs then "✅" else "❌"}
""")
                |> String.concat "\n"

            $"""Found {methods.Length} method(s):

{formattedMethods}"""

    /// Format project overview for display
    let formatProjectOverview (projectInfo: ProjectInfo) (stats: IndexStats) : string =
        $"""# Project Overview: {projectInfo.Name}

**Generated**: {projectInfo.GeneratedAt.ToString("yyyy-MM-dd HH:mm:ss")} UTC
**Version**: {projectInfo.Version}
**Project File**: {projectInfo.ProjectFile |> Option.defaultValue "N/A"}

## Package Summary
{projectInfo.Packages |> Array.mapi (fun i pkg -> $"{i + 1}. {pkg}") |> String.concat "\n"}

## Statistics
- **Total Packages**: {stats.PackageCount:N0}
- **Total Types**: {stats.TotalTypes:N0}
- **Total Methods**: {stats.TotalMethods:N0}
- **Total Properties**: {stats.TotalProperties:N0}
- **Total Keywords**: {stats.TotalKeywords:N0}
- **Generation Time**: {stats.GenerationTime.TotalSeconds:F2} seconds

## Search Capabilities
This project has an intelligent search index optimized for agent-driven development workflows.
Use the search tools to efficiently discover APIs, explore type relationships, and find usage patterns.
"""
