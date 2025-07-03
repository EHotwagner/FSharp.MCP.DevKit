# JsonDictionaryContract Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonDictionaryContract`
- **Base Type:** `Newtonsoft.Json.Serialization.JsonContainerContract`

Contract details for a  used by the .

## Methods

### get_DictionaryKeyResolver

**Signature:** `System.Func`2[System.String,System.String] get_DictionaryKeyResolver()`
**Return Type:** `Func`2`

---

### set_DictionaryKeyResolver

**Signature:** `Void set_DictionaryKeyResolver(System.Func`2[System.String,System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Func`2` | No | `` |  |

---

### get_DictionaryKeyType

**Signature:** `System.Type get_DictionaryKeyType()`
**Return Type:** `Type`

---

### get_DictionaryValueType

**Signature:** `System.Type get_DictionaryValueType()`
**Return Type:** `Type`

---

### get_OverrideCreator

**Signature:** `Newtonsoft.Json.Serialization.ObjectConstructor`1[System.Object] get_OverrideCreator()`
**Return Type:** `ObjectConstructor`1`

---

### set_OverrideCreator

**Signature:** `Void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor`1[System.Object])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ObjectConstructor`1` | No | `` |  |

---

### get_HasParameterizedCreator

**Signature:** `Boolean get_HasParameterizedCreator()`
**Return Type:** `Boolean`

---

### set_HasParameterizedCreator

**Signature:** `Void set_HasParameterizedCreator(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

## Properties

### DictionaryKeyResolver

**Type:** `Func`2` (read/write)

**Description:** Gets or sets the dictionary key resolver.

---

### DictionaryKeyType

**Type:** `Type` (read-only)

**Description:** Gets the  of the dictionary keys.

---

### DictionaryValueType

**Type:** `Type` (read-only)

**Description:** Gets the  of the dictionary values.

---

### OverrideCreator

**Type:** `ObjectConstructor`1` (read/write)

**Description:** Gets or sets the function used to create the object. When set this function will override .

---

### HasParameterizedCreator

**Type:** `Boolean` (read/write)

**Description:** Gets a value indicating whether the creator has a parameter with the dictionary values.

---