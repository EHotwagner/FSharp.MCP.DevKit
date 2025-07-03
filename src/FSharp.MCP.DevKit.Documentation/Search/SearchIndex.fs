// FSharp.MCP.DevKit.Documentation/Search/SearchIndex.fs
// Search index data structures and functionality for agent-optimized documentation access

namespace FSharp.MCP.DevKit.Documentation.Search

open System
open System.Collections.Generic
open FSharp.MCP.DevKit.Documentation.Model

/// Core search index data structures for efficient agent queries
module SearchIndex =

    /// Summary information about a type for search indexing
    type TypeSummary =
        { FullName: string
          Purpose: string
          Package: string
          Namespace: string
          Kind: string // "Class", "Interface", "Struct", etc.
          KeyMethods: string[]
          KeyProperties: string[]
          CommonPatterns: string[]
          DocumentationPath: string
          HasXmlDocs: bool
          Popularity: int } // Based on method/property count

    /// Summary information about a method for search indexing
    type MethodSummary =
        { Name: string
          FullName: string
          DeclaringType: string
          Purpose: string
          Parameters: ParameterSummary[]
          ReturnType: string
          IsStatic: bool
          DocumentationPath: string
          HasXmlDocs: bool
          UsageFrequency: int } // Estimated usage frequency

    /// Summary information about a parameter
    and ParameterSummary =
        { Name: string
          Type: string
          Purpose: string option
          IsOptional: bool }

    /// Summary information about a property for search indexing
    type PropertySummary =
        { Name: string
          FullName: string
          DeclaringType: string
          Purpose: string
          PropertyType: string
          CanRead: bool
          CanWrite: bool
          IsStatic: bool
          DocumentationPath: string
          HasXmlDocs: bool }

    /// Common usage patterns and examples
    type UseCaseSummary =
        { UseCase: string
          Description: string
          RelevantTypes: string[]
          ExampleCode: string option
          Keywords: string[] }

    /// Keyword index for semantic search
    type KeywordIndex = Map<string, ApiReference[]>

    /// Reference to an API element
    and ApiReference =
        { ElementType: ElementType
          FullName: string
          Score: float } // Relevance score for this keyword

    /// Type of API element
    and ElementType =
        | TypeElement
        | MethodElement
        | PropertyElement
        | EventElement
        | FieldElement

    /// Statistics about the search index
    type IndexStats =
        { TotalTypes: int
          TotalMethods: int
          TotalProperties: int
          TotalKeywords: int
          PackageCount: int
          GenerationTime: TimeSpan }

    /// Project information for the search index
    type ProjectInfo =
        { Name: string
          ProjectFile: string option
          Packages: string[]
          GeneratedAt: DateTime
          Version: string }

    /// Complete search database for a project
    type SearchDatabase =
        { Version: string
          ProjectInfo: ProjectInfo
          Indices:
              {| TypeIndex: Map<string, TypeSummary>
                 MethodIndex: Map<string, MethodSummary[]>
                 PropertyIndex: Map<string, PropertySummary[]>
                 KeywordIndex: KeywordIndex
                 UseCaseIndex: Map<string, UseCaseSummary[]>
                 SemanticIndex: Map<string, ScoredApiReference[]> |}
          Metadata:
              {| GeneratedAt: DateTime
                 PackageVersions: Map<string, string>
                 IndexStatistics: IndexStats |} }

    /// Scored API reference for semantic search
    and ScoredApiReference =
        { ApiReference: ApiReference
          SemanticScore: float
          ContextScore: float }

    /// Results from API search
    type ApiSearchResult =
        { ElementType: ElementType
          FullName: string
          Purpose: string
          DocumentationPath: string
          RelevanceScore: float
          MatchType: MatchType }

    /// Type of search match
    and MatchType =
        | ExactMatch
        | SemanticMatch
        | KeywordMatch
        | UseCaseMatch

    /// Search query context for improved results
    type SearchContext =
        { CurrentFiles: string[]
          RecentlyUsedTypes: string[]
          ProjectContext: string option }

    /// Build search index from documentation model
    let buildSearchIndex (docs: DocNode list) (projectInfo: ProjectInfo) : SearchDatabase =
        let typeIndex = Dictionary<string, TypeSummary>()
        let methodIndex = Dictionary<string, List<MethodSummary>>()
        let propertyIndex = Dictionary<string, List<PropertySummary>>()
        let keywordIndex = Dictionary<string, List<ApiReference>>()

        let addKeyword (keyword: string) (apiRef: ApiReference) =
            let normalizedKeyword = keyword.ToLowerInvariant()

            if not (keywordIndex.ContainsKey(normalizedKeyword)) then
                keywordIndex.[normalizedKeyword] <- List<ApiReference>()

            keywordIndex.[normalizedKeyword].Add(apiRef)

        let extractKeywords (text: string option) : string[] =
            match text with
            | Some t ->
                t.Split([| ' '; '.'; ','; ';'; '\n'; '\r' |], StringSplitOptions.RemoveEmptyEntries)
                |> Array.filter (fun w -> w.Length > 2)
                |> Array.map (fun w -> w.ToLowerInvariant())
            | None -> [||]

        let rec processNode (node: DocNode) =
            match node with
            | Type typeInfo ->
                let typeSummary =
                    { FullName = typeInfo.FullName
                      Purpose = typeInfo.XmlDocs |> Option.bind (fun x -> x.Summary) |> Option.defaultValue ""
                      Package = typeInfo.Assembly.Package.Name
                      Namespace = typeInfo.FullName.Substring(0, max 0 (typeInfo.FullName.LastIndexOf('.')))
                      Kind =
                        match typeInfo.Kind with
                        | Class -> "Class"
                        | Interface -> "Interface"
                        | Struct -> "Struct"
                        | Enum -> "Enum"
                        | Delegate -> "Delegate"
                      KeyMethods = [||] // Will be populated when processing methods
                      KeyProperties = [||] // Will be populated when processing properties
                      CommonPatterns = [||]
                      DocumentationPath = $"{typeInfo.Assembly.Package.Name}/{typeInfo.Name}.md"
                      HasXmlDocs = typeInfo.XmlDocs.IsSome
                      Popularity = typeInfo.Members.Length }

                typeIndex.[typeInfo.FullName] <- typeSummary

                // Add keywords from type name and documentation
                let typeApiRef =
                    { ElementType = TypeElement
                      FullName = typeInfo.FullName
                      Score = 1.0 }

                addKeyword typeInfo.Name typeApiRef

                // Extract keywords from XML documentation
                extractKeywords (typeInfo.XmlDocs |> Option.bind (fun x -> x.Summary))
                |> Array.iter (fun keyword -> addKeyword keyword typeApiRef)

                // Process type members
                typeInfo.Members |> List.iter processNode

            | Method methodInfo ->
                let methodSummary =
                    { Name = methodInfo.Name
                      FullName = methodInfo.FullName
                      DeclaringType = methodInfo.DeclaringType
                      Purpose = methodInfo.XmlDocs |> Option.bind (fun x -> x.Summary) |> Option.defaultValue ""
                      Parameters = [||] // Will be populated from methodInfo.Parameters
                      ReturnType = methodInfo.ReturnType.ToString()
                      IsStatic = false // TODO: Extract from attributes
                      DocumentationPath =
                        $"{methodInfo.Assembly.Package.Name}/{methodInfo.DeclaringType}.md#method-{methodInfo.Name}"
                      HasXmlDocs = methodInfo.XmlDocs.IsSome
                      UsageFrequency = 1 }

                if not (methodIndex.ContainsKey(methodInfo.DeclaringType)) then
                    methodIndex.[methodInfo.DeclaringType] <- List<MethodSummary>()

                methodIndex.[methodInfo.DeclaringType].Add(methodSummary)

                // Add keywords from method name and documentation
                let methodApiRef =
                    { ElementType = MethodElement
                      FullName = methodInfo.FullName
                      Score = 0.8 }

                addKeyword methodInfo.Name methodApiRef

                extractKeywords (methodInfo.XmlDocs |> Option.bind (fun x -> x.Summary))
                |> Array.iter (fun keyword -> addKeyword keyword methodApiRef)

            | Property propertyInfo ->
                let propertySummary =
                    { Name = propertyInfo.Name
                      FullName = propertyInfo.FullName
                      DeclaringType = propertyInfo.DeclaringType
                      Purpose =
                        propertyInfo.XmlDocs
                        |> Option.bind (fun x -> x.Summary)
                        |> Option.defaultValue ""
                      PropertyType = propertyInfo.PropertyType.ToString()
                      CanRead = propertyInfo.CanRead
                      CanWrite = propertyInfo.CanWrite
                      IsStatic = false // TODO: Extract from attributes
                      DocumentationPath =
                        $"{propertyInfo.Assembly.Package.Name}/{propertyInfo.DeclaringType}.md#property-{propertyInfo.Name}"
                      HasXmlDocs = propertyInfo.XmlDocs.IsSome }

                if not (propertyIndex.ContainsKey(propertyInfo.DeclaringType)) then
                    propertyIndex.[propertyInfo.DeclaringType] <- List<PropertySummary>()

                propertyIndex.[propertyInfo.DeclaringType].Add(propertySummary)

                // Add keywords from property name and documentation
                let propertyApiRef =
                    { ElementType = PropertyElement
                      FullName = propertyInfo.FullName
                      Score = 0.6 }

                addKeyword propertyInfo.Name propertyApiRef

                extractKeywords (propertyInfo.XmlDocs |> Option.bind (fun x -> x.Summary))
                |> Array.iter (fun keyword -> addKeyword keyword propertyApiRef)

            | _ -> () // Handle other node types as needed

        // Process all documentation nodes
        docs |> List.iter processNode

        // Convert dictionaries to maps
        let finalTypeIndex = typeIndex |> Seq.map (|KeyValue|) |> Map.ofSeq

        let finalMethodIndex =
            methodIndex
            |> Seq.map (fun kvp -> kvp.Key, kvp.Value |> Seq.toArray)
            |> Map.ofSeq

        let finalPropertyIndex =
            propertyIndex
            |> Seq.map (fun kvp -> kvp.Key, kvp.Value |> Seq.toArray)
            |> Map.ofSeq

        let finalKeywordIndex =
            keywordIndex
            |> Seq.map (fun kvp -> kvp.Key, kvp.Value |> Seq.toArray)
            |> Map.ofSeq

        let stats =
            { TotalTypes = finalTypeIndex.Count
              TotalMethods = finalMethodIndex |> Map.toSeq |> Seq.sumBy (fun (_, methods) -> methods.Length)
              TotalProperties = finalPropertyIndex |> Map.toSeq |> Seq.sumBy (fun (_, props) -> props.Length)
              TotalKeywords = finalKeywordIndex.Count
              PackageCount = projectInfo.Packages.Length
              GenerationTime = TimeSpan.Zero }

        { Version = "1.0.0"
          ProjectInfo = projectInfo
          Indices =
            {| TypeIndex = finalTypeIndex
               MethodIndex = finalMethodIndex
               PropertyIndex = finalPropertyIndex
               KeywordIndex = finalKeywordIndex
               UseCaseIndex = Map.empty // TODO: Implement use case extraction
               SemanticIndex = Map.empty // TODO: Implement semantic indexing
            |}
          Metadata =
            {| GeneratedAt = DateTime.UtcNow
               PackageVersions = Map.empty // TODO: Extract package versions
               IndexStatistics = stats |} }
