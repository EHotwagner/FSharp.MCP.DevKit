# JTokenReader Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JTokenReader`
- **Base Type:** `Newtonsoft.Json.JsonReader`
- **Implements:** `System.IAsyncDisposable`, `System.IDisposable`, `Newtonsoft.Json.IJsonLineInfo`

Represents a reader that provides fast, non-cached, forward-only access to serialized JSON data.

## Methods

### get_CurrentToken

**Signature:** `Newtonsoft.Json.Linq.JToken get_CurrentToken()`
**Return Type:** `JToken`

---

### Read

**Signature:** `Boolean Read()`
**Return Type:** `Boolean`

**Description:** Reads the next JSON token from the stream.

**Returns:** true if the next token was read successfully; false if there are no more tokens to read.

---

### get_Path

**Signature:** `System.String get_Path()`
**Return Type:** `String`

---

## Properties

### CurrentToken

**Type:** `JToken` (read-only)

**Description:** Gets the  at the reader's current position.

---

### Path

**Type:** `String` (read-only)

**Description:** Gets the path of the current JSON token.

---