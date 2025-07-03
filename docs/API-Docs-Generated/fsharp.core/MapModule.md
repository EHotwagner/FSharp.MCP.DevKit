# MapModule Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.MapModule`

Contains operations for working with values of type .

## Methods

### IsEmpty (static) (generic)

**Signature:** `Boolean IsEmpty[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### Add (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] Add[TKey,T](TKey, T, Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `value` | `T` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Change (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] Change[TKey,T](TKey, Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.FSharpOption`1[T],Microsoft.FSharp.Core.FSharpOption`1[T]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Find (static) (generic)

**Signature:** `T Find[TKey,T](TKey, Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### TryFind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryFind[TKey,T](TKey, Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Remove (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] Remove[TKey,T](TKey, Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### ContainsKey (static) (generic)

**Signature:** `Boolean ContainsKey[TKey,T](TKey, Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `TKey` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### TryPick (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] TryPick[TKey,T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Pick (static) (generic)

**Signature:** `TResult Pick[TKey,T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Exists (static) (generic)

**Signature:** `Boolean Exists[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] Filter[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Partition (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpMap`2[TKey,T],Microsoft.FSharp.Collections.FSharpMap`2[TKey,T]] Partition[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### ForAll (static) (generic)

**Signature:** `Boolean ForAll[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Map (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,TResult] Map[TKey,T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,TResult]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### Fold (static) (generic)

**Signature:** `TState Fold[TKey,T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]]], TState, Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### FoldBack (static) (generic)

**Signature:** `TState FoldBack[TKey,T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### ToSeq (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Tuple`2[TKey,T]] ToSeq[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### FindKey (static) (generic)

**Signature:** `TKey FindKey[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `TKey`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### TryFindKey (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TKey] TryFindKey[TKey,T](Microsoft.FSharp.Core.FSharpFunc`2[TKey,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `table` | `FSharpMap`2` | No | `` |  |

---

### OfList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] OfList[TKey,T](Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[TKey,T]])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `FSharpList`1` | No | `` |  |

---

### OfSeq (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] OfSeq[TKey,T](System.Collections.Generic.IEnumerable`1[System.Tuple`2[TKey,T]])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `IEnumerable`1` | No | `` |  |

---

### OfArray (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] OfArray[TKey,T](System.Tuple`2[TKey,T][])`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `Tuple`2[]` | No | `` |  |

---

### ToList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[TKey,T]] ToList[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### ToArray (static) (generic)

**Signature:** `System.Tuple`2[TKey,T][] ToArray[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### Empty (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[TKey,T] Empty[TKey,T]()`
**Return Type:** `FSharpMap`2`

---

### Count (static) (generic)

**Signature:** `Int32 Count[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### Keys (static) (generic)

**Signature:** `System.Collections.Generic.ICollection`1[TKey] Keys[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `ICollection`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### Values (static) (generic)

**Signature:** `System.Collections.Generic.ICollection`1[T] Values[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `ICollection`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### MinKeyValue (static) (generic)

**Signature:** `System.Tuple`2[TKey,T] MinKeyValue[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---

### MaxKeyValue (static) (generic)

**Signature:** `System.Tuple`2[TKey,T] MaxKeyValue[TKey,T](Microsoft.FSharp.Collections.FSharpMap`2[TKey,T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `table` | `FSharpMap`2` | No | `` |  |

---