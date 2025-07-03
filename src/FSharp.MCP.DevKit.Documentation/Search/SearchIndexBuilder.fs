// FSharp.MCP.DevKit.Documentation/Search/SearchIndexBuilder.fs
// Search index building and serialization functionality

namespace FSharp.MCP.DevKit.Documentation.Search

open System
open System.IO
open System.Text.Json
open System.Text.Json.Serialization
open FSharp.MCP.DevKit.Documentation.Model
open FSharp.MCP.DevKit.Documentation.Search.SearchIndex

/// Search index building and serialization
module SearchIndexBuilder =

    /// JSON serialization options for search index
    let private jsonOptions =
        let options = JsonSerializerOptions()
        options.WriteIndented <- true
        options.PropertyNamingPolicy <- JsonNamingPolicy.CamelCase
        // options.Converters.Add(JsonFSharpConverter())  // Commented out until FSharp.SystemTextJson is available
        options

    /// Generate human-readable summary of the search index
    let private generateIndexSummary (searchDb: SearchDatabase) : string =
        let stats = searchDb.Metadata.IndexStatistics

        sprintf
            """# Search Index Summary

Generated: %s UTC
Version: %s

## Project Information
- **Name**: %s
- **Packages**: %d
- **Project File**: %s

## Index Statistics
- **Types**: %s
- **Methods**: %s
- **Properties**: %s
- **Keywords**: %s
- **Generation Time**: %.2f seconds

## Package Summary
%s

## File Structure
```
.search/
├── api-index.json          # Complete search database
├── type-index.json         # Type summaries for quick lookup
├── method-index.json       # Method summaries by declaring type
├── keyword-index.json      # Keyword to API mappings
├── metadata.json          # Index metadata and statistics
└── index-summary.md       # This human-readable summary
```

## Usage
This search index is optimized for agent-driven API discovery and contextual information extraction.
Use the search tools to efficiently find relevant APIs during development.
"""
            (searchDb.Metadata.GeneratedAt.ToString("yyyy-MM-dd HH:mm:ss"))
            searchDb.Version
            searchDb.ProjectInfo.Name
            stats.PackageCount
            (searchDb.ProjectInfo.ProjectFile |> Option.defaultValue "N/A")
            (stats.TotalTypes.ToString("N0"))
            (stats.TotalMethods.ToString("N0"))
            (stats.TotalProperties.ToString("N0"))
            (stats.TotalKeywords.ToString("N0"))
            stats.GenerationTime.TotalSeconds
            (searchDb.ProjectInfo.Packages
             |> Array.mapi (fun i pkg -> sprintf "%d. %s" (i + 1) pkg)
             |> String.concat "\n")

    /// Build search index from documentation and save to file system
    let buildAndSaveSearchIndex
        (docs: DocNode list)
        (projectInfo: ProjectInfo)
        (searchDir: string)
        : Result<string, string> =

        try
            // Create search directory if it doesn't exist
            Directory.CreateDirectory(searchDir) |> ignore

            // Build the search index
            let searchDb = buildSearchIndex docs projectInfo

            // Serialize to JSON files
            let apiIndexPath = Path.Combine(searchDir, "api-index.json")
            let typeIndexPath = Path.Combine(searchDir, "type-index.json")
            let methodIndexPath = Path.Combine(searchDir, "method-index.json")
            let keywordIndexPath = Path.Combine(searchDir, "keyword-index.json")
            let metadataPath = Path.Combine(searchDir, "metadata.json")

            // Save main API index
            let apiIndexJson = JsonSerializer.Serialize(searchDb, jsonOptions)
            File.WriteAllText(apiIndexPath, apiIndexJson)

            // Save specialized indices for faster access
            let typeIndexJson =
                JsonSerializer.Serialize(searchDb.Indices.TypeIndex, jsonOptions)

            File.WriteAllText(typeIndexPath, typeIndexJson)

            let methodIndexJson =
                JsonSerializer.Serialize(searchDb.Indices.MethodIndex, jsonOptions)

            File.WriteAllText(methodIndexPath, methodIndexJson)

            let keywordIndexJson =
                JsonSerializer.Serialize(searchDb.Indices.KeywordIndex, jsonOptions)

            File.WriteAllText(keywordIndexPath, keywordIndexJson)

            // Save metadata separately for quick access
            let metadataJson = JsonSerializer.Serialize(searchDb.Metadata, jsonOptions)
            File.WriteAllText(metadataPath, metadataJson)

            // Create summary file for human inspection
            let summaryPath = Path.Combine(searchDir, "index-summary.md")
            let summary = generateIndexSummary searchDb
            File.WriteAllText(summaryPath, summary)

            Ok $"Search index built successfully at: {searchDir}"

        with ex ->
            Error $"Failed to build search index: {ex.Message}"

    /// Load search index from file system
    let loadSearchIndex (searchDir: string) : Result<SearchDatabase, string> =
        try
            let apiIndexPath = Path.Combine(searchDir, "api-index.json")

            if not (File.Exists(apiIndexPath)) then
                Error $"Search index not found at: {apiIndexPath}"
            else
                let json = File.ReadAllText(apiIndexPath)
                let searchDb = JsonSerializer.Deserialize<SearchDatabase>(json, jsonOptions)
                Ok searchDb
        with ex ->
            Error $"Failed to load search index: {ex.Message}"

    /// Check if search index exists and is valid
    let validateSearchIndex (searchDir: string) : Result<DateTime, string> =
        try
            let metadataPath = Path.Combine(searchDir, "metadata.json")

            if not (File.Exists(metadataPath)) then
                Error "Search index metadata not found"
            else
                let json = File.ReadAllText(metadataPath)

                let metadata =
                    JsonSerializer.Deserialize<{| GeneratedAt: DateTime |}>(json, jsonOptions)

                Ok metadata.GeneratedAt
        with ex ->
            Error $"Failed to validate search index: {ex.Message}"

    /// Get search index statistics without loading the full index
    let getIndexStatistics (searchDir: string) : Result<IndexStats, string> =
        try
            let metadataPath = Path.Combine(searchDir, "metadata.json")

            if not (File.Exists(metadataPath)) then
                Error "Search index metadata not found"
            else
                let json = File.ReadAllText(metadataPath)

                let metadata =
                    JsonSerializer.Deserialize<{| IndexStatistics: IndexStats |}>(json, jsonOptions)

                Ok metadata.IndexStatistics
        with ex ->
            Error $"Failed to get index statistics: {ex.Message}"
