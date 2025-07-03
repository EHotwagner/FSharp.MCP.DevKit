# IdentifierValidator Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.IdentifierValidator`

## Methods

### get_NormalizationForm

**Signature:** `System.Text.NormalizationForm get_NormalizationForm()`
**Return Type:** `NormalizationForm`

---

### set_NormalizationForm

**Signature:** `Void set_NormalizationForm(System.Text.NormalizationForm)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `NormalizationForm` | No | `` |  |

---

### get_NormalizeBeforeValidation

**Signature:** `Boolean get_NormalizeBeforeValidation()`
**Return Type:** `Boolean`

---

### set_NormalizeBeforeValidation

**Signature:** `Void set_NormalizeBeforeValidation(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_AllowJoinControlCharsAsIdContinueChars

**Signature:** `Boolean get_AllowJoinControlCharsAsIdContinueChars()`
**Return Type:** `Boolean`

---

### set_AllowJoinControlCharsAsIdContinueChars

**Signature:** `Void set_AllowJoinControlCharsAsIdContinueChars(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### SetIsAsciiNoIdChar

**Signature:** `Void SetIsAsciiNoIdChar(Char)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asciiChar` | `Char` | No | `` |  |

---

### SetIsAsciiIdStartChar

**Signature:** `Void SetIsAsciiIdStartChar(Char)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asciiChar` | `Char` | No | `` |  |

---

### SetIsAsciiIdNonStartChar

**Signature:** `Void SetIsAsciiIdNonStartChar(Char)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asciiChar` | `Char` | No | `` |  |

---

### ValidateAndNormalize

**Signature:** `System.String ValidateAndNormalize(System.String, Int32 ByRef)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |
| `errorPosition` | `Int32&` | No | `` |  |

---

### get_IsIdStartOrSurrogateFunc

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean] get_IsIdStartOrSurrogateFunc()`
**Return Type:** `FSharpFunc`2`

---

### get_IsIdContinueOrSurrogateFunc

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean] get_IsIdContinueOrSurrogateFunc()`
**Return Type:** `FSharpFunc`2`

---

### get_IsIdContinueOrJoinControlOrSurrogateFunc

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean] get_IsIdContinueOrJoinControlOrSurrogateFunc()`
**Return Type:** `FSharpFunc`2`

---

### IsXIdStartOrSurrogate (static)

**Signature:** `Boolean IsXIdStartOrSurrogate(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `bmpCodePoint` | `Char` | No | `` |  |

---

### IsXIdContinueOrSurrogate (static)

**Signature:** `Boolean IsXIdContinueOrSurrogate(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `bmpCodePoint` | `Char` | No | `` |  |

---

### IsXIdContinueOrJoinControlOrSurrogate (static)

**Signature:** `Boolean IsXIdContinueOrJoinControlOrSurrogate(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `bmpCodePoint` | `Char` | No | `` |  |

---

### IsXIdStartSmp (static)

**Signature:** `Boolean IsXIdStartSmp(Int32)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `smpCodePointMinus0x10000` | `Int32` | No | `` |  |

---

### IsXIdContinueSmp (static)

**Signature:** `Boolean IsXIdContinueSmp(Int32)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `smpCodePointMinus0x10000` | `Int32` | No | `` |  |

---

## Properties

### NormalizationForm

**Type:** `NormalizationForm` (read/write)

---

### NormalizeBeforeValidation

**Type:** `Boolean` (read/write)

---

### AllowJoinControlCharsAsIdContinueChars

**Type:** `Boolean` (read/write)

---

### IsIdStartOrSurrogateFunc

**Type:** `FSharpFunc`2` (read-only)

---

### IsIdContinueOrSurrogateFunc

**Type:** `FSharpFunc`2` (read-only)

---

### IsIdContinueOrJoinControlOrSurrogateFunc

**Type:** `FSharpFunc`2` (read-only)

---