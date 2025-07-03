# ProcStartInfo Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ProcStartInfo`
- **Implements:** `System.IEquatable`1[[Fake.Core.ProcStartInfo, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`

The process start info, a type used to define a process configurations, options and arguments

## Methods

### get_Arguments

**Signature:** `System.String get_Arguments()`
**Return Type:** `String`

---

### get_CreateNoWindow

**Signature:** `Boolean get_CreateNoWindow()`
**Return Type:** `Boolean`

---

### get_Domain

**Signature:** `System.String get_Domain()`
**Return Type:** `String`

---

### get_Environment

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String] get_Environment()`
**Return Type:** `FSharpMap`2`

---

### get_FileName

**Signature:** `System.String get_FileName()`
**Return Type:** `String`

---

### get_LoadUserProfile

**Signature:** `Boolean get_LoadUserProfile()`
**Return Type:** `Boolean`

---

### get_Password

**Signature:** `System.String get_Password()`
**Return Type:** `String`

---

### get_RedirectStandardError

**Signature:** `Boolean get_RedirectStandardError()`
**Return Type:** `Boolean`

---

### get_RedirectStandardInput

**Signature:** `Boolean get_RedirectStandardInput()`
**Return Type:** `Boolean`

---

### get_RedirectStandardOutput

**Signature:** `Boolean get_RedirectStandardOutput()`
**Return Type:** `Boolean`

---

### get_StandardErrorEncoding

**Signature:** `System.Text.Encoding get_StandardErrorEncoding()`
**Return Type:** `Encoding`

---

### get_StandardOutputEncoding

**Signature:** `System.Text.Encoding get_StandardOutputEncoding()`
**Return Type:** `Encoding`

---

### get_UserName

**Signature:** `System.String get_UserName()`
**Return Type:** `String`

---

### get_UseShellExecute

**Signature:** `Boolean get_UseShellExecute()`
**Return Type:** `Boolean`

---

### get_WorkingDirectory

**Signature:** `System.String get_WorkingDirectory()`
**Return Type:** `String`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### GetHashCode

**Signature:** `Int32 GetHashCode(System.Collections.IEqualityComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IEqualityComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Object, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### Create (static)

**Signature:** `Fake.Core.ProcStartInfo Create()`
**Return Type:** `ProcStartInfo`

---

### WithEnvironment

**Signature:** `Fake.Core.ProcStartInfo WithEnvironment(Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String])`
**Return Type:** `ProcStartInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `map` | `FSharpMap`2` | No | `` |  |

---

### get_AsStartInfo

**Signature:** `System.Diagnostics.ProcessStartInfo get_AsStartInfo()`
**Return Type:** `ProcessStartInfo`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.ProcStartInfo)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ProcStartInfo` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

## Properties

### Arguments

**Type:** `String` (read-only)

**Description:** Gets or sets the set of command-line arguments to use when starting the application.

---

### CreateNoWindow

**Type:** `Boolean` (read-only)

**Description:** Gets or sets a value indicating whether to start the process in a new window.

---

### Domain

**Type:** `String` (read-only)

**Description:** Gets or sets a value that identifies the domain to use when starting the process. If this value is null,
 the UserName property must be specified in UPN format.

---

### Environment

**Type:** `FSharpMap`2` (read-only)

**Description:** Gets the environment variables that apply to this process and its child processes.
 NOTE: Recommendation is to not use this Field, but instead use the helper function in the Proc module
 (for example Process.setEnvironmentVariable)
 NOTE: This field is ignored when UseShellExecute is true.

---

### FileName

**Type:** `String` (read-only)

**Description:** Gets or sets the application or document to start.

---

### LoadUserProfile

**Type:** `Boolean` (read-only)

**Description:** true if the Windows user profile should be loaded; otherwise, false. The default is false.

---

### Password

**Type:** `String` (read-only)

**Description:** Gets or sets the user password in clear text to use when starting the process.

---

### RedirectStandardError

**Type:** `Boolean` (read-only)

**Description:** true if error output should be written to Process.StandardError; otherwise, false. The default is false.

---

### RedirectStandardInput

**Type:** `Boolean` (read-only)

**Description:** true if input should be read from Process.StandardInput; otherwise, false. The default is false.

---

### RedirectStandardOutput

**Type:** `Boolean` (read-only)

**Description:** true if output should be written to Process.StandardOutput; otherwise, false. The default is false.

---

### StandardErrorEncoding

**Type:** `Encoding` (read-only)

**Description:** An object that represents the preferred encoding for error output. The default is null.

---

### StandardOutputEncoding

**Type:** `Encoding` (read-only)

**Description:** An object that represents the preferred encoding for standard output. The default is null.

---

### UserName

**Type:** `String` (read-only)

**Description:** The user name to use when starting the process. If you use the UPN format, user@DNS_domain_name, the Domain
 property must be null.

---

### UseShellExecute

**Type:** `Boolean` (read-only)

**Description:** true if the shell should be used when starting the process; false if the process should be created directly
 from the executable file. The default is true.

---

### WorkingDirectory

**Type:** `String` (read-only)

**Description:** When UseShellExecute is true, the fully qualified name of the directory that contains the process to be
 started. When the UseShellExecute property is false, the working directory for the process to be started.
 The default is an empty string ("").

---

### AsStartInfo

**Type:** `ProcessStartInfo` (read-only)

---