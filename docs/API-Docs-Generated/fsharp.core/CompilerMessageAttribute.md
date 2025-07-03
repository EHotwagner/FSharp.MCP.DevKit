# CompilerMessageAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.CompilerMessageAttribute`
- **Base Type:** `System.Attribute`

Indicates that a message should be emitted when F# source code uses this construct.

## Methods

### get_Message

**Signature:** `System.String get_Message()`
**Return Type:** `String`

---

### get_MessageNumber

**Signature:** `Int32 get_MessageNumber()`
**Return Type:** `Int32`

---

### get_IsError

**Signature:** `Boolean get_IsError()`
**Return Type:** `Boolean`

---

### set_IsError

**Signature:** `Void set_IsError(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_IsHidden

**Signature:** `Boolean get_IsHidden()`
**Return Type:** `Boolean`

---

### set_IsHidden

**Signature:** `Void set_IsHidden(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

## Properties

### Message

**Type:** `String` (read-only)

**Description:** Indicates the warning message to be emitted when F# source code uses this construct

---

### MessageNumber

**Type:** `Int32` (read-only)

**Description:** Indicates the number associated with the message.

---

### IsError

**Type:** `Boolean` (read/write)

**Description:** Indicates if the message should indicate a compiler error. Error numbers less than
 10000 are considered reserved for use by the F# compiler and libraries.

---

### IsHidden

**Type:** `Boolean` (read/write)

**Description:** Indicates if the construct should always be hidden in an editing environment.

---