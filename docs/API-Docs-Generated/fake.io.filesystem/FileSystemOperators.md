# FileSystemOperators Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.FileSystemOperators`

Defines custom operators for manipulating files and directories in a file system

## Methods

### op_AtAt (static)

**Signature:** `System.String op_AtAt(System.String, System.String)`
**Return Type:** `String`

**Description:** Combines two path strings using Path.Combine. Trims leading slashes of the right operand.
 This makes "/test" @@ "/sub" return /test/sub

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path1` | `String` | No | `` | The first path to operate on |
| `path2` | `String` | No | `` | The second path to operate on |

---

### op_LessDivideGreater (static)

**Signature:** `System.String op_LessDivideGreater(System.String, System.String)`
**Return Type:** `String`

**Description:** Combines two path strings using Path.Combine

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path1` | `String` | No | `` | The first path to operate on |
| `path2` | `String` | No | `` | The second path to operate on |

---