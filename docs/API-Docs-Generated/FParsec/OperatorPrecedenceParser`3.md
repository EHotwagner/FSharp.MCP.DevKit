# OperatorPrecedenceParser`3 Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.OperatorPrecedenceParser`3`
- **Base Type:** ``
- **Generic Parameters:** `<TTerm, TAfterString, TUserState>`

## Methods

### get_TermParser

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[TUserState],FParsec.Reply`1[TTerm]] get_TermParser()`
**Return Type:** `FSharpFunc`2`

---

### set_TermParser

**Signature:** `Void set_TermParser(Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[TUserState],FParsec.Reply`1[TTerm]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FSharpFunc`2` | No | `` |  |

---

### get_MissingTernary2ndStringErrorFormatter

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`4[FParsec.Position,FParsec.Position,FParsec.TernaryOperator`3[TTerm,TAfterString,TUserState],TAfterString],FParsec.ErrorMessageList] get_MissingTernary2ndStringErrorFormatter()`
**Return Type:** `FSharpFunc`2`

---

### set_MissingTernary2ndStringErrorFormatter

**Signature:** `Void set_MissingTernary2ndStringErrorFormatter(Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`4[FParsec.Position,FParsec.Position,FParsec.TernaryOperator`3[TTerm,TAfterString,TUserState],TAfterString],FParsec.ErrorMessageList])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FSharpFunc`2` | No | `` |  |

---

### get_OperatorConflictErrorFormatter

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[FParsec.Position,FParsec.Operator`3[TTerm,TAfterString,TUserState],TAfterString],Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[FParsec.Position,FParsec.Operator`3[TTerm,TAfterString,TUserState],TAfterString],FParsec.ErrorMessageList]] get_OperatorConflictErrorFormatter()`
**Return Type:** `FSharpFunc`2`

---

### set_OperatorConflictErrorFormatter

**Signature:** `Void set_OperatorConflictErrorFormatter(Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[FParsec.Position,FParsec.Operator`3[TTerm,TAfterString,TUserState],TAfterString],Microsoft.FSharp.Core.FSharpFunc`2[System.Tuple`3[FParsec.Position,FParsec.Operator`3[TTerm,TAfterString,TUserState],TAfterString],FParsec.ErrorMessageList]])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FSharpFunc`2` | No | `` |  |

---

### get_ExpressionParser

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[TUserState],FParsec.Reply`1[TTerm]] get_ExpressionParser()`
**Return Type:** `FSharpFunc`2`

---

### AddOperator

**Signature:** `Void AddOperator(FParsec.Operator`3[TTerm,TAfterString,TUserState])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op` | `Operator`3` | No | `` |  |

---

### RemoveInfixOperator

**Signature:** `Boolean RemoveInfixOperator(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `opString` | `String` | No | `` |  |

---

### RemovePrefixOperator

**Signature:** `Boolean RemovePrefixOperator(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `opString` | `String` | No | `` |  |

---

### RemovePostfixOperator

**Signature:** `Boolean RemovePostfixOperator(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `opString` | `String` | No | `` |  |

---

### RemoveTernaryOperator

**Signature:** `Boolean RemoveTernaryOperator(System.String, System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `opStringLeft` | `String` | No | `` |  |
| `opStringRight` | `String` | No | `` |  |

---

### RemoveOperator

**Signature:** `Boolean RemoveOperator(FParsec.Operator`3[TTerm,TAfterString,TUserState])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op` | `Operator`3` | No | `` |  |

---

### get_Operators

**Signature:** `System.Collections.Generic.IEnumerable`1[FParsec.Operator`3[TTerm,TAfterString,TUserState]] get_Operators()`
**Return Type:** `IEnumerable`1`

---

### Invoke

**Signature:** `FParsec.Reply`1[TTerm] Invoke(FParsec.CharStream`1[TUserState])`
**Return Type:** `Reply`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stream` | `CharStream`1` | No | `` |  |

---

## Properties

### TermParser

**Type:** `FSharpFunc`2` (read/write)

---

### MissingTernary2ndStringErrorFormatter

**Type:** `FSharpFunc`2` (read/write)

---

### OperatorConflictErrorFormatter

**Type:** `FSharpFunc`2` (read/write)

---

### ExpressionParser

**Type:** `FSharpFunc`2` (read-only)

---

### Operators

**Type:** `IEnumerable`1` (read-only)

---