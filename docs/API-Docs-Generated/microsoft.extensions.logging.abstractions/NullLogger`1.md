# NullLogger`1 Class

**Namespace:** `Microsoft.Extensions.Logging.Abstractions`
**Full Name:** `Microsoft.Extensions.Logging.Abstractions.NullLogger`1`
- **Implements:** ``, `Microsoft.Extensions.Logging.ILogger`
- **Generic Parameters:** `<T>`

Minimalistic logger that does nothing.

## Methods

### BeginScope (generic)

**Signature:** `System.IDisposable BeginScope[TState](TState)`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TState` | No | `` |  |

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

### IsEnabled

**Signature:** `Boolean IsEnabled(Microsoft.Extensions.Logging.LogLevel)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` |  |

---