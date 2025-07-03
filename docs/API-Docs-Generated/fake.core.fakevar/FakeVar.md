# FakeVar Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.FakeVar`

This module contains helpers for managing build time variables

## Methods

### get (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[a] get[a](System.String)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### getOrFail (static) (generic)

**Signature:** `a getOrFail[a](System.String)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### getOrDefault (static) (generic)

**Signature:** `a getOrDefault[a](System.String, a)`
**Return Type:** `a`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `defaultValue` | `a` | No | `` |  |

---

### remove (static)

**Signature:** `Void remove(System.String)`
**Return Type:** `Void`

**Description:** Removes a FakeVar by name

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The name of the FakeVar |

---

### set (static) (generic)

**Signature:** `Void set[a](System.String, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `v` | `a` | No | `` |  |

---

### define (static) (generic)

**Signature:** `System.Tuple`3[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.FSharpOption`1[a]],Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit]] define[a](System.String)`
**Return Type:** `Tuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### defineAllowNoContext (static) (generic)

**Signature:** `System.Tuple`3[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.FSharpOption`1[a]],Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit]] defineAllowNoContext[a](System.String)`
**Return Type:** `Tuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

### defineOrNone (static) (generic)

**Signature:** `System.Tuple`3[Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.FSharpOption`1[a]],Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,Microsoft.FSharp.Core.Unit],Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit]] defineOrNone[a](System.String)`
**Return Type:** `Tuple`3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---