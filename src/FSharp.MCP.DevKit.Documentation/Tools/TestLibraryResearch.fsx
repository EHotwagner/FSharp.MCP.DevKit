// Test script for the new library research functionality
#r "nuget: FSharp.MCP.DevKit.Documentation"

open FSharp.MCP.DevKit.Documentation.Tools.DocumentationCommands
open FSharp.MCP.DevKit.Documentation.Tools.LibraryResearch

// Test the research functionality
printfn "Testing library research functionality..."

// Test generating a library overview
match generateLibraryOverview "Newtonsoft.Json" "./test-docs" None with
| Ok filePath -> printfn "✅ Successfully generated overview: %s" filePath
| Error err -> printfn "❌ Error: %s" err

// Test the FSI convenience function
printfn "\nTesting FSI convenience function..."
researchLib "FSharp.Core"

printfn "\nLibrary research functionality test completed."
