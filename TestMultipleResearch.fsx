#I "./src/FSharp.MCP.DevKit.Core/bin/Debug/net9.0/"
#I "./src/FSharp.MCP.DevKit.Documentation/bin/Debug/net9.0/"

#r "FSharp.MCP.DevKit.Core.dll"
#r "FSharp.MCP.DevKit.Documentation.dll"

open FSharp.MCP.DevKit.Documentation.Tools.DocumentationCommands

printfn "Testing library research with different libraries..."

// Test multiple libraries
let testLibraries =
    [ "System.Text.Json"; "Microsoft.Extensions.Logging"; "Newtonsoft.Json" ]

for library in testLibraries do
    printfn "\n--- Researching %s ---" library
    researchLib library

printfn "\nAll library research tests completed!"

// Show what files were created
open System.IO
let docsDir = "./docs"

if Directory.Exists docsDir then
    let overviewFiles =
        Directory.GetFiles(docsDir, "*-Overview.md") |> Array.map Path.GetFileName

    printfn "\nGenerated overview files:"

    for file in overviewFiles do
        printfn "  📄 %s" file
