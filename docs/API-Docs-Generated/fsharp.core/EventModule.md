# EventModule Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.EventModule`

Contains operations for working with values of type .

## Methods

### Map (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[TResult],TResult] Map[T,TResult,TDel](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[T],T] Filter[T,TDel](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Partition (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[T],T],Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[T],T]] Partition[T,TDel](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Choose (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[TResult],TResult] Choose[T,TResult,TDel](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Scan (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[TResult],TResult] Scan[TResult,T,TDel](Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[T,TResult]], TResult, Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `collector` | `FSharpFunc`2` | No | `` |  |
| `state` | `TResult` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Add (static) (generic)

**Signature:** `Void Add[T,TDel](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `callback` | `FSharpFunc`2` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Pairwise (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[System.Tuple`2[T,T]],System.Tuple`2[T,T]] Pairwise[TDel,T](Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sourceEvent` | `IEvent`2` | No | `` |  |

---

### Merge (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[T],T] Merge[TDel1,T,TDel2](Microsoft.FSharp.Control.IEvent`2[TDel1,T], Microsoft.FSharp.Control.IEvent`2[TDel2,T])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `event1` | `IEvent`2` | No | `` |  |
| `event2` | `IEvent`2` | No | `` |  |

---

### Split (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[TResult1],TResult1],Microsoft.FSharp.Control.IEvent`2[Microsoft.FSharp.Control.FSharpHandler`1[TResult2],TResult2]] Split[T,TResult1,TResult2,TDel](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpChoice`2[TResult1,TResult2]], Microsoft.FSharp.Control.IEvent`2[TDel,T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `splitter` | `FSharpFunc`2` | No | `` |  |
| `sourceEvent` | `IEvent`2` | No | `` |  |

---