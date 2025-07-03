# ActorSystem Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ActorSystem`
- **Implements:** `Garnet.Composition.IMessagePump`, `System.IDisposable`, `Garnet.Composition.IOutbox`

## Methods

### get_ActorCount

**Signature:** `Int32 get_ActorCount()`
**Return Type:** `Int32`

---

### Register

**Signature:** `Void Register(Garnet.Composition.IActorFactory)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `factory` | `IActorFactory` | No | `` |  |

---

### RegisterExceptionHandler

**Signature:** `System.IDisposable RegisterExceptionHandler(System.Action`1[Garnet.Composition.ActorException])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `onException` | `Action`1` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---

### Process

**Signature:** `Void Process()`
**Return Type:** `Void`

---

### ProcessAll

**Signature:** `Void ProcessAll()`
**Return Type:** `Void`

---

### BeginSend (generic)

**Signature:** `Garnet.Composition.IMessageWriter`1[a] BeginSend[a]()`
**Return Type:** `IMessageWriter`1`

---

### ToString

**Signature:** `Void ToString(Garnet.Composition.IStringBlockWriter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `IStringBlockWriter` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CreateSingleThread (static)

**Signature:** `Garnet.Composition.ActorSystem CreateSingleThread()`
**Return Type:** `ActorSystem`

---

## Properties

### ActorCount

**Type:** `Int32` (read-only)

---