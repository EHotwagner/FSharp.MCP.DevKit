# ArrayCollector`1 Struct

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ArrayCollector`1`
- **Base Type:** `System.ValueType`
- **Generic Parameters:** `<T>`

Collects elements and builds an array

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

**Signature:** `T[] AddManyAndClose(System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `T[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `values` | `IEnumerable`1` | No | `` |  |

---

### Close

**Signature:** `T[] Close()`
**Return Type:** `T[]`

**Description:** Return the resulting list

---