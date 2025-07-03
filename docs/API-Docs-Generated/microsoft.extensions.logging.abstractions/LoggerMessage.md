# LoggerMessage Class

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.LoggerMessage`

Creates delegates that can be later cached to log messages in a performant way.

## Methods

### DefineScope (static)

**Signature:** `System.Func`2[Microsoft.Extensions.Logging.ILogger,System.IDisposable] DefineScope(System.String)`
**Return Type:** `Func`2`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### DefineScope (static) (generic)

**Signature:** `System.Func`3[Microsoft.Extensions.Logging.ILogger,T1,System.IDisposable] DefineScope[T1](System.String)`
**Return Type:** `Func`3`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### DefineScope (static) (generic)

**Signature:** `System.Func`4[Microsoft.Extensions.Logging.ILogger,T1,T2,System.IDisposable] DefineScope[T1,T2](System.String)`
**Return Type:** `Func`4`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### DefineScope (static) (generic)

**Signature:** `System.Func`5[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,System.IDisposable] DefineScope[T1,T2,T3](System.String)`
**Return Type:** `Func`5`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### DefineScope (static) (generic)

**Signature:** `System.Func`6[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,System.IDisposable] DefineScope[T1,T2,T3,T4](System.String)`
**Return Type:** `Func`6`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### DefineScope (static) (generic)

**Signature:** `System.Func`7[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,T5,System.IDisposable] DefineScope[T1,T2,T3,T4,T5](System.String)`
**Return Type:** `Func`7`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### DefineScope (static) (generic)

**Signature:** `System.Func`8[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,T5,T6,System.IDisposable] DefineScope[T1,T2,T3,T4,T5,T6](System.String)`
**Return Type:** `Func`8`

**Description:** Creates a delegate that can be invoked to create a log scope.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log scope.

---

### Define (static)

**Signature:** `System.Action`2[Microsoft.Extensions.Logging.ILogger,System.Exception] Define(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`2`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static)

**Signature:** `System.Action`2[Microsoft.Extensions.Logging.ILogger,System.Exception] Define(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`2`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`3[Microsoft.Extensions.Logging.ILogger,T1,System.Exception] Define[T1](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`3`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`3[Microsoft.Extensions.Logging.ILogger,T1,System.Exception] Define[T1](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`3`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`4[Microsoft.Extensions.Logging.ILogger,T1,T2,System.Exception] Define[T1,T2](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`4`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`4[Microsoft.Extensions.Logging.ILogger,T1,T2,System.Exception] Define[T1,T2](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`4`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`5[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,System.Exception] Define[T1,T2,T3](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`5`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`5[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,System.Exception] Define[T1,T2,T3](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`5`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`6[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,System.Exception] Define[T1,T2,T3,T4](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`6`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`6[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,System.Exception] Define[T1,T2,T3,T4](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`6`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`7[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,T5,System.Exception] Define[T1,T2,T3,T4,T5](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`7`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`7[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,T5,System.Exception] Define[T1,T2,T3,T4,T5](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`7`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`8[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,T5,T6,System.Exception] Define[T1,T2,T3,T4,T5,T6](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String)`
**Return Type:** `Action`8`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |

**Returns:** A delegate that, when invoked, creates a log message.

---

### Define (static) (generic)

**Signature:** `System.Action`8[Microsoft.Extensions.Logging.ILogger,T1,T2,T3,T4,T5,T6,System.Exception] Define[T1,T2,T3,T4,T5,T6](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.String, Microsoft.Extensions.Logging.LogDefineOptions)`
**Return Type:** `Action`8`

**Description:** Creates a delegate that can be invoked for logging a message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `logLevel` | `LogLevel` | No | `` | The . |
| `eventId` | `EventId` | No | `` | The event ID. |
| `formatString` | `String` | No | `` | The named format string. |
| `options` | `LogDefineOptions` | No | `` | The . |

**Returns:** A delegate that, when invoked, creates a log message.

---