# FSharp.MCP.DevKit.CodeEditing

The `FSharp.MCP.DevKit.CodeEditing` module provides comprehensive F# Interactive (FSI) integration and code manipulation tools through the Model Context Protocol (MCP). This module serves as the bridge between AI assistants and F# development workflows.

## Overview

This module consolidates all F# Interactive operations, code analysis, and system management tools into a unified MCP server implementation. It provides safe, validated, and efficient F# development capabilities through structured tool categories.

## Architecture

The module is organized into several key components:

### Core Service Layer
- **`FsiMcpService`** - Central service managing FSI pipe server and client connections
- **Helper Functions** - Diagnostic formatting and file validation utilities

### Tool Categories
- **`FSharpREPLTools`** - F# Interactive session management and code execution
- **`FSharpEnvironmentTools`** - Package and environment management
- **`FSharpAnalysisTools`** - Code analysis and validation
- **`SystemManagementTools`** - Process and server management

## Key Features

### 🔧 FSI Service Management
- **Persistent Sessions**: Stateful F# Interactive session management
- **Automatic Initialization**: Common namespaces pre-loaded (`System`, `System.IO`, `System.Collections.Generic`)
- **Pipe Communication**: High-performance named pipe IPC
- **Timeout Configuration**: Configurable operation timeouts (default: 30 seconds)
- **Resource Management**: Proper disposal and cleanup of resources

### 🚀 REPL and Interactive Development
- **Code Execution**: Execute arbitrary F# code with comprehensive error handling
- **Expression Evaluation**: Evaluate F# expressions with full type information
- **Session State**: Get current bindings and session state
- **Session Reset**: Clear all state while maintaining the session
- **Server Status**: Check FSI server availability and health

### 📦 Environment and Package Management
- **Script Loading**: Load F# script files with dependency tracking
- **Assembly References**: Add .NET assembly references dynamically
- **NuGet Packages**: Reference NuGet packages with version support
- **Search Paths**: Manage F# compiler search paths

### 🔍 Code Analysis and Validation
- **Syntax Validation**: Parse and validate F# code for errors
- **File Analysis**: Comprehensive F# file structure analysis
- **Diagnostic Reporting**: Detailed error and warning information
- **Performance Metrics**: Line counts, character counts, and analysis summaries

### ⚙️ System Management
- **Process Management**: Terminate MCP server processes
- **Clean Shutdown**: Graceful service termination
- **Resource Cleanup**: Automatic disposal of system resources

## MCP Tools Reference

### FSharpREPLTools

| Tool | Description | Parameters |
|------|-------------|------------|
| `fsi-execute` | Execute F# code in FSI session | `code: string`, `timeoutSeconds: int?` |
| `fsi-evaluate` | Evaluate F# expression with type info | `expression: string`, `timeoutSeconds: int?` |
| `fsi-get-state` | Get current FSI session bindings | `timeoutSeconds: int?` |
| `fsi-reset` | Reset FSI session, clearing all state | `timeoutSeconds: int?` |
| `fsi-status` | Check FSI server availability | None |

### FSharpEnvironmentTools

| Tool | Description | Parameters |
|------|-------------|------------|
| `fsi-load-script` | Load F# script into FSI session | `filePath: string`, `timeoutSeconds: int?` |
| `fsi-reference-assembly` | Add .NET assembly reference | `assemblyPath: string`, `timeoutSeconds: int?` |
| `fsi-reference-nuget` | Add NuGet package reference | `packageName: string`, `timeoutSeconds: int?` |
| `fsi-add-path` | Add directory to F# search path | `path: string`, `timeoutSeconds: int?` |

### FSharpAnalysisTools

| Tool | Description | Parameters |
|------|-------------|------------|
| `code-validate` | Parse and validate F# code | `code: string`, `timeoutSeconds: int?` |
| `file-analyze` | Analyze F# file structure | `filePath: string` |

### SystemManagementTools

| Tool | Description | Parameters |
|------|-------------|------------|
| `server-kill-all` | Terminate all MCP server processes | None |

## Usage Examples

### Basic Code Execution
```fsharp
// Execute simple F# code
fsi-execute "let x = 1 + 2; printfn \"Result: %d\" x"

// Evaluate expressions
fsi-evaluate "List.map ((*) 2) [1..5]"
```

### Package Management
```fsharp
// Reference a NuGet package
fsi-reference-nuget "FSharp.Data"

// Reference an assembly
fsi-reference-assembly "System.Data.dll"

// Load a script file
fsi-load-script "MyUtilities.fsx"
```

### Code Analysis
```fsharp
// Validate F# code syntax
code-validate "let add x y = x + y"

// Analyze a complete file
file-analyze "MyModule.fs"
```

## Error Handling

The module provides comprehensive error handling with:

### Diagnostic Integration
- **Structured Diagnostics**: Full compiler diagnostic information
- **Error Categorization**: Errors vs. warnings with line numbers
- **Context Preservation**: Original error messages with enhanced formatting

### Timeout Management
- **Configurable Timeouts**: Per-operation timeout configuration
- **Default Values**: Sensible 30-second default timeouts
- **Graceful Degradation**: Clean timeout handling without resource leaks

### Resource Safety
- **Automatic Cleanup**: Proper disposal of FSI services and pipe connections
- **Exception Handling**: Comprehensive try-catch with logging
- **State Consistency**: Consistent state management across operations

## File Type Support

The module validates and supports the following F# file types:
- **`.fsx`** - F# Script files
- **`.fs`** - F# Source files  
- **`.fsi`** - F# Signature files

## Configuration

### Default Settings
- **Timeout**: 30 seconds for all operations
- **Pipe Name**: Configured via `PipeConfig.defaultConfig`
- **FSI Config**: Uses `FsiConfig.defaultConfig`

### Logging Integration
- Full Microsoft.Extensions.Logging integration
- Structured logging with context information
- Error tracking and performance monitoring

## Integration Points

### Dependencies
- **FSharp.MCP.DevKit.Core** - FSI services and configurations
- **FSharp.MCP.DevKit.Communication.IPC** - Named pipe communication
- **FSharp.MCP.DevKit.Analysis** - Code analysis capabilities
- **ModelContextProtocol.Server** - MCP server framework
- **Fantomas.Core** - Code formatting (imported but not actively used in current implementation)

### External Integration
- **F# Compiler Services** - Via core FSI service layer
- **Named Pipes** - High-performance IPC communication
- **.NET Process Management** - System process control

## Best Practices

### For AI Assistants
1. **Always check FSI status** before executing complex operations
2. **Use timeouts appropriately** for long-running operations
3. **Validate code syntax** before execution when possible
4. **Monitor diagnostics** for code quality feedback
5. **Clean up resources** using the kill-all tool when needed

### For Developers
1. **Leverage the consolidated API** instead of direct FSI access
2. **Use structured error handling** with diagnostic information
3. **Configure appropriate timeouts** for your use case
4. **Monitor logging output** for performance and debugging
5. **Test with file validation** before processing F# files

## Future Enhancements

Potential areas for future development:
- **Fantomas Integration**: Active code formatting capabilities
- **Advanced Diagnostics**: Enhanced error reporting and suggestions
- **Performance Monitoring**: Built-in performance metrics and profiling
- **Session Persistence**: Save and restore FSI session state
- **Multi-target Support**: Support for different F# versions and frameworks
