# FSharpRef`1 Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FSharpRef`1`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<T>`

The type of mutable references. Use the functions [!] and [:=] to get and
 set values of this type.

## Methods

### get_contents

**Signature:** `T get_contents()`
**Return Type:** `T`

---

### set_contents

**Signature:** `Void set_contents(T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(Microsoft.FSharp.Core.FSharpRef`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpRef`1` | No | `` |  |

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

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpRef`1[T], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpRef`1` | No | `` |  |
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

### get_Value

**Signature:** `T get_Value()`
**Return Type:** `T`

---

### set_Value

**Signature:** `Void set_Value(T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `T` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpRef`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpRef`1` | No | `` |  |

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

### contents

**Type:** `T` (read/write)

**Description:** The current value of the reference cell

---

### Value

**Type:** `T` (read/write)

**Description:** The current value of the reference cell

---