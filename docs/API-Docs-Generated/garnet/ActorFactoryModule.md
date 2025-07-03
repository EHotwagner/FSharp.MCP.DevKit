# ActorFactoryModule Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ActorFactoryModule`

## Methods

### IActorFactory.Wrap (static)

**Signature:** `Garnet.Composition.IActorFactory IActorFactory.Wrap(Garnet.Composition.IActorFactory, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.ActorId,Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Actor,Garnet.Composition.Actor]])`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IActorFactory` | No | `` |  |
| `map` | `FSharpFunc`2` | No | `` |  |

---

### IActorFactory.WithDispatcher (static)

**Signature:** `Garnet.Composition.IActorFactory IActorFactory.WithDispatcher(Garnet.Composition.IActorFactory, Int32)`
**Return Type:** `IActorFactory`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IActorFactory` | No | `` |  |
| `dispatcherId` | `Int32` | No | `` |  |

---

### IActorFactory.Create (static)

**Signature:** `Garnet.Composition.Actor IActorFactory.Create(Garnet.Composition.IActorFactory, Garnet.Composition.ActorId)`
**Return Type:** `Actor`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IActorFactory` | No | `` |  |
| `actorId` | `ActorId` | No | `` |  |

---