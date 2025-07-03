# FileInfo Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.FileInfo`

Contains tasks to interact with FileInfo

## Methods

### ofPath (static)

**Signature:** `System.IO.FileInfo ofPath(System.String)`
**Return Type:** `FileInfo`

**Description:** Creates a FileInfo for the given path.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | Create an instance of `FileInfo` from given path |

---

### |FullName| (static)

**Signature:** `System.String |FullName|(System.IO.FileInfo)`
**Return Type:** `String`

**Description:** Active Pattern for determining file name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FileInfo` | No | `` | FileInfo to operate on |

---

### |NameSections| (static)

**Signature:** `System.Tuple`3[System.String,System.String,System.String] |NameSections|(System.IO.FileInfo)`
**Return Type:** `Tuple`3`

**Description:** Active Pattern for determining FileInfoNameSections.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FileInfo` | No | `` | FileInfo to operate on |

---

### contentIsEqualTo (static)

**Signature:** `Boolean contentIsEqualTo(System.IO.FileInfo, System.IO.FileInfo)`
**Return Type:** `Boolean`

**Description:** Checks if the two files are byte-to-byte equal.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `first` | `FileInfo` | No | `` | First FileInfo to operate on |
| `second` | `FileInfo` | No | `` | Second FileInfo to operate on |

---