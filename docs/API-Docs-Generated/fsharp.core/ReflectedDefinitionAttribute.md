# ReflectedDefinitionAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.ReflectedDefinitionAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to the let-binding for the definition of a top-level 
 value makes the quotation expression that implements the value available
 for use at runtime.

## Methods

### get_IncludeValue

**Signature:** `Boolean get_IncludeValue()`
**Return Type:** `Boolean`

---

## Properties

### IncludeValue

**Type:** `Boolean` (read-only)

**Description:** The value of the attribute, indicating whether to include the evaluated value of the definition as the outer node of the quotation

---