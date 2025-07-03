# DirectoryInfo Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.DirectoryInfo`

Contains tasks to interact with DirectoryInfo

## Methods

### ofPath (static)

**Signature:** `System.IO.DirectoryInfo ofPath(System.String)`
**Return Type:** `DirectoryInfo`

**Description:** Creates a DirectoryInfo for the given path.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to use |

---

### getSubDirectories (static)

**Signature:** `System.IO.DirectoryInfo[] getSubDirectories(System.IO.DirectoryInfo)`
**Return Type:** `DirectoryInfo[]`

**Description:** Gets all subdirectories of a given directory.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `DirectoryInfo` | No | `` | The directory to use |

---

### getFiles (static)

**Signature:** `System.IO.FileInfo[] getFiles(System.IO.DirectoryInfo)`
**Return Type:** `FileInfo[]`

**Description:** Gets all files in the directory.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `DirectoryInfo` | No | `` | The directory to use |

---

### getMatchingFiles (static)

**Signature:** `System.IO.FileInfo[] getMatchingFiles(System.String, System.IO.DirectoryInfo)`
**Return Type:** `FileInfo[]`

**Description:** Finds all the files in the directory matching the search pattern.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The glob pattern to use for search |
| `dir` | `DirectoryInfo` | No | `` | The directory to use |

---

### getMatchingFilesRecursive (static)

**Signature:** `System.IO.FileInfo[] getMatchingFilesRecursive(System.String, System.IO.DirectoryInfo)`
**Return Type:** `FileInfo[]`

**Description:** Finds all the files in the directory and in all subdirectories matching the search pattern.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The glob pattern to use for search |
| `dir` | `DirectoryInfo` | No | `` | The directory to use |

---

### isSubfolderOf (static)

**Signature:** `Boolean isSubfolderOf(System.IO.DirectoryInfo, System.IO.DirectoryInfo)`
**Return Type:** `Boolean`

**Description:** Checks if dir1 is a subfolder of dir2. If dir1 equals dir2 the function returns also true.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir2` | `DirectoryInfo` | No | `` | The second directory to check for |
| `dir1` | `DirectoryInfo` | No | `` | The first directory to check for |

---

### containsFile (static)

**Signature:** `Boolean containsFile(System.IO.FileInfo, System.IO.DirectoryInfo)`
**Return Type:** `Boolean`

**Description:** Checks if the file is in a subfolder of the dir.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileInfo` | `FileInfo` | No | `` | The file to check for |
| `dir` | `DirectoryInfo` | No | `` | The directory to search in |

---

### exists (static)

**Signature:** `Boolean exists(System.IO.DirectoryInfo)`
**Return Type:** `Boolean`

**Description:** Checks if the directory exists on disk.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `DirectoryInfo` | No | `` | The directory to check for |

---

### ensure (static)

**Signature:** `Void ensure(System.IO.DirectoryInfo)`
**Return Type:** `Void`

**Description:** Ensure that directory chain exists. Create necessary directories if necessary.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `DirectoryInfo` | No | `` | The directory to check |

---

### setReadOnly (static)

**Signature:** `Void setReadOnly(Boolean, System.IO.DirectoryInfo)`
**Return Type:** `Void`

**Description:** Sets the directory readonly

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `readOnly` | `Boolean` | No | `` | Flag to set directory to readonly or not. |
| `dir` | `DirectoryInfo` | No | `` | The directory to set |

---

### setReadOnlyRecursive (static)

**Signature:** `Void setReadOnlyRecursive(Boolean, System.IO.DirectoryInfo)`
**Return Type:** `Void`

**Description:** Sets all files in the directory readonly recursively.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `readOnly` | `Boolean` | No | `` | Flag to set directory to readonly or not. |
| `dir` | `DirectoryInfo` | No | `` | The directory to set |

---

### copyRecursiveToWithFilter (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] copyRecursiveToWithFilter(Boolean, Microsoft.FSharp.Core.FSharpFunc`2[System.IO.DirectoryInfo,Microsoft.FSharp.Core.FSharpFunc`2[System.IO.FileInfo,System.Boolean]], System.IO.DirectoryInfo, System.IO.DirectoryInfo)`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `overwrite` | `Boolean` | No | `` |  |
| `filter` | `FSharpFunc`2` | No | `` |  |
| `outputDir` | `DirectoryInfo` | No | `` |  |
| `dir` | `DirectoryInfo` | No | `` |  |

---

### copyRecursiveTo (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] copyRecursiveTo(Boolean, System.IO.DirectoryInfo, System.IO.DirectoryInfo)`
**Return Type:** `FSharpList`1`

**Description:** Copies the file structure recursively.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `overwrite` | `Boolean` | No | `` | Flag to overwrite same files in target dir |
| `outputDir` | `DirectoryInfo` | No | `` | The target directory to copy to |
| `dir` | `DirectoryInfo` | No | `` | The source directory to copy from |

---