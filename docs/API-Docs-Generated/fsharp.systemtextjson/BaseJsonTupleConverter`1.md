# BaseJsonTupleConverter`1 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.BaseJsonTupleConverter`1`
- **Base Type:** ``
- **Generic Parameters:** `<T>`

## Methods

### ReadCore

**Signature:** `T ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `Utf8JsonReader&` | No | `` |  |
| `` | `JsonSerializerOptions` | No | `` |  |

---

### WriteCore

**Signature:** `Void WriteCore(System.Text.Json.Utf8JsonWriter, T, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `Utf8JsonWriter` | No | `` |  |
| `` | `T` | No | `` |  |
| `` | `JsonSerializerOptions` | No | `` |  |

---

### Read

**Signature:** `T Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
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

### get_HandleNull

**Signature:** `Boolean get_HandleNull()`
**Return Type:** `Boolean`

---

## Properties

### HandleNull

**Type:** `Boolean` (read-only)

---