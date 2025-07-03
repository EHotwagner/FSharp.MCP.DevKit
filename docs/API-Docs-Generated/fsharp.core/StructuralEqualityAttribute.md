# StructuralEqualityAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.StructuralEqualityAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a record, union or struct type confirms the automatic 
 generation of overrides for 'System.Object.Equals(obj)' and 
 'System.Object.GetHashCode()' for the type.