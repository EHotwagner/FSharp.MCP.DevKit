# Templates Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.Templates`

Contains basic templating functions. Used in other helpers.

## Methods

### load (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.Collections.Generic.IEnumerable`1[System.String]]] load(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `seq` | `IEnumerable`1` | No | `` |  |

---

### replaceKeywords (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Collections.Generic.IEnumerable`1[System.Tuple`2[a,b]],System.Collections.Generic.IEnumerable`1[System.Tuple`2[a,System.Collections.Generic.IEnumerable`1[System.String]]]] replaceKeywords[a,b](System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `replacements` | `IEnumerable`1` | No | `` |  |

---

### get_saveFiles (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.Collections.Generic.IEnumerable`1[System.String]]],Microsoft.FSharp.Core.Unit] get_saveFiles()`
**Return Type:** `FSharpFunc`2`

---

### replaceInFiles (static)

**Signature:** `Void replaceInFiles(System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.String]], System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `replacements` | `IEnumerable`1` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

## Properties

### saveFiles (static)

**Type:** `FSharpFunc`2` (read-only)

**Description:** Saves all files (lazy - file by file!)

---