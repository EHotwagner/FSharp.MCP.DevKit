# JsonStructTupleConverter`2 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonStructTupleConverter`2`
- **Base Type:** ``
- **Generic Parameters:** `<T1, T2>`

## Methods

### ReadCore

**Signature:** `System.ValueTuple`2[T1,T2] ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `ValueTuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### WriteCore

**Signature:** `Void WriteCore(System.Text.Json.Utf8JsonWriter, System.ValueTuple`2[T1,T2], System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `_arg1` | `ValueTuple`2` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---