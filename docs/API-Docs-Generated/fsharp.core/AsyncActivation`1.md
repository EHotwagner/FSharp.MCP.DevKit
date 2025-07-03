# AsyncActivation`1 Struct

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.AsyncActivation`1`
- **Base Type:** `System.ValueType`
- **Generic Parameters:** `<T>`

The F# compiler emits references to this type to implement F# async expressions.

## Methods

### get_IsCancellationRequested

**Signature:** `Boolean get_IsCancellationRequested()`
**Return Type:** `Boolean`

---

### OnCancellation

**Signature:** `Microsoft.FSharp.Control.AsyncReturn OnCancellation()`
**Return Type:** `AsyncReturn`

**Description:** The F# compiler emits calls to this function to implement F# async expressions.

**Returns:** A value indicating asynchronous execution.

---

### Success (static)

**Signature:** `Microsoft.FSharp.Control.AsyncReturn Success(Microsoft.FSharp.Control.AsyncActivation`1[T], T)`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ctxt` | `AsyncActivation`1` | No | `` |  |
| `result` | `T` | No | `` |  |

---

### OnSuccess

**Signature:** `Microsoft.FSharp.Control.AsyncReturn OnSuccess(T)`
**Return Type:** `AsyncReturn`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `T` | No | `` |  |

---

### OnExceptionRaised

**Signature:** `Void OnExceptionRaised()`
**Return Type:** `Void`

**Description:** The F# compiler emits calls to this function to implement F# async expressions.

---

## Properties

### IsCancellationRequested

**Type:** `Boolean` (read-only)

**Description:** The F# compiler emits calls to this function to implement F# async expressions.

---