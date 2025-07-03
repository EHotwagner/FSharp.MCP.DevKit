# StringEnumConverter Class

**Namespace:** `Newtonsoft.Json.Converters`
**Full Name:** `Newtonsoft.Json.Converters.StringEnumConverter`
- **Base Type:** `Newtonsoft.Json.JsonConverter`

Converts an  to and from its name string value.

## Methods

### get_CamelCaseText

**Signature:** `Boolean get_CamelCaseText()`
**Return Type:** `Boolean`

---

### set_CamelCaseText

**Signature:** `Void set_CamelCaseText(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_NamingStrategy

**Signature:** `Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy()`
**Return Type:** `NamingStrategy`

---

### set_NamingStrategy

**Signature:** `Void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `NamingStrategy` | No | `` |  |

---

### get_AllowIntegerValues

**Signature:** `Boolean get_AllowIntegerValues()`
**Return Type:** `Boolean`

---

### set_AllowIntegerValues

**Signature:** `Void set_AllowIntegerValues(Boolean)`
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

**Description:** Determines whether this instance can convert the specified object type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `objectType` | `Type` | No | `` | Type of the object. |

**Returns:** true if this instance can convert the specified object type; otherwise, false.

---

## Properties

### CamelCaseText

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether the written enum text should be camel case.

---

### NamingStrategy

**Type:** `NamingStrategy` (read/write)

---

### AllowIntegerValues

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether integer values are allowed.

---