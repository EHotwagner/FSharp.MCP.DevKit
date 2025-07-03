# JsonNameAttribute Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.JsonNameAttribute`
- **Base Type:** `System.Attribute`

## Methods

### get_Name

**Signature:** `System.Text.Json.Serialization.JsonName get_Name()`
**Return Type:** `JsonName`

---

### get_OtherNames

**Signature:** `System.Text.Json.Serialization.JsonName[] get_OtherNames()`
**Return Type:** `JsonName[]`

---

### get_AllNames

**Signature:** `System.Text.Json.Serialization.JsonName[] get_AllNames()`
**Return Type:** `JsonName[]`

---

### get_Field

**Signature:** `System.String get_Field()`
**Return Type:** `String`

---

### set_Field

**Signature:** `Void set_Field(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

## Properties

### Name

**Type:** `JsonName` (read-only)

---

### OtherNames

**Type:** `JsonName[]` (read-only)

---

### AllNames

**Type:** `JsonName[]` (read-only)

---

### Field

**Type:** `String` (read/write)

**Description:** The name of the union field that this name applies to.

---