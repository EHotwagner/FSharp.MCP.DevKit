# FSharpFunc`2 Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FSharpFunc`2`
- **Generic Parameters:** `<T, TResult>`

The CLI type used to represent F# function values. This type is not
 typically used directly, though may be used from other CLI languages.

## Methods

### Invoke

**Signature:** `TResult Invoke(T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `T` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T,TResult] op_Implicit(System.Converter`2[T,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Converter`2` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `System.Converter`2[T,TResult] op_Implicit(Microsoft.FSharp.Core.FSharpFunc`2[T,TResult])`
**Return Type:** `Converter`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |

---

### FromConverter (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T,TResult] FromConverter(System.Converter`2[T,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `converter` | `Converter`2` | No | `` |  |

---

### ToConverter (static)

**Signature:** `System.Converter`2[T,TResult] ToConverter(Microsoft.FSharp.Core.FSharpFunc`2[T,TResult])`
**Return Type:** `Converter`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |

---

### InvokeFast (static) (generic)

**Signature:** `V InvokeFast[V](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TResult,V]], T, TResult)`
**Return Type:** `V`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T` | No | `` |  |
| `arg2` | `TResult` | No | `` |  |

---

### InvokeFast (static) (generic)

**Signature:** `W InvokeFast[V,W](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[V,W]]], T, TResult, V)`
**Return Type:** `W`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T` | No | `` |  |
| `arg2` | `TResult` | No | `` |  |
| `arg3` | `V` | No | `` |  |

---

### InvokeFast (static) (generic)

**Signature:** `X InvokeFast[V,W,X](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[V,Microsoft.FSharp.Core.FSharpFunc`2[W,X]]]], T, TResult, V, W)`
**Return Type:** `X`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T` | No | `` |  |
| `arg2` | `TResult` | No | `` |  |
| `arg3` | `V` | No | `` |  |
| `arg4` | `W` | No | `` |  |

---

### InvokeFast (static) (generic)

**Signature:** `Y InvokeFast[V,W,X,Y](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[V,Microsoft.FSharp.Core.FSharpFunc`2[W,Microsoft.FSharp.Core.FSharpFunc`2[X,Y]]]]], T, TResult, V, W, X)`
**Return Type:** `Y`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T` | No | `` |  |
| `arg2` | `TResult` | No | `` |  |
| `arg3` | `V` | No | `` |  |
| `arg4` | `W` | No | `` |  |
| `arg5` | `X` | No | `` |  |

---