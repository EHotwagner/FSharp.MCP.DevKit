# FSharpExpr Class

**Namespace:** `Microsoft.FSharp.Quotations`
**Full Name:** `Microsoft.FSharp.Quotations.FSharpExpr`

Quoted expressions annotated with System.Type values.

## Methods

### get_CustomAttributes

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr] get_CustomAttributes()`
**Return Type:** `FSharpList`1`

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### ToString

**Signature:** `System.String ToString(Boolean)`
**Return Type:** `String`

**Description:** Format the expression as a string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `full` | `Boolean` | No | `` | Indicates if method, property, constructor and type objects should be printed in detail. If false, these are abbreviated to their name. |

**Returns:** The formatted string.

---

### Substitute

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Substitute(Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr]])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `substitution` | `FSharpFunc`2` | No | `` |  |

---

### GetFreeVars

**Signature:** `System.Collections.Generic.IEnumerable`1[Microsoft.FSharp.Quotations.FSharpVar] GetFreeVars()`
**Return Type:** `IEnumerable`1`

**Description:** Gets the free expression variables of an expression as a list.

**Returns:** A sequence of the free variables in the expression.

---

### get_Type

**Signature:** `System.Type get_Type()`
**Return Type:** `Type`

---

### AddressOf (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr AddressOf(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents getting the address of a value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `FSharpExpr` | No | `` | The target expression. |

**Returns:** The resulting expression.

---

### AddressSet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr AddressSet(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents setting the value held at a particular address.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `FSharpExpr` | No | `` | The target expression. |
| `value` | `FSharpExpr` | No | `` | The value to set at the address. |

**Returns:** The resulting expression.

---

### Application (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Application(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the application of a first class function value to a single argument.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `functionExpr` | `FSharpExpr` | No | `` | The function to apply. |
| `argument` | `FSharpExpr` | No | `` | The argument to the function. |

**Returns:** The resulting expression.

---

### Applications (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Applications(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `functionExpr` | `FSharpExpr` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### Call (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Call(System.Reflection.MethodInfo, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `methodInfo` | `MethodInfo` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### Call (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Call(Microsoft.FSharp.Quotations.FSharpExpr, System.Reflection.MethodInfo, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpExpr` | No | `` |  |
| `methodInfo` | `MethodInfo` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### CallWithWitnesses (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr CallWithWitnesses(System.Reflection.MethodInfo, System.Reflection.MethodInfo, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr], Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `methodInfo` | `MethodInfo` | No | `` |  |
| `methodInfoWithWitnesses` | `MethodInfo` | No | `` |  |
| `witnesses` | `FSharpList`1` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### CallWithWitnesses (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr CallWithWitnesses(Microsoft.FSharp.Quotations.FSharpExpr, System.Reflection.MethodInfo, System.Reflection.MethodInfo, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr], Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpExpr` | No | `` |  |
| `methodInfo` | `MethodInfo` | No | `` |  |
| `methodInfoWithWitnesses` | `MethodInfo` | No | `` |  |
| `witnesses` | `FSharpList`1` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### Coerce (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Coerce(Microsoft.FSharp.Quotations.FSharpExpr, System.Type)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the coercion of an expression to a type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `FSharpExpr` | No | `` | The expression to coerce. |
| `target` | `Type` | No | `` | The target type. |

**Returns:** The resulting expression.

---

### IfThenElse (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr IfThenElse(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds 'if ... then ... else' expressions.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `guard` | `FSharpExpr` | No | `` | The condition expression. |
| `thenExpr` | `FSharpExpr` | No | `` | The then sub-expression. |
| `elseExpr` | `FSharpExpr` | No | `` | The else sub-expression. |

**Returns:** The resulting expression.

---

### ForIntegerRangeLoop (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr ForIntegerRangeLoop(Microsoft.FSharp.Quotations.FSharpVar, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds a 'for i = ... to ... do ...' expression that represent loops over integer ranges

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `loopVariable` | `FSharpVar` | No | `` | The sub-expression declaring the loop variable. |
| `start` | `FSharpExpr` | No | `` | The sub-expression setting the initial value of the loop variable. |
| `endExpr` | `FSharpExpr` | No | `` | The sub-expression declaring the final value of the loop variable. |
| `body` | `FSharpExpr` | No | `` | The sub-expression representing the body of the loop. |

**Returns:** The resulting expression.

---

### FieldGet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr FieldGet(System.Reflection.FieldInfo)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the access of a static field

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fieldInfo` | `FieldInfo` | No | `` | The description of the field to access. |

**Returns:** The resulting expression.

---

### FieldGet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr FieldGet(Microsoft.FSharp.Quotations.FSharpExpr, System.Reflection.FieldInfo)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the access of a field of an object

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpExpr` | No | `` | The input object. |
| `fieldInfo` | `FieldInfo` | No | `` | The description of the field to access. |

**Returns:** The resulting expression.

---

### FieldSet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr FieldSet(System.Reflection.FieldInfo, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents writing to a static field

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `fieldInfo` | `FieldInfo` | No | `` | The description of the field to write to. |
| `value` | `FSharpExpr` | No | `` | The value to the set to the field. |

**Returns:** The resulting expression.

---

### FieldSet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr FieldSet(Microsoft.FSharp.Quotations.FSharpExpr, System.Reflection.FieldInfo, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents writing to a field of an object

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpExpr` | No | `` | The input object. |
| `fieldInfo` | `FieldInfo` | No | `` | The description of the field to write to. |
| `value` | `FSharpExpr` | No | `` | The value to set to the field. |

**Returns:** The resulting expression.

---

### Lambda (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Lambda(Microsoft.FSharp.Quotations.FSharpVar, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the construction of an F# function value

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parameter` | `FSharpVar` | No | `` | The parameter to the function. |
| `body` | `FSharpExpr` | No | `` | The body of the function. |

**Returns:** The resulting expression.

---

### Let (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Let(Microsoft.FSharp.Quotations.FSharpVar, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds expressions associated with 'let' constructs

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `letVariable` | `FSharpVar` | No | `` | The variable in the let expression. |
| `letExpr` | `FSharpExpr` | No | `` | The expression bound to the variable. |
| `body` | `FSharpExpr` | No | `` | The sub-expression where the binding is in scope. |

**Returns:** The resulting expression.

---

### LetRecursive (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr LetRecursive(Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr]], Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `bindings` | `FSharpList`1` | No | `` |  |
| `body` | `FSharpExpr` | No | `` |  |

---

### NewObject (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewObject(System.Reflection.ConstructorInfo, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `constructorInfo` | `ConstructorInfo` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### DefaultValue (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr DefaultValue(System.Type)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the invocation of a default object constructor

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `expressionType` | `Type` | No | `` | The type on which the constructor is invoked. |

**Returns:** The resulting expression.

---

### NewTuple (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewTuple(Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `FSharpList`1` | No | `` |  |

---

### NewStructTuple (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewStructTuple(System.Reflection.Assembly, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asm` | `Assembly` | No | `` |  |
| `elements` | `FSharpList`1` | No | `` |  |

---

### NewStructTuple (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewStructTuple(Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elements` | `FSharpList`1` | No | `` |  |

---

### NewRecord (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewRecord(System.Type, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `elements` | `FSharpList`1` | No | `` |  |

---

### NewArray (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewArray(System.Type, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `elementType` | `Type` | No | `` |  |
| `elements` | `FSharpList`1` | No | `` |  |

---

### NewDelegate (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewDelegate(System.Type, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpVar], Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `delegateType` | `Type` | No | `` |  |
| `parameters` | `FSharpList`1` | No | `` |  |
| `body` | `FSharpExpr` | No | `` |  |

---

### NewUnionCase (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr NewUnionCase(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### PropertyGet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr PropertyGet(Microsoft.FSharp.Quotations.FSharpExpr, System.Reflection.PropertyInfo, Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpExpr` | No | `` |  |
| `property` | `PropertyInfo` | No | `` |  |
| `indexerArgs` | `FSharpOption`1` | No | `` |  |

---

### PropertyGet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr PropertyGet(System.Reflection.PropertyInfo, Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `property` | `PropertyInfo` | No | `` |  |
| `indexerArgs` | `FSharpOption`1` | No | `` |  |

---

### PropertySet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr PropertySet(Microsoft.FSharp.Quotations.FSharpExpr, System.Reflection.PropertyInfo, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `FSharpExpr` | No | `` |  |
| `property` | `PropertyInfo` | No | `` |  |
| `value` | `FSharpExpr` | No | `` |  |
| `indexerArgs` | `FSharpOption`1` | No | `` |  |

---

### PropertySet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr PropertySet(System.Reflection.PropertyInfo, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `property` | `PropertyInfo` | No | `` |  |
| `value` | `FSharpExpr` | No | `` |  |
| `indexerArgs` | `FSharpOption`1` | No | `` |  |

---

### Quote (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Quote(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a nested typed or raw quotation literal

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `inner` | `FSharpExpr` | No | `` | The expression being quoted. |

**Returns:** The resulting expression.

---

### QuoteRaw (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr QuoteRaw(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a nested raw quotation literal

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `inner` | `FSharpExpr` | No | `` | The expression being quoted. |

**Returns:** The resulting expression.

---

### QuoteTyped (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr QuoteTyped(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a nested typed quotation literal

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `inner` | `FSharpExpr` | No | `` | The expression being quoted. |

**Returns:** The resulting expression.

---

### Sequential (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Sequential(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents the sequential execution of one expression followed by another

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `first` | `FSharpExpr` | No | `` | The first expression. |
| `second` | `FSharpExpr` | No | `` | The second expression. |

**Returns:** The resulting expression.

---

### TryWith (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr TryWith(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpVar, Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpVar, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a try/with construct for exception filtering and catching.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpExpr` | No | `` | The body of the try expression. |
| `filterVar` | `FSharpVar` | No | `` |  |
| `filterBody` | `FSharpExpr` | No | `` |  |
| `catchVar` | `FSharpVar` | No | `` | The variable to bind to a caught exception. |
| `catchBody` | `FSharpExpr` | No | `` | The expression evaluated when an exception is caught. |

**Returns:** The resulting expression.

---

### TryFinally (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr TryFinally(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a try/finally construct

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `body` | `FSharpExpr` | No | `` | The body of the try expression. |
| `compensation` | `FSharpExpr` | No | `` | The final part of the expression to be evaluated. |

**Returns:** The resulting expression.

---

### TupleGet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr TupleGet(Microsoft.FSharp.Quotations.FSharpExpr, Int32)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents getting a field of a tuple

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tuple` | `FSharpExpr` | No | `` | The input tuple. |
| `index` | `Int32` | No | `` | The index of the tuple element to get. |

**Returns:** The resulting expression.

---

### TypeTest (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr TypeTest(Microsoft.FSharp.Quotations.FSharpExpr, System.Type)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a type test.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `FSharpExpr` | No | `` | The expression to test. |
| `target` | `Type` | No | `` | The target type. |

**Returns:** The resulting expression.

---

### UnionCaseTest (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr UnionCaseTest(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Reflection.UnionCaseInfo)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a test of a value is of a particular union case

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `FSharpExpr` | No | `` | The expression to test. |
| `unionCase` | `UnionCaseInfo` | No | `` | The description of the union case. |

**Returns:** The resulting expression.

---

### Value (static) (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Value[T](T)`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Value (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Value(System.Object, System.Type)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a constant value of a particular type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The untyped object. |
| `expressionType` | `Type` | No | `` | The type of the object. |

**Returns:** The resulting expression.

---

### ValueWithName (static) (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr ValueWithName[T](T, System.String)`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `name` | `String` | No | `` |  |

---

### ValueWithName (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr ValueWithName(System.Object, System.Type, System.String)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a constant value of a particular type, arising from a variable of the given name

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The untyped object. |
| `expressionType` | `Type` | No | `` | The type of the object. |
| `name` | `String` | No | `` | The name of the variable. |

**Returns:** The resulting expression.

---

### WithValue (static) (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr`1[T] WithValue[T](T, Microsoft.FSharp.Quotations.FSharpExpr`1[T])`
**Return Type:** `FSharpExpr`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `definition` | `FSharpExpr`1` | No | `` |  |

---

### WithValue (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr WithValue(System.Object, System.Type, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a value and its associated reflected definition as a quotation

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The untyped object. |
| `expressionType` | `Type` | No | `` | The type of the object. |
| `definition` | `FSharpExpr` | No | `` | The definition of the value being quoted. |

**Returns:** The resulting expression.

---

### Var (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Var(Microsoft.FSharp.Quotations.FSharpVar)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a variable

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `variable` | `FSharpVar` | No | `` | The input variable. |

**Returns:** The resulting expression.

---

### VarSet (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr VarSet(Microsoft.FSharp.Quotations.FSharpVar, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents setting a mutable variable

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `variable` | `FSharpVar` | No | `` | The input variable. |
| `value` | `FSharpExpr` | No | `` | The value to set. |

**Returns:** The resulting expression.

---

### WhileLoop (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr WhileLoop(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`

**Description:** Builds an expression that represents a while loop

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `guard` | `FSharpExpr` | No | `` | The predicate to control the loop iteration. |
| `body` | `FSharpExpr` | No | `` | The body of the while loop. |

**Returns:** The resulting expression.

---

### TryGetReflectedDefinition (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Microsoft.FSharp.Quotations.FSharpExpr] TryGetReflectedDefinition(System.Reflection.MethodBase)`
**Return Type:** `FSharpOption`1`

**Description:** Try and find a stored reflection definition for the given method. Stored reflection
 definitions are added to an F# assembly through the use of the [<ReflectedDefinition>] attribute.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `methodBase` | `MethodBase` | No | `` | The description of the method to find. |

**Returns:** The reflection definition or None if a match could not be found.

---

### Cast (static) (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr`1[T] Cast[T](Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpExpr`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `FSharpExpr` | No | `` |  |

---

### Deserialize (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Deserialize(System.Type, Microsoft.FSharp.Collections.FSharpList`1[System.Type], Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr], Byte[])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `qualifyingType` | `Type` | No | `` |  |
| `spliceTypes` | `FSharpList`1` | No | `` |  |
| `spliceExprs` | `FSharpList`1` | No | `` |  |
| `bytes` | `Byte[]` | No | `` |  |

---

### Deserialize40 (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr Deserialize40(System.Type, System.Type[], System.Type[], Microsoft.FSharp.Quotations.FSharpExpr[], Byte[])`
**Return Type:** `FSharpExpr`

**Description:** This function is called automatically when quotation syntax (<@ @>) and other sources of
 quotations are used.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `qualifyingType` | `Type` | No | `` | A type in the assembly where the quotation occurs. |
| `referencedTypes` | `Type[]` | No | `` | The type definitions referenced. |
| `spliceTypes` | `Type[]` | No | `` | The spliced types, to replace references to type variables. |
| `spliceExprs` | `FSharpExpr[]` | No | `` | The spliced expressions to replace references to spliced expressions. |
| `bytes` | `Byte[]` | No | `` | The serialized form of the quoted expression. |

**Returns:** The resulting expression.

---

### RegisterReflectedDefinitions (static)

**Signature:** `Void RegisterReflectedDefinitions(System.Reflection.Assembly, System.String, Byte[])`
**Return Type:** `Void`

**Description:** Permits interactive environments such as F# Interactive
 to explicitly register new pickled resources that represent persisted
 top level definitions.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `assembly` | `Assembly` | No | `` | The assembly associated with the resource. |
| `resource` | `String` | No | `` | The unique name for the resources being added. |
| `serializedValue` | `Byte[]` | No | `` | The serialized resource to register with the environment. |

---

### RegisterReflectedDefinitions (static)

**Signature:** `Void RegisterReflectedDefinitions(System.Reflection.Assembly, System.String, Byte[], System.Type[])`
**Return Type:** `Void`

**Description:** Permits interactive environments such as F# Interactive
 to explicitly register new pickled resources that represent persisted
 top level definitions.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `assembly` | `Assembly` | No | `` | The assembly associated with the resource. |
| `resource` | `String` | No | `` | The unique name for the resources being added. |
| `serializedValue` | `Byte[]` | No | `` | The serialized resource to register with the environment. |
| `referencedTypes` | `Type[]` | No | `` | The type definitions referenced. |

---

### GlobalVar (static) (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr`1[T] GlobalVar[T](System.String)`
**Return Type:** `FSharpExpr`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |

---

## Properties

### CustomAttributes

**Type:** `FSharpList`1` (read-only)

**Description:** Returns the custom attributes of an expression. For quotations deriving from quotation literals this may include the source location of the literal.

---

### Type

**Type:** `Type` (read-only)

**Description:** Returns type of an expression.

---