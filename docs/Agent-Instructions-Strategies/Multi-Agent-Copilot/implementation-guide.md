# Multi-Agent Copilot Implementation Guide

## Quick Decision Matrix

| Use Case | Recommended Strategy | Setup Time | Complexity |
|----------|---------------------|------------|------------|
| Single developer, quick start | Role-Based Instructions | 5 minutes | Low |
| VS Code team, specialized workflows | Prompt Files | 15 minutes | Medium |
| Complex projects, dynamic needs | Context Switching | Variable | High |
| Large teams, mixed environments | Hybrid Approach | 30 minutes | Medium |

## Understanding Context Layering

**Critical Concept**: All strategies work WITH your `.github/copilot-instructions.md`, not AGAINST it.

### How GitHub Copilot Combines Context:

```
Final AI Context = Repository Instructions + Additional Layers + Chat Context
```

#### Layer Stack (from bottom to top):
1. **Repository Instructions** (`.github/copilot-instructions.md`) - Foundation
2. **Instructions Files** (`.github/instructions/*.instructions.md`) - Conditional
3. **Prompt Files** (`.github/prompts/*.prompt.md`) - Task-specific  
4. **Personal Instructions** (VS Code user settings) - User preferences
5. **Direct Chat Context** - Immediate conversation

### Why This Matters:
- Your F# project standards are ALWAYS active
- Agent specializations ADD focus, don't REPLACE foundations
- Consistent coding patterns across all roles
- No loss of project-specific context

## Strategy 1: Role-Based Instructions (Recommended Start)

### Step 1: Enhance Your Existing Instructions

Edit `.github/copilot-instructions.md` to add role-based sections:

```markdown
# F# MCP DevKit - Copilot Instructions

## Core Principles
[Your existing core principles here]

## Role-Based Instructions

### @planner Role
When acting as @planner, focus on:
- System architecture and high-level design
- Module organization and boundaries
- API surface design and contracts
- Integration patterns and dependencies

### @implementer Role  
When acting as @implementer, focus on:
- Writing clean, functional F# code
- Following established patterns
- Implementing robust error handling
- Creating maintainable, testable code

### @tester Role
When acting as @tester, focus on:
- Property-based testing with FsCheck
- Unit testing with NUnit or xUnit
- Integration testing strategies
- Test-driven development patterns

### @fixer Role
When acting as @fixer, focus on:
- Debugging F# code issues
- Performance optimization
- Error analysis and resolution
- Refactoring for maintainability

### @documenter Role
When acting as @documenter, focus on:
- XML documentation for APIs
- README and guide creation
- Code examples and tutorials
- Architecture documentation
```

### Step 2: Usage Examples

```markdown
"@planner: Design a caching layer for our F# HTTP client"
"@implementer: Based on that plan, create the cache implementation"
"@tester: Create comprehensive tests for the caching functionality"
"@fixer: The cache is not invalidating properly, help debug this issue"
```

### Advantages:
- ✅ Single file to maintain
- ✅ Works in all environments
- ✅ Quick setup
- ✅ Preserves all project context

### Disadvantages:
- ❌ Single large instruction file
- ❌ Less specialized than dedicated prompts
- ❌ Role switching requires explicit mentions

## Strategy 2: VS Code Prompt Files (Advanced)

### Step 1: Verify VS Code Setup

Ensure you have VS Code Insiders or VS Code with the GitHub Copilot Chat extension that supports prompt files.

### Step 2: Enable Prompt Files

Create or update `.vscode/settings.json`:

```json
{
  "chat.promptFiles": true,
  "chat.promptFilesLocations": [".github/prompts"],
  "chat.instructionsFilesLocations": [".github/instructions"]
}
```

### Step 3: Create Prompt Directory

```powershell
mkdir .github\prompts
```

### Step 4: Create Specialized Prompt Files

#### .github/prompts/planner.prompt.md
```markdown
You are an expert F# system architect and planner.

## Your Role
Focus on high-level design, architecture decisions, and planning implementation strategies.

## Specializations
- F# module organization and boundaries
- Functional programming patterns and composition
- API design with F# type system
- Integration patterns and dependency management
- Performance considerations for F# applications

## Output Style
- Provide clear architectural decisions with rationales
- Design modular, composable solutions
- Consider functional programming principles
- Plan for testability and maintainability
- Use F# idioms and patterns

Remember: You inherit all project patterns from the repository instructions. Build upon that foundation with your architectural expertise.
```

#### .github/prompts/implementer.prompt.md
```markdown
You are an expert F# developer focused on clean, functional implementation.

## Your Role
Transform plans and designs into robust, maintainable F# code.

## Implementation Focus
- Write idiomatic F# code following functional principles
- Use proper error handling with Result<T, Error> types
- Implement async workflows and computation expressions
- Follow script-driven development patterns
- Create composable, testable functions

## Code Quality Standards
- Prefer immutability and pure functions
- Use pattern matching effectively
- Implement proper type safety
- Write self-documenting code with clear naming
- Follow established project patterns

Remember: You inherit all project coding standards. Focus on translating designs into high-quality F# code.
```

#### .github/prompts/tester.prompt.md
```markdown
You are an expert F# testing specialist.

## Your Role
Design and implement comprehensive testing strategies for F# applications.

## Testing Expertise
- Property-based testing with FsCheck
- Unit testing with NUnit/xUnit in F#
- Integration testing patterns
- F# test data generation and setup
- Testing async workflows and computation expressions

## Testing Approach
- Design tests that validate behavior, not implementation
- Create comprehensive property-based tests
- Test error handling and edge cases
- Ensure tests are maintainable and readable
- Use F# testing idioms and patterns

Remember: You inherit all project patterns. Apply testing best practices to the established codebase patterns.
```

#### .github/prompts/fixer.prompt.md
```markdown
You are an expert F# debugging and optimization specialist.

## Your Role
Diagnose, debug, and fix issues in F# codebases with focus on maintainable solutions.

## Debugging Expertise
- F# compiler error interpretation and resolution
- Performance analysis and optimization
- Memory usage and garbage collection issues
- Async workflow debugging and deadlock resolution
- Type inference and constraint solving

## Problem-Solving Approach
- Systematic root cause analysis
- Minimal, targeted fixes that preserve existing functionality
- Performance improvements without sacrificing readability
- Refactoring that improves maintainability
- Documentation of fixes and prevention strategies

Remember: You inherit all project patterns. Apply debugging expertise within the established architectural and coding patterns.
```

#### .github/prompts/documenter.prompt.md
```markdown
You are an expert technical writer specialized in F# documentation.

## Your Role
Create clear, comprehensive documentation for F# projects and APIs.

## Documentation Expertise
- F# XML documentation and API docs
- Tutorial and guide writing for F# developers
- Code examples that demonstrate best practices
- Architecture documentation and decision records
- User-facing documentation and README files

## Documentation Standards
- Use clear, concise language
- Provide practical code examples
- Include error handling and edge cases
- Document rationale behind design decisions
- Create scannable, well-structured content

Remember: You inherit all project context. Document the established patterns and help users understand how to work within the project's architectural decisions.
```

### Step 5: Usage Examples

```markdown
"/planner Design a real-time notification system for our F# application"
"/implementer Create the HTTP client wrapper we planned"
"/tester Write property-based tests for the Result monad utilities"
"/fixer Debug this performance issue in our async workflow"
"/documenter Create API documentation for our core modules"
```

### Advantages:
- ✅ Highly specialized prompts
- ✅ Clean, focused interactions
- ✅ Reusable across team
- ✅ Preserves base project context

### Disadvantages:
- ❌ VS Code specific
- ❌ More files to maintain
- ❌ Requires team training

## Strategy 3: Context Switching (Expert)

### When to Use
- Complex, evolving requirements
- Long development sessions
- Research and exploration phases
- When you need maximum flexibility

### Step 1: Establish Context Patterns

Create conversation templates for common workflows:

#### Feature Development Template
```markdown
# Feature: [Name]

## Context Anchor
Project: F# MCP DevKit
Architecture: [Current architectural decisions]
Patterns: [Established patterns in use]

## Planning Phase (@planner)
**Objective**: [Clear objective]
**Constraints**: [Technical/business constraints]

[Planning work here]

---

## Implementation Phase (@implementer)  
**Based on plan above**
**Current focus**: [Specific implementation area]

[Implementation work here]

---

## Testing Phase (@tester)
**Testing scope**: [What we're testing]
**Approach**: [Testing strategy]

[Testing work here]
```

### Step 2: Use Transition Protocols

```markdown
"Context transition: @planner → @implementer
Key decisions from planning: [Summary]
Now implementing: [Specific component]
Maintaining: [Context to preserve]"
```

### Advantages:
- ✅ Maximum flexibility
- ✅ Rich context building
- ✅ Works everywhere
- ✅ Dynamic adaptation

### Disadvantages:
- ❌ Requires discipline
- ❌ Manual context management
- ❌ Risk of context loss

## Hybrid Approach (Recommended for Teams)

### Combine Multiple Strategies

1. **Foundation**: Role-based instructions in `.github/copilot-instructions.md`
2. **VS Code Users**: Add prompt files for specialized workflows
3. **Complex Sessions**: Use context switching for deep work

### Implementation Steps

1. **Week 1**: Implement role-based instructions
2. **Week 2**: Add prompt files for VS Code users
3. **Week 3**: Train team on context switching
4. **Week 4**: Establish team patterns and best practices

## Troubleshooting

### Common Issues

#### "Roles Not Being Recognized"
**Problem**: AI doesn't seem to follow role instructions
**Solutions**:
- Make role mentions more explicit: "You are now acting as @planner"
- Add context: "As @planner, focus on architecture decisions"
- Check that instructions are clear and specific

#### "Context Loss in Long Conversations"
**Problem**: AI forgets previous context or role
**Solutions**:
- Use context anchors: "Context: We're building X using Y pattern"
- Summarize key decisions periodically
- Start new conversations for major context shifts

#### "Prompt Files Not Working"
**Problem**: `/planner` commands not recognized
**Solutions**:
- Verify VS Code version supports prompt files
- Check `.vscode/settings.json` configuration
- Ensure prompt files are in correct directory
- Restart VS Code after configuration changes

#### "Inconsistent Behavior Across Team"
**Problem**: Different team members get different results
**Solutions**:
- Standardize on repository instructions first
- Ensure everyone uses same VS Code settings
- Create team training materials
- Establish common patterns and examples

### Validation Tests

#### Test Role Recognition
```markdown
"@planner: What would you focus on for this project?"
Expected: Architecture and design response

"@implementer: How would you approach this task?"
Expected: Implementation-focused response
```

#### Test Context Preservation
```markdown
"Context: F# HTTP client library using Result<T,Error>
@planner: Design the error handling strategy
@implementer: Now implement based on that design"
Expected: Implementation that builds on planning decisions
```

## Team Adoption

### Training Plan

#### Week 1: Foundation
- [ ] Install role-based instructions
- [ ] Practice basic role commands
- [ ] Establish team conventions

#### Week 2: Specialization
- [ ] Set up prompt files (VS Code users)
- [ ] Practice specialized workflows
- [ ] Create team-specific examples

#### Week 3: Advanced Techniques
- [ ] Learn context switching
- [ ] Practice complex multi-role scenarios
- [ ] Develop team patterns

#### Week 4: Optimization
- [ ] Refine based on experience
- [ ] Document team patterns
- [ ] Establish maintenance processes

### Success Metrics

- **Adoption Rate**: % of team using role-based interactions
- **Quality Improvement**: Better code/design quality in reviews
- **Efficiency Gains**: Faster development cycles
- **Consistency**: More consistent patterns across team output

## Maintenance

### Regular Tasks

#### Monthly Review
- [ ] Update role descriptions based on team feedback
- [ ] Add new roles as needed
- [ ] Refine prompt files
- [ ] Update examples and templates

#### Quarterly Assessment
- [ ] Evaluate strategy effectiveness
- [ ] Gather team feedback
- [ ] Plan improvements
- [ ] Update training materials

### Evolution Path

1. **Start Simple**: Role-based instructions
2. **Add Specialization**: Prompt files for power users
3. **Increase Sophistication**: Context switching for complex work
4. **Optimize**: Team-specific customizations
5. **Scale**: Share patterns across organization

This implementation guide provides a complete roadmap for implementing multi-agent GitHub Copilot strategies while maintaining your project's foundational patterns and standards.
