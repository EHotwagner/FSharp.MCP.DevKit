# UnionCaseInfo Class

**Namespace:** `Microsoft.FSharp.Reflection`
**Full Name:** `Microsoft.FSharp.Reflection.UnionCaseInfo`

Represents a case of a discriminated union type

## Methods

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### get_DeclaringType

**Signature:** `System.Type get_DeclaringType()`
**Return Type:** `Type`

---

### GetFields

**Signature:** `System.Reflection.PropertyInfo[] GetFields()`
**Return Type:** `PropertyInfo[]`

**Description:** The fields associated with the case, represented by a PropertyInfo.

**Returns:** The fields associated with the case.

---

### GetCustomAttributes

**Signature:** `System.Object[] GetCustomAttributes()`
**Return Type:** `Object[]`

**Description:** Returns the custom attributes associated with the case.

**Returns:** An array of custom attributes.

---

### GetCustomAttributes

**Signature:** `System.Object[] GetCustomAttributes(System.Type)`
**Return Type:** `Object[]`

**Description:** Returns the custom attributes associated with the case matching the given attribute type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `attributeType` | `Type` | No | `` | The type of attributes to return. |

**Returns:** An array of custom attributes.

---

### GetCustomAttributesData

**Signature:** `System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()`
**Return Type:** `IList`1`

**Description:** Returns the custom attributes data associated with the case.

**Returns:** An list of custom attribute data items.

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

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

**Description:** The name of the case.

---

### DeclaringType

**Type:** `Type` (read-only)

**Description:** The type in which the case occurs.

---

### Tag

**Type:** `Int32` (read-only)

**Description:** The integer tag for the case.

---