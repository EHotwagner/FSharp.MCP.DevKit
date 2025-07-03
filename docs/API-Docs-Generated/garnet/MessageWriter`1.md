# MessageWriter`1 Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.MessageWriter`1`
- **Implements:** ``, ``, `Garnet.Composition.IMessageWriter`, `System.IDisposable`
- **Generic Parameters:** `<a>`

## Methods

### get_Recipients

**Signature:** `System.Collections.Generic.List`1[Garnet.Composition.Destination] get_Recipients()`
**Return Type:** `List`1`

---

### get_SourceId

**Signature:** `Garnet.Composition.ActorId get_SourceId()`
**Return Type:** `ActorId`

---

### get_Memory

**Signature:** `System.ReadOnlyMemory`1[a] get_Memory()`
**Return Type:** `ReadOnlyMemory`1`

---

### Allocate

**Signature:** `Void Allocate(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minSize` | `Int32` | No | `` |  |

---

### SetSource

**Signature:** `Void SetSource(Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `ActorId` | No | `` |  |

---

### AddDestination

**Signature:** `Void AddDestination(Garnet.Composition.Destination)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `Destination` | No | `` |  |

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
| `minSize` | `Int32` | No | `` |  |

---

### GetSpan

**Signature:** `System.Span`1[a] GetSpan(Int32)`
**Return Type:** `Span`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minSize` | `Int32` | No | `` |  |

---

### CopyTo

**Signature:** `Void CopyTo(Garnet.Composition.IMessageWriter`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `IMessageWriter`1` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---

## Properties

### Recipients

**Type:** `List`1` (read-only)

---

### SourceId

**Type:** `ActorId` (read-only)

---

### Memory

**Type:** `ReadOnlyMemory`1` (read-only)

---