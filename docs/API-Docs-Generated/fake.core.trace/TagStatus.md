# TagStatus Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TagStatus`
- **Implements:** `System.IEquatable`1[[Fake.Core.TagStatus, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.TagStatus, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The types of tagging on testing supported
 Please consider not using a match on this type in code external to the fake repository.

## Methods

### get_Success (static)

**Signature:** `Fake.Core.TagStatus get_Success()`
**Return Type:** `TagStatus`

---

### get_IsSuccess

**Signature:** `Boolean get_IsSuccess()`
**Return Type:** `Boolean`

---

### get_Warning (static)

**Signature:** `Fake.Core.TagStatus get_Warning()`
**Return Type:** `TagStatus`

---

### get_IsWarning

**Signature:** `Boolean get_IsWarning()`
**Return Type:** `Boolean`

---

### get_Failed (static)

**Signature:** `Fake.Core.TagStatus get_Failed()`
**Return Type:** `TagStatus`

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

**Signature:** `Int32 CompareTo(Fake.Core.TagStatus)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `TagStatus` | No | `` |  |

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

**Signature:** `Boolean Equals(Fake.Core.TagStatus)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `TagStatus` | No | `` |  |

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

### Success (static)

**Type:** `TagStatus` (read-only)

---

### IsSuccess

**Type:** `Boolean` (read-only)

---

### Warning (static)

**Type:** `TagStatus` (read-only)

---

### IsWarning

**Type:** `Boolean` (read-only)

---

### Failed (static)

**Type:** `TagStatus` (read-only)

---

### IsFailed

**Type:** `Boolean` (read-only)

---