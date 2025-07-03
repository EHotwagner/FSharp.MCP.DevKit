# JsonContract Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.JsonContract`

Contract details for a  used by the .

## Methods

### get_UnderlyingType

**Signature:** `System.Type get_UnderlyingType()`
**Return Type:** `Type`

---

### get_CreatedType

**Signature:** `System.Type get_CreatedType()`
**Return Type:** `Type`

---

### set_CreatedType

**Signature:** `Void set_CreatedType(System.Type)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Type` | No | `` |  |

---

### get_IsReference

**Signature:** `System.Nullable`1[System.Boolean] get_IsReference()`
**Return Type:** `Nullable`1`

---

### set_IsReference

**Signature:** `Void set_IsReference(System.Nullable`1[System.Boolean])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_Converter

**Signature:** `Newtonsoft.Json.JsonConverter get_Converter()`
**Return Type:** `JsonConverter`

---

### set_Converter

**Signature:** `Void set_Converter(Newtonsoft.Json.JsonConverter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JsonConverter` | No | `` |  |

---

### get_InternalConverter

**Signature:** `Newtonsoft.Json.JsonConverter get_InternalConverter()`
**Return Type:** `JsonConverter`

---

### get_OnDeserializedCallbacks

**Signature:** `System.Collections.Generic.IList`1[Newtonsoft.Json.Serialization.SerializationCallback] get_OnDeserializedCallbacks()`
**Return Type:** `IList`1`

---

### get_OnDeserializingCallbacks

**Signature:** `System.Collections.Generic.IList`1[Newtonsoft.Json.Serialization.SerializationCallback] get_OnDeserializingCallbacks()`
**Return Type:** `IList`1`

---

### get_OnSerializedCallbacks

**Signature:** `System.Collections.Generic.IList`1[Newtonsoft.Json.Serialization.SerializationCallback] get_OnSerializedCallbacks()`
**Return Type:** `IList`1`

---

### get_OnSerializingCallbacks

**Signature:** `System.Collections.Generic.IList`1[Newtonsoft.Json.Serialization.SerializationCallback] get_OnSerializingCallbacks()`
**Return Type:** `IList`1`

---

### get_OnErrorCallbacks

**Signature:** `System.Collections.Generic.IList`1[Newtonsoft.Json.Serialization.SerializationErrorCallback] get_OnErrorCallbacks()`
**Return Type:** `IList`1`

---

### get_DefaultCreator

**Signature:** `System.Func`1[System.Object] get_DefaultCreator()`
**Return Type:** `Func`1`

---

### set_DefaultCreator

**Signature:** `Void set_DefaultCreator(System.Func`1[System.Object])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Func`1` | No | `` |  |

---

### get_DefaultCreatorNonPublic

**Signature:** `Boolean get_DefaultCreatorNonPublic()`
**Return Type:** `Boolean`

---

### set_DefaultCreatorNonPublic

**Signature:** `Void set_DefaultCreatorNonPublic(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

## Properties

### UnderlyingType

**Type:** `Type` (read-only)

**Description:** Gets the underlying type for the contract.

---

### CreatedType

**Type:** `Type` (read/write)

**Description:** Gets or sets the type created during deserialization.

---

### IsReference

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets whether this type contract is serialized as a reference.

---

### Converter

**Type:** `JsonConverter` (read/write)

**Description:** Gets or sets the default  for this contract.

---

### InternalConverter

**Type:** `JsonConverter` (read/write)

---

### OnDeserializedCallbacks

**Type:** `IList`1` (read-only)

**Description:** Gets or sets all methods called immediately after deserialization of the object.

---

### OnDeserializingCallbacks

**Type:** `IList`1` (read-only)

**Description:** Gets or sets all methods called during deserialization of the object.

---

### OnSerializedCallbacks

**Type:** `IList`1` (read-only)

**Description:** Gets or sets all methods called after serialization of the object graph.

---

### OnSerializingCallbacks

**Type:** `IList`1` (read-only)

**Description:** Gets or sets all methods called before serialization of the object.

---

### OnErrorCallbacks

**Type:** `IList`1` (read-only)

**Description:** Gets or sets all method called when an error is thrown during the serialization of the object.

---

### DefaultCreator

**Type:** `Func`1` (read/write)

**Description:** Gets or sets the default creator method used to create the object.

---

### DefaultCreatorNonPublic

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether the default creator is non public.

---