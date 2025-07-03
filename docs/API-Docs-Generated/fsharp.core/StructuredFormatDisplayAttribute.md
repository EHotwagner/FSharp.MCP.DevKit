# StructuredFormatDisplayAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.StructuredFormatDisplayAttribute`
- **Base Type:** `System.Attribute`

This attribute is used to mark how a type is displayed by default when using 
 '%A' printf formatting patterns and other two-dimensional text-based display layouts. 
 In this version of F# valid values are of the form PreText {PropertyName1} PostText {PropertyName2} ... {PropertyNameX} PostText.
 The property names indicate properties to evaluate and to display instead of the object itself.

## Methods

### get_Value

**Signature:** `System.String get_Value()`
**Return Type:** `String`

---

## Properties

### Value

**Type:** `String` (read-only)

**Description:** Indicates the text to display by default when objects of this type are displayed 
 using '%A' printf formatting patterns and other two-dimensional text-based display 
 layouts.

---