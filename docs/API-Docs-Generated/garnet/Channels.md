# Channels Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Channels`
- **Implements:** `Garnet.Composition.IChannels`

## Methods

### get_Count

**Signature:** `Int32 get_Count()`
**Return Type:** `Int32`

---

### Clear

**Signature:** `Void Clear()`
**Return Type:** `Void`

---

### Commit

**Signature:** `Void Commit()`
**Return Type:** `Void`

---

### SetPublisher

**Signature:** `Void SetPublisher(Microsoft.FSharp.Core.FSharpValueOption`1[Garnet.Composition.IPublisher])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newPublisher` | `FSharpValueOption`1` | No | `` |  |

---

### Publish

**Signature:** `Boolean Publish()`
**Return Type:** `Boolean`

---

### GetChannel (generic)

**Signature:** `Garnet.Composition.Channel`1[a] GetChannel[a]()`
**Return Type:** `Channel`1`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

## Properties

### Count

**Type:** `Int32` (read-only)

---