# Context Switching Strategy

## Overview

This strategy provides dynamic role switching techniques that allow seamless transitions between different agent personas within a single conversation, maximizing the flexibility of GitHub Copilot's single instruction file limitation.

## Core Concept

Instead of having separate agents, use context switching cues and conversation management techniques to dynamically change the AI's focus and behavior during interactions.

## Implementation Strategies

### 1. Conversation State Management

Use explicit state declarations to maintain context across role switches:

```
Current Context: @planner
Working on: User Authentication System
Previous Decisions: [List key decisions made]
Next Phase: Implementation

[Your planning request here]
```

### 2. Role Transition Protocols

#### Smooth Transitions
```
@planner → @implementer transition:
"Based on the plan we just created, now switching to @implementer mode to begin implementation. Key requirements from planning phase: [summary]"
```

#### Context Preservation
```
"Maintaining context from @tester role: We identified 3 critical test scenarios. Now as @fixer, let's address the bug found in scenario 2."
```

### 3. Multi-Role Conversations

#### Sequential Role Usage
```
Session 1: @planner
- Design the authentication system
- Identify key components
- Plan implementation phases

Session 2: @implementer
- Implement User model
- Create authentication service
- Set up middleware

Session 3: @tester
- Create unit tests
- Design integration tests
- Plan performance tests

Session 4: @fixer
- Address test failures
- Optimize performance issues
- Refactor based on learnings
```

#### Collaborative Role Usage
```
"I need @planner and @implementer to work together:
1. @planner: Assess the current architecture for adding real-time notifications
2. @implementer: Once we have the plan, implement the solution with proper error handling"
```

## Context Management Techniques

### 1. Conversation Templates

#### Feature Development Template
```markdown
# Feature: [Feature Name]

## Planning Phase (@planner)
**Objective**: [What we're building]
**Constraints**: [Technical/business constraints]
**Success Criteria**: [How we measure success]

### Architecture Analysis
- Current system state
- Integration points
- Dependencies

### Implementation Plan
- Phase 1: [Description]
- Phase 2: [Description]  
- Phase 3: [Description]

---

## Implementation Phase (@implementer)
**Based on plan above**
**Current Phase**: [Which phase we're implementing]

### Implementation Notes
- Key patterns to follow
- Error handling strategy
- Performance considerations

---

## Testing Phase (@tester)
**Testing scope**: [What we're testing]
**Test types needed**: [Unit/Integration/Performance]

### Test Strategy
- Happy path scenarios
- Edge cases
- Error conditions

---

## Documentation Phase (@documenter)
**Documentation scope**: [What needs documenting]
**Audience**: [Who will read this]

### Documentation Plan
- API documentation
- User guides
- Developer notes
```

#### Bug Fix Template
```markdown
# Bug Fix: [Issue Description]

## Analysis Phase (@fixer)
**Problem**: [Clear problem statement]
**Impact**: [Who/what is affected]
**Timeline**: [When did this start]

### Investigation Notes
- Steps to reproduce
- Error messages/logs
- Affected components

### Root Cause Analysis
- Primary cause
- Contributing factors
- Why wasn't this caught earlier

---

## Solution Phase (@implementer)
**Fix Strategy**: [Approach to fixing]
**Risk Assessment**: [Potential side effects]

### Implementation Plan
- Quick fix (if needed)
- Proper fix
- Prevention measures

---

## Validation Phase (@tester)
**Test Plan**: [How to verify the fix]
**Regression Testing**: [What else to test]

### Validation Checklist
- [ ] Original issue resolved
- [ ] No new regressions
- [ ] Performance impact acceptable
- [ ] Documentation updated
```

### 2. State Preservation Patterns

#### Context Anchoring
```
"Context Anchor: We're building a HTTP client library for the F# MCP DevKit.
Key decisions: Using Result<T, Error> for error handling, HttpClient as base, async workflows.

@implementer: Now implement the core HttpClient wrapper class based on these decisions."
```

#### Decision Trail
```
"Decision Trail:
1. @planner decided: Use Repository pattern for data access
2. @implementer implemented: Basic repository with CRUD operations  
3. @tester found: Performance issues with large datasets
4. @fixer (current): Need to optimize query performance

Current task: Implement pagination and caching for large datasets"
```

## Dynamic Role Selection

### 1. Automatic Role Inference

Train yourself to use context cues that naturally lead to role-appropriate responses:

#### Planning Context Cues
```
"What's the best architecture for..."
"How should we structure..."
"What are the trade-offs between..."
"Design a system that..."
```

#### Implementation Context Cues
```
"Write the code for..."
"Implement the function that..."
"Create a module that..."
"Here's the interface, now implement..."
```

#### Testing Context Cues
```
"Create tests for..."
"How do we validate..."
"What edge cases should we consider..."
"Write property-based tests for..."
```

#### Fixing Context Cues
```
"This code is failing because..."
"Debug this issue..."
"Why is this not working..."
"Optimize this performance problem..."
```

### 2. Explicit Role Switching

#### Mid-Conversation Switches
```
"We've finished the planning phase. Let me switch to @implementer mode and start coding the solution we just designed."
```

#### Conditional Switches
```
"If the implementation works correctly, switch to @tester mode to create tests. If there are issues, switch to @fixer mode to debug."
```

## Advanced Context Techniques

### 1. Multi-Agent Simulation

Simulate conversations between different roles:

```
"Let's simulate a design review:

@planner: 'I propose we use a microservices architecture for this feature.'

@implementer: 'That adds complexity. Can we achieve the same goals with a modular monolith?'

@tester: 'How will we test the integration points in either approach?'

@fixer: 'What are the debugging implications of each choice?'

Now synthesize these perspectives and recommend the best approach."
```

### 2. Role Perspective Analysis

```
"Analyze this code from multiple perspectives:

@implementer perspective: Is the code clean and maintainable?
@tester perspective: Is it testable and robust?
@fixer perspective: What could go wrong and how would we debug it?
@documenter perspective: Is it self-documenting and clear?

Provide insights from each perspective."
```

## Conversation Flow Patterns

### 1. Linear Flow
```
@planner → @implementer → @tester → @documenter → @fixer (if needed)
```

### 2. Iterative Flow
```
@planner → @implementer → @tester → @fixer → @implementer → @tester → @documenter
```

### 3. Parallel Flow
```
@planner creates architecture
├── @implementer works on core components
├── @tester designs test strategy  
└── @documenter outlines documentation structure
```

## Best Practices

### 1. Clear Role Declarations
Always explicitly state when switching roles:
```
"Switching to @tester mode to evaluate the implementation we just completed."
```

### 2. Context Preservation
Summarize important context when switching:
```
"Key context from @planner phase: We decided on Event Sourcing pattern with CQRS. Now as @implementer, let's build the event store."
```

### 3. Conversation Continuity
Reference previous role decisions:
```
"Building on the @planner's architecture decision to use F# Computation Expressions, let's implement the workflow as @implementer."
```

### 4. State Validation
Periodically confirm context understanding:
```
"Before we continue with @implementer role, let me confirm: We're building a HTTP client library with Result<T,Error> error handling, correct?"
```

## Tools and Techniques

### 1. Conversation Bookmarks
```
"Bookmark: Authentication Module - Planning Complete
- Requirements: OAuth 2.0, JWT tokens, refresh mechanism
- Architecture: Service-based with dependency injection
- Next: Implementation phase with @implementer"
```

### 2. Decision Records
```
"ADR-001: @planner decided to use Railway-oriented programming for error handling
Rationale: Better composability and explicit error handling
Impact: All functions return Result<T, Error>
Status: Approved, ready for @implementer"
```

### 3. Progress Tracking
```
"Progress Update:
✅ @planner: Architecture defined
✅ @implementer: Core module implemented  
🔄 @tester: Currently creating unit tests
⏳ @documenter: Waiting for implementation completion
⏳ @fixer: On standby for any issues"
```

## Advantages

- **Single Conversation Flow**: No need to start new chats
- **Rich Context**: Builds complex context over time
- **Flexible Switching**: Can adapt to changing needs
- **Universal Compatibility**: Works with any GitHub Copilot interface

## Disadvantages

- **Manual Management**: Requires discipline to maintain context
- **Context Loss**: Risk of losing context in long conversations
- **Cognitive Load**: More complex to manage than simple role assignment

## Integration Tips

1. **Combine with Role-Based Instructions**: Use context switching with your instruction file roles
2. **Document Patterns**: Create templates for common conversation flows
3. **Practice Consistency**: Develop team standards for context switching
4. **Review and Refine**: Regularly evaluate which patterns work best

This strategy provides maximum flexibility while working within GitHub Copilot's current limitations, enabling sophisticated multi-agent workflows through careful conversation management.
