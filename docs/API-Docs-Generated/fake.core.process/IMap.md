# IMap Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.IMap`

## Methods

### empty (static) (generic)

**Signature:** `System.Collections.Immutable.IImmutableDictionary`2[key,value] empty[key,value]()`
**Return Type:** `IImmutableDictionary`2`

---

### tryFind (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[b] tryFind[a,b](a, System.Collections.Immutable.IImmutableDictionary`2[a,b])`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `k` | `a` | No | `` |  |
| `m` | `IImmutableDictionary`2` | No | `` |  |

---

### remove (static) (generic)

**Signature:** `System.Collections.Immutable.IImmutableDictionary`2[a,b] remove[a,b](a, System.Collections.Immutable.IImmutableDictionary`2[a,b])`
**Return Type:** `IImmutableDictionary`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `k` | `a` | No | `` |  |
| `m` | `IImmutableDictionary`2` | No | `` |  |

---

### iter (static) (generic)

**Signature:** `Void iter[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,Microsoft.FSharp.Core.Unit]], System.Collections.Immutable.IImmutableDictionary`2[a,b])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `m` | `IImmutableDictionary`2` | No | `` |  |

---

### add (static) (generic)

**Signature:** `System.Collections.Immutable.IImmutableDictionary`2[a,b] add[a,b](a, b, System.Collections.Immutable.IImmutableDictionary`2[a,b])`
**Return Type:** `IImmutableDictionary`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `k` | `a` | No | `` |  |
| `v` | `b` | No | `` |  |
| `m` | `IImmutableDictionary`2` | No | `` |  |

---

### toSeq (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[System.Tuple`2[a,b]] toSeq[a,b](System.Collections.Immutable.IImmutableDictionary`2[a,b])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `m` | `IImmutableDictionary`2` | No | `` |  |

---