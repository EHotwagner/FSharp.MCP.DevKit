// FSharp.MCP.DevKit.Documentation/Search/ContextAwareSearch.fs
// Context-aware search service with intelligent caching and batch operations

namespace FSharp.MCP.DevKit.Documentation.Search

open System
open System.IO
open System.Collections.Generic
open System.Collections.Concurrent
open FSharp.MCP.DevKit.Documentation.Search.SearchIndex
open FSharp.MCP.DevKit.Documentation.Search.SearchService

/// Context-aware search with intelligent caching and batch operations
module ContextAwareSearch =

    /// Development context for improved search relevance
    type DevelopmentContext = {
        CurrentFiles: string[]
        RecentlyUsedTypes: string[]
        ProjectContext: string option
        CurrentNamespaces: string[]
        RecentSearchQueries: string[]
    }

    /// Cached type information with timestamp
    type CachedTypeInfo = {
        TypeInfo: TypeSummary
        CachedAt: DateTime
        AccessCount: int
        LastAccessed: DateTime
    }

    /// LRU cache for type information
    type TypeInfoCache(maxSize: int) =
        let cache = ConcurrentDictionary<string, CachedTypeInfo>()
        let accessOrder = Queue<string>()
        let lockObj = obj()

        member this.Get(key: string) : TypeSummary option =
            match cache.TryGetValue(key) with
            | true, cached ->
                // Update access information
                let updated = { cached with AccessCount = cached.AccessCount + 1; LastAccessed = DateTime.UtcNow }
                cache.[key] <- updated
                Some cached.TypeInfo
            | false, _ -> None

        member this.Put(key: string, typeInfo: TypeSummary) : unit =
            lock lockObj (fun () ->
                let cached = {
                    TypeInfo = typeInfo
                    CachedAt = DateTime.UtcNow
                    AccessCount = 1
                    LastAccessed = DateTime.UtcNow
                }

                cache.[key] <- cached
                accessOrder.Enqueue(key)

                // Evict oldest entries if cache is full
                while accessOrder.Count > maxSize do
                    let oldestKey = accessOrder.Dequeue()
                    cache.TryRemove(oldestKey) |> ignore
            )

        member this.InvalidateByProject(projectPath: string) : unit =
            let projectPrefix = Path.GetDirectoryName(projectPath)
            let keysToRemove =
                cache.Keys
                |> Seq.filter (fun key -> key.StartsWith(projectPrefix))
                |> Seq.toArray

            keysToRemove |> Array.iter (fun key -> cache.TryRemove(key) |> ignore)

    /// Global cache instance
    let private typeInfoCache = TypeInfoCache(1000)

    /// Extract development context from current files
    let analyzeCurrentContext (currentFiles: string[]) : DevelopmentContext =
        let extractedNamespaces =
            currentFiles
            |> Array.choose (fun file ->
                if file.EndsWith(".fs") || file.EndsWith(".fsx") then
                    // Simple namespace extraction from file path
                    let fileName = Path.GetFileNameWithoutExtension(file)
                    if fileName.Contains(".") then
                        Some fileName.Substring(0, fileName.LastIndexOf('.'))
                    else None
                else None
            )
            |> Array.distinct

        let recentTypes =
            currentFiles
            |> Array.choose (fun file ->
                if file.EndsWith(".fs") || file.EndsWith(".fsx") then
                    Some (Path.GetFileNameWithoutExtension(file))
                else None
            )
            |> Array.distinct

        {
            CurrentFiles = currentFiles
            RecentlyUsedTypes = recentTypes
            ProjectContext = None
            CurrentNamespaces = extractedNamespaces
            RecentSearchQueries = [||]
        }

    /// Rank search results by relevance to development context
    let rankByRelevanceToContext (context: DevelopmentContext) (results: ApiSearchResult[]) : ApiSearchResult[] =
        results
        |> Array.map (fun result ->
            let contextScore =
                let mutable score = 0.0

                // Boost score if type is in current namespaces
                context.CurrentNamespaces |> Array.iter (fun ns ->
                    if result.FullName.StartsWith(ns) then
                        score <- score + 0.3
                )

                // Boost score if type name matches recently used types
                context.RecentlyUsedTypes |> Array.iter (fun typeName ->
                    if result.FullName.Contains(typeName) then
                        score <- score + 0.2
                )

                // Boost score if in same project context
                match context.ProjectContext with
                | Some projectName when result.FullName.Contains(projectName) -> score + 0.1
                | _ -> score

            { result with RelevanceScore = result.RelevanceScore + contextScore }
        )
        |> Array.sortByDescending (fun r -> r.RelevanceScore)

    /// Limit results to most relevant for agent consumption
    let limitToMostRelevant (maxResults: int) (results: ApiSearchResult[]) : ApiSearchResult[] =
        results |> Array.take (min maxResults results.Length)

    /// Context-aware search API
    let searchWithContext
        (query: string)
        (currentFiles: string[])
        (projectPath: string)
        : Result<ApiSearchResult[], string> =

        match searchAPI query projectPath with
        | Ok results ->
            let context = analyzeCurrentContext currentFiles
            let rankedResults =
                results
                |> rankByRelevanceToContext context
                |> limitToMostRelevant 5
            Ok rankedResults
        | Error err -> Error err

    /// Get cached type information with automatic caching
    let getTypeInfoCached (typeName: string) (projectPath: string) : Result<TypeSummary, string> =
        let cacheKey = $"{projectPath}:{typeName}"

        match typeInfoCache.Get(cacheKey) with
        | Some cached -> Ok cached
        | None ->
            match getTypeInfo typeName projectPath with
            | Ok typeInfo ->
                typeInfoCache.Put(cacheKey, typeInfo)
                Ok typeInfo
            | Error err -> Error err

    /// Batch type information retrieval
    let getMultipleTypeInfo (typeNames: string[]) (projectPath: string) : Result<Map<string, TypeSummary>, string> =
        let results = Dictionary<string, TypeSummary>()
        let errors = List<string>()

        typeNames |> Array.iter (fun typeName ->
            match getTypeInfoCached typeName projectPath with
            | Ok typeInfo -> results.[typeName] <- typeInfo
            | Error err -> errors.Add($"Failed to get info for {typeName}: {err}")
        )

        if errors.Count > 0 then
            Error (String.concat "; " errors)
        else
            Ok (results |> Seq.map (|KeyValue|) |> Map.ofSeq)

    /// Batch method information retrieval
    let getMultipleMethodInfo (typeNames: string[]) (projectPath: string) : Result<Map<string, MethodSummary[]>, string> =
        let results = Dictionary<string, MethodSummary[]>()
        let errors = List<string>()

        typeNames |> Array.iter (fun typeName ->
            match getMethodInfo typeName projectPath with
            | Ok methods -> results.[typeName] <- methods
            | Error err -> errors.Add($"Failed to get methods for {typeName}: {err}")
        )

        if errors.Count > 0 then
            Error (String.concat "; " errors)
        else
            Ok (results |> Seq.map (|KeyValue|) |> Map.ofSeq)

    /// Smart search recommendations based on context
    let getSearchRecommendations (context: DevelopmentContext) (projectPath: string) : Result<ApiSearchResult[], string> =
        // Generate search queries based on context
        let recommendedQueries =
            Array.concat [
                context.CurrentNamespaces |> Array.map (fun ns -> $"namespace:{ns}")
                context.RecentlyUsedTypes |> Array.take 3  // Limit to recent 3
                [| "serialize"; "deserialize"; "convert"; "parse" |]  // Common development tasks
            ]

        let allRecommendations = List<ApiSearchResult>()

        recommendedQueries
        |> Array.take 5  // Limit queries to prevent overwhelming results
        |> Array.iter (fun query ->
            match searchAPI query projectPath with
            | Ok results ->
                results
                |> Array.take 2  // Top 2 results per query
                |> Array.iter allRecommendations.Add
            | Error _ -> ()
        )

        let uniqueRecommendations =
            allRecommendations
            |> Seq.distinctBy (fun r -> r.FullName)
            |> Seq.take 10
            |> Seq.toArray

        Ok uniqueRecommendations

    /// Performance monitoring and cache statistics
    type CacheStatistics = {
        TotalRequests: int
        CacheHits: int
        CacheMisses: int
        HitRate: float
        AverageResponseTime: TimeSpan
    }

    /// Get cache performance statistics
    let getCacheStatistics () : CacheStatistics =
        // Placeholder implementation - would track actual metrics
        {
            TotalRequests = 0
            CacheHits = 0
            CacheMisses = 0
            HitRate = 0.0
            AverageResponseTime = TimeSpan.Zero
        }

    /// Clear cache for a specific project
    let clearProjectCache (projectPath: string) : unit =
        typeInfoCache.InvalidateByProject(projectPath)

    /// Preload commonly used types into cache
    let preloadCommonTypes (projectPath: string) : Result<int, string> =
        let commonTypeQueries = [|
            "string"; "int"; "DateTime"; "List"; "Array"; "Option"; "Result"
            "Json"; "Http"; "File"; "Path"; "Console"; "Task"; "Async"
        |]

        let mutable loadedCount = 0

        commonTypeQueries |> Array.iter (fun query ->
            match searchAPI query projectPath with
            | Ok results ->
                results
                |> Array.take 3  // Top 3 results per query
                |> Array.iter (fun result ->
                    match getTypeInfoCached result.FullName projectPath with
                    | Ok _ -> loadedCount <- loadedCount + 1
                    | Error _ -> ()
                )
            | Error _ -> ()
        )

        Ok loadedCount
