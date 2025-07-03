# FSharp.MCP.DevKit.CodeEditing

`FSharp.MCP.DevKit.CodeEditing` provides sophisticated F# code manipulation and editing capabilities with enterprise-grade safety features. This project implements advanced code injection, formatting, and validation tools that enable safe programmatic modification of F# source files while maintaining code integrity and syntactic correctness.

## Overview

The CodeEditing project provides:
- Safe F# code insertion with AST validation.
- Code formatting integration with Fantomas.
- Structure analysis and dependency tracking.
- Preview capabilities for code changes.
- Type-safe code manipulation tools.

## Architecture

The CodeEditing project implements a multi-layered code manipulation architecture:
- **Safe Code Injection**: Context-aware code insertion with comprehensive validation.
- **Atomic Operations**: All-or-nothing code modifications with rollback capabilities.
- **Format Integration**: Deep integration with Fantomas for consistent code formatting.
- **Validation Pipeline**: Multi-stage validation with AST analysis and type checking.
- **Error Recovery**: Robust error handling with detailed diagnostic reporting.

```mermaid
graph TB
    subgraph "Code Editing Pipeline"
        Request["`**Edit Request**<br/>• Code to Insert<br/>• Target Location<br/>• Validation Options`"]
        PreValidation["`**Pre-Validation**<br/>• File Type Check<br/>• Parameter Validation<br/>• Permission Check`"]
        Backup["`**Backup Creation**<br/>• Original File Copy<br/>• Rollback Preparation<br/>• Version Tracking`"]
        PreFormat["`**Pre-Format Code**<br/>• Fantomas Integration<br/>• Style Consistency<br/>• Syntax Correction`"]
        ContextAnalysis["`**Context Analysis**<br/>• Insertion Safety<br/>• Scope Validation<br/>• Syntax Compatibility`"]
        ASTValidation["`**AST Validation**<br/>• Parse Tree Check<br/>• Type Validation<br/>• Semantic Analysis`"]
        AtomicInsert["`**Atomic Insertion**<br/>• Safe File Modification<br/>• Transaction Semantics<br/>• Error Recovery`"]
        PostFormat["`**Post-Format**<br/>• Document Formatting<br/>• Style Enforcement<br/>• Final Validation`"]
        Commit["`**Commit Changes**<br/>• Finalize Modifications<br/>• Update Metadata<br/>• Success Response`"]
    end
    
    subgraph "External Services"
        Fantomas["`**Fantomas**<br/>Code Formatter<br/>• F# Style Rules<br/>• Consistent Output<br/>• Custom Configuration`"]
        CompilerServices["`**F# Compiler Services**<br/>• AST Analysis<br/>• Type Checking<br/>• Error Reporting`"]
        FileSystem["`**File System**<br/>• Safe I/O Operations<br/>• Backup Management<br/>• Lock Handling`"]
    end
    
    subgraph "Error Handling"
        ValidationError["`**Validation Error**<br/>• Detailed Diagnostics<br/>• Rollback Trigger<br/>• User Feedback`"]
        RollbackOperation["`**Rollback**<br/>• Restore Original<br/>• Cleanup Temp Files<br/>• Error Reporting`"]
    end
    
    Request --> PreValidation
    PreValidation --> Backup
    Backup --> PreFormat
    PreFormat --> ContextAnalysis
    ContextAnalysis --> ASTValidation
    ASTValidation --> AtomicInsert
    AtomicInsert --> PostFormat
    PostFormat --> Commit

    PreValidation -- "On Failure" --> ValidationError
    ASTValidation -- "On Failure" --> ValidationError
    AtomicInsert -- "On Failure" --> RollbackOperation
    ValidationError --> RollbackOperation
```

## Available Tools

The code injection tools provide a safe and reliable way to programmatically modify F# script files.

### 1. TryInsertCode (Safe Injection)

**Purpose**: Safely insert F# code into a script file with full AST validation and type checking.

**Signature**:
```fsharp
TryInsertCode(fsiService, newCode, filePath, ?insertAtLine)
```

**Features**:
- Full AST parsing and validation before insertion.
- Type checking to ensure code validity.
- Comprehensive error and warning reporting.
- Rollback on validation failure.

### 2. InsertCode (Direct Injection)

**Purpose**: Directly insert code without validation (use with caution).

**Signature**:
```fsharp
InsertCode(fsiService, newCode, filePath, ?insertAtLine)
```

**Features**:
- Immediate insertion without validation.
- Faster execution for trusted code.

### 3. PreviewCodeInjection

**Purpose**: Preview what the file will look like after code injection without actually modifying it.

**Signature**:
```fsharp
PreviewCodeInjection(fsiService, newCode, filePath, ?insertAtLine)
```

**Features**:
- Shows complete file content with injection markers.
- No file modification.

## Implementation Report Summary

The code insertion functionality was significantly refactored to address several critical issues:

-   **Error String Injection Bug**: Fixed a bug where validation error messages were being written to files, causing corruption.
-   **Inconsistent Error Handling**: Unified error handling to use a `Result` type for predictable outcomes.
-   **Line Numbering Issues**: Corrected line splitting logic to handle empty lines properly, ensuring accurate insertion.
-   **Unsafe File Operations**: Implemented atomic writes and file backups to prevent data loss.
-   **Refactoring**: Replaced three separate insertion functions with a single, robust `InsertCode` tool that handles validation, formatting, and file operations safely.

## Related Projects

- [Core](../Core/) - F# Interactive core services
- [Server](../Server/) - MCP server implementation
- [Communication](../Communication/) - IPC and communication protocols
- [Analysis](../Analysis/) - Code analysis and symbol detection
- [Documentation](../Documentation/) - Documentation generation tools
