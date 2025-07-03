# Disposable Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Disposable`
- **Implements:** `System.IDisposable`

## Methods

### get_Null (static)

**Signature:** `System.IDisposable get_Null()`
**Return Type:** `IDisposable`

---

### Create (static)

**Signature:** `System.IDisposable Create(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dispose` | `FSharpFunc`2` | No | `` |  |

---

### Create (static)

**Signature:** `System.IDisposable Create(System.IDisposable[])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `items` | `IDisposable[]` | No | `` |  |

---

### Create (static)

**Signature:** `System.IDisposable Create(System.Collections.Generic.IEnumerable`1[System.IDisposable])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `items` | `IEnumerable`1` | No | `` |  |

---

## Properties

### Null (static)

**Type:** `IDisposable` (read-only)

---