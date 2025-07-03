# DiagnosticsTraceWriter Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.DiagnosticsTraceWriter`
- **Implements:** `Newtonsoft.Json.Serialization.ITraceWriter`

## Methods

### get_LevelFilter

**Signature:** `System.Diagnostics.TraceLevel get_LevelFilter()`
**Return Type:** `TraceLevel`

---

### set_LevelFilter

**Signature:** `Void set_LevelFilter(System.Diagnostics.TraceLevel)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TraceLevel` | No | `` |  |

---

### Trace

**Signature:** `Void Trace(System.Diagnostics.TraceLevel, System.String, System.Exception)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `level` | `TraceLevel` | No | `` |  |
| `message` | `String` | No | `` |  |
| `ex` | `Exception` | No | `` |  |

---

## Properties

### LevelFilter

**Type:** `TraceLevel` (read/write)

---