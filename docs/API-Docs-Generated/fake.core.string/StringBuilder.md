# StringBuilder Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.StringBuilder`

FAKE's StringBuilder module.

## Methods

### append (static)

**Signature:** `System.Text.StringBuilder append(System.String, System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Description:** Appends a text to a StringBuilder.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### appendWithoutQuotes (static)

**Signature:** `System.Text.StringBuilder appendWithoutQuotes(System.String, System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Description:** Appends a text to a StringBuilder without surrounding quotes.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### appendIfSome (static) (generic)

**Signature:** `System.Text.StringBuilder appendIfSome[a](Microsoft.FSharp.Core.FSharpOption`1[a], Microsoft.FSharp.Core.FSharpFunc`2[a,System.String], System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `FSharpOption`1` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### appendIfTrue (static)

**Signature:** `System.Text.StringBuilder appendIfTrue(Boolean, System.String, System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Description:** Appends a text if the predicate is true.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `Boolean` | No | `` |  |
| `s` | `String` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### appendIfTrueWithoutQuotes (static)

**Signature:** `System.Text.StringBuilder appendIfTrueWithoutQuotes(Boolean, System.String, System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `Boolean` | No | `` |  |
| `s` | `String` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### appendIfFalse (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,System.Text.StringBuilder]] appendIfFalse(Boolean)`
**Return Type:** `FSharpFunc`2`

**Description:** Appends a text if the predicate is false.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `Boolean` | No | `` |  |

---

### appendWithoutQuotesIfNotNull (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,System.Text.StringBuilder] appendWithoutQuotesIfNotNull(System.Object, System.String)`
**Return Type:** `FSharpFunc`2`

**Description:** Appends a text without quoting if the value is not null.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |
| `s` | `String` | No | `` |  |

---

### appendIfNotNull (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,System.Text.StringBuilder] appendIfNotNull(System.Object, System.String)`
**Return Type:** `FSharpFunc`2`

**Description:** Appends a text if the value is not null.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |
| `s` | `String` | No | `` |  |

---

### appendQuotedIfNotNull (static)

**Signature:** `System.Text.StringBuilder appendQuotedIfNotNull(System.Object, System.String, System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Description:** Appends a quoted text if the value is not null.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |
| `s` | `String` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### appendStringIfValueIsNotNull (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,System.Text.StringBuilder]] appendStringIfValueIsNotNull[a](a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `a` | No | `` |  |

---

### appendStringIfValueIsNotNullOrEmpty (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,System.Text.StringBuilder]] appendStringIfValueIsNotNullOrEmpty(System.String)`
**Return Type:** `FSharpFunc`2`

**Description:** Appends a text if the value is not null or empty.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### appendIfNotNullOrEmpty (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,System.Text.StringBuilder] appendIfNotNullOrEmpty(System.String, System.String)`
**Return Type:** `FSharpFunc`2`

**Description:** Appends a text if the value is not null or empty.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `s` | `String` | No | `` |  |

---

### appendFileNamesIfNotNull (static)

**Signature:** `System.Text.StringBuilder appendFileNamesIfNotNull(System.Collections.Generic.IEnumerable`1[System.String], System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileNames` | `IEnumerable`1` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### forEach (static) (generic)

**Signature:** `System.Text.StringBuilder forEach[a,b,c](Microsoft.FSharp.Collections.FSharpList`1[a], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,Microsoft.FSharp.Core.FSharpFunc`2[System.Text.StringBuilder,c]]], b, System.Text.StringBuilder)`
**Return Type:** `StringBuilder`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `items` | `FSharpList`1` | No | `` |  |
| `action` | `FSharpFunc`2` | No | `` |  |
| `text` | `b` | No | `` |  |
| `builder` | `StringBuilder` | No | `` |  |

---

### toText (static)

**Signature:** `System.String toText(System.Text.StringBuilder)`
**Return Type:** `String`

**Description:** Returns the text from the StringBuilder

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `builder` | `StringBuilder` | No | `` |  |

---