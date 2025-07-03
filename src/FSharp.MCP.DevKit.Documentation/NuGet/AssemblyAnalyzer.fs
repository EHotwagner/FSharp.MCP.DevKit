// FSharp.MCP.DevKit.Documentation/NuGet/AssemblyAnalyzer.fs
namespace FSharp.MCP.DevKit.Documentation.NuGet

open System
open System.Reflection
open FSharp.MCP.DevKit.Documentation.Model

/// Assembly reflection and analysis
module AssemblyAnalyzer =

    /// Convert System.Type to TypeReference
    let rec typeToTypeReference (t: Type) : TypeReference =
        { Name = t.Name
          FullName = t.FullName
          GenericArguments =
            if t.IsGenericType then
                t.GetGenericArguments() |> Array.map typeToTypeReference |> Array.toList
            else
                [] }

    /// Convert reflection ParameterInfo to our ParameterInfo
    let parameterInfoToDocParam (param: System.Reflection.ParameterInfo) : ParameterInfo =
        { Name = param.Name
          ParameterType = typeToTypeReference param.ParameterType
          IsOptional = param.IsOptional
          DefaultValue =
            if param.HasDefaultValue then
                match param.DefaultValue with
                | null -> Some "null"
                | value -> Some(value.ToString())
            else
                Option.None
          Attributes = [] } // TODO: Extract attributes

    /// Convert reflection attributes to our AttributeInfo
    let attributesToDocAttributes (attributes: obj[]) : AttributeInfo list =
        attributes
        |> Array.choose (fun attr ->
            match attr with
            | :? Attribute as a ->
                Some
                    { Name = a.GetType().Name
                      FullName = a.GetType().FullName
                      Arguments = [] } // TODO: Extract attribute arguments
            | _ -> Option.None)
        |> Array.toList

    /// Analyze a method and create MethodInfo
    let analyzeMethod
        (method: System.Reflection.MethodInfo)
        (assembly: AssemblyInfo)
        (xmlDocs: Map<string, XmlDocumentation>)
        : MethodInfo =
        let memberName = sprintf "M:%s.%s" method.DeclaringType.FullName method.Name
        let xmlDoc = xmlDocs.TryFind(memberName)

        { Name = method.Name
          FullName = sprintf "%s.%s" method.DeclaringType.FullName method.Name
          Signature = method.ToString() // TODO: Generate better signature
          Parameters = method.GetParameters() |> Array.map parameterInfoToDocParam |> Array.toList
          ReturnType = typeToTypeReference method.ReturnType
          GenericParameters = [] // TODO: Extract generic parameters
          Attributes = attributesToDocAttributes (method.GetCustomAttributes(false))
          DeclaringType = method.DeclaringType.FullName
          Assembly = assembly
          XmlDocs = xmlDoc }

    /// Analyze a property and create PropertyInfo
    let analyzeProperty
        (property: System.Reflection.PropertyInfo)
        (assembly: AssemblyInfo)
        (xmlDocs: Map<string, XmlDocumentation>)
        : PropertyInfo =
        let memberName = sprintf "P:%s.%s" property.DeclaringType.FullName property.Name
        let xmlDoc = xmlDocs.TryFind(memberName)

        { Name = property.Name
          FullName = sprintf "%s.%s" property.DeclaringType.FullName property.Name
          PropertyType = typeToTypeReference property.PropertyType
          CanRead = property.CanRead
          CanWrite = property.CanWrite
          Attributes = attributesToDocAttributes (property.GetCustomAttributes(false))
          DeclaringType = property.DeclaringType.FullName
          Assembly = assembly
          XmlDocs = xmlDoc }

    /// Analyze a field and create FieldInfo
    let analyzeField
        (field: System.Reflection.FieldInfo)
        (assembly: AssemblyInfo)
        (xmlDocs: Map<string, XmlDocumentation>)
        : FieldInfo =
        let memberName = sprintf "F:%s.%s" field.DeclaringType.FullName field.Name
        let xmlDoc = xmlDocs.TryFind(memberName)

        { Name = field.Name
          FullName = sprintf "%s.%s" field.DeclaringType.FullName field.Name
          FieldType = typeToTypeReference field.FieldType
          IsStatic = field.IsStatic
          IsReadOnly = field.IsInitOnly
          Attributes = attributesToDocAttributes (field.GetCustomAttributes(false))
          DeclaringType = field.DeclaringType.FullName
          Assembly = assembly
          XmlDocs = xmlDoc }

    /// Determine TypeKind from System.Type
    let getTypeKind (t: Type) : TypeKind =
        if t.IsInterface then Interface
        elif t.IsEnum then Enum
        elif t.IsValueType then Struct
        elif typeof<Delegate>.IsAssignableFrom(t) then Delegate
        else Class

    /// Analyze a type and create TypeInfo with all its members
    let analyzeType (t: Type) (assembly: AssemblyInfo) (xmlDocs: Map<string, XmlDocumentation>) : TypeInfo =
        let memberName = sprintf "T:%s" t.FullName
        let xmlDoc = xmlDocs.TryFind(memberName)

        // Get public methods
        let methods =
            t.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.Static)
            |> Array.filter (fun m -> not m.IsSpecialName) // Exclude property getters/setters
            |> Array.map (fun m -> Method(analyzeMethod m assembly xmlDocs))
            |> Array.toList

        // Get public properties
        let properties =
            t.GetProperties(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.Static)
            |> Array.map (fun p -> Property(analyzeProperty p assembly xmlDocs))
            |> Array.toList

        // Get public fields
        let fields =
            t.GetFields(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.Static)
            |> Array.map (fun f -> Field(analyzeField f assembly xmlDocs))
            |> Array.toList

        // TODO: Add events, constructors

        let allMembers = methods @ properties @ fields

        { Name = t.Name
          FullName = t.FullName
          Members = allMembers
          Kind = getTypeKind t
          GenericParameters = [] // TODO: Extract generic parameters
          Attributes = attributesToDocAttributes (t.GetCustomAttributes(false))
          Interfaces = t.GetInterfaces() |> Array.map (fun i -> i.FullName) |> Array.toList
          BaseType =
            if t.BaseType <> null then
                Some t.BaseType.FullName
            else
                Option.None
          Assembly = assembly
          XmlDocs = xmlDoc }

    /// Analyze an assembly and extract all public types
    let analyzeAssembly
        (assemblyPath: string)
        (packageInfo: PackageInfo)
        (xmlDocs: Map<string, XmlDocumentation>)
        : Result<DocNode list, DocError> =
        try
            let assembly = Assembly.LoadFrom(assemblyPath)

            let assemblyInfo =
                { Name = assembly.GetName().Name
                  FullName = assembly.FullName
                  Location = assemblyPath
                  Package = packageInfo }

            // Get all public types
            let publicTypes =
                assembly.GetTypes()
                |> Array.filter (fun t -> t.IsPublic)
                |> Array.map (fun t -> analyzeType t assemblyInfo xmlDocs)

            // Group types by namespace
            let namespaceGroups =
                publicTypes
                |> Array.groupBy (fun t -> t.FullName.Substring(0, t.FullName.LastIndexOf('.')))
                |> Array.map (fun (namespaceName, types) ->
                    let namespaceInfo =
                        { Name = namespaceName
                          Members = types |> Array.map Type |> Array.toList
                          Assembly = assemblyInfo }

                    Namespace namespaceInfo)
                |> Array.toList

            Ok namespaceGroups

        with ex ->
            Error(AssemblyLoadFailed(assemblyPath, ex))
