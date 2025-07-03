# FSharpList`1 Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.FSharpList`1`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`, ``, ``, ``, `System.Collections.IEnumerable`
- **Generic Parameters:** `<T>`

The type of immutable singly-linked lists.

## Methods

### get_Empty (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] get_Empty()`
**Return Type:** `FSharpList`1`

---

### get_IsEmpty

**Signature:** `Boolean get_IsEmpty()`
**Return Type:** `Boolean`

---

### Cons (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Cons(T, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `head` | `T` | No | `` |  |
| `tail` | `FSharpList`1` | No | `` |  |

---

### get_IsCons

**Signature:** `Boolean get_IsCons()`
**Return Type:** `Boolean`

---

### get_HeadOrDefault

**Signature:** `T get_HeadOrDefault()`
**Return Type:** `T`

---

### get_TailOrNull

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] get_TailOrNull()`
**Return Type:** `FSharpList`1`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### CompareTo

**Signature:** `Int32 CompareTo(Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpList`1` | No | `` |  |

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

**Signature:** `Boolean Equals(Microsoft.FSharp.Collections.FSharpList`1[T], System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpList`1` | No | `` |  |
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

**Signature:** `Boolean Equals(Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpList`1` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### get_Length

**Signature:** `Int32 get_Length()`
**Return Type:** `Int32`

---

### get_Head

**Signature:** `T get_Head()`
**Return Type:** `T`

---

### get_Tail

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] get_Tail()`
**Return Type:** `FSharpList`1`

---

### get_Item

**Signature:** `T get_Item(Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### GetSlice

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] GetSlice(Microsoft.FSharp.Core.FSharpOption`1[System.Int32], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `startIndex` | `FSharpOption`1` | No | `` |  |
| `endIndex` | `FSharpOption`1` | No | `` |  |

---

### GetReverseIndex

**Signature:** `Int32 GetReverseIndex(Int32, Int32)`
**Return Type:** `Int32`

**Description:** Get the index for the element offset elements away from the end of the collection.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `rank` | `Int32` | No | `` | The rank of the index. |
| `offset` | `Int32` | No | `` | The offset from the end. |

**Returns:** The corresponding index from the start.

---

## Properties

### Tag

**Type:** `Int32` (read-only)

---

### Empty (static)

**Type:** `FSharpList`1` (read-only)

**Description:** Returns an empty list of a particular type

---

### IsEmpty

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating if the list contains no entries

---

### IsCons

**Type:** `Boolean` (read-only)

---

### HeadOrDefault

**Type:** `T` (read-only)

---

### TailOrNull

**Type:** `FSharpList`1` (read-only)

---

### Length

**Type:** `Int32` (read-only)

**Description:** Gets the number of items contained in the list

---

### Head

**Type:** `T` (read-only)

**Description:** Gets the first element of the list

---

### Tail

**Type:** `FSharpList`1` (read-only)

**Description:** Gets the tail of the list, which is a list containing all the elements of the list, excluding the first element

---

### Item

**Type:** `T` (read-only)

---