# JValue Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JValue`
- **Base Type:** `Newtonsoft.Json.Linq.JToken`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`, `System.IEquatable`1[[Newtonsoft.Json.Linq.JValue, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.IFormattable`, `System.IComparable`, `System.IComparable`1[[Newtonsoft.Json.Linq.JValue, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.IConvertible`

Represents a value in JSON (string, integer, date, etc).

## Methods

### WriteToAsync

**Signature:** `System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter, System.Threading.CancellationToken, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` |  |
| `cancellationToken` | `CancellationToken` | No | `` |  |
| `converters` | `JsonConverter[]` | No | `` |  |

---

### get_HasValues

**Signature:** `Boolean get_HasValues()`
**Return Type:** `Boolean`

---

### CreateComment (static)

**Signature:** `Newtonsoft.Json.Linq.JValue CreateComment(System.String)`
**Return Type:** `JValue`

**Description:** Creates a  comment with the given value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The value. |

**Returns:** A  comment with the given value.

---

### CreateString (static)

**Signature:** `Newtonsoft.Json.Linq.JValue CreateString(System.String)`
**Return Type:** `JValue`

**Description:** Creates a  string with the given value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The value. |

**Returns:** A  string with the given value.

---

### CreateNull (static)

**Signature:** `Newtonsoft.Json.Linq.JValue CreateNull()`
**Return Type:** `JValue`

**Description:** Creates a  null value.

**Returns:** A  null value.

---

### CreateUndefined (static)

**Signature:** `Newtonsoft.Json.Linq.JValue CreateUndefined()`
**Return Type:** `JValue`

**Description:** Creates a  undefined value.

**Returns:** A  undefined value.

---

### get_Type

**Signature:** `Newtonsoft.Json.Linq.JTokenType get_Type()`
**Return Type:** `JTokenType`

---

### get_Value

**Signature:** `System.Object get_Value()`
**Return Type:** `Object`

---

### set_Value

**Signature:** `Void set_Value(System.Object)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |

---

### WriteTo

**Signature:** `Void WriteTo(Newtonsoft.Json.JsonWriter, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `Void`

**Description:** Writes this token to a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` | A  into which this method will write. |
| `converters` | `JsonConverter[]` | No | `` | A collection of  which will be used when writing the token. |

---

### Equals

**Signature:** `Boolean Equals(Newtonsoft.Json.Linq.JValue)`
**Return Type:** `Boolean`

**Description:** Indicates whether the current object is equal to another object of the same type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `other` | `JValue` | No | `` | An object to compare with this object. |

**Returns:** true if the current object is equal to the  parameter; otherwise, false.

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Description:** Determines whether the specified  is equal to the current .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` | The  to compare with the current . |

**Returns:** true if the specified  is equal to the current ; otherwise, false.

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

**Description:** Serves as a hash function for a particular type.

**Returns:** A hash code for the current .

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

**Description:** Returns a  that represents this instance.

**Returns:** A  that represents this instance.

---

### ToString

**Signature:** `System.String ToString(System.String)`
**Return Type:** `String`

**Description:** Returns a  that represents this instance.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `String` | No | `` | The format. |

**Returns:** A  that represents this instance.

---

### ToString

**Signature:** `System.String ToString(System.IFormatProvider)`
**Return Type:** `String`

**Description:** Returns a  that represents this instance.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatProvider` | `IFormatProvider` | No | `` | The format provider. |

**Returns:** A  that represents this instance.

---

### ToString

**Signature:** `System.String ToString(System.String, System.IFormatProvider)`
**Return Type:** `String`

**Description:** Returns a  that represents this instance.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `String` | No | `` | The format. |
| `formatProvider` | `IFormatProvider` | No | `` | The format provider. |

**Returns:** A  that represents this instance.

---

### CompareTo

**Signature:** `Int32 CompareTo(Newtonsoft.Json.Linq.JValue)`
**Return Type:** `Int32`

**Description:** Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `JValue` | No | `` | An object to compare with this instance. |

**Returns:** A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has these meanings:
            Value
            Meaning
            Less than zero
            This instance is less than .
            Zero
            This instance is equal to .
            Greater than zero
            This instance is greater than .

---

## Properties

### HasValues

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether this token has child tokens.

---

### Type

**Type:** `JTokenType` (read-only)

**Description:** Gets the node type for this .

---

### Value

**Type:** `Object` (read/write)

**Description:** Gets or sets the underlying token value.

---