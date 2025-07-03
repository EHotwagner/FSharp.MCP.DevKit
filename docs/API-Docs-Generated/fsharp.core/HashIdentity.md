# HashIdentity Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.HashIdentity`

Common notions of value identity implementing the 
 interface, for constructing  objects and other collections

## Methods

### Structural (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] Structural[T]()`
**Return Type:** `IEqualityComparer`1`

---

### LimitedStructural (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] LimitedStructural[T](Int32)`
**Return Type:** `IEqualityComparer`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `limit` | `Int32` | No | `` |  |

---

### Reference (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] Reference[T]()`
**Return Type:** `IEqualityComparer`1`

---

### NonStructural (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] NonStructural[T]()`
**Return Type:** `IEqualityComparer`1`

---

### NonStructural$W (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] NonStructural$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]])`
**Return Type:** `IEqualityComparer`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Equality` | `FSharpFunc`2` | No | `` |  |

---

### FromFunctions (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] FromFunctions[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]])`
**Return Type:** `IEqualityComparer`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `hasher` | `FSharpFunc`2` | No | `` |  |
| `equality` | `FSharpFunc`2` | No | `` |  |

---