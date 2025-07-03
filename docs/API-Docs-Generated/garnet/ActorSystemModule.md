# ActorSystemModule Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ActorSystemModule`

## Methods

### IMessagePump.Get (static)

**Signature:** `Garnet.Composition.ActorReference IMessagePump.Get(Garnet.Composition.IMessagePump, Garnet.Composition.ActorId)`
**Return Type:** `ActorReference`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessagePump` | No | `` |  |
| `id` | `ActorId` | No | `` |  |

---

### IMessagePump.Process (static) (generic)

**Signature:** `Void IMessagePump.Process[a](Garnet.Composition.IMessagePump, Garnet.Composition.ActorId, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessagePump` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### IMessagePump.Process (static) (generic)

**Signature:** `Void IMessagePump.Process[a](Garnet.Composition.IMessagePump, Garnet.Composition.ActorId, a, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IMessagePump` | No | `` |  |
| `destId` | `ActorId` | No | `` |  |
| `msg` | `a` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, System.Collections.Generic.IEnumerable`1[Garnet.Composition.IActorFactory])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `factories` | `IEnumerable`1` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Microsoft.FSharp.Core.FSharpValueOption`1[Garnet.Composition.Actor]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `tryCreate` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Garnet.Composition.Actor])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `create` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Garnet.Composition.Actor])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `create` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Garnet.Composition.ActorId, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Garnet.Composition.Actor])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `actorId` | `ActorId` | No | `` |  |
| `create` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,System.Boolean], Int32, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `dispatcherId` | `Int32` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Int32, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `dispatcherId` | `Int32` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Garnet.Composition.ActorId, Int32, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `actorId` | `ActorId` | No | `` |  |
| `dispatcherId` | `Int32` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### ActorSystem.Register (static)

**Signature:** `Void ActorSystem.Register(Garnet.Composition.ActorSystem, Garnet.Composition.ActorId, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorSystem` | No | `` |  |
| `actorId` | `ActorId` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### ActorReference.BeginSend (static) (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[System.Object] ActorReference.BeginSend[a](Garnet.Composition.ActorReference)`
**Return Type:** `IMessageWriter`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ActorReference` | No | `` |  |

---

### ActorReference.Send (static) (generic)

**Signature:** `Void ActorReference.Send[a](Garnet.Composition.ActorReference, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorReference` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### ActorReference.Send (static) (generic)

**Signature:** `Void ActorReference.Send[a](Garnet.Composition.ActorReference, a, Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorReference` | No | `` |  |
| `msg` | `a` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### ActorReference.SendAll (static) (generic)

**Signature:** `Void ActorReference.SendAll[a](Garnet.Composition.ActorReference, System.ReadOnlySpan`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorReference` | No | `` |  |
| `msgs` | `ReadOnlySpan`1` | No | `` |  |

---

### ActorReference.SendAll (static) (generic)

**Signature:** `Void ActorReference.SendAll[a](Garnet.Composition.ActorReference, System.ReadOnlySpan`1[a], Garnet.Composition.ActorId)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorReference` | No | `` |  |
| `msgs` | `ReadOnlySpan`1` | No | `` |  |
| `sourceId` | `ActorId` | No | `` |  |

---

### ActorReference.Process (static) (generic)

**Signature:** `Void ActorReference.Process[a](Garnet.Composition.ActorReference, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `ActorReference` | No | `` |  |
| `msg` | `a` | No | `` |  |

---