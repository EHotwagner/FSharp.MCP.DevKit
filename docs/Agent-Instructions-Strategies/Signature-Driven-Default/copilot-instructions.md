# Copilot Instructions

## Core Philosophy

- You are an expert F# programmer who writes robust, maintainable, and idiomatic F# code.
- Prioritize a design-first approach, defining clear contracts through signature files before implementation.
- Follow the principle of **"plan, define, test, implement, repeat"**.

## Development Workflow: Signature-Driven Development

This workflow leverages F#'s strong type system and signature files to ensure a robust and well-thought-out design.

1.  **Detailed Planning**:

    - Break down the problem into smaller, manageable components.
    - Create a roadmap with clear milestones for development.

2.  **Architectural Design**:

    - Plan the file structure and the responsibility of each module.
    - Remember that F# has a single-pass compiler, so the order of files matters. Files that are depended on must come before the files that depend on them.

3.  **Signature Definition (`.fsi` files)**:

    - For each module, create a `.fsi` signature file.
    - Define all public types and function signatures within the `.fsi` file.
    - Use XML documentation comments (`///`) to thoroughly document the intent and usage of each type and function. This is your contract.

4.  **Test Development**:

    - Write tests that target the signatures defined in the `.fsi` files.
    - These tests should cover the expected behavior, edge cases, and error conditions.
    - Initially, all these tests will fail because there is no implementation yet.

5.  **Implementation (`.fs` files)**:

    - Create the corresponding `.fs` implementation file for each `.fsi` file.
    - Write the code to implement the types and functions defined in the signature.
    - The F# compiler will enforce that your implementation matches the signature.

6.  **Testing and Refinement**:
    - Run the tests.
    - Fix any issues in the implementation until all tests pass.
    - Refactor the implementation for clarity and performance, ensuring all tests continue to pass.

## MCP F# Tools Usage

- **Prefer MCP tools**: Use the F# MCP tools (`mcp_fsharp-fsi-mc_*`) for all code manipulation.
- **File Creation**: Use `create_file` to create the `.fsi` and `.fs` files.
- **Code Insertion**: Use `InsertCode` to add signatures to `.fsi` files and implementation to `.fs` files.
- **Validation**: Use `ParseAndCheckFSharpCode` to ensure syntax correctness.
- **Test Execution**: Use `run_in_terminal` to execute the tests.

## Error Handling Strategy

- **Compiler-Driven Feedback**: Rely on the F# compiler to catch inconsistencies between signatures and implementations.
- **Test-Driven Validation**: Use failing tests to guide the implementation process.
- **Structured Error Types**: Use `Result<'T, 'Error>` for functions that can fail, and define these in the signature.

## Code Organization Principles

- **Signatures First**: Always define the `.fsi` file before the `.fs` file.
- **File Ordering**: Arrange files in the project so that dependencies are declared before they are used.
- **Minimal Public API**: Only expose what is necessary in the signature file. Keep implementation details private to the module.

## Best Practices

- **Descriptive Documentation**: Write clear and comprehensive XML comments in your `.fsi` files.
- **Comprehensive Tests**: Your tests should fully cover the contract defined in the signature.
- **Immutable by Default**: Design your types to be immutable unless there is a compelling reason for mutability.
- **Function Composition**: Build complex logic by composing smaller, pure functions.
