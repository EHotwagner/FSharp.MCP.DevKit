# ResultModule Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.ResultModule`

Contains operations for working with values of type .

## Methods

### Map (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpResult`2[TResult,TError] Map[T,TResult,TError](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `FSharpResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### MapError (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpResult`2[T,TResult] MapError[TError,TResult,T](Microsoft.FSharp.Core.FSharpFunc`2[TError,TResult], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `FSharpResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### Bind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpResult`2[TResult,TError] Bind[T,TResult,TError](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpResult`2[TResult,TError]], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `FSharpResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `binder` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### IsOk (static) (generic)

**Signature:** `Boolean IsOk[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---

### IsError (static) (generic)

**Signature:** `Boolean IsError[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---

### DefaultValue (static) (generic)

**Signature:** `T DefaultValue[T,TError](T, Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### DefaultWith (static) (generic)

**Signature:** `T DefaultWith[TError,T](Microsoft.FSharp.Core.FSharpFunc`2[TError,T], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `defThunk` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### Count (static) (generic)

**Signature:** `Int32 Count[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---

### Fold (static) (generic)

**Signature:** `TState Fold[T,TError,TState](Microsoft.FSharp.Core.FSharpFunc`2[TState,Microsoft.FSharp.Core.FSharpFunc`2[T,TState]], TState, Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### FoldBack (static) (generic)

**Signature:** `TState FoldBack[T,TError,TState](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TState,TState]], Microsoft.FSharp.Core.FSharpResult`2[T,TError], TState)`
**Return Type:** `TState`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Exists (static) (generic)

**Signature:** `Boolean Exists[T,TError](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### ForAll (static) (generic)

**Signature:** `Boolean ForAll[T,TError](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### Contains (static) (generic)

**Signature:** `Boolean Contains[T,TError](T, Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[T,TError](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `result` | `FSharpResult`2` | No | `` |  |

---

### ToArray (static) (generic)

**Signature:** `T[] ToArray[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---

### ToList (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] ToList[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---

### ToOption (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] ToOption[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---

### ToValueOption (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] ToValueOption[T,TError](Microsoft.FSharp.Core.FSharpResult`2[T,TError])`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `FSharpResult`2` | No | `` |  |

---