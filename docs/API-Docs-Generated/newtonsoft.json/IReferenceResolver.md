# IReferenceResolver Interface

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.IReferenceResolver`

Used to resolve references when serializing and deserializing JSON by the .

## Methods

### ResolveReference

**Signature:** `System.Object ResolveReference(System.Object, System.String)`
**Return Type:** `Object`

**Description:** Resolves a reference to its object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `context` | `Object` | No | `` | The serialization context. |
| `reference` | `String` | No | `` | The reference to resolve. |

**Returns:** The object that

---

### GetReference

**Signature:** `System.String GetReference(System.Object, System.Object)`
**Return Type:** `String`

**Description:** Gets the reference for the sepecified object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `context` | `Object` | No | `` | The serialization context. |
| `value` | `Object` | No | `` | The object to get a reference for. |

**Returns:** The reference to the object.

---

### IsReferenced

**Signature:** `Boolean IsReferenced(System.Object, System.Object)`
**Return Type:** `Boolean`

**Description:** Determines whether the specified object is referenced.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `context` | `Object` | No | `` | The serialization context. |
| `value` | `Object` | No | `` | The object to test for a reference. |

**Returns:** true if the specified object is referenced; otherwise, false.

---

### AddReference

**Signature:** `Void AddReference(System.Object, System.String, System.Object)`
**Return Type:** `Void`

**Description:** Adds a reference to the specified object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `context` | `Object` | No | `` | The serialization context. |
| `reference` | `String` | No | `` | The reference. |
| `value` | `Object` | No | `` | The object to reference. |

---