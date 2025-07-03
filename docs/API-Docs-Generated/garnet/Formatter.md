# Formatter Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Formatter`
- **Implements:** `Garnet.Composition.IFormatter`

## Methods

### Skip

**Signature:** `Void Skip(System.Type)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `t` | `Type` | No | `` |  |

---

### Skip (generic)

**Signature:** `Void Skip[a]()`
**Return Type:** `Void`

---

### Register (generic)

**Signature:** `Void Register[a](System.Type, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `t` | `Type` | No | `` |  |
| `format` | `a` | No | `` |  |

---

### Register (generic)

**Signature:** `Void Register[a](Microsoft.FSharp.Core.FSharpFunc`2[a,System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |

---

### Format (generic)

**Signature:** `System.String Format[a](a)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `a` | No | `` |  |

---