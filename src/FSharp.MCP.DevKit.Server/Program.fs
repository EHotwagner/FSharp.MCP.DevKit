module FSharp.MCP.DevKit.Server.Program

open System
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open ModelContextProtocol.Server
open FSharp.MCP.DevKit.Server.McpFsiTools

[<EntryPoint>]
let main argv =
    let builder = Host.CreateApplicationBuilder(argv)

    // Configure logging to stderr (required for MCP)
    builder.Logging.AddConsole(fun consoleLogOptions -> consoleLogOptions.LogToStandardErrorThreshold <- LogLevel.Trace)
    |> ignore

    // Register FSI service
    builder.Services.AddSingleton<FsiMcpService>() |> ignore

    // Register FsAutoComplete service
    builder.Services.AddSingleton<FsAutoCompleteService>() |> ignore

    // Register FsAutoComplete tools with dependency injection
    builder.Services.AddSingleton<FsAutoCompleteTools>() |> ignore

    // Configure MCP server with all tools
    builder.Services.AddMcpServer().WithStdioServerTransport().WithToolsFromAssembly()
    |> ignore

    let host = builder.Build()

    // Run the host
    host.RunAsync().GetAwaiter().GetResult()
    0
