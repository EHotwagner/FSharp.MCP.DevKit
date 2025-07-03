# TargetOperators Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TargetOperators`

Provides functions and operators to deal with FAKE targets and target dependencies.

## Methods

### op_Dynamic (static) (generic)

**Signature:** `b op_Dynamic[a,b](Microsoft.FSharp.Core.FSharpFunc`2[a,b], a)`
**Return Type:** `b`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `s` | `a` | No | `` |  |

---

### op_DynamicAssignment (static) (generic)

**Signature:** `c op_DynamicAssignment[a,b,c](Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.FSharpFunc`2[b,c]], a, b)`
**Return Type:** `c`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `str` | `a` | No | `` |  |
| `action` | `b` | No | `` |  |

---

### op_LessEqualsEquals (static)

**Signature:** `Void op_LessEqualsEquals(System.String, Microsoft.FSharp.Collections.FSharpList`1[System.String])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |
| `y` | `FSharpList`1` | No | `` |  |

---

### op_EqualsEqualsGreater (static)

**Signature:** `System.String op_EqualsEqualsGreater(System.String, System.String)`
**Return Type:** `String`

**Description:** Defines a dependency - y is dependent on x

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |
| `y` | `String` | No | `` |  |

---

### op_QmarkEqualsGreater (static)

**Signature:** `System.String op_QmarkEqualsGreater(System.String, System.String)`
**Return Type:** `String`

**Description:** Defines a soft dependency. x must run before y, if it is present, but y does not require x to be run.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |
| `y` | `String` | No | `` |  |

---

### op_LessEqualsQmark (static)

**Signature:** `System.String op_LessEqualsQmark(System.String, System.String)`
**Return Type:** `String`

**Description:** Defines a soft dependency. x must run before y, if it is present, but y does not require x to be run.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `y` | `String` | No | `` |  |
| `x` | `String` | No | `` |  |

---

### op_LessEqualsGreater (static)

**Signature:** `System.String op_LessEqualsGreater(System.String, System.String)`
**Return Type:** `String`

**Description:** Defines that x and y are not dependent on each other but y is dependent on all dependencies of x.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |
| `y` | `String` | No | `` |  |

---

### op_EqualsQmarkGreater (static)

**Signature:** `System.String op_EqualsQmarkGreater(System.String, System.String, Boolean)`
**Return Type:** `String`

**Description:** Defines a conditional dependency - y is dependent on x if the condition is true

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |
| `y` | `String` | No | `` |  |
| `condition` | `Boolean` | No | `` |  |

---