# NoComparisonAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.NoComparisonAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a type indicates it is a type where comparison is an abnormal operation.
 This means that the type does not satisfy the F# 'comparison' constraint. Within the bounds of the 
 F# type system, this helps ensure that the F# generic comparison function is not instantiated directly
 at this type. The attribute and checking does not constrain the use of comparison with base or child 
 types of this type.