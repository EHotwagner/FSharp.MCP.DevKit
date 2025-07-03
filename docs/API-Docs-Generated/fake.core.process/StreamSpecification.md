# StreamSpecification Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.StreamSpecification`

Various options to redirect streams.

## Methods

### get_Inherit (static)

**Signature:** `Fake.Core.StreamSpecification get_Inherit()`
**Return Type:** `StreamSpecification`

---

### get_IsInherit

**Signature:** `Boolean get_IsInherit()`
**Return Type:** `Boolean`

---

### NewUseStream (static)

**Signature:** `Fake.Core.StreamSpecification NewUseStream(Boolean, System.IO.Stream)`
**Return Type:** `StreamSpecification`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_closeOnExit` | `Boolean` | No | `` |  |
| `_stream` | `Stream` | No | `` |  |

---

### get_IsUseStream

**Signature:** `Boolean get_IsUseStream()`
**Return Type:** `Boolean`

---

### NewCreatePipe (static)

**Signature:** `Fake.Core.StreamSpecification NewCreatePipe(Fake.Core.DataRef`1[System.IO.Stream])`
**Return Type:** `StreamSpecification`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `DataRef`1` | No | `` |  |

---

### get_IsCreatePipe

**Signature:** `Boolean get_IsCreatePipe()`
**Return Type:** `Boolean`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

## Properties

### Tag

**Type:** `Int32` (read-only)

---

### Inherit (static)

**Type:** `StreamSpecification` (read-only)

---

### IsInherit

**Type:** `Boolean` (read-only)

---

### IsUseStream

**Type:** `Boolean` (read-only)

---

### IsCreatePipe

**Type:** `Boolean` (read-only)

---