# XmlNodeConverter Class

**Namespace:** `Newtonsoft.Json.Converters`
**Full Name:** `Newtonsoft.Json.Converters.XmlNodeConverter`
- **Base Type:** `Newtonsoft.Json.JsonConverter`

Converts XML to and from JSON.

## Methods

### get_DeserializeRootElementName

**Signature:** `System.String get_DeserializeRootElementName()`
**Return Type:** `String`

---

### set_DeserializeRootElementName

**Signature:** `Void set_DeserializeRootElementName(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_WriteArrayAttribute

**Signature:** `Boolean get_WriteArrayAttribute()`
**Return Type:** `Boolean`

---

### set_WriteArrayAttribute

**Signature:** `Void set_WriteArrayAttribute(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_OmitRootObject

**Signature:** `Boolean get_OmitRootObject()`
**Return Type:** `Boolean`

---

### set_OmitRootObject

**Signature:** `Void set_OmitRootObject(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_EncodeSpecialCharacters

**Signature:** `Boolean get_EncodeSpecialCharacters()`
**Return Type:** `Boolean`

---

### set_EncodeSpecialCharacters

**Signature:** `Void set_EncodeSpecialCharacters(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### WriteJson

**Signature:** `Void WriteJson(Newtonsoft.Json.JsonWriter, System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Void`

**Description:** Writes the JSON representation of the object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` | The  to write to. |
| `value` | `Object` | No | `` | The value. |
| `serializer` | `JsonSerializer` | No | `` | The calling serializer. |

---

### ReadJson

**Signature:** `System.Object ReadJson(Newtonsoft.Json.JsonReader, System.Type, System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Object`

**Description:** Reads the JSON representation of the object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  to read from. |
| `objectType` | `Type` | No | `` | Type of the object. |
| `existingValue` | `Object` | No | `` | The existing value of object being read. |
| `serializer` | `JsonSerializer` | No | `` | The calling serializer. |

**Returns:** The object value.

---

### CanConvert

**Signature:** `Boolean CanConvert(System.Type)`
**Return Type:** `Boolean`

**Description:** Determines whether this instance can convert the specified value type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `valueType` | `Type` | No | `` | Type of the value. |

**Returns:** true if this instance can convert the specified value type; otherwise, false.

---

## Properties

### DeserializeRootElementName

**Type:** `String` (read/write)

**Description:** Gets or sets the name of the root element to insert when deserializing to XML if the JSON structure has produces multiple root elements.

---

### WriteArrayAttribute

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a flag to indicate whether to write the Json.NET array attribute.
            This attribute helps preserve arrays when converting the written XML back to JSON.

---

### OmitRootObject

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether to write the root JSON object.

---

### EncodeSpecialCharacters

**Type:** `Boolean` (read/write)

---