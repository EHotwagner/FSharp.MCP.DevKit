# GeneratedSequenceBase`1 Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.GeneratedSequenceBase`1`
- **Implements:** `System.Collections.IEnumerator`, `System.IDisposable`, ``, `System.Collections.IEnumerable`, ``
- **Generic Parameters:** `<T>`

The F# compiler emits implementations of this type for compiled sequence expressions.

## Methods

### GetFreshEnumerator

**Signature:** `System.Collections.Generic.IEnumerator`1[T] GetFreshEnumerator()`
**Return Type:** `IEnumerator`1`

**Description:** The F# compiler emits implementations of this type for compiled sequence expressions.

**Returns:** A new enumerator for the sequence.

---

### GenerateNext

**Signature:** `Int32 GenerateNext(System.Collections.Generic.IEnumerable`1[T] ByRef)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IEnumerable`1&` | No | `` |  |

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

**Description:** The F# compiler emits implementations of this type for compiled sequence expressions.

---

### get_CheckClose

**Signature:** `Boolean get_CheckClose()`
**Return Type:** `Boolean`

---

### get_LastGenerated

**Signature:** `T get_LastGenerated()`
**Return Type:** `T`

---

## Properties

### CheckClose

**Type:** `Boolean` (read-only)

**Description:** The F# compiler emits implementations of this type for compiled sequence expressions.

---

### LastGenerated

**Type:** `T` (read-only)

**Description:** The F# compiler emits implementations of this type for compiled sequence expressions.

---