# MediumPriority Class

**Namespace:** `Microsoft.FSharp.Control.TaskBuilderExtensions`
**Full Name:** `Microsoft.FSharp.Control.TaskBuilderExtensions.MediumPriority`

Contains medium-priority overloads for the `task` computation expression builder.

## Methods

### TaskBuilderBase.Bind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2] TaskBuilderBase.Bind[TResult1,TOverall,TResult2](Microsoft.FSharp.Control.TaskBuilderBase, Microsoft.FSharp.Control.FSharpAsync`1[TResult1], Microsoft.FSharp.Core.FSharpFunc`2[TResult1,Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[TOverall],TResult2]])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `TaskBuilderBase` | No | `` |  |
| `computation` | `FSharpAsync`1` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |

---

### TaskBuilderBase.ReturnFrom (static) (generic)

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumableCode`2[Microsoft.FSharp.Control.TaskStateMachineData`1[T],T] TaskBuilderBase.ReturnFrom[T](Microsoft.FSharp.Control.TaskBuilderBase, Microsoft.FSharp.Control.FSharpAsync`1[T])`
**Return Type:** `ResumableCode`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `TaskBuilderBase` | No | `` |  |
| `computation` | `FSharpAsync`1` | No | `` |  |

---