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

    // Configure MCP server
    builder.Services.AddMcpServer().WithStdioServerTransport().WithToolsFromAssembly()
    |> ignore

    let host = builder.Build()

    // Run the host
    host.RunAsync().GetAwaiter().GetResult()
    0
