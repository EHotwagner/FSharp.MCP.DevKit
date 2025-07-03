# JsonContainerAttribute Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonContainerAttribute`
- **Base Type:** `System.Attribute`

Instructs the  how to serialize the object.

## Methods

### get_Id

**Signature:** `System.String get_Id()`
**Return Type:** `String`

---

### set_Id

**Signature:** `Void set_Id(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_Title

**Signature:** `System.String get_Title()`
**Return Type:** `String`

---

### set_Title

**Signature:** `Void set_Title(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_Description

**Signature:** `System.String get_Description()`
**Return Type:** `String`

---

### set_Description

**Signature:** `Void set_Description(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_ItemConverterType

**Signature:** `System.Type get_ItemConverterType()`
**Return Type:** `Type`

---

### set_ItemConverterType

**Signature:** `Void set_ItemConverterType(System.Type)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Type` | No | `` |  |

---

### get_ItemConverterParameters

**Signature:** `System.Object[] get_ItemConverterParameters()`
**Return Type:** `Object[]`

---

### set_ItemConverterParameters

**Signature:** `Void set_ItemConverterParameters(System.Object[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object[]` | No | `` |  |

---

### get_NamingStrategyType

**Signature:** `System.Type get_NamingStrategyType()`
**Return Type:** `Type`

---

### set_NamingStrategyType

**Signature:** `Void set_NamingStrategyType(System.Type)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Type` | No | `` |  |

---

### get_NamingStrategyParameters

**Signature:** `System.Object[] get_NamingStrategyParameters()`
**Return Type:** `Object[]`

---

### set_NamingStrategyParameters

**Signature:** `Void set_NamingStrategyParameters(System.Object[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object[]` | No | `` |  |

---

### get_IsReference

**Signature:** `Boolean get_IsReference()`
**Return Type:** `Boolean`

---

### set_IsReference

**Signature:** `Void set_IsReference(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_ItemIsReference

**Signature:** `Boolean get_ItemIsReference()`
**Return Type:** `Boolean`

---

### set_ItemIsReference

**Signature:** `Void set_ItemIsReference(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_ItemReferenceLoopHandling

**Signature:** `Newtonsoft.Json.ReferenceLoopHandling get_ItemReferenceLoopHandling()`
**Return Type:** `ReferenceLoopHandling`

---

### set_ItemReferenceLoopHandling

**Signature:** `Void set_ItemReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ReferenceLoopHandling` | No | `` |  |

---

### get_ItemTypeNameHandling

**Signature:** `Newtonsoft.Json.TypeNameHandling get_ItemTypeNameHandling()`
**Return Type:** `TypeNameHandling`

---

### set_ItemTypeNameHandling

**Signature:** `Void set_ItemTypeNameHandling(Newtonsoft.Json.TypeNameHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TypeNameHandling` | No | `` |  |

---

## Properties

### Id

**Type:** `String` (read/write)

**Description:** Gets or sets the id.

---

### Title

**Type:** `String` (read/write)

**Description:** Gets or sets the title.

---

### Description

**Type:** `String` (read/write)

**Description:** Gets or sets the description.

---

### ItemConverterType

**Type:** `Type` (read/write)

**Description:** Gets or sets the collection's items converter.

---

### ItemConverterParameters

**Type:** `Object[]` (read/write)

**Description:** The parameter list to use when constructing the  described by ItemConverterType.
            If null, the default constructor is used.
            When non-null, there must be a constructor defined in the  that exactly matches the number,
            order, and type of these parameters.

---

### NamingStrategyType

**Type:** `Type` (read/write)

**Description:** Gets or sets the  of the .

---

### NamingStrategyParameters

**Type:** `Object[]` (read/write)

**Description:** The parameter list to use when constructing the  described by NamingStrategyType.  
            If null, the default constructor is used.
            When non-null, there must be a constructor defined in the  that exactly matches the number,
            order, and type of these parameters.

---

### IsReference

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value that indicates whether to preserve object references.

---

### ItemIsReference

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value that indicates whether to preserve collection's items references.

---

### ItemReferenceLoopHandling

**Type:** `ReferenceLoopHandling` (read/write)

**Description:** Gets or sets the reference loop handling used when serializing the collection's items.

---

### ItemTypeNameHandling

**Type:** `TypeNameHandling` (read/write)

**Description:** Gets or sets the type name handling used when serializing the collection's items.

---