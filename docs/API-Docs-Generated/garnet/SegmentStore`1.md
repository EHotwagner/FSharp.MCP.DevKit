# SegmentStore`1 Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.SegmentStore`1`
- **Implements:** ``
- **Generic Parameters:** `<k>`

## Methods

### GetSegments (generic)

**Signature:** `Garnet.Composition.Segments`2[k,a] GetSegments[a]()`
**Return Type:** `Segments`2`

---

### Clear

**Signature:** `Void Clear()`
**Return Type:** `Void`

---

### Remove

**Signature:** `Void Remove(k, UInt64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |
| `mask` | `UInt64` | No | `` |  |

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

### Commit

**Signature:** `Void Commit()`
**Return Type:** `Void`

---

### ApplyRemovalsFrom (generic)

**Signature:** `Void ApplyRemovalsFrom[a](Garnet.Composition.Segments`2[k,a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `segments` | `Segments`2` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---