# IJsonLineInfo Interface

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.IJsonLineInfo`

Provides an interface to enable a class to return line and position information.

## Methods

### HasLineInfo

**Signature:** `Boolean HasLineInfo()`
**Return Type:** `Boolean`

**Description:** Gets a value indicating whether the class can return line information.

**Returns:** true if LineNumber and LinePosition can be provided; otherwise, false.

---

### get_LineNumber

**Signature:** `Int32 get_LineNumber()`
**Return Type:** `Int32`

---

### get_LinePosition

**Signature:** `Int32 get_LinePosition()`
**Return Type:** `Int32`

---

## Properties

### LineNumber

**Type:** `Int32` (read-only)

**Description:** Gets the current line number.

---

### LinePosition

**Type:** `Int32` (read-only)

**Description:** Gets the current line position.

---