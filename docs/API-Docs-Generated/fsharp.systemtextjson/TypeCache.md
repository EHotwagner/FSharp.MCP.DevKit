# TypeCache Class

**Namespace:** `System.Text.Json.Serialization`
**Full Name:** `System.Text.Json.Serialization.TypeCache`

## Methods

### get_getKind (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Type,System.Text.Json.Serialization.TypeCache+TypeKind] get_getKind()`
**Return Type:** `FSharpFunc`2`

---

### isUnion (static)

**Signature:** `Boolean isUnion(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `Type` | No | `` |  |

---

### isRecord (static)

**Signature:** `Boolean isRecord(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `Type` | No | `` |  |

---

### isList (static)

**Signature:** `Boolean isList(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `Type` | No | `` |  |

---

### isSet (static)

**Signature:** `Boolean isSet(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `Type` | No | `` |  |

---

### isMap (static)

**Signature:** `Boolean isMap(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `Type` | No | `` |  |

---

### isTuple (static)

**Signature:** `Boolean isTuple(System.Type)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `Type` | No | `` |  |

---

## Properties

### getKind (static)

**Type:** `FSharpFunc`2` (read-only)

**Description:** cached access to FSharpType.* and System.Type to prevent repeated access to reflection members

---