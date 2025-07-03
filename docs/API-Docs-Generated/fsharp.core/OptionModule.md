# OptionModule Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.OptionModule`

Contains operations for working with options.

## Methods

### GetValue (static) (generic)

**Signature:** `T GetValue[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### IsSome (static) (generic)

**Signature:** `Boolean IsSome[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### IsNone (static) (generic)

**Signature:** `Boolean IsNone[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### DefaultValue (static) (generic)

**Signature:** `T DefaultValue[T](T, Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### DefaultWith (static) (generic)

**Signature:** `T DefaultWith[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `defThunk` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### OrElse (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] OrElse[T](Microsoft.FSharp.Core.FSharpOption`1[T], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ifNone` | `FSharpOption`1` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### OrElseWith (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] OrElseWith[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.FSharpOption`1[T]], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ifNoneThunk` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### Count (static) (generic)

**Signature:** `Int32 Count[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### Fold (static) (generic)

**Signature:** `TState Fold[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### FoldBack (static) (generic)

**Signature:** `TState FoldBack[T,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], Microsoft.FSharp.Core.FSharpOption`1[T], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Exists (static) (generic)

**Signature:** `Boolean Exists[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### ForAll (static) (generic)

**Signature:** `Boolean ForAll[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### Contains (static) (generic)

**Signature:** `Boolean Contains[T](T, Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### Map (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] Map[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### Map2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] Map2[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]], Microsoft.FSharp.Core.FSharpOption`1[T1], Microsoft.FSharp.Core.FSharpOption`1[T2])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `option1` | `FSharpOption`1` | No | `` |  |
| `option2` | `FSharpOption`1` | No | `` |  |

---

### Map3 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] Map3[T1,T2,T3,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]], Microsoft.FSharp.Core.FSharpOption`1[T1], Microsoft.FSharp.Core.FSharpOption`1[T2], Microsoft.FSharp.Core.FSharpOption`1[T3])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `option1` | `FSharpOption`1` | No | `` |  |
| `option2` | `FSharpOption`1` | No | `` |  |
| `option3` | `FSharpOption`1` | No | `` |  |

---

### Bind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TResult] Bind[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `binder` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### Flatten (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] Flatten[T](Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.FSharpOption`1[T]])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] Filter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `option` | `FSharpOption`1` | No | `` |  |

---

### ToArray (static) (generic)

**Signature:** `T[] ToArray[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### ToList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] ToList[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### ToNullable (static) (generic)

**Signature:** `System.Nullable`1[T] ToNullable[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### OfNullable (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] OfNullable[T](System.Nullable`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### OfObj (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] OfObj[T](T)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToObj (static) (generic)

**Signature:** `T ToObj[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FSharpOption`1` | No | `` |  |

---

### OfValueOption (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] OfValueOption[T](Microsoft.FSharp.Core.FSharpValueOption`1[T])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `voption` | `FSharpValueOption`1` | No | `` |  |

---

### ToValueOption (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] ToValueOption[T](Microsoft.FSharp.Core.FSharpOption`1[T])`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---