# FSharpMap`2 Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.FSharpMap`2`
- **Implements:** ``, ``, ``, `System.Collections.IEnumerable`, `System.IComparable`, ``, ``, `System.Collections.IStructuralEquatable`
- **Generic Parameters:** `<TKey, TValue>`

Immutable maps based on binary trees, where keys are ordered by F# generic comparison. By default
 comparison is the F# structural comparison function or uses implementations of the IComparable interface on key values.

## Methods

### Add

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,TValue] Add(TKey, TValue)`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `value` | `TValue` | No | `` |  |

---

### Change

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,TValue] Change(TKey, Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.FSharpOption`1[TValue],Microsoft.FSharp.Core.FSharpOption`1[TValue]])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### get_IsEmpty

**Signature:** `Boolean get_IsEmpty()`
**Return Type:** `Boolean`

---

### get_Item

**Signature:** `TValue get_Item(TKey)`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |

---

### get_Count

**Signature:** `Int32 get_Count()`
**Return Type:** `Int32`

---

### ContainsKey

**Signature:** `Boolean ContainsKey(TKey)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |

---

### Remove

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,TValue] Remove(TKey)`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |

---

### TryGetValue

**Signature:** `Boolean TryGetValue(TKey, TValue ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `value` | `TValue&` | No | `` |  |

---

### TryFind

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TValue] TryFind(TKey)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |

---

### get_Keys

**Signature:** `System.Collections.Generic.ICollection`1[TKey] get_Keys()`
**Return Type:** `ICollection`1`

---

### get_Values

**Signature:** `System.Collections.Generic.ICollection`1[TValue] get_Values()`
**Return Type:** `ICollection`1`

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `that` | `Object` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

## Properties

### IsEmpty

**Type:** `Boolean` (read-only)

**Description:** Returns true if there are no bindings in the map.

---

### Item

**Type:** `TValue` (read-only)

---

### Count

**Type:** `Int32` (read-only)

**Description:** The number of bindings in the map.

---

### Keys

**Type:** `ICollection`1` (read-only)

**Description:** The keys in the map.
 The sequence will be ordered by the keys of the map.

---

### Values

**Type:** `ICollection`1` (read-only)

**Description:** All the values in the map, including the duplicates.
 The sequence will be ordered by the keys of the map.

---