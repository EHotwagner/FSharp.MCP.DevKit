# ExtensionDataGetter Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ExtensionDataGetter`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`

Gets extension data for an object during serialization.

## Methods

### Invoke

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.Object,System.Object]] Invoke(System.Object)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(System.Object, System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` |  |
| `callback` | `AsyncCallback` | No | `` |  |
| `object` | `Object` | No | `` |  |

---

### EndInvoke

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Collections.Generic.KeyValuePair`2[System.Object,System.Object]] EndInvoke(System.IAsyncResult)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IAsyncResult` | No | `` |  |

---