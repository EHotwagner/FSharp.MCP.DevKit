# FSharpOption`1 Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FSharpOption`1`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<T>`

The type of optional values. When used from other CLI languages the
 empty option is the null value.

## Methods

### get_None (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] get_None()`
**Return Type:** `FSharpOption`1`

---

### Some (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] Some(T)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### get_Value

**Signature:** `T get_Value()`
**Return Type:** `T`

---

### GetTag (static)

**Signature:** `Int32 GetTag(Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `FSharpOption`1` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpOption`1` | No | `` |  |

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

### Equals (static)

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpOption`1[T], Microsoft.FSharp.Core.FSharpOption`1[T], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `FSharpOption`1` | No | `` |  |
| `obj` | `FSharpOption`1` | No | `` |  |
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

### get_IsNone (static)

**Signature:** `Boolean get_IsNone(Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `FSharpOption`1` | No | `` |  |

---

### get_IsSome (static)

**Signature:** `Boolean get_IsSome(Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `FSharpOption`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] op_Implicit(T)`
**Return Type:** `FSharpOption`1`

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

**Signature:** `Boolean Equals(Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpOption`1` | No | `` |  |

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

### None (static)

**Type:** `FSharpOption`1` (read-only)

**Description:** Create an option value that is a 'None' value.

---

### Value

**Type:** `T` (read-only)

**Description:** Get the value of a 'Some' option. A NullReferenceException is raised if the option is 'None'.

---

### IsNone (static)

**Type:** `Boolean` (read-only)

**Description:** Return 'true' if the option is a 'None' value.

---

### IsSome (static)

**Type:** `Boolean` (read-only)

**Description:** Return 'true' if the option is a 'Some' value.

---