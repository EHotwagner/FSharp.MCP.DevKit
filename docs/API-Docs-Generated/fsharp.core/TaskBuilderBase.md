# TaskBuilderBase Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.TaskBuilderBase`

Contains methods to build tasks using the F# computation expression syntax

## Methods

### Delay (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T] Delay[TOverall,T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `generator` | `FSharpFunc`2` | No | `` |  |

---

### Zero (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],Microsoft.FSharp.Core.Unit] Zero[TOverall]()`
**Return Type:** `ResumableCode`2`

---

### Return (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[T],T] Return[T](T)`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Combine (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T] Combine[TOverall,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `task1` | `ResumableCode`2` | No | `` |  |
| `task2` | `ResumableCode`2` | No | `` |  |

---

### While (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],Microsoft.FSharp.Core.Unit] While[TOverall](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Boolean], Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],Microsoft.FSharp.Core.Unit])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `condition` | `FSharpFunc`2` | No | `` |  |
| `body` | `ResumableCode`2` | No | `` |  |

---

### TryWith (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T] TryWith[TOverall,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `ResumableCode`2` | No | `` |  |
| `catch` | `FSharpFunc`2` | No | `` |  |

---

### TryFinally (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T] TryFinally[TOverall,T](Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `ResumableCode`2` | No | `` |  |
| `compensation` | `FSharpFunc`2` | No | `` |  |

---

### For (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],Microsoft.FSharp.Core.Unit] For[T,TOverall](System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],Microsoft.FSharp.Core.Unit]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sequence` | `IEnumerable`1` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### Using (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T] Using[TResource,TOverall,T](TResource, Microsoft.FSharp.Core.FSharpFunc`2[TResource,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `resource` | `TResource` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---