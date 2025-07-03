# WarnOnWithoutNullArgumentAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.WarnOnWithoutNullArgumentAttribute`
- **Base Type:** `System.Attribute`

When used in a compilation with null-checking enabled, indicates that a function is meant to be used only with potentially-nullable values and warns accordingly.

## Methods

### get_WarningMessage

**Signature:** `System.String get_WarningMessage()`
**Return Type:** `String`

---

## Properties

### WarningMessage

**Type:** `String` (read-only)

**Description:** Warning message displayed when the annotated function is used with a value known to be without null

---