# PatternsModule Class

**Namespace:** `Microsoft.FSharp.Quotations`
**Full Name:** `Microsoft.FSharp.Quotations.PatternsModule`

Contains a set of primitive F# active patterns to analyze F# expression objects

## Methods

### VarPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpVar] VarPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a variable

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the variable of the input expression

---

### ApplicationPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] ApplicationPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent applications of first class function values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the function and argument of the input expression

---

### LambdaPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr]] LambdaPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent first class function values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the variable and body of the input expression

---

### QuotePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] QuotePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a nested quotation literal

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the nested quotation expression of the input expression

---

### QuoteRawPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] QuoteRawPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a nested raw quotation literal

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the nested quotation expression of the input expression

---

### QuoteTypedPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] QuoteTypedPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a nested typed quotation literal

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the nested quotation expression of the input expression

---

### IfThenElsePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] IfThenElsePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent conditionals

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the condition, then-branch and else-branch of the input expression

---

### NewTuplePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]] NewTuplePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent construction of tuple values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the element expressions of the input expression

---

### NewStructTuplePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]] NewStructTuplePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent construction of struct tuple values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the element expressions of the input expression

---

### DefaultValuePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Type] DefaultValuePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent invocations of a default constructor of a struct

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the relevant type of the input expression

---

### NewRecordPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] NewRecordPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent construction of record values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the record type and field values of the input expression

---

### NewUnionCasePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Reflection.UnionCaseInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] NewUnionCasePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent construction of particular union case values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the union case and field values of the input expression

---

### UnionCaseTestPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Reflection.UnionCaseInfo]] UnionCaseTestPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a test if a value is of a particular union case

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the expression and union case being tested

---

### TupleGetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,System.Int32]] TupleGetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent getting a tuple field

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the expression and tuple field being accessed

---

### CoercePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,System.Type]] CoercePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent coercions from one type to another

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the source expression and target type of the input expression

---

### TypeTestPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,System.Type]] TypeTestPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a dynamic type test

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the expression and type being tested

---

### NewArrayPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] NewArrayPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent the construction of arrays

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the element type and values of the input expression

---

### AddressSetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] AddressSetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent setting the value held at an address

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the target and value expressions of the input expression

---

### TryFinallyPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] TryFinallyPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a try/finally construct

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the body and handler parts of the try/finally expression

---

### TryWithPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`5[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr]] TryWithPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a try/with construct for exception filtering and catching

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the body, exception variable, filter expression and catch expression of the input expression

---

### VarSetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr]] VarSetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent setting a mutable variable

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the variable and value expression of the input expression

---

### ValuePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.Object,System.Type]] ValuePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a constant value. This also matches expressions matched by ValueWithName.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the boxed value and its static type

---

### ValueWithNamePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[System.Object,System.Type,System.String]] ValueWithNamePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a constant value

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the boxed value, its static type and its name

---

### WithValuePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[System.Object,System.Type,Microsoft.FSharp.Quotations.FSharpExpr]] WithValuePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that are a value with an associated definition

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the boxed value, its static type and its definition

---

### AddressOfPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] AddressOfPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent getting the address of a value

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the sub-expression of the input AddressOf expression

---

### SequentialPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] SequentialPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent sequential execution of one expression followed by another

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the two sub-expressions of the input expression

---

### ForIntegerRangeLoopPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`4[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] ForIntegerRangeLoopPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent loops over integer ranges

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the value, start, finish and body of the input expression

---

### WhileLoopPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] WhileLoopPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent while loops

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the guard and body of the input expression

---

### PropertyGetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],System.Reflection.PropertyInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] PropertyGetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent the read of a static or instance property, or a non-function value declared in a module

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the object, property and indexer arguments of the input expression

---

### PropertySetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`4[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],System.Reflection.PropertyInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr],Microsoft.FSharp.Quotations.FSharpExpr]] PropertySetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent setting a static or instance property, or a non-function value declared in a module

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the object, property, indexer arguments and setter value of the input expression

---

### FieldGetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],System.Reflection.FieldInfo]] FieldGetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent getting a static or instance field

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the object and field of the input expression

---

### FieldSetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],System.Reflection.FieldInfo,Microsoft.FSharp.Quotations.FSharpExpr]] FieldSetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent setting a static or instance field

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the object, field and value of the input expression

---

### NewObjectPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.Reflection.ConstructorInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] NewObjectPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent invocation of object constructors

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constructor and arguments of the input expression

---

### CallPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],System.Reflection.MethodInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] CallPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent calls to static and instance methods, and functions defined in modules

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the object, method and argument sub-expressions of the input expression

---

### CallWithWitnessesPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`5[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],System.Reflection.MethodInfo,System.Reflection.MethodInfo,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr],Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] CallWithWitnessesPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent calls to static and instance methods, and functions defined in modules, including witness arguments

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the object, method, witness-argument and argument sub-expressions of the input expression

---

### LetPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] LetPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent let bindings

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the variable, binding expression and body of the input expression

---

### NewDelegatePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[System.Type,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpVar],Microsoft.FSharp.Quotations.FSharpExpr]] NewDelegatePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent construction of delegate values

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the delegate type, argument parameters and body of the input expression

---

### LetRecursivePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr]],Microsoft.FSharp.Quotations.FSharpExpr]] LetRecursivePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent recursive let bindings of one or more variables

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the bindings and body of the input expression

---