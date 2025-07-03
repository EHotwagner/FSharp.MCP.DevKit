# TestStatus Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TestStatus`
- **Implements:** `System.IEquatable`1[[Fake.Core.TestStatus, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.TestStatus, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The testing statuses supported
 Please consider not using a match on this type in code external to the fake repository.

## Methods

### NewIgnored (static)

**Signature:** `Fake.Core.TestStatus NewIgnored(System.String)`
**Return Type:** `TestStatus`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_message` | `String` | No | `` |  |

---

### get_IsIgnored

**Signature:** `Boolean get_IsIgnored()`
**Return Type:** `Boolean`

---

### NewFailed (static)

**Signature:** `Fake.Core.TestStatus NewFailed(System.String, System.String, Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.String,System.String]])`
**Return Type:** `TestStatus`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_message` | `String` | No | `` |  |
| `_details` | `String` | No | `` |  |
| `_expectedActual` | `FSharpOption`1` | No | `` |  |

---

### get_IsFailed

**Signature:** `Boolean get_IsFailed()`
**Return Type:** `Boolean`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.TestStatus)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `TestStatus` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Object)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Object, System.Collections.IComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IComparer` | No | `` |  |

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

**Signature:** `Boolean Equals(System.Object, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.TestStatus)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `TestStatus` | No | `` |  |

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

### Tag

**Type:** `Int32` (read-only)

---

### IsIgnored

**Type:** `Boolean` (read-only)

---

### IsFailed

**Type:** `Boolean` (read-only)

---