# FSharpAsyncBuilder Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.FSharpAsyncBuilder`

The type of the async operator, used to build workflows for asynchronous computations.

## Methods

### Zero

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] Zero()`
**Return Type:** `FSharpAsync`1`

**Description:** Creates an asynchronous computation that just returns ().

**Returns:** An asynchronous computation that returns ().

---

### Delay (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] Delay[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `generator` | `FSharpFunc`2` | No | `` |  |

---

### Return (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] Return[T](T)`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ReturnFrom (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] ReturnFrom[T](Microsoft.FSharp.Control.FSharpAsync`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |

---

### Bind (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[TResult] Bind[T,TResult](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[TResult]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `binder` | `FSharpFunc`2` | No | `` |  |

---

### Using (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[TResult] Using[T,TResult](T, Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[TResult]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `resource` | `T` | No | `` |  |
| `binder` | `FSharpFunc`2` | No | `` |  |

---

### While

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] While(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Boolean], Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `guard` | `FSharpFunc`2` | No | `` |  |
| `computation` | `FSharpAsync`1` | No | `` |  |

---

### For (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] For[T](System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sequence` | `IEnumerable`1` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### Combine (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] Combine[T](Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Control.FSharpAsync`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation1` | `FSharpAsync`1` | No | `` |  |
| `computation2` | `FSharpAsync`1` | No | `` |  |

---

### TryFinally (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] TryFinally[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `compensation` | `FSharpFunc`2` | No | `` |  |

---

### TryWith (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] TryWith[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `catchHandler` | `FSharpFunc`2` | No | `` |  |

---