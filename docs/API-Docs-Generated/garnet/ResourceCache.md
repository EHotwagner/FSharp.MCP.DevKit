# ResourceCache Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ResourceCache`
- **Implements:** `System.IDisposable`, `Garnet.Composition.IResourceCache`

## Methods

### SetFolder

**Signature:** `Void SetFolder(Garnet.Composition.IReadOnlyFolder)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newFolder` | `IReadOnlyFolder` | No | `` |  |

---

### AddLoader

**Signature:** `Void AddLoader(System.String, Garnet.Composition.IResourceLoader)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `extension` | `String` | No | `` |  |
| `typeLoader` | `IResourceLoader` | No | `` |  |

---

### AddResource (generic)

**Signature:** `Void AddResource[b](System.String, b)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` |  |
| `resource` | `b` | No | `` |  |

---

### TryGetResource (generic)

**Signature:** `Boolean TryGetResource[a](System.String, a ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` |  |
| `value` | `a&` | No | `` |  |

---

### LoadResource (generic)

**Signature:** `a LoadResource[a](System.String)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `String` | No | `` |  |

---

### LoadAll

**Signature:** `Void LoadAll(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

---