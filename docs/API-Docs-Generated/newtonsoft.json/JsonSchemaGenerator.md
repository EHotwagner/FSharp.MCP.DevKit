# JsonSchemaGenerator Class

**Namespace:** `Newtonsoft.Json.Schema`
**Full Name:** `Newtonsoft.Json.Schema.JsonSchemaGenerator`

Generates a  from a specified .
            
            JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.

## Methods

### get_UndefinedSchemaIdHandling

**Signature:** `Newtonsoft.Json.Schema.UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling()`
**Return Type:** `UndefinedSchemaIdHandling`

---

### set_UndefinedSchemaIdHandling

**Signature:** `Void set_UndefinedSchemaIdHandling(Newtonsoft.Json.Schema.UndefinedSchemaIdHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UndefinedSchemaIdHandling` | No | `` |  |

---

### get_ContractResolver

**Signature:** `Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver()`
**Return Type:** `IContractResolver`

---

### set_ContractResolver

**Signature:** `Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `IContractResolver` | No | `` |  |

---

### Generate

**Signature:** `Newtonsoft.Json.Schema.JsonSchema Generate(System.Type)`
**Return Type:** `JsonSchema`

**Description:** Generate a  from the specified type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The type to generate a  from. |

**Returns:** A  generated from the specified type.

---

### Generate

**Signature:** `Newtonsoft.Json.Schema.JsonSchema Generate(System.Type, Newtonsoft.Json.Schema.JsonSchemaResolver)`
**Return Type:** `JsonSchema`

**Description:** Generate a  from the specified type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The type to generate a  from. |
| `resolver` | `JsonSchemaResolver` | No | `` | The  used to resolve schema references. |

**Returns:** A  generated from the specified type.

---

### Generate

**Signature:** `Newtonsoft.Json.Schema.JsonSchema Generate(System.Type, Boolean)`
**Return Type:** `JsonSchema`

**Description:** Generate a  from the specified type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The type to generate a  from. |
| `rootSchemaNullable` | `Boolean` | No | `` | Specify whether the generated root  will be nullable. |

**Returns:** A  generated from the specified type.

---

### Generate

**Signature:** `Newtonsoft.Json.Schema.JsonSchema Generate(System.Type, Newtonsoft.Json.Schema.JsonSchemaResolver, Boolean)`
**Return Type:** `JsonSchema`

**Description:** Generate a  from the specified type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The type to generate a  from. |
| `resolver` | `JsonSchemaResolver` | No | `` | The  used to resolve schema references. |
| `rootSchemaNullable` | `Boolean` | No | `` | Specify whether the generated root  will be nullable. |

**Returns:** A  generated from the specified type.

---

## Properties

### UndefinedSchemaIdHandling

**Type:** `UndefinedSchemaIdHandling` (read/write)

**Description:** Gets or sets how undefined schemas are handled by the serializer.

---

### ContractResolver

**Type:** `IContractResolver` (read/write)

**Description:** Gets or sets the contract resolver.

---