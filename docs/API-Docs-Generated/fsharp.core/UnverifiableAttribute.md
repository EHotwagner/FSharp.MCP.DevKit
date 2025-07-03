# UnverifiableAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.UnverifiableAttribute`
- **Base Type:** `System.Attribute`

This attribute is used to tag values whose use will result in the generation
 of unverifiable code. These values are inevitably marked 'inline' to ensure that
 the unverifiable constructs are not present in the actual code for the F# library,
 but are rather copied to the source code of the caller.