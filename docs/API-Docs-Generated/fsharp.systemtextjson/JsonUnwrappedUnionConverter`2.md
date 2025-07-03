# JsonUnwrappedUnionConverter`2 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonUnwrappedUnionConverter`2`
- **Base Type:** ``
- **Generic Parameters:** `<T, FieldT>`

## Methods

### Read

**Signature:** `T Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `_typeToConvert` | `Type` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### ReadAsPropertyName

**Signature:** `T ReadAsPropertyName(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `typeToConvert` | `Type` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### Write

**Signature:** `Void Write(System.Text.Json.Utf8JsonWriter, T, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `T` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### WriteAsPropertyName

**Signature:** `Void WriteAsPropertyName(System.Text.Json.Utf8JsonWriter, T, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `T` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---