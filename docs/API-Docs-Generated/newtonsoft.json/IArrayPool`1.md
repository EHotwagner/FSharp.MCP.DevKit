# IArrayPool`1 Interface

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.IArrayPool`1`
- **Generic Parameters:** `<T>`

Provides an interface for using pooled arrays.

## Methods

### Rent

**Signature:** `T[] Rent(Int32)`
**Return Type:** `T[]`

**Description:** Rent a array from the pool. This array must be returned when it is no longer needed.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minimumLength` | `Int32` | No | `` | The minimum required length of the array. The returned array may be longer. |

**Returns:** The rented array from the pool. This array must be returned when it is no longer needed.

---

### Return

**Signature:** `Void Return(T[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[]` | No | `` |  |

---