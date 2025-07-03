# JsonContainerContract Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonContainerContract`
- **Base Type:** `Newtonsoft.Json.Serialization.JsonContract`

Contract details for a  used by the .

## Methods

### get_ItemConverter

**Signature:** `Newtonsoft.Json.JsonConverter get_ItemConverter()`
**Return Type:** `JsonConverter`

---

### set_ItemConverter

**Signature:** `Void set_ItemConverter(Newtonsoft.Json.JsonConverter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JsonConverter` | No | `` |  |

---

### get_ItemIsReference

**Signature:** `System.Nullable`1[System.Boolean] get_ItemIsReference()`
**Return Type:** `Nullable`1`

---

### set_ItemIsReference

**Signature:** `Void set_ItemIsReference(System.Nullable`1[System.Boolean])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_ItemReferenceLoopHandling

**Signature:** `System.Nullable`1[Newtonsoft.Json.ReferenceLoopHandling] get_ItemReferenceLoopHandling()`
**Return Type:** `Nullable`1`

---

### set_ItemReferenceLoopHandling

**Signature:** `Void set_ItemReferenceLoopHandling(System.Nullable`1[Newtonsoft.Json.ReferenceLoopHandling])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_ItemTypeNameHandling

**Signature:** `System.Nullable`1[Newtonsoft.Json.TypeNameHandling] get_ItemTypeNameHandling()`
**Return Type:** `Nullable`1`

---

### set_ItemTypeNameHandling

**Signature:** `Void set_ItemTypeNameHandling(System.Nullable`1[Newtonsoft.Json.TypeNameHandling])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

## Properties

### ItemConverter

**Type:** `JsonConverter` (read/write)

**Description:** Gets or sets the default collection items .

---

### ItemIsReference

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets a value indicating whether the collection items preserve object references.

---

### ItemReferenceLoopHandling

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets the collection item reference loop handling.

---

### ItemTypeNameHandling

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets the collection item type name handling.

---