# IAttributeProvider Interface

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.IAttributeProvider`

Provides methods to get attributes.

## Methods

### GetAttributes

**Signature:** `System.Collections.Generic.IList`1[System.Attribute] GetAttributes(Boolean)`
**Return Type:** `IList`1`

**Description:** Returns a collection of all of the attributes, or an empty collection if there are no attributes.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `inherit` | `Boolean` | No | `` | When true, look up the hierarchy chain for the inherited custom attribute. |

**Returns:** A collection of s, or an empty collection.

---

### GetAttributes

**Signature:** `System.Collections.Generic.IList`1[System.Attribute] GetAttributes(System.Type, Boolean)`
**Return Type:** `IList`1`

**Description:** Returns a collection of attributes, identified by type, or an empty collection if there are no attributes.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `attributeType` | `Type` | No | `` | The type of the attributes. |
| `inherit` | `Boolean` | No | `` | When true, look up the hierarchy chain for the inherited custom attribute. |

**Returns:** A collection of s, or an empty collection.

---