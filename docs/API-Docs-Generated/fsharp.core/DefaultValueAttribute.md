# DefaultValueAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.DefaultValueAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a field declaration means that the field is 
 not initialized. During type checking a constraint is asserted that the field type supports 'null'. 
 If the 'check' value is false then the constraint is not asserted.

## Methods

### get_Check

**Signature:** `Boolean get_Check()`
**Return Type:** `Boolean`

---

## Properties

### Check

**Type:** `Boolean` (read-only)

**Description:** Indicates if a constraint is asserted that the field type supports 'null'

---