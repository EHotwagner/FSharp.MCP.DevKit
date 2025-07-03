# JsonUnionConverter`1 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonUnionConverter`1`
- **Base Type:** ``
- **Generic Parameters:** `<T>`

## Methods

### Read

**Signature:** `T Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `_typeToConvert` | `Type` | No | `` |  |
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
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### get_HandleNull

**Signature:** `Boolean get_HandleNull()`
**Return Type:** `Boolean`

---

## Properties

### HandleNull

**Type:** `Boolean` (read-only)

---