# MCP Tools Organization

This folder contains all MCP (Model Context Protocol) tools organized by category for better maintainability and discoverability.

## Folder Structure

### 📁 Core/

F# Interactive and core development tools

- **McpFsiTools.fs** - F# Interactive execution, code management, and REPL operations

### 📁 Documentation/

Documentation generation and management tools  

- **McpDocumentationTools.fs** - NuGet package documentation generation and search

### 📁 LanguageServer/

Language Server Protocol integration tools

- **McpFsAutoCompleteTools.fs** - FsAutoComplete LSP integration for real-time diagnostics

### 📁 CodeAnalysis/

*Future: Code analysis and static analysis tools*

### 📁 Utilities/

*Future: General utility and helper tools*

## Adding New Tools

When adding new MCP tools:

1. **Choose the appropriate folder** based on the tool's primary purpose
2. **Follow the naming convention**: `Mcp[Category]Tools.fs`
3. **Update the project file** to include the new file in the correct order
4. **Register the tool** in `Program.fs` if it requires dependency injection
5. **Update this README** to document the new tool

## Tool Structure

Each tool file should follow this pattern:

```fsharp
namespace FSharp.MCP.DevKit.Server

open System.ComponentModel
open ModelContextProtocol.Server

[<McpServerToolType>]
type YourToolsClass() =
    
    [<McpServerTool; Description("Tool description")>]
    member this.YourTool(parameter: string) =
        // Implementation
        "Result"
```

## Integration

All tools are automatically discovered and registered via the MCP server's `WithToolsFromAssembly()` method in `Program.fs`. The organized folder structure makes it easy to:

- **Find tools** by category
- **Maintain related functionality** together  
- **Scale the project** as more tools are added
- **Debug and test** specific tool categories

## Benefits

✅ **Better Organization** - Tools grouped by purpose  
✅ **Easier Maintenance** - Related code stays together  
✅ **Improved Discoverability** - Clear folder structure  
✅ **Scalable Architecture** - Easy to add new categories  
✅ **Development Efficiency** - Faster navigation and understanding
