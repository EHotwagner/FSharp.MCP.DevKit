# Entity`3 Struct

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Entity`3`
- **Base Type:** `System.ValueType`
- **Implements:** ``, `System.Collections.IStructuralEquatable`
- **Generic Parameters:** `<k, c, m>`

## Methods

### get_Id

**Signature:** `c get_Id()`
**Return Type:** `c`

---

### get_Components

**Signature:** `Garnet.Composition.ComponentStore`3[k,c,m] get_Components()`
**Return Type:** `ComponentStore`3`

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

### Add (generic)

**Signature:** `Void Add[a](a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `a` | No | `` |  |

---

### Set (generic)

**Signature:** `Void Set[a](a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `a` | No | `` |  |

---

### Remove (generic)

**Signature:** `Void Remove[a]()`
**Return Type:** `Void`

---

### Get (generic)

**Signature:** `a& Get[a]()`
**Return Type:** `a&`

---

### CopyTo (generic)

**Signature:** `Void CopyTo[a](c)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `destId` | `c` | No | `` |  |

---

### TryGet (generic)

**Signature:** `Boolean TryGet[a](a ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `a&` | No | `` |  |

---

### GetOrDefault (generic)

**Signature:** `a GetOrDefault[a](a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fallback` | `a` | No | `` |  |

---

### Has (generic)

**Signature:** `Boolean Has[a]()`
**Return Type:** `Boolean`

---

### Destroy

**Signature:** `Void Destroy()`
**Return Type:** `Void`

---

### With (generic)

**Signature:** `Garnet.Composition.Entity`3[k,c,m] With[a](a)`
**Return Type:** `Entity`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `a` | No | `` |  |

---

### Without (generic)

**Signature:** `Garnet.Composition.Entity`3[k,c,m] Without[a]()`
**Return Type:** `Entity`3`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Garnet.Composition.Entity`3[k,c,m])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Entity`3` | No | `` |  |

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

**Type:** `c` (read-only)

---

### Components

**Type:** `ComponentStore`3` (read-only)

---