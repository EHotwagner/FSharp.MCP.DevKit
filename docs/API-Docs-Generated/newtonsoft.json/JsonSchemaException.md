# JsonSchemaException Class

**Namespace:** `Newtonsoft.Json.Schema`
**Full Name:** `Newtonsoft.Json.Schema.JsonSchemaException`
- **Base Type:** `Newtonsoft.Json.JsonException`
- **Implements:** `System.Runtime.Serialization.ISerializable`

Returns detailed information about the schema exception.
            
            JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.

## Methods

### get_LineNumber

**Signature:** `Int32 get_LineNumber()`
**Return Type:** `Int32`

---

### get_LinePosition

**Signature:** `Int32 get_LinePosition()`
**Return Type:** `Int32`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

## Properties

### LineNumber

**Type:** `Int32` (read-only)

**Description:** Gets the line number indicating where the error occurred.

---

### LinePosition

**Type:** `Int32` (read-only)

**Description:** Gets the line position indicating where the error occurred.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path to the JSON where the error occurred.

---