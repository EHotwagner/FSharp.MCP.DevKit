# IReadOnlyFolder Interface

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.IReadOnlyFolder`
- **Implements:** `System.IDisposable`, `Garnet.Composition.IStreamSource`

## Methods

### GetFiles

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] GetFiles(System.String, System.String)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `String` | No | `` |  |
| `` | `String` | No | `` |  |

---

### Contains

**Signature:** `Boolean Contains(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `String` | No | `` |  |

---

### FlushChanged

**Signature:** `Void FlushChanged(System.Action`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `Action`1` | No | `` |  |

---