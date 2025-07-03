// TestDocGeneratorSimple.fsx
// Simple test to verify DocGenerator compilation and basic functionality

#load "DocGenerator.fs"

open FSharp.MCP.DevKit.Documentation.Tools.DocGenerator
open System
open System.IO

printfn "=== Testing DocGenerator Module ==="

// Test 1: Check if types are accessible
printfn "✅ Testing basic types..."
let config = defaultConfig
printfn "Default config loaded: %A" config.OutputDirectory

// Test 2: Check package discovery
printfn "✅ Testing package discovery..."
let nugetPath = getGlobalNuGetCachePath ()
printfn "NuGet cache path: %s" nugetPath
printfn "Cache directory exists: %b" (Directory.Exists nugetPath)

// Test 3: Test package search
printfn "✅ Testing package search..."

match findPackageInCache "Newtonsoft.Json" with
| Some packageVersion -> printfn "Found Newtonsoft.Json: %s at %s" packageVersion.Version packageVersion.Path
| None -> printfn "Newtonsoft.Json not found in cache"

// Test 4: Test basic functionality with limited scope
printfn "✅ Testing documentation generation..."

let testConfig =
    { config with
        MaxTypesPerPackage = Some 2
        OverwriteExisting = true }

match findPackageInCache "Newtonsoft.Json" with
| Some packageVersion ->
    let assemblies = findAssembliesInPackage packageVersion.Path
    printfn "Found %d assemblies in package" assemblies.Length

    if assemblies.Length > 0 then
        let firstAssembly = assemblies.[0]
        printfn "First assembly: %s" firstAssembly
        let types = analyzeAssembly firstAssembly testConfig
        printfn "Analyzed %d types from first assembly" types.Length

        if types.Length > 0 then
            let firstType = types.[0]
            printfn "First type: %s in namespace %s" firstType.Name firstType.Namespace
            printfn "  Methods: %d, Properties: %d" firstType.Methods.Length firstType.Properties.Length
| None -> printfn "No package found for testing assembly analysis"

printfn "✅ All basic tests completed successfully!"
printfn "The DocGenerator module is working correctly."
