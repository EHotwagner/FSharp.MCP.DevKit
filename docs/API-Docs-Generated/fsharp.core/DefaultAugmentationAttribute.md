# DefaultAugmentationAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.DefaultAugmentationAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a discriminated union with value false
 turns off the generation of standard helper member tester, constructor 
 and accessor members for the generated CLI class for that type.

## Methods

### get_Value

**Signature:** `Boolean get_Value()`
**Return Type:** `Boolean`

---

## Properties

### Value

**Type:** `Boolean` (read-only)

**Description:** The value of the attribute, indicating whether the type has a default augmentation or not

---