# FuncConvert Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.FuncConvert`

Helper functions for converting F# first class function values to and from CLI representations
 of functions using delegates.

## Methods

### ToFSharpFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit] ToFSharpFunc[T](System.Action`1[T])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`1` | No | `` |  |

---

### ToFSharpFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T,TResult] ToFSharpFunc[T,TResult](System.Converter`2[T,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `converter` | `Converter`2` | No | `` |  |

---

### FromFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T] FromFunc[T](System.Func`1[T])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `Func`1` | No | `` |  |

---

### FromFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T,TResult] FromFunc[T,TResult](System.Func`2[T,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `Func`2` | No | `` |  |

---

### FromFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]] FromFunc[T1,T2,TResult](System.Func`3[T1,T2,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `Func`3` | No | `` |  |

---

### FromFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]] FromFunc[T1,T2,T3,TResult](System.Func`4[T1,T2,T3,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `Func`4` | No | `` |  |

---

### FromFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.FSharpFunc`2[T4,TResult]]]] FromFunc[T1,T2,T3,T4,TResult](System.Func`5[T1,T2,T3,T4,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `Func`5` | No | `` |  |

---

### FromFunc (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.FSharpFunc`2[T4,Microsoft.FSharp.Core.FSharpFunc`2[T5,TResult]]]]] FromFunc[T1,T2,T3,T4,T5,TResult](System.Func`6[T1,T2,T3,T4,T5,TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `Func`6` | No | `` |  |

---

### FromAction (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit] FromAction(System.Action)`
**Return Type:** `FSharpFunc`2`

**Description:** Convert the given Action delegate object to an F# function value

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action` | No | `` | The input Action delegate. |

**Returns:** The F# function.

---

### FromAction (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.Unit] FromAction[T](System.Action`1[T])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`1` | No | `` |  |

---

### FromAction (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.Unit]] FromAction[T1,T2](System.Action`2[T1,T2])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`2` | No | `` |  |

---

### FromAction (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.Unit]]] FromAction[T1,T2,T3](System.Action`3[T1,T2,T3])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`3` | No | `` |  |

---

### FromAction (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.FSharpFunc`2[T4,Microsoft.FSharp.Core.Unit]]]] FromAction[T1,T2,T3,T4](System.Action`4[T1,T2,T3,T4])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`4` | No | `` |  |

---

### FromAction (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.FSharpFunc`2[T4,Microsoft.FSharp.Core.FSharpFunc`2[T5,Microsoft.FSharp.Core.Unit]]]]] FromAction[T1,T2,T3,T4,T5](System.Action`5[T1,T2,T3,T4,T5])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `Action`5` | No | `` |  |

---

### FuncFromTupled (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]] FuncFromTupled[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`2[T1,T2],TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |

---

### FuncFromTupled (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]] FuncFromTupled[T1,T2,T3,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[T1,T2,T3],TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |

---

### FuncFromTupled (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.FSharpFunc`2[T4,TResult]]]] FuncFromTupled[T1,T2,T3,T4,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`4[T1,T2,T3,T4],TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |

---

### FuncFromTupled (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,Microsoft.FSharp.Core.FSharpFunc`2[T4,Microsoft.FSharp.Core.FSharpFunc`2[T5,TResult]]]]] FuncFromTupled[T1,T2,T3,T4,T5,TResult](Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`5[T1,T2,T3,T4,T5],TResult])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |

---