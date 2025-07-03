# EntryPointAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.EntryPointAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a function indicates it is the entrypoint for an application.
 If this attribute is not specified for an EXE then the initialization implicit in the
 module bindings in the last file in the compilation sequence are used as the entrypoint.