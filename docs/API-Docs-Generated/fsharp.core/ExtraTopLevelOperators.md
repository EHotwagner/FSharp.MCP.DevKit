# ExtraTopLevelOperators Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.ExtraTopLevelOperators`

A set of extra operators and functions. This module is automatically opened in all F# code.

## Methods

### CreateSet (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpSet`1[T] CreateSet[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `FSharpSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `IEnumerable`1` | No | `` |  |

---

### CreateDictionary (static) (generic)

**Signature:** `System.Collections.Generic.IDictionary`2[TKey,TValue] CreateDictionary[TKey,TValue](System.Collections.Generic.IEnumerable`1[System.Tuple`2[TKey,TValue]])`
**Return Type:** `IDictionary`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `keyValuePairs` | `IEnumerable`1` | No | `` |  |

---

### CreateReadOnlyDictionary (static) (generic)

**Signature:** `System.Collections.Generic.IReadOnlyDictionary`2[TKey,TValue] CreateReadOnlyDictionary[TKey,TValue](System.Collections.Generic.IEnumerable`1[System.Tuple`2[TKey,TValue]])`
**Return Type:** `IReadOnlyDictionary`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `keyValuePairs` | `IEnumerable`1` | No | `` |  |

---

### CreateArray2D (static) (generic)

**Signature:** `T[,] CreateArray2D[a,T](System.Collections.Generic.IEnumerable`1[a])`
**Return Type:** `T[,]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `rows` | `IEnumerable`1` | No | `` |  |

---

### PrintFormatToString (static) (generic)

**Signature:** `T PrintFormatToString[T](Microsoft.FSharp.Core.PrintfFormat`4[T,Microsoft.FSharp.Core.Unit,System.String,System.String])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToStringThenFail (static) (generic)

**Signature:** `T PrintFormatToStringThenFail[T,TResult](Microsoft.FSharp.Core.PrintfFormat`4[T,Microsoft.FSharp.Core.Unit,System.String,TResult])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToTextWriter (static) (generic)

**Signature:** `T PrintFormatToTextWriter[T](System.IO.TextWriter, Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `textWriter` | `TextWriter` | No | `` |  |
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatLineToTextWriter (static) (generic)

**Signature:** `T PrintFormatLineToTextWriter[T](System.IO.TextWriter, Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `textWriter` | `TextWriter` | No | `` |  |
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormat (static) (generic)

**Signature:** `T PrintFormat[T](Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToError (static) (generic)

**Signature:** `T PrintFormatToError[T](Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatLine (static) (generic)

**Signature:** `T PrintFormatLine[T](Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatLineToError (static) (generic)

**Signature:** `T PrintFormatLineToError[T](Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### get_DefaultAsyncBuilder (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsyncBuilder get_DefaultAsyncBuilder()`
**Return Type:** `FSharpAsyncBuilder`

---

### ToSingle (static) (generic)

**Signature:** `Single ToSingle[T](T)`
**Return Type:** `Single`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToSingle$W (static) (generic)

**Signature:** `Single ToSingle$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Single], T)`
**Return Type:** `Single`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToDouble (static) (generic)

**Signature:** `Double ToDouble[T](T)`
**Return Type:** `Double`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToDouble$W (static) (generic)

**Signature:** `Double ToDouble$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Double], T)`
**Return Type:** `Double`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToByte (static) (generic)

**Signature:** `Byte ToByte[T](T)`
**Return Type:** `Byte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToByte$W (static) (generic)

**Signature:** `Byte ToByte$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Byte], T)`
**Return Type:** `Byte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToSByte (static) (generic)

**Signature:** `SByte ToSByte[T](T)`
**Return Type:** `SByte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToSByte$W (static) (generic)

**Signature:** `SByte ToSByte$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.SByte], T)`
**Return Type:** `SByte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### SpliceExpression (static) (generic)

**Signature:** `T SpliceExpression[T](Microsoft.FSharp.Quotations.FSharpExpr`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `expression` | `FSharpExpr`1` | No | `` |  |

---

### SpliceUntypedExpression (static) (generic)

**Signature:** `T SpliceUntypedExpression[T](Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `expression` | `FSharpExpr` | No | `` |  |

---

### LazyPattern (static) (generic)

**Signature:** `T LazyPattern[T](System.Lazy`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `Lazy`1` | No | `` |  |

---

### get_query (static)

**Signature:** `Microsoft.FSharp.Linq.QueryBuilder get_query()`
**Return Type:** `QueryBuilder`

---

## Properties

### DefaultAsyncBuilder (static)

**Type:** `FSharpAsyncBuilder` (read-only)

**Description:** Builds an asynchronous workflow using computation expression syntax.

---

### query (static)

**Type:** `QueryBuilder` (read-only)

**Description:** Builds a query using query syntax and operators.

---