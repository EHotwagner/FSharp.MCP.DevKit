# Multi-Agent GitHub Copilot Strategies

This directory contains strategies for implementing multiple specialized GitHub Copilot agents within a single repository, despite the current limitation of having only one `.github/copilot-instructions.md` file per repository.

## Overview

While GitHub Copilot currently supports only one instruction file per repository, we can achieve multi-agent behavior through several strategic approaches that simulate having different specialized agents for various development roles.

## Strategy Files

- [`role-based-instructions.md`](./role-based-instructions.md) - Using role sections in a single instruction file
- [`prompt-files-approach.md`](./prompt-files-approach.md) - VS Code prompt files for agent simulation
- [`context-switching.md`](./context-switching.md) - Dynamic role switching techniques
- [`implementation-guide.md`](./implementation-guide.md) - Step-by-step setup instructions

## Agent Roles

Our multi-agent strategy supports these specialized roles:

1. **Planner Agent** - Architecture and high-level design
2. **Implementer Agent** - Code implementation and development
3. **Tester Agent** - Testing strategies and quality assurance
4. **Fixer Agent** - Debugging and problem resolution
5. **Documenter Agent** - Documentation and knowledge management

## Quick Start

1. Read the [Implementation Guide](./implementation-guide.md) for setup instructions
2. Choose your preferred approach (role-based instructions or prompt files)
3. Customize the agent roles for your specific project needs
4. Test the agents with sample prompts

## Current Limitations

- GitHub Copilot supports only one instruction file per repository
- No native multi-agent orchestration
- Role persistence requires explicit prompting
- Agent memory is limited to conversation context

## Future Considerations

These strategies are designed to be forward-compatible with potential future GitHub Copilot features that may support native multi-agent functionality.
