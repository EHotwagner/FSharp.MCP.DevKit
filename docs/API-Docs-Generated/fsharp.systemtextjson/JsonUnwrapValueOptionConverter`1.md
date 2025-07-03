# JsonUnwrapValueOptionConverter`1 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonUnwrapValueOptionConverter`1`
- **Base Type:** ``
- **Generic Parameters:** `<T>`

## Methods

### Read

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[T] Read(System.Text.Json.Utf8JsonReader ByRef, System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `_typeToConvert` | `Type` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### Write

**Signature:** `Void Write(System.Text.Json.Utf8JsonWriter, Microsoft.FSharp.Core.FSharpValueOption`1[T], System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `value` | `FSharpValueOption`1` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---