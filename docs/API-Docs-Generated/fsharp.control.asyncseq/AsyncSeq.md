# AsyncSeq Class

**Namespace:** `FSharp.Control`
**Full Name:** `FSharp.Control.AsyncSeq`

## Methods

### empty (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] empty[T]()`
**Return Type:** `IAsyncEnumerable`1`

---

### singleton (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] singleton[T](T)`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `T` | No | `` |  |

---

### append (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] append[T](FSharp.Control.IAsyncEnumerable`1[T], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `seq1` | `IAsyncEnumerable`1` | No | `` |  |
| `seq2` | `IAsyncEnumerable`1` | No | `` |  |

---

### collect (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[TResult] collect[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,FSharp.Control.IAsyncEnumerable`1[TResult]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### ofSeq (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] ofSeq[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |

---

### iteriAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] iteriAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### iterAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] iterAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### unfoldAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] unfoldAsync[State,T](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[T,State]]]], State)`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `generator` | `FSharpFunc`2` | No | `` |  |
| `state` | `State` | No | `` |  |

---

### replicateInfinite (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] replicateInfinite[T](T)`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `T` | No | `` |  |

---

### replicateInfiniteAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] replicateInfiniteAsync[T](Microsoft.FSharp.Control.FSharpAsync`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `FSharpAsync`1` | No | `` |  |

---

### replicate (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] replicate[T](Int32, T)`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `v` | `T` | No | `` |  |

---

### replicateUntilNoneAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] replicateUntilNoneAsync[T](Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `next` | `FSharpAsync`1` | No | `` |  |

---

### intervalMs (static)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.DateTime] intervalMs(Int32)`
**Return Type:** `IAsyncEnumerable`1`

**Description:** Returns an async sequence which emits an element on a specified period.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `periodMs` | `Int32` | No | `` |  |

---

### mapAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[TResult] mapAsync[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[TResult]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### mapiAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] mapiAsync[T,U](Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[U]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### mapAsyncParallel (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] mapAsyncParallel[T,U](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[U]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `s` | `IAsyncEnumerable`1` | No | `` |  |

---

### chooseAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[R] chooseAsync[T,R](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[R]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### ofSeqAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] ofSeqAsync[T](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |

---

### filterAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] filterAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### tryLast (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]] tryLast[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### lastOrDefault (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] lastOrDefault[T](T, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `default` | `T` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### tryFirst (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]] tryFirst[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### firstOrDefault (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] firstOrDefault[T](T, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `default` | `T` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### scanAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[State] scanAsync[State,T](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[State]]], State, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `State` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### pairwise (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[T,T]] pairwise[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### pickAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[TResult] pickAsync[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[TResult]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### pick (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[TResult] pick[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### tryPickAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[TResult]] tryPickAsync[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[TResult]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### tryPick (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[TResult]] tryPick[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### contains (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean] contains[T](T, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### tryFind (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]] tryFind[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### exists (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean] exists[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### forall (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean] forall[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### foldAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[State] foldAsync[State,T](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[State]]], State, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `State` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### fold (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[State] fold[State,T](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Core.FSharpFunc`2[T,State]], State, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `State` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### length (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Int64] length[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### sum (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T] sum[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### scan (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[State] scan[State,T](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Core.FSharpFunc`2[T,State]], State, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `state` | `State` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### unfold (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] unfold[State,T](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[T,State]]], State)`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `generator` | `FSharpFunc`2` | No | `` |  |
| `state` | `State` | No | `` |  |

---

### initInfiniteAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] initInfiniteAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |

---

### initAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] initAsync[T](Int64, Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,Microsoft.FSharp.Control.FSharpAsync`1[T]])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int64` | No | `` |  |
| `mapping` | `FSharpFunc`2` | No | `` |  |

---

### init (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] init[T](Int64, Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int64` | No | `` |  |
| `mapping` | `FSharpFunc`2` | No | `` |  |

---

### initInfinite (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] initInfinite[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |

---

### mapi (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] mapi[T,U](Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,Microsoft.FSharp.Core.FSharpFunc`2[T,U]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### map (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] map[T,U](Microsoft.FSharp.Core.FSharpFunc`2[T,U], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### indexed (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[System.Int64,T]] indexed[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### iter (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] iter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### choose (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] choose[T,U](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[U]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### filter (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] filter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### iterAsyncParallel (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] iterAsyncParallel[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### iterAsyncParallelThrottled (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] iterAsyncParallelThrottled[T](Int32, Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parallelism` | `Int32` | No | `` |  |
| `action` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### ofObservableBuffered (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] ofObservableBuffered[T](System.IObservable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IObservable`1` | No | `` |  |

---

### ofObservable (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] ofObservable[T](System.IObservable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IObservable`1` | No | `` |  |

---

### toObservable (static) (generic)

**Signature:** `System.IObservable`1[T] toObservable[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### toBlockingSeq (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] toBlockingSeq[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### cache (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] cache[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### threadStateAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] threadStateAsync[State,T,U](Microsoft.FSharp.Core.FSharpFunc`2[State,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[System.Tuple`2[U,State]]]], State, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `folder` | `FSharpFunc`2` | No | `` |  |
| `st` | `State` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### zipWithAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zipWithAsync[T1,T2,U](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Control.FSharpAsync`1[U]]], FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### zipWithAsyncParallel (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zipWithAsyncParallel[T1,T2,U](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Control.FSharpAsync`1[U]]], FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### zip (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[T1,T2]] zip[T1,T2](FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input1` | `IAsyncEnumerable`1` | No | `` |  |
| `input2` | `IAsyncEnumerable`1` | No | `` |  |

---

### zipParallel (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[T1,T2]] zipParallel[T1,T2](FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input1` | `IAsyncEnumerable`1` | No | `` |  |
| `input2` | `IAsyncEnumerable`1` | No | `` |  |

---

### zipWith (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zipWith[T1,T2,U](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,U]], FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### zipWithParallel (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zipWithParallel[T1,T2,U](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,U]], FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### zipWithIndexAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zipWithIndexAsync[T,U](Microsoft.FSharp.Core.FSharpFunc`2[System.Int64,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[U]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### zappAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zappAsync[T,U](FSharp.Control.IAsyncEnumerable`1[Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[U]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `functions` | `IAsyncEnumerable`1` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### zapp (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[U] zapp[T,U](FSharp.Control.IAsyncEnumerable`1[Microsoft.FSharp.Core.FSharpFunc`2[T,U]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `functions` | `IAsyncEnumerable`1` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### takeWhileAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] takeWhileAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### takeWhile (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] takeWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### takeUntilSignal (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] takeUntilSignal[T](Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `signal` | `FSharpAsync`1` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### takeUntil (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] takeUntil[T](Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `signal` | `FSharpAsync`1` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### takeWhileInclusive (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] takeWhileInclusive[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### skipWhileAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] skipWhileAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### skipUntilSignal (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] skipUntilSignal[T](Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `signal` | `FSharpAsync`1` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### skipUntil (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] skipUntil[T](Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `signal` | `FSharpAsync`1` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### skipWhile (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] skipWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### take (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] take[T](Int32, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### truncate (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] truncate[T](Int32, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### skip (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] skip[T](Int32, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### toArrayAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[T[]] toArrayAsync[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### toListAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Collections.FSharpList`1[T]] toListAsync[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### toListSynchronously (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] toListSynchronously[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### toArraySynchronously (static) (generic)

**Signature:** `T[] toArraySynchronously[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### concatSeq (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] concatSeq[?,T](FSharp.Control.IAsyncEnumerable`1[?])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### concat (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] concat[T](FSharp.Control.IAsyncEnumerable`1[FSharp.Control.IAsyncEnumerable`1[T]])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### interleaveChoice (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[Microsoft.FSharp.Core.FSharpChoice`2[T1,T2]] interleaveChoice[T1,T2](FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### interleave (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] interleave[T](FSharp.Control.IAsyncEnumerable`1[T], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### bufferByCount (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T[]] bufferByCount[T](Int32, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `bufferSize` | `Int32` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### sort (static) (generic)

**Signature:** `T[] sort[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### sortBy (static) (generic)

**Signature:** `T[] sortBy[T,Key](Microsoft.FSharp.Core.FSharpFunc`2[T,Key], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### sortDescending (static) (generic)

**Signature:** `T[] sortDescending[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### sortByDescending (static) (generic)

**Signature:** `T[] sortByDescending[T,Key](Microsoft.FSharp.Core.FSharpFunc`2[T,Key], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### bufferByCountAndTime (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T[]] bufferByCountAndTime[T](Int32, Int32, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `bufferSize` | `Int32` | No | `` |  |
| `timeoutMs` | `Int32` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### bufferByTime (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T[]] bufferByTime[T](Int32, FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `timeMs` | `Int32` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### mergeChoice (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[Microsoft.FSharp.Core.FSharpChoice`2[T1,T2]] mergeChoice[T1,T2](FSharp.Control.IAsyncEnumerable`1[T1], FSharp.Control.IAsyncEnumerable`1[T2])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### merge (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] merge[T](FSharp.Control.IAsyncEnumerable`1[T], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### mergeAll (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] mergeAll[T](Microsoft.FSharp.Collections.FSharpList`1[FSharp.Control.IAsyncEnumerable`1[T]])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sources` | `FSharpList`1` | No | `` |  |

---

### combineLatestWithAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[V] combineLatestWithAsync[T,U,V](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[U,Microsoft.FSharp.Control.FSharpAsync`1[V]]], FSharp.Control.IAsyncEnumerable`1[T], FSharp.Control.IAsyncEnumerable`1[U])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `combine` | `FSharpFunc`2` | No | `` |  |
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### combineLatestWith (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[V] combineLatestWith[T,U,V](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[U,V]], FSharp.Control.IAsyncEnumerable`1[T], FSharp.Control.IAsyncEnumerable`1[U])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `combine` | `FSharpFunc`2` | No | `` |  |
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### combineLatest (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[a,b]] combineLatest[a,b](FSharp.Control.IAsyncEnumerable`1[a], FSharp.Control.IAsyncEnumerable`1[b])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source1` | `IAsyncEnumerable`1` | No | `` |  |
| `source2` | `IAsyncEnumerable`1` | No | `` |  |

---

### distinctUntilChangedWithAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] distinctUntilChangedWithAsync[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[System.Boolean]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### distinctUntilChangedWith (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] distinctUntilChangedWith[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### distinctUntilChanged (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[T] distinctUntilChanged[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### getIterator (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[T]]] getIterator[T](FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### traverseOptionAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[FSharp.Control.IAsyncEnumerable`1[U]]] traverseOptionAsync[T,U](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpOption`1[U]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### traverseChoiceAsync (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpChoice`2[FSharp.Control.IAsyncEnumerable`1[U],e]] traverseChoiceAsync[T,U,e](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.FSharpChoice`2[U,e]]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### groupByAsync (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[Key,FSharp.Control.IAsyncEnumerable`1[T]]] groupByAsync[T,Key](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Control.FSharpAsync`1[Key]], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---

### groupBy (static) (generic)

**Signature:** `FSharp.Control.IAsyncEnumerable`1[System.Tuple`2[Key,FSharp.Control.IAsyncEnumerable`1[T]]] groupBy[T,Key](Microsoft.FSharp.Core.FSharpFunc`2[T,Key], FSharp.Control.IAsyncEnumerable`1[T])`
**Return Type:** `IAsyncEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `projection` | `FSharpFunc`2` | No | `` |  |
| `source` | `IAsyncEnumerable`1` | No | `` |  |

---