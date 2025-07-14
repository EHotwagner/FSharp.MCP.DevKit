# CodeLens Integration for FSharp.MCP.DevKit

## Overview

The CodeLens integration wraps FsAutoComplete's CodeLens functionality into MCP tools, providing inline code information such as references, implementations, and other contextual data directly through the Model Context Protocol.

## Features

### Core CodeLens Capabilities

- **Reference Counting**: Shows how many times functions, types, and members are referenced
- **Implementation Discovery**: Displays implementations for interfaces and abstract members  
- **Navigation Commands**: Provides commands for jumping to definitions and references
- **Type Information**: Shows additional type and usage information inline with code

### MCP Tools Available

#### 1. `GetCodeLens`

Gets basic CodeLens information for an F# file.

**Parameters:**

- `filePath` (string): Path to the F# file (.fs or .fsx)
- `timeoutSeconds` (optional int): Timeout in seconds (default: 30)

**Returns:** Summary of CodeLens items found in the file with their positions and basic command information.

**Example:**

```
mcp call GetCodeLens --filePath "src/MyFile.fs"
```

#### 2. `GetDetailedCodeLens`  

Gets comprehensive CodeLens information with all commands resolved.

**Parameters:**

- `filePath` (string): Path to the F# file (.fs or .fsx)
- `timeoutSeconds` (optional int): Timeout in seconds (default: 30)

**Returns:** Detailed summary with resolved commands, argument counts, and full command information.

**Example:**

```
mcp call GetDetailedCodeLens --filePath "src/MyFile.fs"
```

#### 3. `ResolveCodeLens`

Resolves a specific CodeLens item to get its complete command details.

**Parameters:**

- `filePath` (string): Path to the F# file (.fs or .fsx)
- `codeLensIndex` (int): Zero-based index of the CodeLens item to resolve
- `timeoutSeconds` (optional int): Timeout in seconds (default: 30)

**Returns:** Detailed information about the specific CodeLens command, including title, command name, and arguments.

**Example:**

```
mcp call ResolveCodeLens --filePath "src/MyFile.fs" --codeLensIndex 0
```

## Technical Implementation

### LSP Integration

The CodeLens functionality integrates with FsAutoComplete through the Language Server Protocol:

- **Request**: `textDocument/codeLens` - Gets CodeLens items for a document
- **Resolve**: `codeLens/resolve` - Resolves CodeLens commands with full details

### Data Flow

1. **Document Opening**: File is opened in FsAutoComplete to establish context
2. **CodeLens Request**: LSP request sent to get CodeLens items
3. **Command Resolution**: Individual CodeLens items resolved to get command details
4. **Response Formatting**: Results formatted for MCP tool consumption

### Types and Structures

#### CodeLens Type

```fsharp
type CodeLens =
    { Range: Range
      Command: Command option  
      Data: obj option }
```

#### Command Type

```fsharp
type Command =
    { Title: string
      Command: string
      Arguments: obj[] option }
```

## Usage Examples

### Basic Reference Counting

For a function like:

```fsharp
let addNumbers x y = x + y
```

CodeLens might show: `"2 references"` if the function is used twice in the codebase.

### Interface Implementation

For an interface:

```fsharp
type IProcessor =
    abstract Process: string -> string
```

CodeLens might show: `"1 implementation"` with a command to navigate to the implementing type.

### Type Usage

For a type definition:

```fsharp
type Calculator = { Name: string; Version: string }
```

CodeLens might show: `"3 references"` with commands to navigate to usage locations.

## Error Handling

The CodeLens tools handle various error scenarios:

- **File Not Found**: Returns appropriate error message
- **FsAutoComplete Not Ready**: Prompts to start the language server
- **No CodeLens Available**: Indicates when no CodeLens items are found
- **Resolution Failures**: Reports when specific CodeLens items cannot be resolved
- **Invalid Indices**: Validates CodeLens index parameters

## Performance Considerations

- **Caching**: FsAutoComplete caches analysis results for better performance
- **Lazy Loading**: CodeLens items are loaded on demand
- **Timeout Handling**: Configurable timeouts prevent hanging operations
- **Async Operations**: All operations are asynchronous to avoid blocking

## Integration with Development Workflow

### With VS Code

CodeLens information complements VS Code's built-in CodeLens display, providing programmatic access to the same data.

### With CI/CD

CodeLens can be used in automated workflows to:

- Analyze code complexity based on reference counts
- Verify interface implementations
- Generate usage reports

### With Documentation Tools

CodeLens data can inform documentation generation by identifying:

- Heavily used APIs that need better documentation
- Unused code that might be deprecated
- Implementation patterns across the codebase

## Troubleshooting

### Common Issues

1. **No CodeLens Found**
   - Ensure file is part of a valid F# project
   - Verify FsAutoComplete has loaded the project context
   - Check that the file compiles without errors

2. **Resolution Timeouts**
   - Increase timeout parameter for complex projects
   - Ensure FsAutoComplete is fully initialized
   - Check system performance and memory availability

3. **Invalid Commands**
   - Some CodeLens items may not have associated commands
   - Verify FsAutoComplete version compatibility
   - Check for project configuration issues

### Debugging

Enable detailed logging in FsAutoComplete to see:

- CodeLens request/response flow
- Resolution attempts and failures
- Performance metrics

## Future Enhancements

Potential improvements to the CodeLens integration:

- **Filtering**: Filter CodeLens by type (references, implementations, etc.)
- **Sorting**: Sort results by relevance or frequency
- **Caching**: Cache resolved CodeLens for better performance
- **Batch Operations**: Resolve multiple CodeLens items in parallel
- **Custom Commands**: Support for custom CodeLens command definitions
