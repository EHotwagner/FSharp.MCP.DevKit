# Container Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Container`
- **Implements:** `Garnet.Composition.IInbox`, `Garnet.Composition.IOutbox`, `Garnet.Composition.ISegmentStore`1[[System.Int32, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]`, `Garnet.Composition.IComponentStore`3[[System.Int32, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[Garnet.Composition.Eid, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null],[Garnet.Composition.EidSegmentKeyMapper, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `Garnet.Composition.IChannels`, `Garnet.Composition.IResourceCache`, `Garnet.Composition.IRegistry`

## Methods

### GetComponents (generic)

**Signature:** `Garnet.Composition.Components`4[System.Int32,Garnet.Composition.Eid,Garnet.Composition.EidSegmentKeyMapper,a] GetComponents[a]()`
**Return Type:** `Components`4`

---

### GetSegments (generic)

**Signature:** `Garnet.Composition.Segments`2[System.Int32,a] GetSegments[a]()`
**Return Type:** `Segments`2`

---

### GetChannel (generic)

**Signature:** `Garnet.Composition.Channel`1[a] GetChannel[a]()`
**Return Type:** `Channel`1`

---

### SetFactory (generic)

**Signature:** `Void SetFactory[q](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,q])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `FSharpFunc`2` | No | `` |  |

---

### Set (generic)

**Signature:** `Void Set[p](p)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `p` | No | `` |  |

---

### Get (generic)

**Signature:** `o& Get[o]()`
**Return Type:** `o&`

---

### TryGet (generic)

**Signature:** `Boolean TryGet[a](a ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `a&` | No | `` |  |

---

### AddResource (generic)

**Signature:** `Void AddResource[a](System.String, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` |  |
| `resource` | `a` | No | `` |  |

---

### TryGetResource (generic)

**Signature:** `Boolean TryGetResource[a](System.String, a ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` |  |
| `value` | `a&` | No | `` |  |

---

### LoadResource (generic)

**Signature:** `a LoadResource[a](System.String)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` |  |

---

### Iter (generic)

**Signature:** `Void Iter[n](n, Garnet.Composition.IRegistryHandler`1[n])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `n` | No | `` |  |
| `handler` | `IRegistryHandler`1` | No | `` |  |

---

### GetAddresses

**Signature:** `Garnet.Composition.Addresses GetAddresses()`
**Return Type:** `Addresses`

---

### Commit

**Signature:** `Void Commit()`
**Return Type:** `Void`

---

### Run

**Signature:** `Void Run()`
**Return Type:** `Void`

---

### Contains

**Signature:** `Boolean Contains(Garnet.Composition.Eid)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `eid` | `Eid` | No | `` |  |

---

### Get

**Signature:** `Garnet.Composition.Entity`3[System.Int32,Garnet.Composition.Eid,Garnet.Composition.EidSegmentKeyMapper] Get(Garnet.Composition.Eid)`
**Return Type:** `Entity`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `eid` | `Eid` | No | `` |  |

---

### Handle (generic)

**Signature:** `Void Handle[m](m, Garnet.Composition.ISegmentListHandler`2[m,System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `m` | No | `` |  |
| `handler` | `ISegmentListHandler`2` | No | `` |  |

---

### Handle (generic)

**Signature:** `Void Handle[l](l, Int32, UInt64, Garnet.Composition.ISegmentHandler`2[l,System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `l` | No | `` |  |
| `sid` | `Int32` | No | `` |  |
| `mask` | `UInt64` | No | `` |  |
| `handler` | `ISegmentHandler`2` | No | `` |  |

---

### Handle (generic)

**Signature:** `Void Handle[k](k, Garnet.Composition.Eid, Garnet.Composition.ISegmentHandler`2[k,System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `k` | No | `` |  |
| `id` | `Eid` | No | `` |  |
| `handler` | `ISegmentHandler`2` | No | `` |  |

---

### Destroy

**Signature:** `Void Destroy(Garnet.Composition.Eid)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `eid` | `Eid` | No | `` |  |

---

### Step

**Signature:** `Void Step(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `deltaTime` | `Int64` | No | `` |  |

---

### Start

**Signature:** `Void Start(System.Collections.Generic.IEnumerable`1[Garnet.Composition.Wait])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `coroutine` | `IEnumerable`1` | No | `` |  |

---

### SetPublisher

**Signature:** `Void SetPublisher(Microsoft.FSharp.Core.FSharpValueOption`1[Garnet.Composition.IPublisher])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pub` | `FSharpValueOption`1` | No | `` |  |

---

### SetPublisher

**Signature:** `Void SetPublisher(Garnet.Composition.IPublisher)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pub` | `IPublisher` | No | `` |  |

---

### UnsubscribeAll

**Signature:** `Void UnsubscribeAll()`
**Return Type:** `Void`

---

### BeginSend (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[j] BeginSend[j]()`
**Return Type:** `IMessageWriter`1`

---

### Receive (generic)

**Signature:** `Void Receive[a](Garnet.Composition.Envelope`1[System.ReadOnlyMemory`1[a]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `Envelope`1` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### GetSourceId

**Signature:** `Garnet.Composition.ActorId GetSourceId()`
**Return Type:** `ActorId`

---

### GetDestinationId

**Signature:** `Garnet.Composition.ActorId GetDestinationId()`
**Return Type:** `ActorId`

---

### Create

**Signature:** `Garnet.Composition.Entity`3[System.Int32,Garnet.Composition.Eid,Garnet.Composition.EidSegmentKeyMapper] Create(Int32)`
**Return Type:** `Entity`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `partition` | `Int32` | No | `` |  |

---

### Create

**Signature:** `Garnet.Composition.Entity`3[System.Int32,Garnet.Composition.Eid,Garnet.Composition.EidSegmentKeyMapper] Create()`
**Return Type:** `Entity`3`

---

### Create

**Signature:** `Garnet.Composition.Entity`3[System.Int32,Garnet.Composition.Eid,Garnet.Composition.EidSegmentKeyMapper] Create(Garnet.Composition.Eid)`
**Return Type:** `Entity`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `eid` | `Eid` | No | `` |  |

---

### DestroyAll

**Signature:** `Void DestroyAll()`
**Return Type:** `Void`

---

### Run (generic)

**Signature:** `Void Run[c](c)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `c` | No | `` |  |

---

### BeginRespond (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[b] BeginRespond[b]()`
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

### AddSystems

**Signature:** `System.IDisposable AddSystems(System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable]])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `systems` | `IEnumerable`1` | No | `` |  |

---

### AddSystem

**Signature:** `System.IDisposable AddSystem(System.String, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### AddSystem

**Signature:** `System.IDisposable AddSystem(Garnet.Composition.ActorId, Garnet.Composition.IOutbox, Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `actorId` | `ActorId` | No | `` |  |
| `actorOutbox` | `IOutbox` | No | `` |  |
| `register` | `FSharpFunc`2` | No | `` |  |

---

### AddStateMachine (generic)

**Signature:** `System.IDisposable AddStateMachine[a](a, Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable]])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `initState` | `a` | No | `` |  |
| `registerState` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `Garnet.Composition.Container Create(Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Container,System.IDisposable])`
**Return Type:** `Container`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `register` | `FSharpFunc`2` | No | `` |  |

---