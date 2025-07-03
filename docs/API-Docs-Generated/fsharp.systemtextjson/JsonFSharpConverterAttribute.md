# JsonFSharpConverterAttribute Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonFSharpConverterAttribute`
- **Base Type:** `System.Text.Json.Serialization.JsonConverterAttribute`
- **Implements:** `System.Text.Json.Serialization.IJsonFSharpConverterAttribute`

## Methods

### set_UnionEncoding

**Signature:** `Void set_UnionEncoding(System.Text.Json.Serialization.JsonUnionEncoding)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `JsonUnionEncoding` | No | `` |  |

---

### set_BaseUnionEncoding

**Signature:** `Void set_BaseUnionEncoding(System.Text.Json.Serialization.JsonUnionEncoding)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `JsonUnionEncoding` | No | `` |  |

---

### set_UnionTagName

**Signature:** `Void set_UnionTagName(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### set_UnionFieldsName

**Signature:** `Void set_UnionFieldsName(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### set_UnionTagNamingPolicy

**Signature:** `Void set_UnionTagNamingPolicy(System.Text.Json.Serialization.JsonKnownNamingPolicy)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `JsonKnownNamingPolicy` | No | `` |  |

---

### set_UnionFieldNamingPolicy

**Signature:** `Void set_UnionFieldNamingPolicy(System.Text.Json.Serialization.JsonKnownNamingPolicy)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `JsonKnownNamingPolicy` | No | `` |  |

---

### set_UnionTagCaseSensitive

**Signature:** `Void set_UnionTagCaseSensitive(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_AllowNullFields

**Signature:** `Void set_AllowNullFields(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_IncludeRecordProperties

**Signature:** `Void set_IncludeRecordProperties(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_Types

**Signature:** `Void set_Types(System.Text.Json.Serialization.JsonFSharpTypes)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `JsonFSharpTypes` | No | `` |  |

---

### set_UnionNamedFields

**Signature:** `Void set_UnionNamedFields(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnionUnwrapFieldlessTags

**Signature:** `Void set_UnionUnwrapFieldlessTags(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnwrapOption

**Signature:** `Void set_UnwrapOption(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnionUnwrapSingleCaseUnions

**Signature:** `Void set_UnionUnwrapSingleCaseUnions(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnionUnwrapSingleFieldCases

**Signature:** `Void set_UnionUnwrapSingleFieldCases(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnionUnwrapRecordCases

**Signature:** `Void set_UnionUnwrapRecordCases(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnionAllowUnorderedTag

**Signature:** `Void set_UnionAllowUnorderedTag(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_UnionFieldNamesFromTypes

**Signature:** `Void set_UnionFieldNamesFromTypes(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### set_SkippableOptionFields

**Signature:** `Void set_SkippableOptionFields(System.Text.Json.Serialization.SkippableOptionFields)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `SkippableOptionFields` | No | `` |  |

---

### CreateConverter

**Signature:** `System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type)`
**Return Type:** `JsonConverter`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeToConvert` | `Type` | No | `` |  |

---

## Properties

### UnionEncoding

**Type:** `JsonUnionEncoding` (write-only)

---

### BaseUnionEncoding

**Type:** `JsonUnionEncoding` (write-only)

---

### UnionTagName

**Type:** `String` (write-only)

---

### UnionFieldsName

**Type:** `String` (write-only)

---

### UnionTagNamingPolicy

**Type:** `JsonKnownNamingPolicy` (write-only)

---

### UnionFieldNamingPolicy

**Type:** `JsonKnownNamingPolicy` (write-only)

---

### UnionTagCaseSensitive

**Type:** `Boolean` (write-only)

---

### AllowNullFields

**Type:** `Boolean` (write-only)

---

### IncludeRecordProperties

**Type:** `Boolean` (write-only)

---

### Types

**Type:** `JsonFSharpTypes` (write-only)

---

### UnionNamedFields

**Type:** `Boolean` (write-only)

---

### UnionUnwrapFieldlessTags

**Type:** `Boolean` (write-only)

---

### UnwrapOption

**Type:** `Boolean` (write-only)

---

### UnionUnwrapSingleCaseUnions

**Type:** `Boolean` (write-only)

---

### UnionUnwrapSingleFieldCases

**Type:** `Boolean` (write-only)

---

### UnionUnwrapRecordCases

**Type:** `Boolean` (write-only)

---

### UnionAllowUnorderedTag

**Type:** `Boolean` (write-only)

---

### UnionFieldNamesFromTypes

**Type:** `Boolean` (write-only)

---

### SkippableOptionFields

**Type:** `SkippableOptionFields` (write-only)

---