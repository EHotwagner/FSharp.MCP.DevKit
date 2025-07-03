# FSharp.MCP.DevKit.Server

`FSharp.MCP.DevKit.Server` is the application host and primary entry point for the FSharp.MCP.DevKit solution. This project implements a comprehensive Model Context Protocol (MCP) server that exposes 25+ specialized tools for F# Interactive session management, code analysis, documentation generation, and advanced scripting capabilities.

## Overview

The Server project provides:
- MCP protocol implementation
- Server lifecycle management
- Tool registration and execution
- Client communication handling
- Error handling and logging

## Architecture

The Server project implements a modern .NET hosting architecture with:
- **MCP Protocol Compliance**: Full implementation of Model Context Protocol specification
- **Tool-Based Architecture**: Extensive collection of specialized F# scripting tools
- **Dependency Injection**: Enterprise-grade service container configuration
- **Stdio Transport**: Standard input/output communication for MCP clients
- **Comprehensive Logging**: Structured logging with configurable levels
- **Graceful Shutdown**: Proper resource cleanup and session management

```mermaid
graph TB
    subgraph "FSharp.MCP.DevKit.Server Architecture"
        Program["`**Program.fs**<br/>Application Entry Point<br/>• Host Configuration<br/>• Service Registration<br/>• MCP Server Setup`"]
        McpTools["`**McpFsiTools.fs**<br/>MCP Tool Implementation<br/>• 25+ F# Development Tools<br/>• Tool Registration<br/>• Request/Response Handling`"]
        Config["`**appsettings.json**<br/>Configuration Management<br/>• Environment Settings<br/>• Tool-specific Options<br/>• Logging Configuration`"]
    end
    
    subgraph "MCP Protocol Layer"
        MCPServer["`**MCP Server**<br/>Protocol Implementation<br/>• Stdio Transport<br/>• Tool Discovery<br/>• Request Routing`"]
        Transport["`**Stdio Transport**<br/>Communication Layer<br/>• Standard I/O Handling<br/>• JSON-RPC Protocol<br/>• Error Handling`"]
    end
    
    subgraph "Core Services Integration"
        FsiService["`**FsiMcpService**<br/>FSI Integration<br/>• Session Management<br/>• Code Execution<br/>• Pipe Communication`"]
        Analysis["`**Analysis Services**<br/>Code Intelligence<br/>• Symbol Detection<br/>• Syntax Validation<br/>• Structure Analysis`"]
        CodeEditing["`**Code Editing**<br/>File Manipulation<br/>• Safe Code Insertion<br/>• Format Integration<br/>• Atomic Operations`"]
        Communication["`**Communication**<br/>IPC Infrastructure<br/>• Named Pipes<br/>• Concurrent Processing<br/>• Error Recovery`"]
    end
    
    subgraph "AI Assistant Integration"
        Client["`**AI Assistant**<br/>(Claude, GPT, etc.)<br/>• Tool Discovery<br/>• Request Generation<br/>• Response Processing`"]
    end
    
    Program --> McpTools
    Program --> Config
    McpTools --> MCPServer
    MCPServer --> Transport
    
    McpTools --> FsiService
    McpTools --> Analysis
    McpTools --> CodeEditing
    McpTools --> Communication
    
    Transport <--> Client
```

## Related Projects

- [Core](../Core/) - F# Interactive core services
- [Communication](../Communication/) - IPC and communication protocols
- [CodeEditing](../CodeEditing/) - Code manipulation tools
- [Analysis](../Analysis/) - Code analysis capabilities
- [Documentation](../Documentation/) - Documentation generation
