# JsonExtensionDataAttribute Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonExtensionDataAttribute`
- **Base Type:** `System.Attribute`

Instructs the  to deserialize properties with no matching class member into the specified collection
            and write values during serialization.

## Methods

### get_WriteData

**Signature:** `Boolean get_WriteData()`
**Return Type:** `Boolean`

---

### set_WriteData

**Signature:** `Void set_WriteData(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_ReadData

**Signature:** `Boolean get_ReadData()`
**Return Type:** `Boolean`

---

### set_ReadData

**Signature:** `Void set_ReadData(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

## Properties

### WriteData

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value that indicates whether to write extension data when serializing the object.

---

### ReadData

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value that indicates whether to read extension data when deserializing the object.

---