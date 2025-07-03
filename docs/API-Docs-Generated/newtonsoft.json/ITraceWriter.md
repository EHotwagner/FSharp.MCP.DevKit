# ITraceWriter Interface

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ITraceWriter`

Represents a trace writer.

## Methods

### get_LevelFilter

**Signature:** `System.Diagnostics.TraceLevel get_LevelFilter()`
**Return Type:** `TraceLevel`

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

**Type:** `TraceLevel` (read-only)

**Description:** Gets the  that will be used to filter the trace messages passed to the writer.
            For example a filter level of Info will exclude Verbose messages and include Info,
            Warning and Error messages.

---