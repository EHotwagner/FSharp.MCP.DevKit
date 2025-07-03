# ExprShapeModule Class

**Namespace:** `Microsoft.FSharp.Quotations`
**Full Name:** `Microsoft.FSharp.Quotations.ExprShapeModule`

Active patterns for traversing, visiting, rebuilding and transforming expressions in a generic way

## Methods

### RebuildShapeCombination (static)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr RebuildShapeCombination(System.Object, Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr])`
**Return Type:** `FSharpExpr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `shape` | `Object` | No | `` |  |
| `arguments` | `FSharpList`1` | No | `` |  |

---

### ShapePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`3[Microsoft.FSharp.Quotations.FSharpVar,System.Tuple`2[Microsoft.FSharp.Quotations.FSharpVar,Microsoft.FSharp.Quotations.FSharpExpr],System.Tuple`2[System.Object,Microsoft.FSharp.Collections.FSharpList`1[Microsoft.FSharp.Quotations.FSharpExpr]]] ShapePattern(Microsoft.FSharp.Quotations.FSharpExpr)`
**Return Type:** `FSharpChoice`3`

**Description:** An active pattern that performs a complete decomposition viewing the expression tree as a binding structure

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `input` | `FSharpExpr` | No | `` | The input expression. |

**Returns:** The decomposed Var, Lambda, or ConstApp.

---