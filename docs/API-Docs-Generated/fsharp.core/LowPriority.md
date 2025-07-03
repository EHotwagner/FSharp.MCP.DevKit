# LowPriority Class

**Namespace:** `Microsoft.FSharp.Control.TaskBuilderExtensions`
**Full Name:** `Microsoft.FSharp.Control.TaskBuilderExtensions.LowPriority`

Contains low-priority overloads for the `task` computation expression builder.

## Methods

### TaskBuilderBase.BindDynamic.Static (static) (generic)

**Signature:** `Boolean TaskBuilderBase.BindDynamic.Static[TTaskLike,TResult1,TResult2,TAwaiter,TOverall](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall]] ByRef, TTaskLike, Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `task` | `TTaskLike` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.BindDynamic.Static$W (static) (generic)

**Signature:** `Boolean TaskBuilderBase.BindDynamic.Static$W[TTaskLike,TResult1,TResult2,TAwaiter,TOverall](Microsoft.FSharp.Core.FSharpFunc`2[TTaskLike,TAwaiter], Microsoft.FSharp.Core.FSharpFunc`2[TAwaiter,TResult1], Microsoft.FSharp.Core.FSharpFunc`2[TAwaiter,System.Boolean], Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall]] ByRef, TTaskLike, Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `getAwaiter` | `FSharpFunc`2` | No | `` |  |
| `getResult` | `FSharpFunc`2` | No | `` |  |
| `get_IsCompleted` | `FSharpFunc`2` | No | `` |  |
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `task` | `TTaskLike` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.Bind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2] TaskBuilderBase.Bind[TTaskLike,TResult1,TResult2,TAwaiter,TOverall](Microsoft.FSharp.Control.TaskBuilderBase, TTaskLike, Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_` | `TaskBuilderBase` | No | `` |  |
| `task` | `TTaskLike` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.Bind$W (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2] TaskBuilderBase.Bind$W[TTaskLike,TResult1,TResult2,TAwaiter,TOverall](Microsoft.FSharp.Core.FSharpFunc`2[TTaskLike,TAwaiter], Microsoft.FSharp.Core.FSharpFunc`2[TAwaiter,TResult1], Microsoft.FSharp.Core.FSharpFunc`2[TAwaiter,System.Boolean], Microsoft.FSharp.Control.TaskBuilderBase, TTaskLike, Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `getAwaiter` | `FSharpFunc`2` | No | `` |  |
| `getResult` | `FSharpFunc`2` | No | `` |  |
| `get_IsCompleted` | `FSharpFunc`2` | No | `` |  |
| `_` | `TaskBuilderBase` | No | `` |  |
| `task` | `TTaskLike` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.ReturnFrom (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[T],T] TaskBuilderBase.ReturnFrom[TTaskLike,TAwaiter,T](Microsoft.FSharp.Control.TaskBuilderBase, TTaskLike)`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `TaskBuilderBase` | No | `` |  |
| `task` | `TTaskLike` | No | `` |  |

---

### TaskBuilderBase.ReturnFrom$W (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[T],T] TaskBuilderBase.ReturnFrom$W[TTaskLike,TAwaiter,T](Microsoft.FSharp.Core.FSharpFunc`2[TTaskLike,TAwaiter], Microsoft.FSharp.Core.FSharpFunc`2[TAwaiter,T], Microsoft.FSharp.Core.FSharpFunc`2[TAwaiter,System.Boolean], Microsoft.FSharp.Control.TaskBuilderBase, TTaskLike)`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `getAwaiter` | `FSharpFunc`2` | No | `` |  |
| `getResult` | `FSharpFunc`2` | No | `` |  |
| `get_IsCompleted` | `FSharpFunc`2` | No | `` |  |
| `this` | `TaskBuilderBase` | No | `` |  |
| `task` | `TTaskLike` | No | `` |  |

---

### TaskBuilderBase.Using (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T] TaskBuilderBase.Using[TResource,TOverall,T](Microsoft.FSharp.Control.TaskBuilderBase, TResource, Microsoft.FSharp.Core.FSharpFunc`2[TResource,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],T]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_` | `TaskBuilderBase` | No | `` |  |
| `resource` | `TResource` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---