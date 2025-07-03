# SerializationCallback Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.SerializationCallback`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`

Handles  serialization callback events.

## Methods

### Invoke

**Signature:** `Void Invoke(System.Object, System.Runtime.Serialization.StreamingContext)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `context` | `StreamingContext` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(System.Object, System.Runtime.Serialization.StreamingContext, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `context` | `StreamingContext` | No | `` |  |
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