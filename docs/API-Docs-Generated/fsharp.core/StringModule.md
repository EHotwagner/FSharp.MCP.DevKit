# StringModule Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.StringModule`

Functional programming operators for string processing.  Further string operations
 are available via the member functions on strings and other functionality in
  System.String
 and System.Text.RegularExpressions types.

## Methods

### Length (static)

**Signature:** `Int32 Length(System.String)`
**Return Type:** `Int32`

**Description:** Returns the length of the string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` | The input string. |

**Returns:** The number of characters in the string.

---

### Concat (static)

**Signature:** `System.String Concat(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sep` | `String` | No | `` |  |
| `strings` | `IEnumerable`1` | No | `` |  |

---

### Iterate (static)

**Signature:** `Void Iterate(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,Microsoft.FSharp.Core.Unit], System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### IterateIndexed (static)

**Signature:** `Void IterateIndexed(Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Char,Microsoft.FSharp.Core.Unit]], System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `action` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### Map (static)

**Signature:** `System.String Map(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Char], System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### MapIndexed (static)

**Signature:** `System.String MapIndexed(Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Char]], System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### Filter (static)

**Signature:** `System.String Filter(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### Collect (static)

**Signature:** `System.String Collect(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.String], System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `mapping` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### Initialize (static)

**Signature:** `System.String Initialize(Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |
| `initializer` | `FSharpFunc`2` | No | `` |  |

---

### Replicate (static)

**Signature:** `System.String Replicate(Int32, System.String)`
**Return Type:** `String`

**Description:** Returns a string by concatenating count instances of str.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` | The number of copies of the input string will be copied. |
| `str` | `String` | No | `` | The input string. |

**Returns:** The concatenated string.

---

### ForAll (static)

**Signature:** `Boolean ForAll(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---

### Exists (static)

**Signature:** `Boolean Exists(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `predicate` | `FSharpFunc`2` | No | `` |  |
| `str` | `String` | No | `` |  |

---