# KnownTags Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.KnownTags`
- **Implements:** `System.IEquatable`1[[Fake.Core.KnownTags, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.KnownTags, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The supported tracing tags
 Please consider not using a match on this type in code external to the fake repository.

## Methods

### NewTask (static)

**Signature:** `Fake.Core.KnownTags NewTask(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_name` | `String` | No | `` |  |

---

### get_IsTask

**Signature:** `Boolean get_IsTask()`
**Return Type:** `Boolean`

---

### NewTarget (static)

**Signature:** `Fake.Core.KnownTags NewTarget(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_name` | `String` | No | `` |  |

---

### get_IsTarget

**Signature:** `Boolean get_IsTarget()`
**Return Type:** `Boolean`

---

### NewFinalTarget (static)

**Signature:** `Fake.Core.KnownTags NewFinalTarget(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_name` | `String` | No | `` |  |

---

### get_IsFinalTarget

**Signature:** `Boolean get_IsFinalTarget()`
**Return Type:** `Boolean`

---

### NewFailureTarget (static)

**Signature:** `Fake.Core.KnownTags NewFailureTarget(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_name` | `String` | No | `` |  |

---

### get_IsFailureTarget

**Signature:** `Boolean get_IsFailureTarget()`
**Return Type:** `Boolean`

---

### NewCompilation (static)

**Signature:** `Fake.Core.KnownTags NewCompilation(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_compiler` | `String` | No | `` |  |

---

### get_IsCompilation

**Signature:** `Boolean get_IsCompilation()`
**Return Type:** `Boolean`

---

### NewTestSuite (static)

**Signature:** `Fake.Core.KnownTags NewTestSuite(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_suiteName` | `String` | No | `` |  |

---

### get_IsTestSuite

**Signature:** `Boolean get_IsTestSuite()`
**Return Type:** `Boolean`

---

### NewTest (static)

**Signature:** `Fake.Core.KnownTags NewTest(System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_testName` | `String` | No | `` |  |

---

### get_IsTest

**Signature:** `Boolean get_IsTest()`
**Return Type:** `Boolean`

---

### NewOther (static)

**Signature:** `Fake.Core.KnownTags NewOther(System.String, System.String)`
**Return Type:** `KnownTags`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_typeDef` | `String` | No | `` |  |
| `_name` | `String` | No | `` |  |

---

### get_IsOther

**Signature:** `Boolean get_IsOther()`
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

**Signature:** `Int32 CompareTo(Fake.Core.KnownTags)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `KnownTags` | No | `` |  |

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

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### get_Type

**Signature:** `System.String get_Type()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.KnownTags)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `KnownTags` | No | `` |  |

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

### IsTask

**Type:** `Boolean` (read-only)

---

### IsTarget

**Type:** `Boolean` (read-only)

---

### IsFinalTarget

**Type:** `Boolean` (read-only)

---

### IsFailureTarget

**Type:** `Boolean` (read-only)

---

### IsCompilation

**Type:** `Boolean` (read-only)

---

### IsTestSuite

**Type:** `Boolean` (read-only)

---

### IsTest

**Type:** `Boolean` (read-only)

---

### IsOther

**Type:** `Boolean` (read-only)

---

### Name

**Type:** `String` (read-only)

---

### Type

**Type:** `String` (read-only)

---