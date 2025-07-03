# ILoggerFactory Interface

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.ILoggerFactory`
- **Implements:** `System.IDisposable`

Represents a type used to configure the logging system and create instances of  from
            the registered s.

## Methods

### CreateLogger

**Signature:** `Microsoft.Extensions.Logging.ILogger CreateLogger(System.String)`
**Return Type:** `ILogger`

**Description:** Creates a new  instance.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `categoryName` | `String` | No | `` | The category name for messages produced by the logger. |

**Returns:** The .

---

### AddProvider

**Signature:** `Void AddProvider(Microsoft.Extensions.Logging.ILoggerProvider)`
**Return Type:** `Void`

**Description:** Adds an  to the logging system.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `provider` | `ILoggerProvider` | No | `` | The . |

---