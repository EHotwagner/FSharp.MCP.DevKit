# ArrayModule Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.ArrayModule`

Contains operations for working with arrays.

## Methods

### Length (static) (generic)

**Signature:** `Int32 Length[T](T[])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Last (static) (generic)

**Signature:** `T Last[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### TryLast (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryLast[T](T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Initialize (static) (generic)

**Signature:** `T[] Initialize[T](Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `initializer` | `FSharpFunc`2` | No | `` |  |

---

### ZeroCreate (static) (generic)

**Signature:** `T[] ZeroCreate[T](Int32)`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |

---

### Create (static) (generic)

**Signature:** `T[] Create[T](Int32, T)`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### TryHead (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryHead[T](T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### IsEmpty (static) (generic)

**Signature:** `Boolean IsEmpty[T](T[])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Tail (static) (generic)

**Signature:** `T[] Tail[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Empty (static) (generic)

**Signature:** `T[] Empty[T]()`
**Return Type:** `T[]`

---

### CopyTo (static) (generic)

**Signature:** `Void CopyTo[T](T[], Int32, T[], Int32, Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `T[]` | No | `` |  |
| `sourceIndex` | `Int32` | No | `` |  |
| `target` | `T[]` | No | `` |  |
| `targetIndex` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---

### Concat (static) (generic)

**Signature:** `T[] Concat[T](System.Collections.Generic.IEnumerable`1[T[]])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arrays` | `IEnumerable`1` | No | `` |  |

---

### Replicate (static) (generic)

**Signature:** `T[] Replicate[T](Int32, T)`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `initial` | `T` | No | `` |  |

---

### Collect (static) (generic)

**Signature:** `TResult[] Collect[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult[]], T[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SplitAt (static) (generic)

**Signature:** `System.Tuple`2[T[],T[]] SplitAt[T](Int32, T[])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Take (static) (generic)

**Signature:** `T[] Take[T](Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TakeWhile (static) (generic)

**Signature:** `T[] TakeWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### CountBy (static) (generic)

**Signature:** `System.Tuple`2[TKey,System.Int32][] CountBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], T[])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Append (static) (generic)

**Signature:** `T[] Append[T](T[], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array1` | `T[]` | No | `` |  |
| `array2` | `T[]` | No | `` |  |

---

### Head (static) (generic)

**Signature:** `T Head[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Copy (static) (generic)

**Signature:** `T[] Copy[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### ToList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] ToList[T](T[])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### OfList (static) (generic)

**Signature:** `T[] OfList[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list` | `FSharpList`1` | No | `` |  |

---

### Indexed (static) (generic)

**Signature:** `System.Tuple`2[System.Int32,T][] Indexed[T](T[])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Distinct (static) (generic)

**Signature:** `T[] Distinct[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Map (static) (generic)

**Signature:** `TResult[] Map[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Iterate2 (static) (generic)

**Signature:** `Void Iterate2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.Unit]], T1[], T2[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### DistinctBy (static) (generic)

**Signature:** `T[] DistinctBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Map2 (static) (generic)

**Signature:** `TResult[] Map2[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]], T1[], T2[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### Map3 (static) (generic)

**Signature:** `TResult[] Map3[T1,T2,T3,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]], T1[], T2[], T3[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |
| `array3` | `T3[]` | No | `` |  |

---

### MapIndexed2 (static) (generic)

**Signature:** `TResult[] MapIndexed2[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]]], T1[], T2[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### IterateIndexed (static) (generic)

**Signature:** `Void IterateIndexed[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit]], T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### IterateIndexed2 (static) (generic)

**Signature:** `Void IterateIndexed2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.Unit]]], T1[], T2[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### MapIndexed (static) (generic)

**Signature:** `TResult[] MapIndexed[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,TResult]], T[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### MapFold (static) (generic)

**Signature:** `System.Tuple`2[TResult[],TState] MapFold[T,TState,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Tuple`2[TResult,TState]]], TState, T[])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### MapFoldBack (static) (generic)

**Signature:** `System.Tuple`2[TResult[],TState] MapFoldBack[T,TState,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,System.Tuple`2[TResult,TState]]], T[], TState)`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Exists (static) (generic)

**Signature:** `Boolean Exists[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Contains (static) (generic)

**Signature:** `Boolean Contains[T](T, T[])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Exists2 (static) (generic)

**Signature:** `Boolean Exists2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,System.Boolean]], T1[], T2[])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### ForAll (static) (generic)

**Signature:** `Boolean ForAll[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### ForAll2 (static) (generic)

**Signature:** `Boolean ForAll2[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,System.Boolean]], T1[], T2[])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### GroupBy (static) (generic)

**Signature:** `System.Tuple`2[TKey,T[]][] GroupBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], T[])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Pick (static) (generic)

**Signature:** `TResult Pick[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], T[])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TryPick (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] TryPick[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Choose (static) (generic)

**Signature:** `TResult[] Choose[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], T[])`
**Return Type:** `TResult[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `T[] Filter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Where (static) (generic)

**Signature:** `T[] Where[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Except (static) (generic)

**Signature:** `T[] Except[T](System.Collections.Generic.IEnumerable`1[T], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `itemsToExclude` | `IEnumerable`1` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Partition (static) (generic)

**Signature:** `System.Tuple`2[T[],T[]] Partition[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Find (static) (generic)

**Signature:** `T Find[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TryFind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryFind[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Skip (static) (generic)

**Signature:** `T[] Skip[T](Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SkipWhile (static) (generic)

**Signature:** `T[] SkipWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### FindBack (static) (generic)

**Signature:** `T FindBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TryFindBack (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryFindBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### FindIndexBack (static) (generic)

**Signature:** `Int32 FindIndexBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TryFindIndexBack (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int32] TryFindIndexBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Windowed (static) (generic)

**Signature:** `T[][] Windowed[T](Int32, T[])`
**Return Type:** `T[][]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `windowSize` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### ChunkBySize (static) (generic)

**Signature:** `T[][] ChunkBySize[T](Int32, T[])`
**Return Type:** `T[][]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chunkSize` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SplitInto (static) (generic)

**Signature:** `T[][] SplitInto[T](Int32, T[])`
**Return Type:** `T[][]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Zip (static) (generic)

**Signature:** `System.Tuple`2[T1,T2][] Zip[T1,T2](T1[], T2[])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### Zip3 (static) (generic)

**Signature:** `System.Tuple`3[T1,T2,T3][] Zip3[T1,T2,T3](T1[], T2[], T3[])`
**Return Type:** `Tuple`3[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |
| `array3` | `T3[]` | No | `` |  |

---

### AllPairs (static) (generic)

**Signature:** `System.Tuple`2[T1,T2][] AllPairs[T1,T2](T1[], T2[])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### Unfold (static) (generic)

**Signature:** `T[] Unfold[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[T,TState]]], TState)`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `generator` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Unzip (static) (generic)

**Signature:** `System.Tuple`2[T1[],T2[]] Unzip[T1,T2](System.Tuple`2[T1,T2][])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `Tuple`2[]` | No | `` |  |

---

### Unzip3 (static) (generic)

**Signature:** `System.Tuple`3[T1[],T2[],T3[]] Unzip3[T1,T2,T3](System.Tuple`3[T1,T2,T3][])`
**Return Type:** `Tuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `Tuple`3[]` | No | `` |  |

---

### Reverse (static) (generic)

**Signature:** `T[] Reverse[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Fold (static) (generic)

**Signature:** `TState Fold[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, T[])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### FoldBack (static) (generic)

**Signature:** `TState FoldBack[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], T[], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### FoldBack2 (static) (generic)

**Signature:** `TState FoldBack2[T1,T2,TState](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]]], T1[], T2[], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Fold2 (static) (generic)

**Signature:** `TState Fold2[T1,T2,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TState]]], TState, T1[], T2[])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `array1` | `T1[]` | No | `` |  |
| `array2` | `T2[]` | No | `` |  |

---

### Scan (static) (generic)

**Signature:** `TState[] Scan[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, T[])`
**Return Type:** `TState[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### ScanBack (static) (generic)

**Signature:** `TState[] ScanBack[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], T[], TState)`
**Return Type:** `TState[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Singleton (static) (generic)

**Signature:** `T[] Singleton[T](T)`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Pairwise (static) (generic)

**Signature:** `System.Tuple`2[T,T][] Pairwise[T](T[])`
**Return Type:** `Tuple`2[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Reduce (static) (generic)

**Signature:** `T Reduce[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reduction` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### ReduceBack (static) (generic)

**Signature:** `T ReduceBack[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reduction` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SortInPlaceWith (static) (generic)

**Signature:** `Void SortInPlaceWith[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32]], T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SortInPlaceBy (static) (generic)

**Signature:** `Void SortInPlaceBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SortInPlace (static) (generic)

**Signature:** `Void SortInPlace[T](T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### SortWith (static) (generic)

**Signature:** `T[] SortWith[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32]], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SortBy (static) (generic)

**Signature:** `T[] SortBy[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Sort (static) (generic)

**Signature:** `T[] Sort[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### SortByDescending (static) (generic)

**Signature:** `T[] SortByDescending[T,TKey](Microsoft.FSharp.Core.FSharpFunc`2[T,TKey], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SortDescending (static) (generic)

**Signature:** `T[] SortDescending[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### ToSeq (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] ToSeq[T](T[])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### OfSeq (static) (generic)

**Signature:** `T[] OfSeq[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |

---

### FindIndex (static) (generic)

**Signature:** `Int32 FindIndex[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TryFindIndex (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int32] TryFindIndex[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Permute (static) (generic)

**Signature:** `T[] Permute[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,System.Int32], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `indexMap` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Sum (static) (generic)

**Signature:** `T Sum[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Sum$W (static) (generic)

**Signature:** `T Sum$W[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SumBy (static) (generic)

**Signature:** `TResult SumBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### SumBy$W (static) (generic)

**Signature:** `TResult SumBy$W[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TResult], Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[TResult,TResult]], Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Min (static) (generic)

**Signature:** `T Min[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### MinBy (static) (generic)

**Signature:** `T MinBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Max (static) (generic)

**Signature:** `T Max[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### MaxBy (static) (generic)

**Signature:** `T MaxBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Average (static) (generic)

**Signature:** `T Average[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Average$W (static) (generic)

**Signature:** `T Average$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### AverageBy (static) (generic)

**Signature:** `TResult AverageBy[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### AverageBy$W (static) (generic)

**Signature:** `TResult AverageBy$W[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,TResult]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TResult], Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[TResult,TResult]], Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### CompareWith (static) (generic)

**Signature:** `Int32 CompareWith[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32]], T[], T[])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `FSharpFunc`2` | No | `` |  |
| `array1` | `T[]` | No | `` |  |
| `array2` | `T[]` | No | `` |  |

---

### GetSubArray (static) (generic)

**Signature:** `T[] GetSubArray[T](T[], Int32, Int32)`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |
| `startIndex` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---

### Item (static) (generic)

**Signature:** `T Item[T](Int32, T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### TryItem (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryItem[T](Int32, T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### Get (static) (generic)

**Signature:** `T Get[T](T[], Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |
| `index` | `Int32` | No | `` |  |

---

### Set (static) (generic)

**Signature:** `Void Set[T](T[], Int32, T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |
| `index` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Fill (static) (generic)

**Signature:** `Void Fill[T](T[], Int32, Int32, T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `T[]` | No | `` |  |
| `targetIndex` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ExactlyOne (static) (generic)

**Signature:** `T ExactlyOne[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### TryExactlyOne (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryExactlyOne[T](T[])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### Transpose (static) (generic)

**Signature:** `T[][] Transpose[T](System.Collections.Generic.IEnumerable`1[T[]])`
**Return Type:** `T[][]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arrays` | `IEnumerable`1` | No | `` |  |

---

### Truncate (static) (generic)

**Signature:** `T[] Truncate[T](Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `array` | `T[]` | No | `` |  |

---

### RemoveAt (static) (generic)

**Signature:** `T[] RemoveAt[T](Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RemoveManyAt (static) (generic)

**Signature:** `T[] RemoveManyAt[T](Int32, Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### UpdateAt (static) (generic)

**Signature:** `T[] UpdateAt[T](Int32, T, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### InsertAt (static) (generic)

**Signature:** `T[] InsertAt[T](Int32, T, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### InsertManyAt (static) (generic)

**Signature:** `T[] InsertManyAt[T](Int32, System.Collections.Generic.IEnumerable`1[T], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `values` | `IEnumerable`1` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomShuffleWith (static) (generic)

**Signature:** `T[] RandomShuffleWith[T](System.Random, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomShuffleBy (static) (generic)

**Signature:** `T[] RandomShuffleBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomShuffle (static) (generic)

**Signature:** `T[] RandomShuffle[T](T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `T[]` | No | `` |  |

---

### RandomShuffleInPlaceWith (static) (generic)

**Signature:** `Void RandomShuffleInPlaceWith[T](System.Random, T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomShuffleInPlaceBy (static) (generic)

**Signature:** `Void RandomShuffleInPlaceBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomShuffleInPlace (static) (generic)

**Signature:** `Void RandomShuffleInPlace[T](T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `T[]` | No | `` |  |

---

### RandomChoiceWith (static) (generic)

**Signature:** `T RandomChoiceWith[T](System.Random, T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomChoiceBy (static) (generic)

**Signature:** `T RandomChoiceBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomChoice (static) (generic)

**Signature:** `T RandomChoice[T](T[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `T[]` | No | `` |  |

---

### RandomChoicesWith (static) (generic)

**Signature:** `T[] RandomChoicesWith[T](System.Random, Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomChoicesBy (static) (generic)

**Signature:** `T[] RandomChoicesBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomChoices (static) (generic)

**Signature:** `T[] RandomChoices[T](Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomSampleWith (static) (generic)

**Signature:** `T[] RandomSampleWith[T](System.Random, Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `random` | `Random` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomSampleBy (static) (generic)

**Signature:** `T[] RandomSampleBy[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Double], Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `randomizer` | `FSharpFunc`2` | No | `` |  |
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---

### RandomSample (static) (generic)

**Signature:** `T[] RandomSample[T](Int32, T[])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `T[]` | No | `` |  |

---