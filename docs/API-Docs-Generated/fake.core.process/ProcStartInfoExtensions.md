# ProcStartInfoExtensions Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ProcStartInfoExtensions`

An extension to process start info type

## Methods

### ProcStartInfo.WithArguments (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithArguments(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** Gets or sets the set of command-line arguments to use when starting the application.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `args` | `String` | No | `` |  |

---

### ProcStartInfo.WithCreateNoWindow (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithCreateNoWindow(Fake.Core.ProcStartInfo, Boolean)`
**Return Type:** `ProcStartInfo`

**Description:** Gets or sets a value indicating whether to start the process in a new window.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `noWindow` | `Boolean` | No | `` |  |

---

### ProcStartInfo.WithDomain (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithDomain(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** Gets or sets a value that identifies the domain to use when starting the process.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `domain` | `String` | No | `` |  |

---

### ProcStartInfo.WithoutEnvironment (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithoutEnvironment(Fake.Core.ProcStartInfo)`
**Return Type:** `ProcStartInfo`

**Description:** Remove the current Environment Variables and use the default

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ProcStartInfo` | No | `` |  |

---

### ProcStartInfo.WithEnvironmentVariable (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithEnvironmentVariable(Fake.Core.ProcStartInfo, System.String, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** Sets the given environment variable for the given startInfo.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `envKey` | `String` | No | `` |  |
| `envVar` | `String` | No | `` |  |

---

### ProcStartInfo.WithRemovedEnvironmentVariable (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithRemovedEnvironmentVariable(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** Unsets the given environment variable for the given startInfo.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `envKey` | `String` | No | `` |  |

---

### ProcStartInfo.WithEnvironmentVariables (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithEnvironmentVariables(Fake.Core.ProcStartInfo, System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.String]])`
**Return Type:** `ProcStartInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `vars` | `IEnumerable`1` | No | `` |  |

---

### ProcStartInfo.WithCurrentEnvironmentVariables (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithCurrentEnvironmentVariables(Fake.Core.ProcStartInfo)`
**Return Type:** `ProcStartInfo`

**Description:** Sets the current environment variables.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `ProcStartInfo` | No | `` |  |

---

### ProcStartInfo.WithFileName (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithFileName(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** Gets or sets the application or document to start.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `name` | `String` | No | `` |  |

---

### ProcStartInfo.WithLoadUserProfile (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithLoadUserProfile(Fake.Core.ProcStartInfo, Boolean)`
**Return Type:** `ProcStartInfo`

**Description:** true if the Windows user profile should be loaded; otherwise, false. The default is false.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `userProfile` | `Boolean` | No | `` |  |

---

### ProcStartInfo.WithPassword (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithPassword(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** Gets or sets the user password in clear text to use when starting the process.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `password` | `String` | No | `` |  |

---

### ProcStartInfo.WithRedirectStandardError (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithRedirectStandardError(Fake.Core.ProcStartInfo, Boolean)`
**Return Type:** `ProcStartInfo`

**Description:** true if error output should be written to Process.StandardError; otherwise, false. The default is false.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `redirectStdErr` | `Boolean` | No | `` |  |

---

### ProcStartInfo.WithRedirectStandardInput (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithRedirectStandardInput(Fake.Core.ProcStartInfo, Boolean)`
**Return Type:** `ProcStartInfo`

**Description:** true if input should be read from Process.StandardInput; otherwise, false. The default is false.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `redirectStdInput` | `Boolean` | No | `` |  |

---

### ProcStartInfo.WithRedirectStandardOutput (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithRedirectStandardOutput(Fake.Core.ProcStartInfo, Boolean)`
**Return Type:** `ProcStartInfo`

**Description:** true if output should be written to Process.StandardOutput; otherwise, false. The default is false.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `redirectStdOutput` | `Boolean` | No | `` |  |

---

### ProcStartInfo.WithStandardErrorEncoding (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithStandardErrorEncoding(Fake.Core.ProcStartInfo, System.Text.Encoding)`
**Return Type:** `ProcStartInfo`

**Description:** An object that represents the preferred encoding for error output. The default is null.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `encoding` | `Encoding` | No | `` |  |

---

### ProcStartInfo.WithStandardOutputEncoding (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithStandardOutputEncoding(Fake.Core.ProcStartInfo, System.Text.Encoding)`
**Return Type:** `ProcStartInfo`

**Description:** An object that represents the preferred encoding for standard output. The default is null.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `encoding` | `Encoding` | No | `` |  |

---

### ProcStartInfo.WithUserName (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithUserName(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** The user name to use when starting the process. If you use the UPN format, user@DNS_domain_name,
 the Domain property must be null.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `name` | `String` | No | `` |  |

---

### ProcStartInfo.WithUseShellExecute (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithUseShellExecute(Fake.Core.ProcStartInfo, Boolean)`
**Return Type:** `ProcStartInfo`

**Description:** true if the shell should be used when starting the process; false if the process should be
 created directly from the executable file. The default is true.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `shellExec` | `Boolean` | No | `` |  |

---

### ProcStartInfo.WithWorkingDirectory (static)

**Signature:** `Fake.Core.ProcStartInfo ProcStartInfo.WithWorkingDirectory(Fake.Core.ProcStartInfo, System.String)`
**Return Type:** `ProcStartInfo`

**Description:** When UseShellExecute is true, the fully qualified name of the directory that contains the process
 to be started. When the UseShellExecute property is false, the working directory for the process to be
 started. The default is an empty string ("").

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `ProcStartInfo` | No | `` |  |
| `dir` | `String` | No | `` |  |

---