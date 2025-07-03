# ValidationEventHandler Class

**Namespace:** `Newtonsoft.Json.Schema`
**Full Name:** `Newtonsoft.Json.Schema.ValidationEventHandler`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`

Represents the callback method that will handle JSON schema validation events and the .
            
            JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.

## Methods

### Invoke

**Signature:** `Void Invoke(System.Object, Newtonsoft.Json.Schema.ValidationEventArgs)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sender` | `Object` | No | `` |  |
| `e` | `ValidationEventArgs` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(System.Object, Newtonsoft.Json.Schema.ValidationEventArgs, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sender` | `Object` | No | `` |  |
| `e` | `ValidationEventArgs` | No | `` |  |
| `callback` | `AsyncCallback` | No | `` |  |
| `object` | `Object` | No | `` |  |

---

### EndInvoke

**Signature:** `Void EndInvoke(System.IAsyncResult)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IAsyncResult` | No | `` |  |

---