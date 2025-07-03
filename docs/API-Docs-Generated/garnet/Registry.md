# Registry Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.Registry`
- **Implements:** `Garnet.Composition.IRegistry`

## Methods

### SetFactory (generic)

**Signature:** `Void SetFactory[a](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `create` | `FSharpFunc`2` | No | `` |  |

---

### Set (generic)

**Signature:** `Void Set[a](a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newValue` | `a` | No | `` |  |

---

### Get (generic)

**Signature:** `a& Get[a]()`
**Return Type:** `a&`

---

### TryGet (generic)

**Signature:** `Boolean TryGet[a](a ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `a&` | No | `` |  |

---

### Iter (generic)

**Signature:** `Void Iter[p](p, Garnet.Composition.IRegistryHandler`1[p])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `p` | No | `` |  |
| `handler` | `IRegistryHandler`1` | No | `` |  |

---

### Iter (generic)

**Signature:** `Void Iter[p](p, Garnet.Composition.IRegistryHandler`1[p], Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `param` | `p` | No | `` |  |
| `handler` | `IRegistryHandler`1` | No | `` |  |
| `offset` | `Int32` | No | `` |  |

---

### ToString

**Signature:** `Void ToString(Garnet.Composition.IStringBlockWriter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `IStringBlockWriter` | No | `` |  |

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---