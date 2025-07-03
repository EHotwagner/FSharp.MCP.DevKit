# Skippable Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.Skippable`

## Methods

### map (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[b] map[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,b], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### map2 (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[c] map2[a,b,c](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,c]], System.Text.Json.Serialization.Skippable`1[a], System.Text.Json.Serialization.Skippable`1[b])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `skippable1` | `Skippable`1` | No | `` |  |
| `skippable2` | `Skippable`1` | No | `` |  |

---

### map3 (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[d] map3[a,b,c,d](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,Microsoft.FSharp.Core.FSharpFunc`2[c,d]]], System.Text.Json.Serialization.Skippable`1[a], System.Text.Json.Serialization.Skippable`1[b], System.Text.Json.Serialization.Skippable`1[c])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `skippable1` | `Skippable`1` | No | `` |  |
| `skippable2` | `Skippable`1` | No | `` |  |
| `skippable3` | `Skippable`1` | No | `` |  |

---

### bind (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[b] bind[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,System.Text.Json.Serialization.Skippable`1[b]], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `binder` | `FSharpFunc`2` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### apply (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[b] apply[a,b](System.Text.Json.Serialization.Skippable`1[Microsoft.FSharp.Core.FSharpFunc`2[a,b]], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `Skippable`1` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### defaultValue (static) (generic)

**Signature:** `a defaultValue[a](a, System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `a` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### defaultWith (static) (generic)

**Signature:** `a defaultWith[a](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,a], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `valueThunk` | `FSharpFunc`2` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### orElse (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[a] orElse[a](System.Text.Json.Serialization.Skippable`1[a], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ifSkip` | `Skippable`1` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### toOption (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[a] toOption[a](System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skippable` | `Skippable`1` | No | `` |  |

---

### ofOption (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[a] ofOption[a](Microsoft.FSharp.Core.FSharpOption`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `option` | `FSharpOption`1` | No | `` |  |

---

### toValueOption (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpValueOption`1[a] toValueOption[a](System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `FSharpValueOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skippable` | `Skippable`1` | No | `` |  |

---

### ofValueOption (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[a] ofValueOption[a](Microsoft.FSharp.Core.FSharpValueOption`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `voption` | `FSharpValueOption`1` | No | `` |  |

---

### iter (static) (generic)

**Signature:** `Void iter[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### filter (static) (generic)

**Signature:** `System.Text.Json.Serialization.Skippable`1[a] filter[a](Microsoft.FSharp.Core.FSharpFunc`2[a,System.Boolean], System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Skippable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `skippable` | `Skippable`1` | No | `` |  |

---

### isSkip (static) (generic)

**Signature:** `Boolean isSkip[a](System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skippable` | `Skippable`1` | No | `` |  |

---

### isInclude (static) (generic)

**Signature:** `Boolean isInclude[a](System.Text.Json.Serialization.Skippable`1[a])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skippable` | `Skippable`1` | No | `` |  |

---