# Contributing to FSharp.MCP.DevKit

Thank you for your interest in contributing to FSharp.MCP.DevKit! This document provides guidelines for contributing to the project.

## Getting Started

1. **Review the documentation:**
   - [README.md](README.md) - Project overview
   - [docs/Features.md](docs/Features.md) - Current features
   - [docs/Architecture.md](docs/Architecture.md) - Technical architecture
   - [docs/ROADMAP.md](docs/ROADMAP.md) - Future plans
   - [docs/ISSUES.md](docs/ISSUES.md) - Known issues

2. **Set up your development environment:**
   - F# 6.0 or later
   - .NET 9.0 SDK
   - VS Code with F# support (recommended)

## How to Contribute

### Reporting Bugs

Before creating a bug report:
1. Check [docs/ISSUES.md](docs/ISSUES.md) for known issues
2. Search existing issues to avoid duplicates
3. Test with the latest version

Use the bug report template in [docs/ISSUES.md](docs/ISSUES.md#bug-report-template).

### Suggesting Features

Feature requests are welcome! Please:
1. Check the [roadmap](docs/ROADMAP.md) to see if it's already planned
2. Open a discussion about the feature first
3. Use the feature request template in [docs/ISSUES.md](docs/ISSUES.md#feature-request-template)

### Code Contributions

#### Development Workflow

1. **Fork and clone** the repository
2. **Create a feature branch:** `git checkout -b feature/your-feature-name`
3. **Follow F# coding standards** (see below)
4. **Write tests** for new functionality
5. **Update documentation** as needed
6. **Test your changes** thoroughly
7. **Submit a pull request**

#### F# Coding Standards

Follow the project's F# coding guidelines:
- Use functional programming patterns
- Prefer immutable data structures
- Write small, focused functions
- Include type annotations for public APIs
- Follow the existing code style and conventions
- Add XML documentation comments for public functions

#### Testing

- Write unit tests for new functions
- Use F# test frameworks (e.g., Expecto, NUnit)
- Include integration tests for MCP tools
- Test with real F# code samples

#### Documentation

When contributing code, also update:
- API documentation (XML comments)
- User documentation in `docs/`
- Code examples if applicable
- README.md if adding new features

## Project Structure

```
├── src/
│   ├── FSharp.MCP.DevKit.Core/         # Core utilities
│   ├── FSharp.MCP.DevKit.Analysis/     # Code analysis
│   ├── FSharp.MCP.DevKit.CodeEditing/  # Code manipulation
│   ├── FSharp.MCP.DevKit.Documentation/ # Doc generation
│   ├── FSharp.MCP.DevKit.Communication/ # MCP communication
│   └── FSharp.MCP.DevKit.Server/       # MCP server
├── tests/                              # Unit tests
├── docs/                               # Documentation
├── examples/                           # Example scripts
└── Scripting/                          # Development scripts
```

## Development Guidelines

### MCP Tool Development

When creating new MCP tools:
1. Follow the existing naming convention: `mcp_fsharp-fsi-mc_*`
2. Include proper error handling and validation
3. Add timeout parameters where appropriate
4. Write comprehensive documentation
5. Include usage examples

### Documentation Generation

When working on documentation features:
1. Test with multiple package types (.NET, F#, mixed)
2. Verify namespace merging across assemblies
3. Check output formatting and readability
4. Test search functionality
5. Validate cross-references

### Code Quality

- **Format code** using Fantomas
- **Run tests** before submitting
- **Check for warnings** and address them
- **Profile performance** for critical paths
- **Handle errors gracefully**

## Pull Request Process

1. **Ensure your branch is up to date** with main
2. **Run all tests** and ensure they pass
3. **Update documentation** for any API changes
4. **Write a clear commit message** describing your changes
5. **Fill out the pull request template** completely
6. **Request review** from maintainers

### Pull Request Template

```
## Summary
Brief description of changes

## Type of Change
- [ ] Bug fix
- [ ] New feature
- [ ] Documentation update
- [ ] Performance improvement
- [ ] Code refactoring

## Testing
- [ ] Unit tests added/updated
- [ ] Integration tests pass
- [ ] Manual testing completed

## Documentation
- [ ] Code comments updated
- [ ] User documentation updated
- [ ] API documentation updated

## Checklist
- [ ] Code follows project style guidelines
- [ ] Self-review completed
- [ ] Tests pass locally
- [ ] No new warnings introduced
```

## Recognition

Contributors will be recognized in:
- Project README.md
- Release notes for significant contributions
- Documentation credits

## Questions?

- Check the [documentation](docs/)
- Look at [existing issues](docs/ISSUES.md)
- Start a discussion in the project repository

Thank you for contributing to FSharp.MCP.DevKit!
