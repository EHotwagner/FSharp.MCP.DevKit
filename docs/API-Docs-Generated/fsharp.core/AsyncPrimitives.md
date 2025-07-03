# AsyncPrimitives Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.AsyncPrimitives`

Entry points for generated code

## Methods

### Invoke (static) (generic)

**Signature:** `Microsoft.FSharp.Control.AsyncReturn Invoke[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Control.AsyncActivation`1[T])`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `ctxt` | `AsyncActivation`1` | No | `` |  |

---

### CallThenInvoke (static) (generic)

**Signature:** `Microsoft.FSharp.Control.AsyncReturn CallThenInvoke[T,TResult](Microsoft.FSharp.Control.AsyncActivation`1[T], TResult, Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ctxt` | `AsyncActivation`1` | No | `` |  |
| `result1` | `TResult` | No | `` |  |
| `part2` | `FSharpFunc`2` | No | `` |  |

---

### MakeAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] MakeAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.AsyncActivation`1[T],Microsoft.FSharp.Control.AsyncReturn])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpFunc`2` | No | `` |  |

---

### Bind (static) (generic)

**Signature:** `Microsoft.FSharp.Control.AsyncReturn Bind[T,TResult](Microsoft.FSharp.Control.AsyncActivation`1[T], Microsoft.FSharp.Control.FSharpAsync`1[TResult], Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ctxt` | `AsyncActivation`1` | No | `` |  |
| `part1` | `FSharpAsync`1` | No | `` |  |
| `part2` | `FSharpFunc`2` | No | `` |  |

---

### TryFinally (static) (generic)

**Signature:** `Microsoft.FSharp.Control.AsyncReturn TryFinally[T](Microsoft.FSharp.Control.AsyncActivation`1[T], Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ctxt` | `AsyncActivation`1` | No | `` |  |
| `computation` | `FSharpAsync`1` | No | `` |  |
| `finallyFunction` | `FSharpFunc`2` | No | `` |  |

---

### TryWith (static) (generic)

**Signature:** `Microsoft.FSharp.Control.AsyncReturn TryWith[T](Microsoft.FSharp.Control.AsyncActivation`1[T], Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Control.FSharpAsync`1[T]]])`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ctxt` | `AsyncActivation`1` | No | `` |  |
| `computation` | `FSharpAsync`1` | No | `` |  |
| `catchFunction` | `FSharpFunc`2` | No | `` |  |

---