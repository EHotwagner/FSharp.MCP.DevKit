# BsonReader Class

**Namespace:** `Newtonsoft.Json.Bson`
**Full Name:** `Newtonsoft.Json.Bson.BsonReader`
- **Base Type:** `Newtonsoft.Json.JsonReader`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`

Represents a reader that provides fast, non-cached, forward-only access to serialized JSON data.

## Methods

### get_JsonNet35BinaryCompatibility

**Signature:** `Boolean get_JsonNet35BinaryCompatibility()`
**Return Type:** `Boolean`

---

### set_JsonNet35BinaryCompatibility

**Signature:** `Void set_JsonNet35BinaryCompatibility(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_ReadRootValueAsArray

**Signature:** `Boolean get_ReadRootValueAsArray()`
**Return Type:** `Boolean`

---

### set_ReadRootValueAsArray

**Signature:** `Void set_ReadRootValueAsArray(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

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

### Read

**Signature:** `Boolean Read()`
**Return Type:** `Boolean`

**Description:** Reads the next JSON token from the stream.

**Returns:** true if the next token was read successfully; false if there are no more tokens to read.

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

**Description:** Changes the  to Closed.

---

## Properties

### JsonNet35BinaryCompatibility

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether binary data reading should compatible with incorrect Json.NET 3.5 written binary.

---

### ReadRootValueAsArray

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether the root object will be read as a JSON array.

---

### DateTimeKindHandling

**Type:** `DateTimeKind` (read/write)

**Description:** Gets or sets the  used when reading  values from BSON.

---