# JTokenEqualityComparer Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JTokenEqualityComparer`
- **Implements:** `System.Collections.Generic.IEqualityComparer`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`

Compares tokens to determine whether they are equal.

## Methods

### Equals

**Signature:** `Boolean Equals(Newtonsoft.Json.Linq.JToken, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Boolean`

**Description:** Determines whether the specified objects are equal.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `JToken` | No | `` | The first object of type  to compare. |
| `y` | `JToken` | No | `` | The second object of type  to compare. |

**Returns:** true if the specified objects are equal; otherwise, false.

---

### GetHashCode

**Signature:** `Int32 GetHashCode(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Int32`

**Description:** Returns a hash code for the specified object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `JToken` | No | `` | The  for which a hash code is to be returned. |

**Returns:** A hash code for the specified object.

---