# UnixDateTimeConverter Class

**Namespace:** `Newtonsoft.Json.Converters`
**Full Name:** `Newtonsoft.Json.Converters.UnixDateTimeConverter`
- **Base Type:** `Newtonsoft.Json.Converters.DateTimeConverterBase`

## Methods

### get_AllowPreEpoch

**Signature:** `Boolean get_AllowPreEpoch()`
**Return Type:** `Boolean`

---

### set_AllowPreEpoch

**Signature:** `Void set_AllowPreEpoch(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### WriteJson

**Signature:** `Void WriteJson(Newtonsoft.Json.JsonWriter, System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` |  |
| `value` | `Object` | No | `` |  |
| `serializer` | `JsonSerializer` | No | `` |  |

---

### ReadJson

**Signature:** `System.Object ReadJson(Newtonsoft.Json.JsonReader, System.Type, System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `objectType` | `Type` | No | `` |  |
| `existingValue` | `Object` | No | `` |  |
| `serializer` | `JsonSerializer` | No | `` |  |

---

## Properties

### AllowPreEpoch

**Type:** `Boolean` (read/write)

---