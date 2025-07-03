# FSharpSet`1 Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.FSharpSet`1`
- **Implements:** `System.Collections.IEnumerable`, ``, ``, ``, `System.Collections.IStructuralEquatable`, `System.IComparable`
- **Generic Parameters:** `<T>`

Immutable sets based on binary trees, where elements are ordered by F# generic comparison. By default
 comparison is the F# structural comparison function or uses implementations of the IComparable interface on element values.

## Methods

### Add

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Add(T)`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Remove

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Remove(T)`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### get_Count

**Signature:** `Int32 get_Count()`
**Return Type:** `Int32`

---

### Contains

**Signature:** `Boolean Contains(T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### get_IsEmpty

**Signature:** `Boolean get_IsEmpty()`
**Return Type:** `Boolean`

---

### op_Subtraction (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] op_Subtraction(Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### op_Addition (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] op_Addition(Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### get_MinimumElement

**Signature:** `T get_MinimumElement()`
**Return Type:** `T`

---

### get_MaximumElement

**Signature:** `T get_MaximumElement()`
**Return Type:** `T`

---

### IsSubsetOf

**Signature:** `Boolean IsSubsetOf(Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `otherSet` | `FSharpSet`1` | No | `` |  |

---

### IsSupersetOf

**Signature:** `Boolean IsSupersetOf(Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `otherSet` | `FSharpSet`1` | No | `` |  |

---

### IsProperSubsetOf

**Signature:** `Boolean IsProperSubsetOf(Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `otherSet` | `FSharpSet`1` | No | `` |  |

---

### IsProperSupersetOf

**Signature:** `Boolean IsProperSupersetOf(Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `otherSet` | `FSharpSet`1` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `that` | `Object` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

## Properties

### Count

**Type:** `Int32` (read-only)

**Description:** The number of elements in the set

---

### IsEmpty

**Type:** `Boolean` (read-only)

**Description:** A useful shortcut for Set.isEmpty. See the Set module for further operations on sets.

---

### MinimumElement

**Type:** `T` (read-only)

**Description:** Returns the lowest element in the set according to the ordering being used for the set.

---

### MaximumElement

**Type:** `T` (read-only)

**Description:** Returns the highest element in the set according to the ordering being used for the set.

---