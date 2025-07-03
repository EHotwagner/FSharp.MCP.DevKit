# SetStateMachineMethodImpl`1 Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.SetStateMachineMethodImpl`1`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`
- **Generic Parameters:** `<TData>`

Defines the implementation of the SetStateMachine method for a struct state machine.

## Methods

### Invoke

**Signature:** `Void Invoke(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, System.Runtime.CompilerServices.IAsyncStateMachine)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ResumableStateMachine`1&` | No | `` |  |
| `` | `IAsyncStateMachine` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, System.Runtime.CompilerServices.IAsyncStateMachine, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ResumableStateMachine`1&` | No | `` |  |
| `` | `IAsyncStateMachine` | No | `` |  |
| `callback` | `AsyncCallback` | No | `` |  |
| `objects` | `Object` | No | `` |  |

---

### EndInvoke

**Signature:** `Void EndInvoke(System.IAsyncResult)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IAsyncResult` | No | `` |  |

---