# MemoryStreamLookup`1 Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.MemoryStreamLookup`1`
- **Generic Parameters:** `<k>`

## Methods

### OpenWrite

**Signature:** `System.IO.Stream OpenWrite(k)`
**Return Type:** `Stream`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `k` | No | `` |  |

---

### GetKeys

**Signature:** `System.Collections.Generic.IEnumerable`1[k] GetKeys()`
**Return Type:** `IEnumerable`1`

---

### Contains

**Signature:** `Boolean Contains(k)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `k` | No | `` |  |

---

### TryOpen

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[System.IO.Stream] TryOpen(k)`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `k` | No | `` |  |

---

### FlushChanged

**Signature:** `Void FlushChanged(System.Action`1[k])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`1` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---