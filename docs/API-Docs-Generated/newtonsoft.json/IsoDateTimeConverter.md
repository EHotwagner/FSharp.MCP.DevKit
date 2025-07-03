# IsoDateTimeConverter Class

**Namespace:** `Newtonsoft.Json.Converters`
**Full Name:** `Newtonsoft.Json.Converters.IsoDateTimeConverter`
- **Base Type:** `Newtonsoft.Json.Converters.DateTimeConverterBase`

Converts a  to and from the ISO 8601 date format (e.g. 2008-04-12T12:53Z).

## Methods

### get_DateTimeStyles

**Signature:** `System.Globalization.DateTimeStyles get_DateTimeStyles()`
**Return Type:** `DateTimeStyles`

---

### set_DateTimeStyles

**Signature:** `Void set_DateTimeStyles(System.Globalization.DateTimeStyles)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeStyles` | No | `` |  |

---

### get_DateTimeFormat

**Signature:** `System.String get_DateTimeFormat()`
**Return Type:** `String`

---

### set_DateTimeFormat

**Signature:** `Void set_DateTimeFormat(System.String)`
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

## Properties

### DateTimeStyles

**Type:** `DateTimeStyles` (read/write)

**Description:** Gets or sets the date time styles used when converting a date to and from JSON.

---

### DateTimeFormat

**Type:** `String` (read/write)

**Description:** Gets or sets the date time format used when converting a date to and from JSON.

---

### Culture

**Type:** `CultureInfo` (read/write)

**Description:** Gets or sets the culture used when converting a date to and from JSON.

---