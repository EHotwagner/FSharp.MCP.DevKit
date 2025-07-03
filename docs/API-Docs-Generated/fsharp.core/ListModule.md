# ListModule Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.ListModule`

Contains operations for working with values of type .

## Methods

### Length (static) (generic)

**Signature:** `Int32 Length[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Last (static) (generic)

**Signature:** `T Last[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### TryLast (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryLast[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Reverse (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Reverse[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Concat (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Concat[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Collections.FSharpList`1[T]])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lists` | `IEnumerable`1` | No | `` |  |

---

### CountBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[TKey,System.Int32]] CountBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Map (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] Map[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### MapIndexed (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] MapIndexed[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,TResult]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Indexed (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[System.Int32,T]] Indexed[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### MapFold (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[TResult],TState] MapFold[T,TState,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Tuple`2[TResult,TState]]], TState, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### MapFoldBack (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[TResult],TState] MapFoldBack[T,TState,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,System.Tuple`2[TResult,TState]]], Microsoft.FSharp.Collections.FSharpList`1[T], TState)`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Distinct (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Distinct[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### DistinctBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] DistinctBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### OfArray (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] OfArray[T](T[])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### ToArray (static) (generic)

**Signature:** `T[] ToArray[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Empty (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Empty[T]()`
**Return Type:** `FSharpList`1`

---

### Head (static) (generic)

**Signature:** `T Head[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### TryHead (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryHead[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Tail (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Tail[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### IsEmpty (static) (generic)

**Signature:** `Boolean IsEmpty[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Append (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Append[T](Microsoft.FSharp.Collections.FSharpList`1[T], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Item (static) (generic)

**Signature:** `T Item[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TryItem (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryItem[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Get (static) (generic)

**Signature:** `T Get[T](Microsoft.FSharp.Collections.FSharpList`1[T], Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |
| `index` | `Int32` | No | `` |  |

---

### Choose (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] Choose[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SplitAt (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[T],Microsoft.FSharp.Collections.FSharpList`1[T]] SplitAt[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Take (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Take[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TakeWhile (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] TakeWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### IterateIndexed (static) (generic)

**Signature:** `Void IterateIndexed[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Initialize (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Initialize[T](Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length` | `Int32` | No | `` |  |
| `initializer` | `FSharpFunc`2` | No | `` |  |

---

### Replicate (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Replicate[T](Int32, T)`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `initial` | `T` | No | `` |  |

---

### Iterate2 (static) (generic)

**Signature:** `Void Iterate2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.Unit]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### IterateIndexed2 (static) (generic)

**Signature:** `Void IterateIndexed2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.Unit]]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Map3 (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] Map3[T1,T2,T3,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2], Microsoft.FSharp.Collections.FSharpList`1[T3])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |
| `list3` | `FSharpList`1` | No | `` |  |

---

### MapIndexed2 (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] MapIndexed2[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Map2 (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] Map2[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Fold (static) (generic)

**Signature:** `TState Fold[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Pairwise (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[T,T]] Pairwise[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Reduce (static) (generic)

**Signature:** `T Reduce[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reduction` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Scan (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TState] Scan[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Singleton (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Singleton[T](T)`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Fold2 (static) (generic)

**Signature:** `TState Fold2[T1,T2,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TState]]], TState, Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### FoldBack (static) (generic)

**Signature:** `TState FoldBack[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], Microsoft.FSharp.Collections.FSharpList`1[T], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### ReduceBack (static) (generic)

**Signature:** `T ReduceBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reduction` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### ScanBack (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TState] ScanBack[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], Microsoft.FSharp.Collections.FSharpList`1[T], TState)`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### FoldBack2 (static) (generic)

**Signature:** `TState FoldBack2[T1,T2,TState](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### ForAll2 (static) (generic)

**Signature:** `Boolean ForAll2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,System.Boolean]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### ForAll (static) (generic)

**Signature:** `Boolean ForAll[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Exists (static) (generic)

**Signature:** `Boolean Exists[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Contains (static) (generic)

**Signature:** `Boolean Contains[T](T, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### Exists2 (static) (generic)

**Signature:** `Boolean Exists2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,System.Boolean]], Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Find (static) (generic)

**Signature:** `T Find[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TryFind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryFind[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### FindBack (static) (generic)

**Signature:** `T FindBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TryFindBack (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryFindBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TryPick (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] TryPick[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Pick (static) (generic)

**Signature:** `TResult Pick[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Filter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Except (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Except[T](System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `itemsToExclude` | `IEnumerable`1` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Where (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Where[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### GroupBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[TKey,Microsoft.FSharp.Collections.FSharpList`1[T]]] GroupBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Partition (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[T],Microsoft.FSharp.Collections.FSharpList`1[T]] Partition[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Unzip (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[T1],Microsoft.FSharp.Collections.FSharpList`1[T2]] Unzip[T1,T2](Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[T1,T2]])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Unzip3 (static) (generic)

**Signature:** `System.Tuple`3[Microsoft.FSharp.Collections.FSharpList`1[T1],Microsoft.FSharp.Collections.FSharpList`1[T2],Microsoft.FSharp.Collections.FSharpList`1[T3]] Unzip3[T1,T2,T3](Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`3[T1,T2,T3]])`
**Return Type:** `Tuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Windowed (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[T]] Windowed[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `windowSize` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### ChunkBySize (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[T]] ChunkBySize[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chunkSize` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SplitInto (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[T]] SplitInto[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Zip (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[T1,T2]] Zip[T1,T2](Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Zip3 (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`3[T1,T2,T3]] Zip3[T1,T2,T3](Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2], Microsoft.FSharp.Collections.FSharpList`1[T3])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |
| `list3` | `FSharpList`1` | No | `` |  |

---

### Skip (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Skip[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SkipWhile (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] SkipWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SortWith (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] SortWith[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SortBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] SortBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Sort (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Sort[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### SortByDescending (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] SortByDescending[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SortDescending (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] SortDescending[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### OfSeq (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] OfSeq[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |

---

### ToSeq (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] ToSeq[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### FindIndex (static) (generic)

**Signature:** `Int32 FindIndex[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TryFindIndex (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int32] TryFindIndex[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### FindIndexBack (static) (generic)

**Signature:** `Int32 FindIndexBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### TryFindIndexBack (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int32] TryFindIndexBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Sum (static) (generic)

**Signature:** `T Sum[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Sum$W (static) (generic)

**Signature:** `T Sum$W[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SumBy (static) (generic)

**Signature:** `TResult SumBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### SumBy$W (static) (generic)

**Signature:** `TResult SumBy$W[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TResult], Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[TResult,TResult]], Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Max (static) (generic)

**Signature:** `T Max[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### MaxBy (static) (generic)

**Signature:** `T MaxBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Min (static) (generic)

**Signature:** `T Min[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### MinBy (static) (generic)

**Signature:** `T MinBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Average (static) (generic)

**Signature:** `T Average[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Average$W (static) (generic)

**Signature:** `T Average$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### AverageBy (static) (generic)

**Signature:** `TResult AverageBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### AverageBy$W (static) (generic)

**Signature:** `TResult AverageBy$W[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,TResult]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TResult], Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[TResult,TResult]], Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Collect (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[TResult] Collect[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Collections.FSharpList`1[TResult]], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### AllPairs (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[T1,T2]] AllPairs[T1,T2](Microsoft.FSharp.Collections.FSharpList`1[T1], Microsoft.FSharp.Collections.FSharpList`1[T2])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### CompareWith (static) (generic)

**Signature:** `Int32 CompareWith[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32]], Microsoft.FSharp.Collections.FSharpList`1[T], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `FSharpFunc`2` | No | `` |  |
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Permute (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Permute[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,System.Int32], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `indexMap` | `FSharpFunc`2` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### ExactlyOne (static) (generic)

**Signature:** `T ExactlyOne[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### TryExactlyOne (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryExactlyOne[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Transpose (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[T]] Transpose[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Collections.FSharpList`1[T]])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lists` | `IEnumerable`1` | No | `` |  |

---

### Truncate (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Truncate[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `list` | `FSharpList`1` | No | `` |  |

---

### Unfold (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Unfold[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[T,TState]]], TState)`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `generator` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### RemoveAt (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RemoveAt[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RemoveManyAt (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RemoveManyAt[T](Int32, Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### UpdateAt (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] UpdateAt[T](Int32, T, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### InsertAt (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] InsertAt[T](Int32, T, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### InsertManyAt (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] InsertManyAt[T](Int32, System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `values` | `IEnumerable`1` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomShuffleWith (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomShuffleWith[T](System.Random, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomShuffleBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomShuffleBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomShuffle (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomShuffle[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomChoiceWith (static) (generic)

**Signature:** `T RandomChoiceWith[T](System.Random, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomChoiceBy (static) (generic)

**Signature:** `T RandomChoiceBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomChoice (static) (generic)

**Signature:** `T RandomChoice[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomChoicesWith (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomChoicesWith[T](System.Random, Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomChoicesBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomChoicesBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomChoices (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomChoices[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomSampleWith (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomSampleWith[T](System.Random, Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomSampleBy (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomSampleBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---

### RandomSample (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] RandomSample[T](Int32, Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `FSharpList`1` | No | `` |  |

---