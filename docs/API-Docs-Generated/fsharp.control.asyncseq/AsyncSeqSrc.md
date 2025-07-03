# AsyncSeqSrc Class

**Namespace:** `FSharp.Control`
**Full Name:** `FSharp.Control.AsyncSeqSrc`

Operations on async sequence sources.

## Methods

### create (static) (generic)

**Signature:** `FSharp.Control.AsyncSeqSrc`1[T] create[T]()`
**Return Type:** `AsyncSeqSrc`1`

---

### put (static) (generic)

**Signature:** `Void put[T](T, FSharp.Control.AsyncSeqSrc`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `T` | No | `` |  |
| `src` | `AsyncSeqSrc`1` | No | `` |  |

---

### close (static) (generic)

**Signature:** `Void close[T](FSharp.Control.AsyncSeqSrc`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `src` | `AsyncSeqSrc`1` | No | `` |  |

---

### toAsyncSeq (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] toAsyncSeq[T](FSharp.Control.AsyncSeqSrc`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `src` | `AsyncSeqSrc`1` | No | `` |  |

---

### error (static) (generic)

**Signature:** `Void error[T](System.Exception, FSharp.Control.AsyncSeqSrc`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exn` | `Exception` | No | `` |  |
| `src` | `AsyncSeqSrc`1` | No | `` |  |

---