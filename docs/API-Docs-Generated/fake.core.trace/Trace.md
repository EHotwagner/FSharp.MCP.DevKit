# Trace Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Trace`

This module contains function which allow to trace build output

## Methods

### setVerbose (static)

**Signature:** `Void setVerbose()`
**Return Type:** `Void`

---

### log (static)

**Signature:** `Void log(System.String)`
**Return Type:** `Void`

**Description:** Logs the specified string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `String` | No | `` | The message to log |

---

### isVerbose (static)

**Signature:** `Boolean isVerbose(Boolean)`
**Return Type:** `Boolean`

**Description:** Checks if FAKE is running in verbose mode

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `printHint` | `Boolean` | No | `` | Flag to mark if a hint will be written to log for verbosity |

---

### logfn (static) (generic)

**Signature:** `a logfn[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### logf (static) (generic)

**Signature:** `a logf[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### logVerbosefn (static) (generic)

**Signature:** `a logVerbosefn[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### trace (static)

**Signature:** `Void trace(System.String)`
**Return Type:** `Void`

**Description:** Writes a trace to the command line (in green)

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `String` | No | `` | The message to log |

---

### tracefn (static) (generic)

**Signature:** `a tracefn[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### tracef (static) (generic)

**Signature:** `a tracef[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### traceVerbose (static)

**Signature:** `Void traceVerbose(System.String)`
**Return Type:** `Void`

**Description:** Writes a trace to the command line (in green) if the verbose mode is activated.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` | The message to trace |

---

### traceImportant (static)

**Signature:** `Void traceImportant(System.String)`
**Return Type:** `Void`

**Description:** Writes a trace to stderr (in yellow)

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` | The text to trace |

---

### traceImportantfn (static) (generic)

**Signature:** `a traceImportantfn[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### traceFAKE (static) (generic)

**Signature:** `a traceFAKE[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### traceError (static)

**Signature:** `Void traceError(System.String)`
**Return Type:** `Void`

**Description:** Traces an error (in red)

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `error` | `String` | No | `` | The error message to trace |

---

### traceErrorfn (static) (generic)

**Signature:** `a traceErrorfn[a](Microsoft.FSharp.Core.PrintfFormat`4[a,Microsoft.FSharp.Core.Unit,System.String,Microsoft.FSharp.Core.Unit])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fmt` | `PrintfFormat`4` | No | `` |  |

---

### exceptionAndInnersToString (static)

**Signature:** `System.String exceptionAndInnersToString(System.Exception)`
**Return Type:** `String`

**Description:** Converts an exception and its inner exceptions to a nice string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ex` | `Exception` | No | `` | The exception to convert |

---

### traceException (static)

**Signature:** `Void traceException(System.Exception)`
**Return Type:** `Void`

**Description:** Traces an exception details (in red)

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ex` | `Exception` | No | `` | The exception to trace |

---

### traceEnvironmentVariables (static)

**Signature:** `Void traceEnvironmentVariables()`
**Return Type:** `Void`

**Description:** Traces the EnvironmentVariables

---

### traceLine (static)

**Signature:** `Void traceLine()`
**Return Type:** `Void`

**Description:** Traces a line

---

### traceHeader (static)

**Signature:** `Void traceHeader(System.String)`
**Return Type:** `Void`

**Description:** Traces a header

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The header value |

---

### openTagUnsafe (static)

**Signature:** `Void openTagUnsafe(Fake.Core.KnownTags, System.String)`
**Return Type:** `Void`

**Description:** Puts an opening tag on the internal tag stack

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tag` | `KnownTags` | No | `` | The tag to insert |
| `description` | `String` | No | `` | The tag description |

---

### closeTagUnsafeEx (static)

**Signature:** `Void closeTagUnsafeEx(Fake.Core.TagStatus, Fake.Core.KnownTags)`
**Return Type:** `Void`

**Description:** Removes an opening tag from the internal tag stack

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `status` | `TagStatus` | No | `` |  |
| `tag` | `KnownTags` | No | `` | The tag to close |

---

### closeTagUnsafe (static)

**Signature:** `Void closeTagUnsafe(Fake.Core.KnownTags)`
**Return Type:** `Void`

**Description:** Removes an opening tag from the internal tag stack

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tag` | `KnownTags` | No | `` | The tag to insert |

---

### traceTag (static)

**Signature:** `ISafeDisposable traceTag(Fake.Core.KnownTags, System.String)`
**Return Type:** `ISafeDisposable`

**Description:** Traces a tag

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tag` | `KnownTags` | No | `` | The tag to trace |
| `description` | `String` | No | `` | the tag description |

---

### setBuildStateWithMessage (static)

**Signature:** `Void setBuildStateWithMessage(Fake.Core.TagStatus, System.String)`
**Return Type:** `Void`

**Description:** Set build state with the given tag and message

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tag` | `TagStatus` | No | `` | The tag to trace |
| `message` | `String` | No | `` | the build message |

---

### setBuildState (static)

**Signature:** `Void setBuildState(Fake.Core.TagStatus)`
**Return Type:** `Void`

**Description:** Set build state with the given tag

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tag` | `TagStatus` | No | `` | The tag to trace |

---

### testStatus (static)

**Signature:** `Void testStatus(System.String, Fake.Core.TestStatus)`
**Return Type:** `Void`

**Description:** Set status for the given test

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `testName` | `String` | No | `` | The test name |
| `testStatus` | `TestStatus` | No | `` | The test status |

---

### testOutput (static)

**Signature:** `Void testOutput(System.String, System.String, System.String)`
**Return Type:** `Void`

**Description:** Trace test output and errors

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `testName` | `String` | No | `` | The test name |
| `out` | `String` | No | `` | The test output |
| `err` | `String` | No | `` | The test error |

---

### publish (static)

**Signature:** `Void publish(Fake.Core.ImportData, System.String)`
**Return Type:** `Void`

**Description:** Publish given type in given path

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `ImportData` | No | `` | The type to publish |
| `path` | `String` | No | `` | The path to publish type to |

---

### setBuildNumber (static)

**Signature:** `Void setBuildNumber(System.String)`
**Return Type:** `Void`

**Description:** Trace the given build number

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `number` | `String` | No | `` | The build number to trace |

---

### closeAllOpenTags (static)

**Signature:** `Void closeAllOpenTags()`
**Return Type:** `Void`

**Description:** Closes all opened tags

---

### traceStartTargetUnsafe (static)

**Signature:** `Void traceStartTargetUnsafe(System.String, System.String, System.String)`
**Return Type:** `Void`

**Description:** Traces the begin of a target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |
| `description` | `String` | No | `` | The description of the target |
| `dependencyString` | `String` | No | `` | The target dependency string |

---

### traceStartFinalTargetUnsafe (static)

**Signature:** `Void traceStartFinalTargetUnsafe(System.String, System.String, System.String)`
**Return Type:** `Void`

**Description:** Traces the begin of a final target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |
| `description` | `String` | No | `` | The description of the target |
| `dependencyString` | `String` | No | `` | The target dependency string |

---

### traceStartFailureTargetUnsafe (static)

**Signature:** `Void traceStartFailureTargetUnsafe(System.String, System.String, System.String)`
**Return Type:** `Void`

**Description:** Traces the begin of a failure target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |
| `description` | `String` | No | `` | The description of the target |
| `dependencyString` | `String` | No | `` | The target dependency string |

---

### traceEndTargetUnsafeEx (static)

**Signature:** `Void traceEndTargetUnsafeEx(Fake.Core.TagStatus, System.String)`
**Return Type:** `Void`

**Description:** Traces the end of a target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TagStatus` | No | `` | The target state |
| `name` | `String` | No | `` | The name of the target |

---

### traceEndFinalTargetUnsafeEx (static)

**Signature:** `Void traceEndFinalTargetUnsafeEx(Fake.Core.TagStatus, System.String)`
**Return Type:** `Void`

**Description:** Traces the end of a final target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TagStatus` | No | `` | The target state |
| `name` | `String` | No | `` | The name of the target |

---

### traceEndFailureTargetUnsafeEx (static)

**Signature:** `Void traceEndFailureTargetUnsafeEx(Fake.Core.TagStatus, System.String)`
**Return Type:** `Void`

**Description:** Traces the end of a failure target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TagStatus` | No | `` | The target state |
| `name` | `String` | No | `` | The name of the target |

---

### traceEndTargetUnsafe (static)

**Signature:** `Void traceEndTargetUnsafe(System.String)`
**Return Type:** `Void`

**Description:** Traces the end of a target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |

---

### traceTarget (static)

**Signature:** `ISafeDisposable traceTarget(System.String, System.String, System.String)`
**Return Type:** `ISafeDisposable`

**Description:** Traces a target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |
| `description` | `String` | No | `` | The description of the target |
| `dependencyString` | `String` | No | `` | The target dependency string |

---

### traceFinalTarget (static)

**Signature:** `ISafeDisposable traceFinalTarget(System.String, System.String, System.String)`
**Return Type:** `ISafeDisposable`

**Description:** Traces a final target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |
| `description` | `String` | No | `` | The description of the target |
| `dependencyString` | `String` | No | `` | The target dependency string |

---

### traceFailureTarget (static)

**Signature:** `ISafeDisposable traceFailureTarget(System.String, System.String, System.String)`
**Return Type:** `ISafeDisposable`

**Description:** Traces a failed target

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the target |
| `description` | `String` | No | `` | The description of the target |
| `dependencyString` | `String` | No | `` | The target dependency string |

---

### traceStartTaskUnsafe (static)

**Signature:** `Void traceStartTaskUnsafe(System.String, System.String)`
**Return Type:** `Void`

**Description:** Traces the begin of a task

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `task` | `String` | No | `` | The name of the task |
| `description` | `String` | No | `` | The description of the task |

---

### traceEndTaskUnsafeEx (static)

**Signature:** `Void traceEndTaskUnsafeEx(Fake.Core.TagStatus, System.String)`
**Return Type:** `Void`

**Description:** Traces the end of a task

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `TagStatus` | No | `` | The state of the task |
| `task` | `String` | No | `` | The name of the task |

---

### traceEndTaskUnsafe (static)

**Signature:** `Void traceEndTaskUnsafe(System.String)`
**Return Type:** `Void`

**Description:** Traces the end of a task

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `task` | `String` | No | `` | The name of the task |

---

### traceTask (static)

**Signature:** `ISafeDisposable traceTask(System.String, System.String)`
**Return Type:** `ISafeDisposable`

**Description:** Wrap functions in a 'use' of this function

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the task |
| `description` | `String` | No | `` | The description of the task |

---

### useWith (static) (generic)

**Signature:** `a useWith[a](Boolean, Microsoft.FSharp.Core.FSharpFunc`2[Fake.Core.Trace+ISafeDisposable,a], ISafeDisposable)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `automaticSuccess` | `Boolean` | No | `` |  |
| `func` | `FSharpFunc`2` | No | `` |  |
| `trace` | `ISafeDisposable` | No | `` |  |

---

### logToConsole (static)

**Signature:** `Void logToConsole(System.String, EventLogEntryType)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |
| `eventLogEntry` | `EventLogEntryType` | No | `` |  |

---

### logItems (static)

**Signature:** `Void logItems(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `String` | No | `` |  |
| `items` | `IEnumerable`1` | No | `` |  |

---