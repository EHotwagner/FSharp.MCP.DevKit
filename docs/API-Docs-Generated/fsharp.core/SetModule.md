# SetModule Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.SetModule`

Contains operations for working with values of type .

## Methods

### IsEmpty (static) (generic)

**Signature:** `Boolean IsEmpty[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---

### Contains (static) (generic)

**Signature:** `Boolean Contains[T](T, Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `element` | `T` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Add (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Add[T](T, Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Singleton (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Singleton[T](T)`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Remove (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Remove[T](T, Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Union (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Union[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### UnionMany (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] UnionMany[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Collections.FSharpSet`1[T]])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sets` | `IEnumerable`1` | No | `` |  |

---

### Intersect (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Intersect[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### IntersectMany (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] IntersectMany[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Collections.FSharpSet`1[T]])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sets` | `IEnumerable`1` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Empty (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Empty[T]()`
**Return Type:** `FSharpSet`1`

---

### ForAll (static) (generic)

**Signature:** `Boolean ForAll[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Exists (static) (generic)

**Signature:** `Boolean Exists[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Filter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Partition (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Collections.FSharpSet`1[T],Microsoft.FSharp.Collections.FSharpSet`1[T]] Partition[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Fold (static) (generic)

**Signature:** `TState Fold[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### FoldBack (static) (generic)

**Signature:** `TState FoldBack[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], Microsoft.FSharp.Collections.FSharpSet`1[T], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Map (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[TResult] Map[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `set` | `FSharpSet`1` | No | `` |  |

---

### Count (static) (generic)

**Signature:** `Int32 Count[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---

### OfList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] OfList[T](Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `FSharpList`1` | No | `` |  |

---

### OfArray (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] OfArray[T](T[])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---

### ToList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] ToList[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---

### ToArray (static) (generic)

**Signature:** `T[] ToArray[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---

### ToSeq (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] ToSeq[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---

### OfSeq (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] OfSeq[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `IEnumerable`1` | No | `` |  |

---

### Difference (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] Difference[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### IsSubset (static) (generic)

**Signature:** `Boolean IsSubset[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### IsSuperset (static) (generic)

**Signature:** `Boolean IsSuperset[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### IsProperSubset (static) (generic)

**Signature:** `Boolean IsProperSubset[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### IsProperSuperset (static) (generic)

**Signature:** `Boolean IsProperSuperset[T](Microsoft.FSharp.Collections.FSharpSet`1[T], Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set1` | `FSharpSet`1` | No | `` |  |
| `set2` | `FSharpSet`1` | No | `` |  |

---

### MinElement (static) (generic)

**Signature:** `T MinElement[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---

### MaxElement (static) (generic)

**Signature:** `T MaxElement[T](Microsoft.FSharp.Collections.FSharpSet`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `FSharpSet`1` | No | `` |  |

---