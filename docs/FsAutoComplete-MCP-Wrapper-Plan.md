# MCP Server Wrapper for FsAutoComplete: A Detailed Plan

This document outlines the plan for creating a Model Context Protocol (MCP) server that wraps the FsAutoComplete language server.

## 1. Goal

The primary goal is to create a robust and maintainable MCP server that acts as a wrapper around FsAutoComplete. This will expose F# language services (like diagnostics, completions, tooltips) to an MCP client, enabling advanced F# tooling in environments that support MCP.

A key focus will be on reliably capturing and exposing diagnostics (errors and warnings), which was a challenge in previous attempts.

## 2. Architecture

The proposed architecture consists of three main components:

1. **FsAutoComplete Process**: The standard FsAutoComplete language server running as a separate, managed child process.
2. **MCP Wrapper Server**: A new F# project, `FSharp.MCP.DevKit.FsAutoComplete`, that will:
    * Manage the lifecycle of the FsAutoComplete process.
    * Communicate with it over `stdin`/`stdout` using the Language Server Protocol (LSP).
    * Expose FsAutoComplete's functionality through a set of MCP methods.
3. **MCP Client**: The consumer of the MCP services (e.g., a VS Code extension).

The wrapper will be responsible for translating MCP calls into LSP requests, sending them to FsAutoComplete, parsing the responses, and returning them to the client. For server-initiated notifications like diagnostics, the wrapper will maintain a persistent state that can be queried on demand by the MCP client.

## 3. Project Setup

1. **Create a new project**:
    * Create a new F# library project named `FSharp.MCP.DevKit.FsAutoComplete` inside the `src/` directory.
    * Add this project to the `FSharp.MCP.DevKit.sln` solution file.
    * This project will contain the core logic for the wrapper.

2. **Dependencies**:
    * The project will need a library for handling JSON-RPC and LSP types. `LSP.Types` is a good candidate.
    * It will also need dependencies for logging and configuration, likely reusing what's already in your solution.
    * A reference to `FSharp.MCP.DevKit.Core` will be needed to define the MCP methods.

## 4. Locating FsAutoComplete

FsAutoComplete is installed as a .NET global tool. This simplifies locating the executable. The wrapper will not need a configured path to the FsAutoComplete DLL. Instead, it can simply execute `fsautocomplete` and the shell will resolve the path to the globally installed tool. This makes the wrapper more portable and easier to configure.

## 5. Core Implementation Plan

### Phase 1: Process Management and Basic Communication

The first step is to reliably manage the FsAutoComplete process and establish basic communication.

1. **Process Manager**: Create a module responsible for:
    * Starting the `fsautocomplete` process.
    * Redirecting its `stdin` and `stdout` streams for communication.
    * Monitoring the process for unexpected termination and handling restarts.
    * Gracefully shutting down the process.

2. **LSP Communication Layer**: Create a module to handle LSP message formatting and parsing.
    * Implement functions to serialize LSP requests (like `initialize`, `textDocument/didOpen`) into the JSON-RPC format that FsAutoComplete expects.
    * Implement a parser for incoming LSP messages from FsAutoComplete's `stdout`. This parser must handle both responses to requests and unsolicited notifications.

3. **Initialization**:
    * Implement an `mcp_fsac_initialize` method.
    * This method will start the FsAutoComplete process (if not already running) and send the LSP `initialize` request.
    * It should then wait for the `initialize` response and store the server capabilities. This handshake is essential for all future communication.

### Phase 2: The Diagnostics Solution

This phase tackles the critical requirement of capturing diagnostics. Since diagnostics are *pushed* from the server, we need a listener.

1. **Dedicated Output Listener**:
    * On process start, spawn a long-running, asynchronous task that continuously reads from the FsAutoComplete process's `stdout` stream.
    * This listener will use the LSP message parser from Phase 1.

2. **State Management**:
    * Create a thread-safe, in-memory store (e.g., a `ConcurrentDictionary<Uri, Diagnostic[]>`) to hold the diagnostics for each file.

3. **Handling `publishDiagnostics`**:
    * The output listener, upon receiving a `textDocument/publishDiagnostics` notification, will parse it.
    * It will then update the central diagnostics store with the new list of diagnostics for the given file URI. If the list is empty, it means all previous errors in that file have been resolved.

4. **MCP Endpoint for Diagnostics**:
    * Create an MCP method, `mcp_fsac_getDiagnostics { fileUri: string }`.
    * This method will simply query the in-memory diagnostics store for the given file and return the cached diagnostics. This provides a synchronous, on-demand way for the client to get the latest diagnostics.

### Phase 3: Wrapping Core LSP Features

With the foundation in place, we can start wrapping standard LSP features. For each feature, the pattern will be:
`MCP Method` -> `LSP Request` -> `Wait for Response` -> `Return Result`

* **Document Synchronization**: `didOpen`, `didChange`, `didClose`
* **Language Features**: `completion`, `hover`, `signatureHelp`, `definition`

### Phase 4: Advanced Features and Refinements

1. **Workspace Symbols**: Implement `workspace/symbol`.
2. **Code Actions**: Implement `textDocument/codeAction` to provide refactorings and quick fixes.
3. **Error Resilience**: Improve the robustness of the wrapper.
4. **Performance**: Profile and optimize the wrapper.
5. **Configuration**: Expose FsAutoComplete settings through the MCP interface.

## 6. Development Workflow: Updating the Server

Since the MCP server is a long-running process, updating it with new code requires a specific workflow. The recommended approach is to use a "watch and restart" script.

1. **Create a Watch Task**: A new task, similar to the existing `watch` task in `tasks.json`, should be created for the `FSharp.MCP.DevKit.FsAutoComplete` project.
2. **Functionality**: This task will use `dotnet watch`. `dotnet watch` will:
    * Monitor the project's source files for any changes.
    * When a file is saved, it will automatically terminate the currently running server process.
    * It will then rebuild the project.
    * Finally, it will restart the server with the newly compiled code.

This approach provides a seamless development experience, automating the compile-and-restart cycle and allowing for rapid iteration.

## 7. Root Cause Analysis: Why Diagnostics Failed Previously

Based on research into the Microsoft LSP documentation and FsAutoComplete source code, the diagnostics issue stems from a fundamental misunderstanding of the LSP protocol:

### The Problem: Notifications vs Requests

1. **Diagnostics are notifications, not responses**: In LSP, `textDocument/publishDiagnostics` is a **notification** sent from server to client, not a response to a request.

2. **JSON-RPC distinction**:
   * **Requests** have an `id` field and expect a response with the same `id`
   * **Notifications** have no `id` field and expect no response
   * Diagnostics use the notification pattern

3. **Asynchronous by design**: FsAutoComplete sends diagnostics:
   * After parsing completes
   * After type-checking completes  
   * After each analyzer runs (unused opens, unused declarations, etc.)
   * This results in multiple `publishDiagnostics` notifications per file change

### Microsoft Documentation Evidence

From the MS Docs search results:

* LSP specifies that diagnostics are sent via `textDocument/publishDiagnostics` notifications
* These are server-initiated messages that happen asynchronously
* The client must have a persistent listener for these notifications
* Visual Studio supports `textDocument/publishDiagnostics` in its LSP implementation

### FsAutoComplete Implementation Details

From the FsAutoComplete source code analysis:

* Diagnostics are sent via `lspClient.TextDocumentPublishDiagnostics(publishDiagnosticsParams)`
* Multiple diagnostic sources: F# Compiler, FSAC analyzers, F# Analyzers, etc.
* Each source sends its own `publishDiagnostics` notification
* FsAutoComplete has a `DiagnosticCollection` that manages and batches diagnostics
* There's even a fix mentioned in changelog: "Fix textDocument/publishDiagnostics sometimes not getting sent"

### The Solution Architecture

The proposed architecture with a dedicated output listener and stateful cache is exactly what's needed because:

1. **Persistent Listener**: Required to capture asynchronous notifications
2. **State Management**: Multiple diagnostics notifications need to be aggregated
3. **Polling Interface**: MCP clients can query the cached state synchronously

### Available Development Tools

We also have Microsoft Docs MCP tools available for researching LSP documentation and troubleshooting implementation issues during development.

## 8. Learning from Past Attempts

The `archive/fsautocomplete-research` directory suggests a previous effort that likely failed because it tried to use a request/response pattern for diagnostics instead of implementing a proper notification listener. The architecture proposed here directly addresses that fundamental misunderstanding of the LSP protocol.

## 9. Additional Improvements and Considerations

### Enhanced Error Handling and Reliability

1. **Process Health Monitoring**:
   * Implement heartbeat checks to detect FsAutoComplete crashes
   * Auto-restart with exponential backoff on failures
   * Graceful degradation when FsAutoComplete is unavailable

2. **Message Validation**:
   * Validate all LSP messages before sending to FsAutoComplete
   * Handle malformed responses gracefully
   * Implement request timeouts to prevent hanging

3. **State Consistency**:
   * Persist critical state (open documents, project info) to handle restarts
   * Implement state reconciliation after process restarts
   * Track document versions to avoid stale diagnostics

### Performance Optimizations

1. **Message Batching**:
   * Batch multiple document changes into single requests where possible
   * Implement debouncing for rapid file changes
   * Optimize JSON serialization/deserialization

2. **Diagnostic Aggregation**:
   * Merge diagnostics from multiple sources intelligently
   * Remove duplicate diagnostics across sources
   * Implement diagnostic versioning to track freshness

3. **Memory Management**:
   * Implement LRU cache for diagnostics with configurable size limits
   * Clean up diagnostics for closed documents
   * Monitor memory usage and implement cleanup strategies

### Enhanced Development and Testing

1. **Comprehensive Testing Strategy**:
   * Unit tests for LSP message parsing/generation
   * Integration tests with real FsAutoComplete processes
   * End-to-end tests simulating actual F# development workflows
   * Property-based testing for message handling edge cases

2. **Development Tools**:
   * LSP message logging with different verbosity levels
   * Debug endpoints to inspect internal state
   * Performance metrics and monitoring
   * Configuration hot-reloading for rapid development

3. **Documentation and Examples**:
   * Sample MCP client implementations
   * API documentation with usage examples
   * Troubleshooting guide for common issues
   * Performance tuning guidelines

### Security and Sandboxing

1. **Process Isolation**:
   * Run FsAutoComplete in a restricted environment
   * Limit file system access to workspace directories
   * Implement resource limits (CPU, memory, file handles)

2. **Input Validation**:
   * Sanitize all file paths and URIs
   * Validate workspace boundaries
   * Prevent path traversal attacks

### Configuration and Customization

1. **Flexible Configuration**:
   * Support for multiple FsAutoComplete versions
   * Per-project configuration overrides
   * Plugin architecture for custom analyzers
   * Environment-specific settings (dev vs prod)

2. **Workspace Management**:
   * Support for multi-root workspaces
   * Project discovery and auto-loading
   * Solution-wide analysis coordination
   * Dependency tracking and reload triggers

### Future Extensibility

1. **Plugin Architecture**:
   * Interface for custom MCP tools
   * Extension points for additional language services
   * Support for external analyzers and linters

2. **Protocol Evolution**:
   * Version negotiation with MCP clients
   * Backward compatibility for older clients
   * Feature capability advertisement

3. **Integration Points**:
   * Hooks for CI/CD integration
   * Support for external build systems
   * Integration with package managers (NuGet, Paket)

## 10. Implementation Priorities

### Phase 1 (MVP): Core Functionality

- [x] Process management and basic LSP communication
* [x] Diagnostics capture and caching
* [x] Basic MCP endpoint implementation
* [ ] Document synchronization (open/close/change)
* [ ] Essential language services (hover, definition)

### Phase 2: Enhanced Reliability

- [ ] Robust error handling and recovery
* [ ] Process health monitoring
* [ ] State persistence and reconciliation
* [ ] Comprehensive testing suite

### Phase 3: Performance and Polish

- [ ] Performance optimizations
* [ ] Advanced diagnostic features
* [ ] Configuration management
* [ ] Documentation and examples

### Phase 4: Advanced Features

- [ ] Multi-workspace support
* [ ] Plugin architecture
* [ ] Security hardening
* [ ] Monitoring and metrics
