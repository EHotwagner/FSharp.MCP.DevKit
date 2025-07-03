# CompilationRepresentationAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.CompilationRepresentationAttribute`
- **Base Type:** `System.Attribute`

This attribute is used to adjust the runtime representation for a type. 
 For example, it may be used to note that the null representation
 may be used for a type. This affects how some constructs are compiled.

## Methods

### get_Flags

**Signature:** `Microsoft.FSharp.Core.CompilationRepresentationFlags get_Flags()`
**Return Type:** `CompilationRepresentationFlags`

---

## Properties

### Flags

**Type:** `CompilationRepresentationFlags` (read-only)

**Description:** Indicates one or more adjustments to the compiled representation of an F# type or member

---