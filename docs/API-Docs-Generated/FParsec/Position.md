# Position Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.Position`
- **Implements:** `System.IEquatable`1[[FParsec.Position, FParsecCS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=40ccfc0a09edbb5d]]`, `System.IComparable`, `System.IComparable`1[[FParsec.Position, FParsecCS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=40ccfc0a09edbb5d]]`

## Methods

### get_Index

**Signature:** `Int64 get_Index()`
**Return Type:** `Int64`

---

### get_Line

**Signature:** `Int64 get_Line()`
**Return Type:** `Int64`

---

### get_Column

**Signature:** `Int64 get_Column()`
**Return Type:** `Int64`

---

### get_StreamName

**Signature:** `System.String get_StreamName()`
**Return Type:** `String`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(FParsec.Position)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `other` | `Position` | No | `` |  |

---

### op_Equality (static)

**Signature:** `Boolean op_Equality(FParsec.Position, FParsec.Position)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `Position` | No | `` |  |
| `right` | `Position` | No | `` |  |

---

### op_Inequality (static)

**Signature:** `Boolean op_Inequality(FParsec.Position, FParsec.Position)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `Position` | No | `` |  |
| `right` | `Position` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Compare (static)

**Signature:** `Int32 Compare(FParsec.Position, FParsec.Position)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `Position` | No | `` |  |
| `right` | `Position` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(FParsec.Position)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `other` | `Position` | No | `` |  |

---

## Properties

### Index

**Type:** `Int64` (read/write)

---

### Line

**Type:** `Int64` (read/write)

---

### Column

**Type:** `Int64` (read/write)

---

### StreamName

**Type:** `String` (read/write)

---