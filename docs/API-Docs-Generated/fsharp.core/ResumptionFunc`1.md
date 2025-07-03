# ResumptionFunc`1 Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumptionFunc`1`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`
- **Generic Parameters:** `<TData>`

Represents the runtime continuation of a resumable state machine created dynamically

## Methods

### Invoke

**Signature:** `Boolean Invoke(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef)`
**Return Type:** `Boolean`

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

**Signature:** `Boolean EndInvoke(System.IAsyncResult)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IAsyncResult` | No | `` |  |

---