# FSharpChoice`3 Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FSharpChoice`3`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<T1, T2, T3>`

Helper types for active patterns with 3 choices.

## Methods

### NewChoice1Of3 (static)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`3[T1,T2,T3] NewChoice1Of3(T1)`
**Return Type:** `FSharpChoice`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `T1` | No | `` |  |

---

### get_IsChoice1Of3

**Signature:** `Boolean get_IsChoice1Of3()`
**Return Type:** `Boolean`

---

### NewChoice2Of3 (static)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`3[T1,T2,T3] NewChoice2Of3(T2)`
**Return Type:** `FSharpChoice`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `T2` | No | `` |  |

---

### get_IsChoice2Of3

**Signature:** `Boolean get_IsChoice2Of3()`
**Return Type:** `Boolean`

---

### NewChoice3Of3 (static)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`3[T1,T2,T3] NewChoice3Of3(T3)`
**Return Type:** `FSharpChoice`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `T3` | No | `` |  |

---

### get_IsChoice3Of3

**Signature:** `Boolean get_IsChoice3Of3()`
**Return Type:** `Boolean`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### CompareTo

**Signature:** `Int32 CompareTo(Microsoft.FSharp.Core.FSharpChoice`3[T1,T2,T3])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpChoice`3` | No | `` |  |

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

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpChoice`3[T1,T2,T3], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpChoice`3` | No | `` |  |
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

### Equals

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpChoice`3[T1,T2,T3])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpChoice`3` | No | `` |  |

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

### IsChoice1Of3

**Type:** `Boolean` (read-only)

---

### IsChoice2Of3

**Type:** `Boolean` (read-only)

---

### IsChoice3Of3

**Type:** `Boolean` (read-only)

---