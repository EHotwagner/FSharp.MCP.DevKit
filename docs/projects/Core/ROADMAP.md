# Core Project Roadmap

## Overview

The Core project provides the foundational layer for the FSharp.MCP.DevKit, including FSI session management, configuration, and shared utilities.

## Current Status

**Version:** 1.0.0
**Status:** ✅ Stable Foundation

## Completed Features

### v1.0.0 - Foundation (Q1 2025)
- ✅ FSI session lifecycle management
- ✅ Configuration management
- ✅ Error handling utilities
- ✅ Logging infrastructure
- ✅ Session state tracking

## Planned Enhancements

### v1.1.0 - Performance & Reliability (Q2 2025)
**Status:** 📋 Planned

- 📋 **Session pooling** - Manage multiple FSI sessions for parallel operations
- 📋 **Health monitoring** - FSI session health checks and auto-recovery
- 📋 **Memory optimization** - Reduce memory footprint of long-running sessions
- 📋 **Configuration validation** - Enhanced validation for configuration settings
- 📋 **Metrics collection** - Performance metrics and usage statistics

### v1.2.0 - Advanced Session Management (Q3 2025)
**Status:** 📋 Future

- 📋 **Session isolation** - Better isolation between different operations
- 📋 **Custom FSI configurations** - Per-session custom compiler settings
- 📋 **Session persistence** - Save/restore session state across restarts
- 📋 **Plugin system** - Extensible plugin architecture for Core functionality
- 📋 **Multi-framework support** - Support for different .NET target frameworks

### v2.0.0 - Distributed Operations (Q4 2025)
**Status:** 📋 Future

- 📋 **Remote FSI sessions** - Manage FSI sessions on remote machines
- 📋 **Cluster coordination** - Coordinate multiple FSI instances
- 📋 **Load balancing** - Distribute operations across available sessions
- 📋 **Fault tolerance** - Graceful handling of session failures

## Known Issues

- 🐛 **Memory growth** - Long-running FSI sessions may experience memory growth
- 📋 **Session startup time** - Cold start of FSI sessions can be slow
- 💡 **Configuration complexity** - Current configuration system could be simplified

## Dependencies

- F# Compiler Services
- .NET 9.0 Runtime
- System.IO.Pipes (for communication)

## Impact on Other Projects

The Core project is foundational and affects:
- **Analysis**: Depends on FSI session management
- **CodeEditing**: Uses Core utilities and error handling
- **Communication**: Relies on Core configuration
- **Documentation**: Uses Core logging and error handling
- **Server**: Depends on Core session management and configuration
