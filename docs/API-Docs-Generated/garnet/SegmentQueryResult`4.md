# SegmentQueryResult`4 Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.SegmentQueryResult`4`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IComparable`, `System.Collections.IStructuralComparable`
- **Generic Parameters:** `<k, s1, s2, s3>`

## Methods

### get_Id

**Signature:** `k get_Id()`
**Return Type:** `k`

---

### get_Mask

**Signature:** `UInt64 get_Mask()`
**Return Type:** `UInt64`

---

### get_Segment1

**Signature:** `Garnet.Composition.SegmentData`1[s1] get_Segment1()`
**Return Type:** `SegmentData`1`

---

### get_Segment2

**Signature:** `Garnet.Composition.SegmentData`1[s2] get_Segment2()`
**Return Type:** `SegmentData`1`

---

### get_Segment3

**Signature:** `Garnet.Composition.SegmentData`1[s3] get_Segment3()`
**Return Type:** `SegmentData`1`

---

### CompareTo

**Signature:** `Int32 CompareTo(Garnet.Composition.SegmentQueryResult`4[k,s1,s2,s3])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `SegmentQueryResult`4` | No | `` |  |

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

### get_Segments

**Signature:** `System.ValueTuple`3[Garnet.Composition.SegmentData`1[s1],Garnet.Composition.SegmentData`1[s2],Garnet.Composition.SegmentData`1[s3]] get_Segments()`
**Return Type:** `ValueTuple`3`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.SegmentQueryResult`4[k,s1,s2,s3])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `SegmentQueryResult`4` | No | `` |  |

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

### Segment1

**Type:** `SegmentData`1` (read-only)

---

### Segment2

**Type:** `SegmentData`1` (read-only)

---

### Segment3

**Type:** `SegmentData`1` (read-only)

---

### Indices

**Type:** `MaskEnumerable` (read-only)

---

### Segments

**Type:** `ValueTuple`3` (read-only)

---