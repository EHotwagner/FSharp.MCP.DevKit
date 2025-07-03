# SystemRegistry Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.SystemRegistry`

## Methods

### Contains

**Signature:** `Boolean Contains(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### Add

**Signature:** `System.IDisposable Add(System.String, Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,System.IDisposable])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `create` | `FSharpFunc`2` | No | `` |  |

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

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