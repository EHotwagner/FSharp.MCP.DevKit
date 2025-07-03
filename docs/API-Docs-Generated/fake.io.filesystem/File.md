# File Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.File`

Contains helpers which allow to interact with the file system.

## Methods

### getEncoding (static)

**Signature:** `System.Text.Encoding getEncoding(System.Text.Encoding, System.String)`
**Return Type:** `Encoding`

**Description:** Detect the encoding, from https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding
 Detect the encoding

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `def` | `Encoding` | No | `` | The encoding to detect for |
| `filename` | `String` | No | `` | The file name to check |

---

### exists (static)

**Signature:** `Boolean exists(System.String)`
**Return Type:** `Boolean`

**Description:** Checks if the file exists on disk.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | The file name to check |

---

### getEncodingOrDefault (static)

**Signature:** `System.Text.Encoding getEncodingOrDefault(System.Text.Encoding, System.String)`
**Return Type:** `Encoding`

**Description:** Gets the encoding from the file or the default of the file doesn't exist

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `def` | `Encoding` | No | `` | The encoding to detect for |
| `filename` | `String` | No | `` | The file name to check |

---

### get_getEncodingOrUtf8WithoutBom (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.Text.Encoding] get_getEncodingOrUtf8WithoutBom()`
**Return Type:** `FSharpFunc`2`

---

### checkExists (static)

**Signature:** `Void checkExists(System.String)`
**Return Type:** `Void`

**Description:** Raises an exception if the file doesn't exist on disk.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` |  |

---

### allExist (static)

**Signature:** `Boolean allExist(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `files` | `IEnumerable`1` | No | `` |  |

---

### tryGetVersion (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] tryGetVersion(System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Tries to get the version of a file. Throws `FileNotFoundException` if the file doesn't exist.
 Returns None if the file doesn't contain a `FileVersion` component.
 On non-windows platforms this API returns assembly metadata instead,
 see FileVersionInfo.Unix.cs

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | Name of file from which the version is retrieved. The path can be relative. |

---

### getVersion (static)

**Signature:** `System.String getVersion(System.String)`
**Return Type:** `String`

**Description:** Get the version a file. This overload throws when the file has no version,
 consider using `tryGetVersion` instead. On non-windows platforms this API returns assembly metadata instead,
 FileVersionInfo.Unix.cs

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | Name of file from which the version is retrieved. The path can be relative. |

---

### create (static)

**Signature:** `Void create(System.String)`
**Return Type:** `Void`

**Description:** Creates a file if it does not exist.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | The name of the file to create |

---

### delete (static)

**Signature:** `Void delete(System.String)`
**Return Type:** `Void`

**Description:** Deletes a file if it exists.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | The name of the file to delete |

---

### deleteAll (static)

**Signature:** `Void deleteAll(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `files` | `IEnumerable`1` | No | `` |  |

---

### |EndsWith|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.Unit] |EndsWith|_|(System.String, System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Active Pattern for determining file extension.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `extension` | `String` | No | `` | The extension to look for |
| `file` | `String` | No | `` | The file name to use |

---

### readWithEncoding (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] readWithEncoding(System.Text.Encoding, System.String)`
**Return Type:** `IEnumerable`1`

**Description:** Reads a file line by line

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` | The encoding to use |
| `file` | `String` | No | `` | The file name to use |

---

### read (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] read(System.String)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` |  |

---

### readLineWithEncoding (static)

**Signature:** `System.String readLineWithEncoding(System.Text.Encoding, System.String)`
**Return Type:** `String`

**Description:** Reads the first line of a file. This can be helpful to read a password from file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` | The encoding to use |
| `file` | `String` | No | `` | The file name to use |

---

### readLine (static)

**Signature:** `System.String readLine(System.String)`
**Return Type:** `String`

**Description:** Reads the first line of a file. This can be helpful to read a password from file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` | The file name to use |

---

### writeWithEncoding (static)

**Signature:** `Void writeWithEncoding(System.Text.Encoding, Boolean, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` |  |
| `append` | `Boolean` | No | `` |  |
| `fileName` | `String` | No | `` |  |
| `lines` | `IEnumerable`1` | No | `` |  |

---

### write (static)

**Signature:** `Void write(Boolean, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `append` | `Boolean` | No | `` |  |
| `fileName` | `String` | No | `` |  |
| `lines` | `IEnumerable`1` | No | `` |  |

---

### writeBytes (static)

**Signature:** `Void writeBytes(System.String, Byte[])`
**Return Type:** `Void`

**Description:** Writes a byte array to a file

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` | The file name to use |
| `bytes` | `Byte[]` | No | `` | The bytes to write |

---

### writeStringWithEncoding (static)

**Signature:** `Void writeStringWithEncoding(System.Text.Encoding, Boolean, System.String, System.String)`
**Return Type:** `Void`

**Description:** Writes a string to a file

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` | The encoding to use |
| `append` | `Boolean` | No | `` | Flag to check if to append content or overwrite |
| `fileName` | `String` | No | `` |  |
| `text` | `String` | No | `` | The string text to write |

---

### writeString (static)

**Signature:** `Void writeString(Boolean, System.String, System.String)`
**Return Type:** `Void`

**Description:** Writes a string to a file

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `append` | `Boolean` | No | `` | Flag to check if to append content or overwrite |
| `fileName` | `String` | No | `` |  |
| `text` | `String` | No | `` | The string text to write |

---

### replaceContent (static)

**Signature:** `Void replaceContent(System.String, System.String)`
**Return Type:** `Void`

**Description:** Replaces the file with the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` |  |
| `text` | `String` | No | `` | The string text to write |

---

### writeNew (static)

**Signature:** `Void writeNew(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` |  |
| `lines` | `IEnumerable`1` | No | `` |  |

---

### append (static)

**Signature:** `Void append(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` |  |
| `lines` | `IEnumerable`1` | No | `` |  |

---

### readAsStringWithEncoding (static)

**Signature:** `System.String readAsStringWithEncoding(System.Text.Encoding, System.String)`
**Return Type:** `String`

**Description:** Reads a file as one text

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` | The encoding to use |
| `file` | `String` | No | `` | The file name to use |

---

### readAsString (static)

**Signature:** `System.String readAsString(System.String)`
**Return Type:** `String`

**Description:** Reads a file as one text

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` | The file name to use |

---

### readAsBytes (static)

**Signature:** `Byte[] readAsBytes(System.String)`
**Return Type:** `Byte[]`

**Description:** Reads a file as one array of bytes

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `file` | `String` | No | `` | The file name to use |

---

### applyReplace (static)

**Signature:** `Void applyReplace(Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.String], System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `replaceF` | `FSharpFunc`2` | No | `` |  |
| `fileName` | `String` | No | `` |  |

---

## Properties

### getEncodingOrUtf8WithoutBom (static)

**Type:** `FSharpFunc`2` (read-only)

**Description:** Get the encoding from the file or utf8 without BOM if unknown or the file doesn't exist

---