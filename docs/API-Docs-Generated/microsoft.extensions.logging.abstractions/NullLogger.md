# NullLogger Class

**Namespace:** `Microsoft.Extensions.Logging.Abstractions`
**Full Name:** `Microsoft.Extensions.Logging.Abstractions.NullLogger`
- **Implements:** `Microsoft.Extensions.Logging.ILogger`

Minimalistic logger that does nothing.

## Methods

### get_Instance (static)

**Signature:** `Microsoft.Extensions.Logging.Abstractions.NullLogger get_Instance()`
**Return Type:** `NullLogger`

---

### BeginScope (generic)

**Signature:** `System.IDisposable BeginScope[TState](TState)`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TState` | No | `` |  |

---

### IsEnabled

**Signature:** `Boolean IsEnabled(Microsoft.Extensions.Logging.LogLevel)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` |  |

---

### Log (generic)

**Signature:** `Void Log[TState](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, TState, System.Exception, System.Func`3[TState,System.Exception,System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` |  |
| `eventId` | `EventId` | No | `` |  |
| `state` | `TState` | No | `` |  |
| `exception` | `Exception` | No | `` |  |
| `formatter` | `Func`3` | No | `` |  |

---

## Properties

### Instance (static)

**Type:** `NullLogger` (read-only)

**Description:** Returns the shared instance of .

---