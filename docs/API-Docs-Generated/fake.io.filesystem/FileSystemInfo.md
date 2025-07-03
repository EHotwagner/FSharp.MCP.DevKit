# FileSystemInfo Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.FileSystemInfo`

Contains tasks to interact with FileSystemInfo

## Methods

### ofPath (static)

**Signature:** `System.IO.FileSystemInfo ofPath(System.String)`
**Return Type:** `FileSystemInfo`

**Description:** Creates a FileInfo or a DirectoryInfo for the given path

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to create FileSystemInfo from |

---

### setReadOnly (static)

**Signature:** `Void setReadOnly(Boolean, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `readOnly` | `Boolean` | No | `` |  |
| `items` | `IEnumerable`1` | No | `` |  |

---

### |File|Directory| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`2[System.IO.FileInfo,System.Tuple`2[System.IO.DirectoryInfo,System.Collections.Generic.IEnumerable`1[System.IO.FileSystemInfo]]] |File|Directory|(System.IO.FileSystemInfo)`
**Return Type:** `FSharpChoice`2`

**Description:** Active pattern which discriminates between files and directories.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileSysInfo` | `FileSystemInfo` | No | `` | The FileSystemInfo to check |

---