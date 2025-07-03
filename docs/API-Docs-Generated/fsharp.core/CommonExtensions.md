# CommonExtensions Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.CommonExtensions`

A module of extension members providing asynchronous operations for some basic CLI types related to concurrency and I/O.

## Methods

### AsyncRead (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Int32] AsyncRead(System.IO.Stream, Byte[], Microsoft.FSharp.Core.FSharpOption`1[System.Int32], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stream` | `Stream` | No | `` |  |
| `buffer` | `Byte[]` | No | `` |  |
| `offset` | `FSharpOption`1` | No | `` |  |
| `count` | `FSharpOption`1` | No | `` |  |

---

### AsyncReadBytes (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Byte[]] AsyncReadBytes(System.IO.Stream, Int32)`
**Return Type:** `FSharpAsync`1`

**Description:** Returns an asynchronous computation that will read the given number of bytes from the stream.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stream` | `Stream` | No | `` |  |
| `count` | `Int32` | No | `` | The number of bytes to read. |

**Returns:** An asynchronous computation that returns the read byte array when run.

---

### AsyncWrite (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] AsyncWrite(System.IO.Stream, Byte[], Microsoft.FSharp.Core.FSharpOption`1[System.Int32], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stream` | `Stream` | No | `` |  |
| `buffer` | `Byte[]` | No | `` |  |
| `offset` | `FSharpOption`1` | No | `` |  |
| `count` | `FSharpOption`1` | No | `` |  |

---

### AddToObservable (static) (generic)

**Signature:** `Void AddToObservable[T](System.IObservable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `IObservable`1` | No | `` |  |
| `callback` | `FSharpFunc`2` | No | `` |  |

---

### SubscribeToObservable (static) (generic)

**Signature:** `System.IDisposable SubscribeToObservable[T](System.IObservable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `IObservable`1` | No | `` |  |
| `callback` | `FSharpFunc`2` | No | `` |  |

---