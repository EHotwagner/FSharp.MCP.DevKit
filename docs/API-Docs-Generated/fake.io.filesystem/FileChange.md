# FileChange Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.FileChange`
- **Implements:** `System.IEquatable`1[[Fake.IO.FileChange, Fake.IO.FileSystem, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.IO.FileChange, Fake.IO.FileSystem, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

Capture file change operation, see FileStatus

## Methods

### get_FullPath

**Signature:** `System.String get_FullPath()`
**Return Type:** `String`

---

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### get_Status

**Signature:** `Fake.IO.FileStatus get_Status()`
**Return Type:** `FileStatus`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.IO.FileChange)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FileChange` | No | `` |  |

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

**Signature:** `Boolean Equals(Fake.IO.FileChange)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FileChange` | No | `` |  |

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

### FullPath

**Type:** `String` (read-only)

---

### Name

**Type:** `String` (read-only)

---

### Status

**Type:** `FileStatus` (read-only)

---