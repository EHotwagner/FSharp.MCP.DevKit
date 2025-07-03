# Eid Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Eid`
- **Base Type:** `System.ValueType`
- **Implements:** `System.IEquatable`1[[Garnet.Composition.Eid, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Garnet.Composition.Eid, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

## Methods

### get_Value

**Signature:** `Int32 get_Value()`
**Return Type:** `Int32`

---

### CompareTo

**Signature:** `Int32 CompareTo(Garnet.Composition.Eid)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Eid` | No | `` |  |

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

### get_IsDefined

**Signature:** `Boolean get_IsDefined()`
**Return Type:** `Boolean`

---

### get_IsUndefined

**Signature:** `Boolean get_IsUndefined()`
**Return Type:** `Boolean`

---

### get_Index

**Signature:** `Int32 get_Index()`
**Return Type:** `Int32`

---

### get_Slot

**Signature:** `Int32 get_Slot()`
**Return Type:** `Int32`

---

### get_Gen

**Signature:** `Int32 get_Gen()`
**Return Type:** `Int32`

---

### get_Partition

**Signature:** `Int32 get_Partition()`
**Return Type:** `Int32`

---

### get_SegmentIndex

**Signature:** `Int32 get_SegmentIndex()`
**Return Type:** `Int32`

---

### get_ComponentIndex

**Signature:** `Int32 get_ComponentIndex()`
**Return Type:** `Int32`

---

### WithGen

**Signature:** `Garnet.Composition.Eid WithGen(Int32)`
**Return Type:** `Eid`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `gen` | `Int32` | No | `` |  |

---

### IncrementGen

**Signature:** `Garnet.Composition.Eid IncrementGen()`
**Return Type:** `Eid`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### ToPartString

**Signature:** `System.String ToPartString()`
**Return Type:** `String`

---

### get_Undefined (static)

**Signature:** `Garnet.Composition.Eid get_Undefined()`
**Return Type:** `Eid`

---

### SegmentToPartition (static) (generic)

**Signature:** `a SegmentToPartition[a](a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sid` | `a` | No | `` |  |

---

### SegmentToPartition$W (static) (generic)

**Signature:** `a SegmentToPartition$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,a]], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_RightShift` | `FSharpFunc`2` | No | `` |  |
| `sid` | `a` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.Eid)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Eid` | No | `` |  |

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

### Value

**Type:** `Int32` (read-only)

---

### IsDefined

**Type:** `Boolean` (read-only)

---

### IsUndefined

**Type:** `Boolean` (read-only)

---

### Index

**Type:** `Int32` (read-only)

---

### Slot

**Type:** `Int32` (read-only)

---

### Gen

**Type:** `Int32` (read-only)

---

### Partition

**Type:** `Int32` (read-only)

---

### SegmentIndex

**Type:** `Int32` (read-only)

---

### ComponentIndex

**Type:** `Int32` (read-only)

---

### Undefined (static)

**Type:** `Eid` (read-only)

---