# PrintfModule Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.PrintfModule`

Extensible printf-style formatting for numbers and other datatypes

## Methods

### PrintFormatToStringThen (static) (generic)

**Signature:** `T PrintFormatToStringThen[TResult,T](Microsoft.FSharp.Core.FSharpFunc`2[System.String,TResult], Microsoft.FSharp.Core.PrintfFormat`4[T,Microsoft.FSharp.Core.Unit,System.String,TResult])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `continuation` | `FSharpFunc`2` | No | `` |  |
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToStringThen (static) (generic)

**Signature:** `T PrintFormatToStringThen[T](Microsoft.FSharp.Core.PrintfFormat`4[T,Microsoft.FSharp.Core.Unit,System.String,System.String])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatThen (static) (generic)

**Signature:** `T PrintFormatThen[TResult,T](Microsoft.FSharp.Core.FSharpFunc`2[System.String,TResult], Microsoft.FSharp.Core.PrintfFormat`4[T,Microsoft.FSharp.Core.Unit,System.String,TResult])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `continuation` | `FSharpFunc`2` | No | `` |  |
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToStringBuilderThen (static) (generic)

**Signature:** `T PrintFormatToStringBuilderThen[TResult,T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TResult], System.Text.StringBuilder, Microsoft.FSharp.Core.PrintfFormat`4[T,System.Text.StringBuilder,Microsoft.FSharp.Core.Unit,TResult])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `continuation` | `FSharpFunc`2` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToTextWriterThen (static) (generic)

**Signature:** `T PrintFormatToTextWriterThen[TResult,T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TResult], System.IO.TextWriter, Microsoft.FSharp.Core.PrintfFormat`4[T,System.IO.TextWriter,Microsoft.FSharp.Core.Unit,TResult])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `continuation` | `FSharpFunc`2` | No | `` |  |
| `textWriter` | `TextWriter` | No | `` |  |
| `format` | `PrintfFormat`4` | No | `` |  |

---

### PrintFormatToStringBuilder (static) (generic)

**Signature:** `T PrintFormatToStringBuilder[T](System.Text.StringBuilder, Microsoft.FSharp.Core.PrintfFormat`4[T,System.Text.StringBuilder,Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `builder` | `StringBuilder` | No | `` |  |
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

### PrintFormatToStringThenFail (static) (generic)

**Signature:** `T PrintFormatToStringThenFail[T,TResult](Microsoft.FSharp.Core.PrintfFormat`4[T,Microsoft.FSharp.Core.Unit,System.String,TResult])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
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