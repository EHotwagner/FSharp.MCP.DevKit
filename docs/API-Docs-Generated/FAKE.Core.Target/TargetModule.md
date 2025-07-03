# TargetModule Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TargetModule`

FAKE Target module contains tasks to define and run targets.

## Methods

### get_setPrintStackTraceOnError (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,Microsoft.FSharp.Core.Unit] get_setPrintStackTraceOnError()`
**Return Type:** `FSharpFunc`2`

---

### get_setLastDescription (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit] get_setLastDescription()`
**Return Type:** `FSharpFunc`2`

---

### get_removeLastDescription (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit] get_removeLastDescription()`
**Return Type:** `FSharpFunc`2`

---

### get_setCollectStack (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Boolean,Microsoft.FSharp.Core.Unit] get_setCollectStack()`
**Return Type:** `FSharpFunc`2`

---

### get_removeCollectStack (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit] get_removeCollectStack()`
**Return Type:** `FSharpFunc`2`

---

### description (static)

**Signature:** `Void description(System.String)`
**Return Type:** `Void`

**Description:** Sets the Description for the next target.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` | The description of the next target |

---

### get (static)

**Signature:** `Fake.Core.Target get(System.String)`
**Return Type:** `Target`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### runSimple (static)

**Signature:** `Fake.Core.TargetResult runSimple(System.String, Microsoft.FSharp.Collections.FSharpList`1[System.String])`
**Return Type:** `TargetResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `args` | `FSharpList`1` | No | `` |  |

---

### runSimpleWithContext (static)

**Signature:** `Fake.Core.TargetResult runSimpleWithContext(System.String, Fake.Core.TargetContext)`
**Return Type:** `TargetResult`

**Description:** This simply runs the function of a target without doing anything (like tracing, stop watching or
 adding it to the results at the end)

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The target name |
| `ctx` | `TargetContext` | No | `` | The context object |

---

### create (static)

**Signature:** `Void create(System.String, Microsoft.FSharp.Core.FSharpFunc`2[Fake.Core.TargetParameter,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### listAvailable (static)

**Signature:** `Void listAvailable()`
**Return Type:** `Void`

**Description:** List all targets available.

---

### printDependencyGraph (static)

**Signature:** `Void printDependencyGraph(Boolean, System.String)`
**Return Type:** `Void`

**Description:** Writes a dependency graph.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `verbose` | `Boolean` | No | `` | Whether to print verbose output or not. |
| `target` | `String` | No | `` | The target for which the dependencies should be printed. |

---

### createBuildFailure (static)

**Signature:** `Void createBuildFailure(System.String, Microsoft.FSharp.Core.FSharpFunc`2[Fake.Core.TargetParameter,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### activateBuildFailure (static)

**Signature:** `Void activateBuildFailure(System.String)`
**Return Type:** `Void`

**Description:** Activates the build failure target.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The target name |

---

### deactivateBuildFailure (static)

**Signature:** `Void deactivateBuildFailure(System.String)`
**Return Type:** `Void`

**Description:** Deactivates the build failure target.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The target name |

---

### createFinal (static)

**Signature:** `Void createFinal(System.String, Microsoft.FSharp.Core.FSharpFunc`2[Fake.Core.TargetParameter,Microsoft.FSharp.Core.Unit])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### activateFinal (static)

**Signature:** `Void activateFinal(System.String)`
**Return Type:** `Void`

**Description:** Activates the final target.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The target name |

---

### deactivateFinal (static)

**Signature:** `Void deactivateFinal(System.String)`
**Return Type:** `Void`

**Description:** Deactivates the final target.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The target name |

---

### updateBuildStatus (static)

**Signature:** `Void updateBuildStatus(OptionalTargetContext)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `context` | `OptionalTargetContext` | No | `` |  |

---

### raiseIfError (static)

**Signature:** `Void raiseIfError(OptionalTargetContext)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `context` | `OptionalTargetContext` | No | `` |  |

---

### initEnvironment (static)

**Signature:** `Void initEnvironment()`
**Return Type:** `Void`

**Description:** Allows to initialize the environment before defining targets

---

### getArguments (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String[]] getArguments()`
**Return Type:** `FSharpOption`1`

**Description:** Allows to retrieve the arguments passed into the current execution,
 when Target.run*withArguments overloads are used, see
 Targets with arguments

---

### run (static)

**Signature:** `Void run(Int32, System.String, Microsoft.FSharp.Collections.FSharpList`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parallelJobs` | `Int32` | No | `` |  |
| `targetName` | `String` | No | `` |  |
| `args` | `FSharpList`1` | No | `` |  |

---

### runOrDefault (static)

**Signature:** `Void runOrDefault(System.String)`
**Return Type:** `Void`

**Description:** Runs the command given on the command line or the given target when no target is given

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `defaultTarget` | `String` | No | `` |  |

---

### runOrDefaultWithArguments (static)

**Signature:** `Void runOrDefaultWithArguments(System.String)`
**Return Type:** `Void`

**Description:** Runs the command given on the command line or the given target when no target is given

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `defaultTarget` | `String` | No | `` |  |

---

### runOrList (static)

**Signature:** `Void runOrList()`
**Return Type:** `Void`

**Description:** Runs the target given by the target parameter or lists the available targets

---

## Properties

### setPrintStackTraceOnError (static)

**Type:** `FSharpFunc`2` (read-only)

---

### setLastDescription (static)

**Type:** `FSharpFunc`2` (read-only)

---

### removeLastDescription (static)

**Type:** `FSharpFunc`2` (read-only)

---

### setCollectStack (static)

**Type:** `FSharpFunc`2` (read-only)

---

### removeCollectStack (static)

**Type:** `FSharpFunc`2` (read-only)

---