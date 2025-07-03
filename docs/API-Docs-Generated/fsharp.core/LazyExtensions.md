# LazyExtensions Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.LazyExtensions`

Extensions related to Lazy values.

## Methods

### Create (static) (generic)

**Signature:** `System.Lazy`1[T] Create[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T])`
**Return Type:** `Lazy`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `creator` | `FSharpFunc`2` | No | `` |  |

---

### CreateFromValue (static) (generic)

**Signature:** `System.Lazy`1[T] CreateFromValue[T](T)`
**Return Type:** `Lazy`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Force (static) (generic)

**Signature:** `T Force[T](System.Lazy`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `Lazy`1` | No | `` |  |

---