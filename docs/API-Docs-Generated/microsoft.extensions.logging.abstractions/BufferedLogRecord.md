# BufferedLogRecord Class

**Namespace:** `Microsoft.Extensions.Logging.Abstractions`
**Full Name:** `Microsoft.Extensions.Logging.Abstractions.BufferedLogRecord`

Represents a buffered log record to be written in batch to an .

## Methods

### get_Timestamp

**Signature:** `System.DateTimeOffset get_Timestamp()`
**Return Type:** `DateTimeOffset`

---

### get_LogLevel

**Signature:** `Microsoft.Extensions.Logging.LogLevel get_LogLevel()`
**Return Type:** `LogLevel`

---

### get_EventId

**Signature:** `Microsoft.Extensions.Logging.EventId get_EventId()`
**Return Type:** `EventId`

---

### get_Exception

**Signature:** `System.String get_Exception()`
**Return Type:** `String`

---

### get_ActivitySpanId

**Signature:** `System.Nullable`1[System.Diagnostics.ActivitySpanId] get_ActivitySpanId()`
**Return Type:** `Nullable`1`

---

### get_ActivityTraceId

**Signature:** `System.Nullable`1[System.Diagnostics.ActivityTraceId] get_ActivityTraceId()`
**Return Type:** `Nullable`1`

---

### get_ManagedThreadId

**Signature:** `System.Nullable`1[System.Int32] get_ManagedThreadId()`
**Return Type:** `Nullable`1`

---

### get_FormattedMessage

**Signature:** `System.String get_FormattedMessage()`
**Return Type:** `String`

---

### get_MessageTemplate

**Signature:** `System.String get_MessageTemplate()`
**Return Type:** `String`

---

### get_Attributes

**Signature:** `System.Collections.Generic.IReadOnlyList`1[System.Collections.Generic.KeyValuePair`2[System.String,System.Object]] get_Attributes()`
**Return Type:** `IReadOnlyList`1`

---

## Properties

### Timestamp

**Type:** `DateTimeOffset` (read-only)

**Description:** Gets the time when the log record was first created.

---

### LogLevel

**Type:** `LogLevel` (read-only)

**Description:** Gets the record's logging severity level.

---

### EventId

**Type:** `EventId` (read-only)

**Description:** Gets the record's event ID.

---

### Exception

**Type:** `String` (read-only)

**Description:** Gets an exception string for this record.

---

### ActivitySpanId

**Type:** `Nullable`1` (read-only)

**Description:** Gets an activity span ID for this record, representing the state of the thread that created the record.

---

### ActivityTraceId

**Type:** `Nullable`1` (read-only)

**Description:** Gets an activity trace ID for this record, representing the state of the thread that created the record.

---

### ManagedThreadId

**Type:** `Nullable`1` (read-only)

**Description:** Gets the ID of the thread that created the log record.

---

### FormattedMessage

**Type:** `String` (read-only)

**Description:** Gets the formatted log message.

---

### MessageTemplate

**Type:** `String` (read-only)

**Description:** Gets the original log message template.

---

### Attributes

**Type:** `IReadOnlyList`1` (read-only)

**Description:** Gets the variable set of name/value pairs associated with the record.

---