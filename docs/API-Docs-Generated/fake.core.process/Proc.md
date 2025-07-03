# Proc Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Proc`

Module to start or run processes, used in combination with the CreateProcess API.

## Methods

### startRaw (static) (generic)

**Signature:** `System.Threading.Tasks.Task`1[Fake.Core.AsyncProcessResult`1[a]] startRaw[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### startRawSync (static) (generic)

**Signature:** `Fake.Core.AsyncProcessResult`1[a] startRawSync[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `AsyncProcessResult`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### start (static) (generic)

**Signature:** `System.Threading.Tasks.Task`1[a] start[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### startAndAwait (static) (generic)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[a] startAndAwait[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `FSharpAsync`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---

### run (static) (generic)

**Signature:** `a run[a](Fake.Core.CreateProcess`1[a])`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `CreateProcess`1` | No | `` |  |

---