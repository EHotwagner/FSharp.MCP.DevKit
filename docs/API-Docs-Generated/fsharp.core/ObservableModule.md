# ObservableModule Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.ObservableModule`

Contains operations for working with first class event and other observable objects.

## Methods

### Map (static) (generic)

**Signature:** `System.IObservable`1[TResult] Map[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], System.IObservable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Choose (static) (generic)

**Signature:** `System.IObservable`1[TResult] Choose[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpOption`1[TResult]], System.IObservable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chooser` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Filter (static) (generic)

**Signature:** `System.IObservable`1[T] Filter[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], System.IObservable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Partition (static) (generic)

**Signature:** `System.Tuple`2[System.IObservable`1[T],System.IObservable`1[T]] Partition[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], System.IObservable`1[T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Scan (static) (generic)

**Signature:** `System.IObservable`1[TResult] Scan[TResult,T](Microsoft.FSharp.Core.FSharpFunc`2[TResult,Microsoft.FSharp.Core.FSharpFunc`2[T,TResult]], TResult, System.IObservable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `collector` | `FSharpFunc`2` | No | `` |  |
| `state` | `TResult` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Add (static) (generic)

**Signature:** `Void Add[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], System.IObservable`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `callback` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Subscribe (static) (generic)

**Signature:** `System.IDisposable Subscribe[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], System.IObservable`1[T])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `callback` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---

### Pairwise (static) (generic)

**Signature:** `System.IObservable`1[System.Tuple`2[T,T]] Pairwise[T](System.IObservable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IObservable`1` | No | `` |  |

---

### Merge (static) (generic)

**Signature:** `System.IObservable`1[T] Merge[T](System.IObservable`1[T], System.IObservable`1[T])`
**Return Type:** `IObservable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source1` | `IObservable`1` | No | `` |  |
| `source2` | `IObservable`1` | No | `` |  |

---

### Split (static) (generic)

**Signature:** `System.Tuple`2[System.IObservable`1[TResult1],System.IObservable`1[TResult2]] Split[T,TResult1,TResult2](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpChoice`2[TResult1,TResult2]], System.IObservable`1[T])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `splitter` | `FSharpFunc`2` | No | `` |  |
| `source` | `IObservable`1` | No | `` |  |

---