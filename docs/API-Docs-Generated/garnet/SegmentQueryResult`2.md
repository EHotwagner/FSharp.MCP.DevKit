# SegmentQueryResult`2 Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.SegmentQueryResult`2`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<k, s1>`

## Methods

### get_Id

**Signature:** `k get_Id()`
**Return Type:** `k`

---

### get_Mask

**Signature:** `UInt64 get_Mask()`
**Return Type:** `UInt64`

---

### get_Segment

**Signature:** `Garnet.Composition.SegmentData`1[s1] get_Segment()`
**Return Type:** `SegmentData`1`

---

### CompareTo

**Signature:** `Int32 CompareTo(Garnet.Composition.SegmentQueryResult`2[k,s1])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `SegmentQueryResult`2` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Object)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Object, System.Collections.IComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode(System.Collections.IEqualityComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IEqualityComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Object, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### get_Indices

**Signature:** `Garnet.Composition.MaskEnumerable get_Indices()`
**Return Type:** `MaskEnumerable`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.SegmentQueryResult`2[k,s1])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `SegmentQueryResult`2` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

## Properties

### Id

**Type:** `k` (read-only)

---

### Mask

**Type:** `UInt64` (read-only)

---

### Segment

**Type:** `SegmentData`1` (read-only)

---

### Indices

**Type:** `MaskEnumerable` (read-only)

---