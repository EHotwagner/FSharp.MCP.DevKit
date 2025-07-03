# JsonEnumLikeUnionConverter`1 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonEnumLikeUnionConverter`1`
- **Base Type:** ``
- **Generic Parameters:** `<T>`

## Methods

### get_HandleNull

**Signature:** `Boolean get_HandleNull()`
**Return Type:** `Boolean`

---

### Read

**Signature:** `T Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `typeToConvert` | `Type` | No | `` |  |
| `_options` | `JsonSerializerOptions` | No | `` |  |

---

### ReadAsPropertyName

**Signature:** `T ReadAsPropertyName(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `typeToConvert` | `Type` | No | `` |  |
| `_options` | `JsonSerializerOptions` | No | `` |  |

---

### Write

**Signature:** `Void Write(System.Text.Json.Utf8JsonWriter, T, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `T` | No | `` |  |
| `_options` | `JsonSerializerOptions` | No | `` |  |

---

### WriteAsPropertyName

**Signature:** `Void WriteAsPropertyName(System.Text.Json.Utf8JsonWriter, T, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `T` | No | `` |  |
| `_options` | `JsonSerializerOptions` | No | `` |  |

---

## Properties

### HandleNull

**Type:** `Boolean` (read-only)

---