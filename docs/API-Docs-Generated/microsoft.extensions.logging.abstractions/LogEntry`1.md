# LogEntry`1 Struct

**Namespace:** `Microsoft.Extensions.Logging.Abstractions`
**Full Name:** `Microsoft.Extensions.Logging.Abstractions.LogEntry`1`
- **Base Type:** `System.ValueType`
- **Generic Parameters:** `<TState>`

Holds the information for a single log entry.

## Methods

### get_LogLevel

**Signature:** `Microsoft.Extensions.Logging.LogLevel get_LogLevel()`
**Return Type:** `LogLevel`

---

### get_Category

**Signature:** `System.String get_Category()`
**Return Type:** `String`

---

### get_EventId

**Signature:** `Microsoft.Extensions.Logging.EventId get_EventId()`
**Return Type:** `EventId`

---

### get_State

**Signature:** `TState get_State()`
**Return Type:** `TState`

---

### get_Exception

**Signature:** `System.Exception get_Exception()`
**Return Type:** `Exception`

---

### get_Formatter

**Signature:** `System.Func`3[TState,System.Exception,System.String] get_Formatter()`
**Return Type:** `Func`3`

---

## Properties

### LogLevel

**Type:** `LogLevel` (read-only)

**Description:** Gets the log level.

---

### Category

**Type:** `String` (read-only)

**Description:** Gets the log category.

---

### EventId

**Type:** `EventId` (read-only)

**Description:** Gets the log event ID.

---

### State

**Type:** `TState` (read-only)

**Description:** Gets the state.

---

### Exception

**Type:** `Exception` (read-only)

**Description:** Gets the log exception.

---

### Formatter

**Type:** `Func`3` (read-only)

**Description:** Gets the formatter.

---