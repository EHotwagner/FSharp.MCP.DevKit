# CoreTracing Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.CoreTracing`

## Methods

### get_importantMessagesToStdErr (static)

**Signature:** `Boolean get_importantMessagesToStdErr()`
**Return Type:** `Boolean`

---

### get_defaultConsoleTraceListener (static)

**Signature:** `Fake.Core.ITraceListener get_defaultConsoleTraceListener()`
**Return Type:** `ITraceListener`

---

### get_setTraceListenersPrivate (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.ITraceListener],Microsoft.FSharp.Core.Unit] get_setTraceListenersPrivate()`
**Return Type:** `FSharpFunc`2`

---

### areListenersSet (static)

**Signature:** `Boolean areListenersSet()`
**Return Type:** `Boolean`

---

### getListeners (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.ITraceListener] getListeners()`
**Return Type:** `FSharpList`1`

---

### setTraceListeners (static)

**Signature:** `Void setTraceListeners(Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.ITraceListener])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `l` | `FSharpList`1` | No | `` |  |

---

### addListener (static)

**Signature:** `Void addListener(Fake.Core.ITraceListener)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `l` | `ITraceListener` | No | `` |  |

---

### ensureConsoleListener (static)

**Signature:** `Void ensureConsoleListener()`
**Return Type:** `Void`

---

### postMessage (static)

**Signature:** `Void postMessage(Fake.Core.TraceData)`
**Return Type:** `Void`

**Description:** Allows to post messages to all trace listeners

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `TraceData` | No | `` |  |

---

## Properties

### importantMessagesToStdErr (static)

**Type:** `Boolean` (read-only)

---

### defaultConsoleTraceListener (static)

**Type:** `ITraceListener` (read-only)

**Description:** The default TraceListener for Console.

---

### setTraceListenersPrivate (static)

**Type:** `FSharpFunc`2` (read-only)

---