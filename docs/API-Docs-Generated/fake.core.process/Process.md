# Process Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Process`

Contains functions which can be used to start other tools.

## Methods

### kill (static)

**Signature:** `Void kill(System.Diagnostics.Process)`
**Return Type:** `Void`

**Description:** Kills the given process

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `proc` | `Process` | No | `` | The process to kill |

---

### setKillCreatedProcesses (static)

**Signature:** `Void setKillCreatedProcesses(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `enable` | `Boolean` | No | `` |  |

---

### shouldKillCreatedProcesses (static)

**Signature:** `Boolean shouldKillCreatedProcesses()`
**Return Type:** `Boolean`

---

### get_setRedirectOutputToTrace (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,Microsoft.FSharp.Core.Unit] get_setRedirectOutputToTrace()`
**Return Type:** `FSharpFunc`2`

---

### getRedirectOutputToTrace (static)

**Signature:** `Boolean getRedirectOutputToTrace()`
**Return Type:** `Boolean`

---

### get_setEnableProcessTracing (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,Microsoft.FSharp.Core.Unit] get_setEnableProcessTracing()`
**Return Type:** `FSharpFunc`2`

---

### shouldEnableProcessTracing (static)

**Signature:** `Boolean shouldEnableProcessTracing()`
**Return Type:** `Boolean`

---

### get_AlwaysSetProcessEncoding (static)

**Signature:** `Boolean get_AlwaysSetProcessEncoding()`
**Return Type:** `Boolean`

---

### set_AlwaysSetProcessEncoding (static)

**Signature:** `Void set_AlwaysSetProcessEncoding(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_ProcessEncoding (static)

**Signature:** `System.Text.Encoding get_ProcessEncoding()`
**Return Type:** `Encoding`

---

### set_ProcessEncoding (static)

**Signature:** `Void set_ProcessEncoding(System.Text.Encoding)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Encoding` | No | `` |  |

---

### get_defaultEnvVar (static)

**Signature:** `System.String get_defaultEnvVar()`
**Return Type:** `String`

---

### createEnvironmentMap (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String] createEnvironmentMap()`
**Return Type:** `FSharpMap`2`

---

### setRedirectOutput (static) (generic)

**Signature:** `a setRedirectOutput[a](Boolean, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `shouldRedirect` | `Boolean` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setRedirectOutput$W (static) (generic)

**Signature:** `a setRedirectOutput$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,a]], Boolean, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withRedirectOutput` | `FSharpFunc`2` | No | `` |  |
| `shouldRedirect` | `Boolean` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### redirectOutput (static) (generic)

**Signature:** `a redirectOutput[a](a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `startInfo` | `a` | No | `` |  |

---

### redirectOutput$W (static) (generic)

**Signature:** `a redirectOutput$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,a]], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withRedirectOutput` | `FSharpFunc`2` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### disableRedirectOutput (static) (generic)

**Signature:** `a disableRedirectOutput[a](a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `startInfo` | `a` | No | `` |  |

---

### disableRedirectOutput$W (static) (generic)

**Signature:** `a disableRedirectOutput$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,a]], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withRedirectOutput` | `FSharpFunc`2` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setEnvironment (static) (generic)

**Signature:** `a setEnvironment[a](Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `map` | `FSharpMap`2` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setEnvironment$W (static) (generic)

**Signature:** `a setEnvironment$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String],a]], Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withEnvironment` | `FSharpFunc`2` | No | `` |  |
| `map` | `FSharpMap`2` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### disableShellExecute (static)

**Signature:** `Fake.Core.ProcStartInfo disableShellExecute(Fake.Core.ProcStartInfo)`
**Return Type:** `ProcStartInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `startInfo` | `ProcStartInfo` | No | `` |  |

---

### setEnvironmentVariable (static) (generic)

**Signature:** `a setEnvironmentVariable[a](System.String, System.String, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envKey` | `String` | No | `` |  |
| `envVar` | `String` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setEnvironmentVariable$W (static) (generic)

**Signature:** `a setEnvironmentVariable$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String],a]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String]], System.String, System.String, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withEnvironment` | `FSharpFunc`2` | No | `` |  |
| `get_Environment` | `FSharpFunc`2` | No | `` |  |
| `envKey` | `String` | No | `` |  |
| `envVar` | `String` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### getEnvironmentVariable (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] getEnvironmentVariable[a](System.String, a)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envKey` | `String` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### getEnvironmentVariable$W (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] getEnvironmentVariable$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String]], System.String, a)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Environment` | `FSharpFunc`2` | No | `` |  |
| `envKey` | `String` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### removeEnvironmentVariable (static) (generic)

**Signature:** `a removeEnvironmentVariable[a](System.String, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envKey` | `String` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### removeEnvironmentVariable$W (static) (generic)

**Signature:** `a removeEnvironmentVariable$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String],a]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String]], System.String, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withEnvironment` | `FSharpFunc`2` | No | `` |  |
| `get_Environment` | `FSharpFunc`2` | No | `` |  |
| `envKey` | `String` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setEnvironmentVariables (static) (generic)

**Signature:** `a setEnvironmentVariables[a](System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.String]], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `vars` | `IEnumerable`1` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setEnvironmentVariables$W (static) (generic)

**Signature:** `a setEnvironmentVariables$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String],a]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String]], System.Collections.Generic.IEnumerable`1[System.Tuple`2[System.String,System.String]], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withEnvironment` | `FSharpFunc`2` | No | `` |  |
| `get_Environment` | `FSharpFunc`2` | No | `` |  |
| `vars` | `IEnumerable`1` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### setCurrentEnvironmentVariables (static) (generic)

**Signature:** `a setCurrentEnvironmentVariables[a](a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `startInfo` | `a` | No | `` |  |

---

### setCurrentEnvironmentVariables$W (static) (generic)

**Signature:** `a setCurrentEnvironmentVariables$W[a](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String],a]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Collections.FSharpMap`2[System.String,System.String]], a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `withEnvironment` | `FSharpFunc`2` | No | `` |  |
| `get_Environment` | `FSharpFunc`2` | No | `` |  |
| `startInfo` | `a` | No | `` |  |

---

### killById (static)

**Signature:** `Void killById(Int32)`
**Return Type:** `Void`

**Description:** Kills all processes with the given id

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `id` | `Int32` | No | `` | The process id to kill |

---

### getFileName (static)

**Signature:** `System.String getFileName(System.Diagnostics.Process)`
**Return Type:** `String`

**Description:** Retrieve the file-path of the running executable of the given process.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `Process` | No | `` | The process instance to use |

---

### getAllByName (static)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Diagnostics.Process] getAllByName(System.String)`
**Return Type:** `IEnumerable`1`

**Description:** Returns all processes with the given name

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The process name |

---

### killAllByName (static)

**Signature:** `Void killAllByName(System.String)`
**Return Type:** `Void`

**Description:** Kills all processes with the given name

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The process name |

---

### killFSI (static)

**Signature:** `Void killFSI()`
**Return Type:** `Void`

**Description:** Kills the F# Interactive (FSI) process.

---

### killMSBuild (static)

**Signature:** `Void killMSBuild()`
**Return Type:** `Void`

**Description:** Kills the MSBuild process.

---

### killAllCreatedProcesses (static)

**Signature:** `Void killAllCreatedProcesses()`
**Return Type:** `Void`

**Description:** Kills all processes that are created by the FAKE build script unless "donotkill" flag was set.

---

### ensureProcessesHaveStopped (static)

**Signature:** `Void ensureProcessesHaveStopped(System.String, System.TimeSpan)`
**Return Type:** `Void`

**Description:** Waits until the processes with the given name have stopped or fails after given timeout.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the processes in question. |
| `timeout` | `TimeSpan` | No | `` | The timespan to time out after. |

---

### shellExec (static)

**Signature:** `Int32 shellExec(Fake.Core.ExecParams)`
**Return Type:** `Int32`

**Description:** Execute an external program and return the exit code.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `ExecParams` | No | `` | The execution arguments |

---

### get_monoVersion (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.String,Microsoft.FSharp.Core.FSharpOption`1[System.Version]]] get_monoVersion()`
**Return Type:** `FSharpOption`1`

---

### withFramework (static)

**Signature:** `Fake.Core.ProcStartInfo withFramework(Fake.Core.ProcStartInfo)`
**Return Type:** `ProcStartInfo`

**Description:** Ensures the executable is run with the full framework. On non-windows platforms that
 means running the tool by invoking 'mono'.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `proc` | `ProcStartInfo` | No | `` | The process start info |

---

## Properties

### setRedirectOutputToTrace (static)

**Type:** `FSharpFunc`2` (read-only)

---

### setEnableProcessTracing (static)

**Type:** `FSharpFunc`2` (read-only)

---

### AlwaysSetProcessEncoding (static)

**Type:** `Boolean` (read/write)

**Description:** If set to true the ProcessHelper will start all processes with a custom ProcessEncoding.
 If set to false (default) only mono processes will be changed.

---

### ProcessEncoding (static)

**Type:** `Encoding` (read/write)

**Description:** The ProcessHelper will start all processes with this encoding if AlwaysSetProcessEncoding is set to true.
 If AlwaysSetProcessEncoding is set to false (default) only mono processes will be changed.

---

### defaultEnvVar (static)

**Type:** `String` (read-only)

---

### monoVersion (static)

**Type:** `FSharpOption`1` (read-only)

---