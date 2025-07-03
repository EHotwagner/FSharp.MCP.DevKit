# SegmentQueryEnumerator`2 Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.SegmentQueryEnumerator`2`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`, ``, `System.IDisposable`, `System.Collections.IEnumerator`
- **Generic Parameters:** `<k, s1>`

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

### get_Mask

**Signature:** `UInt64 get_Mask()`
**Return Type:** `UInt64`

---

### get_Item

**Signature:** `s1& get_Item(Int32)`
**Return Type:** `s1&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `i` | `Int32` | No | `` |  |

---

### get_Current

**Signature:** `System.ValueTuple`2[Garnet.Composition.SegmentDescriptor`1[k],Garnet.Composition.SegmentData`1[s1]] get_Current()`
**Return Type:** `ValueTuple`2`

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

**Signature:** `Boolean Equals(Garnet.Composition.SegmentQueryEnumerator`2[k,s1])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `SegmentQueryEnumerator`2` | No | `` |  |

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

**Type:** `s1&` (read-only)

---

### Current

**Type:** `ValueTuple`2` (read-only)

---