# TaskBuilderModule Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.TaskBuilderModule`

Contains the `task` computation expression builder.

## Methods

### get_task (static)

**Signature:** `Microsoft.FSharp.Control.TaskBuilder get_task()`
**Return Type:** `TaskBuilder`

---

### get_backgroundTask (static)

**Signature:** `Microsoft.FSharp.Control.BackgroundTaskBuilder get_backgroundTask()`
**Return Type:** `BackgroundTaskBuilder`

---

## Properties

### task (static)

**Type:** `TaskBuilder` (read-only)

**Description:** Builds a task using computation expression syntax.

---

### backgroundTask (static)

**Type:** `BackgroundTaskBuilder` (read-only)

**Description:** Builds a task using computation expression syntax which switches to execute on a background thread if not
 already doing so.

---