# ResolvedGlobbingPattern Class

**Namespace:** `Fake.IO.Globbing`
**Full Name:** `Fake.IO.Globbing.ResolvedGlobbingPattern`
- **Implements:** `System.IEquatable`1[[Fake.IO.Globbing.ResolvedGlobbingPattern, Fake.IO.FileSystem, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.IO.Globbing.ResolvedGlobbingPattern, Fake.IO.FileSystem, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`, `System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]`, `System.Collections.IEnumerable`, `Fake.IO.IGlobbingPattern`

Holds globbing patterns for backward compatability, see GlobbingPatternExtensions

## Methods

### get_BaseDirectory

**Signature:** `System.String get_BaseDirectory()`
**Return Type:** `String`

---

### get_Includes

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] get_Includes()`
**Return Type:** `FSharpList`1`

---

### get_Excludes

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] get_Excludes()`
**Return Type:** `FSharpList`1`

---

### get_Results

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] get_Results()`
**Return Type:** `FSharpList`1`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.IO.Globbing.ResolvedGlobbingPattern)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ResolvedGlobbingPattern` | No | `` |  |

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

**Signature:** `Boolean Equals(Fake.IO.Globbing.ResolvedGlobbingPattern)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ResolvedGlobbingPattern` | No | `` |  |

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

### BaseDirectory

**Type:** `String` (read-only)

---

### Includes

**Type:** `FSharpList`1` (read-only)

---

### Excludes

**Type:** `FSharpList`1` (read-only)

---

### Results

**Type:** `FSharpList`1` (read-only)

---