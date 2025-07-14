# FSharp.MCP.DevKit 🚀

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=flat-square)](https://dotnet.microsoft.com/)
[![F#](https://img.shields.io/badge/F%23-6.0-378BBA?style=flat-square)](https://fsharp.org/)
[![MCP](https://img.shields.io/badge/MCP-Compatible-00AA88?style=flat-square)](https://modelcontextprotocol.io/)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)

An experimental prototype of an F# development toolkit delivered via the **Model Context Protocol (MCP)**. It provides F# Interactive (FSI) capabilities, code documentation, safe code manipulation, and analysis tools with language server features. Integration with the FAKE build system is under development.

## ⚠️ Disclaimer (by EHotwagner)

This project has been developed with significant reliance on AI-driven tools. While it has proven to be surprisingly effective—largely by leveraging robust libraries like **F# Compiler Services** and **Fantomas**—it will contain inaccuracies or incomplete features. Especially regarding Documentation, the agent tends to insert tons of industry buzzword BS whenever you look away for a second.

### Please Note

- **Code Verification**: The entire codebase and its documentation have not been manually verified for correctness or completeness. However, the core features described should be functional (as in I have seen them work at least once).
- **Agent Stability**: The AI agent's instructions are generally initially effective, but after it deviates, restarting the agent to reset its context is recommended.
- **DevEnvironment**: This project has been developed in VSCode with GH Copilot, mostly using Claude Sonnet 4 and a bit of Gemini 2.5 Pro for planning and design. <https://austen.info/blog/github-copilot-agent-mcp/>
- **Design**: Documentation is written somewhat with REPL-driven development in mind, allowing for interactive code generation and testing. I am currently tending towards a more script-driven development approach, which allows for structured experimentation and reproducible testing. A new, more rigorous approach, **Signature-Driven Development**, is also being considered.
  - [REPL-Driven Development](./docs/Agent-Instructions-Strategies/REPL-Driven-Default/Design.md)
  - [Script-Driven Development](./docs/Agent-Instructions-Strategies/Script-Driven-Default/Design.md)
  - [Signature-Driven Development](./docs/Agent-Instructions-Strategies/Signature-Driven-Default/Design.md)

- REPL works with hosted FSI sessions, which in this context are not easy to configure, a bit fragile with some Input, have no nice output (only MCP-Tools output terminal and agent chat window). Letting the agent start a standard fsi process in an agent observed terminal is of course possible but cumbersome in VSCode since terminal actions need approval. This project should be neutral to the chosen approach in the future. VsCode Insiders has <https://github.com/microsoft/vscode/issues/253103> which changes the ergonomics a lot. Needs consideration.
- **Get Started**: There are no releases yet. For VSCode use this <https://devblogs.microsoft.com/dotnet/build-a-model-context-protocol-mcp-server-in-csharp/> approach. Add the project to the mcp.json file. Later a dotnet tool might be the best way to distribute this project.
- **Contributions Welcome**: This project is open to contributions.
- **Status**: Need to do lots of research next. These are tools for AI agents not humans. The complete agent system is something like: model + context + tools. I need to know more about Context management and what tools might work with what context. Improving prototyped tools might not be that useful, maybe less is more, who knows. How to best integrate fake and dotnet tool support is very important in my opinion since it gives the agent controlled and structured ways to iterate.

## ✨ Features

### 🔧 [F# Interactive Integration](docs/projects/Core/)

- **Projects**: [`FSharp.MCP.DevKit.Core`](./src/FSharp.MCP.DevKit.Core/), [`FSharp.MCP.DevKit.Communication`](./src/FSharp.MCP.DevKit.Communication/)
- **💾 Persistent FSI Session**: Stateful F# Interactive session management with cross-session state preservation
  - *Powered by*: `FSIService` + `PermanentReplServer` - Maintains long-running FSI processes via named pipes with session isolation
  - *How it works*: Spawns dedicated FSI processes, manages state through IPC communication, preserves bindings across tool calls
  - *MCP Tools*: `CheckFSIServerStatus`, `ResetFSISession`, `RestartFSISession`, `GetFSIState`

- **⚡ Code Execution**: Execute F# code with comprehensive error handling and validation
  - *Powered by*: `ExecuteFSharpCode` + `ExecuteFSharpCodeDetailed` - Robust code execution with detailed diagnostics
  - *How it works*: Submits code to FSI via IPC, captures stdout/stderr, parses compiler errors with line-level precision
  - *MCP Tools*: `ExecuteFSharpCode`, `ExecuteFSharpCodeDetailed`, `EvaluateFSharpExpression`

- **📁 Script Loading**: Load and manage F# script files with dependency tracking
  - *Powered by*: `LoadFSharpScript` - Smart script loading with automatic dependency resolution
  - *How it works*: Parses #load directives, resolves relative paths, maintains load order, handles circular dependencies
  - *MCP Tools*: `LoadFSharpScript`, `AddSearchPath`

- **📦 Package Management**: Reference .NET assemblies and NuGet packages seamlessly
  - *Powered by*: `ReferenceAssembly` + `ReferenceNuGetPackage` - Dynamic assembly and package loading
  - *How it works*: Uses #r directives for assemblies, NuGet package resolution via FSI's built-in package manager
  - *MCP Tools*: `ReferenceAssembly`, `ReferenceNuGetPackage`

### 📚 [Documentation Generation & Search](docs/projects/Documentation/)

- **Projects**: [`FSharp.MCP.DevKit.Documentation`](./src/FSharp.MCP.DevKit.Documentation/), [`FSharp.MCP.DevKit.Documentation.Tool`](./src/FSharp.MCP.DevKit.Documentation.Tool/)
- **📦 Package Documentation**: Generate comprehensive API docs for NuGet packages with cross-reference linking
  - *Powered by*: `GeneratePackageDocumentation` - Deep .NET assembly analysis with reflection-based documentation extraction
  - *How it works*: Loads assemblies via reflection, extracts XML documentation comments, generates structured markdown with type hierarchies
  - *MCP Tools*: `GeneratePackageDocumentation`, `ShowPackageInfo`

- **🔍 Smart Search**: Search through generated documentation with context-aware results and fuzzy matching
  - *Powered by*: `SearchDocumentation` - Full-text search across generated markdown with relevance scoring
  - *How it works*: Indexes markdown content, performs case-insensitive substring matching, ranks results by context relevance
  - *MCP Tools*: `SearchDocumentation`

- **📖 API Reference**: Create structured markdown documentation for modules and types with navigation
  - *Powered by*: Documentation generation engine - Converts .NET metadata to human-readable markdown format
  - *How it works*: Parses assembly metadata, extracts type information, generates cross-linked documentation trees
  - *Output format*: Hierarchical markdown files with consistent structure and cross-references

- **🏗️ Project Documentation**: Bulk documentation generation for entire F# projects with dependency analysis
  - *Powered by*: `GenerateProjectDocumentation` - Project-wide documentation with package dependency resolution
  - *How it works*: Parses .fsproj files, resolves all package references, generates comprehensive documentation sets
  - *MCP Tools*: `GenerateProjectDocumentation`

- **💾 Package Discovery**: Browse and explore available NuGet packages in local cache with metadata
  - *Powered by*: `ListCachedPackages` - Local NuGet cache exploration with search filtering
  - *How it works*: Scans local NuGet cache directories, extracts package metadata, provides searchable package listings
  - *MCP Tools*: `ListCachedPackages`, `SetDocumentationOutputDirectory`, `ShowDocumentationConfig`

### ✏️ [Safe Code Manipulation](docs/projects/CodeEditing/)

- **Project**: [`FSharp.MCP.DevKit.CodeEditing`](./src/FSharp.MCP.DevKit.CodeEditing/)
- **🛡️ Safe Code Insertion**: Insert F# code with AST validation and type checking to prevent syntax corruption
  - *Powered by*: `InsertCode` - Multi-phase insertion with pre-validation, formatting, and post-validation
  - *How it works*: Parses existing code to AST, validates insertion context, performs syntax-aware insertion, validates final result
  - *MCP Tools*: `InsertCode`, `PreviewCodeInjection`

- **🎨 Code Formatting**: Deep integration with Fantomas for consistent code formatting with configurable style
  - *Powered by*: `FormatFile` - Fantomas-based formatting with F# community style standards
  - *How it works*: Applies Fantomas formatting rules, preserves semantic meaning, maintains consistent indentation and spacing
  - *MCP Tools*: `FormatFile`

- **🔍 Structure Analysis**: Analyze F# code structure, dependencies, and syntax with detailed diagnostics
  - *Powered by*: `AnalyzeCodeStructure` + `ParseSourceToAST` - Multi-level code analysis from syntax to semantics
  - *How it works*: Parses code to AST, performs structural analysis, identifies patterns and potential issues
  - *MCP Tools*: `AnalyzeCodeStructure`, `ParseSourceToAST`

- **👀 Preview Capabilities**: Preview code changes before applying them with diff-style output
  - *Powered by*: `PreviewCodeInjection` - Non-destructive change preview with context visualization
  - *How it works*: Simulates code insertion, generates preview output showing before/after state without file modification
  - *MCP Tools*: `PreviewCodeInjection`

- **⚡ Atomic Operations**: Atomic file operations with backup/rollback support for safe editing
  - *Powered by*: Atomic file writing system - Ensures consistency during file modifications
  - *How it works*: Creates temporary files, performs operations atomically, provides rollback on failure
  - *Features*: Transaction-like semantics, automatic backup creation, error recovery

### 🧠 [Advanced Analysis Tools](docs/projects/Analysis/)

- **Project**: [`FSharp.MCP.DevKit.Analysis`](./src/FSharp.MCP.DevKit.Analysis/)
- **🔍 Symbol Detection**: Advanced symbol detection and resolution
  - *Powered by*: `SmartSymbolDetectionService` - Uses F# Compiler Services to identify and resolve symbols, functions, types, and modules within F# code
  - *How it works*: Parses source code into AST, performs semantic analysis to resolve symbol bindings, their scope, and provides position-sensitive symbol lookup
  - *MCP Tools*: `GetAllSymbols`, `GetSymbolAtPosition`, `WhatIsAtPosition`, `GetSymbolSignatureAtPosition`

- **📊 Syntax Validation**: Comprehensive F# syntax analysis and error reporting
  - *Powered by*: `ParseAndCheckFSharpCode` - Validates F# syntax and performs type checking with detailed diagnostics
  - *How it works*: Uses F# Compiler Services via IPC to parse source code, check for syntax errors, type mismatches, and compiler warnings with line-level error locations

- **🗂️ Dependency Analysis**: Track and analyze code dependencies and relationships
  - *Powered by*: `AnalyzeCodeStructure` - Provides basic file analysis including line count, character count, and diagnostic summaries
  - *How it works*: Performs F# Compiler Services parsing to identify errors, warnings, and structural issues in F# files
  - *Current scope*: File-level analysis rather than deep dependency graph analysis

- **🎯 Position-Sensitive Analysis**: Context-aware code analysis based on cursor position
  - *Powered by*: `InsertCode` validation + `PreviewCodeInjection` - Provides contextual analysis for safe code insertion
  - *How it works*: Analyzes insertion context to prevent breaking multi-line constructs (type definitions, unions, records) and validates combined code after insertion

### 🔧 [F# Language Server Integration](docs/projects/FsAutoComplete/)

- **Project**: [`FSharp.MCP.DevKit.FsAutoComplete`](./src/FSharp.MCP.DevKit.FsAutoComplete/)
- **✅ Implementation Status**: All MCP tools now implemented with real FsAutoComplete integration (requires fsautocomplete binary)
- **📡 Real-time Diagnostics**: Live F# compiler diagnostics and error detection with LSP integration
  - *Powered by*: `FsAutoCompleteWrapper` - Direct integration with FsAutoComplete language server for real-time code intelligence
  - *How it works*: Manages FsAutoComplete process lifecycle, handles LSP communication, provides live diagnostic feedback with position-accurate error reporting
  - *MCP Tools*: `CheckFile`, `GetDiagnostics`, `StartFsAutoComplete`, `StopFsAutoComplete`

- **💡 Code Intelligence**: Rich hover information, type signatures, and symbol definitions
  - *Powered by*: `McpFsAutoCompleteTools` - Comprehensive code intelligence through Language Server Protocol
  - *How it works*: Leverages FsAutoComplete's semantic analysis for hover documentation, go-to-definition, and type signature resolution
  - *MCP Tools*: `GetDocumentation`, `GetSignature`, `GetStatus`

- **🏗️ Workspace Management**: Project loading, file watching, and workspace-aware analysis
  - *Powered by*: `WorkspaceManagement` - Full F# project and solution support with incremental updates
  - *How it works*: Loads F# projects and solutions, monitors file changes, provides workspace-wide code intelligence and cross-project analysis
  - *MCP Tools*: `LoadProject`, `WorkspaceLoad`, `WorkspacePeek`, `GetWorkspaceStatus`

- **🔗 LSP Protocol Support**: Full Language Server Protocol implementation for F# development
  - *Powered by*: `LspCommunication` + `LspTypes` - Complete LSP message handling with type-safe protocol implementation
  - *How it works*: Implements LSP client/server communication, handles all LSP message types, provides robust error handling and recovery
  - *Features*: Unified type system, JSON serialization, protocol compliance, concurrent message processing

## 🚀 Usage Examples

### Documentation Generation

```bash
# Generate documentation for a NuGet package
GeneratePackageDocumentation "System.Text.Json" "./docs" true

# Search through generated documentation  
SearchDocumentation "./docs" "JsonSerializer"

# List available packages
ListCachedPackages "System"
```

### Code Execution

```fsharp
// Execute F# code
ExecuteFSharpCode "let x = 1 + 2; printfn \"Result: %d\" x"

// Evaluate expressions with type info
EvaluateFSharpExpression "List.map ((*) 2) [1..5]"

// Reference packages
ReferenceNuGetPackage "FSharp.Data"
```

### Safe Code Insertion

```fsharp
// Insert code with validation and formatting
InsertCode "let newFunction x = x * 2" "MyScript.fsx" 10 1 true true

// Preview changes first
PreviewCodeInjection "let helper = ..." "MyScript.fsx" 15
```

### F# Language Server

```fsharp
// Start FsAutoComplete language server
StartFsAutoComplete "./workspace/path"

// Get real-time diagnostics for F# files
CheckFile "./MyScript.fs"

// Get hover documentation and type signatures
GetDocumentation "./MyScript.fs" 15 25
GetSignature "./MyScript.fs" 20 30

// Load F# projects for workspace analysis
LoadProject "./MyProject.fsproj"
WorkspacePeek "./solution" 2
```

## 🤖 Agent Development Strategies

This project provides **comprehensive strategies** for AI agents to work effectively with F# development through different methodologies:

### 📋 Available Development Approaches

The toolkit supports multiple development philosophies, each optimized for different scenarios and agent capabilities:

#### 🎯 [Script-Driven Development](docs/Agent-Instructions-Strategies/Script-Driven-Default/)

**Recommended for: Production workflows, complex validation, agent-driven development**

- **[📖 Design Philosophy](docs/Agent-Instructions-Strategies/Script-Driven-Default/Design.md)** - Comprehensive guide to script-based development methodology
- **[🛠️ Copilot Instructions](docs/Agent-Instructions-Strategies/Script-Driven-Default/copilot-instructions.md)** - Detailed agent instructions for script-driven workflows
- **Key Characteristics**: Reproducible execution, structured output, comprehensive validation, audit trails

#### 🔄 [REPL-Driven Development](docs/Agent-Instructions-Strategies/REPL-Driven-Default/)

**Recommended for: Exploration, prototyping, interactive development**

- **[📖 Design Philosophy](docs/Agent-Instructions-Strategies/REPL-Driven-Default/Design.md)** - Deep dive into REPL-based development patterns
- **[🛠️ Copilot Instructions](docs/Agent-Instructions-Strategies/REPL-Driven-Default/copilot-instructions.md)** - Agent guidance for interactive REPL workflows
- **Key Characteristics**: Immediate feedback, live debugging, exploratory programming, state preservation

#### 📜 [Signature-Driven Development](docs/Agent-Instructions-Strategies/Signature-Driven-Default/)

**Recommended for: Contract-first development, rigorous validation, clear interfaces**

- **[📖 Design Philosophy](docs/Agent-Instructions-Strategies/Signature-Driven-Default/Design.md)** - In-depth exploration of signature-driven development principles
- **[🛠️ Copilot Instructions](docs/Agent-Instructions-Strategies/Signature-Driven-Default/copilot-instructions.md)** - Instructions for implementing signature-driven workflows
- **Key Characteristics**: Explicit contracts, enhanced validation, clear module boundaries, improved collaboration

## 🏗️ Architecture

The FSharp.MCP.DevKit follows a **modular, layered architecture** with clear separation of concerns:

- **Core Layer**: Fundamental building blocks and services
- **Communication Layer**: Inter-process communication and networking
- **Code Editing Layer**: Code manipulation, formatting, and analysis
- **Documentation Layer**: Documentation generation and search
- **Agent Layer**: AI agent integration and management

---

<div align="center">

 **[📚 Documentation](.md)** • **[🛠️ Tools](#-mcp-tools-overview)** • **[🏗️ Architecture](#-architecture)**

*Built with ❤️ using F# and the Model Context Protocol*

</div>
