# NonDisposingStream Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.NonDisposingStream`
- **Base Type:** `System.IO.Stream`
- **Implements:** `System.IDisposable`, `System.IAsyncDisposable`

## Methods

### get_Position

**Signature:** `Int64 get_Position()`
**Return Type:** `Int64`

---

### set_Position

**Signature:** `Void set_Position(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int64` | No | `` |  |

---

### get_CanRead

**Signature:** `Boolean get_CanRead()`
**Return Type:** `Boolean`

---

### get_CanWrite

**Signature:** `Boolean get_CanWrite()`
**Return Type:** `Boolean`

---

### get_CanSeek

**Signature:** `Boolean get_CanSeek()`
**Return Type:** `Boolean`

---

### get_Length

**Signature:** `Int64 get_Length()`
**Return Type:** `Int64`

---

### Write

**Signature:** `Void Write(Byte[], Int32, Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `Byte[]` | No | `` |  |
| `offset` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---

### Read

**Signature:** `Int32 Read(Byte[], Int32, Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `output` | `Byte[]` | No | `` |  |
| `offset` | `Int32` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---

### Flush

**Signature:** `Void Flush()`
**Return Type:** `Void`

---

### Seek

**Signature:** `Int64 Seek(Int64, System.IO.SeekOrigin)`
**Return Type:** `Int64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `offset` | `Int64` | No | `` |  |
| `origin` | `SeekOrigin` | No | `` |  |

---

### SetLength

**Signature:** `Void SetLength(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length` | `Int64` | No | `` |  |

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

---

## Properties

### Position

**Type:** `Int64` (read/write)

---

### CanRead

**Type:** `Boolean` (read-only)

---

### CanWrite

**Type:** `Boolean` (read-only)

---

### CanSeek

**Type:** `Boolean` (read-only)

---

### Length

**Type:** `Int64` (read-only)

---