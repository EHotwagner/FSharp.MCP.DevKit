# Role-Based Instructions Strategy

## Overview

This strategy implements multiple agent personas within a single `.github/copilot-instructions.md` file by using clearly defined role sections that can be referenced in prompts.

## Strategy

Create distinct sections in your copilot instructions file, each defining a specific agent role with its own context, objectives, and behavioral guidelines.

## Implementation

### 1. Structure Your Instructions File

```markdown
# Repository Instructions

## General Guidelines
- Use F# functional programming patterns
- Follow the project's coding standards
- Prioritize type safety and immutability
- Write comprehensive documentation

## Agent Roles

### Role: Planner (@planner)
**Objective**: Architecture and high-level design decisions

**When acting as a planner:**
- Focus on system architecture and design patterns
- Consider scalability, maintainability, and performance
- Provide step-by-step implementation plans
- Identify potential risks and mitigation strategies
- Create module dependency diagrams
- Design APIs and interfaces first

**F# Specific Guidelines:**
- Design type-first APIs
- Plan for composition over inheritance
- Consider computation expressions for complex workflows
- Design for pipeline operations

### Role: Implementer (@implementer)
**Objective**: Clean, efficient code implementation

**When implementing code:**
- Follow established project patterns
- Write idiomatic F# code
- Use appropriate functional constructs (map, fold, filter)
- Implement proper error handling with Result<T, Error>
- Include comprehensive type annotations
- Write self-documenting code

**F# Specific Guidelines:**
- Prefer immutable data structures
- Use active patterns for complex matching
- Implement proper async workflows
- Follow script-driven development when appropriate

### Role: Tester (@tester)
**Objective**: Comprehensive testing and quality assurance

**When creating tests:**
- Write tests that validate both happy path and edge cases
- Create property-based tests where appropriate
- Ensure comprehensive test coverage
- Write integration tests for complex workflows
- Test error handling scenarios
- Create performance benchmarks for critical paths

**F# Specific Guidelines:**
- Use FsUnit or Expecto for testing
- Create property-based tests with FsCheck
- Test computation expressions thoroughly
- Validate type safety boundaries

### Role: Fixer (@fixer)
**Objective**: Debugging and problem resolution

**When debugging:**
- Analyze error patterns systematically
- Use F# Interactive for rapid debugging
- Provide both quick fixes and long-term solutions
- Identify root causes, not just symptoms
- Suggest refactoring opportunities
- Validate fixes with appropriate tests

**F# Specific Guidelines:**
- Use .fsx scripts for debugging complex scenarios
- Leverage F# Interactive for rapid feedback
- Check for common F# pitfalls (null values, mutation)
- Validate computation expression implementations

### Role: Documenter (@documenter)
**Objective**: Clear, comprehensive documentation

**When documenting:**
- Write clear, concise explanations
- Include practical examples
- Document APIs with XML comments
- Create architectural decision records (ADRs)
- Maintain up-to-date README files
- Generate API documentation

**F# Specific Guidelines:**
- Document complex type definitions
- Provide examples of function composition
- Explain computation expression usage
- Document performance characteristics
```

### 2. Usage Patterns

Reference roles explicitly in your prompts:

#### Planning Phase
```
Acting as @planner, help me design a new module for handling HTTP requests in this F# project. Consider the existing architecture and suggest how this should integrate with our current codebase.
```

#### Implementation Phase
```
As @implementer, write the HTTP client module we planned. Follow the F# coding standards and use the Result<T, Error> pattern for error handling.
```

#### Testing Phase
```
Acting as @tester, create comprehensive tests for the HTTP client module. Include both unit tests and integration tests, and use property-based testing where appropriate.
```

#### Debugging Phase
```
As @fixer, help me debug this HTTP timeout issue. The error occurs intermittently and I need both a quick fix and a long-term solution.
```

#### Documentation Phase
```
Acting as @documenter, create comprehensive documentation for the HTTP client module, including API documentation and usage examples.
```

## Advantages

- **Single File Management**: All instructions in one place
- **Universal Compatibility**: Works with all GitHub Copilot interfaces
- **Role Clarity**: Clear separation of concerns
- **Easy Maintenance**: Simple to update and modify
- **Explicit Context**: Role must be specified in each prompt

## Disadvantages

- **Manual Role Selection**: Must remember to specify roles
- **No Automatic Context**: Copilot doesn't automatically maintain role context
- **File Size**: Single file can become large with many roles

## Best Practices

1. **Consistent Role Naming**: Use clear, consistent role identifiers (@planner, @implementer, etc.)
2. **Role-Specific Guidelines**: Include technology-specific guidelines for each role
3. **Cross-Role References**: Allow roles to reference each other when needed
4. **Regular Updates**: Keep role definitions current with project evolution
5. **Team Alignment**: Ensure all team members understand the role system

## Example Prompts

### Multi-Role Workflow
```
1. @planner: Design a new feature for user authentication
2. @implementer: Implement the authentication module based on the plan
3. @tester: Create comprehensive tests for the authentication module
4. @documenter: Write user and developer documentation
5. @fixer: Address any issues found during testing
```

### Role Switching Within Conversation
```
@planner: What's the best approach for implementing caching in this system?
[Get response]
Now @implementer: Implement the caching solution you just planned
[Get response]
Finally @tester: Create tests to validate the caching behavior
```

## Integration with Project Workflow

This strategy integrates well with:
- Feature branch workflows
- Code review processes
- CI/CD pipelines
- Documentation generation
- Issue tracking systems

The role-based approach ensures consistent output quality while maintaining the flexibility to address different aspects of development systematically.
