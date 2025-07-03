# FileStatus Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.FileStatus`
- **Implements:** `System.IEquatable`1[[Fake.IO.FileStatus, Fake.IO.FileSystem, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.IO.FileStatus, Fake.IO.FileSystem, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The state of the file

## Methods

### get_Deleted (static)

**Signature:** `Fake.IO.FileStatus get_Deleted()`
**Return Type:** `FileStatus`

---

### get_IsDeleted

**Signature:** `Boolean get_IsDeleted()`
**Return Type:** `Boolean`

---

### get_Created (static)

**Signature:** `Fake.IO.FileStatus get_Created()`
**Return Type:** `FileStatus`

---

### get_IsCreated

**Signature:** `Boolean get_IsCreated()`
**Return Type:** `Boolean`

---

### get_Changed (static)

**Signature:** `Fake.IO.FileStatus get_Changed()`
**Return Type:** `FileStatus`

---

### get_IsChanged

**Signature:** `Boolean get_IsChanged()`
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

**Signature:** `Int32 CompareTo(Fake.IO.FileStatus)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FileStatus` | No | `` |  |

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

**Signature:** `Boolean Equals(Fake.IO.FileStatus)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FileStatus` | No | `` |  |

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

### Deleted (static)

**Type:** `FileStatus` (read-only)

---

### IsDeleted

**Type:** `Boolean` (read-only)

---

### Created (static)

**Type:** `FileStatus` (read-only)

---

### IsCreated

**Type:** `Boolean` (read-only)

---

### Changed (static)

**Type:** `FileStatus` (read-only)

---

### IsChanged

**Type:** `Boolean` (read-only)

---