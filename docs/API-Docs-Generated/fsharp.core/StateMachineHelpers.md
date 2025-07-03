# StateMachineHelpers Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.StateMachineHelpers`

Contains compiler intrinsics related to the definition of state machines.

## Methods

### __useResumableCode (static) (generic)

**Signature:** `Boolean __useResumableCode[T]()`
**Return Type:** `Boolean`

---

### __debugPoint (static)

**Signature:** `Void __debugPoint(System.String)`
**Return Type:** `Void`

**Description:** Indicates a named debug point arising from the context of inlined code.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_name` | `String` | No | `` |  |

---

### __resumableEntry (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int32] __resumableEntry()`
**Return Type:** `FSharpOption`1`

**Description:** Indicates a resumption point within resumable code

---

### __resumeAt (static) (generic)

**Signature:** `T __resumeAt[T](Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `programLabel` | `Int32` | No | `` |  |

---

### __stateMachine (static) (generic)

**Signature:** `TResult __stateMachine[TData,TResult](Microsoft.FSharp.Core.CompilerServices.MoveNextMethodImpl`1[TData], Microsoft.FSharp.Core.CompilerServices.SetStateMachineMethodImpl`1[TData], Microsoft.FSharp.Core.CompilerServices.AfterCode`2[TData,TResult])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `moveNextMethod` | `MoveNextMethodImpl`1` | No | `` |  |
| `setStateMachineMethod` | `SetStateMachineMethodImpl`1` | No | `` |  |
| `afterCode` | `AfterCode`2` | No | `` |  |

---