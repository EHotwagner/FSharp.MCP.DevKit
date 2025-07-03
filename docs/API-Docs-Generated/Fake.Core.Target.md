# Fake.Core.Target API Reference

**Version:** 6.1.3  
**Package:** Fake.Core.Target  
**Generated:** 2025-07-03  

## Overview

The `Fake.Core.Target` package provides the core target definition and execution functionality for FAKE (F# Make) build scripts. It defines the fundamental building blocks for creating build targets and managing their dependencies.

## Key Features

- **Target Definition**: Define build targets with dependencies
- **Target Execution**: Execute targets with proper dependency resolution
- **Parallel Execution**: Support for parallel target execution
- **Error Handling**: Comprehensive error handling and logging
- **Dependency Management**: Automatic dependency resolution and ordering

## Core Types and Modules

### Target Module

The main `Target` module provides the primary API for defining and executing build targets.

#### Core Functions

##### Target Creation

```fsharp
val create : name:string -> body:(TargetParameter -> unit) -> unit
```
Creates a new build target with the specified name and execution body.

**Parameters:**
- `name` - The unique name of the target
- `body` - The function to execute when the target runs

**Example:**
```fsharp
Target.create "Build" (fun _ ->
    // Build logic here
    printfn "Building the project..."
)
```

##### Target Dependencies

```fsharp
val dependency : target:string -> dependency:string -> unit
```
Defines a dependency relationship between targets.

**Parameters:**
- `target` - The target that depends on another
- `dependency` - The target that must run first

**Example:**
```fsharp
"Test" ==> "Build"  // Test depends on Build
```

##### Target Execution

```fsharp
val run : target:string -> unit
```
Executes the specified target and all its dependencies.

**Parameters:**
- `target` - The name of the target to execute

**Example:**
```fsharp
Target.run "Deploy"
```

#### Advanced Functions

##### Conditional Targets

```fsharp
val createBuildFailure : name:string -> body:(TargetParameter -> unit) -> unit
```
Creates a target that only runs if the build fails.

```fsharp
val createFinal : name:string -> body:(TargetParameter -> unit) -> unit  
```
Creates a target that always runs at the end, regardless of build success or failure.

##### Parallel Execution

```fsharp
val runParallel : maxThreads:int -> targets:string list -> unit
```
Executes multiple targets in parallel with the specified maximum thread count.

**Parameters:**
- `maxThreads` - Maximum number of concurrent threads
- `targets` - List of target names to execute

#### Target Information

```fsharp
val listAvailable : unit -> string list
```
Returns a list of all available target names.

```fsharp
val description : target:string -> description:string -> unit
```
Adds a description to a target for documentation purposes.

**Example:**
```fsharp
Target.create "Build" (fun _ -> ...)
Target.description "Build" "Compiles the entire solution"
```

### TargetParameter Type

The `TargetParameter` type provides context information to target execution functions.

#### Properties

- **Target** - The current target being executed
- **Context** - Build context information
- **CancellationToken** - Cancellation token for long-running operations

### Operators

FAKE provides convenient operators for defining target dependencies:

#### ==> Operator (Dependency)

```fsharp
val (==>) : string -> string -> unit
```
Defines a soft dependency between targets.

**Example:**
```fsharp
"Clean" ==> "Build" ==> "Test" ==> "Deploy"
```

#### ?=> Operator (Conditional Dependency)

```fsharp
val (?=>) : string -> string -> unit  
```
Defines a conditional dependency that only applies if the dependency target exists.

#### <== Operator (Reverse Dependency)

```fsharp
val (<==) : string -> string -> unit
```
Defines a reverse dependency relationship.

## Usage Patterns

### Basic Target Definition

```fsharp
open Fake.Core

Target.create "Clean" (fun _ ->
    // Cleaning logic
    Shell.cleanDirs ["bin"; "obj"]
)

Target.create "Build" (fun _ ->
    // Build logic  
    DotNet.build id "MyProject.sln"
)

Target.create "Test" (fun _ ->
    // Test logic
    DotNet.test id "MyProject.sln"  
)

// Define dependencies
"Clean" ==> "Build" ==> "Test"

// Run the build
Target.run "Test"
```

### Advanced Target Configuration

```fsharp
// Target with description
Target.create "Package" (fun _ ->
    // Packaging logic
    NuGet.pack (fun defaults -> { defaults with OutputPath = "artifacts" })
)
Target.description "Package" "Creates NuGet packages for distribution"

// Conditional target
Target.create "PublishToNuGet" (fun _ ->
    // Only runs if API key is available
    if Environment.hasEnvironVar "NUGET_API_KEY" then
        NuGet.push (fun defaults -> defaults)
)

// Build failure handler
Target.createBuildFailure "NotifyFailure" (fun _ ->
    // Notification logic for build failures
    printfn "Build failed! Sending notifications..."
)

// Final cleanup target
Target.createFinal "Cleanup" (fun _ ->
    // Always runs at the end
    Shell.cleanDirs ["temp"]
)
```

### Parallel Execution

```fsharp
// Define independent targets
Target.create "BuildClient" (fun _ -> (* client build *))
Target.create "BuildServer" (fun _ -> (* server build *))  
Target.create "BuildShared" (fun _ -> (* shared lib build *))

// Dependencies
"BuildShared" ==> "BuildClient"
"BuildShared" ==> "BuildServer"

// Parallel execution after shared build
Target.create "BuildAll" (fun _ ->
    Target.runParallel 2 ["BuildClient"; "BuildServer"]
)
```

## Error Handling

Targets automatically handle exceptions and provide detailed error information:

```fsharp
Target.create "RiskyTarget" (fun _ ->
    try
        // Risky operation
        failwith "Something went wrong"
    with
    | ex -> 
        Trace.traceError $"Target failed: {ex.Message}"
        reraise()
)
```

## Integration with Other FAKE Modules

The Target module integrates seamlessly with other FAKE components:

- **Fake.Core.Trace** - For logging and output
- **Fake.DotNet.Cli** - For .NET CLI operations  
- **Fake.IO.FileSystem** - For file system operations
- **Fake.Core.Process** - For external process execution

## Best Practices

1. **Clear Naming**: Use descriptive target names
2. **Logical Dependencies**: Structure dependencies logically
3. **Error Handling**: Implement proper error handling in targets
4. **Documentation**: Add descriptions to important targets
5. **Modularity**: Keep targets focused and modular
6. **Parallel Execution**: Use parallel execution for independent operations

## Migration Notes

When migrating from older FAKE versions:

- Use `Target.create` instead of deprecated `Target` function
- Use `Target.run` instead of `RunTargetOrDefault`
- Update dependency syntax to use `==>` operator
- Replace `Target` with `Target.create` in target definitions

## See Also

- [Fake.Core.Trace](../fake.core.trace/README.md) - Logging and tracing
- [Fake.Core.Environment](../fake.core.environment/README.md) - Environment utilities
- [FAKE Documentation](https://fake.build/) - Official FAKE documentation
