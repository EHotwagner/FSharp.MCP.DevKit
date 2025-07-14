namespace FSharp.MCP.DevKit.Server

open System
open System.ComponentModel
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open FSharp.MCP.DevKit.Documentation.Tools.DocumentationCommands
open FSharp.MCP.DevKit.Documentation.Tools.DocGenerator
open ModelContextProtocol.Server

/// Module containing MCP server tools for documentation generation and search
module McpDocumentationTools =

    /// Documentation generation and search MCP tools
    [<McpServerToolType>]
    type DocumentationMcpTools() =

        /// Generate documentation for a NuGet package
        [<McpServerTool; Description("Generate comprehensive API documentation for a NuGet package")>]
        static member GeneratePackageDocumentation
            (
                [<Description("Name of the NuGet package (e.g., 'Newtonsoft.Json')")>] packageName: string,
                [<Description("Output directory (optional, defaults to ./docs)")>] ?outputDir: string,
                [<Description("Whether to overwrite existing documentation (default: false)")>] ?overwrite: bool
            ) : Task<string> =
            task {
                try
                    let result =
                        generatePackageDocumentation packageName outputDir (defaultArg overwrite false)

                    match result with
                    | Success(message, details) ->
                        return
                            match details with
                            | Some detail -> sprintf "%s\n\n%s" message detail
                            | None -> message
                    | Error errorMsg -> return errorMsg
                    | Info(message, data) -> return sprintf "%s\n%s" message data

                with ex ->
                    return sprintf "❌ Error generating package documentation: %s" ex.Message
            }

        /// Generate documentation for all packages in an F# project
        [<McpServerTool;
          Description("Generate comprehensive API documentation for all packages referenced in an F# project")>]
        static member GenerateProjectDocumentation
            (
                [<Description("Path to the F# project file (.fsproj)")>] projectPath: string,
                [<Description("Output directory (optional, defaults to ./docs)")>] ?outputDir: string,
                [<Description("Whether to overwrite existing documentation (default: false)")>] ?overwrite: bool
            ) : Task<string> =
            task {
                try
                    let result =
                        generateProjectDocumentation projectPath outputDir (defaultArg overwrite false)

                    match result with
                    | Success(message, details) ->
                        return
                            match details with
                            | Some detail -> sprintf "%s\n\n%s" message detail
                            | None -> message
                    | Error errorMsg -> return errorMsg
                    | Info(message, data) -> return sprintf "%s\n%s" message data

                with ex ->
                    return sprintf "❌ Error generating project documentation: %s" ex.Message
            }

        /// List cached NuGet packages available for documentation
        [<McpServerTool; Description("List NuGet packages available in the local cache for documentation generation")>]
        static member ListCachedPackages
            ([<Description("Optional search term to filter packages")>] ?searchTerm: string)
            : Task<string> =
            task {
                try
                    let result = listCachedPackages searchTerm

                    match result with
                    | Success(message, details) ->
                        return
                            match details with
                            | Some detail -> sprintf "%s\n\n%s" message detail
                            | None -> message
                    | Error errorMsg -> return errorMsg
                    | Info(message, data) -> return sprintf "%s\n%s" message data

                with ex ->
                    return sprintf "❌ Error listing cached packages: %s" ex.Message
            }

        /// Show detailed information about a specific package
        [<McpServerTool; Description("Show detailed information about a specific NuGet package in the local cache")>]
        static member ShowPackageInfo([<Description("Name of the NuGet package")>] packageName: string) : Task<string> =
            task {
                try
                    let result = showPackageInfo packageName

                    match result with
                    | Success(message, details) ->
                        return
                            match details with
                            | Some detail -> sprintf "%s\n\n%s" message detail
                            | None -> message
                    | Error errorMsg -> return errorMsg
                    | Info(message, data) -> return sprintf "%s\n%s" message data

                with ex ->
                    return sprintf "❌ Error getting package info: %s" ex.Message
            }

        /// Search generated markdown documentation
        [<McpServerTool; Description("Search through generated markdown documentation files for specific terms")>]
        static member SearchDocumentation
            (
                [<Description("Search term or identifier to find")>] searchTerm: string,
                [<Description("Documentation directory to search (optional, defaults to ./docs)")>] ?docsDir: string
            ) : Task<string> =
            task {
                try
                    let result = searchDocumentation searchTerm docsDir

                    match result with
                    | Success(message, details) ->
                        return
                            match details with
                            | Some detail -> sprintf "%s\n\n%s" message detail
                            | None -> message
                    | Error errorMsg -> return errorMsg
                    | Info(message, data) -> return sprintf "%s\n%s" message data

                with ex ->
                    return sprintf "❌ Error searching documentation: %s" ex.Message
            }

        /// Show current documentation generation configuration
        [<McpServerTool; Description("Display current configuration settings for documentation generation")>]
        static member ShowDocumentationConfig() : Task<string> =
            task {
                try
                    let result = showCurrentConfig ()

                    match result with
                    | Success(message, details) ->
                        return
                            match details with
                            | Some detail -> sprintf "%s\n\n%s" message detail
                            | None -> message
                    | Error errorMsg -> return errorMsg
                    | Info(message, data) -> return sprintf "%s\n%s" message data

                with ex ->
                    return sprintf "❌ Error getting configuration: %s" ex.Message
            }

        /// Set output directory for documentation generation
        [<McpServerTool; Description("Set the default output directory for documentation generation")>]
        static member SetDocumentationOutputDirectory
            ([<Description("Path to the output directory")>] outputDir: string)
            : Task<string> =
            task {
                try
                    setOutputDirectory outputDir
                    return sprintf "✅ Documentation output directory set to: %s" outputDir

                with ex ->
                    return sprintf "❌ Error setting output directory: %s" ex.Message
            }
