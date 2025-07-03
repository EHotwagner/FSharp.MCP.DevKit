# JsonMapObjectConverter`2 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonMapObjectConverter`2`
- **Base Type:** ``
- **Generic Parameters:** `<K, V>`

## Methods

### Read

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[K,V] Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `FSharpMap`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `_typeToConvert` | `Type` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### Write

**Signature:** `Void Write(System.Text.Json.Utf8JsonWriter, Microsoft.FSharp.Collections.FSharpMap`2[K,V], System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `FSharpMap`2` | No | `` |  |
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