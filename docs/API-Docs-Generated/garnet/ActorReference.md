# ActorReference Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ActorReference`
- **Base Type:** `System.ValueType`
- **Implements:** `System.IEquatable`1[[Garnet.Composition.ActorReference, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`

## Methods

### get_ActorId

**Signature:** `Garnet.Composition.ActorId get_ActorId()`
**Return Type:** `ActorId`

---

### get_MessagePump

**Signature:** `Garnet.Composition.IMessagePump get_MessagePump()`
**Return Type:** `IMessagePump`

---

### GetHashCode

**Signature:** `Int32 GetHashCode(System.Collections.IEqualityComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IEqualityComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Object, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### get_Null (static)

**Signature:** `Garnet.Composition.ActorReference get_Null()`
**Return Type:** `ActorReference`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.ActorReference)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ActorReference` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

## Properties

### ActorId

**Type:** `ActorId` (read-only)

---

### MessagePump

**Type:** `IMessagePump` (read-only)

---

### Null (static)

**Type:** `ActorReference` (read-only)

---