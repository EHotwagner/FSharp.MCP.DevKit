# LeafExpressionConverter Class

**Namespace:** `Microsoft.FSharp.Linq.RuntimeHelpers`
**Full Name:** `Microsoft.FSharp.Linq.RuntimeHelpers.LeafExpressionConverter`

Contains functionality to convert F# quotations to LINQ expression trees.

## Methods

### MemberInitializationHelper (static) (generic)

**Signature:** `T MemberInitializationHelper[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_x` | `T` | No | `` |  |

---

### NewAnonymousObjectHelper (static) (generic)

**Signature:** `T NewAnonymousObjectHelper[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_x` | `T` | No | `` |  |

---

### ImplicitExpressionConversionHelper (static) (generic)

**Signature:** `System.Linq.Expressions.Expression`1[T] ImplicitExpressionConversionHelper[T](T)`
**Return Type:** `Expression`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_x` | `T` | No | `` |  |

---

### SubstHelperRaw (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr SubstHelperRaw(Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpVar[], System.Object[])`
**Return Type:** `FSharpExpr`

**Description:** A runtime helper used to evaluate nested quotation literals.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `q` | `FSharpExpr` | No | `` |  |
| `x` | `FSharpVar[]` | No | `` |  |
| `y` | `Object[]` | No | `` |  |

---

### SubstHelper (static) (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr`1[T] SubstHelper[T](Microsoft.FSharp.Quotations.FSharpExpr, Microsoft.FSharp.Quotations.FSharpVar[], System.Object[])`
**Return Type:** `FSharpExpr`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `q` | `FSharpExpr` | No | `` |  |
| `x` | `FSharpVar[]` | No | `` |  |
| `y` | `Object[]` | No | `` |  |

---

### QuotationToExpression (static)

**Signature:** `System.Linq.Expressions.Expression QuotationToExpression(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `Expression`

**Description:** Converts a subset of F# quotations to a LINQ expression, for the subset of LINQ expressions represented by the
 expression syntax in the C# language.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `FSharpExpr` | No | `` |  |

---

### QuotationToLambdaExpression (static) (generic)

**Signature:** `System.Linq.Expressions.Expression`1[T] QuotationToLambdaExpression[T](Microsoft.FSharp.Quotations.FSharpExpr`1[T])`
**Return Type:** `Expression`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `FSharpExpr`1` | No | `` |  |

---

### EvaluateQuotation (static)

**Signature:** `System.Object EvaluateQuotation(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `Object`

**Description:** Evaluates a subset of F# quotations by first converting to a LINQ expression, for the subset of LINQ expressions represented by the
 expression syntax in the C# language.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `FSharpExpr` | No | `` |  |

---