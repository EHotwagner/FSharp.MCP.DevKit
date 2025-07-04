# Documentation Instructions for F# MCP DevKit

## File Patterns
- **/docs/**
- **/*.md
- **/*.fs (for XML documentation)

## Documentation Guidelines

When working with documentation in this F# project:

### XML Documentation
- Add XML documentation to all public APIs
- Include `<summary>`, `<param>`, and `<returns>` tags
- Document exceptions that may be thrown
- Provide code examples for complex APIs

### Markdown Documentation
- Use clear, descriptive headings
- Include code examples with proper F# syntax highlighting
- Structure content with logical flow and scannable sections
- Link to related documentation and external resources

### API Documentation
- Document function signatures and their purposes
- Explain F# specific concepts (computation expressions, active patterns, etc.)
- Include examples showing typical usage patterns
- Document error handling patterns and Result types

### Architecture Documentation
- Use diagrams to illustrate system design
- Document module dependencies and boundaries
- Explain design decisions and trade-offs made
- Include migration guides for breaking changes

### User Guides
- Write step-by-step instructions
- Include prerequisite information
- Provide troubleshooting sections
- Use practical, working examples

### README Files
- Start with clear project description and purpose
- Include quick start instructions
- List prerequisites and installation steps
- Provide links to detailed documentation

### Code Comments
- Use comments to explain "why" not "what"
- Document complex algorithms and business logic
- Explain F# specific patterns when they might be unfamiliar
- Keep comments concise and up-to-date

### F# Specific Documentation
- Explain computation expressions and their usage
- Document active patterns and when to use them
- Show functional composition patterns
- Demonstrate error handling with Result types

Remember: Documentation should reflect the project's functional programming approach and help developers understand both the "what" and "why" of the codebase.
