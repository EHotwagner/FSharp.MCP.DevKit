# TargetContext Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TargetContext`

## Methods

### get_PreviousTargets

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.TargetResult] get_PreviousTargets()`
**Return Type:** `FSharpList`1`

---

### get_AllExecutingTargets

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.Target] get_AllExecutingTargets()`
**Return Type:** `FSharpList`1`

---

### get_FinalTarget

**Signature:** `System.String get_FinalTarget()`
**Return Type:** `String`

---

### get_Arguments

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] get_Arguments()`
**Return Type:** `FSharpList`1`

---

### get_IsRunningFinalTargets

**Signature:** `Boolean get_IsRunningFinalTargets()`
**Return Type:** `Boolean`

---

### get_CancellationToken

**Signature:** `System.Threading.CancellationToken get_CancellationToken()`
**Return Type:** `CancellationToken`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Create (static)

**Signature:** `Fake.Core.TargetContext Create(System.String, Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.Target], Microsoft.FSharp.Collections.FSharpList`1[System.String], System.Threading.CancellationToken)`
**Return Type:** `TargetContext`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ft` | `String` | No | `` |  |
| `all` | `FSharpList`1` | No | `` |  |
| `args` | `FSharpList`1` | No | `` |  |
| `token` | `CancellationToken` | No | `` |  |

---

### get_HasError

**Signature:** `Boolean get_HasError()`
**Return Type:** `Boolean`

---

### TryFindPrevious

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Fake.Core.TargetResult] TryFindPrevious(System.String)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### TryFindTarget

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Fake.Core.Target] TryFindTarget(System.String)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### get_ErrorTargets

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[System.Exception,Fake.Core.Target]] get_ErrorTargets()`
**Return Type:** `FSharpList`1`

---

## Properties

### PreviousTargets

**Type:** `FSharpList`1` (read-only)

---

### AllExecutingTargets

**Type:** `FSharpList`1` (read-only)

---

### FinalTarget

**Type:** `String` (read-only)

---

### Arguments

**Type:** `FSharpList`1` (read-only)

---

### IsRunningFinalTargets

**Type:** `Boolean` (read-only)

---

### CancellationToken

**Type:** `CancellationToken` (read-only)

---

### HasError

**Type:** `Boolean` (read-only)

---

### ErrorTargets

**Type:** `FSharpList`1` (read-only)

---