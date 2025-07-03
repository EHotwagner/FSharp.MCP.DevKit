# JsonValidatingReader Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonValidatingReader`
- **Base Type:** `Newtonsoft.Json.JsonReader`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`, `Newtonsoft.Json.IJsonLineInfo`

Represents a reader that provides  validation.
            
            JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.

## Methods

### add_ValidationEventHandler

**Signature:** `Void add_ValidationEventHandler(Newtonsoft.Json.Schema.ValidationEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ValidationEventHandler` | No | `` |  |

---

### remove_ValidationEventHandler

**Signature:** `Void remove_ValidationEventHandler(Newtonsoft.Json.Schema.ValidationEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ValidationEventHandler` | No | `` |  |

---

### get_Value

**Signature:** `System.Object get_Value()`
**Return Type:** `Object`

---

### get_Depth

**Signature:** `Int32 get_Depth()`
**Return Type:** `Int32`

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

### get_QuoteChar

**Signature:** `Char get_QuoteChar()`
**Return Type:** `Char`

---

### get_TokenType

**Signature:** `Newtonsoft.Json.JsonToken get_TokenType()`
**Return Type:** `JsonToken`

---

### get_ValueType

**Signature:** `System.Type get_ValueType()`
**Return Type:** `Type`

---

### get_Schema

**Signature:** `Newtonsoft.Json.Schema.JsonSchema get_Schema()`
**Return Type:** `JsonSchema`

---

### set_Schema

**Signature:** `Void set_Schema(Newtonsoft.Json.Schema.JsonSchema)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `JsonSchema` | No | `` |  |

---

### get_Reader

**Signature:** `Newtonsoft.Json.JsonReader get_Reader()`
**Return Type:** `JsonReader`

---

### Close

**Signature:** `Void Close()`
**Return Type:** `Void`

---

### ReadAsInt32

**Signature:** `System.Nullable`1[System.Int32] ReadAsInt32()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A .

---

### ReadAsBytes

**Signature:** `Byte[] ReadAsBytes()`
**Return Type:** `Byte[]`

**Description:** Reads the next JSON token from the stream as a [].

**Returns:** A [] or a null reference if the next JSON token is null.

---

### ReadAsDecimal

**Signature:** `System.Nullable`1[System.Decimal] ReadAsDecimal()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A .

---

### ReadAsDouble

**Signature:** `System.Nullable`1[System.Double] ReadAsDouble()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A .

---

### ReadAsBoolean

**Signature:** `System.Nullable`1[System.Boolean] ReadAsBoolean()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A .

---

### ReadAsString

**Signature:** `System.String ReadAsString()`
**Return Type:** `String`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsDateTime

**Signature:** `System.Nullable`1[System.DateTime] ReadAsDateTime()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A . This method will return null at the end of an array.

---

### ReadAsDateTimeOffset

**Signature:** `System.Nullable`1[System.DateTimeOffset] ReadAsDateTimeOffset()`
**Return Type:** `Nullable`1`

**Description:** Reads the next JSON token from the stream as a .

**Returns:** A .

---

### Read

**Signature:** `Boolean Read()`
**Return Type:** `Boolean`

**Description:** Reads the next JSON token from the stream.

**Returns:** true if the next token was read successfully; false if there are no more tokens to read.

---

## Properties

### Value

**Type:** `Object` (read-only)

**Description:** Gets the text value of the current JSON token.

---

### Depth

**Type:** `Int32` (read-only)

**Description:** Gets the depth of the current token in the JSON document.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the current JSON token.

---

### QuoteChar

**Type:** `Char` (read/write)

**Description:** Gets the quotation mark character used to enclose the value of a string.

---

### TokenType

**Type:** `JsonToken` (read-only)

**Description:** Gets the type of the current JSON token.

---

### ValueType

**Type:** `Type` (read-only)

**Description:** Gets the Common Language Runtime (CLR) type for the current JSON token.

---

### Schema

**Type:** `JsonSchema` (read/write)

**Description:** Gets or sets the schema.

---

### Reader

**Type:** `JsonReader` (read-only)

**Description:** Gets the  used to construct this .

---