# FSharpAsync Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.FSharpAsync`

Holds static members for creating and manipulating asynchronous computations.

## Methods

### get_CancellationToken (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Threading.CancellationToken] get_CancellationToken()`
**Return Type:** `FSharpAsync`1`

---

### FromContinuations (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] FromContinuations[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Core.FSharpFunc`2[System.OperationCanceledException,Microsoft.FSharp.Core.Unit]],Microsoft.FSharp.Core.Unit])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `callback` | `FSharpFunc`2` | No | `` |  |

---

### get_DefaultCancellationToken (static)

**Signature:** `System.Threading.CancellationToken get_DefaultCancellationToken()`
**Return Type:** `CancellationToken`

---

### CancelDefaultToken (static)

**Signature:** `Void CancelDefaultToken()`
**Return Type:** `Void`

**Description:** Raises the cancellation condition for the most recent set of asynchronous computations started 
 without any specific CancellationToken. Replaces the global CancellationTokenSource with a new 
 global token source for any asynchronous computations created after this point without any 
 specific CancellationToken.

---

### Catch (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpChoice`2[T,System.Exception]] Catch[T](Microsoft.FSharp.Control.FSharpAsync`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |

---

### RunSynchronously (static) (generic)

**Signature:** `T RunSynchronously[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpOption`1[System.Int32], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `timeout` | `FSharpOption`1` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### Start (static)

**Signature:** `Void Start(Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### StartAsTask (static) (generic)

**Signature:** `System.Threading.Tasks.Task`1[T] StartAsTask[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.Tasks.TaskCreationOptions], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `taskCreationOptions` | `FSharpOption`1` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### StartChildAsTask (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Threading.Tasks.Task`1[T]] StartChildAsTask[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.Tasks.TaskCreationOptions])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `taskCreationOptions` | `FSharpOption`1` | No | `` |  |

---

### Parallel (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T[]] Parallel[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computations` | `IEnumerable`1` | No | `` |  |

---

### Parallel (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T[]] Parallel[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Control.FSharpAsync`1[T]], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computations` | `IEnumerable`1` | No | `` |  |
| `maxDegreeOfParallelism` | `FSharpOption`1` | No | `` |  |

---

### Sequential (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T[]] Sequential[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computations` | `IEnumerable`1` | No | `` |  |

---

### Choice (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]] Choice[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computations` | `IEnumerable`1` | No | `` |  |

---

### StartWithContinuations (static) (generic)

**Signature:** `Void StartWithContinuations[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpFunc`2[System.OperationCanceledException,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `continuation` | `FSharpFunc`2` | No | `` |  |
| `exceptionContinuation` | `FSharpFunc`2` | No | `` |  |
| `cancellationContinuation` | `FSharpFunc`2` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### StartImmediateAsTask (static) (generic)

**Signature:** `System.Threading.Tasks.Task`1[T] StartImmediateAsTask[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### StartImmediate (static)

**Signature:** `Void StartImmediate(Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpOption`1[System.Threading.CancellationToken])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `cancellationToken` | `FSharpOption`1` | No | `` |  |

---

### Sleep (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] Sleep(Int32)`
**Return Type:** `FSharpAsync`1`

**Description:** Creates an asynchronous computation that will sleep for the given time. This is scheduled
  using a System.Threading.Timer object. The operation will not block operating system threads
  for the duration of the wait.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `millisecondsDueTime` | `Int32` | No | `` | The number of milliseconds to sleep. |

**Returns:** An asynchronous computation that will sleep for the given time.

---

### Sleep (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] Sleep(System.TimeSpan)`
**Return Type:** `FSharpAsync`1`

**Description:** Creates an asynchronous computation that will sleep for the given time. This is scheduled
  using a System.Threading.Timer object. The operation will not block operating system threads
  for the duration of the wait.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dueTime` | `TimeSpan` | No | `` | The amount of time to sleep. |

**Returns:** An asynchronous computation that will sleep for the given time.

---

### AwaitWaitHandle (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean] AwaitWaitHandle(System.Threading.WaitHandle, Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `waitHandle` | `WaitHandle` | No | `` |  |
| `millisecondsTimeout` | `FSharpOption`1` | No | `` |  |

---

### AwaitIAsyncResult (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean] AwaitIAsyncResult(System.IAsyncResult, Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `iar` | `IAsyncResult` | No | `` |  |
| `millisecondsTimeout` | `FSharpOption`1` | No | `` |  |

---

### FromBeginEnd (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] FromBeginEnd[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`2[System.AsyncCallback,System.Object],System.IAsyncResult], Microsoft.FSharp.Core.FSharpFunc`2[System.IAsyncResult,T], Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `beginAction` | `FSharpFunc`2` | No | `` |  |
| `endAction` | `FSharpFunc`2` | No | `` |  |
| `cancelAction` | `FSharpOption`1` | No | `` |  |

---

### FromBeginEnd (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] FromBeginEnd[TArg1,T](TArg1, Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[TArg1,System.AsyncCallback,System.Object],System.IAsyncResult], Microsoft.FSharp.Core.FSharpFunc`2[System.IAsyncResult,T], Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg` | `TArg1` | No | `` |  |
| `beginAction` | `FSharpFunc`2` | No | `` |  |
| `endAction` | `FSharpFunc`2` | No | `` |  |
| `cancelAction` | `FSharpOption`1` | No | `` |  |

---

### FromBeginEnd (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] FromBeginEnd[TArg1,TArg2,T](TArg1, TArg2, Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`4[TArg1,TArg2,System.AsyncCallback,System.Object],System.IAsyncResult], Microsoft.FSharp.Core.FSharpFunc`2[System.IAsyncResult,T], Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg1` | `TArg1` | No | `` |  |
| `arg2` | `TArg2` | No | `` |  |
| `beginAction` | `FSharpFunc`2` | No | `` |  |
| `endAction` | `FSharpFunc`2` | No | `` |  |
| `cancelAction` | `FSharpOption`1` | No | `` |  |

---

### FromBeginEnd (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] FromBeginEnd[TArg1,TArg2,TArg3,T](TArg1, TArg2, TArg3, Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`5[TArg1,TArg2,TArg3,System.AsyncCallback,System.Object],System.IAsyncResult], Microsoft.FSharp.Core.FSharpFunc`2[System.IAsyncResult,T], Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg1` | `TArg1` | No | `` |  |
| `arg2` | `TArg2` | No | `` |  |
| `arg3` | `TArg3` | No | `` |  |
| `beginAction` | `FSharpFunc`2` | No | `` |  |
| `endAction` | `FSharpFunc`2` | No | `` |  |
| `cancelAction` | `FSharpOption`1` | No | `` |  |

---

### AsBeginEnd (static) (generic)

**Signature:** `System.Tuple`3[Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[TArg,System.AsyncCallback,System.Object],System.IAsyncResult],Microsoft.FSharp.Core.FSharpFunc`2[System.IAsyncResult,T],Microsoft.FSharp.Core.FSharpFunc`2[System.IAsyncResult,Microsoft.FSharp.Core.Unit]] AsBeginEnd[TArg,T](Microsoft.FSharp.Core.FSharpFunc`2[TArg,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `Tuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpFunc`2` | No | `` |  |

---

### AwaitEvent (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] AwaitEvent[TDel,T](Microsoft.FSharp.Control.IEvent`2[TDel,T], Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `event` | `IEvent`2` | No | `` |  |
| `cancelAction` | `FSharpOption`1` | No | `` |  |

---

### Ignore (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] Ignore[T](Microsoft.FSharp.Control.FSharpAsync`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |

---

### SwitchToNewThread (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] SwitchToNewThread()`
**Return Type:** `FSharpAsync`1`

**Description:** Creates an asynchronous computation that creates a new thread and runs
 its continuation in that thread.

**Returns:** A computation that will execute on a new thread.

---

### SwitchToThreadPool (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] SwitchToThreadPool()`
**Return Type:** `FSharpAsync`1`

**Description:** Creates an asynchronous computation that queues a work item that runs
 its continuation.

**Returns:** A computation that generates a new work item in the thread pool.

---

### StartChild (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Control.FSharpAsync`1[T]] StartChild[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpOption`1[System.Int32])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `millisecondsTimeout` | `FSharpOption`1` | No | `` |  |

---

### SwitchToContext (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] SwitchToContext(System.Threading.SynchronizationContext)`
**Return Type:** `FSharpAsync`1`

**Description:** Creates an asynchronous computation that runs
 its continuation using syncContext.Post. If syncContext is null 
 then the asynchronous computation is equivalent to SwitchToThreadPool().

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `syncContext` | `SynchronizationContext` | No | `` | The synchronization context to accept the posted computation. |

**Returns:** An asynchronous computation that uses the syncContext context to execute.

---

### OnCancel (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.IDisposable] OnCancel(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `interruption` | `FSharpFunc`2` | No | `` |  |

---

### TryCancelled (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] TryCancelled[T](Microsoft.FSharp.Control.FSharpAsync`1[T], Microsoft.FSharp.Core.FSharpFunc`2[System.OperationCanceledException,Microsoft.FSharp.Core.Unit])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `FSharpAsync`1` | No | `` |  |
| `compensation` | `FSharpFunc`2` | No | `` |  |

---

### AwaitTask (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] AwaitTask[T](System.Threading.Tasks.Task`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `task` | `Task`1` | No | `` |  |

---

### AwaitTask (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] AwaitTask(System.Threading.Tasks.Task)`
**Return Type:** `FSharpAsync`1`

**Description:** Return an asynchronous computation that will wait for the given task to complete and return
 its result.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `task` | `Task` | No | `` | The task to await. |

---

## Properties

### CancellationToken (static)

**Type:** `FSharpAsync`1` (read-only)

**Description:** Creates an asynchronous computation that returns the CancellationToken governing the execution 
 of the computation.

---

### DefaultCancellationToken (static)

**Type:** `CancellationToken` (read-only)

**Description:** Gets the default cancellation token for executing asynchronous computations.

---