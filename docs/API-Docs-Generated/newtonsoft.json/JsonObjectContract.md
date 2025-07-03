# JsonObjectContract Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonObjectContract`
- **Base Type:** `Newtonsoft.Json.Serialization.JsonContainerContract`

Contract details for a  used by the .

## Methods

### get_MemberSerialization

**Signature:** `Newtonsoft.Json.MemberSerialization get_MemberSerialization()`
**Return Type:** `MemberSerialization`

---

### set_MemberSerialization

**Signature:** `Void set_MemberSerialization(Newtonsoft.Json.MemberSerialization)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `MemberSerialization` | No | `` |  |

---

### get_MissingMemberHandling

**Signature:** `System.Nullable`1[Newtonsoft.Json.MissingMemberHandling] get_MissingMemberHandling()`
**Return Type:** `Nullable`1`

---

### set_MissingMemberHandling

**Signature:** `Void set_MissingMemberHandling(System.Nullable`1[Newtonsoft.Json.MissingMemberHandling])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_ItemRequired

**Signature:** `System.Nullable`1[Newtonsoft.Json.Required] get_ItemRequired()`
**Return Type:** `Nullable`1`

---

### set_ItemRequired

**Signature:** `Void set_ItemRequired(System.Nullable`1[Newtonsoft.Json.Required])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_ItemNullValueHandling

**Signature:** `System.Nullable`1[Newtonsoft.Json.NullValueHandling] get_ItemNullValueHandling()`
**Return Type:** `Nullable`1`

---

### set_ItemNullValueHandling

**Signature:** `Void set_ItemNullValueHandling(System.Nullable`1[Newtonsoft.Json.NullValueHandling])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_Properties

**Signature:** `Newtonsoft.Json.Serialization.JsonPropertyCollection get_Properties()`
**Return Type:** `JsonPropertyCollection`

---

### get_CreatorParameters

**Signature:** `Newtonsoft.Json.Serialization.JsonPropertyCollection get_CreatorParameters()`
**Return Type:** `JsonPropertyCollection`

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

### get_ExtensionDataSetter

**Signature:** `Newtonsoft.Json.Serialization.ExtensionDataSetter get_ExtensionDataSetter()`
**Return Type:** `ExtensionDataSetter`

---

### set_ExtensionDataSetter

**Signature:** `Void set_ExtensionDataSetter(Newtonsoft.Json.Serialization.ExtensionDataSetter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ExtensionDataSetter` | No | `` |  |

---

### get_ExtensionDataGetter

**Signature:** `Newtonsoft.Json.Serialization.ExtensionDataGetter get_ExtensionDataGetter()`
**Return Type:** `ExtensionDataGetter`

---

### set_ExtensionDataGetter

**Signature:** `Void set_ExtensionDataGetter(Newtonsoft.Json.Serialization.ExtensionDataGetter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ExtensionDataGetter` | No | `` |  |

---

### get_ExtensionDataValueType

**Signature:** `System.Type get_ExtensionDataValueType()`
**Return Type:** `Type`

---

### set_ExtensionDataValueType

**Signature:** `Void set_ExtensionDataValueType(System.Type)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Type` | No | `` |  |

---

### get_ExtensionDataNameResolver

**Signature:** `System.Func`2[System.String,System.String] get_ExtensionDataNameResolver()`
**Return Type:** `Func`2`

---

### set_ExtensionDataNameResolver

**Signature:** `Void set_ExtensionDataNameResolver(System.Func`2[System.String,System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Func`2` | No | `` |  |

---

## Properties

### MemberSerialization

**Type:** `MemberSerialization` (read/write)

**Description:** Gets or sets the object member serialization.

---

### MissingMemberHandling

**Type:** `Nullable`1` (read/write)

---

### ItemRequired

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets a value that indicates whether the object's properties are required.

---

### ItemNullValueHandling

**Type:** `Nullable`1` (read/write)

---

### Properties

**Type:** `JsonPropertyCollection` (read-only)

**Description:** Gets the object's properties.

---

### CreatorParameters

**Type:** `JsonPropertyCollection` (read-only)

**Description:** Gets a collection of  instances that define the parameters used with .

---

### OverrideCreator

**Type:** `ObjectConstructor`1` (read/write)

**Description:** Gets or sets the function used to create the object. When set this function will override .
            This function is called with a collection of arguments which are defined by the  collection.

---

### ExtensionDataSetter

**Type:** `ExtensionDataSetter` (read/write)

**Description:** Gets or sets the extension data setter.

---

### ExtensionDataGetter

**Type:** `ExtensionDataGetter` (read/write)

**Description:** Gets or sets the extension data getter.

---

### ExtensionDataValueType

**Type:** `Type` (read/write)

**Description:** Gets or sets the extension data value type.

---

### ExtensionDataNameResolver

**Type:** `Func`2` (read/write)

---