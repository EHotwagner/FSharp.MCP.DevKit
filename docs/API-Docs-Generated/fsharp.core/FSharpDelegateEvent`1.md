# FSharpDelegateEvent`1 Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.FSharpDelegateEvent`1`
- **Generic Parameters:** `<TDelegate>`

Event implementations for an arbitrary type of delegate.

## Methods

### Trigger

**Signature:** `Void Trigger(System.Object[])`
**Return Type:** `Void`

**Description:** Triggers the event using the given parameters.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `Object[]` | No | `` | The parameters for the event. |

---

### get_Publish

**Signature:** `Microsoft.FSharp.Control.IDelegateEvent`1[TDelegate] get_Publish()`
**Return Type:** `IDelegateEvent`1`

---

## Properties

### Publish

**Type:** `IDelegateEvent`1` (read-only)

**Description:** Publishes the event as a first class event value.

---