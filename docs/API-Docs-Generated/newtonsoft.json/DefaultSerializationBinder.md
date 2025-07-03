# DefaultSerializationBinder Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.DefaultSerializationBinder`
- **Base Type:** `System.Runtime.Serialization.SerializationBinder`
- **Implements:** `Newtonsoft.Json.Serialization.ISerializationBinder`

The default serialization binder used when resolving and loading classes from type names.

## Methods

### BindToType

**Signature:** `System.Type BindToType(System.String, System.String)`
**Return Type:** `Type`

**Description:** When overridden in a derived class, controls the binding of a serialized object to a type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `assemblyName` | `String` | No | `` | Specifies the  name of the serialized object. |
| `typeName` | `String` | No | `` | Specifies the  name of the serialized object. |

**Returns:** The type of the object the formatter creates a new instance of.

---

### BindToName

**Signature:** `Void BindToName(System.Type, System.String ByRef, System.String ByRef)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `serializedType` | `Type` | No | `` |  |
| `assemblyName` | `String&` | No | `` |  |
| `typeName` | `String&` | No | `` |  |

---