# NullLoggerFactory Class

**Namespace:** `Microsoft.Extensions.Logging.Abstractions`
**Full Name:** `Microsoft.Extensions.Logging.Abstractions.NullLoggerFactory`
- **Implements:** `Microsoft.Extensions.Logging.ILoggerFactory`, `System.IDisposable`

An  used to create an instance of
             that logs nothing.

## Methods

### CreateLogger

**Signature:** `Microsoft.Extensions.Logging.ILogger CreateLogger(System.String)`
**Return Type:** `ILogger`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### AddProvider

**Signature:** `Void AddProvider(Microsoft.Extensions.Logging.ILoggerProvider)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `provider` | `ILoggerProvider` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---