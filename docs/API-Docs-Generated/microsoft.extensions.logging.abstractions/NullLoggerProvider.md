# NullLoggerProvider Class

**Namespace:** `Microsoft.Extensions.Logging.Abstractions`
**Full Name:** `Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider`
- **Implements:** `Microsoft.Extensions.Logging.ILoggerProvider`, `System.IDisposable`

Provider for the .

## Methods

### get_Instance (static)

**Signature:** `Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider get_Instance()`
**Return Type:** `NullLoggerProvider`

---

### CreateLogger

**Signature:** `Microsoft.Extensions.Logging.ILogger CreateLogger(System.String)`
**Return Type:** `ILogger`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `categoryName` | `String` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---

## Properties

### Instance (static)

**Type:** `NullLoggerProvider` (read-only)

**Description:** Returns an instance of .

---