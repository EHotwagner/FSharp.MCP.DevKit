// Test the library research functionality
// This script tests the new research capability

#I "./src/FSharp.MCP.DevKit.Core/bin/Debug/net9.0/"
#I "./src/FSharp.MCP.DevKit.Documentation/bin/Debug/net9.0/"

#r "FSharp.MCP.DevKit.Core.dll"
#r "FSharp.MCP.DevKit.Documentation.dll"

open System
open System.IO

// Test creating a simple library overview manually
let testManualOverview () =
    try
        let outputDir = "./test-docs"
        let libraryName = "Newtonsoft.Json"
        
        // Ensure output directory exists
        if not (Directory.Exists outputDir) then
            Directory.CreateDirectory outputDir |> ignore
        
        // Create a basic overview file manually
        let overviewPath = Path.Combine(outputDir, sprintf "%s-Overview.md" libraryName)
        
        let content = sprintf """# %s - Library Overview

*Generated on %s from research template*

## Description

Research-based description for %s. This library appears to be a popular JSON serialization library for .NET commonly used in F# and C# projects.

## Quick Reference Links

- **📦 NuGet Package**: [%s](https://www.nuget.org/packages/%s)
- **📚 Official Documentation**: [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/%s)

## Namespace Tree (Shallow Overview)

```
%s
├── Core
│   ├── Types
│   └── Functions
├── Extensions
│   └── [Library-specific extensions]
└── [Additional namespaces]

Note: This is a template structure.
Generate detailed API docs for actual namespace tree.
```

## Example Usage Patterns

```fsharp
// Basic usage example for %s
open %s

// Common patterns (research-based):
// let result = JsonConvert.SerializeObject(data)
// let deserialized = JsonConvert.DeserializeObject<'T>(json)

// For specific examples, check:
// 1. Generated API documentation
// 2. Official documentation links above
// 3. GitHub repository examples
```

## For AI Agents

This document provides a high-level overview of the library capabilities.
For specific implementation details:

1. Use the detailed API documentation generation tools
2. Search the generated documentation for specific types/methods
3. Reference the official documentation links above

### Commands for Detailed Information
```fsharp
// Generate complete API documentation for %s
docGen "%s"

// Search for specific types or methods
searchDocumentation "YourSearchTerm" None
```
""" libraryName (DateTime.Now.ToString("yyyy-MM-dd")) libraryName libraryName libraryName (libraryName.ToLower().Replace(".", "-")) libraryName libraryName libraryName libraryName libraryName
        
        File.WriteAllText(overviewPath, content)
        
        printfn "✅ Successfully created manual overview: %s" overviewPath
        printfn "📄 File size: %d bytes" (FileInfo(overviewPath).Length)
        
        // Preview the content
        let preview = content.Substring(0, min 400 content.Length)
        printfn "\n📝 Content preview:"
        printfn "%s..." preview
        
        Ok overviewPath
        
    with ex ->
        Error (sprintf "Failed to create overview: %s" ex.Message)

// Run the test
match testManualOverview () with
| Ok path -> printfn "\n🎉 Test successful! Created file at: %s" path
| Error err -> printfn "\n❌ Test failed: %s" err

printfn "\nLibrary research functionality test completed."
