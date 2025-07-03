# LoggerFactoryExtensions Class

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.LoggerFactoryExtensions`

ILoggerFactory extension methods for common scenarios.

## Methods

### CreateLogger (static) (generic)

**Signature:** `Microsoft.Extensions.Logging.ILogger`1[T] CreateLogger[T](Microsoft.Extensions.Logging.ILoggerFactory)`
**Return Type:** `ILogger`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `factory` | `ILoggerFactory` | No | `` |  |

---

### CreateLogger (static)

**Signature:** `Microsoft.Extensions.Logging.ILogger CreateLogger(Microsoft.Extensions.Logging.ILoggerFactory, System.Type)`
**Return Type:** `ILogger`

**Description:** Creates a new  instance using the full name of the given .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `factory` | `ILoggerFactory` | No | `` | The factory. |
| `type` | `Type` | No | `` | The type. |

**Returns:** The  that was created.

---