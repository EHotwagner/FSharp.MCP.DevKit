# Envelope`1 Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Envelope`1`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`
- **Generic Parameters:** `<a>`

## Methods

### get_Outbox

**Signature:** `Garnet.Composition.IOutbox get_Outbox()`
**Return Type:** `IOutbox`

---

### get_SourceId

**Signature:** `Garnet.Composition.ActorId get_SourceId()`
**Return Type:** `ActorId`

---

### get_DestinationId

**Signature:** `Garnet.Composition.ActorId get_DestinationId()`
**Return Type:** `ActorId`

---

### get_Message

**Signature:** `a get_Message()`
**Return Type:** `a`

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

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.Envelope`1[a])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Envelope`1` | No | `` |  |

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

### Outbox

**Type:** `IOutbox` (read-only)

---

### SourceId

**Type:** `ActorId` (read-only)

---

### DestinationId

**Type:** `ActorId` (read-only)

---

### Message

**Type:** `a` (read-only)

---