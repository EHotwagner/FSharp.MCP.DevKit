# FileFolder Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.FileFolder`
- **Implements:** `Garnet.Composition.IFolder`, `Garnet.Composition.IReadOnlyFolder`, `System.IDisposable`, `Garnet.Composition.IStreamSource`

## Methods

### GetFiles

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] GetFiles(System.String, System.String)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` |  |
| `searchPattern` | `String` | No | `` |  |

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

### OpenWrite

**Signature:** `System.IO.Stream OpenWrite(System.String)`
**Return Type:** `Stream`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` |  |

---

### FlushChanged

**Signature:** `Void FlushChanged(System.Action`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`1` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---