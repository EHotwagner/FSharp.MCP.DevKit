# HighPriority Class

**Namespace:** `Microsoft.FSharp.Control.TaskBuilderExtensions`
**Full Name:** `Microsoft.FSharp.Control.TaskBuilderExtensions.HighPriority`

Contains high-priority overloads for the `task` computation expression builder.

## Methods

### TaskBuilderBase.BindDynamic.Static (static) (generic)

**Signature:** `Boolean TaskBuilderBase.BindDynamic.Static[TOverall,TResult1,TResult2](Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall]] ByRef, System.Threading.Tasks.Task`1[TResult1], Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sm` | `ResumableStateMachine`1&` | No | `` |  |
| `task` | `Task`1` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.Bind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2] TaskBuilderBase.Bind[TResult1,TOverall,TResult2](Microsoft.FSharp.Control.TaskBuilderBase, System.Threading.Tasks.Task`1[TResult1], Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_` | `TaskBuilderBase` | No | `` |  |
| `task` | `Task`1` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.ReturnFrom (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[T],T] TaskBuilderBase.ReturnFrom[T](Microsoft.FSharp.Control.TaskBuilderBase, System.Threading.Tasks.Task`1[T])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `TaskBuilderBase` | No | `` |  |
| `task` | `Task`1` | No | `` |  |

---