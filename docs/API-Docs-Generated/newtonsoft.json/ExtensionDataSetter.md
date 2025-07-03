# ExtensionDataSetter Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ExtensionDataSetter`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`

Sets extension data for an object during deserialization.

## Methods

### Invoke

**Signature:** `Void Invoke(System.Object, System.String, System.Object)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `key` | `String` | No | `` |  |
| `value` | `Object` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(System.Object, System.String, System.Object, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `key` | `String` | No | `` |  |
| `value` | `Object` | No | `` |  |
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