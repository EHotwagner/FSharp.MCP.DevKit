# Skippable`1 Struct

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.Skippable`1`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<T>`

Represents a value that can be represented as an absent field in JSON.
 In particular, Skippable<'T option> allows distinguishing between absent field and null field.

## Methods

### get_Skip (static)

**Signature:** `System.Text.Json.Serialization.Skippable`1[T] get_Skip()`
**Return Type:** `Skippable`1`

---

### get_IsSkip

**Signature:** `Boolean get_IsSkip()`
**Return Type:** `Boolean`

---

### NewInclude (static)

**Signature:** `System.Text.Json.Serialization.Skippable`1[T] NewInclude(T)`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `T` | No | `` |  |

---

### get_IsInclude

**Signature:** `Boolean get_IsInclude()`
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

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Text.Json.Serialization.Skippable`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Skippable`1` | No | `` |  |

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

**Signature:** `Boolean Equals(System.Text.Json.Serialization.Skippable`1[T], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Skippable`1` | No | `` |  |
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

### get_isSkip

**Signature:** `Boolean get_isSkip()`
**Return Type:** `Boolean`

---

### get_isInclude

**Signature:** `Boolean get_isInclude()`
**Return Type:** `Boolean`

---

### Equals

**Signature:** `Boolean Equals(System.Text.Json.Serialization.Skippable`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Skippable`1` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### op_LessMultiplyGreater (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[b] op_LessMultiplyGreater[a,b](System.Text.Json.Serialization.Skippable`1[Microsoft.FSharp.Core.FSharpFunc`2[a,b]], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fSkip` | `Skippable`1` | No | `` |  |
| `xSkip` | `Skippable`1` | No | `` |  |

---

### op_LessBangGreater (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[b] op_LessBangGreater[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,b], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

## Properties

### Tag

**Type:** `Int32` (read-only)

---

### Skip (static)

**Type:** `Skippable`1` (read-only)

---

### IsSkip

**Type:** `Boolean` (read-only)

---

### IsInclude

**Type:** `Boolean` (read-only)

---

### Item

**Type:** `T` (read-only)

---

### isSkip

**Type:** `Boolean` (read-only)

**Description:** Returns true if the value is Skip.

---

### isInclude

**Type:** `Boolean` (read-only)

**Description:** Returns true if the value is not Skip.

---