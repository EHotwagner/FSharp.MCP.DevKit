// FSharp.MCP.DevKit.Documentation/Tools/EnhancedDocGenerator.fs
// Enhanced documentation generator with centralized output and search index creation

namespace FSharp.MCP.DevKit.Documentation.Tools

open System
open System.IO
open FSharp.MCP.DevKit.Documentation.Model
open FSharp.MCP.DevKit.Documentation.Search.SearchIndex
open FSharp.MCP.DevKit.Documentation.Search.SearchIndexBuilder
open FSharp.MCP.DevKit.Documentation.Tools.DocGenerator
open FSharp.MCP.DevKit.Documentation.Tools.ProjectAnalyzer

/// Enhanced documentation generation with centralized structure and search indexing
module EnhancedDocGenerator =

    /// Enhanced project documentation configuration
    type EnhancedDocConfig =
        { ProjectFile: string
          OutputDirectory: string option // If None, uses docs/ relative to project
          OverwriteExisting: bool
          GenerateSearchIndex: bool
          CreateProjectTemplates: bool
          IncludeXmlDocs: bool }

    /// Result of enhanced project documentation generation
    type EnhancedProjectDocResult =
        { ProjectInfo: ProjectInfo
          DocumentationResults: ProjectDocResult
          SearchIndexPath: string option
          ProjectDocsCreated: string[]
          TotalGenerationTime: TimeSpan
          Success: bool
          Message: string }

    /// Default enhanced configuration
    let defaultEnhancedConfig (projectFile: string) =
        { ProjectFile = projectFile
          OutputDirectory = None
          OverwriteExisting = false
          GenerateSearchIndex = true
          CreateProjectTemplates = true
          IncludeXmlDocs = true }

    /// Create standardized directory structure for project documentation
    let createStandardDirectoryStructure (baseDir: string) : unit =
        let directories =
            [ baseDir
              Path.Combine(baseDir, "api")
              Path.Combine(baseDir, "api", "packages")
              Path.Combine(baseDir, "project")
              Path.Combine(baseDir, ".search") ]

        directories
        |> List.iter (fun dir ->
            if not (Directory.Exists(dir)) then
                Directory.CreateDirectory(dir) |> ignore)

    /// Generate project README template
    let private generateProjectReadme (projectName: string) : string =
        sprintf
            """# %s

## Overview

This project provides [brief description of the project's purpose and functionality].

## Getting Started

See [Getting Started Guide](project/getting-started.md) for detailed setup instructions.

## API Documentation

Complete API documentation is available in the [`api/`](api/) directory:

- [API Index](api/index.md) - Overview of all documented packages
- [Package Documentation](api/packages/) - Detailed API reference for each package

## Architecture

See [Architecture Overview](project/architecture.md) for system design and component relationships.

## Common Usage Patterns

See [API Usage Patterns](project/api-usage-patterns.md) for examples and best practices.

## Development

### Prerequisites

- .NET SDK 8.0 or later
- [Additional prerequisites as needed]

### Building

```bash
dotnet build
```

### Testing

```bash
dotnet test
```

---

*Documentation generated on %s using FSharp.MCP.DevKit.Documentation*
"""
            projectName
            (DateTime.UtcNow.ToString("yyyy-MM-dd"))

    /// Generate architecture documentation template
    let private generateArchitectureTemplate (projectName: string) : string =
        sprintf
            """# %s Architecture

## System Overview

[Describe the high-level architecture and design principles]

## Components

### Core Components

[List and describe main components]

### Dependencies

[Document key dependencies and their purposes]

## Design Patterns

[Describe important design patterns used in the project]

## Data Flow

[Describe how data flows through the system]

## Extension Points

[Document how the system can be extended]

---

*Last updated: %s*
"""
            projectName
            (DateTime.UtcNow.ToString("yyyy-MM-dd"))

    /// Generate getting started documentation template
    let private generateGettingStartedTemplate (projectName: string) : string =
        sprintf
            """# Getting Started with %s

## Quick Start

1. **Installation**
   ```bash
   [Installation instructions]
   ```

2. **Basic Usage**
   ```fsharp
   [Basic usage examples]
   ```

## Configuration

[Configuration options and examples]

## Examples

### Example 1: [Common Use Case]

```fsharp
[Example code]
```

### Example 2: [Another Use Case]

```fsharp
[Example code]
```

## Troubleshooting

### Common Issues

[List common issues and solutions]

## Next Steps

- Review the [API Documentation](../api/index.md)
- Study the [Architecture Overview](architecture.md)
- Explore [Common Usage Patterns](api-usage-patterns.md)

---

*Last updated: %s*
"""
            projectName
            (DateTime.UtcNow.ToString("yyyy-MM-dd"))

    /// Generate usage patterns documentation template
    let private generateUsagePatternsTemplate (projectName: string) : string =
        sprintf
            """# %s API Usage Patterns

## Common Patterns

### Pattern 1: [Pattern Name]

**Use Case**: [When to use this pattern]

```fsharp
[Example code]
```

**Key Points**:
- [Important consideration 1]
- [Important consideration 2]

### Pattern 2: [Pattern Name]

**Use Case**: [When to use this pattern]

```fsharp
[Example code]
```

**Key Points**:
- [Important consideration 1]
- [Important consideration 2]

## Best Practices

1. **[Practice 1]**: [Description]
2. **[Practice 2]**: [Description]
3. **[Practice 3]**: [Description]

## Anti-Patterns

### Avoid: [Anti-pattern Name]

[Description of what not to do and why]

## Performance Considerations

[Performance tips and optimization strategies]

---

*Last updated: %s*
"""
            projectName
            (DateTime.UtcNow.ToString("yyyy-MM-dd"))

    /// Generate project documentation templates
    let generateProjectDocumentationTemplates (projectDir: string) (projectName: string) : string[] =
        let templates =
            [ ("README.md", generateProjectReadme projectName)
              ("project/architecture.md", generateArchitectureTemplate projectName)
              ("project/getting-started.md", generateGettingStartedTemplate projectName)
              ("project/api-usage-patterns.md", generateUsagePatternsTemplate projectName) ]

        templates
        |> List.map (fun (relativePath, content) ->
            let fullPath = Path.Combine(projectDir, relativePath)
            let dir = Path.GetDirectoryName(fullPath)

            if not (Directory.Exists(dir)) then
                Directory.CreateDirectory(dir) |> ignore

            if not (File.Exists(fullPath)) then
                File.WriteAllText(fullPath, content)

            fullPath)
        |> List.toArray

    /// Generate API index with package summary
    let generateApiIndex (projectResult: ProjectDocResult) (outputDir: string) : unit =
        let apiIndexPath = Path.Combine(outputDir, "api", "index.md")

        let packageSummaries =
            projectResult.DocumentationResults
            |> List.map (fun (packageName, result) ->
                match result with
                | Ok docResult ->
                    let xmlDocsStatus = if docResult.HasXmlDocs then "✅ Yes" else "❌ No"

                    sprintf
                        """### [%s](packages/%s/)

- **Version**: %s
- **Types**: %s
- **Methods**: %s
- **Properties**: %s
- **Has XML Documentation**: %s

"""
                        packageName
                        packageName
                        docResult.Version
                        (docResult.TypesDocumented.ToString("N0"))
                        (docResult.MethodsDocumented.ToString("N0"))
                        (docResult.PropertiesDocumented.ToString("N0"))
                        xmlDocsStatus
                | Error err ->
                    sprintf
                        """### %s (Failed)

- **Error**: %s

"""
                        packageName
                        err)
            |> String.concat "\n"

        let totalTypes =
            projectResult.DocumentationResults
            |> List.sumBy (fun (_, result) ->
                match result with
                | Ok docResult -> docResult.TypesDocumented
                | Error _ -> 0)

        let totalMethods =
            projectResult.DocumentationResults
            |> List.sumBy (fun (_, result) ->
                match result with
                | Ok docResult -> docResult.MethodsDocumented
                | Error _ -> 0)

        let totalProperties =
            projectResult.DocumentationResults
            |> List.sumBy (fun (_, result) ->
                match result with
                | Ok docResult -> docResult.PropertiesDocumented
                | Error _ -> 0)

        let content =
            sprintf
                """# API Documentation Index

## Project Overview

**Project**: %s
**Generated**: %s UTC

## Package Summary

%s

## Statistics

- **Total Packages**: %d
- **Successful Generations**: %d
- **Failed Generations**: %d
- **Total Types**: %s
- **Total Methods**: %s
- **Total Properties**: %s
- **Generation Time**: %.2f seconds

## Search & Discovery

This documentation includes an intelligent search index optimized for development workflows:

- Use the search tools to find APIs by functionality
- Explore type relationships and common usage patterns
- Access contextual information for efficient development

---

*Generated using FSharp.MCP.DevKit.Documentation*
"""
                projectResult.ProjectInfo.ProjectName
                (DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"))
                packageSummaries
                projectResult.TotalPackages
                projectResult.SuccessfulDocs
                projectResult.FailedDocs
                (totalTypes.ToString("N0"))
                (totalMethods.ToString("N0"))
                (totalProperties.ToString("N0"))
                projectResult.TotalGenerationTime.TotalSeconds

        File.WriteAllText(apiIndexPath, content)

    /// Enhanced project documentation generation with search index
    let generateProjectDocumentationEnhanced (config: EnhancedDocConfig) : Result<EnhancedProjectDocResult, string> =
        let startTime = DateTime.UtcNow

        try
            // Determine output directory
            let projectDir = Path.GetDirectoryName(config.ProjectFile)

            let outputDir =
                config.OutputDirectory |> Option.defaultValue (Path.Combine(projectDir, "docs"))

            // Create standardized directory structure
            createStandardDirectoryStructure outputDir

            // Configure regular documentation generation
            let docConfig =
                { OutputDirectory = Path.Combine(outputDir, "api")
                  IncludeXmlDocs = config.IncludeXmlDocs
                  OverwriteExisting = config.OverwriteExisting
                  MaxTypesPerPackage = None
                  MarkdownFormat = EnhancedReference }

            // Generate project documentation
            let projectResult = generateDocumentationForProject config.ProjectFile docConfig

            match projectResult with
            | Ok projResult ->
                // Generate API index
                generateApiIndex projResult outputDir

                // Create project documentation templates
                let templateFiles =
                    if config.CreateProjectTemplates then
                        generateProjectDocumentationTemplates outputDir projResult.ProjectInfo.ProjectName
                    else
                        [||]

                // Build search index if requested
                let searchIndexPath =
                    if config.GenerateSearchIndex then
                        let searchDir = Path.Combine(outputDir, ".search")

                        // Extract documentation nodes from project results
                        // For now, using empty list as placeholder - would need to extract from DocumentationResults
                        let allDocs = []

                        let packageNames = projResult.DocumentationResults |> List.map fst |> List.toArray

                        let projectInfo =
                            { Name = projResult.ProjectInfo.ProjectName
                              ProjectFile = Some config.ProjectFile
                              Packages = packageNames
                              GeneratedAt = DateTime.UtcNow
                              Version = "1.0.0" }

                        match buildAndSaveSearchIndex allDocs projectInfo searchDir with
                        | Ok _ -> Some searchDir
                        | Error _ -> None
                    else
                        None

                let totalTime = DateTime.UtcNow - startTime

                let result =
                    { ProjectInfo = projResult.ProjectInfo
                      DocumentationResults = projResult
                      SearchIndexPath = searchIndexPath
                      ProjectDocsCreated = templateFiles
                      TotalGenerationTime = totalTime
                      Success = true
                      Message = $"Enhanced documentation generated successfully in {totalTime.TotalSeconds:F2} seconds" }

                Ok result

            | Error err -> Error $"Failed to generate project documentation: {err}"

        with ex ->
            Error $"Unexpected error during enhanced documentation generation: {ex.Message}"

    /// Simple interface for enhanced project documentation
    let docGenProjectEnhanced (projectFile: string) : Result<EnhancedProjectDocResult, string> =
        let config = defaultEnhancedConfig projectFile
        generateProjectDocumentationEnhanced config

    /// Enhanced project documentation with custom output directory
    let docGenProjectEnhancedTo (projectFile: string) (outputDir: string) : Result<EnhancedProjectDocResult, string> =
        let config =
            { defaultEnhancedConfig projectFile with
                OutputDirectory = Some outputDir }

        generateProjectDocumentationEnhanced config
