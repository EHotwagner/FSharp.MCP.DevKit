# JsonArrayContract Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonArrayContract`
- **Base Type:** `Newtonsoft.Json.Serialization.JsonContainerContract`

Contract details for a  used by the .

## Methods

### get_CollectionItemType

**Signature:** `System.Type get_CollectionItemType()`
**Return Type:** `Type`

---

### get_IsMultidimensionalArray

**Signature:** `Boolean get_IsMultidimensionalArray()`
**Return Type:** `Boolean`

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

### CollectionItemType

**Type:** `Type` (read-only)

**Description:** Gets the  of the collection items.

---

### IsMultidimensionalArray

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether the collection type is a multidimensional array.

---

### OverrideCreator

**Type:** `ObjectConstructor`1` (read/write)

**Description:** Gets or sets the function used to create the object. When set this function will override .

---

### HasParameterizedCreator

**Type:** `Boolean` (read/write)

**Description:** Gets a value indicating whether the creator has a parameter with the collection values.

---