# RuntimeHelpers Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers`

A group of functions used as part of the compiled representation of F# sequence expressions.

## Methods

### EnumerateFromFunctions (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[TResult] EnumerateFromFunctions[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[T,TResult])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `create` | `FSharpFunc`2` | No | `` |  |
| `moveNext` | `FSharpFunc`2` | No | `` |  |
| `current` | `FSharpFunc`2` | No | `` |  |

---

### EnumerateUsing (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[TResult] EnumerateUsing[T,TCollection,TResult](T, Microsoft.FSharp.Core.FSharpFunc`2[T,TCollection])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `resource` | `T` | No | `` |  |
| `source` | `FSharpFunc`2` | No | `` |  |

---

### EnumerateWhile (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] EnumerateWhile[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.Boolean], System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `guard` | `FSharpFunc`2` | No | `` |  |
| `source` | `IEnumerable`1` | No | `` |  |

---

### EnumerateThenFinally (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] EnumerateThenFinally[T](System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |
| `compensation` | `FSharpFunc`2` | No | `` |  |

---

### EnumerateTryWith (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] EnumerateTryWith[T](System.Collections.Generic.IEnumerable`1[T], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,System.Int32], Microsoft.FSharp.Core.FSharpFunc`2[System.Exception,System.Collections.Generic.IEnumerable`1[T]])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |
| `exceptionFilter` | `FSharpFunc`2` | No | `` |  |
| `exceptionHandler` | `FSharpFunc`2` | No | `` |  |

---

### CreateEvent (static) (generic)

**Signature:** `Microsoft.FSharp.Control.IEvent`2[TDelegate,TArgs] CreateEvent[TDelegate,TArgs](Microsoft.FSharp.Core.FSharpFunc`2[TDelegate,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpFunc`2[TDelegate,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.FSharpFunc`2[System.Object,Microsoft.FSharp.Core.FSharpFunc`2[TArgs,Microsoft.FSharp.Core.Unit]],TDelegate])`
**Return Type:** `IEvent`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `addHandler` | `FSharpFunc`2` | No | `` |  |
| `removeHandler` | `FSharpFunc`2` | No | `` |  |
| `createHandler` | `FSharpFunc`2` | No | `` |  |

---