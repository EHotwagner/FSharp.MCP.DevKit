# ResumptionDynamicInfo`1 Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ResumptionDynamicInfo`1`
- **Generic Parameters:** `<TData>`

Represents the delegated runtime continuation of a resumable state machine created dynamically

## Methods

### MoveNext

**Signature:** `Void MoveNext(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `machine` | `ResumableStateMachine`1&` | No | `` |  |

---

### SetStateMachine

**Signature:** `Void SetStateMachine(Microsoft.FSharp.Core.CompilerServices.ResumableStateMachine`1[TData] ByRef, System.Runtime.CompilerServices.IAsyncStateMachine)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `machine` | `ResumableStateMachine`1&` | No | `` |  |
| `machineState` | `IAsyncStateMachine` | No | `` |  |

---

### get_ResumptionFunc

**Signature:** `Microsoft.FSharp.Core.CompilerServices.ResumptionFunc`1[TData] get_ResumptionFunc()`
**Return Type:** `ResumptionFunc`1`

---

### set_ResumptionFunc

**Signature:** `Void set_ResumptionFunc(Microsoft.FSharp.Core.CompilerServices.ResumptionFunc`1[TData])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `ResumptionFunc`1` | No | `` |  |

---

### get_ResumptionData

**Signature:** `System.Object get_ResumptionData()`
**Return Type:** `Object`

---

### set_ResumptionData

**Signature:** `Void set_ResumptionData(System.Object)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Object` | No | `` |  |

---

## Properties

### ResumptionFunc

**Type:** `ResumptionFunc`1` (read/write)

**Description:** The continuation of the state machine

---

### ResumptionData

**Type:** `Object` (read/write)

**Description:** Additional data associated with the state machine

---