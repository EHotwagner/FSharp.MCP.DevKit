# CreateProcess Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.CreateProcess`

Module for creating and modifying CreateProcess<'TRes> instances.

## Methods

### fromCommand (static)

**Signature:** `Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[Microsoft.FSharp.Core.Unit]] fromCommand(Fake.Core.Command)`
**Return Type:** `CreateProcess`1`

**Description:** Create a simple CreateProcess<_> instance from the given command.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `command` | `Command` | No | `` |  |

---

### fromRawCommandLine (static)

**Signature:** `Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[Microsoft.FSharp.Core.Unit]] fromRawCommandLine(System.String, System.String)`
**Return Type:** `CreateProcess`1`

**Description:** Create a CreateProcess from the given file and arguments

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `command` | `String` | No | `` |  |
| `windowsCommandLine` | `String` | No | `` |  |

---

### fromRawCommand (static)

**Signature:** `Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[Microsoft.FSharp.Core.Unit]] fromRawCommand(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `command` | `String` | No | `` |  |
| `args` | `IEnumerable`1` | No | `` |  |

---

### ofStartInfo (static)

**Signature:** `Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[Microsoft.FSharp.Core.Unit]] ofStartInfo(System.Diagnostics.ProcessStartInfo)`
**Return Type:** `CreateProcess`1`

**Description:** Create a CreateProcess from the given ProcessStartInfo

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `ProcessStartInfo` | No | `` |  |

---

### interceptStream (static)

**Signature:** `Fake.Core.StreamSpecification interceptStream(System.IO.Stream, Fake.Core.StreamSpecification)`
**Return Type:** `StreamSpecification`

**Description:** Intercept the given StreamSpecification and writes the intercepted data into target.
 Throws if the stream is not redirected (ie is Inherit).

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `Stream` | No | `` | The target stream |
| `s` | `StreamSpecification` | No | `` | The target stream specification |

---

### copyRedirectedProcessOutputsToStandardOutputs (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] copyRedirectedProcessOutputsToStandardOutputs[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### withWorkingDirectory (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withWorkingDirectory[a](System.String, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `workDir` | `String` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### disableTraceCommand (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] disableTraceCommand[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### withCommand (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withCommand[a](Fake.Core.Command, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `command` | `Command` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### replaceFilePath (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] replaceFilePath[a](System.String, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newFilePath` | `String` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### mapFilePath (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] mapFilePath[a](Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.String], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### appendSimpleFuncs (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[c] appendSimpleFuncs[a,b,c](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,a], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Diagnostics.Process,Microsoft.FSharp.Core.Unit]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Control.FSharpAsync`1[b],Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Threading.Tasks.Task`1[Fake.Core.RawProcessResult],Microsoft.FSharp.Control.FSharpAsync`1[c]]]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit], Fake.Core.CreateProcess`1[b])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `prepareState` | `FSharpFunc`2` | No | `` |  |
| `onStart` | `FSharpFunc`2` | No | `` |  |
| `onResult` | `FSharpFunc`2` | No | `` |  |
| `onDispose` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### addOnSetup (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[b] addOnSetup[a,b](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,a], Fake.Core.CreateProcess`1[b])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### addOnFinally (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] addOnFinally[a](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### addOnStarted (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] addOnStarted[a](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### addOnStartedEx (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] addOnStartedEx[a](Microsoft.FSharp.Core.FSharpFunc`2[Fake.Core.StartedProcessInfo,Microsoft.FSharp.Core.Unit], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### withEnvironment (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withEnvironment[a](Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[System.String,System.String]], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `env` | `FSharpList`1` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### withEnvironmentMap (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withEnvironmentMap[a](System.Collections.Immutable.IImmutableDictionary`2[System.String,System.String], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `env` | `IImmutableDictionary`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### getEnvironmentMap (static) (generic)

**Signature:** `System.Collections.Immutable.IImmutableDictionary`2[System.String,System.String] getEnvironmentMap[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `IImmutableDictionary`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### setEnvironmentVariable (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] setEnvironmentVariable[a](System.String, System.String, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `envKey` | `String` | No | `` |  |
| `envVar` | `String` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### withStandardOutput (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withStandardOutput[a](Fake.Core.StreamSpecification, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stdOut` | `StreamSpecification` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### withStandardError (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withStandardError[a](Fake.Core.StreamSpecification, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stdErr` | `StreamSpecification` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### withStandardInput (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withStandardInput[a](Fake.Core.StreamSpecification, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stdIn` | `StreamSpecification` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### map (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[b] map[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,b], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### mapResult (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[b]] mapResult[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,b], Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[a]])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### redirectOutput (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[Fake.Core.ProcessResult`1[Fake.Core.ProcessOutput]] redirectOutput[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### redirectOutputIfNotRedirected (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] redirectOutputIfNotRedirected[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### withOutputEvents (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withOutputEvents[a](Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `onStdOut` | `FSharpFunc`2` | No | `` |  |
| `onStdErr` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### withOutputEventsNotNull (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withOutputEventsNotNull[a](Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `onStdOut` | `FSharpFunc`2` | No | `` |  |
| `onStdErr` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### addOnExited (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[b] addOnExited[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,b]], Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---

### ensureExitCodeWithMessage (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] ensureExitCodeWithMessage[a](System.String, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |
| `r` | `CreateProcess`1` | No | `` |  |

---

### ensureExitCode (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] ensureExitCode[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `r` | `CreateProcess`1` | No | `` |  |

---

### warnOnExitCode (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] warnOnExitCode[a](System.String, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |
| `r` | `CreateProcess`1` | No | `` |  |

---

### withTimeout (static) (generic)

**Signature:** `Fake.Core.CreateProcess`1[a] withTimeout[a](System.TimeSpan, Fake.Core.CreateProcess`1[a])`
**Return Type:** `CreateProcess`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `timeout` | `TimeSpan` | No | `` |  |
| `c` | `CreateProcess`1` | No | `` |  |

---