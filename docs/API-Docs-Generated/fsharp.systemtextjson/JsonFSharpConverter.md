# JsonFSharpConverter Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonFSharpConverter`
- **Base Type:** `System.Text.Json.Serialization.JsonConverterFactory`

## Methods

### get_Options

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions get_Options()`
**Return Type:** `JsonFSharpOptions`

---

### get_Overrides

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Text.Json.Serialization.JsonFSharpOptions,System.Collections.Generic.IDictionary`2[System.Type,System.Text.Json.Serialization.JsonFSharpOptions]] get_Overrides()`
**Return Type:** `FSharpFunc`2`

---

### CanConvert

**Signature:** `Boolean CanConvert(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeToConvert` | `Type` | No | `` |  |

---

### CreateConverter

**Signature:** `System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type, System.Text.Json.JsonSerializerOptions)`
**Return Type:** `JsonConverter`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeToConvert` | `Type` | No | `` |  |
| `options` | `JsonSerializerOptions` | No | `` |  |

---

## Properties

### Options

**Type:** `JsonFSharpOptions` (read-only)

---

### Overrides

**Type:** `FSharpFunc`2` (read-only)

---