# JsonPropertyCollection Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonPropertyCollection`
- **Base Type:** `System.Collections.ObjectModel.KeyedCollection`2[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`
- **Implements:** `System.Collections.Generic.IList`1[[Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.ICollection`1[[Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `System.Collections.IList`, `System.Collections.ICollection`, `System.Collections.Generic.IReadOnlyList`1[[Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IReadOnlyCollection`1[[Newtonsoft.Json.Serialization.JsonProperty, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`

A collection of  objects.

## Methods

### AddProperty

**Signature:** `Void AddProperty(Newtonsoft.Json.Serialization.JsonProperty)`
**Return Type:** `Void`

**Description:** Adds a  object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `property` | `JsonProperty` | No | `` | The property to add to the collection. |

---

### GetClosestMatchProperty

**Signature:** `Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(System.String)`
**Return Type:** `JsonProperty`

**Description:** Gets the closest matching  object.
            First attempts to get an exact case match of propertyName and then
            a case insensitive match.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | Name of the property. |

**Returns:** A matching property if found.

---

### GetProperty

**Signature:** `Newtonsoft.Json.Serialization.JsonProperty GetProperty(System.String, System.StringComparison)`
**Return Type:** `JsonProperty`

**Description:** Gets a property by property name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | The name of the property to get. |
| `comparisonType` | `StringComparison` | No | `` | Type property name string comparison. |

**Returns:** A matching property if found.

---