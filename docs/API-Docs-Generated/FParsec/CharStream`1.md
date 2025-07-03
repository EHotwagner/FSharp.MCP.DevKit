# CharStream`1 Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.CharStream`1`
- **Base Type:** `FParsec.CharStream`
- **Implements:** `System.IDisposable`
- **Generic Parameters:** `<TUserState>`

Provides read‐access to a sequence of UTF‐16 chars.

## Methods

### get_UserState

**Signature:** `TUserState get_UserState()`
**Return Type:** `TUserState`

---

### set_UserState

**Signature:** `Void set_UserState(TUserState)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TUserState` | No | `` |  |

---

### get_State

**Signature:** `FParsec.CharStreamState`1[TUserState] get_State()`
**Return Type:** `CharStreamState`1`

---

### BacktrackTo

**Signature:** `Void BacktrackTo(FParsec.CharStreamState`1[TUserState])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `CharStreamState`1` | No | `` |  |

---

### BacktrackTo

**Signature:** `Void BacktrackTo(FParsec.CharStreamState`1[TUserState] ByRef)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `CharStreamState`1&` | No | `` |  |

---

### ReadFrom

**Signature:** `System.String ReadFrom(FParsec.CharStreamState`1[TUserState], Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stateWhereStringBegins` | `CharStreamState`1` | No | `` |  |
| `normalizeNewlines` | `Boolean` | No | `` |  |

---

### ReadFrom

**Signature:** `System.String ReadFrom(FParsec.CharStreamState`1[TUserState] ByRef, Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `CharStreamState`1&` | No | `` |  |
| `normalizeNewlines` | `Boolean` | No | `` |  |

---

### CreateSubstream (generic)

**Signature:** `FParsec.CharStream`1[TSubStreamUserState] CreateSubstream[TSubStreamUserState](FParsec.CharStreamState`1[TUserState])`
**Return Type:** `CharStream`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stateWhereSubstreamBegins` | `CharStreamState`1` | No | `` |  |

---

### CreateSubstream (generic)

**Signature:** `FParsec.CharStream`1[TSubStreamUserState] CreateSubstream[TSubStreamUserState](FParsec.CharStreamState`1[TUserState] ByRef)`
**Return Type:** `CharStream`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stateWhereSubstreamBegins` | `CharStreamState`1&` | No | `` |  |

---

## Properties

### UserState

**Type:** `TUserState` (read/write)

---

### State

**Type:** `CharStreamState`1` (read-only)

---