#I "./src/FSharp.MCP.DevKit.Core/bin/Debug/net9.0/"
#I "./src/FSharp.MCP.DevKit.Documentation/bin/Debug/net9.0/"

#r "FSharp.MCP.DevKit.Core.dll"
#r "FSharp.MCP.DevKit.Documentation.dll"

open FSharp.MCP.DevKit.Documentation.Tools.DocumentationCommands

printfn "Testing the researchLib function..."

// Test the new research functionality
researchLib "FSharp.Core"

printfn "Research test completed!"
