# DispatcherDescriptor Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.DispatcherDescriptor`
- **Implements:** `System.IEquatable`1[[Garnet.Composition.DispatcherDescriptor, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Garnet.Composition.DispatcherDescriptor, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

## Methods

### get_DispatcherType

**Signature:** `Garnet.Composition.DispatcherType get_DispatcherType()`
**Return Type:** `DispatcherType`

---

### get_ThreadCount

**Signature:** `Int32 get_ThreadCount()`
**Return Type:** `Int32`

---

### get_Throughput

**Signature:** `Int32 get_Throughput()`
**Return Type:** `Int32`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Garnet.Composition.DispatcherDescriptor)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `DispatcherDescriptor` | No | `` |  |

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

### get_DefaultThreadCount (static)

**Signature:** `Int32 get_DefaultThreadCount()`
**Return Type:** `Int32`

---

### get_Background (static)

**Signature:** `Garnet.Composition.DispatcherDescriptor get_Background()`
**Return Type:** `DispatcherDescriptor`

---

### get_Foreground (static)

**Signature:** `Garnet.Composition.DispatcherDescriptor get_Foreground()`
**Return Type:** `DispatcherDescriptor`

---

### get_Dedicated (static)

**Signature:** `Garnet.Composition.DispatcherDescriptor get_Dedicated()`
**Return Type:** `DispatcherDescriptor`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.DispatcherDescriptor)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `DispatcherDescriptor` | No | `` |  |

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

### DispatcherType

**Type:** `DispatcherType` (read-only)

---

### ThreadCount

**Type:** `Int32` (read-only)

---

### Throughput

**Type:** `Int32` (read-only)

---

### DefaultThreadCount (static)

**Type:** `Int32` (read-only)

---

### Background (static)

**Type:** `DispatcherDescriptor` (read-only)

---

### Foreground (static)

**Type:** `DispatcherDescriptor` (read-only)

---

### Dedicated (static)

**Type:** `DispatcherDescriptor` (read-only)

---