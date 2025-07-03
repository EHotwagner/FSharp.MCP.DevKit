# JsonFSharpOptions Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonFSharpOptions`

## Methods

### Default (static)

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions Default()`
**Return Type:** `JsonFSharpOptions`

---

### InheritUnionEncoding (static)

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions InheritUnionEncoding()`
**Return Type:** `JsonFSharpOptions`

---

### NewtonsoftLike (static)

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions NewtonsoftLike()`
**Return Type:** `JsonFSharpOptions`

---

### ThothLike (static)

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions ThothLike()`
**Return Type:** `JsonFSharpOptions`

---

### FSharpLuLike (static)

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions FSharpLuLike()`
**Return Type:** `JsonFSharpOptions`

---

### get_UnionEncoding

**Signature:** `System.Text.Json.Serialization.JsonUnionEncoding get_UnionEncoding()`
**Return Type:** `JsonUnionEncoding`

---

### get_UnionTagName

**Signature:** `System.String get_UnionTagName()`
**Return Type:** `String`

---

### get_UnionFieldsName

**Signature:** `System.String get_UnionFieldsName()`
**Return Type:** `String`

---

### get_UnionTagNamingPolicy

**Signature:** `System.Text.Json.JsonNamingPolicy get_UnionTagNamingPolicy()`
**Return Type:** `JsonNamingPolicy`

---

### get_UnionFieldNamingPolicy

**Signature:** `System.Text.Json.JsonNamingPolicy get_UnionFieldNamingPolicy()`
**Return Type:** `JsonNamingPolicy`

---

### get_UnionTagCaseInsensitive

**Signature:** `Boolean get_UnionTagCaseInsensitive()`
**Return Type:** `Boolean`

---

### get_AllowNullFields

**Signature:** `Boolean get_AllowNullFields()`
**Return Type:** `Boolean`

---

### get_IncludeRecordProperties

**Signature:** `Boolean get_IncludeRecordProperties()`
**Return Type:** `Boolean`

---

### get_SkippableOptionFields

**Signature:** `System.Text.Json.Serialization.SkippableOptionFields get_SkippableOptionFields()`
**Return Type:** `SkippableOptionFields`

---

### get_MapFormat

**Signature:** `System.Text.Json.Serialization.MapFormat get_MapFormat()`
**Return Type:** `MapFormat`

---

### get_Types

**Signature:** `System.Text.Json.Serialization.JsonFSharpTypes get_Types()`
**Return Type:** `JsonFSharpTypes`

---

### get_AllowOverride

**Signature:** `Boolean get_AllowOverride()`
**Return Type:** `Boolean`

---

### get_Overrides

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Text.Json.Serialization.JsonFSharpOptions,System.Collections.Generic.IDictionary`2[System.Type,System.Text.Json.Serialization.JsonFSharpOptions]] get_Overrides()`
**Return Type:** `FSharpFunc`2`

---

### WithUnionEncoding

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionEncoding(System.Text.Json.Serialization.JsonUnionEncoding)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionEncoding` | `JsonUnionEncoding` | No | `` |  |

---

### WithUnionTagName

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionTagName(System.String)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionTagName` | `String` | No | `` |  |

---

### WithUnionFieldsName

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionFieldsName(System.String)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionFieldsName` | `String` | No | `` |  |

---

### WithUnionTagNamingPolicy

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionTagNamingPolicy(System.Text.Json.JsonNamingPolicy)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionTagNamingPolicy` | `JsonNamingPolicy` | No | `` |  |

---

### WithUnionFieldNamingPolicy

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionFieldNamingPolicy(System.Text.Json.JsonNamingPolicy)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionFieldNamingPolicy` | `JsonNamingPolicy` | No | `` |  |

---

### WithUnionTagCaseInsensitive

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionTagCaseInsensitive(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionTagCaseInsensitive` | `Boolean` | Yes | `True` |  |

---

### WithAllowNullFields

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithAllowNullFields(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `allowNullFields` | `Boolean` | Yes | `True` |  |

---

### WithIncludeRecordProperties

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithIncludeRecordProperties(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `includeRecordProperties` | `Boolean` | Yes | `True` |  |

---

### WithSkippableOptionFields

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithSkippableOptionFields(System.Text.Json.Serialization.SkippableOptionFields, Boolean)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skippableOptionFields` | `SkippableOptionFields` | No | `` |  |
| `deserializeNullAsNone` | `Boolean` | Yes | `False` |  |

---

### WithSkippableOptionFields

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithSkippableOptionFields(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skippableOptionFields` | `Boolean` | Yes | `True` |  |

---

### WithMapFormat

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithMapFormat(System.Text.Json.Serialization.MapFormat)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `MapFormat` | No | `` |  |

---

### WithTypes

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithTypes(System.Text.Json.Serialization.JsonFSharpTypes)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `types` | `JsonFSharpTypes` | No | `` |  |

---

### WithAllowOverride

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithAllowOverride(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `allowOverride` | `Boolean` | Yes | `True` |  |

---

### WithOverrides

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithOverrides(Microsoft.FSharp.Core.FSharpFunc`2[System.Text.Json.Serialization.JsonFSharpOptions,System.Collections.Generic.IDictionary`2[System.Type,System.Text.Json.Serialization.JsonFSharpOptions]])`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `overrides` | `FSharpFunc`2` | No | `` |  |

---

### WithOverrides

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithOverrides(System.Collections.Generic.IDictionary`2[System.Type,System.Text.Json.Serialization.JsonFSharpOptions])`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `overrides` | `IDictionary`2` | No | `` |  |

---

### WithOverrideMembers

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithOverrideMembers(System.Collections.Generic.IDictionary`2[System.String,System.Collections.Generic.IEnumerable`1[System.Attribute]])`
**Return Type:** `JsonFSharpOptions`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `overrides` | `IDictionary`2` | No | `` |  |

---

### WithUnionAdjacentTag

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionAdjacentTag()`
**Return Type:** `JsonFSharpOptions`

**Description:** Encode unions as a 2-valued object:
 `unionTagName` (defaults to "Case") contains the union tag,
 and `unionFieldsName` (defaults to "Fields") contains the union fields.
 If the case doesn't have fields, "Fields": [] is omitted.
 This flag is included in Default.

---

### WithUnionExternalTag

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionExternalTag()`
**Return Type:** `JsonFSharpOptions`

**Description:** Encode unions as a 1-valued object:
 The field name is the union tag, and the value is the union fields.

---

### WithUnionInternalTag

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionInternalTag()`
**Return Type:** `JsonFSharpOptions`

**Description:** Encode unions as a (n+1)-valued object or array (depending on NamedFields):
 the first value (named `unionTagName`, defaulting to "Case", if NamedFields is set)
 is the union tag, the rest are the union fields.

---

### WithUnionUntagged

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionUntagged()`
**Return Type:** `JsonFSharpOptions`

**Description:** Encode unions as a n-valued object:
 the union tag is not encoded, only the union fields are.
 Deserialization is only possible if the fields of all cases have different names.

---

### WithUnionNamedFields

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionNamedFields(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** If unset, union fields are encoded as an array.
 If set, union fields are encoded as an object using their field names.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnionUnwrapFieldlessTags

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionUnwrapFieldlessTags(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** If set, union cases that don't have fields are encoded as a bare string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnwrapOption

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnwrapOption(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** If set, `None` is represented as null,
 and `Some x`  is represented the same as `x`.
 This flag is included in Default.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnionUnwrapSingleCaseUnions

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionUnwrapSingleCaseUnions(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** If set, single-case single-field unions are serialized as the single field's value.
 This flag is included in Default.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnionUnwrapSingleFieldCases

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionUnwrapSingleFieldCases(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** If set, the field of a single-field union case is encoded as just the value
 rather than a single-value array or object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnionUnwrapRecordCases

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionUnwrapRecordCases(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** Implicitly sets NamedFields. If set, when a union case has a single field which is a record,
 the fields of this record are encoded directly as fields of the object representing the union.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnionAllowUnorderedTag

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionAllowUnorderedTag(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** In AdjacentTag and InternalTag mode, allow deserializing unions
 where the tag is not the first field in the JSON object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

### WithUnionFieldNamesFromTypes

**Signature:** `System.Text.Json.Serialization.JsonFSharpOptions WithUnionFieldNamesFromTypes(Boolean)`
**Return Type:** `JsonFSharpOptions`

**Description:** When a union field doesn't have an explicit name, use its type as name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `set` | `Boolean` | Yes | `True` |  |

---

## Properties

### UnionEncoding

**Type:** `JsonUnionEncoding` (read-only)

---

### UnionTagName

**Type:** `String` (read-only)

---

### UnionFieldsName

**Type:** `String` (read-only)

---

### UnionTagNamingPolicy

**Type:** `JsonNamingPolicy` (read-only)

---

### UnionFieldNamingPolicy

**Type:** `JsonNamingPolicy` (read-only)

---

### UnionTagCaseInsensitive

**Type:** `Boolean` (read-only)

---

### AllowNullFields

**Type:** `Boolean` (read-only)

---

### IncludeRecordProperties

**Type:** `Boolean` (read-only)

---

### SkippableOptionFields

**Type:** `SkippableOptionFields` (read-only)

---

### MapFormat

**Type:** `MapFormat` (read-only)

---

### Types

**Type:** `JsonFSharpTypes` (read-only)

---

### AllowOverride

**Type:** `Boolean` (read-only)

---

### Overrides

**Type:** `FSharpFunc`2` (read-only)

---