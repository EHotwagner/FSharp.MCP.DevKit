# Testing Instructions for F# MCP DevKit

## File Patterns
- **/*Tests.fs
- **/tests/**
- **/*.fsx (when containing test functions)

## Testing Guidelines

When working with test files in this F# project:

### Testing Framework Preferences
- Use NUnit or xUnit for unit testing
- Use FsCheck for property-based testing
- Use Expecto for more F#-idiomatic testing when appropriate

### Test Structure
- Follow AAA pattern: Arrange, Act, Assert
- Use descriptive test names that explain the scenario
- Group related tests in test modules

### F# Testing Patterns
- Use computation expressions for test setup when beneficial
- Leverage pattern matching in assertions
- Create test data using F# record types and discriminated unions

### Error Handling in Tests
- Test both success and error cases for Result<T, Error> functions
- Use explicit assertions for error types and messages
- Test async workflows with proper async test patterns

### Property-Based Testing
- Use FsCheck for testing properties and invariants
- Generate test data that exercises edge cases
- Create custom generators for domain-specific types

### Integration Testing
- Test F# async workflows end-to-end
- Mock external dependencies appropriately
- Use test databases or in-memory alternatives for data access tests

### Performance Testing
- Include performance assertions for critical paths
- Test memory allocation patterns for performance-sensitive code
- Use BenchmarkDotNet for detailed performance analysis when needed

### Script-Based Testing
- Create .fsx test scripts for exploratory testing
- Use printfn for debugging and validation in test scripts
- Structure test scripts with clear validation logic and output

Remember: All tests should follow the project's functional programming principles and error handling patterns established in the repository instructions.
