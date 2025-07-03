# ResumableCode Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`

Contains functions for composing resumable code blocks

## Methods

### Delay (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T] Delay[TData,T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### Zero (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit] Zero[TData]()`
**Return Type:** `ResumableCode`2`

---

### CombineDynamic (static) (generic)

**Signature:** `Boolean CombineDynamic[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `code1` | `ResumableCode`2` | No | `` |  |
| `code2` | `ResumableCode`2` | No | `` |  |

---

### Combine (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T] Combine[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `code1` | `ResumableCode`2` | No | `` |  |
| `code2` | `ResumableCode`2` | No | `` |  |

---

### WhileDynamic (static) (generic)

**Signature:** `Boolean WhileDynamic[TData](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Boolean], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `condition` | `FSharpFunc`2` | No | `` |  |
| `body` | `ResumableCode`2` | No | `` |  |

---

### While (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit] While[TData](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Boolean], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `condition` | `FSharpFunc`2` | No | `` |  |
| `body` | `ResumableCode`2` | No | `` |  |

---

### TryWithDynamic (static) (generic)

**Signature:** `Boolean TryWithDynamic[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T]])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `body` | `ResumableCode`2` | No | `` |  |
| `handler` | `FSharpFunc`2` | No | `` |  |

---

### TryWith (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T] TryWith[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `ResumableCode`2` | No | `` |  |
| `catch` | `FSharpFunc`2` | No | `` |  |

---

### TryFinallyAsyncDynamic (static) (generic)

**Signature:** `Boolean TryFinallyAsyncDynamic[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `body` | `ResumableCode`2` | No | `` |  |
| `compensation` | `ResumableCode`2` | No | `` |  |

---

### TryFinally (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T] TryFinally[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `ResumableCode`2` | No | `` |  |
| `compensation` | `ResumableCode`2` | No | `` |  |

---

### TryFinallyAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T] TryFinallyAsync[TData,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `ResumableCode`2` | No | `` |  |
| `compensation` | `ResumableCode`2` | No | `` |  |

---

### Using (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T] Using[TResource,TData,T](TResource, Microsoft.FSharp.Core.FSharpFunc`2[TResource,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `resource` | `TResource` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### For (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit] For[T,TData](System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sequence` | `IEnumerable`1` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### YieldDynamic (static) (generic)

**Signature:** `Boolean YieldDynamic[TData](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |

---

### Yield (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[TData,Microsoft.FSharp.Core.Unit] Yield[TData]()`
**Return Type:** `ResumableCode`2`

---