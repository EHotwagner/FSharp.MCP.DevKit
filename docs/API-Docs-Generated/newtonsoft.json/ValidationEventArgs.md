# ValidationEventArgs Class

**Namespace:** `Newtonsoft.Json.Schema`
**Full Name:** `Newtonsoft.Json.Schema.ValidationEventArgs`
- **Base Type:** `System.EventArgs`

Returns detailed information related to the .
            
            JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.

## Methods

### get_Exception

**Signature:** `Newtonsoft.Json.Schema.JsonSchemaException get_Exception()`
**Return Type:** `JsonSchemaException`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

### get_Message

**Signature:** `System.String get_Message()`
**Return Type:** `String`

---

## Properties

### Exception

**Type:** `JsonSchemaException` (read-only)

**Description:** Gets the  associated with the validation error.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the JSON location where the validation error occurred.

---

### Message

**Type:** `String` (read-only)

**Description:** Gets the text description corresponding to the validation error.

---