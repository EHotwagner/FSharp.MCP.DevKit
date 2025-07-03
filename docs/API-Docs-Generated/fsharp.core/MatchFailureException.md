# MatchFailureException Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.MatchFailureException`
- **Base Type:** `System.Exception`
- **Implements:** `System.Runtime.Serialization.ISerializable`, `System.Collections.IStructuralEquatable`

Non-exhaustive match failures will raise the MatchFailureException exception

## Methods

### get_Data0

**Signature:** `System.String get_Data0()`
**Return Type:** `String`

---

### get_Data1

**Signature:** `Int32 get_Data1()`
**Return Type:** `Int32`

---

### get_Data2

**Signature:** `Int32 get_Data2()`
**Return Type:** `Int32`

---

### GetHashCode

**Signature:** `Int32 GetHashCode(System.Collections.IEqualityComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IEqualityComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Exception, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Exception` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### get_Message

**Signature:** `System.String get_Message()`
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

## Properties

### Data0

**Type:** `String` (read-only)

---

### Data1

**Type:** `Int32` (read-only)

---

### Data2

**Type:** `Int32` (read-only)

---

### Message

**Type:** `String` (read-only)

---