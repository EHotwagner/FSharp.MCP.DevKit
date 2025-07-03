# ObjectConstructor`1 Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ObjectConstructor`1`
- **Base Type:** `System.MulticastDelegate`
- **Implements:** `System.ICloneable`, `System.Runtime.Serialization.ISerializable`
- **Generic Parameters:** `<T>`

Represents a method that constructs an object.

## Methods

### Invoke

**Signature:** `System.Object Invoke(System.Object[])`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `Object[]` | No | `` |  |

---

### BeginInvoke

**Signature:** `System.IAsyncResult BeginInvoke(System.Object[], System.AsyncCallback, System.Object)`
**Return Type:** `IAsyncResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `Object[]` | No | `` |  |
| `callback` | `AsyncCallback` | No | `` |  |
| `object` | `Object` | No | `` |  |

---

### EndInvoke

**Signature:** `System.Object EndInvoke(System.IAsyncResult)`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `IAsyncResult` | No | `` |  |

---