# Path Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.Path`

Contains helper function which allow to deal with files and directories.

## Methods

### combineTrimEnd (static)

**Signature:** `System.String combineTrimEnd(System.String, System.String)`
**Return Type:** `String`

**Description:** Combines two path strings using Path.Combine. Trims leading slashes of path2.
 This makes combineTrimEnd "/test" "/sub" return /test/sub

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path1` | `String` | No | `` | The first path to combine |
| `path2` | `String` | No | `` | The second path to combine |

---

### combine (static)

**Signature:** `System.String combine(System.String, System.String)`
**Return Type:** `String`

**Description:** Combines two path strings using Path.Combine

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path1` | `String` | No | `` | The first path to combine |
| `path2` | `String` | No | `` | The second path to combine |

---

### isDirectory (static)

**Signature:** `Boolean isDirectory(System.String)`
**Return Type:** `Boolean`

**Description:** Detects whether the given path is a directory.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to check |

---

### isFile (static)

**Signature:** `Boolean isFile(System.String)`
**Return Type:** `Boolean`

**Description:** Detects whether the given path is a file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to check |

---

### normalizeFileName (static)

**Signature:** `System.String normalizeFileName(System.String)`
**Return Type:** `String`

**Description:** Normalizes a filename.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | The file name to normalize |

---

### isValidPath (static)

**Signature:** `Boolean isValidPath(System.String)`
**Return Type:** `Boolean`

**Description:** Detects whether the given path does not contains invalid characters.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` |  |

---

### changeExtension (static)

**Signature:** `System.String changeExtension(System.String, System.String)`
**Return Type:** `String`

**Description:** Change the extension of the file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `extension` | `String` | No | `` | The new extension containing the leading '.'. |
| `fileName` | `String` | No | `` | Name of the file from which the extension is retrieved. |

---

### hasExtension (static)

**Signature:** `Boolean hasExtension(System.String, System.String)`
**Return Type:** `Boolean`

**Description:** Tests whether the file has specified extensions (containing the leading '.')

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `extension` | `String` | No | `` | The extension to fine containing the leading '.'. |
| `fileName` | `String` | No | `` | Name of the file from which the extension is retrieved. |

---

### getDirectory (static)

**Signature:** `System.String getDirectory(System.String)`
**Return Type:** `String`

**Description:** Get the directory of the specified path

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path from which the directory is retrieved. |

---

### get_directorySeparator (static)

**Signature:** `System.String get_directorySeparator()`
**Return Type:** `String`

---

### getFullName (static)

**Signature:** `System.String getFullName(System.String)`
**Return Type:** `String`

**Description:** Gets the absolute path for the given path

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `String` | No | `` | The path to get its absolute path |

---

### shortenCurrentDirectory (static)

**Signature:** `System.String shortenCurrentDirectory(System.String)`
**Return Type:** `String`

**Description:** Replaces any occurence of the currentDirectory with "."

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to operate on |

---

### get_toRelativeFrom (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.String]] get_toRelativeFrom()`
**Return Type:** `FSharpFunc`2`

---

### toRelativeFromCurrent (static)

**Signature:** `System.String toRelativeFromCurrent(System.String)`
**Return Type:** `String`

**Description:** Replaces the absolute path with a relative path

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to operate on |

---

### convertWindowsToCurrentPath (static)

**Signature:** `System.String convertWindowsToCurrentPath(System.String)`
**Return Type:** `String`

**Description:** Convert the given windows path to a path in the current system

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `windowsPath` | `String` | No | `` | The path to operate on |

---

## Properties

### directorySeparator (static)

**Type:** `String` (read-only)

**Description:** The directory separator string. On most systems / or \

---

### toRelativeFrom (static)

**Type:** `FSharpFunc`2` (read-only)

**Description:** Replaces the absolute path with a relative path

---