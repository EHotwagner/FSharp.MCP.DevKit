# EventId Struct

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.EventId`
- **Base Type:** `System.ValueType`
- **Implements:** `System.IEquatable`1[[Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.Abstractions, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60]]`

Identifies a logging event. The primary identifier is the "Id" property, with the "Name" property providing a short description of this type of event.

## Methods

### op_Implicit (static)

**Signature:** `Microsoft.Extensions.Logging.EventId op_Implicit(Int32)`
**Return Type:** `EventId`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### op_Equality (static)

**Signature:** `Boolean op_Equality(Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.EventId)`
**Return Type:** `Boolean`

**Description:** Checks if two specified  instances have the same value. They are equal if they have the same Id.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `EventId` | No | `` | The first . |
| `right` | `EventId` | No | `` | The second . |

**Returns:** if the objects are equal.

---

### op_Inequality (static)

**Signature:** `Boolean op_Inequality(Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.EventId)`
**Return Type:** `Boolean`

**Description:** Checks if two specified  instances have different values.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `EventId` | No | `` | The first . |
| `right` | `EventId` | No | `` | The second . |

**Returns:** if the objects are not equal.

---

### get_Id

**Signature:** `Int32 get_Id()`
**Return Type:** `Int32`

---

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Microsoft.Extensions.Logging.EventId)`
**Return Type:** `Boolean`

**Description:** Indicates whether the current object is equal to another object of the same type. Two events are equal if they have the same id.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `other` | `EventId` | No | `` | An object to compare with this object. |

**Returns:** if the current object is equal to the other parameter; otherwise, .

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

## Properties

### Id

**Type:** `Int32` (read-only)

**Description:** Gets the numeric identifier for this event.

---

### Name

**Type:** `String` (read-only)

**Description:** Gets the name of this event.

---