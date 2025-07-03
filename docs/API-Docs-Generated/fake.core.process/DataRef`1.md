# DataRef`1 Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.DataRef`1`
- **Generic Parameters:** `<T>`

Represents basically an "out" parameter, allows to retrieve a value after a certain point in time.
 Used to retrieve "pipes"

## Methods

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### get_Empty (static)

**Signature:** `Fake.Core.DataRef`1[T] get_Empty()`
**Return Type:** `DataRef`1`

---

### Map (static) (generic)

**Signature:** `Fake.Core.DataRef`1[a] Map[a](Microsoft.FSharp.Core.FSharpFunc`2[T,a], Fake.Core.DataRef`1[T])`
**Return Type:** `DataRef`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `inner` | `DataRef`1` | No | `` |  |

---

### get_Value

**Signature:** `T get_Value()`
**Return Type:** `T`

---

## Properties

### Empty (static)

**Type:** `DataRef`1` (read-only)

---

### Value

**Type:** `T` (read-only)

---