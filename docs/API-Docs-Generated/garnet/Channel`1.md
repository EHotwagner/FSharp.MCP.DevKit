# Channel`1 Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Channel`1`
- **Implements:** `Garnet.Composition.IChannel`, ``
- **Generic Parameters:** `<a>`

## Methods

### Clear

**Signature:** `Void Clear()`
**Return Type:** `Void`

---

### SetPublisher

**Signature:** `Void SetPublisher(Microsoft.FSharp.Core.FSharpValueOption`1[Garnet.Composition.IPublisher])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newPublisher` | `FSharpValueOption`1` | No | `` |  |

---

### PublishAll

**Signature:** `Void PublishAll(System.ReadOnlyMemory`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `batch` | `ReadOnlyMemory`1` | No | `` |  |

---

### Publish

**Signature:** `Void Publish(a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `event` | `a` | No | `` |  |

---

### Send

**Signature:** `Void Send(a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `event` | `a` | No | `` |  |

---

### SendAll

**Signature:** `Void SendAll(System.ReadOnlyMemory`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `events` | `ReadOnlyMemory`1` | No | `` |  |

---

### Advance

**Signature:** `Void Advance(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |

---

### GetMemory

**Signature:** `System.Memory`1[a] GetMemory(Int32)`
**Return Type:** `Memory`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sizeHint` | `Int32` | No | `` |  |

---

### GetSpan

**Signature:** `System.Span`1[a] GetSpan(Int32)`
**Return Type:** `Span`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sizeHint` | `Int32` | No | `` |  |

---

### OnAll

**Signature:** `System.IDisposable OnAll(Microsoft.FSharp.Core.FSharpFunc`2[System.ReadOnlyMemory`1[a],Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `handler` | `FSharpFunc`2` | No | `` |  |

---

### Publish

**Signature:** `Boolean Publish()`
**Return Type:** `Boolean`

---

### Commit

**Signature:** `Void Commit()`
**Return Type:** `Void`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---