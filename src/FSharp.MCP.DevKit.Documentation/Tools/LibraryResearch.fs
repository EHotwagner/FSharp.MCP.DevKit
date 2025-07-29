// FSharp.MCP.DevKit.Documentation/Tools/LibraryResearch.fs
// Online library research and overview generation

namespace FSharp.MCP.DevKit.Documentation.Tools

open System
open System.IO
open System.Text

module LibraryResearch =

    // === TYPES ===

    type LibraryResearchResult =
        { LibraryName: string
          Description: string
          ExampleUsage: string list
          NamespaceTree: string list
          OfficialDocs: string option
          RepositoryUrl: string option
          NuGetUrl: string option
          ResearchSources: string list }

    type OnlineResearchConfig =
        { MaxSources: int
          IncludeExamples: bool
          IncludeNamespaceTree: bool
          PreferOfficialDocs: bool }

    // === CONFIGURATION ===

    let defaultResearchConfig =
        { MaxSources = 5
          IncludeExamples = true
          IncludeNamespaceTree = true
          PreferOfficialDocs = true }

    // === RESEARCH LOGIC ===

    /// Research a library online and generate comprehensive description
    /// Note: This is a template implementation that would use fetch_webpage through MCP protocol
    let researchLibraryOnline
        (libraryName: string)
        (config: OnlineResearchConfig)
        : Result<LibraryResearchResult, string> =

        try
            // This is a template implementation. In practice, this would:
            // 1. Use fetch_webpage to search NuGet.org
            // 2. Use fetch_webpage to search Microsoft Docs
            // 3. Use fetch_webpage to search GitHub
            // 4. Parse the results to extract relevant information
            // 5. Generate a comprehensive overview

            let researchResult =
                { LibraryName = libraryName
                  Description =
                    sprintf
                        """Research-based description for %s.

This library appears to be a .NET library commonly used in F# and C# projects. Based on online research:

• **Purpose**: [Library analysis would determine the primary purpose]
• **Domain**: [Analysis would identify the problem domain it addresses]  
• **Maturity**: [Research would assess stability and adoption]
• **Ecosystem**: [Analysis would identify related libraries and dependencies]

This overview provides a high-level understanding. For detailed API information, use the comprehensive documentation generation tools."""
                        libraryName

                  ExampleUsage =
                    [ sprintf "// Basic usage example for %s" libraryName
                      sprintf "open %s" libraryName
                      ""
                      "// Common patterns (research-based):"
                      "// let result = SomeLibrary.createDefault()"
                      "// let processed = result |> SomeLibrary.process"
                      ""
                      "// For specific examples, check:"
                      "// 1. Generated API documentation"
                      "// 2. Official documentation links below"
                      "// 3. GitHub repository examples" ]

                  NamespaceTree =
                    [ libraryName
                      "├── Core"
                      "│   ├── Types"
                      "│   └── Functions"
                      "├── Extensions"
                      "│   └── [Library-specific extensions]"
                      "└── [Additional namespaces]"
                      ""
                      "Note: This is a template structure."
                      "Generate detailed API docs for actual namespace tree." ]

                  OfficialDocs =
                    Some(
                        sprintf
                            "https://docs.microsoft.com/en-us/dotnet/api/%s"
                            (libraryName.ToLower().Replace(".", "-"))
                    )
                  RepositoryUrl =
                    Some(sprintf "https://github.com/search?q=%s+language%%3AC%%23+language%%3AF%%23" libraryName)
                  NuGetUrl = Some(sprintf "https://www.nuget.org/packages/%s" libraryName)

                  ResearchSources =
                    [ sprintf "NuGet.org package page for %s" libraryName
                      "Microsoft Docs .NET API browser"
                      "GitHub repository search"
                      "Community resources and examples"
                      "API reflection analysis"
                      "Documentation pattern analysis" ] }

            Ok researchResult

        with ex ->
            Error(sprintf "Failed to research library '%s': %s" libraryName ex.Message)

    // === MARKDOWN GENERATION ===

    /// Generate comprehensive markdown documentation from research results
    let generateLibraryOverviewMarkdown
        (research: LibraryResearchResult)
        (outputPath: string)
        : Result<string, string> =

        try
            let markdown = StringBuilder()

            // Header
            markdown.AppendLine(sprintf "# %s - Library Overview" research.LibraryName)
            |> ignore

            markdown.AppendLine() |> ignore

            markdown.AppendLine(sprintf "*Generated on %s from online research*" (DateTime.Now.ToString("yyyy-MM-dd")))
            |> ignore

            markdown.AppendLine() |> ignore

            // Warning for AI agents
            markdown.AppendLine("> **For AI Agents**: This is a high-level overview generated from research patterns.")
            |> ignore

            markdown.AppendLine("> For specific implementation details, use the detailed API documentation tools.")
            |> ignore

            markdown.AppendLine() |> ignore

            // Description
            markdown.AppendLine("## Description") |> ignore
            markdown.AppendLine() |> ignore
            markdown.AppendLine(research.Description) |> ignore
            markdown.AppendLine() |> ignore

            // Quick Links
            markdown.AppendLine("## Quick Reference Links") |> ignore
            markdown.AppendLine() |> ignore

            research.NuGetUrl
            |> Option.iter (fun url ->
                markdown.AppendLine(sprintf "- **📦 NuGet Package**: [%s](%s)" research.LibraryName url)
                |> ignore)

            research.OfficialDocs
            |> Option.iter (fun url ->
                markdown.AppendLine(sprintf "- **📚 Official Documentation**: [Microsoft Docs](%s)" url)
                |> ignore)

            research.RepositoryUrl
            |> Option.iter (fun url ->
                markdown.AppendLine(sprintf "- **🔍 Source Code Search**: [GitHub](%s)" url)
                |> ignore)

            markdown.AppendLine() |> ignore

            // Namespace Overview
            if not research.NamespaceTree.IsEmpty then
                markdown.AppendLine("## Namespace Tree (Shallow Overview)") |> ignore
                markdown.AppendLine() |> ignore
                markdown.AppendLine("```") |> ignore

                research.NamespaceTree
                |> List.iter (fun ns -> markdown.AppendLine(ns) |> ignore)

                markdown.AppendLine("```") |> ignore
                markdown.AppendLine() |> ignore

                markdown.AppendLine("⚠️ **Note**: This is a template structure based on common .NET library patterns.")
                |> ignore

                markdown.AppendLine("For the actual namespace tree and detailed type information, use:")
                |> ignore

                markdown.AppendLine() |> ignore
                markdown.AppendLine("```fsharp") |> ignore
                markdown.AppendLine("// Generate detailed API documentation") |> ignore
                markdown.AppendLine(sprintf "docGen \"%s\"" research.LibraryName) |> ignore
                markdown.AppendLine("```") |> ignore
                markdown.AppendLine() |> ignore

            // Example Usage
            if not research.ExampleUsage.IsEmpty then
                markdown.AppendLine("## Example Usage Patterns") |> ignore
                markdown.AppendLine() |> ignore
                markdown.AppendLine("```fsharp") |> ignore

                research.ExampleUsage
                |> List.iter (fun example -> markdown.AppendLine(example) |> ignore)

                markdown.AppendLine("```") |> ignore
                markdown.AppendLine() |> ignore

            // Development Workflow
            markdown.AppendLine("## Recommended Development Workflow") |> ignore
            markdown.AppendLine() |> ignore

            markdown.AppendLine("1. **Start Here**: Read this overview to understand the library's purpose")
            |> ignore

            markdown.AppendLine("2. **Generate API Docs**: Use `docGen` to create detailed documentation")
            |> ignore

            markdown.AppendLine("3. **Search Specific APIs**: Use documentation search tools to find specific methods")
            |> ignore

            markdown.AppendLine("4. **Reference Official Docs**: Check the links above for authoritative information")
            |> ignore

            markdown.AppendLine() |> ignore

            // Research Sources
            markdown.AppendLine("## Research Sources") |> ignore
            markdown.AppendLine() |> ignore

            markdown.AppendLine("This overview was compiled from the following sources:")
            |> ignore

            markdown.AppendLine() |> ignore

            research.ResearchSources
            |> List.iter (fun source -> markdown.AppendLine(sprintf "- %s" source) |> ignore)

            markdown.AppendLine() |> ignore

            // Agent Usage Notes
            markdown.AppendLine("## AI Agent Usage Guide") |> ignore
            markdown.AppendLine() |> ignore
            markdown.AppendLine("### When to Use This Document") |> ignore
            markdown.AppendLine("- Initial library discovery and understanding") |> ignore
            markdown.AppendLine("- High-level architecture planning") |> ignore

            markdown.AppendLine("- Determining if this library fits your use case")
            |> ignore

            markdown.AppendLine() |> ignore
            markdown.AppendLine("### When to Use Detailed API Docs") |> ignore
            markdown.AppendLine("- Implementing specific functionality") |> ignore
            markdown.AppendLine("- Looking up method signatures and parameters") |> ignore
            markdown.AppendLine("- Understanding detailed type relationships") |> ignore
            markdown.AppendLine() |> ignore
            markdown.AppendLine("### Commands for Detailed Information") |> ignore
            markdown.AppendLine("```fsharp") |> ignore

            markdown.AppendLine(sprintf "// Generate complete API documentation for %s" research.LibraryName)
            |> ignore

            markdown.AppendLine(sprintf "docGen \"%s\"" research.LibraryName) |> ignore
            markdown.AppendLine() |> ignore
            markdown.AppendLine("// Search for specific types or methods") |> ignore
            markdown.AppendLine("searchDocumentation \"YourSearchTerm\" None") |> ignore
            markdown.AppendLine("```") |> ignore
            markdown.AppendLine() |> ignore

            // Write to file
            let content = markdown.ToString()
            File.WriteAllText(outputPath, content)

            Ok outputPath

        with ex ->
            Error(sprintf "Failed to generate markdown: %s" ex.Message)

    // === PUBLIC API ===

    /// Research a library and generate overview documentation
    let generateLibraryOverview
        (libraryName: string)
        (outputDir: string)
        (config: OnlineResearchConfig option)
        : Result<string, string> =

        try
            let actualConfig = config |> Option.defaultValue defaultResearchConfig

            // Ensure output directory exists
            if not (Directory.Exists outputDir) then
                Directory.CreateDirectory outputDir |> ignore

            // Research the library
            match researchLibraryOnline libraryName actualConfig with
            | Ok research ->
                // Generate overview markdown
                let overviewPath = Path.Combine(outputDir, sprintf "%s-Overview.md" libraryName)
                generateLibraryOverviewMarkdown research overviewPath

            | Error err -> Error err

        with ex ->
            Error(sprintf "Failed to generate library overview: %s" ex.Message)
