# BsonWriter Class

**Namespace:** `Newtonsoft.Json.Bson`
**Full Name:** `Newtonsoft.Json.Bson.BsonWriter`
- **Base Type:** `Newtonsoft.Json.JsonWriter`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`

Represents a writer that provides a fast, non-cached, forward-only way of generating JSON data.

## Methods

### get_DateTimeKindHandling

**Signature:** `System.DateTimeKind get_DateTimeKindHandling()`
**Return Type:** `DateTimeKind`

---

### set_DateTimeKindHandling

**Signature:** `Void set_DateTimeKindHandling(System.DateTimeKind)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeKind` | No | `` |  |

---

### Flush

**Signature:** `Void Flush()`
**Return Type:** `Void`

**Description:** Flushes whatever is in the buffer to the underlying streams and also flushes the underlying stream.

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

### WriteStartConstructor

**Signature:** `Void WriteStartConstructor(System.String)`
**Return Type:** `Void`

**Description:** Writes the start of a constructor with the given name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the constructor. |

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

### WriteRawValue

**Signature:** `Void WriteRawValue(System.String)`
**Return Type:** `Void`

**Description:** Writes raw JSON where a value is expected and updates the writer's state.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | The raw JSON to write. |

---

### WriteStartArray

**Signature:** `Void WriteStartArray()`
**Return Type:** `Void`

**Description:** Writes the beginning of a JSON array.

---

### WriteStartObject

**Signature:** `Void WriteStartObject()`
**Return Type:** `Void`

**Description:** Writes the beginning of a JSON object.

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

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

**Description:** Closes this stream and the underlying stream.

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

**Signature:** `Void WriteValue(Byte[])`
**Return Type:** `Void`

**Description:** Writes a [] value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte[]` | No | `` | The [] value to write. |

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

### WriteObjectId

**Signature:** `Void WriteObjectId(Byte[])`
**Return Type:** `Void`

**Description:** Writes a [] value that represents a BSON object id.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte[]` | No | `` | The Object ID value to write. |

---

### WriteRegex

**Signature:** `Void WriteRegex(System.String, System.String)`
**Return Type:** `Void`

**Description:** Writes a BSON regex.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The regex pattern. |
| `options` | `String` | No | `` | The regex options. |

---

## Properties

### DateTimeKindHandling

**Type:** `DateTimeKind` (read/write)

**Description:** Gets or sets the  used when writing  values to BSON.
            When set to  no conversion will occur.

---