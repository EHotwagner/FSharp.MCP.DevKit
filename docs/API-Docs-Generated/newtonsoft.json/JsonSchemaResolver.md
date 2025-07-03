# JsonSchemaResolver Class

**Namespace:** `Newtonsoft.Json.Schema`
**Full Name:** `Newtonsoft.Json.Schema.JsonSchemaResolver`

Resolves  from an id.
            
            JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.

## Methods

### get_LoadedSchemas

**Signature:** `System.Collections.Generic.IList`1[Newtonsoft.Json.Schema.JsonSchema] get_LoadedSchemas()`
**Return Type:** `IList`1`

---

### GetSchema

**Signature:** `Newtonsoft.Json.Schema.JsonSchema GetSchema(System.String)`
**Return Type:** `JsonSchema`

**Description:** Gets a  for the specified reference.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reference` | `String` | No | `` | The id. |

**Returns:** A  for the specified reference.

---

## Properties

### LoadedSchemas

**Type:** `IList`1` (read/write)

**Description:** Gets or sets the loaded schemas.

---