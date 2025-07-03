# MailboxModule Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.MailboxModule`

## Methods

### IBufferWriter`1.WriteValue (static) (generic)

**Signature:** `Void IBufferWriter`1.WriteValue[T](System.Buffers.IBufferWriter`1[T], T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IBufferWriter`1` | No | `` |  |
| `x` | `T` | No | `` |  |

---

### IMessageWriter.AddDestination (static)

**Signature:** `Void IMessageWriter.AddDestination(Garnet.Composition.IMessageWriter, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessageWriter` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |

---

### IMessageWriter.AddDestination (static)

**Signature:** `Void IMessageWriter.AddDestination(Garnet.Composition.IMessageWriter, Garnet.Composition.ActorId, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessageWriter` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `recipientId` | `ActorId` | No | `` |  |

---

### IMessageWriter.AddDestinations (static)

**Signature:** `Void IMessageWriter.AddDestinations(Garnet.Composition.IMessageWriter, Garnet.Composition.ActorId[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessageWriter` | No | `` |  |
| `recipients` | `ActorId[]` | No | `` |  |

---

### IMessageWriter.AddDestinations (static)

**Signature:** `Void IMessageWriter.AddDestinations(Garnet.Composition.IMessageWriter, System.ReadOnlySpan`1[Garnet.Composition.ActorId])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessageWriter` | No | `` |  |
| `recipients` | `ReadOnlySpan`1` | No | `` |  |

---

### IMessageWriter`1.WriteAll (static) (generic)

**Signature:** `Void IMessageWriter`1.WriteAll[a](Garnet.Composition.IMessageWriter`1[a], System.ReadOnlySpan`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessageWriter`1` | No | `` |  |
| `msgs` | `ReadOnlySpan`1` | No | `` |  |

---

### IOutbox.BeginSend (static) (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[a] IOutbox.BeginSend[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId)`
**Return Type:** `IMessageWriter`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |

---

### IOutbox.Send (static) (generic)

**Signature:** `Void IOutbox.Send[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### IOutbox.Send (static) (generic)

**Signature:** `Void IOutbox.Send[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId, a, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `msg` | `a` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### IOutbox.SendAll (static) (generic)

**Signature:** `Void IOutbox.SendAll[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId, System.ReadOnlySpan`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `msgs` | `ReadOnlySpan`1` | No | `` |  |

---

### IOutbox.SendAll (static) (generic)

**Signature:** `Void IOutbox.SendAll[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId, System.ReadOnlySpan`1[a], Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `msgs` | `ReadOnlySpan`1` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### IOutbox.SendToAll (static) (generic)

**Signature:** `Void IOutbox.SendToAll[a](Garnet.Composition.IOutbox, System.ReadOnlySpan`1[Garnet.Composition.ActorId], a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destIds` | `ReadOnlySpan`1` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### IOutbox.SendToAll (static) (generic)

**Signature:** `Void IOutbox.SendToAll[a](Garnet.Composition.IOutbox, System.ReadOnlySpan`1[Garnet.Composition.ActorId], a, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destIds` | `ReadOnlySpan`1` | No | `` |  |
| `msg` | `a` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### IOutbox.SendToAll (static) (generic)

**Signature:** `Void IOutbox.SendToAll[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId[], a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destIds` | `ActorId[]` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### IOutbox.SendToAll (static) (generic)

**Signature:** `Void IOutbox.SendToAll[a](Garnet.Composition.IOutbox, Garnet.Composition.ActorId[], a, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `destIds` | `ActorId[]` | No | `` |  |
| `msg` | `a` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### IOutbox.SendAll (static) (generic)

**Signature:** `Void IOutbox.SendAll[a](Garnet.Composition.IOutbox, Garnet.Composition.Envelope`1[System.ReadOnlyMemory`1[a]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IOutbox` | No | `` |  |
| `e` | `Envelope`1` | No | `` |  |

---