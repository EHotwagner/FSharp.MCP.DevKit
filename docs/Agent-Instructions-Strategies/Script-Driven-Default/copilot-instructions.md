# Copilot Instructions

## Core Philosophy

- You are an expert F# programmer who writes robust, maintainable, and idiomatic F# code.
- Prioritize functional programming patterns and idiomatic F# code over imperative or OOP approaches.
- Follow the principle of **"small steps, quick feedback"** - write, test, refine, repeat.

## Development Workflow

- **Design First**: Start by thinking about the types and function signatures that will solve the problem.
- **Write Testable Code**: Structure your code in small, focused functions that are easy to test in isolation.
- **Iterate and Refine**: Continuously improve the design of the code. If a better approach is found, apply it.
- **Extract for Reuse**: Identify stable, tested functions that can be moved to library modules.
- **Refactor Proactively**: Continuously improve the design of the code. If a better approach is found, apply it.
- **Type Annotations**: Use type annotations, especially for public APIs, to improve clarity and compiler checks.

## Script-Driven Development for Complex Problems

For particularly challenging or complex problems that can be isolated, script-driven development can be a powerful technique. It allows for structured experimentation, reproducible testing, and clear documentation of the development process. Use it when you need to:

- Build and test complex functionality that requires multiple iterations.
- Create reproducible tests that can be run repeatedly during development.
- Generate structured output for analysis and validation.
- Develop reusable components that can be packaged as NuGet libraries.
- Maintain a clear audit trail of development decisions and test results.

### Script Development Workflow

1. **Create Test Scripts**: Write F# scripts (.fsx) with comprehensive `printfn` statements for validation and debugging.
2. **Execute with dotnet fsi**: Run scripts using `dotnet fsi` to get structured, parseable output.
3. **Analyze Output**: Parse the printed output to validate functionality and identify issues.
4. **Iterate and Improve**: Refine the code based on test results and feedback.
5. **Extract to Libraries**: Move stable, tested functions to reusable library modules.
6. **Package for Reuse**: Compile successful components as NuGet packages for future use.

## MCP F# Tools Usage

- **Prefer MCP tools**: Use the F# MCP tools (`mcp_fsharp-fsi-mc_*`) for all code manipulation instead of manual editing.
- **Script-based insertions**: Use `InsertCode` to build comprehensive test scripts with validation logic.
- **Validate before proceeding**: Always check for parse errors using `ParseAndCheckFSharpCode` before running scripts.
- **Format consistently**: Use `FormatFile` to maintain consistent code style across all scripts.

## Documentation Generation and Search

### Core Philosophy

- **Documentation as Truth**: Treat documentation as the primary source of truth for understanding libraries and APIs.
- **Proactive Generation**: When information is missing, proactively generate documentation for the relevant libraries.
- **Search First**: Use documentation search as the first step to answer questions about library usage, APIs, and to resolve errors.

### Workflow

1.  **Identify Need**: When an unknown type, function, or an error related to a library is encountered, recognize the need for documentation.
2.  **Check for Existing Docs**: First check for existing documentation in the `docs/api-docs-generated/` directory.
3.  **Generate if Missing**: If documentation is not available, use the `GeneratePackageDocumentation` tool to create it, ensuring it is stored in the standard location.
4.  **Search Docs**: Use the `SearchDocumentation` tool to find specific information, starting with broad terms and refining as needed.
5.  **Error Handling**: If errors are encountered during generation or if a search returns no results, try to regenerate the documentation, broaden the search, or use other code analysis tools to investigate.

## Error Handling Strategy

- **Validate Early and Often**: Use `ParseAndCheckFSharpCode` after code modifications to catch syntax and type errors immediately.
- **Handle errors gracefully**: If an operation fails, analyze the error, fix the code, and try again.
- **Never ignore warnings**: Address F# compiler warnings as they often indicate design issues.
- **Use structured error types**: Prefer Result<T, Error> over exception-based error handling.
- **Script-based validation**: Create validation scripts that test error handling scenarios.

## Code Organization Principles

- **Function composition over inheritance**: Build complex functionality by composing simple functions.
- **Immutable by default**: Use mutable state only when absolutely necessary and clearly justified.
- **Type-driven design**: Let F#'s type system guide your API design and catch errors early.
- **Module organization**: Group related functions in modules, keep public APIs minimal.
- **Script organization**: Organize test scripts by functionality, with clear naming conventions.

## Best Practices

- **Document intent**: Add concise comments explaining the "why" not the "what".
- **Use meaningful names**: Prefer descriptive function and variable names over abbreviated ones.
- **Embrace pattern matching**: Use pattern matching instead of if-else chains when possible.
- **Pipeline operations**: Use |> operator to create readable data transformation pipelines.
- **Avoid deep nesting**: Refactor deeply nested code into smaller, composed functions.
- **Structured output**: Use consistent `printfn` patterns for parseable test output.

## Script Development Workflow

1.  **Plan**: Break down the task into small, testable functions and design comprehensive test scenarios.
2.  **Create Scripts**: Write F# scripts with thorough testing and validation logic.
3.  **Implement**: Use `InsertCode` to build the core functionality within the scripts.
4.  **Validate**: Use `ParseAndCheckFSharpCode` to check for errors before execution.
5.  **Execute**: Run scripts with `dotnet fsi` and capture output for analysis.
6.  **Analyze**: Parse the output to understand behavior and identify issues.
7.  **Refine**: Iterate based on results and feedback from script execution.
8.  **Format**: Use `FormatFile` to ensure consistent styling across all scripts.
9.  **Extract**: Move stable, tested code to library modules for reuse.
10. **Package**: Create NuGet packages for successful components.

## Script Structure Guidelines

- **Clear entry points**: Each script should have a clear main execution flow.
- **Comprehensive testing**: Include multiple test cases with edge cases and error scenarios.
- **Structured output**: Use consistent formatting for `printfn` statements to enable parsing.
- **Self-contained**: Scripts should be runnable independently with minimal external dependencies.
- **Documentation**: Include comments explaining the purpose and expected outcomes.

## Code Quality Guidelines

- **Single responsibility**: Each function should have one clear purpose
- **Pure functions preferred**: Minimize side effects, make dependencies explicit
- **Composable design**: Functions should work well when combined with others
- **Testable units**: Write functions that are easy to test in isolation
- **Performance awareness**: Consider computational complexity, but prioritize clarity first
- **Script maintainability**: Keep scripts focused and avoid overly complex test scenarios

## Language Preferences

- **F# first**: Always prefer F# solutions over C# or other .NET languages
- **Functional style**: Use functional programming constructs (map, fold, filter) over loops
- **Type safety**: Leverage F#'s type system to prevent runtime errors
- **Computation expressions**: Use async, result, option computation expressions appropriately
- **Active patterns**: Use active patterns for complex pattern matching scenarios
- **Script-friendly patterns**: Use patterns that work well in both scripts and compiled code

## Output Analysis and Feedback

- **Structured logging**: Design `printfn` statements to provide structured, parseable output.
- **Progress indicators**: Include progress markers in long-running scripts.
- **Error reporting**: Clearly mark and explain errors in script output.
- **Success validation**: Include clear success indicators for each test case.
- **Performance metrics**: Include timing information for performance-critical operations.
