# JsonWriter Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonWriter`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`

Represents a writer that provides a fast, non-cached, forward-only way of generating JSON data.

## Methods

### CloseAsync

**Signature:** `System.Threading.Tasks.Task CloseAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### FlushAsync

**Signature:** `System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken)`
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

### WriteEndAsync

**Signature:** `System.Threading.Tasks.Task WriteEndAsync(System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
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

### WriteCommentAsync

**Signature:** `System.Threading.Tasks.Task WriteCommentAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |
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

### WriteStartConstructorAsync

**Signature:** `System.Threading.Tasks.Task WriteStartConstructorAsync(System.String, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
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

### WriteTokenAsync

**Signature:** `System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteTokenAsync

**Signature:** `System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonReader, Boolean, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `writeChildren` | `Boolean` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteTokenAsync

**Signature:** `System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonToken, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `token` | `JsonToken` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### WriteTokenAsync

**Signature:** `System.Threading.Tasks.Task WriteTokenAsync(Newtonsoft.Json.JsonToken, System.Object, System.Threading.CancellationToken)`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `token` | `JsonToken` | No | `` |  |
| `value` | `Object` | No | `` |  |
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

### get_CloseOutput

**Signature:** `Boolean get_CloseOutput()`
**Return Type:** `Boolean`

---

### set_CloseOutput

**Signature:** `Void set_CloseOutput(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_AutoCompleteOnClose

**Signature:** `Boolean get_AutoCompleteOnClose()`
**Return Type:** `Boolean`

---

### set_AutoCompleteOnClose

**Signature:** `Void set_AutoCompleteOnClose(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_WriteState

**Signature:** `Newtonsoft.Json.WriteState get_WriteState()`
**Return Type:** `WriteState`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

### get_Formatting

**Signature:** `Newtonsoft.Json.Formatting get_Formatting()`
**Return Type:** `Formatting`

---

### set_Formatting

**Signature:** `Void set_Formatting(Newtonsoft.Json.Formatting)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Formatting` | No | `` |  |

---

### get_DateFormatHandling

**Signature:** `Newtonsoft.Json.DateFormatHandling get_DateFormatHandling()`
**Return Type:** `DateFormatHandling`

---

### set_DateFormatHandling

**Signature:** `Void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateFormatHandling` | No | `` |  |

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

### get_StringEscapeHandling

**Signature:** `Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling()`
**Return Type:** `StringEscapeHandling`

---

### set_StringEscapeHandling

**Signature:** `Void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `StringEscapeHandling` | No | `` |  |

---

### get_FloatFormatHandling

**Signature:** `Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling()`
**Return Type:** `FloatFormatHandling`

---

### set_FloatFormatHandling

**Signature:** `Void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FloatFormatHandling` | No | `` |  |

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

### WriteEndObject

**Signature:** `Void WriteEndObject()`
**Return Type:** `Void`

**Description:** Writes the end of a JSON object.

---

### WriteStartArray

**Signature:** `Void WriteStartArray()`
**Return Type:** `Void`

**Description:** Writes the beginning of a JSON array.

---

### WriteEndArray

**Signature:** `Void WriteEndArray()`
**Return Type:** `Void`

**Description:** Writes the end of an array.

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

### WriteEndConstructor

**Signature:** `Void WriteEndConstructor()`
**Return Type:** `Void`

**Description:** Writes the end constructor.

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

### WriteEnd

**Signature:** `Void WriteEnd()`
**Return Type:** `Void`

**Description:** Writes the end of the current JSON object or array.

---

### WriteToken

**Signature:** `Void WriteToken(Newtonsoft.Json.JsonReader)`
**Return Type:** `Void`

**Description:** Writes the current  token and its children.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  to read the token from. |

---

### WriteToken

**Signature:** `Void WriteToken(Newtonsoft.Json.JsonReader, Boolean)`
**Return Type:** `Void`

**Description:** Writes the current  token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  to read the token from. |
| `writeChildren` | `Boolean` | No | `` | A flag indicating whether the current token's children should be written. |

---

### WriteToken

**Signature:** `Void WriteToken(Newtonsoft.Json.JsonToken, System.Object)`
**Return Type:** `Void`

**Description:** Writes the  token and its value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `token` | `JsonToken` | No | `` | The  to write. |
| `value` | `Object` | No | `` | The value to write.
            A value is only required for tokens that have an associated value, e.g. the  property name for .
            A null value can be passed to the method for token's that don't have a value, e.g. . |

---

### WriteToken

**Signature:** `Void WriteToken(Newtonsoft.Json.JsonToken)`
**Return Type:** `Void`

**Description:** Writes the  token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `token` | `JsonToken` | No | `` | The  to write. |

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

**Description:** Writes raw JSON without changing the writer's state.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | The raw JSON to write. |

---

### WriteRawValue

**Signature:** `Void WriteRawValue(System.String)`
**Return Type:** `Void`

**Description:** Writes raw JSON where a value is expected and updates the writer's state.

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

**Signature:** `Void WriteValue(Double)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Double` | No | `` | The  value to write. |

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

**Signature:** `Void WriteValue(System.Nullable`1[System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.UInt32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Int64])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.UInt64])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

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

**Signature:** `Void WriteValue(System.Nullable`1[System.Double])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Boolean])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Int16])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.UInt16])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Char])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Byte])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.SByte])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Decimal])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.DateTime])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.DateTimeOffset])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.Guid])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WriteValue

**Signature:** `Void WriteValue(System.Nullable`1[System.TimeSpan])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

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

**Signature:** `Void WriteValue(System.Uri)`
**Return Type:** `Void`

**Description:** Writes a  value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Uri` | No | `` | The  value to write. |

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

### CloseOutput

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether the underlying stream or
             should be closed when the writer is closed.

---

### AutoCompleteOnClose

**Type:** `Boolean` (read/write)

---

### WriteState

**Type:** `WriteState` (read-only)

**Description:** Gets the state of the writer.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the writer.

---

### Formatting

**Type:** `Formatting` (read/write)

**Description:** Indicates how JSON text output is formatted.

---

### DateFormatHandling

**Type:** `DateFormatHandling` (read/write)

**Description:** Get or set how dates are written to JSON text.

---

### DateTimeZoneHandling

**Type:** `DateTimeZoneHandling` (read/write)

**Description:** Get or set how  time zones are handling when writing JSON text.

---

### StringEscapeHandling

**Type:** `StringEscapeHandling` (read/write)

**Description:** Get or set how strings are escaped when writing JSON text.

---

### FloatFormatHandling

**Type:** `FloatFormatHandling` (read/write)

**Description:** Get or set how special floating point numbers, e.g. ,
             and ,
            are written to JSON text.

---

### DateFormatString

**Type:** `String` (read/write)

**Description:** Get or set how  and  values are formatting when writing JSON text.

---

### Culture

**Type:** `CultureInfo` (read/write)

**Description:** Gets or sets the culture used when writing JSON. Defaults to .

---