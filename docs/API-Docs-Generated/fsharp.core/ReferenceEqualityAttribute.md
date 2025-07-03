# ReferenceEqualityAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.ReferenceEqualityAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a record or union type disables the automatic generation
 of overrides for 'System.Object.Equals(obj)', 'System.Object.GetHashCode()' 
 and 'System.IComparable' for the type. The type will by default use reference equality.