// FSharp.MCP.DevKit.Documentation/Model/DocumentationModel.fs
namespace FSharp.MCP.DevKit.Documentation.Model

/// Information/// Generic parameter variance
type GenericVariance =
    | Invariant
    | Covariant

and PackageInfo =
    { Name: string
      Version: string
      Dependencies: PackageInfo list
      Source: PackageSource }

/// Source of the package - online, local file, or local feed
and PackageSource =
    | Online of string
    | LocalFile of string
    | LocalFeed of string

/// Information about a loaded assembly
type AssemblyInfo =
    { Name: string
      FullName: string
      Location: string
      Package: PackageInfo }

/// Core documentation node representing any documentable construct
type DocNode =
    | Namespace of NamespaceInfo
    | Type of TypeInfo
    | Method of MethodInfo
    | Property of PropertyInfo
    | Field of FieldInfo
    | Event of EventInfo
    | Constructor of ConstructorInfo

/// Namespace documentation
and NamespaceInfo =
    { Name: string
      Members: DocNode list
      Assembly: AssemblyInfo }

/// Type documentation with comprehensive metadata
and TypeInfo =
    { Name: string
      FullName: string
      Members: DocNode list
      Kind: TypeKind
      GenericParameters: GenericParameterInfo list
      Attributes: AttributeInfo list
      Interfaces: string list
      BaseType: string option
      Assembly: AssemblyInfo
      XmlDocs: XmlDocumentation option }

/// Kind of type (class, interface, etc.)
and TypeKind =
    | Class
    | Interface
    | Struct
    | Enum
    | Delegate

/// Method documentation with signature and parameter details
and MethodInfo =
    { Name: string
      FullName: string
      Signature: string
      Parameters: ParameterInfo list
      ReturnType: TypeReference
      GenericParameters: GenericParameterInfo list
      Attributes: AttributeInfo list
      DeclaringType: string
      Assembly: AssemblyInfo
      XmlDocs: XmlDocumentation option }

/// Property documentation
and PropertyInfo =
    { Name: string
      FullName: string
      PropertyType: TypeReference
      CanRead: bool
      CanWrite: bool
      Attributes: AttributeInfo list
      DeclaringType: string
      Assembly: AssemblyInfo
      XmlDocs: XmlDocumentation option }

/// Field documentation
and FieldInfo =
    { Name: string
      FullName: string
      FieldType: TypeReference
      IsStatic: bool
      IsReadOnly: bool
      Attributes: AttributeInfo list
      DeclaringType: string
      Assembly: AssemblyInfo
      XmlDocs: XmlDocumentation option }

/// Event documentation
and EventInfo =
    { Name: string
      FullName: string
      EventType: TypeReference
      Attributes: AttributeInfo list
      DeclaringType: string
      Assembly: AssemblyInfo
      XmlDocs: XmlDocumentation option }

/// Constructor documentation
and ConstructorInfo =
    { Parameters: ParameterInfo list
      Signature: string
      Attributes: AttributeInfo list
      DeclaringType: string
      Assembly: AssemblyInfo
      XmlDocs: XmlDocumentation option }

/// Parameter documentation
and ParameterInfo =
    { Name: string
      ParameterType: TypeReference
      IsOptional: bool
      DefaultValue: string option
      Attributes: AttributeInfo list }

/// Generic parameter information
and GenericParameterInfo =
    { Name: string
      Constraints: string list
      Variance: GenericVariance }

/// Generic parameter variance
and GenericVariance =
    | Invariant
    | Covariant
    | Contravariant

/// Reference to a type with generic arguments
and TypeReference =
    { Name: string
      FullName: string
      GenericArguments: TypeReference list }

/// Attribute information with arguments
and AttributeInfo =
    { Name: string
      FullName: string
      Arguments: AttributeArgument list }

/// Attribute argument
and AttributeArgument = { Name: string option; Value: string }

/// Parsed XML documentation from assembly XML files
and XmlDocumentation =
    { Summary: string option
      Parameters: Map<string, string>
      Returns: string option
      Remarks: string option
      Examples: string list
      Exceptions: Map<string, string> }

/// Complete documentation for a package
type PackageDocumentation =
    { Package: PackageInfo
      Assemblies: AssemblyInfo list
      RootNodes: DocNode list }

/// Error cases for package documentation operations
type DocError =
    | PackageNotFound of string
    | DownloadFailed of string * System.Exception
    | AssemblyLoadFailed of string * System.Exception
    | ParseError of string * System.Exception
    | InvalidPackageSource of string
