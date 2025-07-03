# JsonUnwrapOptionConverter`1 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonUnwrapOptionConverter`1`
- **Base Type:** ``
- **Generic Parameters:** `<T>`

## Methods

### Read

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `_typeToConvert` | `Type` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### Write

**Signature:** `Void Write(System.Text.Json.Utf8JsonWriter, Microsoft.FSharp.Core.FSharpOption`1[T], System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `FSharpOption`1` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---