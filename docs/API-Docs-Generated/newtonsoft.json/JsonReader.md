# JsonReader Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonReader`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`

Represents a reader that provides fast, non-cached, forward-only access to serialized JSON data.

## Methods

### ReadAsync

**Signature:** `System.Threading.Tasks.Task`1[System.Boolean] ReadAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### SkipAsync

**Signature:** `System.Threading.Tasks.Task SkipAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

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

### get_CloseInput

**Signature:** `Boolean get_CloseInput()`
**Return Type:** `Boolean`

---

### set_CloseInput

**Signature:** `Void set_CloseInput(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_SupportMultipleContent

**Signature:** `Boolean get_SupportMultipleContent()`
**Return Type:** `Boolean`

---

### set_SupportMultipleContent

**Signature:** `Void set_SupportMultipleContent(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_QuoteChar

**Signature:** `Char get_QuoteChar()`
**Return Type:** `Char`

---

### get_DateTimeZoneHandling

**Signature:** `Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling()`
**Return Type:** `DateTimeZoneHandling`

---

### set_DateTimeZoneHandling

**Signature:** `Void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeZoneHandling` | No | `` |  |

---

### get_DateParseHandling

**Signature:** `Newtonsoft.Json.DateParseHandling get_DateParseHandling()`
**Return Type:** `DateParseHandling`

---

### set_DateParseHandling

**Signature:** `Void set_DateParseHandling(Newtonsoft.Json.DateParseHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateParseHandling` | No | `` |  |

---

### get_FloatParseHandling

**Signature:** `Newtonsoft.Json.FloatParseHandling get_FloatParseHandling()`
**Return Type:** `FloatParseHandling`

---

### set_FloatParseHandling

**Signature:** `Void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FloatParseHandling` | No | `` |  |

---

### get_DateFormatString

**Signature:** `System.String get_DateFormatString()`
**Return Type:** `String`

---

### set_DateFormatString

**Signature:** `Void set_DateFormatString(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_MaxDepth

**Signature:** `System.Nullable`1[System.Int32] get_MaxDepth()`
**Return Type:** `Nullable`1`

---

### set_MaxDepth

**Signature:** `Void set_MaxDepth(System.Nullable`1[System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_TokenType

**Signature:** `Newtonsoft.Json.JsonToken get_TokenType()`
**Return Type:** `JsonToken`

---

### get_Value

**Signature:** `System.Object get_Value()`
**Return Type:** `Object`

---

### get_ValueType

**Signature:** `System.Type get_ValueType()`
**Return Type:** `Type`

---

### get_Depth

**Signature:** `Int32 get_Depth()`
**Return Type:** `Int32`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

### get_Culture

**Signature:** `System.Globalization.CultureInfo get_Culture()`
**Return Type:** `CultureInfo`

---

### set_Culture

**Signature:** `Void set_Culture(System.Globalization.CultureInfo)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `CultureInfo` | No | `` |  |

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

### ReadAsDouble

**Signature:** `System.Nullable`1[System.Double] ReadAsDouble()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsBoolean

**Signature:** `System.Nullable`1[System.Boolean] ReadAsBoolean()`
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

### ReadAsDateTime

**Signature:** `System.Nullable`1[System.DateTime] ReadAsDateTime()`
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

### Skip

**Signature:** `Void Skip()`
**Return Type:** `Void`

**Description:** Skips the children of the current token.

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

**Description:** Changes the  to Closed.

---

## Properties

### CloseInput

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether the underlying stream or
             should be closed when the reader is closed.

---

### SupportMultipleContent

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether multiple pieces of JSON content can
            be read from a continuous stream without erroring.

---

### QuoteChar

**Type:** `Char` (read/write)

**Description:** Gets the quotation mark character used to enclose the value of a string.

---

### DateTimeZoneHandling

**Type:** `DateTimeZoneHandling` (read/write)

**Description:** Get or set how  time zones are handling when reading JSON.

---

### DateParseHandling

**Type:** `DateParseHandling` (read/write)

**Description:** Get or set how date formatted strings, e.g. "\/Date(1198908717056)\/" and "2012-03-21T05:40Z", are parsed when reading JSON.

---

### FloatParseHandling

**Type:** `FloatParseHandling` (read/write)

**Description:** Get or set how floating point numbers, e.g. 1.0 and 9.9, are parsed when reading JSON text.

---

### DateFormatString

**Type:** `String` (read/write)

**Description:** Get or set how custom date formatted strings are parsed when reading JSON.

---

### MaxDepth

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets the maximum depth allowed when reading JSON. Reading past this depth will throw a .

---

### TokenType

**Type:** `JsonToken` (read-only)

**Description:** Gets the type of the current JSON token.

---

### Value

**Type:** `Object` (read-only)

**Description:** Gets the text value of the current JSON token.

---

### ValueType

**Type:** `Type` (read-only)

**Description:** Gets The Common Language Runtime (CLR) type for the current JSON token.

---

### Depth

**Type:** `Int32` (read-only)

**Description:** Gets the depth of the current token in the JSON document.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the current JSON token.

---

### Culture

**Type:** `CultureInfo` (read/write)

**Description:** Gets or sets the culture used when reading JSON. Defaults to .

---