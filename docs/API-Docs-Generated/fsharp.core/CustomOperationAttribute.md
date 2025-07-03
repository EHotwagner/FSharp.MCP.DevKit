# CustomOperationAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.CustomOperationAttribute`
- **Base Type:** `System.Attribute`

Indicates that a member on a computation builder type is a custom query operator,
 and indicates the name of that operator.

## Methods

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### get_AllowIntoPattern

**Signature:** `Boolean get_AllowIntoPattern()`
**Return Type:** `Boolean`

---

### set_AllowIntoPattern

**Signature:** `Void set_AllowIntoPattern(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_IsLikeZip

**Signature:** `Boolean get_IsLikeZip()`
**Return Type:** `Boolean`

---

### set_IsLikeZip

**Signature:** `Void set_IsLikeZip(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_IsLikeJoin

**Signature:** `Boolean get_IsLikeJoin()`
**Return Type:** `Boolean`

---

### set_IsLikeJoin

**Signature:** `Void set_IsLikeJoin(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_IsLikeGroupJoin

**Signature:** `Boolean get_IsLikeGroupJoin()`
**Return Type:** `Boolean`

---

### set_IsLikeGroupJoin

**Signature:** `Void set_IsLikeGroupJoin(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_JoinConditionWord

**Signature:** `System.String get_JoinConditionWord()`
**Return Type:** `String`

---

### set_JoinConditionWord

**Signature:** `Void set_JoinConditionWord(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### get_MaintainsVariableSpace

**Signature:** `Boolean get_MaintainsVariableSpace()`
**Return Type:** `Boolean`

---

### set_MaintainsVariableSpace

**Signature:** `Void set_MaintainsVariableSpace(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_MaintainsVariableSpaceUsingBind

**Signature:** `Boolean get_MaintainsVariableSpaceUsingBind()`
**Return Type:** `Boolean`

---

### set_MaintainsVariableSpaceUsingBind

**Signature:** `Void set_MaintainsVariableSpaceUsingBind(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

## Properties

### Name

**Type:** `String` (read-only)

**Description:** Get the name of the custom operation when used in a query or other computation expression

---

### AllowIntoPattern

**Type:** `Boolean` (read/write)

**Description:** Indicates if the custom operation supports the use of 'into' immediately after the use of the operation in a query or other computation expression to consume the results of the operation

---

### IsLikeZip

**Type:** `Boolean` (read/write)

**Description:** Indicates if the custom operation is an operation similar to a zip in a sequence computation, supporting two inputs

---

### IsLikeJoin

**Type:** `Boolean` (read/write)

**Description:** Indicates if the custom operation is an operation similar to a join in a sequence computation, supporting two inputs and a correlation constraint

---

### IsLikeGroupJoin

**Type:** `Boolean` (read/write)

**Description:** Indicates if the custom operation is an operation similar to a group join in a sequence computation, supporting two inputs and a correlation constraint, and generating a group

---

### JoinConditionWord

**Type:** `String` (read/write)

**Description:** Indicates the name used for the 'on' part of the custom query operator for join-like operators

---

### MaintainsVariableSpace

**Type:** `Boolean` (read/write)

**Description:** Indicates if the custom operation maintains the variable space of the query of computation expression

---

### MaintainsVariableSpaceUsingBind

**Type:** `Boolean` (read/write)

**Description:** Indicates if the custom operation maintains the variable space of the query of computation expression through the use of a bind operation

---