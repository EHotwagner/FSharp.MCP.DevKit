# ProcessUtils Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ProcessUtils`

Contains functions which can be used to start other tools.

## Methods

### findFiles (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] findFiles(System.Collections.Generic.IEnumerable`1[System.String], System.String)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dirs` | `IEnumerable`1` | No | `` |  |
| `tool` | `String` | No | `` |  |

---

### tryFindFile (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryFindFile(System.Collections.Generic.IEnumerable`1[System.String], System.String)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dirs` | `IEnumerable`1` | No | `` |  |
| `tool` | `String` | No | `` |  |

---

### findFile (static)

**Signature:** `System.String findFile(System.Collections.Generic.IEnumerable`1[System.String], System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dirs` | `IEnumerable`1` | No | `` |  |
| `tool` | `String` | No | `` |  |

---

### findFilesOnPath (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] findFilesOnPath(System.String)`
**Return Type:** `IEnumerable`1`

**Description:** Searches the current directory and in PATH for the given file and returns the result ordered by precedence.
 Considers PATHEXT on Windows.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tool` | `String` | No | `` | The file name (tool) to search for |

---

### tryFindFileOnPath (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryFindFileOnPath(System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Searches the current directory and the directories within the PATH
 environment variable for the given file. If successful returns the full
 path to the file. Considers PATHEXT on Windows.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tool` | `String` | No | `` |  |

---

### tryFindTool (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryFindTool(System.String, System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Tries to find the tool via Env-Var. If no path has the right tool we are trying the PATH system variable.
 Considers PATHEXT on Windows.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envVar` | `String` | No | `` | The environment variable name |
| `tool` | `String` | No | `` | The file name (tool) to search for |

---

### tryFindPath (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryFindPath(System.Collections.Generic.IEnumerable`1[System.String], System.String)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `additionalDirs` | `IEnumerable`1` | No | `` |  |
| `tool` | `String` | No | `` |  |

---

### findPath (static)

**Signature:** `System.String findPath(System.Collections.Generic.IEnumerable`1[System.String], System.String)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fallbackValue` | `IEnumerable`1` | No | `` |  |
| `tool` | `String` | No | `` |  |

---

### tryFindLocalTool (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryFindLocalTool(System.String, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envVar` | `String` | No | `` |  |
| `tool` | `String` | No | `` |  |
| `recursiveDirs` | `IEnumerable`1` | No | `` |  |

---

### findLocalTool (static)

**Signature:** `System.String findLocalTool(System.String, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envVar` | `String` | No | `` |  |
| `tool` | `String` | No | `` |  |
| `recursiveDirs` | `IEnumerable`1` | No | `` |  |

---