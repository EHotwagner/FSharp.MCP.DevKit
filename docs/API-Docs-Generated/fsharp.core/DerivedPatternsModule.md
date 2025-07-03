# DerivedPatternsModule Class

**Namespace:** `Microsoft.FSharp.Quotations`
**Full Name:** `Microsoft.FSharp.Quotations.DerivedPatternsModule`

Contains a set of derived F# active patterns to analyze F# expression objects

## Methods

### BoolPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Boolean] BoolPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant boolean expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### StringPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] StringPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant string expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### SinglePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Single] SinglePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant 32-bit floating point number expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### DoublePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Double] DoublePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant 64-bit floating point number expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### CharPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Char] CharPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant unicode character expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### SBytePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.SByte] SBytePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant signed byte expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### BytePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Byte] BytePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant byte expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### Int16Pattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int16] Int16Pattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant int16 expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### UInt16Pattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.UInt16] UInt16Pattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant unsigned int16 expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### Int32Pattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int32] Int32Pattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant int32 expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### UInt32Pattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.UInt32] UInt32Pattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant unsigned int32 expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### Int64Pattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Int64] Int64Pattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant int64 expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### UInt64Pattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.UInt64] UInt64Pattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant unsigned int64 expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### UnitPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Core.Unit] UnitPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize () constant expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern does not bind any results

---

### LambdasPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpVar]],Microsoft.FSharp.Quotations.FSharpExpr]] LambdasPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent a (possibly curried or tupled) first class function value

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the curried variables and body of the input expression

---

### ApplicationsPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]]] ApplicationsPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions that represent the application of a (possibly curried or tupled) first class function value

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the function and curried arguments of the input expression

---

### AndAlsoPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] AndAlsoPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions of the form a && b

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the left and right parts of the input expression

---

### OrElsePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Quotations.FSharpExpr]] OrElsePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize expressions of the form a || b

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the left and right parts of the input expression

---

### SpecificCallPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Quotations.FSharpExpr,Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr],Microsoft.FSharp.Collections.FSharpList`1[System.Type],Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]]] SpecificCallPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpFunc`2`

**Description:** A parameterized active pattern to recognize calls to a specified function or method.
 The returned elements are the optional target object (present if the target is an
 instance method), the generic type instantiation (non-empty if the target is a generic
 instantiation), and the arguments to the function or method.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `templateParameter` | `FSharpExpr` | No | `` | The input template expression to specify the method to call. |

**Returns:** The optional target object (present if the target is an
 instance method), the generic type instantiation (non-empty if the target is a generic
 instantiation), and the arguments to the function or method.

---

### DecimalPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Decimal] DecimalPattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize constant decimal expressions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression to match against. |

**Returns:** When successful, the pattern binds the constant value from the input expression

---

### MethodWithReflectedDefinitionPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] MethodWithReflectedDefinitionPattern(System.Reflection.MethodBase)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize methods that have an associated ReflectedDefinition

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `methodBase` | `MethodBase` | No | `` | The description of the method. |

**Returns:** The expression of the method definition if found, or None.

---

### PropertyGetterWithReflectedDefinitionPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] PropertyGetterWithReflectedDefinitionPattern(System.Reflection.PropertyInfo)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize property getters or values in modules that have an associated ReflectedDefinition

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyInfo` | `PropertyInfo` | No | `` | The description of the property. |

**Returns:** The expression of the method definition if found, or None.

---

### PropertySetterWithReflectedDefinitionPattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] PropertySetterWithReflectedDefinitionPattern(System.Reflection.PropertyInfo)`
**Return Type:** `FSharpOption`1`

**Description:** An active pattern to recognize property setters that have an associated ReflectedDefinition

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyInfo` | `PropertyInfo` | No | `` | The description of the property. |

**Returns:** The expression of the method definition if found, or None.

---