# ActorFactory Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ActorFactory`
- **Implements:** `Garnet.Composition.IActorFactory`

## Methods

### get_Null (static)

**Signature:** `Garnet.Composition.IActorFactory get_Null()`
**Return Type:** `IActorFactory`

---

### TryCreate

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[Garnet.Composition.Actor] TryCreate(Garnet.Composition.ActorId)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `createId` | `ActorId` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.IActorFactory Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Microsoft.FSharp.Core.FSharpValueOption`1[Garnet.Composition.Actor]])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tryCreate` | `FSharpFunc`2` | No | `` |  |

---

### Create (static) (generic)

**Signature:** `Garnet.Composition.IActorFactory Create[a](System.Collections.Generic.IEnumerable`1[a])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `factories` | `IEnumerable`1` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.ActorFactory Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Garnet.Composition.Actor])`
**Return Type:** `ActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `create` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.IActorFactory Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Garnet.Composition.Actor])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `create` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.IActorFactory Create(Garnet.Composition.ActorId, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Garnet.Composition.Actor])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `actorId` | `ActorId` | No | `` |  |
| `create` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.IActorFactory Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Mailbox,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.IActorFactory Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Mailbox,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `register` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.IActorFactory Create(Garnet.Composition.ActorId, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Mailbox,Microsoft.FSharp.Core.Unit]])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `actorId` | `ActorId` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

## Properties

### Null (static)

**Type:** `IActorFactory` (read-only)

---