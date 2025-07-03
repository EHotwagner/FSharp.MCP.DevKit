# LoggerMessageAttribute Class

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.LoggerMessageAttribute`
- **Base Type:** `System.Attribute`

Provides information to guide the production of a strongly typed logging method.

## Methods

### get_EventId

**Signature:** `Int32 get_EventId()`
**Return Type:** `Int32`

---

### set_EventId

**Signature:** `Void set_EventId(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` |  |

---

### get_EventName

**Signature:** `System.String get_EventName()`
**Return Type:** `String`

---

### set_EventName

**Signature:** `Void set_EventName(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_Level

**Signature:** `Microsoft.Extensions.Logging.LogLevel get_Level()`
**Return Type:** `LogLevel`

---

### set_Level

**Signature:** `Void set_Level(Microsoft.Extensions.Logging.LogLevel)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `LogLevel` | No | `` |  |

---

### get_Message

**Signature:** `System.String get_Message()`
**Return Type:** `String`

---

### set_Message

**Signature:** `Void set_Message(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_SkipEnabledCheck

**Signature:** `Boolean get_SkipEnabledCheck()`
**Return Type:** `Boolean`

---

### set_SkipEnabledCheck

**Signature:** `Void set_SkipEnabledCheck(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

## Properties

### EventId

**Type:** `Int32` (read/write)

**Description:** Gets or sets the logging event ID for the logging method.

---

### EventName

**Type:** `String` (read/write)

**Description:** Gets or sets the logging event name for the logging method.

---

### Level

**Type:** `LogLevel` (read/write)

**Description:** Gets or sets the logging level for the logging method.

---

### Message

**Type:** `String` (read/write)

**Description:** Gets or sets the message text for the logging method.

---

### SkipEnabledCheck

**Type:** `Boolean` (read/write)

**Description:** Gets or sets the flag to skip IsEnabled check for the logging method.

---