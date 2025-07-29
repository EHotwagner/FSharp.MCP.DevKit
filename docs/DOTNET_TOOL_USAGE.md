# F# MCP DevKit as a .NET Tool

This project is packaged as a .NET tool, making it easy to install and use across different platforms without needing to build from source.

## Installation

### Install from Local Source (Development)

```bash
# From the project root directory
dotnet pack src/FSharp.MCP.DevKit.Server/FSharp.MCP.DevKit.Server.fsproj
dotnet tool install --global --add-source src/FSharp.MCP.DevKit.Server/nupkg FSharp.MCP.DevKit.Server
```

### Install from NuGet (When Published)

```bash
dotnet tool install --global FSharp.MCP.DevKit.Server
```

## Usage

Once installed, you can use the tool anywhere on your system:

```bash
# Start the F# MCP server
fsharp-mcp-server
```

The tool will start the MCP server and listen for connections via stdio.

## VS Code Integration

### Simple Configuration (Recommended)

Create or update your `.vscode/mcp.json`:

```json
{
  "servers": {
    "fsharpDevKit": {
      "type": "stdio",
      "command": "fsharp-mcp-server"
    }
  }
}
```

This approach has several advantages:

1. **Platform Independent**: Works on Windows, macOS, and Linux
2. **No Build Dependencies**: Doesn't require the source code to be present
3. **Version Controlled**: Users can install specific versions
4. **Isolated**: Each user can have their own installation
5. **Reliable**: No build or path issues

### Legacy Configuration (Development Only)

For development work on the project itself, you can still use:

```json
{
  "servers": {
    "fsharpDevKit": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project", 
        "src/FSharp.MCP.DevKit.Server/FSharp.MCP.DevKit.Server.fsproj"
      ],
      "cwd": "/absolute/path/to/FSharp.MCP.DevKit"
    }
  }
}
```

## Tool Management

### Update the Tool

```bash
dotnet tool update --global FSharp.MCP.DevKit.Server
```

### Uninstall the Tool

```bash
dotnet tool uninstall --global FSharp.MCP.DevKit.Server
```

### List Installed Tools

```bash
dotnet tool list --global
```

## Publishing to NuGet

### Build and Pack

```bash
# Build the project
dotnet build src/FSharp.MCP.DevKit.Server/FSharp.MCP.DevKit.Server.fsproj --configuration Release

# Create the NuGet package
dotnet pack src/FSharp.MCP.DevKit.Server/FSharp.MCP.DevKit.Server.fsproj --configuration Release
```

### Publish to NuGet

```bash
# Publish to NuGet.org (requires API key)
dotnet nuget push src/FSharp.MCP.DevKit.Server/nupkg/FSharp.MCP.DevKit.Server.1.0.0.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json
```

## Features Available via Tool

Once installed, the `fsharp-mcp-server` command provides access to all MCP tools:

### F# Interactive Tools

- `ExecuteFSharpCode` - Execute F# code in FSI
- `EvaluateFSharpExpression` - Evaluate expressions with type info
- `GetFSIState` - Get current FSI session state
- `ResetFSISession` - Reset FSI session
- `LoadFSharpScript` - Load F# script files
- `ReferenceNuGetPackage` - Reference NuGet packages
- `ReferenceAssembly` - Reference .NET assemblies

### Code Editing Tools

- `InsertCode` - Safe code insertion with validation and formatting
- `PreviewCodeInjection` - Preview code changes before applying
- `FormatFile` - Format F# files using Fantomas
- `ParseAndCheckFSharpCode` - Parse and validate F# code
- `SearchInFile` - Search for patterns in files
- `ReplaceTextRange` - Replace text in specific line ranges

### Documentation Tools

- `GeneratePackageDocumentation` - Generate API docs for NuGet packages
- `GenerateProjectDocumentation` - Generate docs for F# projects
- `SearchDocumentation` - Search generated documentation
- `ListCachedPackages` - List available packages for documentation
- `ResearchLibrary` - Generate library overviews with online research

## Benefits of .NET Tool Approach

1. **Cross-Platform**: Works identically on Windows, macOS, and Linux
2. **Easy Distribution**: Share via NuGet, no source code needed
3. **Version Management**: Users can pin to specific versions
4. **No Build Requirements**: No need for .NET SDK on target machines
5. **Clean Installation**: Simple install/uninstall process
6. **Global Availability**: Use from any directory
7. **Update Mechanism**: Easy updates via `dotnet tool update`

## MCP Registry Integration

When published to NuGet, this tool can be easily discovered and used by:

- VS Code with GitHub Copilot agent mode
- Claude Desktop
- Other MCP-compatible applications
- AI development environments

The standardized tool approach makes it much easier for users to integrate F# development capabilities into their AI workflows without dealing with platform-specific build issues.
