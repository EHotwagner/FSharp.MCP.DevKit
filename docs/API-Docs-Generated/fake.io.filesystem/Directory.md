# Directory Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.Directory`

Contains helpers which allow to interact with the directory in file system.

## Methods

### ensure (static)

**Signature:** `Void ensure(System.String)`
**Return Type:** `Void`

**Description:** Checks if the given directory exists. If not then this functions creates the directory.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` | The directory to check |

---

### get_create (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit] get_create()`
**Return Type:** `FSharpFunc`2`

---

### tryFindFirstMatchingFile (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryFindFirstMatchingFile(System.String, System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Gets the first file in the directory matching the search pattern as an option value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The glob pattern to use in matching |
| `dir` | `String` | No | `` | The directory to check |

---

### findFirstMatchingFile (static)

**Signature:** `System.String findFirstMatchingFile(System.String, System.String)`
**Return Type:** `String`

**Description:** Gets the first file in the directory matching the search pattern or throws an error if nothing was found.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The glob pattern to use in matching |
| `dir` | `String` | No | `` | The directory to check |

---

### delete (static)

**Signature:** `Void delete(System.String)`
**Return Type:** `Void`

**Description:** Deletes a directory if it exists (including all contained elements).

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to delete |

---

## Properties

### create (static)

**Type:** `FSharpFunc`2` (read-only)

**Description:** Creates a directory if it does not exist.

---