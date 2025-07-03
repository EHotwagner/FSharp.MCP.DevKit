namespace FSharp.MCP.DevKit.Communication

open System
open System.Threading
open FSharp.MCP.DevKit.Core
open FSharp.MCP.DevKit.Communication.IPC

/// Main server application that hosts FSI with named pipe IPC
module PermanentReplServer =

    /// Start the permanent FSI REPL server with named pipes
    let startServer (pipeName: string option) =
        printfn "=== Starting Permanent FSI REPL Server with Named Pipes ==="

        let config =
            match pipeName with
            | Some name ->
                { PipeConfig.defaultConfig with
                    PipeName = name }
            | None -> PipeConfig.defaultConfig

        printfn $"Pipe name: {config.PipeName}"
        printfn $"Max connections: {config.MaxConnections}"
        printfn $"Process ID: {System.Diagnostics.Process.GetCurrentProcess().Id}"

        // Create FSI service
        let fsi = FsiHelpers.createDefault ()
        fsi.Start()


        printfn "✅ FSI session started successfully!"


        // Initialize with some basic setup
        fsi.ExecuteInteraction("open System") |> ignore
        fsi.ExecuteInteraction("open System.IO") |> ignore

        fsi.ExecuteInteraction(
            "printfn \"=== FSI REPL Ready for Named Pipe Commands ===\\nProcess ID: %d\" (System.Diagnostics.Process.GetCurrentProcess().Id)"
        )
        |> ignore

        // Create and start pipe server
        use pipeServer = new PipeServer(config, fsi)
        pipeServer.Start()

        printfn "🔗 Named pipe server started successfully!"
        printfn $"   Pipe name: {config.PipeName}"
        printfn $"   Listening for connections..."

        // Set up graceful shutdown
        let mutable shouldExit = false

        Console.CancelKeyPress.Add(fun args ->
            args.Cancel <- true
            printfn "\n🛑 Shutdown signal received..."
            shouldExit <- true)

        // Keep alive loop
        printfn "\nPress Ctrl+C to stop the server."
        printfn "Use the client library or tools to send commands via named pipe.\n"

        let rec keepAlive () =
            if not shouldExit && fsi.IsRunning && pipeServer.IsRunning then
                Thread.Sleep(1000)
                keepAlive ()
            else
                printfn "🛑 Stopping server..."
                pipeServer.Stop()
                fsi.Stop()
                printfn "✅ Server stopped. Goodbye!"

        keepAlive ()
