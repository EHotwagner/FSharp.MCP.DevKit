# MemoryTraceWriter Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.MemoryTraceWriter`
- **Implements:** `Newtonsoft.Json.Serialization.ITraceWriter`

Represents a trace writer that writes to memory. When the trace message limit is
            reached then old trace messages will be removed as new messages are added.

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

### GetTraceMessages

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] GetTraceMessages()`
**Return Type:** `IEnumerable`1`

**Description:** Returns an enumeration of the most recent trace messages.

**Returns:** An enumeration of the most recent trace messages.

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

**Description:** Returns a  of the most recent trace messages.

**Returns:** A  of the most recent trace messages.

---

## Properties

### LevelFilter

**Type:** `TraceLevel` (read/write)

**Description:** Gets the  that will be used to filter the trace messages passed to the writer.
            For example a filter level of Info will exclude Verbose messages and include Info,
            Warning and Error messages.

---