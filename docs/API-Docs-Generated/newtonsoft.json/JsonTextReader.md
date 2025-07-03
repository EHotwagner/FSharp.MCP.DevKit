# JsonTextReader Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonTextReader`
- **Base Type:** `Newtonsoft.Json.JsonReader`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`, `Newtonsoft.Json.IJsonLineInfo`

Represents a reader that provides fast, non-cached, forward-only access to JSON text data.

## Methods

### ReadAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Boolean] ReadAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsBooleanAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Nullable`1[System.Boolean]] ReadAsBooleanAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsBytesAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Byte[]] ReadAsBytesAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsDateTimeAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Nullable`1[System.DateTime]] ReadAsDateTimeAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsDateTimeOffsetAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Nullable`1[System.DateTimeOffset]] ReadAsDateTimeOffsetAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsDecimalAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Nullable`1[System.Decimal]] ReadAsDecimalAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsDoubleAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Nullable`1[System.Double]] ReadAsDoubleAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsInt32Async

**Signature:** `System.Threading.Tasks.Task`1[System.Nullable`1[System.Int32]] ReadAsInt32Async(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadAsStringAsync

**Signature:** `System.Threading.Tasks.Task`1[System.String] ReadAsStringAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### get_PropertyNameTable

**Signature:** `Newtonsoft.Json.JsonNameTable get_PropertyNameTable()`
**Return Type:** `JsonNameTable`

---

### set_PropertyNameTable

**Signature:** `Void set_PropertyNameTable(Newtonsoft.Json.JsonNameTable)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JsonNameTable` | No | `` |  |

---

### get_ArrayPool

**Signature:** `Newtonsoft.Json.IArrayPool`1[System.Char] get_ArrayPool()`
**Return Type:** `IArrayPool`1`

---

### set_ArrayPool

**Signature:** `Void set_ArrayPool(Newtonsoft.Json.IArrayPool`1[System.Char])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `IArrayPool`1` | No | `` |  |

---

### Read

**Signature:** `Boolean Read()`
**Return Type:** `Boolean`

**Description:** Reads the next JSON token from the stream.

**Returns:** true if the next token was read successfully; false if there are no more tokens to read.

---

### ReadAsInt32

**Signature:** `System.Nullable`1[System.Int32] ReadAsInt32()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsDateTime

**Signature:** `System.Nullable`1[System.DateTime] ReadAsDateTime()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsString

**Signature:** `System.String ReadAsString()`
**Return Type:** `String`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsBytes

**Signature:** `Byte[] ReadAsBytes()`
**Return Type:** `Byte[]`

**Description:** Reads the next JSON token from the stream as a [].

**Returns:** A [] or a null reference if the next JSON token is null. This method will return null at the end of an array.

---

### ReadAsBoolean

**Signature:** `System.Nullable`1[System.Boolean] ReadAsBoolean()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsDateTimeOffset

**Signature:** `System.Nullable`1[System.DateTimeOffset] ReadAsDateTimeOffset()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsDecimal

**Signature:** `System.Nullable`1[System.Decimal] ReadAsDecimal()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsDouble

**Signature:** `System.Nullable`1[System.Double] ReadAsDouble()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

**Description:** Changes the state to closed.

---

### HasLineInfo

**Signature:** `Boolean HasLineInfo()`
**Return Type:** `Boolean`

**Description:** Gets a value indicating whether the class can return line information.

**Returns:** true if LineNumber and LinePosition can be provided; otherwise, false.

---

### get_LineNumber

**Signature:** `Int32 get_LineNumber()`
**Return Type:** `Int32`

---

### get_LinePosition

**Signature:** `Int32 get_LinePosition()`
**Return Type:** `Int32`

---

## Properties

### PropertyNameTable

**Type:** `JsonNameTable` (read/write)

---

### ArrayPool

**Type:** `IArrayPool`1` (read/write)

**Description:** Gets or sets the reader's character buffer pool.

---

### LineNumber

**Type:** `Int32` (read-only)

**Description:** Gets the current line number.

---

### LinePosition

**Type:** `Int32` (read-only)

**Description:** Gets the current line position.

---