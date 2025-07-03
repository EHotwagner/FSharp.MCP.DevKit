# ActorSystemConfiguration Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ActorSystemConfiguration`
- **Implements:** `System.IEquatable`1[[Garnet.Composition.ActorSystemConfiguration, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Garnet.Composition.ActorSystemConfiguration, Garnet, Version=0.5.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

## Methods

### get_Dispatchers

**Signature:** `Garnet.Composition.DispatcherDescriptor[] get_Dispatchers()`
**Return Type:** `DispatcherDescriptor[]`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Garnet.Composition.ActorSystemConfiguration)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ActorSystemConfiguration` | No | `` |  |

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

### get_SingleThread (static)

**Signature:** `Garnet.Composition.ActorSystemConfiguration get_SingleThread()`
**Return Type:** `ActorSystemConfiguration`

---

### Create (static)

**Signature:** `Garnet.Composition.ActorSystemConfiguration Create(Int32)`
**Return Type:** `ActorSystemConfiguration`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `workerCount` | `Int32` | No | `` |  |

---

### get_Default (static)

**Signature:** `Garnet.Composition.ActorSystemConfiguration get_Default()`
**Return Type:** `ActorSystemConfiguration`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.ActorSystemConfiguration)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ActorSystemConfiguration` | No | `` |  |

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

### Dispatchers

**Type:** `DispatcherDescriptor[]` (read-only)

---

### SingleThread (static)

**Type:** `ActorSystemConfiguration` (read-only)

---

### Default (static)

**Type:** `ActorSystemConfiguration` (read-only)

---