# ErrorContext Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ErrorContext`

Provides information surrounding an error.

## Methods

### get_Error

**Signature:** `System.Exception get_Error()`
**Return Type:** `Exception`

---

### get_OriginalObject

**Signature:** `System.Object get_OriginalObject()`
**Return Type:** `Object`

---

### get_Member

**Signature:** `System.Object get_Member()`
**Return Type:** `Object`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

### get_Handled

**Signature:** `Boolean get_Handled()`
**Return Type:** `Boolean`

---

### set_Handled

**Signature:** `Void set_Handled(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

## Properties

### Error

**Type:** `Exception` (read-only)

**Description:** Gets the error.

---

### OriginalObject

**Type:** `Object` (read-only)

**Description:** Gets the original object that caused the error.

---

### Member

**Type:** `Object` (read-only)

**Description:** Gets the member that caused the error.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the JSON location where the error occurred.

---

### Handled

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether this  is handled.

---