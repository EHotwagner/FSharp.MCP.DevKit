// FSharp.MCP.DevKit.Documentation/Tools/DocGenerator.fs
// Core documentation generator combining all milestone capabilities

namespace FSharp.MCP.DevKit.Documentation.Tools

open System
open System.IO
open System.Reflection
open System.Xml.Linq
open System.Text
open System.Collections.Generic

module DocGenerator =

    // === CONFIGURATION ===

    type DocGenConfig =
        { OutputDirectory: string
          IncludeXmlDocs: bool
          OverwriteExisting: bool
          MaxTypesPerPackage: int option
          MarkdownFormat: MarkdownFormat }

    and MarkdownFormat =
        | SingleFile
        | MultiFile
        | EnhancedReference

    let defaultConfig =
        { OutputDirectory = "./docs"
          IncludeXmlDocs = true
          OverwriteExisting = false
          MaxTypesPerPackage = None
          MarkdownFormat = EnhancedReference }

    // === ENHANCED MODELS ===

    type XmlDocumentation =
        { Summary: string option
          Parameters: Map<string, string>
          Returns: string option
          Remarks: string option
          Examples: string list
          Exceptions: Map<string, string> }

    type PackageVersion =
        { Version: string
          Path: string
          LastModified: DateTime }

    type DocGenerationResult =
        { PackageName: string
          Version: string
          OutputPath: string
          TypesDocumented: int
          MethodsDocumented: int
          PropertiesDocumented: int
          GenerationTime: TimeSpan
          HasXmlDocs: bool }

    type MethodDoc =
        { Name: string
          ReturnType: string
          Parameters: (string * string * bool * string option) list // name, type, optional, default
          IsStatic: bool
          IsGeneric: bool
          FullName: string
          DeclaringType: string
          Namespace: string
          XmlDoc: XmlDocumentation option }

    type PropertyDoc =
        { Name: string
          PropertyType: string
          CanRead: bool
          CanWrite: bool
          IsStatic: bool
          FullName: string
          DeclaringType: string
          Namespace: string
          XmlDoc: XmlDocumentation option }

    type TypeDoc =
        { Name: string
          FullName: string
          Namespace: string
          Kind: string // Class, Interface, Struct, Enum, Delegate
          BaseType: string option
          Interfaces: string list
          Methods: MethodDoc list
          Properties: PropertyDoc list
          IsGeneric: bool
          GenericParameters: string list
          XmlDoc: XmlDocumentation option }

    type PackageDoc =
        { Name: string
          Version: string
          Types: TypeDoc list
          Assemblies: AssemblyDoc list
          TotalMethods: int
          TotalProperties: int
          HasXmlDocumentation: bool
          GeneratedAt: DateTime }

    and AssemblyDoc =
        { Name: string
          FullName: string
          Location: string
          Namespaces: NamespaceDoc list }

    and NamespaceDoc =
        { Name: string
          Types: TypeDoc list
          Assembly: AssemblyDoc }

    // === PACKAGE DISCOVERY ===

    let getGlobalNuGetCachePath () : string =
        let userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Path.Combine(userProfile, ".nuget", "packages")

    let findPackageInCache (packageName: string) : PackageVersion option =
        try
            let globalPackagesPath = getGlobalNuGetCachePath ()
            let packageDir = Path.Combine(globalPackagesPath, packageName.ToLower())

            if Directory.Exists(packageDir) then
                let versions =
                    Directory.GetDirectories(packageDir)
                    |> Array.map (fun versionPath ->
                        let version = Path.GetFileName(versionPath)
                        let lastModified = Directory.GetLastWriteTime(versionPath)

                        { Version = version
                          Path = versionPath
                          LastModified = lastModified })
                    |> Array.sortByDescending (fun v -> v.Version) // Simple sort, could improve with proper semver

                if versions.Length > 0 then
                    Some versions.[0] // Return latest version
                else
                    None
            else
                None
        with ex ->
            printfn "Error finding package in cache: %s" ex.Message
            None

    let findAssembliesInPackage (packagePath: string) : string list =
        try
            let libDir = Path.Combine(packagePath, "lib")
            let refDir = Path.Combine(packagePath, "ref")

            let searchDirs = [ libDir; refDir ] |> List.filter Directory.Exists

            searchDirs
            |> List.collect (fun dir -> Directory.GetFiles(dir, "*.dll", SearchOption.AllDirectories) |> Array.toList)
            |> List.distinct
        with ex ->
            printfn "Error finding assemblies: %s" ex.Message
            []

    let findXmlDocumentationFile (assemblyPath: string) : string option =
        try
            let xmlPath = Path.ChangeExtension(assemblyPath, ".xml")
            if File.Exists(xmlPath) then Some xmlPath else None
        with _ ->
            None

    // === XML DOCUMENTATION PARSER ===

    let parseXmlDocFile (xmlPath: string) : Map<string, XmlDocumentation> =
        try
            if not (File.Exists xmlPath) then
                Map.empty
            else
                let doc = XDocument.Load(xmlPath)

                doc.Descendants("member")
                |> Seq.choose (fun memberElement ->
                    let nameAttr = memberElement.Attribute(XName.Get("name"))

                    if nameAttr <> null then
                        let memberName = nameAttr.Value

                        let summary =
                            memberElement.Element(XName.Get("summary"))
                            |> Option.ofObj
                            |> Option.map (fun e -> e.Value.Trim())

                        let parameters =
                            memberElement.Elements(XName.Get("param"))
                            |> Seq.choose (fun paramElement ->
                                let nameAttr = paramElement.Attribute(XName.Get("name"))

                                if nameAttr <> null then
                                    Some(nameAttr.Value, paramElement.Value.Trim())
                                else
                                    None)
                            |> Map.ofSeq

                        let returns =
                            memberElement.Element(XName.Get("returns"))
                            |> Option.ofObj
                            |> Option.map (fun e -> e.Value.Trim())

                        let remarks =
                            memberElement.Element(XName.Get("remarks"))
                            |> Option.ofObj
                            |> Option.map (fun e -> e.Value.Trim())

                        let examples =
                            memberElement.Elements(XName.Get("example"))
                            |> Seq.map (fun e -> e.Value.Trim())
                            |> List.ofSeq

                        let exceptions =
                            memberElement.Elements(XName.Get("exception"))
                            |> Seq.choose (fun excElement ->
                                let crefAttr = excElement.Attribute(XName.Get("cref"))

                                if crefAttr <> null then
                                    Some(crefAttr.Value, excElement.Value.Trim())
                                else
                                    None)
                            |> Map.ofSeq

                        let xmlDoc =
                            { Summary = summary
                              Parameters = parameters
                              Returns = returns
                              Remarks = remarks
                              Examples = examples
                              Exceptions = exceptions }

                        Some(memberName, xmlDoc)
                    else
                        None)
                |> Map.ofSeq
        with ex ->
            printfn "Error parsing XML documentation: %s" ex.Message
            Map.empty

    // === ASSEMBLY ANALYSIS ===

    let generateMemberName (memberInfo: MemberInfo) : string =
        match memberInfo with
        | :? Type as t -> $"T:{t.FullName}"
        | :? MethodInfo as m ->
            let paramTypes =
                m.GetParameters()
                |> Array.map (fun p -> p.ParameterType.FullName)
                |> String.concat ","

            if paramTypes = "" then
                $"M:{m.DeclaringType.FullName}.{m.Name}"
            else
                $"M:{m.DeclaringType.FullName}.{m.Name}({paramTypes})"
        | :? PropertyInfo as p -> $"P:{p.DeclaringType.FullName}.{p.Name}"
        | _ -> ""

    let analyzeMethod (method: MethodInfo) (xmlDocs: Map<string, XmlDocumentation>) : MethodDoc =
        let memberName = generateMemberName method
        let xmlDoc = xmlDocs.TryFind memberName

        let parameters =
            method.GetParameters()
            |> Array.map (fun param ->
                let paramType = param.ParameterType.Name
                let isOptional = param.IsOptional

                let defaultValue =
                    if param.HasDefaultValue then
                        let defaultObj = param.DefaultValue
                        Some(if defaultObj = null then "null" else defaultObj.ToString())
                    else
                        None

                (param.Name, paramType, isOptional, defaultValue))
            |> Array.toList

        { Name = method.Name
          ReturnType = method.ReturnType.Name
          Parameters = parameters
          IsStatic = method.IsStatic
          IsGeneric = method.IsGenericMethod
          FullName = method.ToString()
          DeclaringType = method.DeclaringType.FullName
          Namespace = method.DeclaringType.Namespace |> Option.ofObj |> Option.defaultValue ""
          XmlDoc = xmlDoc }

    let analyzeProperty (property: PropertyInfo) (xmlDocs: Map<string, XmlDocumentation>) : PropertyDoc =
        let memberName = generateMemberName property
        let xmlDoc = xmlDocs.TryFind memberName

        { Name = property.Name
          PropertyType = property.PropertyType.Name
          CanRead = property.CanRead
          CanWrite = property.CanWrite
          IsStatic =
            let getMethod = property.GetGetMethod(true)
            let setMethod = property.GetSetMethod(true)

            (getMethod <> null && getMethod.IsStatic)
            || (setMethod <> null && setMethod.IsStatic)
          FullName = $"{property.DeclaringType.FullName}.{property.Name}"
          DeclaringType = property.DeclaringType.FullName
          Namespace = property.DeclaringType.Namespace |> Option.ofObj |> Option.defaultValue ""
          XmlDoc = xmlDoc }

    let analyzeType (typ: Type) (xmlDocs: Map<string, XmlDocumentation>) (config: DocGenConfig) : TypeDoc =
        let memberName = generateMemberName typ
        let xmlDoc = xmlDocs.TryFind memberName

        let methods =
            typ.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.Static)
            |> Array.filter (fun m -> m.DeclaringType = typ) // Only methods declared on this type
            |> Array.map (fun m -> analyzeMethod m xmlDocs)
            |> Array.toList

        let properties =
            typ.GetProperties(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.Static)
            |> Array.filter (fun p -> p.DeclaringType = typ) // Only properties declared on this type
            |> Array.map (fun p -> analyzeProperty p xmlDocs)
            |> Array.toList

        let interfaces =
            typ.GetInterfaces() |> Array.map (fun i -> i.FullName) |> Array.toList

        let baseType =
            if typ.BaseType <> null && typ.BaseType <> typeof<obj> then
                Some typ.BaseType.FullName
            else
                None

        let kind =
            if typ.IsInterface then "Interface"
            elif typ.IsEnum then "Enum"
            elif typ.IsValueType then "Struct"
            elif typ.IsClass then "Class"
            else "Type"

        { Name = typ.Name
          FullName = typ.FullName
          Namespace = typ.Namespace |> Option.ofObj |> Option.defaultValue ""
          Kind = kind
          BaseType = baseType
          Interfaces = interfaces
          Methods = methods
          Properties = properties
          IsGeneric = typ.IsGenericType
          GenericParameters =
            if typ.IsGenericType then
                typ.GetGenericArguments() |> Array.map (fun t -> t.Name) |> Array.toList
            else
                []
          XmlDoc = xmlDoc }

    let analyzeAssembly (assemblyPath: string) (config: DocGenConfig) : TypeDoc list =
        try
            let assembly = Assembly.LoadFrom(assemblyPath)

            let xmlDocs =
                if config.IncludeXmlDocs then
                    match findXmlDocumentationFile assemblyPath with
                    | Some xmlPath -> parseXmlDocFile xmlPath
                    | None -> Map.empty
                else
                    Map.empty

            let publicTypes =
                assembly.GetTypes()
                |> Array.filter (fun t ->
                    // Include standard public types
                    (t.IsPublic && not t.IsNested)
                    ||
                    // Include F# modules (often compiled as nested public sealed classes)
                    (t.IsPublic
                     && t.IsClass
                     && t.IsSealed
                     && t.IsNested
                     && t.GetCustomAttributes(false)
                        |> Array.exists (fun attr -> attr.GetType().Name = "CompilationMappingAttribute"))
                    ||
                    // Include types that might be F# record types or discriminated unions
                    (t.IsPublic
                     && not t.IsNested
                     && t.IsClass
                     && t.GetCustomAttributes(false)
                        |> Array.exists (fun attr ->
                            let name = attr.GetType().Name
                            name = "CompilationMappingAttribute" || name = "CLIMutableAttribute")))

            let typesToAnalyze =
                match config.MaxTypesPerPackage with
                | Some maxTypes -> publicTypes |> Array.take (min maxTypes publicTypes.Length)
                | None -> publicTypes

            typesToAnalyze
            |> Array.map (fun typ -> analyzeType typ xmlDocs config)
            |> Array.toList

        with ex ->
            printfn "Error analyzing assembly %s: %s" assemblyPath ex.Message
            []

    // === MARKDOWN GENERATION ===

    let renderMethodMarkdown (method: MethodDoc) : string =
        let parameterTable =
            if method.Parameters.IsEmpty then
                ""
            else
                let headers =
                    "| Parameter | Type | Optional | Default | Description |\n|-----------|------|----------|---------|-------------|"

                let rows =
                    method.Parameters
                    |> List.map (fun (name, typ, optional, defaultVal) ->
                        let optionalText = if optional then "Yes" else "No"

                        let defaultText =
                            match defaultVal with
                            | Some value -> value
                            | None -> ""

                        let description =
                            match method.XmlDoc with
                            | Some xml -> xml.Parameters.TryFind name |> Option.defaultValue ""
                            | None -> ""

                        $"| `{name}` | `{typ}` | {optionalText} | `{defaultText}` | {description} |")
                    |> String.concat "\n"

                $"\n\n**Parameters:**\n{headers}\n{rows}"

        let summaryText =
            match method.XmlDoc with
            | Some xml when xml.Summary.IsSome -> $"\n\n**Description:** {xml.Summary.Value}"
            | _ -> ""

        let returnsText =
            match method.XmlDoc with
            | Some xml when xml.Returns.IsSome -> $"\n\n**Returns:** {xml.Returns.Value}"
            | _ -> ""

        let staticText = if method.IsStatic then " (static)" else ""
        let genericText = if method.IsGeneric then " (generic)" else ""

        $"""### {method.Name}{staticText}{genericText}

**Signature:** `{method.FullName}`
**Return Type:** `{method.ReturnType}`{summaryText}{parameterTable}{returnsText}

---"""

    let renderPropertyMarkdown (property: PropertyDoc) : string =
        let accessText =
            match property.CanRead, property.CanWrite with
            | true, true -> "read/write"
            | true, false -> "read-only"
            | false, true -> "write-only"
            | false, false -> "no access"

        let staticText = if property.IsStatic then " (static)" else ""

        let summaryText =
            match property.XmlDoc with
            | Some xml when xml.Summary.IsSome -> $"\n\n**Description:** {xml.Summary.Value}"
            | _ -> ""

        $"""### {property.Name}{staticText}

**Type:** `{property.PropertyType}` ({accessText}){summaryText}

---"""

    let renderTypeMarkdown (typeDoc: TypeDoc) : string =
        let summaryText =
            match typeDoc.XmlDoc with
            | Some xml when xml.Summary.IsSome -> $"\n\n{xml.Summary.Value}"
            | _ -> ""

        let baseTypeText =
            match typeDoc.BaseType with
            | Some baseType -> $"\n- **Base Type:** `{baseType}`"
            | None -> ""

        let interfacesText =
            if typeDoc.Interfaces.IsEmpty then
                ""
            else
                let interfaceList =
                    typeDoc.Interfaces |> List.map (fun i -> $"`{i}`") |> String.concat ", "

                $"\n- **Implements:** {interfaceList}"

        let genericText =
            if typeDoc.IsGeneric then
                let paramList = typeDoc.GenericParameters |> String.concat ", "
                $"\n- **Generic Parameters:** `<{paramList}>`"
            else
                ""

        let methodsSection =
            if typeDoc.Methods.IsEmpty then
                ""
            else
                let methodsMarkdown =
                    typeDoc.Methods |> List.map renderMethodMarkdown |> String.concat "\n\n"

                $"\n\n## Methods\n\n{methodsMarkdown}"

        let propertiesSection =
            if typeDoc.Properties.IsEmpty then
                ""
            else
                let propertiesMarkdown =
                    typeDoc.Properties |> List.map renderPropertyMarkdown |> String.concat "\n\n"

                $"\n\n## Properties\n\n{propertiesMarkdown}"

        $"""# {typeDoc.Name} {typeDoc.Kind}

**Namespace:** `{typeDoc.Namespace}`
**Full Name:** `{typeDoc.FullName}`{baseTypeText}{interfacesText}{genericText}{summaryText}{methodsSection}{propertiesSection}"""

    let renderPackageMarkdown (packageDoc: PackageDoc) (config: DocGenConfig) : string =
        match config.MarkdownFormat with
        | SingleFile ->
            let typesMarkdown =
                packageDoc.Types |> List.map renderTypeMarkdown |> String.concat "\n\n---\n\n"

            let statsText =
                $"**Statistics:** {packageDoc.Types.Length} types, {packageDoc.TotalMethods} methods, {packageDoc.TotalProperties} properties"

            let xmlDocsText =
                if packageDoc.HasXmlDocumentation then
                    " (with XML documentation)"
                else
                    ""

            $"""# {packageDoc.Name} API Reference

**Version:** {packageDoc.Version}
**Generated:** {packageDoc.GeneratedAt.ToString("yyyy-MM-dd HH:mm:ss")}
{statsText}{xmlDocsText}

---

{typesMarkdown}"""

        | MultiFile
        | EnhancedReference ->
            // For multi-file, just generate the index
            let typesList =
                packageDoc.Types
                |> List.map (fun t -> $"- [{t.Name}](./{t.Name}.md) - {t.Kind} in `{t.Namespace}`")
                |> String.concat "\n"

            let statsText =
                $"**Statistics:** {packageDoc.Types.Length} types, {packageDoc.TotalMethods} methods, {packageDoc.TotalProperties} properties"

            let xmlDocsText =
                if packageDoc.HasXmlDocumentation then
                    " (with XML documentation)"
                else
                    ""

            $"""# {packageDoc.Name} API Reference

**Version:** {packageDoc.Version}
**Generated:** {packageDoc.GeneratedAt.ToString("yyyy-MM-dd HH:mm:ss")}
{statsText}{xmlDocsText}

## Types

{typesList}"""

    // === ENHANCED NAMESPACE DOCUMENTATION ===

    /// Generate dedicated namespace documentation files
    let generateNamespaceDocumentation (packageDoc: PackageDoc) (outputDir: string) : Result<string list, string> =
        try
            let namespaceFiles = ResizeArray<string>()

            // Group types by namespace and remove duplicates
            let namespaceGroups =
                packageDoc.Assemblies
                |> List.collect (fun assembly -> assembly.Namespaces)
                |> List.groupBy (fun ns -> ns.Name)
                |> List.map (fun (name, nsList) ->
                    name,
                    nsList
                    |> List.collect (fun ns -> ns.Types)
                    |> List.distinctBy (fun t -> t.FullName))

            for (namespaceName, types) in namespaceGroups do
                let fileName = $"{namespaceName.Replace('.', '_')}_Namespace.md"
                let filePath = Path.Combine(outputDir, fileName)

                let sb = StringBuilder()
                sb.AppendLine($"# {namespaceName} Namespace") |> ignore
                sb.AppendLine() |> ignore
                sb.AppendLine($"**Types:** {types.Length}") |> ignore
                sb.AppendLine() |> ignore

                // Namespace summary if available
                let namespaceSummary =
                    types
                    |> List.tryPick (fun t ->
                        t.XmlDoc
                        |> Option.bind (fun xml -> xml.Summary)
                        |> Option.filter (fun s -> s.Contains(namespaceName)))

                match namespaceSummary with
                | Some summary ->
                    sb.AppendLine($"**Summary:** {summary}") |> ignore
                    sb.AppendLine() |> ignore
                | None -> ()

                // Group types by kind
                let typesByKind =
                    types |> List.groupBy (fun t -> t.Kind.ToString()) |> List.sortBy fst

                for (kind, kindTypes) in typesByKind do
                    let pluralKind =
                        match kind with
                        | "Class" -> "Classes"
                        | "Interface" -> "Interfaces"
                        | "Struct" -> "Structs"
                        | "Enum" -> "Enums"
                        | "Delegate" -> "Delegates"
                        | other -> other + "s"

                    sb.AppendLine($"## {pluralKind} ({kindTypes.Length})") |> ignore
                    sb.AppendLine() |> ignore

                    for t in kindTypes |> List.sortBy (fun x -> x.Name) do
                        let typeFileName = $"{t.Name}.md"
                        sb.AppendLine($"### [{t.Name}](./{typeFileName})") |> ignore
                        sb.AppendLine($"**Full Name:** `{t.FullName}`") |> ignore

                        match t.XmlDoc |> Option.bind (fun x -> x.Summary) with
                        | Some summary -> sb.AppendLine($"**Summary:** {summary}") |> ignore
                        | None -> ()

                        sb.AppendLine($"**Members:** {t.Methods.Length} methods, {t.Properties.Length} properties")
                        |> ignore

                        sb.AppendLine() |> ignore

                File.WriteAllText(filePath, sb.ToString())
                namespaceFiles.Add(filePath)

            Ok(namespaceFiles |> Seq.toList)
        with ex ->
            Error $"Error generating namespace documentation: {ex.Message}"

    // === FILE OPERATIONS ===

    let ensureDirectoryExists (path: string) : unit =
        if not (Directory.Exists path) then
            Directory.CreateDirectory path |> ignore

    let checkDocumentationExists (packageName: string) (version: string) (config: DocGenConfig) : bool =
        let outputPath = Path.Combine(config.OutputDirectory, packageName)
        let indexFile = Path.Combine(outputPath, "README.md")
        File.Exists indexFile

    let writeDocumentation (packageDoc: PackageDoc) (config: DocGenConfig) : string =
        let outputPath = Path.Combine(config.OutputDirectory, packageDoc.Name)
        ensureDirectoryExists outputPath

        match config.MarkdownFormat with
        | SingleFile ->
            let filePath = Path.Combine(outputPath, "README.md")
            let content = renderPackageMarkdown packageDoc config
            File.WriteAllText(filePath, content)
            filePath

        | MultiFile
        | EnhancedReference ->
            // Write index file
            let indexPath = Path.Combine(outputPath, "README.md")
            let indexContent = renderPackageMarkdown packageDoc config
            File.WriteAllText(indexPath, indexContent)

            // Write individual type files
            for typeDoc in packageDoc.Types do
                let typeFilePath = Path.Combine(outputPath, $"{typeDoc.Name}.md")
                let typeContent = renderTypeMarkdown typeDoc
                File.WriteAllText(typeFilePath, typeContent)

            // Generate namespace documentation files
            match generateNamespaceDocumentation packageDoc outputPath with
            | Ok namespaceFiles -> printfn "Generated namespace documentation: %d files" namespaceFiles.Length
            | Error err -> printfn "Warning: Failed to generate namespace documentation: %s" err

            indexPath

    // === MAIN GENERATION FUNCTIONS ===

    let generateDocumentationForPackage
        (packageName: string)
        (config: DocGenConfig)
        : Result<DocGenerationResult, string> =
        try
            let startTime = DateTime.Now

            // Check if docs already exist
            match findPackageInCache packageName with
            | None -> Error $"Package '{packageName}' not found in local NuGet cache"
            | Some packageVersion ->

                if
                    not config.OverwriteExisting
                    && checkDocumentationExists packageName packageVersion.Version config
                then
                    Ok
                        { PackageName = packageName
                          Version = packageVersion.Version
                          OutputPath = Path.Combine(config.OutputDirectory, packageName)
                          TypesDocumented = 0
                          MethodsDocumented = 0
                          PropertiesDocumented = 0
                          GenerationTime = TimeSpan.Zero
                          HasXmlDocs = false }
                else
                    // Find assemblies
                    let assemblies = findAssembliesInPackage packageVersion.Path

                    if assemblies.IsEmpty then
                        Error $"No assemblies found in package '{packageName}'"
                    else
                        // Analyze all assemblies
                        let allTypes =
                            assemblies
                            |> List.collect (fun assemblyPath -> analyzeAssembly assemblyPath config)

                        if allTypes.IsEmpty then
                            Error $"No public types found in package '{packageName}'"
                        else
                            let totalMethods = allTypes |> List.sumBy (fun t -> t.Methods.Length)
                            let totalProperties = allTypes |> List.sumBy (fun t -> t.Properties.Length)

                            let hasXmlDocs =
                                allTypes
                                |> List.exists (fun t ->
                                    t.XmlDoc.IsSome
                                    || t.Methods |> List.exists (fun m -> m.XmlDoc.IsSome)
                                    || t.Properties |> List.exists (fun p -> p.XmlDoc.IsSome))

                            // Create assemblies structure for namespace documentation
                            let assemblyGroups =
                                assemblies
                                |> List.map (fun assemblyPath ->
                                    let assemblyName = Path.GetFileNameWithoutExtension(assemblyPath)

                                    let assemblyTypes =
                                        allTypes
                                        |> List.filter (fun (t: TypeDoc) ->
                                            // Check if type belongs to this assembly by comparing declaring assembly
                                            t.FullName.StartsWith(assemblyName) || t.Namespace.Contains(assemblyName))

                                    let namespaceGroups =
                                        assemblyTypes
                                        |> List.groupBy (fun t -> t.Namespace)
                                        |> List.map (fun (ns, types) ->
                                            { Name = ns
                                              Types = types
                                              Assembly = Unchecked.defaultof<AssemblyDoc> })

                                    { Name = assemblyName
                                      FullName = assemblyPath
                                      Location = assemblyPath
                                      Namespaces = namespaceGroups })

                            let packageDoc =
                                { Name = packageName
                                  Version = packageVersion.Version
                                  Types = allTypes
                                  Assemblies = assemblyGroups
                                  TotalMethods = totalMethods
                                  TotalProperties = totalProperties
                                  HasXmlDocumentation = hasXmlDocs
                                  GeneratedAt = DateTime.Now }

                            // Generate documentation
                            let outputPath = writeDocumentation packageDoc config
                            let endTime = DateTime.Now

                            Ok
                                { PackageName = packageName
                                  Version = packageVersion.Version
                                  OutputPath = outputPath
                                  TypesDocumented = allTypes.Length
                                  MethodsDocumented = totalMethods
                                  PropertiesDocumented = totalProperties
                                  GenerationTime = endTime - startTime
                                  HasXmlDocs = hasXmlDocs }

        with ex ->
            Error $"Error generating documentation for '{packageName}': {ex.Message}"

    // === MARKDOWN SEARCH FUNCTIONALITY ===

    /// Search for identifiers in generated markdown documentation
    type MarkdownSearchResult =
        { FilePath: string
          FileName: string
          Namespace: string option
          MatchType: MatchType
          Context: string option }

    and MatchType =
        | TypeName
        | MethodName
        | PropertyName
        | FieldName
        | NamespaceName
        | Content

    /// Search all generated markdown files for a specific identifier
    let searchMarkdownDocumentation
        (searchTerm: string)
        (docsDirectory: string)
        : Result<MarkdownSearchResult list, string> =
        try
            if not (Directory.Exists docsDirectory) then
                Error $"Documentation directory does not exist: {docsDirectory}"
            else
                let results = ResizeArray<MarkdownSearchResult>()
                let searchTermLower = searchTerm.ToLowerInvariant()

                // Search all markdown files recursively
                let markdownFiles =
                    Directory.GetFiles(docsDirectory, "*.md", SearchOption.AllDirectories)
                    |> Array.filter (fun f -> Path.GetFileName(f) <> "README.md") // Skip index files

                for filePath in markdownFiles do
                    try
                        let content = File.ReadAllText(filePath)
                        let fileName = Path.GetFileNameWithoutExtension(filePath)
                        let lines = content.Split([| '\n'; '\r' |], StringSplitOptions.RemoveEmptyEntries)

                        // Extract namespace from content if available
                        let namespaceInfo =
                            lines
                            |> Array.tryFind (fun line -> line.StartsWith("**Namespace:**"))
                            |> Option.map (fun line -> line.Replace("**Namespace:**", "").Trim().Trim('`'))

                        // Check if filename matches search term (type name match)
                        if fileName.ToLowerInvariant().Contains(searchTermLower) then
                            results.Add
                                { FilePath = filePath
                                  FileName = fileName
                                  Namespace = namespaceInfo
                                  MatchType = TypeName
                                  Context = Some $"Type: {fileName}" }

                        // Search for method/property/field names in headers
                        for line in lines do
                            let lineLower = line.ToLowerInvariant()

                            if lineLower.Contains(searchTermLower) then
                                let matchType, context =
                                    if line.StartsWith("### ") then
                                        let memberName = line.Substring(4).Trim()

                                        if memberName.ToLowerInvariant().Contains(searchTermLower) then
                                            MethodName, Some $"Member: {memberName}"
                                        else
                                            Content, Some $"Content: {line.Trim()}"
                                    elif line.StartsWith("## ") then
                                        let typeName = line.Substring(3).Trim()

                                        if typeName.ToLowerInvariant().Contains(searchTermLower) then
                                            TypeName, Some $"Type: {typeName}"
                                        else
                                            Content, Some $"Content: {line.Trim()}"
                                    elif line.Contains("**Property:**") || line.Contains("**Field:**") then
                                        PropertyName, Some $"Property/Field: {line.Trim()}"
                                    else
                                        Content, Some $"Content: {line.Trim()}"

                                results.Add
                                    { FilePath = filePath
                                      FileName = fileName
                                      Namespace = namespaceInfo
                                      MatchType = matchType
                                      Context = context }
                    with ex ->
                        // Continue with other files if one fails
                        printfn "Warning: Failed to search file %s: %s" filePath ex.Message

                // Remove duplicates and sort by relevance
                let uniqueResults =
                    results
                    |> Seq.distinctBy (fun r -> r.FilePath, r.MatchType, r.Context)
                    |> Seq.sortBy (fun r ->
                        match r.MatchType with
                        | TypeName -> 0
                        | MethodName -> 1
                        | PropertyName -> 2
                        | FieldName -> 3
                        | NamespaceName -> 4
                        | Content -> 5)
                    |> Seq.toList

                Ok uniqueResults
        with ex ->
            Error $"Error searching markdown documentation: {ex.Message}"

    /// Format search results as a readable string
    let formatSearchResults (results: MarkdownSearchResult list) : string =
        if results.IsEmpty then
            "No matches found."
        else
            let grouped = results |> List.groupBy (fun r -> r.FileName)
            let sb = StringBuilder()

            sb.AppendLine($"Found {results.Length} matches in {grouped.Length} files:")
            |> ignore

            sb.AppendLine() |> ignore

            for (fileName, matches) in grouped do
                sb.AppendLine($"**{fileName}**") |> ignore

                let namespaceInfo =
                    matches
                    |> List.tryPick (fun m -> m.Namespace)
                    |> Option.map (fun ns -> $" (Namespace: {ns})")
                    |> Option.defaultValue ""

                sb.AppendLine($"  File: {(matches |> List.head).FilePath}{namespaceInfo}")
                |> ignore

                for m in matches |> List.distinctBy (fun x -> x.Context) do
                    let matchTypeStr =
                        match m.MatchType with
                        | TypeName -> "Type"
                        | MethodName -> "Method"
                        | PropertyName -> "Property"
                        | FieldName -> "Field"
                        | NamespaceName -> "Namespace"
                        | Content -> "Content"

                    match m.Context with
                    | Some context -> sb.AppendLine($"  - {matchTypeStr}: {context}") |> ignore
                    | None -> sb.AppendLine($"  - {matchTypeStr} match") |> ignore

                sb.AppendLine() |> ignore

            sb.ToString()

    // === SYMBOL SEARCH FUNCTIONALITY ===

    /// Search for symbols (types, methods, properties) in PackageDoc
    type SymbolSearchResult =
        { Name: string
          FullName: string
          Kind: SymbolKind
          Namespace: string
          DeclaringType: string option
          Summary: string option
          MatchScore: int }

    and SymbolKind =
        | TypeSymbol
        | MethodSymbol
        | PropertySymbol
        | FieldSymbol

    /// Search for symbols in a PackageDoc by name
    let searchSymbols (searchTerm: string) (packageDoc: PackageDoc) : SymbolSearchResult list =
        let searchTermLower = searchTerm.ToLowerInvariant()
        let results = ResizeArray<SymbolSearchResult>()

        // Calculate match score based on how closely the name matches
        let calculateMatchScore (name: string) (searchTerm: string) : int =
            let nameLower = name.ToLowerInvariant()

            if nameLower = searchTerm then 100 // Exact match
            elif nameLower.StartsWith(searchTerm) then 80 // Starts with
            elif nameLower.Contains(searchTerm) then 60 // Contains
            else 0 // No match

        // Search types
        for typeDoc in packageDoc.Types do
            let typeScore = calculateMatchScore typeDoc.Name searchTermLower

            if typeScore > 0 then
                results.Add
                    { Name = typeDoc.Name
                      FullName = typeDoc.FullName
                      Kind = TypeSymbol
                      Namespace = typeDoc.Namespace
                      DeclaringType = None
                      Summary = typeDoc.XmlDoc |> Option.bind (fun xml -> xml.Summary)
                      MatchScore = typeScore }

            // Search methods in this type
            for method in typeDoc.Methods do
                let methodScore = calculateMatchScore method.Name searchTermLower

                if methodScore > 0 then
                    results.Add
                        { Name = method.Name
                          FullName = method.FullName
                          Kind = MethodSymbol
                          Namespace = method.Namespace
                          DeclaringType = Some typeDoc.Name
                          Summary = method.XmlDoc |> Option.bind (fun xml -> xml.Summary)
                          MatchScore = methodScore }

            // Search properties in this type
            for property in typeDoc.Properties do
                let propertyScore = calculateMatchScore property.Name searchTermLower

                if propertyScore > 0 then
                    results.Add
                        { Name = property.Name
                          FullName = property.FullName
                          Kind = PropertySymbol
                          Namespace = property.Namespace
                          DeclaringType = Some typeDoc.Name
                          Summary = property.XmlDoc |> Option.bind (fun xml -> xml.Summary)
                          MatchScore = propertyScore }

        // Sort by match score (highest first) then by name
        results |> Seq.sortBy (fun r -> -r.MatchScore, r.Name) |> Seq.toList

    /// Search for symbols across all packages in a directory
    let searchSymbolsInDocumentationDir
        (searchTerm: string)
        (docsDirectory: string)
        : Result<SymbolSearchResult list, string> =
        try
            if not (Directory.Exists docsDirectory) then
                Error $"Documentation directory does not exist: {docsDirectory}"
            else
                // This is a simplified version that searches markdown files
                // In a full implementation, we would load the PackageDoc objects
                let results = ResizeArray<SymbolSearchResult>()
                let searchTermLower = searchTerm.ToLowerInvariant()

                // Search all markdown files for symbol definitions
                let markdownFiles =
                    Directory.GetFiles(docsDirectory, "*.md", SearchOption.AllDirectories)

                for filePath in markdownFiles do
                    try
                        let content = File.ReadAllText(filePath)
                        let lines = content.Split([| '\n'; '\r' |], StringSplitOptions.RemoveEmptyEntries)

                        // Extract namespace
                        let namespaceInfo =
                            lines
                            |> Array.tryFind (fun line -> line.StartsWith("**Namespace:**"))
                            |> Option.map (fun line -> line.Replace("**Namespace:**", "").Trim().Trim('`'))
                            |> Option.defaultValue ""

                        // Search for type definitions
                        for line in lines do
                            if
                                line.StartsWith("# ")
                                && (line.Contains("Class")
                                    || line.Contains("Interface")
                                    || line.Contains("Struct")
                                    || line.Contains("Enum"))
                            then
                                let typeName = line.Substring(2).Split(' ').[0]

                                if typeName.ToLowerInvariant().Contains(searchTermLower) then
                                    let matchScore =
                                        if typeName.ToLowerInvariant() = searchTermLower then
                                            100
                                        elif typeName.ToLowerInvariant().StartsWith(searchTermLower) then
                                            80
                                        else
                                            60

                                    results.Add
                                        { Name = typeName
                                          FullName = $"{namespaceInfo}.{typeName}"
                                          Kind = TypeSymbol
                                          Namespace = namespaceInfo
                                          DeclaringType = None
                                          Summary = None
                                          MatchScore = matchScore }

                            elif line.StartsWith("### ") then
                                let memberName = line.Substring(4).Split('(').[0].Trim()

                                if memberName.ToLowerInvariant().Contains(searchTermLower) then
                                    let matchScore =
                                        if memberName.ToLowerInvariant() = searchTermLower then
                                            100
                                        elif memberName.ToLowerInvariant().StartsWith(searchTermLower) then
                                            80
                                        else
                                            60

                                    let isMethod = line.Contains("(") || content.Contains($"**Return Type:** `")
                                    let kind = if isMethod then MethodSymbol else PropertySymbol

                                    results.Add
                                        { Name = memberName
                                          FullName = $"{namespaceInfo}.{memberName}"
                                          Kind = kind
                                          Namespace = namespaceInfo
                                          DeclaringType = Some(Path.GetFileNameWithoutExtension(filePath))
                                          Summary = None
                                          MatchScore = matchScore }
                    with ex ->
                        printfn "Warning: Failed to search file %s: %s" filePath ex.Message

                let sortedResults =
                    results
                    |> Seq.distinctBy (fun r -> r.FullName, r.Kind)
                    |> Seq.sortBy (fun r -> -r.MatchScore, r.Name)
                    |> Seq.toList

                Ok sortedResults
        with ex ->
            Error $"Error searching symbols: {ex.Message}"

    /// Format symbol search results as a readable string
    let formatSymbolSearchResults (results: SymbolSearchResult list) : string =
        if results.IsEmpty then
            "No symbols found."
        else
            let sb = StringBuilder()
            sb.AppendLine($"Found {results.Length} symbols:") |> ignore
            sb.AppendLine() |> ignore

            let grouped = results |> List.groupBy (fun r -> r.Kind)

            for (kind, symbols) in grouped do
                let kindName =
                    match kind with
                    | TypeSymbol -> "Types"
                    | MethodSymbol -> "Methods"
                    | PropertySymbol -> "Properties"
                    | FieldSymbol -> "Fields"

                sb.AppendLine($"## {kindName} ({symbols.Length})") |> ignore
                sb.AppendLine() |> ignore

                for symbol in symbols |> List.take (min 10 symbols.Length) do // Limit to top 10 per category
                    sb.AppendLine($"### {symbol.Name}") |> ignore
                    sb.AppendLine($"- **Full Name:** `{symbol.FullName}`") |> ignore
                    sb.AppendLine($"- **Namespace:** `{symbol.Namespace}`") |> ignore

                    match symbol.DeclaringType with
                    | Some declaringType -> sb.AppendLine($"- **Declaring Type:** `{declaringType}`") |> ignore
                    | None -> ()

                    match symbol.Summary with
                    | Some summary -> sb.AppendLine($"- **Summary:** {summary}") |> ignore
                    | None -> ()

                    sb.AppendLine($"- **Match Score:** {symbol.MatchScore}%%") |> ignore
                    sb.AppendLine() |> ignore

                if symbols.Length > 10 then
                    sb.AppendLine($"... and {symbols.Length - 10} more {kindName.ToLower()}")
                    |> ignore

                    sb.AppendLine() |> ignore

            sb.ToString()

    // === ADVANCED SEARCH FEATURES ===

    /// Search for symbols by signature pattern (e.g., methods with specific parameter types)
    let searchBySignature (signaturePattern: string) (packageDoc: PackageDoc) : SymbolSearchResult list =
        let results = ResizeArray<SymbolSearchResult>()
        let patternLower = signaturePattern.ToLowerInvariant()

        for typeDoc in packageDoc.Types do
            for method in typeDoc.Methods do
                let signature = method.FullName.ToLowerInvariant()

                if signature.Contains(patternLower) then
                    results.Add
                        { Name = method.Name
                          FullName = method.FullName
                          Kind = MethodSymbol
                          Namespace = method.Namespace
                          DeclaringType = Some typeDoc.Name
                          Summary = method.XmlDoc |> Option.bind (fun xml -> xml.Summary)
                          MatchScore = 70 }

        results |> Seq.toList

    /// Find all overloads of a method
    let findMethodOverloads (methodName: string) (packageDoc: PackageDoc) : SymbolSearchResult list =
        let results = ResizeArray<SymbolSearchResult>()
        let methodNameLower = methodName.ToLowerInvariant()

        for typeDoc in packageDoc.Types do
            let overloads =
                typeDoc.Methods
                |> List.filter (fun m -> m.Name.ToLowerInvariant() = methodNameLower)

            for method in overloads do
                results.Add
                    { Name = method.Name
                      FullName = method.FullName
                      Kind = MethodSymbol
                      Namespace = method.Namespace
                      DeclaringType = Some typeDoc.Name
                      Summary = method.XmlDoc |> Option.bind (fun xml -> xml.Summary)
                      MatchScore = 90 }

        results |> Seq.toList

    // === PACKAGE CACHE SEARCH FUNCTIONALITY ===

    /// Search for packages in the global NuGet cache
    let searchPackagesInCache (searchTerm: string) : (string * string list) list =
        try
            let globalPackagesPath = getGlobalNuGetCachePath ()

            if not (Directory.Exists globalPackagesPath) then
                []
            else
                let searchTermLower = searchTerm.ToLowerInvariant()

                Directory.GetDirectories(globalPackagesPath)
                |> Array.choose (fun packageDir ->
                    let packageName = Path.GetFileName(packageDir)

                    if packageName.ToLowerInvariant().Contains(searchTermLower) then
                        let versions =
                            Directory.GetDirectories(packageDir)
                            |> Array.map Path.GetFileName
                            |> Array.sort
                            |> Array.toList

                        Some(packageName, versions)
                    else
                        None)
                |> Array.toList
        with ex ->
            printfn "Error searching packages in cache: %s" ex.Message
            []

    /// List all packages in the global NuGet cache
    let listAllPackagesInCache () : (string * string list) list =
        try
            let globalPackagesPath = getGlobalNuGetCachePath ()

            if not (Directory.Exists globalPackagesPath) then
                []
            else
                Directory.GetDirectories(globalPackagesPath)
                |> Array.map (fun packageDir ->
                    let packageName = Path.GetFileName(packageDir)

                    let versions =
                        Directory.GetDirectories(packageDir)
                        |> Array.map Path.GetFileName
                        |> Array.sort
                        |> Array.toList

                    (packageName, versions))
                |> Array.toList
        with ex ->
            printfn "Error listing packages in cache: %s" ex.Message
            []

    /// Get all versions of a specific package
    let getPackageVersions (packageName: string) : string list =
        try
            let globalPackagesPath = getGlobalNuGetCachePath ()
            let packageDir = Path.Combine(globalPackagesPath, packageName.ToLower())

            if Directory.Exists(packageDir) then
                Directory.GetDirectories(packageDir)
                |> Array.map Path.GetFileName
                |> Array.sort
                |> Array.toList
            else
                []
        with ex ->
            printfn "Error getting package versions: %s" ex.Message
            []
