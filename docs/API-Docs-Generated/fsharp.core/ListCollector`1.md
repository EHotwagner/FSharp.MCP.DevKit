# ListCollector`1 Struct

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ListCollector`1`
- **Base Type:** `System.ValueType`
- **Generic Parameters:** `<T>`

Collects elements and builds a list

## Methods

### Add

**Signature:** `Void Add(T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### AddMany

**Signature:** `Void AddMany(System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `values` | `IEnumerable`1` | No | `` |  |

---

### AddManyAndClose

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] AddManyAndClose(System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `values` | `IEnumerable`1` | No | `` |  |

---

### Close

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] Close()`
**Return Type:** `FSharpList`1`

**Description:** Return the resulting list

---