# CustomCreationConverter`1 Class

**Namespace:** `Newtonsoft.Json.Converters`
**Full Name:** `Newtonsoft.Json.Converters.CustomCreationConverter`1`
- **Base Type:** `Newtonsoft.Json.JsonConverter`
- **Generic Parameters:** `<T>`

Create a custom object

## Methods

### WriteJson

**Signature:** `Void WriteJson(Newtonsoft.Json.JsonWriter, System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Void`

**Description:** Writes the JSON representation of the object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` | The  to write to. |
| `value` | `Object` | No | `` | The value. |
| `serializer` | `JsonSerializer` | No | `` | The calling serializer. |

---

### ReadJson

**Signature:** `System.Object ReadJson(Newtonsoft.Json.JsonReader, System.Type, System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `Object`

**Description:** Reads the JSON representation of the object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  to read from. |
| `objectType` | `Type` | No | `` | Type of the object. |
| `existingValue` | `Object` | No | `` | The existing value of object being read. |
| `serializer` | `JsonSerializer` | No | `` | The calling serializer. |

**Returns:** The object value.

---

### Create

**Signature:** `T Create(System.Type)`
**Return Type:** `T`

**Description:** Creates an object which will then be populated by the serializer.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `objectType` | `Type` | No | `` | Type of the object. |

**Returns:** The created object.

---

### CanConvert

**Signature:** `Boolean CanConvert(System.Type)`
**Return Type:** `Boolean`

**Description:** Determines whether this instance can convert the specified object type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `objectType` | `Type` | No | `` | Type of the object. |

**Returns:** true if this instance can convert the specified object type; otherwise, false.

---

### get_CanWrite

**Signature:** `Boolean get_CanWrite()`
**Return Type:** `Boolean`

---

## Properties

### CanWrite

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether this  can write JSON.

---