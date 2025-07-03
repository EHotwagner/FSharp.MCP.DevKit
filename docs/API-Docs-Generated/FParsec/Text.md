# Text Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.Text`

## Methods

### FoldCase (static)

**Signature:** `System.String FoldCase(System.String)`
**Return Type:** `String`

**Description:** Returns a case-folded copy of the string argument. All chars are mapped
            using the (non-Turkic) 1-to-1 case folding mappings (v. 6.0) for Unicode code
            points in the Basic Multilingual Plane, i.e. code points below 0x10000.
            If the argument is null, null is returned.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### FoldCase (static)

**Signature:** `Char FoldCase(Char)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---

### NormalizeNewlines (static)

**Signature:** `System.String NormalizeNewlines(System.String)`
**Return Type:** `String`

**Description:** Returns the given string with all occurrences of "\r\n" and "\r" replaced
            by "\n". If the argument is null, null is returned.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### CountTextElements (static)

**Signature:** `Int32 CountTextElements(System.String)`
**Return Type:** `Int32`

**Description:** A faster implementation of System.Globalization.StringInfo(str).LengthInTextElements.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### IsSurrogate (static)

**Signature:** `Boolean IsSurrogate(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---

### IsHighSurrogate (static)

**Signature:** `Boolean IsHighSurrogate(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---

### IsLowSurrogate (static)

**Signature:** `Boolean IsLowSurrogate(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---

### IsWhitespace (static)

**Signature:** `Boolean IsWhitespace(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---