# ZipArchiveFolder Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ZipArchiveFolder`
- **Implements:** `System.IDisposable`, `Garnet.Composition.IReadOnlyFolder`, `Garnet.Composition.IStreamSource`

## Methods

### GetFiles (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] GetFiles[a](System.String, a)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` |  |
| `_arg1` | `a` | No | `` |  |

---

### Contains

**Signature:** `Boolean Contains(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` |  |

---

### TryOpen

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[System.IO.Stream] TryOpen(System.String)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---