// FSharp.MCP.DevKit.Documentation/NuGet/XmlDocumentationParser.fs
namespace FSharp.MCP.DevKit.Documentation.NuGet

open System
open System.IO
open System.Xml.Linq
open FSharp.MCP.DevKit.Documentation.Model
// Import reflection types explicitly
open System.Reflection

/// Production-ready XML documentation parser for assembly XML files
/// Based on the working implementation from TestMilestone4Practical.fsx
module XmlDocumentationParser =

    /// Parse XML documentation file into structured documentation map
    /// Returns Map<memberName, XmlDocumentation> for fast lookup by member name
    let parseXmlDocFile (xmlPath: string) : Map<string, XmlDocumentation> =
        try
            if not (File.Exists xmlPath) then
                Map.empty
            else
                let doc = XDocument.Load(xmlPath)
                let members = doc.Descendants(XName.Get("member"))

                members
                |> Seq.choose (fun memberElement ->
                    let nameAttr = memberElement.Attribute(XName.Get("name"))

                    if nameAttr <> null then
                        let memberName = nameAttr.Value

                        // Parse summary section
                        let summary =
                            memberElement.Descendants(XName.Get("summary"))
                            |> Seq.tryHead
                            |> Option.map (fun e -> e.Value.Trim())

                        // Parse parameter documentation
                        let parameters =
                            memberElement.Descendants(XName.Get("param"))
                            |> Seq.choose (fun paramElement ->
                                let nameAttr = paramElement.Attribute(XName.Get("name"))

                                if nameAttr <> null then
                                    Some(nameAttr.Value, paramElement.Value.Trim())
                                else
                                    None)
                            |> Map.ofSeq

                        // Parse returns section
                        let returns =
                            memberElement.Descendants(XName.Get("returns"))
                            |> Seq.tryHead
                            |> Option.map (fun e -> e.Value.Trim())

                        // Parse remarks section
                        let remarks =
                            memberElement.Descendants(XName.Get("remarks"))
                            |> Seq.tryHead
                            |> Option.map (fun e -> e.Value.Trim())

                        // Parse example sections
                        let examples =
                            memberElement.Descendants(XName.Get("example"))
                            |> Seq.map (fun e -> e.Value.Trim())
                            |> Seq.toList

                        // Parse exception documentation
                        let exceptions =
                            memberElement.Descendants(XName.Get("exception"))
                            |> Seq.choose (fun exceptionElement ->
                                let crefAttr = exceptionElement.Attribute(XName.Get("cref"))

                                if crefAttr <> null then
                                    Some(crefAttr.Value, exceptionElement.Value.Trim())
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
            // Log warning but don't fail - return empty map if XML parsing fails
            printfn "⚠ Warning: Failed to parse XML documentation file %s: %s" xmlPath ex.Message
            Map.empty

    /// Generate XML documentation member name from MemberInfo
    /// This matches the format used in XML documentation files
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
        | :? FieldInfo as f -> $"F:{f.DeclaringType.FullName}.{f.Name}"
        | :? EventInfo as e -> $"E:{e.DeclaringType.FullName}.{e.Name}"
        | :? ConstructorInfo as c ->
            let paramTypes =
                c.GetParameters()
                |> Array.map (fun p -> p.ParameterType.FullName)
                |> String.concat ","

            if paramTypes = "" then
                $"M:{c.DeclaringType.FullName}.#ctor"
            else
                $"M:{c.DeclaringType.FullName}.#ctor({paramTypes})"
        | _ -> ""

    /// Get XML documentation for a specific member by MemberInfo
    let getDocumentationForMember
        (xmlDocs: Map<string, XmlDocumentation>)
        (memberInfo: MemberInfo)
        : XmlDocumentation option =
        let memberName = generateMemberName memberInfo
        xmlDocs.TryFind(memberName)

    /// Get XML documentation for a specific member by name (direct lookup)
    let getDocumentation (xmlDocs: Map<string, XmlDocumentation>) (memberName: string) : XmlDocumentation option =
        xmlDocs.TryFind(memberName)

    /// Find XML documentation file for an assembly
    /// Looks for .xml file with same name as assembly in same directory
    let findXmlDocFile (assemblyPath: string) : string option =
        try
            let assemblyDir = Path.GetDirectoryName(assemblyPath)
            let assemblyName = Path.GetFileNameWithoutExtension(assemblyPath)
            let xmlPath = Path.Combine(assemblyDir, $"{assemblyName}.xml")

            if File.Exists(xmlPath) then Some xmlPath else None
        with ex ->
            printfn "⚠ Error finding XML documentation file for %s: %s" assemblyPath ex.Message
            None

    /// Load and parse XML documentation for an assembly if available
    let loadXmlDocumentationForAssembly (assemblyPath: string) : Map<string, XmlDocumentation> =
        match findXmlDocFile assemblyPath with
        | Some xmlPath ->
            printfn "📄 Loading XML documentation: %s" (Path.GetFileName xmlPath)
            parseXmlDocFile xmlPath
        | None ->
            printfn "ℹ No XML documentation found for %s" (Path.GetFileName assemblyPath)
            Map.empty

    /// Test the XML documentation parser with validation
    let validateXmlDocumentation (xmlPath: string) : Result<int * int, string> =
        try
            if not (File.Exists xmlPath) then
                Error $"XML file not found: {xmlPath}"
            else
                let xmlDocs = parseXmlDocFile xmlPath
                let totalMembers = xmlDocs.Count

                let membersWithSummary =
                    xmlDocs.Values |> Seq.filter (fun doc -> doc.Summary.IsSome) |> Seq.length

                Ok(totalMembers, membersWithSummary)
        with ex ->
            Error $"Failed to validate XML documentation: {ex.Message}"
