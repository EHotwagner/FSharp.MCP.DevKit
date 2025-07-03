# FSharpValueOption`1 Struct

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FSharpValueOption`1`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<T>`

The type of optional values, represented as structs.

## Methods

### get_ValueNone (static)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] get_ValueNone()`
**Return Type:** `FSharpValueOption`1`

---

### get_IsValueNone

**Signature:** `Boolean get_IsValueNone()`
**Return Type:** `Boolean`

---

### NewValueSome (static)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] NewValueSome(T)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `T` | No | `` |  |

---

### get_IsValueSome

**Signature:** `Boolean get_IsValueSome()`
**Return Type:** `Boolean`

---

### get_Item

**Signature:** `T get_Item()`
**Return Type:** `T`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### CompareTo

**Signature:** `Int32 CompareTo(Microsoft.FSharp.Core.FSharpValueOption`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpValueOption`1` | No | `` |  |

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

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpValueOption`1[T], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpValueOption`1` | No | `` |  |
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

### get_None (static)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] get_None()`
**Return Type:** `FSharpValueOption`1`

---

### Some (static)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] Some(T)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### get_IsNone

**Signature:** `Boolean get_IsNone()`
**Return Type:** `Boolean`

---

### get_IsSome

**Signature:** `Boolean get_IsSome()`
**Return Type:** `Boolean`

---

### op_Implicit (static)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] op_Implicit(T)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpValueOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpValueOption`1` | No | `` |  |

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

### ValueNone (static)

**Type:** `FSharpValueOption`1` (read-only)

---

### IsValueNone

**Type:** `Boolean` (read-only)

---

### IsValueSome

**Type:** `Boolean` (read-only)

---

### Item

**Type:** `T` (read-only)

---

### Value

**Type:** `T` (read-only)

**Description:** Get the value of a 'ValueSome' option. An InvalidOperationException is raised if the option is 'ValueNone'.

---

### None (static)

**Type:** `FSharpValueOption`1` (read-only)

**Description:** Create a value option value that is a 'ValueNone' value.

---

### IsNone

**Type:** `Boolean` (read-only)

**Description:** Return 'true' if the value option is a 'ValueNone' value.

---

### IsSome

**Type:** `Boolean` (read-only)

**Description:** Return 'true' if the value option is a 'ValueSome' value.

---