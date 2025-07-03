# Shell Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.Shell`

Shell-like functions. Similar to
 Ruby's FileUtils.

## Methods

### copyFile (static)

**Signature:** `Void copyFile(System.String, System.String)`
**Return Type:** `Void`

**Description:** Copies a single file to the target and overwrites the existing file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` | The target directory or file. |
| `fileName` | `String` | No | `` | The FileName. |

---

### copyFileIntoSubFolder (static)

**Signature:** `Void copyFileIntoSubFolder(System.String, System.String)`
**Return Type:** `Void`

**Description:** Copies a single file to a relative subfolder of the target.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` | The target directory |
| `fileName` | `String` | No | `` | The FileName. |

---

### copyFileWithSubfolder (static)

**Signature:** `Void copyFileWithSubfolder(System.String, System.String, System.String)`
**Return Type:** `Void`

**Description:** Copies a single file to the target folder preserving the folder structure
 starting from the specified base folder.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `baseDir` | `String` | No | `` | The base directory. |
| `target` | `String` | No | `` | The target directory. |
| `fileName` | `String` | No | `` | The file name. |

---

### copy (static)

**Signature:** `Void copy(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### copyTo (static)

**Signature:** `Void copyTo(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### copyCached (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] copyCached(System.String, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` |  |
| `cacheDir` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### rename (static)

**Signature:** `Void rename(System.String, System.String)`
**Return Type:** `Void`

**Description:** Renames the file or directory to the target name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` | The target file or directory name. |
| `fileName` | `String` | No | `` | The original file or directory name. |

---

### silentCopy (static)

**Signature:** `Void silentCopy(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### copyFiles (static)

**Signature:** `Void copyFiles(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### copyFilesWithSubFolder (static)

**Signature:** `Void copyFilesWithSubFolder(System.String, Fake.IO.IGlobbingPattern)`
**Return Type:** `Void`

**Description:** Copies the given glob-matches into another directory by leaving relative paths in place based on the
 globbing base-directory

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `targetDir` | `String` | No | `` | The target directory. |
| `files` | `IGlobbingPattern` | No | `` | The file names. |

---

### copyDir (static)

**Signature:** `Void copyDir(System.String, System.String, Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.Boolean])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` |  |
| `source` | `String` | No | `` |  |
| `filterFile` | `FSharpFunc`2` | No | `` |  |

---

### cleanDir (static)

**Signature:** `Void cleanDir(System.String)`
**Return Type:** `Void`

**Description:** Cleans a directory by removing all files and sub-directories

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The directory path |

---

### cleanDirs (static)

**Signature:** `Void cleanDirs(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dirs` | `IEnumerable`1` | No | `` |  |

---

### deleteDir (static)

**Signature:** `Void deleteDir(System.String)`
**Return Type:** `Void`

**Description:** Delete a directory

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` | The directory path to delete |

---

### deleteDirs (static)

**Signature:** `Void deleteDirs(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dirs` | `IEnumerable`1` | No | `` |  |

---

### appendTextFilesWithEncoding (static)

**Signature:** `Void appendTextFilesWithEncoding(System.Text.Encoding, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` |  |
| `newFileName` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### appendTextFiles (static)

**Signature:** `Void appendTextFiles(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newFileName` | `String` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### compareFiles (static)

**Signature:** `Boolean compareFiles(Boolean, System.String, System.String)`
**Return Type:** `Boolean`

**Description:** Compares the given files for changes.
 If delete is set to true then equal files will be removed.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `delete` | `Boolean` | No | `` | Mark if to delete same files or not |
| `originalFileName` | `String` | No | `` | Original directory to use in comparision |
| `compareFileName` | `String` | No | `` | Other directory to use in comparision |

---

### generatePatchWithFindOldFileFunction (static)

**Signature:** `Void generatePatchWithFindOldFileFunction(System.String, System.String, System.Collections.Generic.IEnumerable`1[System.String], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.String]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lastReleaseDir` | `String` | No | `` |  |
| `patchDir` | `String` | No | `` |  |
| `srcFiles` | `IEnumerable`1` | No | `` |  |
| `findOldFileF` | `FSharpFunc`2` | No | `` |  |

---

### generatePatch (static)

**Signature:** `Void generatePatch(System.String, System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lastReleaseDir` | `String` | No | `` |  |
| `patchDir` | `String` | No | `` |  |
| `srcFiles` | `IEnumerable`1` | No | `` |  |

---

### testDir (static)

**Signature:** `Boolean testDir(System.String)`
**Return Type:** `Boolean`

**Description:** Checks if the directory exists

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | Directory path to check |

---

### testFile (static)

**Signature:** `Boolean testFile(System.String)`
**Return Type:** `Boolean`

**Description:** Checks if the file exists

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | Directory path to check |

---

### copyRecursive (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] copyRecursive(System.String, System.String, Boolean)`
**Return Type:** `FSharpList`1`

**Description:** Copies the file structure recursively.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `dir` | `String` | No | `` | Directory path to copy |
| `outputDir` | `String` | No | `` | The target directory to copy to |
| `overWrite` | `Boolean` | No | `` | Flag to overwrite any matching files/directories or not |

---

### copyRecursiveTo (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] copyRecursiveTo(Boolean, System.String, System.String)`
**Return Type:** `FSharpList`1`

**Description:** Copies the file structure recursively.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `overWrite` | `Boolean` | No | `` | Flag to overwrite any matching files/directories or not |
| `outputDir` | `String` | No | `` | The target directory to copy to |
| `dir` | `String` | No | `` | Directory path to copy |

---

### copyRecursive2 (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] copyRecursive2(CopyRecursiveMethod, System.String, System.String)`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `method` | `CopyRecursiveMethod` | No | `` |  |
| `dir` | `String` | No | `` |  |
| `outputDir` | `String` | No | `` |  |

---

### moveFile (static)

**Signature:** `Void moveFile(System.String, System.String)`
**Return Type:** `Void`

**Description:** Moves a single file to the target and overwrites the existing file.
 If fileName is a directory the functions does nothing.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `String` | No | `` | The target directory. |
| `fileName` | `String` | No | `` | The FileName. |

---

### writeConfigFile (static) (generic)

**Signature:** `Void writeConfigFile[a,b](System.String, System.Collections.Generic.IEnumerable`1[System.Tuple`2[a,b]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `configFileName` | `String` | No | `` |  |
| `parameters` | `IEnumerable`1` | No | `` |  |

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

### regexReplaceInFileWithEncoding (static)

**Signature:** `Void regexReplaceInFileWithEncoding(System.String, System.String, System.Text.Encoding, System.String)`
**Return Type:** `Void`

**Description:** Replace all occurrences of the regex pattern with the given replacement in the specified file

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The string to search for a match |
| `replacement` | `String` | No | `` | The replacement string |
| `encoding` | `Encoding` | No | `` | The encoding to use when reading and writing the file |
| `file` | `String` | No | `` | The path of the file to process |

---

### regexReplaceInFilesWithEncoding (static)

**Signature:** `Void regexReplaceInFilesWithEncoding(System.String, System.String, System.Text.Encoding, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |
| `replacement` | `String` | No | `` |  |
| `encoding` | `Encoding` | No | `` |  |
| `files` | `IEnumerable`1` | No | `` |  |

---

### rm (static)

**Signature:** `Void rm(System.String)`
**Return Type:** `Void`

**Description:** Deletes a file if it exists

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fileName` | `String` | No | `` | The file name to delete |

---

### rm_rf (static)

**Signature:** `Void rm_rf(System.String)`
**Return Type:** `Void`

**Description:** Like "rm -rf" in a shell. Removes files recursively, ignoring non-existing files

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `String` | No | `` | The file name to delete |

---

### mkdir (static)

**Signature:** `Void mkdir(System.String)`
**Return Type:** `Void`

**Description:** Creates a directory if it doesn't exist.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to create directory in |

---

### cp_r (static)

**Signature:** `Void cp_r(System.String, System.String)`
**Return Type:** `Void`

**Description:** Like "cp -r" in a shell. Copies a file or directory recursively.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `src` | `String` | No | `` | The source |
| `dest` | `String` | No | `` | The destination |

---

### cp (static)

**Signature:** `Void cp(System.String, System.String)`
**Return Type:** `Void`

**Description:** Like "cp" in a shell. Copies a single file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `src` | `String` | No | `` | The source |
| `dest` | `String` | No | `` | The destination |

---

### chdir (static)

**Signature:** `Void chdir(System.String)`
**Return Type:** `Void`

**Description:** Changes working directory

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to directory to change to |

---

### cd (static)

**Signature:** `Void cd(System.String)`
**Return Type:** `Void`

**Description:** Changes working directory

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to directory to change to |

---

### pwd (static)

**Signature:** `System.String pwd()`
**Return Type:** `String`

**Description:** Gets working directory

---

### pushd (static)

**Signature:** `Void pushd(System.String)`
**Return Type:** `Void`

**Description:** Store the current directory in the directory stack before changing to a new one

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to directory to push |

---

### popd (static)

**Signature:** `Void popd()`
**Return Type:** `Void`

**Description:** Restore the previous directory stored in the stack

---

### mv (static)

**Signature:** `Void mv(System.String, System.String)`
**Return Type:** `Void`

**Description:** Like "mv" in a shell. Moves/renames a file

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `src` | `String` | No | `` | The source |
| `dest` | `String` | No | `` | The destination |

---