# Array2DModule Class

**Namespace:** `Microsoft.FSharp.Collections`
**Full Name:** `Microsoft.FSharp.Collections.Array2DModule`

Contains operations for working with 2-dimensional arrays.

## Methods

### Length1 (static) (generic)

**Signature:** `Int32 Length1[T](T[,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |

---

### Length2 (static) (generic)

**Signature:** `Int32 Length2[T](T[,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |

---

### Base1 (static) (generic)

**Signature:** `Int32 Base1[T](T[,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |

---

### Base2 (static) (generic)

**Signature:** `Int32 Base2[T](T[,])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |

---

### Get (static) (generic)

**Signature:** `T Get[T](T[,], Int32, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |
| `index1` | `Int32` | No | `` |  |
| `index2` | `Int32` | No | `` |  |

---

### Set (static) (generic)

**Signature:** `Void Set[T](T[,], Int32, Int32, T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |
| `index1` | `Int32` | No | `` |  |
| `index2` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ZeroCreate (static) (generic)

**Signature:** `T[,] ZeroCreate[T](Int32, Int32)`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |

---

### ZeroCreateBased (static) (generic)

**Signature:** `T[,] ZeroCreateBased[T](Int32, Int32, Int32, Int32)`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `base1` | `Int32` | No | `` |  |
| `base2` | `Int32` | No | `` |  |
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |

---

### CreateBased (static) (generic)

**Signature:** `T[,] CreateBased[T](Int32, Int32, Int32, Int32, T)`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `base1` | `Int32` | No | `` |  |
| `base2` | `Int32` | No | `` |  |
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `initial` | `T` | No | `` |  |

---

### InitializeBased (static) (generic)

**Signature:** `T[,] InitializeBased[T](Int32, Int32, Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]])`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `base1` | `Int32` | No | `` |  |
| `base2` | `Int32` | No | `` |  |
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `initializer` | `FSharpFunc`2` | No | `` |  |

---

### Create (static) (generic)

**Signature:** `T[,] Create[T](Int32, Int32, T)`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Initialize (static) (generic)

**Signature:** `T[,] Initialize[T](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]])`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length1` | `Int32` | No | `` |  |
| `length2` | `Int32` | No | `` |  |
| `initializer` | `FSharpFunc`2` | No | `` |  |

---

### Iterate (static) (generic)

**Signature:** `Void Iterate[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit], T[,])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[,]` | No | `` |  |

---

### IterateIndexed (static) (generic)

**Signature:** `Void IterateIndexed[T](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit]]], T[,])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[,]` | No | `` |  |

---

### Map (static) (generic)

**Signature:** `TResult[,] Map[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T[,])`
**Return Type:** `TResult[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[,]` | No | `` |  |

---

### MapIndexed (static) (generic)

**Signature:** `TResult[,] MapIndexed[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[T,TResult]]], T[,])`
**Return Type:** `TResult[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `array` | `T[,]` | No | `` |  |

---

### Copy (static) (generic)

**Signature:** `T[,] Copy[T](T[,])`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |

---

### Rebase (static) (generic)

**Signature:** `T[,] Rebase[T](T[,])`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `T[,]` | No | `` |  |

---

### CopyTo (static) (generic)

**Signature:** `Void CopyTo[T](T[,], Int32, Int32, T[,], Int32, Int32, Int32, Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `T[,]` | No | `` |  |
| `sourceIndex1` | `Int32` | No | `` |  |
| `sourceIndex2` | `Int32` | No | `` |  |
| `target` | `T[,]` | No | `` |  |
| `targetIndex1` | `Int32` | No | `` |  |
| `targetIndex2` | `Int32` | No | `` |  |
| `count1` | `Int32` | No | `` |  |
| `count2` | `Int32` | No | `` |  |

---