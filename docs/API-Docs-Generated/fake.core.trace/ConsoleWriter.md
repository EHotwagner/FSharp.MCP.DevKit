# ConsoleWriter Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ConsoleWriter`

## Methods

### write (static)

**Signature:** `Void write(Boolean, System.ConsoleColor, Boolean, System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `toStdErr` | `Boolean` | No | `` |  |
| `color` | `ConsoleColor` | No | `` |  |
| `newLine` | `Boolean` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### writeAnsiColor (static)

**Signature:** `Void writeAnsiColor(Boolean, System.ConsoleColor, Boolean, System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `toStdErr` | `Boolean` | No | `` |  |
| `color` | `ConsoleColor` | No | `` |  |
| `newLine` | `Boolean` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### colorMap (static)

**Signature:** `System.ConsoleColor colorMap(Fake.Core.TraceData)`
**Return Type:** `ConsoleColor`

**Description:** A default color map which maps TracePriorities to ConsoleColors

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `traceData` | `TraceData` | No | `` |  |

---