# JsonStructTupleConverter`3 Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonStructTupleConverter`3`
- **Base Type:** ``
- **Generic Parameters:** `<T1, T2, T3>`

## Methods

### ReadCore

**Signature:** `System.ValueTuple`3[T1,T2,T3] ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `ValueTuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `Utf8JsonReader&` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

### WriteCore

**Signature:** `Void WriteCore(System.Text.Json.Utf8JsonWriter, System.ValueTuple`3[T1,T2,T3], System.Text.Json.JsonSerializerOptions)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `Utf8JsonWriter` | No | `` |  |
| `_arg1` | `ValueTuple`3` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---