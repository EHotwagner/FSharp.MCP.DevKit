# ChangeWatcher Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.ChangeWatcher`

This module contains helpers to react to file system events.

## Methods

### runWithOptions (static)

**Signature:** `System.IDisposable runWithOptions(Microsoft.FSharp.Core.FSharpFunc`2[Fake.IO.ChangeWatcher+Options,Fake.IO.ChangeWatcher+Options], Microsoft.FSharp.Core.FSharpFunc`2[System.Collections.Generic.IEnumerable`1[Fake.IO.FileChange],Microsoft.FSharp.Core.Unit], Fake.IO.IGlobbingPattern)`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fOptions` | `FSharpFunc`2` | No | `` |  |
| `onChange` | `FSharpFunc`2` | No | `` |  |
| `fileIncludes` | `IGlobbingPattern` | No | `` |  |

---

### run (static)

**Signature:** `System.IDisposable run(Microsoft.FSharp.Core.FSharpFunc`2[System.Collections.Generic.IEnumerable`1[Fake.IO.FileChange],Microsoft.FSharp.Core.Unit], Fake.IO.IGlobbingPattern)`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `onChange` | `FSharpFunc`2` | No | `` |  |
| `fileIncludes` | `IGlobbingPattern` | No | `` |  |

---