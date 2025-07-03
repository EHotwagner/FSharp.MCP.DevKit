# ILogger Interface

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.ILogger`

Represents a type used to perform logging.

## Methods

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

**Description:** Checks if the given  is enabled.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | Level to be checked. |

**Returns:** if enabled.

---

### BeginScope (generic)

**Signature:** `System.IDisposable BeginScope[TState](TState)`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TState` | No | `` |  |

---