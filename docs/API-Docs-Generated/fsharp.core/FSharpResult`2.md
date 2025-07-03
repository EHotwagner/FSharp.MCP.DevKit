# FSharpResult`2 Struct

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FSharpResult`2`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<T, TError>`

Helper type for error handling without exceptions.

## Methods

### NewOk (static)

**Signature:** `Microsoft.FSharp.Core.FSharpResult`2[T,TError] NewOk(T)`
**Return Type:** `FSharpResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `resultValue` | `T` | No | `` |  |

---

### get_IsOk

**Signature:** `Boolean get_IsOk()`
**Return Type:** `Boolean`

---

### NewError (static)

**Signature:** `Microsoft.FSharp.Core.FSharpResult`2[T,TError] NewError(TError)`
**Return Type:** `FSharpResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `errorValue` | `TError` | No | `` |  |

---

### get_IsError

**Signature:** `Boolean get_IsError()`
**Return Type:** `Boolean`

---

### get_ResultValue

**Signature:** `T get_ResultValue()`
**Return Type:** `T`

---

### get_ErrorValue

**Signature:** `TError get_ErrorValue()`
**Return Type:** `TError`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### CompareTo

**Signature:** `Int32 CompareTo(Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpResult`2` | No | `` |  |

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

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpResult`2[T,TError], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpResult`2` | No | `` |  |
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

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpResult`2` | No | `` |  |

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

### IsOk

**Type:** `Boolean` (read-only)

---

### IsError

**Type:** `Boolean` (read-only)

---

### ResultValue

**Type:** `T` (read-only)

---

### ErrorValue

**Type:** `TError` (read-only)

---