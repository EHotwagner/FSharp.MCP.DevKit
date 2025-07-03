# AsyncSeqExtensions Class

**Namespace:** `FSharp.Control`
**Full Name:** `FSharp.Control.AsyncSeqExtensions`

An automatically-opened module that contains the `asyncSeq` builder and an extension method

## Methods

### get_asyncSeq (static)

**Signature:** `AsyncSeqBuilder get_asyncSeq()`
**Return Type:** `AsyncSeqBuilder`

---

### AsyncBuilder.For (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] AsyncBuilder.For[T](Microsoft.FSharp.Control.FSharpAsyncBuilder, FSharp.Control.IAsyncEnumerable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `FSharpAsyncBuilder` | No | `` |  |
| `seq` | `IAsyncEnumerable`1` | No | `` |  |
| `action` | `FSharpFunc`2` | No | `` |  |

---

## Properties

### asyncSeq (static)

**Type:** `AsyncSeqBuilder` (read-only)

**Description:** Builds an asynchronous sequence using the computation builder syntax

---