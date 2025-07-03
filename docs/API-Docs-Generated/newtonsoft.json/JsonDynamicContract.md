# JsonDynamicContract Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonDynamicContract`
- **Base Type:** `Newtonsoft.Json.Serialization.JsonContainerContract`

Contract details for a  used by the .

## Methods

### get_Properties

**Signature:** `Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties()`
**Return Type:** `JsonPropertyCollection`

---

### get_PropertyNameResolver

**Signature:** `System.Func`2[System.String,System.String] get_PropertyNameResolver()`
**Return Type:** `Func`2`

---

### set_PropertyNameResolver

**Signature:** `Void set_PropertyNameResolver(System.Func`2[System.String,System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Func`2` | No | `` |  |

---

## Properties

### Properties

**Type:** `JsonPropertyCollection` (read-only)

**Description:** Gets the object's properties.

---

### PropertyNameResolver

**Type:** `Func`2` (read/write)

**Description:** Gets or sets the property name resolver.

---