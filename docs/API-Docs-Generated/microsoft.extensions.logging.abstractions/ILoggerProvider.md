# ILoggerProvider Interface

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.ILoggerProvider`
- **Implements:** `System.IDisposable`

Represents a type that can create instances of .

## Methods

### CreateLogger

**Signature:** `Microsoft.Extensions.Logging.ILogger CreateLogger(System.String)`
**Return Type:** `ILogger`

**Description:** Creates a new  instance.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `categoryName` | `String` | No | `` | The category name for messages produced by the logger. |

**Returns:** The instance of  that was created.

---