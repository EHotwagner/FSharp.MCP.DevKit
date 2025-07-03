# ISerializationBinder Interface

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ISerializationBinder`

## Methods

### BindToType

**Signature:** `System.Type BindToType(System.String, System.String)`
**Return Type:** `Type`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `assemblyName` | `String` | No | `` |  |
| `typeName` | `String` | No | `` |  |

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