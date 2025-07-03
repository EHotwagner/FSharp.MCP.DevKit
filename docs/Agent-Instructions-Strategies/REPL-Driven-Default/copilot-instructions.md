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

## REPL-Driven Development for Complex Problems

For particularly challenging or complex problems that can be isolated, REPL-driven development can be a powerful technique. It allows for rapid experimentation and exploration to find a solution before integrating it into the main codebase. Use it when you need to:

- Quickly test a hypothesis.
- Explore a new library or API.
- Debug a complex algorithm step-by-step.

## MCP F# Tools Usage

- **Prefer MCP tools**: Use the F# MCP tools (`mcp_fsharp-fsi-mc_*`) for all code manipulation instead of manual editing.
- **Incremental insertions**: Use `InsertCode` for safe, validated, and formatted code insertion.
- **Validate before proceeding**: Always check for parse errors using `ParseAndCheckFSharpCode` before continuing.
- **Format consistently**: Use `FormatFile` to maintain consistent code style across the entire script.
- **Preview changes**: Use `PreviewCodeInjection` when unsure about insertion placement.

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

## Code Organization Principles

- **Function composition over inheritance**: Build complex functionality by composing simple functions.
- **Immutable by default**: Use mutable state only when absolutely necessary and clearly justified.
- **Type-driven design**: Let F#'s type system guide your API design and catch errors early.
- **Module organization**: Group related functions in modules, keep public APIs minimal.

## Best Practices

- **Document intent**: Add concise comments explaining the "why" not the "what".
- **Use meaningful names**: Prefer descriptive function and variable names over abbreviated ones.
- **Embrace pattern matching**: Use pattern matching instead of if-else chains when possible.
- **Pipeline operations**: Use |> operator to create readable data transformation pipelines.
- **Avoid deep nesting**: Refactor deeply nested code into smaller, composed functions.

## MCP Tool Workflow

1.  **Plan**: Break down the task into small, testable functions.
2.  **Implement**: Use `InsertCode` to add new code safely.
3.  **Validate**: Use `ParseAndCheckFSharpCode` to check for errors.
4.  **Test**: Use `ExecuteFSharpCode` to test the new functionality.
5.  **Refine**: Iterate based on results and feedback.
6.  **Format**: Use `FormatFile` to ensure consistent styling.
7.  **Refactor**: Once working, look for opportunities to improve the code's structure and clarity.

## Code Quality Guidelines

- **Single responsibility**: Each function should have one clear purpose
- **Pure functions preferred**: Minimize side effects, make dependencies explicit
- **Composable design**: Functions should work well when combined with others
- **Testable units**: Write functions that are easy to test in isolation
- **Performance awareness**: Consider computational complexity, but prioritize clarity first

## Language Preferences

- **F# first**: Always prefer F# solutions over C# or other .NET languages
- **Functional style**: Use functional programming constructs (map, fold, filter) over loops
- **Type safety**: Leverage F#'s type system to prevent runtime errors
- **Computation expressions**: Use async, result, option computation expressions appropriately
- **Active patterns**: Use active patterns for complex pattern matching scenarios
