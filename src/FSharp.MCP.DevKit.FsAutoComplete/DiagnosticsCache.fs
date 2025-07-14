namespace FSharp.MCP.DevKit.FsAutoComplete

open System
open System.Collections.Concurrent
open System.Threading
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.FsAutoComplete.LspTypes

/// Diagnostics source information
type DiagnosticSource =
    | FSharpCompiler
    | FsacAnalyzer
    | ExternalAnalyzer of name: string
    | Unknown of source: string

    static member FromString(source: string option) =
        match source with
        | None -> Unknown "unknown"
        | Some s when s.Contains("F# Compiler") -> FSharpCompiler
        | Some s when s.Contains("FSAC") -> FsacAnalyzer
        | Some s when s.Contains("F# Analyzers") -> ExternalAnalyzer s
        | Some s when s.Contains("F# Linter") -> ExternalAnalyzer s
        | Some s -> Unknown s

/// Diagnostic entry with metadata
type DiagnosticEntry =
    { Diagnostic: Diagnostic
      Source: DiagnosticSource
      Timestamp: DateTime
      FileVersion: int option }

/// File diagnostics collection
type FileDiagnostics =
    { Uri: string
      Version: int option
      LastUpdated: DateTime
      Diagnostics: Map<DiagnosticSource, DiagnosticEntry[]> }

    /// Get all diagnostics for this file
    member this.AllDiagnostics =
        this.Diagnostics
        |> Map.toSeq
        |> Seq.collect (snd >> Array.map (fun entry -> entry.Diagnostic))
        |> Array.ofSeq

    /// Get diagnostics count by severity
    member this.DiagnosticCounts =
        let diagnostics = this.AllDiagnostics

        let errors =
            diagnostics
            |> Array.filter (fun d -> d.Severity = Some DiagnosticSeverity.Error)
            |> Array.length

        let warnings =
            diagnostics
            |> Array.filter (fun d -> d.Severity = Some DiagnosticSeverity.Warning)
            |> Array.length

        let info =
            diagnostics
            |> Array.filter (fun d -> d.Severity = Some DiagnosticSeverity.Information)
            |> Array.length

        let hints =
            diagnostics
            |> Array.filter (fun d -> d.Severity = Some DiagnosticSeverity.Hint)
            |> Array.length

        {| Errors = errors
           Warnings = warnings
           Information = info
           Hints = hints |}

/// Diagnostics cache configuration
type DiagnosticsCacheConfig =
    { MaxFiles: int
      MaxEntriesPerFile: int
      CleanupInterval: TimeSpan
      DefaultTtl: TimeSpan }

    static member Default =
        { MaxFiles = 1000
          MaxEntriesPerFile = 1000
          CleanupInterval = TimeSpan.FromMinutes(5.0)
          DefaultTtl = TimeSpan.FromHours(1) }

/// Events emitted by the diagnostics cache
type DiagnosticsCacheEvent =
    | DiagnosticsUpdated of uri: string * count: int
    | DiagnosticsCleared of uri: string
    | CacheCleanup of removedFiles: int
    | CacheOverflow of droppedFiles: string[]

/// Thread-safe cache for diagnostics from multiple sources
type DiagnosticsCache(config: DiagnosticsCacheConfig, logger: ILogger) =
    let cache = ConcurrentDictionary<string, FileDiagnostics>()
    let mutable isDisposed = false
    let mutable cleanupTimer: Timer option = None

    // Events
    let cacheEvents = Event<DiagnosticsCacheEvent>()

    do
        // Start cleanup timer
        let timer =
            new Timer(fun _ ->
                if not isDisposed then
                    try
                        let removedCount = cache.Count
                        let currentTime = DateTime.UtcNow

                        let expiredKeys =
                            cache
                            |> Seq.filter (fun kvp -> currentTime - kvp.Value.LastUpdated > config.DefaultTtl)
                            |> Seq.map (fun kvp -> kvp.Key)
                            |> Seq.toArray

                        for key in expiredKeys do
                            cache.TryRemove(key) |> ignore

                        if expiredKeys.Length > 0 then
                            logger.LogDebug("Cleaned up {Count} expired diagnostic entries", expiredKeys.Length)
                            cacheEvents.Trigger(CacheCleanup expiredKeys.Length)
                    with ex ->
                        logger.LogError(ex, "Error during diagnostics cache cleanup"))

        cleanupTimer <- Some timer
        timer.Change(config.CleanupInterval, config.CleanupInterval) |> ignore

    /// Event fired when cache state changes
    [<CLIEvent>]
    member _.CacheEvents = cacheEvents.Publish

    /// Total number of files in cache
    member _.FileCount = cache.Count

    /// Get all cached file URIs
    member _.CachedFiles = cache.Keys |> Array.ofSeq

    /// Update diagnostics for a file from publishDiagnostics notification
    member this.UpdateDiagnosticsFromNotification(publishDiagnostics: PublishDiagnosticsParams) =
        if isDisposed then
            logger.LogWarning("Attempted to update disposed diagnostics cache")
        else
            try
                let uri = publishDiagnostics.Uri
                let version = publishDiagnostics.Version
                let timestamp = DateTime.UtcNow

                // Convert diagnostics to entries with source information
                let entries =
                    publishDiagnostics.Diagnostics
                    |> Array.map (fun diagnostic ->
                        { Diagnostic = diagnostic
                          Source = DiagnosticSource.FromString(diagnostic.Source)
                          Timestamp = timestamp
                          FileVersion = version })

                // Group by source
                let diagnosticsBySource =
                    entries |> Array.groupBy (fun entry -> entry.Source) |> Map.ofArray

                // Update or create file diagnostics
                let updatedFile =
                    cache.AddOrUpdate(
                        uri,
                        (fun _ ->
                            { Uri = uri
                              Version = version
                              LastUpdated = timestamp
                              Diagnostics = diagnosticsBySource }),
                        (fun _ existing ->
                            { existing with
                                Version = version |> Option.orElse existing.Version
                                LastUpdated = timestamp
                                Diagnostics =
                                    // Merge with existing diagnostics, replacing sources that are present
                                    existing.Diagnostics
                                    |> Map.fold
                                        (fun acc source diags ->
                                            match Map.tryFind source diagnosticsBySource with
                                            | Some newDiags -> Map.add source newDiags acc
                                            | None -> Map.add source diags acc)
                                        diagnosticsBySource })
                    )

                let totalCount = updatedFile.AllDiagnostics.Length
                logger.LogDebug("Updated diagnostics for {Uri}: {Count} total diagnostics", uri, totalCount)
                cacheEvents.Trigger(DiagnosticsUpdated(uri, totalCount))

                // Check for cache overflow
                if cache.Count > config.MaxFiles then
                    this.EvictOldestFiles()

            with ex ->
                logger.LogError(ex, "Error updating diagnostics for {Uri}", publishDiagnostics.Uri)

    /// Get diagnostics for a specific file
    member _.GetDiagnostics(uri: string) =
        match cache.TryGetValue(uri) with
        | true, fileDiagnostics -> Some fileDiagnostics
        | false, _ -> None

    /// Get diagnostics for a specific file and source
    member _.GetDiagnosticsBySource(uri: string, source: DiagnosticSource) =
        match cache.TryGetValue(uri) with
        | true, fileDiagnostics -> Map.tryFind source fileDiagnostics.Diagnostics
        | false, _ -> None

    /// Clear diagnostics for a specific file
    member this.ClearDiagnostics(uri: string) =
        if cache.TryRemove(uri) |> fst then
            logger.LogDebug("Cleared diagnostics for {Uri}", uri)
            cacheEvents.Trigger(DiagnosticsCleared uri)
            true
        else
            false

    /// Clear diagnostics for a specific file and source
    member this.ClearDiagnosticsForSource(uri: string, source: DiagnosticSource) =
        match cache.TryGetValue(uri) with
        | true, fileDiagnostics ->
            let updatedDiagnostics = Map.remove source fileDiagnostics.Diagnostics

            let updatedFile =
                { fileDiagnostics with
                    Diagnostics = updatedDiagnostics }

            if Map.isEmpty updatedDiagnostics then
                // Remove file entirely if no diagnostics left
                this.ClearDiagnostics(uri) |> ignore
            else
                cache.TryUpdate(uri, updatedFile, fileDiagnostics) |> ignore

            true
        | false, _ -> false

    /// Get summary statistics for all cached diagnostics
    member _.GetCacheSummary() =
        let files = cache.Values |> Seq.toArray
        let totalDiagnostics = files |> Array.sumBy (fun f -> f.AllDiagnostics.Length)
        let totalErrors = files |> Array.sumBy (fun f -> f.DiagnosticCounts.Errors)
        let totalWarnings = files |> Array.sumBy (fun f -> f.DiagnosticCounts.Warnings)

        {| FileCount = files.Length
           TotalDiagnostics = totalDiagnostics
           TotalErrors = totalErrors
           TotalWarnings = totalWarnings
           OldestEntry = files |> Array.map (fun f -> f.LastUpdated) |> Array.min |> Some
           NewestEntry = files |> Array.map (fun f -> f.LastUpdated) |> Array.max |> Some |}

    /// Get files with diagnostics matching a predicate
    member _.FindFilesWithDiagnostics(predicate: Diagnostic -> bool) =
        cache.Values
        |> Seq.filter (fun fileDiags -> fileDiags.AllDiagnostics |> Array.exists predicate)
        |> Seq.map (fun fileDiags -> fileDiags.Uri)
        |> Array.ofSeq

    /// Perform cleanup of old entries
    member private this.PerformCleanup() =
        if not isDisposed then
            try
                let cutoffTime = DateTime.UtcNow.Subtract(config.DefaultTtl)

                let filesToRemove =
                    cache
                    |> Seq.filter (fun kvp -> kvp.Value.LastUpdated < cutoffTime)
                    |> Seq.map (fun kvp -> kvp.Key)
                    |> Array.ofSeq

                let removedCount =
                    filesToRemove
                    |> Array.fold (fun count uri -> if cache.TryRemove(uri) |> fst then count + 1 else count) 0

                if removedCount > 0 then
                    logger.LogDebug("Cache cleanup removed {Count} old entries", removedCount)
                    cacheEvents.Trigger(CacheCleanup removedCount)

            with ex ->
                logger.LogError(ex, "Error during cache cleanup")

    /// Evict oldest files when cache is full
    member private this.EvictOldestFiles() =
        try
            let excessCount = cache.Count - config.MaxFiles

            if excessCount > 0 then
                let filesToEvict =
                    cache.Values
                    |> Seq.sortBy (fun f -> f.LastUpdated)
                    |> Seq.take excessCount
                    |> Seq.map (fun f -> f.Uri)
                    |> Array.ofSeq

                let evictedFiles =
                    filesToEvict
                    |> Array.choose (fun uri -> if cache.TryRemove(uri) |> fst then Some uri else None)

                if evictedFiles.Length > 0 then
                    logger.LogWarning("Cache overflow: evicted {Count} oldest files", evictedFiles.Length)
                    cacheEvents.Trigger(CacheOverflow evictedFiles)

        with ex ->
            logger.LogError(ex, "Error during cache eviction")

    /// Clear entire cache
    member this.ClearAll() =
        cache.Clear()
        logger.LogInformation("Cleared entire diagnostics cache")

    interface IDisposable with
        member this.Dispose() =
            if not isDisposed then
                isDisposed <- true
                cleanupTimer |> Option.iter (fun timer -> timer.Dispose())
                cache.Clear()

    /// Public dispose method for explicit cleanup
    member this.Dispose() = (this :> IDisposable).Dispose()
