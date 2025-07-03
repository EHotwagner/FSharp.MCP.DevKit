# JToken Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JToken`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`

Represents an abstract JSON token.

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

### WriteToAsync

**Signature:** `System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` |  |
| `converters` | `JsonConverter[]` | No | `` |  |

---

### ReadFromAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JToken] ReadFromAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### ReadFromAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JToken] ReadFromAsync(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `settings` | `JsonLoadSettings` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### LoadAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JToken] LoadAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### LoadAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JToken] LoadAsync(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `settings` | `JsonLoadSettings` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### get_EqualityComparer (static)

**Signature:** `Newtonsoft.Json.Linq.JTokenEqualityComparer get_EqualityComparer()`
**Return Type:** `JTokenEqualityComparer`

---

### get_Parent

**Signature:** `Newtonsoft.Json.Linq.JContainer get_Parent()`
**Return Type:** `JContainer`

---

### get_Root

**Signature:** `Newtonsoft.Json.Linq.JToken get_Root()`
**Return Type:** `JToken`

---

### get_Type

**Signature:** `Newtonsoft.Json.Linq.JTokenType get_Type()`
**Return Type:** `JTokenType`

---

### get_HasValues

**Signature:** `Boolean get_HasValues()`
**Return Type:** `Boolean`

---

### DeepEquals (static)

**Signature:** `Boolean DeepEquals(Newtonsoft.Json.Linq.JToken, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Boolean`

**Description:** Compares the values of two tokens, including the values of all descendant tokens.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `t1` | `JToken` | No | `` | The first  to compare. |
| `t2` | `JToken` | No | `` | The second  to compare. |

**Returns:** true if the tokens are equal; otherwise false.

---

### get_Next

**Signature:** `Newtonsoft.Json.Linq.JToken get_Next()`
**Return Type:** `JToken`

---

### get_Previous

**Signature:** `Newtonsoft.Json.Linq.JToken get_Previous()`
**Return Type:** `JToken`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

### AddAfterSelf

**Signature:** `Void AddAfterSelf(System.Object)`
**Return Type:** `Void`

**Description:** Adds the specified content immediately after this token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | A content object that contains simple content or a collection of content objects to be added after this token. |

---

### AddBeforeSelf

**Signature:** `Void AddBeforeSelf(System.Object)`
**Return Type:** `Void`

**Description:** Adds the specified content immediately before this token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | A content object that contains simple content or a collection of content objects to be added before this token. |

---

### Ancestors

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] Ancestors()`
**Return Type:** `IEnumerable`1`

**Description:** Returns a collection of the ancestor tokens of this token.

**Returns:** A collection of the ancestor tokens of this token.

---

### AncestorsAndSelf

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] AncestorsAndSelf()`
**Return Type:** `IEnumerable`1`

**Description:** Returns a collection of tokens that contain this token, and the ancestors of this token.

**Returns:** A collection of tokens that contain this token, and the ancestors of this token.

---

### AfterSelf

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] AfterSelf()`
**Return Type:** `IEnumerable`1`

**Description:** Returns a collection of the sibling tokens after this token, in document order.

**Returns:** A collection of the sibling tokens after this tokens, in document order.

---

### BeforeSelf

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] BeforeSelf()`
**Return Type:** `IEnumerable`1`

**Description:** Returns a collection of the sibling tokens before this token, in document order.

**Returns:** A collection of the sibling tokens before this token, in document order.

---

### get_Item

**Signature:** `Newtonsoft.Json.Linq.JToken get_Item(System.Object)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `Object` | No | `` |  |

---

### set_Item

**Signature:** `Void set_Item(System.Object, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `Object` | No | `` |  |
| `value` | `JToken` | No | `` |  |

---

### Value (generic)

**Signature:** `T Value[T](System.Object)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `Object` | No | `` |  |

---

### get_First

**Signature:** `Newtonsoft.Json.Linq.JToken get_First()`
**Return Type:** `JToken`

---

### get_Last

**Signature:** `Newtonsoft.Json.Linq.JToken get_Last()`
**Return Type:** `JToken`

---

### Children

**Signature:** `Newtonsoft.Json.Linq.JEnumerable`1[Newtonsoft.Json.Linq.JToken] Children()`
**Return Type:** `JEnumerable`1`

**Description:** Returns a collection of the child tokens of this token, in document order.

**Returns:** An  of  containing the child tokens of this , in document order.

---

### Children (generic)

**Signature:** `Newtonsoft.Json.Linq.JEnumerable`1[T] Children[T]()`
**Return Type:** `JEnumerable`1`

**Description:** Returns a collection of the child tokens of this token, in document order.

**Returns:** An  of  containing the child tokens of this , in document order.

---

### Values (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] Values[T]()`
**Return Type:** `IEnumerable`1`

---

### Remove

**Signature:** `Void Remove()`
**Return Type:** `Void`

**Description:** Removes this token from its parent.

---

### Replace

**Signature:** `Void Replace(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Description:** Replaces this token with the specified token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` | The value. |

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

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

**Description:** Returns the indented JSON for this token.

**Returns:** The indented JSON for this token.

---

### ToString

**Signature:** `System.String ToString(Newtonsoft.Json.Formatting, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `String`

**Description:** Returns the JSON for this token using the given formatting and converters.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |
| `converters` | `JsonConverter[]` | No | `` | A collection of  which will be used when writing the token. |

**Returns:** The JSON for this token using the given formatting and converters.

---

### op_Explicit (static)

**Signature:** `Boolean op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.DateTimeOffset op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `DateTimeOffset`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Boolean] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Int64 op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Int64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.DateTime] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.DateTimeOffset] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Decimal] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Double] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Char] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Int32 op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Int16 op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Int16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `UInt16 op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `UInt16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Char op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Byte op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Byte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `SByte op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `SByte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Int32] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Int16] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.UInt16] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Byte] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.SByte] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.DateTime op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `DateTime`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Int64] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Single] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Decimal op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Decimal`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.UInt32] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.UInt64] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Double op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Double`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Single op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Single`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.String op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `UInt32 op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `UInt32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `UInt64 op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `UInt64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `Byte[] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Byte[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Guid op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Guid`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.Guid] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.TimeSpan op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `TimeSpan`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Nullable`1[System.TimeSpan] op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Explicit (static)

**Signature:** `System.Uri op_Explicit(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Uri`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JToken` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Boolean)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.DateTimeOffset)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeOffset` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Byte)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Byte])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(SByte)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `SByte` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.SByte])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Boolean])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Int64)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int64` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.DateTime])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.DateTimeOffset])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Decimal])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Double])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Int16)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int16` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(UInt16)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt16` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Int32)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Int32])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.DateTime)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTime` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Int64])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Single])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Decimal)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Decimal` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Int16])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.UInt16])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.UInt32])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.UInt64])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Double)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Double` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Single)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Single` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.String)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(UInt32)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt32` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(UInt64)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt64` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(Byte[])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte[]` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Uri)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Uri` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.TimeSpan)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TimeSpan` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.TimeSpan])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Guid)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Guid` | No | `` |  |

---

### op_Implicit (static)

**Signature:** `Newtonsoft.Json.Linq.JToken op_Implicit(System.Nullable`1[System.Guid])`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### CreateReader

**Signature:** `Newtonsoft.Json.JsonReader CreateReader()`
**Return Type:** `JsonReader`

**Description:** Creates an  for this token.

**Returns:** An  that can be used to read this token and its descendants.

---

### FromObject (static)

**Signature:** `Newtonsoft.Json.Linq.JToken FromObject(System.Object)`
**Return Type:** `JToken`

**Description:** Creates a  from an object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` | The object that will be used to create . |

**Returns:** A  with the value of the specified object

---

### FromObject (static)

**Signature:** `Newtonsoft.Json.Linq.JToken FromObject(System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `JToken`

**Description:** Creates a  from an object using the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` | The object that will be used to create . |
| `jsonSerializer` | `JsonSerializer` | No | `` | The  that will be used when reading the object. |

**Returns:** A  with the value of the specified object

---

### ToObject (generic)

**Signature:** `T ToObject[T]()`
**Return Type:** `T`

---

### ToObject

**Signature:** `System.Object ToObject(System.Type)`
**Return Type:** `Object`

**Description:** Creates the specified .NET type from the .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `objectType` | `Type` | No | `` | The object type that the token will be deserialized to. |

**Returns:** The new object created from the JSON value.

---

### ToObject (generic)

**Signature:** `T ToObject[T](Newtonsoft.Json.JsonSerializer)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `jsonSerializer` | `JsonSerializer` | No | `` |  |

---

### ToObject

**Signature:** `System.Object ToObject(System.Type, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Object`

**Description:** Creates the specified .NET type from the  using the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `objectType` | `Type` | No | `` | The object type that the token will be deserialized to. |
| `jsonSerializer` | `JsonSerializer` | No | `` | The  that will be used when creating the object. |

**Returns:** The new object created from the JSON value.

---

### ReadFrom (static)

**Signature:** `Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader)`
**Return Type:** `JToken`

**Description:** Creates a  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | An  positioned at the token to read into this . |

**Returns:** An  that contains the token and its descendant tokens
            that were read from the reader. The runtime type of the token is determined
            by the token type of the first token encountered in the reader.

---

### ReadFrom (static)

**Signature:** `Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JToken`

**Description:** Creates a  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | An  positioned at the token to read into this . |
| `settings` | `JsonLoadSettings` | No | `` | The  used to load the JSON.
            If this is null, default load settings will be used. |

**Returns:** An  that contains the token and its descendant tokens
            that were read from the reader. The runtime type of the token is determined
            by the token type of the first token encountered in the reader.

---

### Parse (static)

**Signature:** `Newtonsoft.Json.Linq.JToken Parse(System.String)`
**Return Type:** `JToken`

**Description:** Load a  from a string that contains JSON.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | A  that contains JSON. |

**Returns:** A  populated from the string that contains JSON.

---

### Parse (static)

**Signature:** `Newtonsoft.Json.Linq.JToken Parse(System.String, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JToken`

**Description:** Load a  from a string that contains JSON.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | A  that contains JSON. |
| `settings` | `JsonLoadSettings` | No | `` | The  used to load the JSON.
            If this is null, default load settings will be used. |

**Returns:** A  populated from the string that contains JSON.

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JToken`

**Description:** Creates a  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | An  positioned at the token to read into this . |
| `settings` | `JsonLoadSettings` | No | `` | The  used to load the JSON.
            If this is null, default load settings will be used. |

**Returns:** An  that contains the token and its descendant tokens
            that were read from the reader. The runtime type of the token is determined
            by the token type of the first token encountered in the reader.

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader)`
**Return Type:** `JToken`

**Description:** Creates a  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | An  positioned at the token to read into this . |

**Returns:** An  that contains the token and its descendant tokens
            that were read from the reader. The runtime type of the token is determined
            by the token type of the first token encountered in the reader.

---

### SelectToken

**Signature:** `Newtonsoft.Json.Linq.JToken SelectToken(System.String)`
**Return Type:** `JToken`

**Description:** Selects a  using a JPath expression. Selects the token that matches the object path.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | A  that contains a JPath expression. |

**Returns:** A , or null.

---

### SelectToken

**Signature:** `Newtonsoft.Json.Linq.JToken SelectToken(System.String, Boolean)`
**Return Type:** `JToken`

**Description:** Selects a  using a JPath expression. Selects the token that matches the object path.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | A  that contains a JPath expression. |
| `errorWhenNoMatch` | `Boolean` | No | `` | A flag to indicate whether an error should be thrown if no tokens are found when evaluating part of the expression. |

**Returns:** A .

---

### SelectToken

**Signature:** `Newtonsoft.Json.Linq.JToken SelectToken(System.String, Newtonsoft.Json.Linq.JsonSelectSettings)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` |  |
| `settings` | `JsonSelectSettings` | No | `` |  |

---

### SelectTokens

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] SelectTokens(System.String)`
**Return Type:** `IEnumerable`1`

**Description:** Selects a collection of elements using a JPath expression.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | A  that contains a JPath expression. |

**Returns:** An  that contains the selected elements.

---

### SelectTokens

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] SelectTokens(System.String, Boolean)`
**Return Type:** `IEnumerable`1`

**Description:** Selects a collection of elements using a JPath expression.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | A  that contains a JPath expression. |
| `errorWhenNoMatch` | `Boolean` | No | `` | A flag to indicate whether an error should be thrown if no tokens are found when evaluating part of the expression. |

**Returns:** An  that contains the selected elements.

---

### SelectTokens

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] SelectTokens(System.String, Newtonsoft.Json.Linq.JsonSelectSettings)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` |  |
| `settings` | `JsonSelectSettings` | No | `` |  |

---

### DeepClone

**Signature:** `Newtonsoft.Json.Linq.JToken DeepClone()`
**Return Type:** `JToken`

**Description:** Creates a new instance of the . All child tokens are recursively cloned.

**Returns:** A new instance of the .

---

### DeepClone

**Signature:** `Newtonsoft.Json.Linq.JToken DeepClone(Newtonsoft.Json.Linq.JsonCloneSettings)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `settings` | `JsonCloneSettings` | No | `` |  |

---

### AddAnnotation

**Signature:** `Void AddAnnotation(System.Object)`
**Return Type:** `Void`

**Description:** Adds an object to the annotation list of this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `annotation` | `Object` | No | `` | The annotation to add. |

---

### Annotation (generic)

**Signature:** `T Annotation[T]()`
**Return Type:** `T`

---

### Annotation

**Signature:** `System.Object Annotation(System.Type)`
**Return Type:** `Object`

**Description:** Gets the first annotation object of the specified type from this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The  of the annotation to retrieve. |

**Returns:** The first annotation object that matches the specified type, or null if no annotation is of the specified type.

---

### Annotations (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] Annotations[T]()`
**Return Type:** `IEnumerable`1`

---

### Annotations

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Object] Annotations(System.Type)`
**Return Type:** `IEnumerable`1`

**Description:** Gets a collection of annotations of the specified type for this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The  of the annotations to retrieve. |

**Returns:** An  of  that contains the annotations that match the specified type for this .

---

### RemoveAnnotations (generic)

**Signature:** `Void RemoveAnnotations[T]()`
**Return Type:** `Void`

---

### RemoveAnnotations

**Signature:** `Void RemoveAnnotations(System.Type)`
**Return Type:** `Void`

**Description:** Removes the annotations of the specified type from this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The  of annotations to remove. |

---

## Properties

### EqualityComparer (static)

**Type:** `JTokenEqualityComparer` (read-only)

**Description:** Gets a comparer that can compare two tokens for value equality.

---

### Parent

**Type:** `JContainer` (read/write)

**Description:** Gets or sets the parent.

---

### Root

**Type:** `JToken` (read-only)

**Description:** Gets the root  of this .

---

### Type

**Type:** `JTokenType` (read-only)

**Description:** Gets the node type for this .

---

### HasValues

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether this token has child tokens.

---

### Next

**Type:** `JToken` (read/write)

**Description:** Gets the next sibling token of this node.

---

### Previous

**Type:** `JToken` (read/write)

**Description:** Gets the previous sibling token of this node.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the JSON token.

---

### Item

**Type:** `JToken` (read/write)

---

### First

**Type:** `JToken` (read-only)

**Description:** Get the first child token of this token.

---

### Last

**Type:** `JToken` (read-only)

**Description:** Get the last child token of this token.

---