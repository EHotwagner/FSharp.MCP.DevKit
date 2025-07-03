# Known Issues

This document tracks current known issues, bugs, and limitations in the FSharp.MCP.DevKit project.

## Active Issues

### High Priority

#### Documentation Generation Issues

**Issue:** `fake.core.commandlineparsing` fails to generate documentation
- **Status:** 🔍 Investigating
- **Priority:** High
- **Description:** This specific FAKE package has a unique F# compilation pattern that the documentation generator doesn't recognize
- **Affected Components:** Documentation generation system
- **Workaround:** None currently
- **Tracking:** First reported during FAKE packages documentation generation
- **Next Steps:** 
  - Analyze the assembly structure of fake.core.commandlineparsing
  - Identify the specific F# compilation patterns causing the failure
  - Extend the F# module detection logic

### Medium Priority

#### Performance Issues

**Issue:** Large assembly documentation generation is slow
- **Status:** 📋 Acknowledged
- **Priority:** Medium
- **Description:** Documentation generation for large assemblies (>1000 types) can take several minutes
- **Affected Components:** DocGenerator.fs
- **Workaround:** Generate documentation in smaller batches
- **Next Steps:**
  - Profile the documentation generation process
  - Implement parallel processing for type analysis
  - Add progress reporting for long-running operations

#### Code Editing Limitations

**Issue:** Limited support for advanced F# syntax
- **Status:** 📋 Planned
- **Priority:** Medium
- **Description:** Some advanced F# features (computation expressions, type providers) have limited analysis support
- **Affected Components:** FSharpCodeEditing.fs, SmartSymbolDetectionService
- **Next Steps:** Planned for v1.2.0 milestone

### Low Priority

#### Minor UI/UX Issues

**Issue:** Namespace overview files could show package origins
- **Status:** 💡 Enhancement
- **Priority:** Low
- **Description:** When viewing namespace overviews, it would be helpful to see which package each type comes from
- **Affected Components:** Documentation generation templates
- **Next Steps:** Consider for future UI improvements

## Resolved Issues

### ✅ Fixed in Recent Updates

#### Duplicate Types in Namespace Overviews
- **Status:** ✅ Fixed
- **Description:** Namespace overview files were showing duplicate type entries when types appeared in multiple assemblies
- **Resolution:** Implemented deduplication logic in namespace generation
- **Fixed in:** Recent documentation generator updates

#### Incorrect Pluralization in Type Counts
- **Status:** ✅ Fixed  
- **Description:** Type count summaries showed "Classs" instead of "Classes"
- **Resolution:** Fixed pluralization logic in type counting
- **Fixed in:** Recent documentation generator updates

## Reporting New Issues

### How to Report

1. **Check this list first** to see if the issue is already known
2. **Search the documentation** for existing workarounds
3. **Create a detailed report** including:
   - Steps to reproduce
   - Expected vs. actual behavior
   - Environment details (F# version, .NET version)
   - Sample code or assembly names if applicable

### Issue Templates

#### Bug Report Template
```
**Summary:** Brief description of the issue

**Steps to Reproduce:**
1. 
2. 
3. 

**Expected Behavior:** 
What should happen

**Actual Behavior:** 
What actually happens

**Environment:**
- F# Version: 
- .NET Version: 
- MCP DevKit Version: 

**Additional Context:**
Any other relevant information
```

#### Feature Request Template
```
**Summary:** Brief description of the requested feature

**Use Case:** 
Why is this feature needed?

**Proposed Solution:** 
How should this work?

**Alternatives Considered:** 
Other approaches that were considered

**Additional Context:**
Any other relevant information
```

## Issue Priority Levels

- 🔥 **Critical:** Blocking core functionality
- ⚠️ **High:** Significant impact on primary features  
- 📋 **Medium:** Moderate impact or affects secondary features
- 💡 **Low:** Minor issues or enhancements
- 🔍 **Investigating:** Currently being analyzed
- ✅ **Fixed:** Resolved and verified
