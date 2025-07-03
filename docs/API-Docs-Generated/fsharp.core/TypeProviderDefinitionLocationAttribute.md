# TypeProviderDefinitionLocationAttribute Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute`
- **Base Type:** `System.Attribute`

A type provider may provide an instance of this attribute to indicate the definition location for a provided type or member.

## Methods

### get_FilePath

**Signature:** `System.String get_FilePath()`
**Return Type:** `String`

---

### set_FilePath

**Signature:** `Void set_FilePath(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### get_Line

**Signature:** `Int32 get_Line()`
**Return Type:** `Int32`

---

### set_Line

**Signature:** `Void set_Line(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Int32` | No | `` |  |

---

### get_Column

**Signature:** `Int32 get_Column()`
**Return Type:** `Int32`

---

### set_Column

**Signature:** `Void set_Column(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Int32` | No | `` |  |

---

## Properties

### FilePath

**Type:** `String` (read/write)

**Description:** Gets or sets the file path for the definition location.

---

### Line

**Type:** `Int32` (read/write)

**Description:** Gets or sets the line for the location.

---

### Column

**Type:** `Int32` (read/write)

**Description:** Gets or sets the column for the location.

---