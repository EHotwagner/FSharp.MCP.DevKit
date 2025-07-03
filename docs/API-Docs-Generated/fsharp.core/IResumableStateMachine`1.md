# IResumableStateMachine`1 Interface

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.IResumableStateMachine`1`
- **Generic Parameters:** `<TData>`

## Methods

### get_ResumptionPoint

**Signature:** `Int32 get_ResumptionPoint()`
**Return Type:** `Int32`

---

### get_Data

**Signature:** `TData get_Data()`
**Return Type:** `TData`

---

### set_Data

**Signature:** `Void set_Data(TData)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `TData` | No | `` |  |

---

## Properties

### ResumptionPoint

**Type:** `Int32` (read-only)

**Description:** Get the resumption point of the state machine

---

### Data

**Type:** `TData` (read/write)

**Description:** Copy-out or copy-in the data of the state machine

---