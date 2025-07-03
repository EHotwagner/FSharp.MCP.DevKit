# JsonConverter`1 Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonConverter`1`
- **Base Type:** `Newtonsoft.Json.JsonConverter`
- **Generic Parameters:** `<T>`

## Methods

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

### WriteJson

**Signature:** `Void WriteJson(Newtonsoft.Json.JsonWriter, T, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` |  |
| `value` | `T` | No | `` |  |
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

### ReadJson

**Signature:** `T ReadJson(Newtonsoft.Json.JsonReader, System.Type, T, Boolean, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `objectType` | `Type` | No | `` |  |
| `existingValue` | `T` | No | `` |  |
| `hasExistingValue` | `Boolean` | No | `` |  |
| `serializer` | `JsonSerializer` | No | `` |  |

---

### CanConvert

**Signature:** `Boolean CanConvert(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `objectType` | `Type` | No | `` |  |

---