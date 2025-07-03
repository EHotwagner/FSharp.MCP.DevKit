# Primitives Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.Primitives`

## Methods

### preturn (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] preturn[a,u](a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `a` | No | `` |  |

---

### pzero (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] pzero[a,u]()`
**Return Type:** `FSharpFunc`2`

---

### op_GreaterGreaterEquals (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] op_GreaterGreaterEquals[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### op_GreaterGreaterPercent (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] op_GreaterGreaterPercent[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], b)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `x` | `b` | No | `` |  |

---

### op_GreaterGreaterDot (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] op_GreaterGreaterDot[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `q` | `FSharpFunc`2` | No | `` |  |

---

### op_DotGreaterGreater (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] op_DotGreaterGreater[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `q` | `FSharpFunc`2` | No | `` |  |

---

### op_DotGreaterGreaterDot (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Tuple`2[a,b]]] op_DotGreaterGreaterDot[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `q` | `FSharpFunc`2` | No | `` |  |

---

### between (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]] between[a,u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `popen` | `FSharpFunc`2` | No | `` |  |
| `pclose` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### op_BarGreaterGreater (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] op_BarGreaterGreater[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[a,b])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### pipe2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]] pipe2[a,u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### pipe3 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[d]] pipe3[a,u,b,c,d](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,Microsoft.FSharp.Core.FSharpFunc`2[c,d]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `p3` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### pipe4 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[e]] pipe4[a,u,b,c,d,e](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[d]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,Microsoft.FSharp.Core.FSharpFunc`2[c,Microsoft.FSharp.Core.FSharpFunc`2[d,e]]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `p3` | `FSharpFunc`2` | No | `` |  |
| `p4` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### pipe5 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[f]] pipe5[a,u,b,c,d,e,f](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[d]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[e]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,Microsoft.FSharp.Core.FSharpFunc`2[c,Microsoft.FSharp.Core.FSharpFunc`2[d,Microsoft.FSharp.Core.FSharpFunc`2[e,f]]]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `p3` | `FSharpFunc`2` | No | `` |  |
| `p4` | `FSharpFunc`2` | No | `` |  |
| `p5` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### op_LessBarGreater (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] op_LessBarGreater[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |

---

### choice (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] choice[a,u](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ps` | `IEnumerable`1` | No | `` |  |

---

### choiceL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] choiceL[a,u](System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]]], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ps` | `IEnumerable`1` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### op_LessBarGreaterPercent (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] op_LessBarGreaterPercent[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `x` | `a` | No | `` |  |

---

### opt (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.FSharpOption`1[a]]] opt[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### optional (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] optional[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### attempt (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] attempt[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### op_GreaterGreaterEqualsQmark (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] op_GreaterGreaterEqualsQmark[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### op_GreaterGreaterQmark (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] op_GreaterGreaterQmark[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `q` | `FSharpFunc`2` | No | `` |  |

---

### op_DotGreaterGreaterDotQmark (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Tuple`2[a,b]]] op_DotGreaterGreaterDotQmark[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `q` | `FSharpFunc`2` | No | `` |  |

---

### op_DotGreaterGreaterQmark (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] op_DotGreaterGreaterQmark[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `q` | `FSharpFunc`2` | No | `` |  |

---

### notEmpty (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] notEmpty[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### followedBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] followedBy[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### followedByL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] followedByL[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### notFollowedBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] notFollowedBy[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### notFollowedByL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] notFollowedByL[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### lookAhead (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] lookAhead[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### op_LessQmarkGreater (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] op_LessQmarkGreater[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### op_LessQmarkQmarkGreater (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] op_LessQmarkQmarkGreater[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### fail (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] fail[a,u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |

---

### failFatally (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] failFatally[a,u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |

---

### tuple2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Tuple`2[a,b]]] tuple2[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |

---

### tuple3 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Tuple`3[a,b,c]]] tuple3[a,u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `p3` | `FSharpFunc`2` | No | `` |  |

---

### tuple4 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Tuple`4[a,b,c,d]]] tuple4[a,u,b,c,d](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[d]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `p3` | `FSharpFunc`2` | No | `` |  |
| `p4` | `FSharpFunc`2` | No | `` |  |

---

### tuple5 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Tuple`5[a,b,c,d,e]]] tuple5[a,u,b,c,d,e](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[d]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[e]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p2` | `FSharpFunc`2` | No | `` |  |
| `p3` | `FSharpFunc`2` | No | `` |  |
| `p4` | `FSharpFunc`2` | No | `` |  |
| `p5` | `FSharpFunc`2` | No | `` |  |

---

### parray (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a[]]] parray[a,u](Int32, Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `n` | `Int32` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### skipArray (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipArray[a,u](Int32, Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `n` | `Int32` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### many (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] many[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### many1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] many1[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### skipMany (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### skipMany1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany1[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### sepBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] sepBy[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### sepBy1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] sepBy1[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### skipSepBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipSepBy[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### skipSepBy1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipSepBy1[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### sepEndBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] sepEndBy[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### sepEndBy1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] sepEndBy1[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### skipSepEndBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipSepEndBy[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### skipSepEndBy1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipSepEndBy1[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### manyTill (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] manyTill[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### many1Till (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Collections.FSharpList`1[a]]] many1Till[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### skipManyTill (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManyTill[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### skipMany1Till (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany1Till[a,u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### chainl1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] chainl1[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[a,a]]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `op` | `FSharpFunc`2` | No | `` |  |

---

### chainl (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] chainl[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[a,a]]]], a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `op` | `FSharpFunc`2` | No | `` |  |
| `x` | `a` | No | `` |  |

---

### chainr1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] chainr1[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[a,a]]]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `op` | `FSharpFunc`2` | No | `` |  |

---

### chainr (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] chainr[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[a,a]]]], a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `op` | `FSharpFunc`2` | No | `` |  |
| `x` | `a` | No | `` |  |

---

### get_parse (static)

**Signature:** `ParserCombinator get_parse()`
**Return Type:** `ParserCombinator`

---

### createParserForwardedToRef (static) (generic)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]],Microsoft.FSharp.Core.FSharpRef`1[Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]]]] createParserForwardedToRef[a,u]()`
**Return Type:** `Tuple`2`

---

## Properties

### parse (static)

**Type:** `ParserCombinator` (read-only)

**Description:** The builder object for building parsers using F#'s computation expression syntax.

---