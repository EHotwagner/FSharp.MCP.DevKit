# JavaScriptDateTimeConverter Class

**Namespace:** `Newtonsoft.Json.Converters`
**Full Name:** `Newtonsoft.Json.Converters.JavaScriptDateTimeConverter`
- **Base Type:** `Newtonsoft.Json.Converters.DateTimeConverterBase`

Converts a  to and from a JavaScript date constructor (e.g. new Date(52231943)).

## Methods

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
| `existingValue` | `Object` | No | `` | The existing property value of the JSON that is being converted. |
| `serializer` | `JsonSerializer` | No | `` | The calling serializer. |

**Returns:** The object value.

---