# Shell Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Shell`

Allows to exec shell operations synchronously and asynchronously.

## Methods

### Exec (static)

**Signature:** `Int32 Exec(System.String, Microsoft.FSharp.Core.FSharpOption`1[System.String], Microsoft.FSharp.Core.FSharpOption`1[System.String])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cmd` | `String` | No | `` |  |
| `args` | `FSharpOption`1` | No | `` |  |
| `dir` | `FSharpOption`1` | No | `` |  |

---

### AsyncExec (static)

**Signature:** `Int32 AsyncExec(System.String, Microsoft.FSharp.Core.FSharpOption`1[System.String], Microsoft.FSharp.Core.FSharpOption`1[System.String])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cmd` | `String` | No | `` |  |
| `args` | `FSharpOption`1` | No | `` |  |
| `dir` | `FSharpOption`1` | No | `` |  |

---