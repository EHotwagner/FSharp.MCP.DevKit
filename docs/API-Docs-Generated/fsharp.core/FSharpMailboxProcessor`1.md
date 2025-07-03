# FSharpMailboxProcessor`1 Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.FSharpMailboxProcessor`1`
- **Implements:** `System.IDisposable`
- **Generic Parameters:** `<TMsg>`

A message-processing agent which executes an asynchronous computation.

## Methods

### get_CurrentQueueLength

**Signature:** `Int32 get_CurrentQueueLength()`
**Return Type:** `Int32`

---

### get_DefaultTimeout

**Signature:** `Int32 get_DefaultTimeout()`
**Return Type:** `Int32`

---

### set_DefaultTimeout

**Signature:** `Void set_DefaultTimeout(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Int32` | No | `` |  |

---

### add_Error

**Signature:** `Void add_Error(Microsoft.FSharp.Control.FSharpHandler`1[System.Exception])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `handler` | `FSharpHandler`1` | No | `` |  |

---

### remove_Error

**Signature:** `Void remove_Error(Microsoft.FSharp.Control.FSharpHandler`1[System.Exception])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `handler` | `FSharpHandler`1` | No | `` |  |

---

### Start

**Signature:** `Void Start()`
**Return Type:** `Void`

**Description:** Starts the agent.

---

### StartImmediate

**Signature:** `Void StartImmediate()`
**Return Type:** `Void`

**Description:** Starts the agent immediately on the current operating system thread.

---

### Post

**Signature:** `Void Post(TMsg)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `TMsg` | No | `` |  |

---

### TryPostAndReply (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[TReply] TryPostAndReply[TReply](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpAsyncReplyChannel`1[TReply],TMsg], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `buildMessage` | `FSharpFunc`2` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### PostAndReply (generic)

**Signature:** `TReply PostAndReply[TReply](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpAsyncReplyChannel`1[TReply],TMsg], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `TReply`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `buildMessage` | `FSharpFunc`2` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### PostAndTryAsyncReply (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[TReply]] PostAndTryAsyncReply[TReply](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpAsyncReplyChannel`1[TReply],TMsg], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `buildMessage` | `FSharpFunc`2` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### PostAndAsyncReply (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[TReply] PostAndAsyncReply[TReply](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpAsyncReplyChannel`1[TReply],TMsg], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `buildMessage` | `FSharpFunc`2` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### Receive

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[TMsg] Receive(Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### TryReceive

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[TMsg]] TryReceive(Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### Scan (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] Scan[T](Microsoft.FSharp.Core.FSharpFunc`2[TMsg,Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Control.FSharpAsync`1[T]]], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `scanner` | `FSharpFunc`2` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### TryScan (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]] TryScan[T](Microsoft.FSharp.Core.FSharpFunc`2[TMsg,Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Control.FSharpAsync`1[T]]], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `scanner` | `FSharpFunc`2` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

**Description:** Disposes the agent's internal resources.

---

### Start (static)

**Signature:** `Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg] Start(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg],Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `FSharpMailboxProcessor`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpFunc`2` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### Start (static)

**Signature:** `Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg] Start(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg],Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], Boolean, Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `FSharpMailboxProcessor`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpFunc`2` | No | `` |  |
| `isThrowExceptionAfterDisposed` | `Boolean` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### StartImmediate (static)

**Signature:** `Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg] StartImmediate(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg],Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `FSharpMailboxProcessor`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpFunc`2` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### StartImmediate (static)

**Signature:** `Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg] StartImmediate(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpMailboxProcessor`1[TMsg],Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], Boolean, Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `FSharpMailboxProcessor`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpFunc`2` | No | `` |  |
| `isThrowExceptionAfterDisposed` | `Boolean` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

## Properties

### CurrentQueueLength

**Type:** `Int32` (read-only)

**Description:** Returns the number of unprocessed messages in the message queue of the agent.

---

### DefaultTimeout

**Type:** `Int32` (read/write)

**Description:** Raises a timeout exception if a message not received in this amount of time. By default
 no timeout is used.

---