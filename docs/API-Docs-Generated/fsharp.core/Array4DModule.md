# Array4DModule Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.Array4DModule`

Contains operations for working with rank 4 arrays.

## Methods

### Length1 (static) (generic)

**Signature:** `Int32 Length1[T](T[,,,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,,,]` | No | `` |  |

---

### Length2 (static) (generic)

**Signature:** `Int32 Length2[T](T[,,,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,,,]` | No | `` |  |

---

### Length3 (static) (generic)

**Signature:** `Int32 Length3[T](T[,,,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,,,]` | No | `` |  |

---

### Length4 (static) (generic)

**Signature:** `Int32 Length4[T](T[,,,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,,,]` | No | `` |  |

---

### ZeroCreate (static) (generic)

**Signature:** `T[,,,] ZeroCreate[T](Int32, Int32, Int32, Int32)`
**Return Type:** `T[,,,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `length3` | `Int32` | No | `` |  |
| `length4` | `Int32` | No | `` |  |

---

### Create (static) (generic)

**Signature:** `T[,,,] Create[T](Int32, Int32, Int32, Int32, T)`
**Return Type:** `T[,,,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `length3` | `Int32` | No | `` |  |
| `length4` | `Int32` | No | `` |  |
| `initial` | `T` | No | `` |  |

---

### Initialize (static) (generic)

**Signature:** `T[,,,] Initialize[T](Int32, Int32, Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]]]])`
**Return Type:** `T[,,,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `length3` | `Int32` | No | `` |  |
| `length4` | `Int32` | No | `` |  |
| `initializer` | `FSharpFunc`2` | No | `` |  |

---

### Get (static) (generic)

**Signature:** `T Get[T](T[,,,], Int32, Int32, Int32, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,,,]` | No | `` |  |
| `index1` | `Int32` | No | `` |  |
| `index2` | `Int32` | No | `` |  |
| `index3` | `Int32` | No | `` |  |
| `index4` | `Int32` | No | `` |  |

---

### Set (static) (generic)

**Signature:** `Void Set[T](T[,,,], Int32, Int32, Int32, Int32, T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,,,]` | No | `` |  |
| `index1` | `Int32` | No | `` |  |
| `index2` | `Int32` | No | `` |  |
| `index3` | `Int32` | No | `` |  |
| `index4` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---