# NamingStrategy Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.NamingStrategy`

A base class for resolving how property names and dictionary keys are serialized.

## Methods

### get_ProcessDictionaryKeys

**Signature:** `Boolean get_ProcessDictionaryKeys()`
**Return Type:** `Boolean`

---

### set_ProcessDictionaryKeys

**Signature:** `Void set_ProcessDictionaryKeys(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_ProcessExtensionDataNames

**Signature:** `Boolean get_ProcessExtensionDataNames()`
**Return Type:** `Boolean`

---

### set_ProcessExtensionDataNames

**Signature:** `Void set_ProcessExtensionDataNames(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_OverrideSpecifiedNames

**Signature:** `Boolean get_OverrideSpecifiedNames()`
**Return Type:** `Boolean`

---

### set_OverrideSpecifiedNames

**Signature:** `Void set_OverrideSpecifiedNames(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### GetPropertyName

**Signature:** `System.String GetPropertyName(System.String, Boolean)`
**Return Type:** `String`

**Description:** Gets the serialized name for a given property name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The initial property name. |
| `hasSpecifiedName` | `Boolean` | No | `` | A flag indicating whether the property has had a name explicitly specfied. |

**Returns:** The serialized property name.

---

### GetExtensionDataName

**Signature:** `System.String GetExtensionDataName(System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### GetDictionaryKey

**Signature:** `System.String GetDictionaryKey(System.String)`
**Return Type:** `String`

**Description:** Gets the serialized key for a given dictionary key.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` | The initial dictionary key. |

**Returns:** The serialized dictionary key.

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

## Properties

### ProcessDictionaryKeys

**Type:** `Boolean` (read/write)

**Description:** A flag indicating whether dictionary keys should be processed.
            Defaults to false.

---

### ProcessExtensionDataNames

**Type:** `Boolean` (read/write)

---

### OverrideSpecifiedNames

**Type:** `Boolean` (read/write)

**Description:** A flag indicating whether explicitly specified property names,
            e.g. a property name customized with a , should be processed.
            Defaults to false.

---