# AfterCode`2 Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.AfterCode`2`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`
- **Generic Parameters:** `<TData, TResult>`

Defines the implementation of the code run after the creation of a struct state machine.

## Methods

### Invoke

**Signature:** `TResult Invoke(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ResumableStateMachine`1&` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ResumableStateMachine`1&` | No | `` |  |
| `callback` | `AsyncCallback` | No | `` |  |
| `objects` | `Object` | No | `` |  |

---

### EndInvoke

**Signature:** `TResult EndInvoke(System.IAsyncResult)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IAsyncResult` | No | `` |  |

---