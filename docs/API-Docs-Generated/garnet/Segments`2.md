# Segments`2 Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Segments`2`
- **Implements:** ``
- **Generic Parameters:** `<k, a>`

## Methods

### GetSpan

**Signature:** `System.ReadOnlySpan`1[Garnet.Composition.Segment`2[k,a]] GetSpan()`
**Return Type:** `ReadOnlySpan`1`

---

### GetMemory

**Signature:** `System.ReadOnlyMemory`1[Garnet.Composition.Segment`2[k,a]] GetMemory()`
**Return Type:** `ReadOnlyMemory`1`

---

### get_Count

**Signature:** `Int32 get_Count()`
**Return Type:** `Int32`

---

### get_Item

**Signature:** `Garnet.Composition.Segment`2[k,a] get_Item(Int32)`
**Return Type:** `Segment`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetComponentCount

**Signature:** `Int32 GetComponentCount()`
**Return Type:** `Int32`

---

### TryFind

**Signature:** `Boolean TryFind(k, Int32 ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |
| `i` | `Int32&` | No | `` |  |

---

### Clear

**Signature:** `Void Clear()`
**Return Type:** `Void`

---

### Set

**Signature:** `a[] Set(k, UInt64)`
**Return Type:** `a[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |
| `mask` | `UInt64` | No | `` |  |

---

### Add

**Signature:** `a[] Add(k, UInt64)`
**Return Type:** `a[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |
| `mask` | `UInt64` | No | `` |  |

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

### Commit

**Signature:** `Void Commit()`
**Return Type:** `Void`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### GetMask

**Signature:** `UInt64 GetMask(k)`
**Return Type:** `UInt64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |

---

### Contains

**Signature:** `Boolean Contains(k)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |

---

### Get

**Signature:** `Garnet.Composition.Segment`2[k,a] Get(k)`
**Return Type:** `Segment`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |

---

### Remove

**Signature:** `Void Remove(k)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |

---

### RemoveAll

**Signature:** `Void RemoveAll()`
**Return Type:** `Void`

---

### GetSegmentOrEmpty

**Signature:** `Garnet.Composition.Segment`2[k,a] GetSegmentOrEmpty(k)`
**Return Type:** `Segment`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |

---

### Find

**Signature:** `Int32 Find(k)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `k` | No | `` |  |

---

## Properties

### Count

**Type:** `Int32` (read-only)

---

### Item

**Type:** `Segment`2` (read-only)

---