# Mailbox Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Mailbox`
- **Implements:** `Garnet.Composition.IOutbox`, `Garnet.Composition.IInbox`

## Methods

### get_SourceId

**Signature:** `Garnet.Composition.ActorId get_SourceId()`
**Return Type:** `ActorId`

---

### get_DestinationId

**Signature:** `Garnet.Composition.ActorId get_DestinationId()`
**Return Type:** `ActorId`

---

### OnAll (generic)

**Signature:** `Void OnAll[a](Microsoft.FSharp.Core.FSharpFunc`2[System.ReadOnlyMemory`1[a],Microsoft.FSharp.Core.Unit])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |

---

### On (generic)

**Signature:** `Void On[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `handle` | `FSharpFunc`2` | No | `` |  |

---

### TryReceive (generic)

**Signature:** `Boolean TryReceive[a](Garnet.Composition.Envelope`1[System.ReadOnlyMemory`1[a]])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `Envelope`1` | No | `` |  |

---

### BeginSend (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[a] BeginSend[a]()`
**Return Type:** `IMessageWriter`1`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Create (static)

**Signature:** `Garnet.Composition.Mailbox Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Mailbox,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Mailbox`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `register` | `FSharpFunc`2` | No | `` |  |

---

### BeginRespond (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[a] BeginRespond[a]()`
**Return Type:** `IMessageWriter`1`

---

### Respond (generic)

**Signature:** `Void Respond[a](a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `a` | No | `` |  |

---

## Properties

### SourceId

**Type:** `ActorId` (read-only)

---

### DestinationId

**Type:** `ActorId` (read-only)

---