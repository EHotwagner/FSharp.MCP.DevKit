# SerializationErrorCallback Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.SerializationErrorCallback`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`

Handles  serialization error callback events.

## Methods

### Invoke

**Signature:** `Void Invoke(System.Object, System.Runtime.Serialization.StreamingContext, Newtonsoft.Json.Serialization.ErrorContext)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `context` | `StreamingContext` | No | `` |  |
| `errorContext` | `ErrorContext` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(System.Object, System.Runtime.Serialization.StreamingContext, Newtonsoft.Json.Serialization.ErrorContext, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `context` | `StreamingContext` | No | `` |  |
| `errorContext` | `ErrorContext` | No | `` |  |
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