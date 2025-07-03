# FSharpVar Class

**Namespace:** `Microsoft.FSharp.Quotations`
**Full Name:** `Microsoft.FSharp.Quotations.FSharpVar`
- **Implements:** `System.IComparable`

Information at the binding site of a variable

## Methods

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### get_IsMutable

**Signature:** `Boolean get_IsMutable()`
**Return Type:** `Boolean`

---

### get_Type

**Signature:** `System.Type get_Type()`
**Return Type:** `Type`

---

### Global (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpVar Global(System.String, System.Type)`
**Return Type:** `FSharpVar`

**Description:** Fetches or create a new variable with the given name and type from a global pool of shared variables
 indexed by name and type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the variable. |
| `typ` | `Type` | No | `` | The type associated with the variable. |

**Returns:** The retrieved or created variable.

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

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

### Name

**Type:** `String` (read-only)

**Description:** The declared name of the variable

---

### IsMutable

**Type:** `Boolean` (read-only)

**Description:** Indicates if the variable represents a mutable storage location

---

### Type

**Type:** `Type` (read-only)

**Description:** The type associated with the variable

---