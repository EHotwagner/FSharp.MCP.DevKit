# ComparisonIdentity Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.ComparisonIdentity`

Common notions of value ordering implementing the 
 interface, for constructing sorted data structures and performing sorting operations.

## Methods

### Structural (static) (generic)

**Signature:** `System.Collections.Generic.IComparer`1[T] Structural[T]()`
**Return Type:** `IComparer`1`

---

### NonStructural (static) (generic)

**Signature:** `System.Collections.Generic.IComparer`1[T] NonStructural[T]()`
**Return Type:** `IComparer`1`

---

### NonStructural$W (static) (generic)

**Signature:** `System.Collections.Generic.IComparer`1[T] NonStructural$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean]])`
**Return Type:** `IComparer`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_GreaterThan` | `FSharpFunc`2` | No | `` |  |
| `op_LessThan` | `FSharpFunc`2` | No | `` |  |

---

### FromFunction (static) (generic)

**Signature:** `System.Collections.Generic.IComparer`1[T] FromFunction[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32]])`
**Return Type:** `IComparer`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `FSharpFunc`2` | No | `` |  |

---