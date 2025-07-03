# ErrorMessageList Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.ErrorMessageList`
- **Implements:** `System.IEquatable`1[[FParsec.ErrorMessageList, FParsecCS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=40ccfc0a09edbb5d]]`

## Methods

### Merge (static)

**Signature:** `FParsec.ErrorMessageList Merge(FParsec.ErrorMessageList, FParsec.ErrorMessageList)`
**Return Type:** `ErrorMessageList`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list1` | `ErrorMessageList` | No | `` |  |
| `list2` | `ErrorMessageList` | No | `` |  |

---

### ToHashSet (static)

**Signature:** `System.Collections.Generic.HashSet`1[FParsec.ErrorMessage] ToHashSet(FParsec.ErrorMessageList)`
**Return Type:** `HashSet`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `messages` | `ErrorMessageList` | No | `` |  |

---

### ToSortedArray (static)

**Signature:** `FParsec.ErrorMessage[] ToSortedArray(FParsec.ErrorMessageList)`
**Return Type:** `ErrorMessage[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `messages` | `ErrorMessageList` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(FParsec.ErrorMessageList)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `other` | `ErrorMessageList` | No | `` |  |

---

### op_Equality (static)

**Signature:** `Boolean op_Equality(FParsec.ErrorMessageList, FParsec.ErrorMessageList)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `ErrorMessageList` | No | `` |  |
| `right` | `ErrorMessageList` | No | `` |  |

---

### op_Inequality (static)

**Signature:** `Boolean op_Inequality(FParsec.ErrorMessageList, FParsec.ErrorMessageList)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `left` | `ErrorMessageList` | No | `` |  |
| `right` | `ErrorMessageList` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---