# GlobbingPatternModule Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.GlobbingPatternModule`

Contains tasks to interact with file system using glob patterns

## Methods

### create (static)

**Signature:** `Fake.IO.IGlobbingPattern create(System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Include files

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |

---

### createFrom (static)

**Signature:** `Fake.IO.IGlobbingPattern createFrom(System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Start an empty globbing pattern from the specified directory

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` |  |

---

### setBaseDir (static)

**Signature:** `Fake.IO.IGlobbingPattern setBaseDir(System.String, Fake.IO.IGlobbingPattern)`
**Return Type:** `IGlobbingPattern`

**Description:** Sets a directory as baseDirectory for fileIncludes.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` |  |
| `fileIncludes` | `IGlobbingPattern` | No | `` |  |

---

### getBaseDirectoryIncludes (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] getBaseDirectoryIncludes(Fake.IO.IGlobbingPattern)`
**Return Type:** `FSharpList`1`

**Description:** Get base include directories. Used to get a smaller set of directories from a globbing pattern.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileIncludes` | `IGlobbingPattern` | No | `` |  |

---