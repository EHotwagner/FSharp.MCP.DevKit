// FSharp.MCP.DevKit.Documentation/Search/SearchService.fs
// Search service for agent-optimized API discovery and information extraction

namespace FSharp.MCP.DevKit.Documentation.Search

open System
open System.IO
open System.Collections.Generic
open FSharp.MCP.DevKit.Documentation.Search.SearchIndex
open FSharp.MCP.DevKit.Documentation.Search.SearchIndexBuilder

/// Search service for efficient API discovery
module SearchService =

    /// Cache for loaded search indices
    let private searchIndexCache = Dictionary<string, SearchDatabase * DateTime>()

    /// Load search index with caching
    let private loadSearchIndexCached (projectPath: string) : Result<SearchDatabase, string> =
        let searchDir = Path.Combine(Path.GetDirectoryName(projectPath), "docs", ".search")

        // Check if we have a cached version
        match searchIndexCache.TryGetValue(searchDir) with
        | true, (cachedIndex, cacheTime) ->
            // Check if cache is still valid (index not modified)
            match validateSearchIndex searchDir with
            | Ok indexTime when indexTime = cacheTime -> Ok cachedIndex
            | _ ->
                // Cache is stale, reload
                match loadSearchIndex searchDir with
                | Ok newIndex ->
                    searchIndexCache.[searchDir] <- (newIndex, newIndex.Metadata.GeneratedAt)
                    Ok newIndex
                | Error err -> Error err
        | false, _ ->
            // Not cached, load fresh
            match loadSearchIndex searchDir with
            | Ok newIndex ->
                searchIndexCache.[searchDir] <- (newIndex, newIndex.Metadata.GeneratedAt)
                Ok newIndex
            | Error err -> Error err

    /// Find exact matches for type and method names
    let findExactMatches (query: string) (searchIndex: SearchDatabase) : ApiSearchResult[] =
        let normalizedQuery = query.ToLowerInvariant()
        let results = List<ApiSearchResult>()

        // Search types
        searchIndex.Indices.TypeIndex
        |> Map.iter (fun fullName typeSummary ->
            if
                typeSummary.FullName.ToLowerInvariant().Contains(normalizedQuery)
                || Path.GetFileNameWithoutExtension(typeSummary.FullName).ToLowerInvariant().Contains(normalizedQuery)
            then
                let result =
                    { ElementType = TypeElement
                      FullName = typeSummary.FullName
                      Purpose = typeSummary.Purpose
                      DocumentationPath = typeSummary.DocumentationPath
                      RelevanceScore =
                        if typeSummary.FullName.ToLowerInvariant() = normalizedQuery then
                            1.0
                        else
                            0.8
                      MatchType = ExactMatch }

                results.Add(result))

        // Search methods
        searchIndex.Indices.MethodIndex
        |> Map.iter (fun _ methods ->
            methods
            |> Array.iter (fun methodSummary ->
                if methodSummary.Name.ToLowerInvariant().Contains(normalizedQuery) then
                    let result =
                        { ElementType = MethodElement
                          FullName = methodSummary.FullName
                          Purpose = methodSummary.Purpose
                          DocumentationPath = methodSummary.DocumentationPath
                          RelevanceScore =
                            if methodSummary.Name.ToLowerInvariant() = normalizedQuery then
                                0.9
                            else
                                0.7
                          MatchType = ExactMatch }

                    results.Add(result)))

        results |> Seq.toArray

    /// Find semantic matches using keyword search
    let findSemanticMatches (query: string) (searchIndex: SearchDatabase) : ApiSearchResult[] =
        let queryWords =
            query.Split([| ' '; '.'; ','; ';' |], StringSplitOptions.RemoveEmptyEntries)
            |> Array.map (fun w -> w.ToLowerInvariant())
            |> Array.filter (fun w -> w.Length > 2)

        let results = List<ApiSearchResult>()
        let scoredResults = Dictionary<string, float * ApiSearchResult>()

        // Search keywords
        queryWords
        |> Array.iter (fun word ->
            match searchIndex.Indices.KeywordIndex.TryFind(word) with
            | Some apiRefs ->
                apiRefs
                |> Array.iter (fun apiRef ->
                    let baseScore = apiRef.Score * 0.6 // Lower score for semantic matches

                    let result =
                        { ElementType = apiRef.ElementType
                          FullName = apiRef.FullName
                          Purpose = "" // Will be filled from type/method index
                          DocumentationPath = "" // Will be filled from type/method index
                          RelevanceScore = baseScore
                          MatchType = SemanticMatch }

                    // Accumulate scores for the same API
                    match scoredResults.TryGetValue(apiRef.FullName) with
                    | true, (existingScore, existingResult) ->
                        scoredResults.[apiRef.FullName] <- (existingScore + baseScore, existingResult)
                    | false, _ -> scoredResults.[apiRef.FullName] <- (baseScore, result))
            | None -> ())

        // Convert to final results and fill in missing information
        scoredResults.Values
        |> Seq.map (fun (score, result) ->
            let updatedResult =
                match result.ElementType with
                | TypeElement ->
                    match searchIndex.Indices.TypeIndex.TryFind(result.FullName) with
                    | Some typeSummary ->
                        { result with
                            Purpose = typeSummary.Purpose
                            DocumentationPath = typeSummary.DocumentationPath }
                    | None -> result
                | MethodElement ->
                    // Find method in method index
                    let methodOpt =
                        searchIndex.Indices.MethodIndex
                        |> Map.toSeq
                        |> Seq.collect (fun (_, methods) -> methods)
                        |> Seq.tryFind (fun m -> m.FullName = result.FullName)

                    match methodOpt with
                    | Some methodSummary ->
                        { result with
                            Purpose = methodSummary.Purpose
                            DocumentationPath = methodSummary.DocumentationPath }
                    | None -> result
                | _ -> result

            { updatedResult with
                RelevanceScore = score })
        |> Seq.toArray

    /// Combine and rank search results
    let rankAndCombineResults (resultSets: ApiSearchResult[][]) : ApiSearchResult[] =
        resultSets
        |> Array.collect id
        |> Array.groupBy (fun r -> r.FullName)
        |> Array.map (fun (_, results) ->
            // Take the result with the highest score
            results |> Array.maxBy (fun r -> r.RelevanceScore))
        |> Array.sortByDescending (fun r -> r.RelevanceScore)

    /// Main API search function
    let searchAPI (query: string) (projectPath: string) : Result<ApiSearchResult[], string> =
        match loadSearchIndexCached projectPath with
        | Ok searchIndex ->
            let exactMatches = findExactMatches query searchIndex
            let semanticMatches = findSemanticMatches query searchIndex

            let combinedResults = rankAndCombineResults [| exactMatches; semanticMatches |]
            Ok combinedResults
        | Error err -> Error err

    /// Get detailed type information
    let getTypeInfo (typeName: string) (projectPath: string) : Result<TypeSummary, string> =
        match loadSearchIndexCached projectPath with
        | Ok searchIndex ->
            match searchIndex.Indices.TypeIndex.TryFind(typeName) with
            | Some typeInfo -> Ok typeInfo
            | None -> Error $"Type '{typeName}' not found in search index"
        | Error err -> Error err

    /// Get method information for a specific type
    let getMethodInfo (typeName: string) (projectPath: string) : Result<MethodSummary[], string> =
        match loadSearchIndexCached projectPath with
        | Ok searchIndex ->
            match searchIndex.Indices.MethodIndex.TryFind(typeName) with
            | Some methods -> Ok methods
            | None -> Ok [||] // No methods found, but not an error
        | Error err -> Error err

    /// Find related APIs based on common keywords and patterns
    let findRelatedAPIs (typeName: string) (projectPath: string) : Result<ApiSearchResult[], string> =
        match loadSearchIndexCached projectPath with
        | Ok searchIndex ->
            match searchIndex.Indices.TypeIndex.TryFind(typeName) with
            | Some typeInfo ->
                // Extract keywords from the type's purpose and search for related APIs
                let keywords =
                    typeInfo.Purpose.Split([| ' '; '.'; ','; ';' |], StringSplitOptions.RemoveEmptyEntries)
                    |> Array.filter (fun w -> w.Length > 3)
                    |> Array.take (min 5 (Array.length keywords)) // Limit to top 5 keywords

                let relatedResults =
                    keywords
                    |> Array.collect (fun keyword ->
                        match findSemanticMatches keyword searchIndex with
                        | results -> results |> Array.filter (fun r -> r.FullName <> typeName)
                        | _ -> [||])
                    |> Array.distinctBy (fun r -> r.FullName)
                    |> Array.take 10 // Limit to top 10 related APIs

                Ok relatedResults
            | None -> Error $"Type '{typeName}' not found in search index"
        | Error err -> Error err

    /// Get usage patterns for a specific type (placeholder implementation)
    let getUsagePatterns (typeName: string) (projectPath: string) : Result<UseCaseSummary[], string> =
        match loadSearchIndexCached projectPath with
        | Ok searchIndex ->
            // Placeholder implementation - would extract common patterns from documentation
            let patterns =
                [| { UseCase = $"Basic usage of {typeName}"
                     Description = "Common usage pattern for this type"
                     RelevantTypes = [| typeName |]
                     ExampleCode = Some $"// Example usage of {typeName}"
                     Keywords = [| "basic"; "usage"; "example" |] } |]

            Ok patterns
        | Error err -> Error err

    /// Get project overview from search index
    let getProjectOverview (projectPath: string) : Result<ProjectInfo * IndexStats, string> =
        match loadSearchIndexCached projectPath with
        | Ok searchIndex -> Ok(searchIndex.ProjectInfo, searchIndex.Metadata.IndexStatistics)
        | Error err -> Error err

    /// Validate that documentation is up to date
    let validateDocumentation (projectPath: string) : Result<bool * DateTime, string> =
        let searchDir = Path.Combine(Path.GetDirectoryName(projectPath), "docs", ".search")

        match validateSearchIndex searchDir with
        | Ok indexTime ->
            // Check if project file is newer than index
            let projectTime = File.GetLastWriteTimeUtc(projectPath)
            let isUpToDate = indexTime >= projectTime
            Ok(isUpToDate, indexTime)
        | Error err -> Error err
