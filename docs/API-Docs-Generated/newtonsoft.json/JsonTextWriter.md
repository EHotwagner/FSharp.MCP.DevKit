# JsonTextWriter Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonTextWriter`
- **Base Type:** `Newtonsoft.Json.JsonWriter`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`

Represents a writer that provides a fast, non-cached, forward-only way of generating JSON data.

## Methods

### FlushAsync

**Signature:** `System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### CloseAsync

**Signature:** `System.Threading.Tasks.Task CloseAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteEndAsync

**Signature:** `System.Threading.Tasks.Task WriteEndAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteRawAsync

**Signature:** `System.Threading.Tasks.Task WriteRawAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteNullAsync

**Signature:** `System.Threading.Tasks.Task WriteNullAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WritePropertyNameAsync

**Signature:** `System.Threading.Tasks.Task WritePropertyNameAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WritePropertyNameAsync

**Signature:** `System.Threading.Tasks.Task WritePropertyNameAsync(System.String, Boolean, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `escape` | `Boolean` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteStartArrayAsync

**Signature:** `System.Threading.Tasks.Task WriteStartArrayAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteStartObjectAsync

**Signature:** `System.Threading.Tasks.Task WriteStartObjectAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteStartConstructorAsync

**Signature:** `System.Threading.Tasks.Task WriteStartConstructorAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteUndefinedAsync

**Signature:** `System.Threading.Tasks.Task WriteUndefinedAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteWhitespaceAsync

**Signature:** `System.Threading.Tasks.Task WriteWhitespaceAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ws` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Boolean, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Boolean], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Byte, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Byte], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Byte[], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte[]` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Char, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Char` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Char], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.DateTime, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTime` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.DateTime], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeOffset` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.DateTimeOffset], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Decimal, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Decimal` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Decimal], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Double, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Double` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Double], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Single, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Single` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Single], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Guid, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Guid` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Guid], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Int32, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Int32], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Int64, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int64` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Int64], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Object, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(SByte, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `SByte` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.SByte], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(Int16, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int16` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.Int16], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TimeSpan` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.TimeSpan], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(UInt32, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt32` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.UInt32], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(UInt64, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt64` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.UInt64], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Uri, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Uri` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(UInt16, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt16` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteValueAsync

**Signature:** `System.Threading.Tasks.Task WriteValueAsync(System.Nullable`1[System.UInt16], System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteCommentAsync

**Signature:** `System.Threading.Tasks.Task WriteCommentAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteEndArrayAsync

**Signature:** `System.Threading.Tasks.Task WriteEndArrayAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteEndConstructorAsync

**Signature:** `System.Threading.Tasks.Task WriteEndConstructorAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteEndObjectAsync

**Signature:** `System.Threading.Tasks.Task WriteEndObjectAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteRawValueAsync

**Signature:** `System.Threading.Tasks.Task WriteRawValueAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

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

### get_Indentation

**Signature:** `Int32 get_Indentation()`
**Return Type:** `Int32`

---

### set_Indentation

**Signature:** `Void set_Indentation(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` |  |

---

### get_QuoteChar

**Signature:** `Char get_QuoteChar()`
**Return Type:** `Char`

---

### set_QuoteChar

**Signature:** `Void set_QuoteChar(Char)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Char` | No | `` |  |

---

### get_IndentChar

**Signature:** `Char get_IndentChar()`
**Return Type:** `Char`

---

### set_IndentChar

**Signature:** `Void set_IndentChar(Char)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Char` | No | `` |  |

---

### get_QuoteName

**Signature:** `Boolean get_QuoteName()`
**Return Type:** `Boolean`

---

### set_QuoteName

**Signature:** `Void set_QuoteName(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### Flush

**Signature:** `Void Flush()`
**Return Type:** `Void`

**Description:** Flushes whatever is in the buffer to the underlying streams and also flushes the underlying stream.

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

**Description:** Closes this stream and the underlying stream.

---

### WriteStartObject

**Signature:** `Void WriteStartObject()`
**Return Type:** `Void`

**Description:** Writes the beginning of a JSON object.

---

### WriteStartArray

**Signature:** `Void WriteStartArray()`
**Return Type:** `Void`

**Description:** Writes the beginning of a JSON array.

---

### WriteStartConstructor

**Signature:** `Void WriteStartConstructor(System.String)`
**Return Type:** `Void`

**Description:** Writes the start of a constructor with the given name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the constructor. |

---

### WritePropertyName

**Signature:** `Void WritePropertyName(System.String)`
**Return Type:** `Void`

**Description:** Writes the property name of a name/value pair on a JSON object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the property. |

---

### WritePropertyName

**Signature:** `Void WritePropertyName(System.String, Boolean)`
**Return Type:** `Void`

**Description:** Writes the property name of a name/value pair on a JSON object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the property. |
| `escape` | `Boolean` | No | `` | A flag to indicate whether the text should be escaped when it is written as a JSON property name. |

---

### WriteValue

**Signature:** `Void WriteValue(System.Object)`
**Return Type:** `Void`

**Description:** Writes a  value.
            An error will raised if the value cannot be written as a single JSON token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The  value to write. |

---

### WriteNull

**Signature:** `Void WriteNull()`
**Return Type:** `Void`

**Description:** Writes a null value.

---

### WriteUndefined

**Signature:** `Void WriteUndefined()`
**Return Type:** `Void`

**Description:** Writes an undefined value.

---

### WriteRaw

**Signature:** `Void WriteRaw(System.String)`
**Return Type:** `Void`

**Description:** Writes raw JSON.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | The raw JSON to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.String)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Int32)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(UInt32)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt32` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Int64)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int64` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(UInt64)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt64` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Single)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Single` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Single])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(Double)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Double` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Double])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(Boolean)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Int16)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int16` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(UInt16)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt16` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Char)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Char` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Byte)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(SByte)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `SByte` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.Decimal)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Decimal` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.DateTime)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTime` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(Byte[])`
**Return Type:** `Void`

**Description:** Writes a [] value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte[]` | No | `` | The [] value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.DateTimeOffset)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeOffset` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.Guid)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Guid` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.TimeSpan)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TimeSpan` | No | `` | The  value to write. |

---

### WriteValue

**Signature:** `Void WriteValue(System.Uri)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Uri` | No | `` | The  value to write. |

---

### WriteComment

**Signature:** `Void WriteComment(System.String)`
**Return Type:** `Void`

**Description:** Writes out a comment /*...*/ containing the specified text.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` | Text to place inside the comment. |

---

### WriteWhitespace

**Signature:** `Void WriteWhitespace(System.String)`
**Return Type:** `Void`

**Description:** Writes out the given white space.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ws` | `String` | No | `` | The string of white space characters. |

---

## Properties

### ArrayPool

**Type:** `IArrayPool`1` (read/write)

**Description:** Gets or sets the writer's character array pool.

---

### Indentation

**Type:** `Int32` (read/write)

**Description:** Gets or sets how many IndentChars to write for each level in the hierarchy when  is set to Formatting.Indented.

---

### QuoteChar

**Type:** `Char` (read/write)

**Description:** Gets or sets which character to use to quote attribute values.

---

### IndentChar

**Type:** `Char` (read/write)

**Description:** Gets or sets which character to use for indenting when  is set to Formatting.Indented.

---

### QuoteName

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether object names will be surrounded with quotes.

---