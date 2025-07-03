# ComponentStore`3 Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ComponentStore`3`
- **Implements:** ``, ``
- **Generic Parameters:** `<k, c, m>`

## Methods

### get_Segments

**Signature:** `Garnet.Composition.SegmentStore`1[k] get_Segments()`
**Return Type:** `SegmentStore`1`

---

### GetSegments (generic)

**Signature:** `Garnet.Composition.Segments`2[k,a] GetSegments[a]()`
**Return Type:** `Segments`2`

---

### GetComponents (generic)

**Signature:** `Garnet.Composition.Components`4[k,c,m,a] GetComponents[a]()`
**Return Type:** `Components`4`

---

### Clear

**Signature:** `Void Clear()`
**Return Type:** `Void`

---

### Handle (generic)

**Signature:** `Void Handle[a](a, c, Garnet.Composition.ISegmentHandler`2[a,k])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `a` | No | `` |  |
| `id` | `c` | No | `` |  |
| `handler` | `ISegmentHandler`2` | No | `` |  |

---

### Handle (generic)

**Signature:** `Void Handle[a](a, k, UInt64, Garnet.Composition.ISegmentHandler`2[a,k])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `a` | No | `` |  |
| `sid` | `k` | No | `` |  |
| `mask` | `UInt64` | No | `` |  |
| `handler` | `ISegmentHandler`2` | No | `` |  |

---

### Handle (generic)

**Signature:** `Void Handle[a](a, Garnet.Composition.ISegmentListHandler`2[a,k])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `a` | No | `` |  |
| `handler` | `ISegmentListHandler`2` | No | `` |  |

---

### Destroy

**Signature:** `Void Destroy(c)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `c` | No | `` |  |

---

### Commit

**Signature:** `Void Commit()`
**Return Type:** `Void`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Get

**Signature:** `Garnet.Composition.Entity`3[k,c,m] Get(c)`
**Return Type:** `Entity`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `c` | No | `` |  |

---

## Properties

### Segments

**Type:** `SegmentStore`1` (read-only)

---