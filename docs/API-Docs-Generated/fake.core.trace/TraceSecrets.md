# TraceSecrets Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TraceSecrets`

Module to handle tracing secret values in logs

## Methods

### get_setTraceSecrets (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.TraceSecret],Microsoft.FSharp.Core.Unit] get_setTraceSecrets()`
**Return Type:** `FSharpFunc`2`

---

### getAll (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.TraceSecret] getAll()`
**Return Type:** `FSharpList`1`

---

### register (static)

**Signature:** `Void register(System.String, System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `replacement` | `String` | No | `` |  |
| `secret` | `String` | No | `` |  |

---

### guardMessage (static)

**Signature:** `System.String guardMessage(System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

## Properties

### setTraceSecrets (static)

**Type:** `FSharpFunc`2` (read-only)

---