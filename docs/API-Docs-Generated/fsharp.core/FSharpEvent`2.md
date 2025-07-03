# FSharpEvent`2 Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.FSharpEvent`2`
- **Generic Parameters:** `<TDelegate, TArgs>`

Event implementations for a delegate types following the standard .NET Framework convention of a first 'sender' argument.

## Methods

### Trigger

**Signature:** `Void Trigger(System.Object, TArgs)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sender` | `Object` | No | `` |  |
| `args` | `TArgs` | No | `` |  |

---

### get_Publish

**Signature:** `Microsoft.FSharp.Control.IEvent`2[TDelegate,TArgs] get_Publish()`
**Return Type:** `IEvent`2`

---

## Properties

### Publish

**Type:** `IEvent`2` (read-only)

**Description:** Publishes the event as a first class event value.

---