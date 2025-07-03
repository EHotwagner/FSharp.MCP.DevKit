# Environment Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Environment`

This module contains functions which allow to read and write environment variables and build parameters

## Methods

### environVar (static)

**Signature:** `System.String environVar(System.String)`
**Return Type:** `String`

**Description:** Retrieves the environment variable with the given name

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The environment variable name |

---

### environVars (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[System.String,System.String]] environVars()`
**Return Type:** `FSharpList`1`

**Description:** Retrieves all environment variables from the given target

---

### setEnvironVar (static)

**Signature:** `Void setEnvironVar(System.String, System.String)`
**Return Type:** `Void`

**Description:** Sets the environment variable with the given name

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable to set |
| `value` | `String` | No | `` | The value of the environment variable to set |

---

### clearEnvironVar (static)

**Signature:** `Void clearEnvironVar(System.String)`
**Return Type:** `Void`

**Description:** Clears the environment variable with the given name for the current process.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable |

---

### environVarOrDefault (static)

**Signature:** `System.String environVarOrDefault(System.String, System.String)`
**Return Type:** `String`

**Description:** Retrieves the environment variable with the given name or returns the default if no value was set

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable |
| `defaultValue` | `String` | No | `` | The default value to return if no value was set |

---

### environVarOrFail (static)

**Signature:** `System.String environVarOrFail(System.String)`
**Return Type:** `String`

**Description:** Retrieves the environment variable with the given name or fails if not found

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable |

---

### environVarAsBoolOrDefault (static)

**Signature:** `Boolean environVarAsBoolOrDefault(System.String, Boolean)`
**Return Type:** `Boolean`

**Description:** Retrieves the environment variable with the given name or returns the default bool if no value was set

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `varName` | `String` | No | `` |  |
| `defaultValue` | `Boolean` | No | `` | The default value to return if no value was set |

---

### environVarAsBool (static)

**Signature:** `Boolean environVarAsBool(System.String)`
**Return Type:** `Boolean`

**Description:** Retrieves the environment variable with the given name or returns the false if no value was set

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `varName` | `String` | No | `` | The name of the environment variable |

---

### environVarOrNone (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] environVarOrNone(System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Retrieves the environment variable or None

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable |

---

### splitEnvironVar (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] splitEnvironVar(System.String)`
**Return Type:** `FSharpList`1`

**Description:** Splits the entries of an environment variable and removes the empty ones.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable |

---

### hasEnvironVar (static)

**Signature:** `Boolean hasEnvironVar(System.String)`
**Return Type:** `Boolean`

**Description:** Returns if the build parameter with the given name was set

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the environment variable |

---

### get_ProgramFiles (static)

**Signature:** `System.String get_ProgramFiles()`
**Return Type:** `String`

---

### get_ProgramFilesX86 (static)

**Signature:** `System.String get_ProgramFilesX86()`
**Return Type:** `String`

---

### get_SystemRoot (static)

**Signature:** `System.String get_SystemRoot()`
**Return Type:** `String`

---

### get_isUnix (static)

**Signature:** `Boolean get_isUnix()`
**Return Type:** `Boolean`

---

### get_isMacOS (static)

**Signature:** `Boolean get_isMacOS()`
**Return Type:** `Boolean`

---

### get_isLinux (static)

**Signature:** `Boolean get_isLinux()`
**Return Type:** `Boolean`

---

### get_isWindows (static)

**Signature:** `Boolean get_isWindows()`
**Return Type:** `Boolean`

---

### get_isMono (static)

**Signature:** `Boolean get_isMono()`
**Return Type:** `Boolean`

---

### get_isDotNetCore (static)

**Signature:** `Boolean get_isDotNetCore()`
**Return Type:** `Boolean`

---

### get_monoVersion (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.String,Microsoft.FSharp.Core.FSharpOption`1[System.Version]]] get_monoVersion()`
**Return Type:** `FSharpOption`1`

---

### get_pathDirectories (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.String] get_pathDirectories()`
**Return Type:** `IEnumerable`1`

---

### get_monoPath (static)

**Signature:** `System.String get_monoPath()`
**Return Type:** `String`

---

### get_sdkBasePath (static)

**Signature:** `System.String get_sdkBasePath()`
**Return Type:** `String`

---

### getNewestTool (static) (generic)

**Signature:** `a getNewestTool[a](System.Collections.Generic.IEnumerable`1[a])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `possibleToolPaths` | `IEnumerable`1` | No | `` |  |

---

### getTargetPlatformDir (static)

**Signature:** `System.String getTargetPlatformDir(System.String)`
**Return Type:** `String`

**Description:** Gets the local directory for the given target platform

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `platformVersion` | `String` | No | `` |  |

---

### getDefaultEncoding (static)

**Signature:** `System.Text.Encoding getDefaultEncoding()`
**Return Type:** `Encoding`

**Description:** Contains the IO encoding which is given via build parameter "encoding" or the default encoding if no encoding
 was specified.

---

### getNuGetPackagesCacheFolder (static)

**Signature:** `System.String getNuGetPackagesCacheFolder()`
**Return Type:** `String`

**Description:** Returns the path to the user-specific nuget packages folder

---

## Properties

### ProgramFiles (static)

**Type:** `String` (read-only)

**Description:** The path of the "Program Files" folder - might be x64 on x64 machine

---

### ProgramFilesX86 (static)

**Type:** `String` (read-only)

**Description:** The path of Program Files (x86)
 It seems this covers all cases where PROCESSOR\_ARCHITECTURE may misreport and the case where
 the other variable PROCESSOR\_ARCHITEW6432 can be null

---

### SystemRoot (static)

**Type:** `String` (read-only)

**Description:** The system root environment variable. Typically C:\Windows

---

### isUnix (static)

**Type:** `Boolean` (read-only)

**Description:** Determines if the current system is an Unix system.
 See 
 how-to-detect-the-execution-platform

---

### isMacOS (static)

**Type:** `Boolean` (read-only)

**Description:** Determines if the current system is a MacOs system

---

### isLinux (static)

**Type:** `Boolean` (read-only)

**Description:** Determines if the current system is a Linux system

---

### isWindows (static)

**Type:** `Boolean` (read-only)

**Description:** Determines if the current system is a Windows system

---

### isMono (static)

**Type:** `Boolean` (read-only)

**Description:** Determines if the current FAKE runner is being run via mono.  With the FAKE 5 or above runner,
 this will always be false

---

### isDotNetCore (static)

**Type:** `Boolean` (read-only)

---

### monoVersion (static)

**Type:** `FSharpOption`1` (read-only)

**Description:** Required sometimes to workaround mono crashes 
 see this link
 Only given when we are running on mono,
 represents the version of the mono runtime we
 are currently running on.
 In netcore world you can retrieve the mono version in the
 environment (PATH) via Fake.Core.Process.Mono.monoVersion

---

### pathDirectories (static)

**Type:** `IEnumerable`1` (read-only)

**Description:** Gets the list of valid directories included in the PATH environment variable.

---

### monoPath (static)

**Type:** `String` (read-only)

---

### sdkBasePath (static)

**Type:** `String` (read-only)

**Description:** Base path for getting tools from windows SDKs

---