# Quick Start: Installing F# MCP DevKit as a .NET Tool

## Overview

Yes, this project **should** be distributed as a .NET tool! The current `mcp.json` configuration using `dotnet run --project` is fragile and platform-dependent. I've just configured the project to be packaged as a proper .NET tool.

## What Changed

### 1. Enhanced Project Configuration

The `FSharp.MCP.DevKit.Server.fsproj` now includes:

- Complete NuGet package metadata
- Proper .NET tool configuration
- Version information and licensing

### 2. Simplified `mcp.json` Configuration

**Old (Fragile):**

```json
{
  "servers": {
    "fsharpDevKit": {
      "type": "stdio",
      "command": "dotnet",
      "args": ["run", "--project", "src/FSharp.MCP.DevKit.Server/FSharp.MCP.DevKit.Server.fsproj"],
      "cwd": "c:\\Users\\ehotw\\Documents\\GitHub\\FSharp.MCP.DevKit"
    }
  }
}
```

**New (Robust):**

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

## Installation Instructions

### Step 1: Build and Install Locally (For Testing)

```bash
# From the project root
dotnet pack src/FSharp.MCP.DevKit.Server/FSharp.MCP.DevKit.Server.fsproj --configuration Release

# Install the tool globally
dotnet tool install --global --add-source src/FSharp.MCP.DevKit.Server/nupkg FSharp.MCP.DevKit.Server
```

### Step 2: Test the Tool

```bash
# The tool should now be available globally
fsharp-mcp-server --help

# Or just run it (it will start the MCP server)
fsharp-mcp-server
```

### Step 3: Update VS Code Configuration

Your `.vscode/mcp.json` is now simplified and will work from any directory:

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

## Benefits of This Approach

### ✅ Platform Independence

- Works identically on Windows, macOS, and Linux
- No hardcoded paths or platform-specific commands

### ✅ Easy Distribution

- Share via NuGet package
- Users don't need source code
- Simple install command

### ✅ Version Management

- Users can install specific versions
- Easy updates via `dotnet tool update`

### ✅ No Build Dependencies

- Users don't need .NET SDK for development
- Just the runtime is sufficient

### ✅ Clean Separation

- Development vs. usage are separate concerns
- No build system complexity for end users

## Publishing to NuGet (Future)

When ready to make this publicly available:

```bash
# Publish to NuGet.org
dotnet nuget push src/FSharp.MCP.DevKit.Server/nupkg/FSharp.MCP.DevKit.Server.1.0.0.nupkg \
  --api-key YOUR_API_KEY \
  --source https://api.nuget.org/v3/index.json
```

Then users can install with just:

```bash
dotnet tool install --global FSharp.MCP.DevKit.Server
```

## Tool Management Commands

```bash
# List installed tools
dotnet tool list --global

# Update the tool
dotnet tool update --global FSharp.MCP.DevKit.Server

# Uninstall the tool  
dotnet tool uninstall --global FSharp.MCP.DevKit.Server
```

## Current Status

✅ Project is now configured as a .NET tool  
✅ NuGet package builds successfully  
✅ `mcp.json` simplified for robustness  
📝 Ready for local testing and eventual NuGet publication

The package `FSharp.MCP.DevKit.Server.1.0.0.nupkg` was successfully created and is ready for installation and testing!
