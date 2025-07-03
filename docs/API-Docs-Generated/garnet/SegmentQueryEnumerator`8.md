# SegmentQueryEnumerator`8 Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.SegmentQueryEnumerator`8`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IDisposable`, `System.Collections.IEnumerator`
- **Generic Parameters:** `<k, s1, s2, s3, s4, s5, s6, s7>`

## Methods

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

### GetValue1

**Signature:** `s1& GetValue1(Int32)`
**Return Type:** `s1&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetValue2

**Signature:** `s2& GetValue2(Int32)`
**Return Type:** `s2&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetValue3

**Signature:** `s3& GetValue3(Int32)`
**Return Type:** `s3&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetValue4

**Signature:** `s4& GetValue4(Int32)`
**Return Type:** `s4&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetValue5

**Signature:** `s5& GetValue5(Int32)`
**Return Type:** `s5&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetValue6

**Signature:** `s6& GetValue6(Int32)`
**Return Type:** `s6&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### GetValue7

**Signature:** `s7& GetValue7(Int32)`
**Return Type:** `s7&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### get_Mask

**Signature:** `UInt64 get_Mask()`
**Return Type:** `UInt64`

---

### get_Item

**Signature:** `System.ValueTuple`7[s1,s2,s3,s4,s5,s6,s7] get_Item(Int32)`
**Return Type:** `ValueTuple`7`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### get_Current

**Signature:** `System.ValueTuple`8[Garnet.Composition.SegmentDescriptor`1[k],Garnet.Composition.SegmentData`1[s1],Garnet.Composition.SegmentData`1[s2],Garnet.Composition.SegmentData`1[s3],Garnet.Composition.SegmentData`1[s4],Garnet.Composition.SegmentData`1[s5],Garnet.Composition.SegmentData`1[s6],System.ValueTuple`1[Garnet.Composition.SegmentData`1[s7]]] get_Current()`
**Return Type:** `ValueTuple`8`

---

### MoveNext

**Signature:** `Boolean MoveNext()`
**Return Type:** `Boolean`

---

### Reset

**Signature:** `Void Reset()`
**Return Type:** `Void`

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.SegmentQueryEnumerator`8[k,s1,s2,s3,s4,s5,s6,s7])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `SegmentQueryEnumerator`8` | No | `` |  |

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

### Mask

**Type:** `UInt64` (read-only)

---

### Item

**Type:** `ValueTuple`7` (read-only)

---

### Current

**Type:** `ValueTuple`8` (read-only)

---