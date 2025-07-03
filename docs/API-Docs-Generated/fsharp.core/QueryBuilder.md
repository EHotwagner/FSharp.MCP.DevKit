# QueryBuilder Class

**Namespace:** `Microsoft.FSharp.Linq`
**Full Name:** `Microsoft.FSharp.Linq.QueryBuilder`

The type used to support the F# query syntax. Use 'query { ... }' to use the query syntax. See
 also <a href="https://learn.microsoft.com/dotnet/fsharp/language-reference/query-expressions">F# Query Expressions</a> in the F# Language Guide.

## Methods

### For (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[TResult,Q] For[T,Q,TResult,Q2](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Linq.QuerySource`2[TResult,Q2]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `body` | `FSharpFunc`2` | No | `` |  |

---

### Zero (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Zero[T,Q]()`
**Return Type:** `QuerySource`2`

---

### Yield (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Yield[T,Q](T)`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### YieldFrom (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] YieldFrom[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `computation` | `QuerySource`2` | No | `` |  |

---

### Quote (generic)

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr`1[T] Quote[T](Microsoft.FSharp.Quotations.FSharpExpr`1[T])`
**Return Type:** `FSharpExpr`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `quotation` | `FSharpExpr`1` | No | `` |  |

---

### Source (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Source[T,Q](System.Linq.IQueryable`1[T])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IQueryable`1` | No | `` |  |

---

### Source (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,System.Collections.IEnumerable] Source[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `IEnumerable`1` | No | `` |  |

---

### Contains (generic)

**Signature:** `Boolean Contains[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `key` | `T` | No | `` |  |

---

### Select (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[TResult,Q] Select[T,Q,TResult](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TResult])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### Where (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Where[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |

---

### Last (generic)

**Signature:** `T Last[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### LastOrDefault (generic)

**Signature:** `T LastOrDefault[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### ExactlyOne (generic)

**Signature:** `T ExactlyOne[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### ExactlyOneOrDefault (generic)

**Signature:** `T ExactlyOneOrDefault[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### Count (generic)

**Signature:** `Int32 Count[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### Distinct (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Distinct[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### Exists (generic)

**Signature:** `Boolean Exists[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |

---

### All (generic)

**Signature:** `Boolean All[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |

---

### Head (generic)

**Signature:** `T Head[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### Nth (generic)

**Signature:** `T Nth[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `index` | `Int32` | No | `` |  |

---

### Skip (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Skip[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Int32)`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---

### SkipWhile (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] SkipWhile[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |

---

### Take (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] Take[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Int32)`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---

### TakeWhile (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] TakeWhile[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |

---

### Find (generic)

**Signature:** `T Find[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Boolean])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `predicate` | `FSharpFunc`2` | No | `` |  |

---

### HeadOrDefault (generic)

**Signature:** `T HeadOrDefault[T,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |

---

### MinBy (generic)

**Signature:** `TValue MinBy[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue])`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `valueSelector` | `FSharpFunc`2` | No | `` |  |

---

### MaxBy (generic)

**Signature:** `TValue MaxBy[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue])`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `valueSelector` | `FSharpFunc`2` | No | `` |  |

---

### MinByNullable (generic)

**Signature:** `System.Nullable`1[TValue] MinByNullable[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TValue]])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `valueSelector` | `FSharpFunc`2` | No | `` |  |

---

### MaxByNullable (generic)

**Signature:** `System.Nullable`1[TValue] MaxByNullable[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TValue]])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `valueSelector` | `FSharpFunc`2` | No | `` |  |

---

### SumByNullable (generic)

**Signature:** `System.Nullable`1[TValue] SumByNullable[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TValue]])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `valueSelector` | `FSharpFunc`2` | No | `` |  |

---

### SumByNullable$W (generic)

**Signature:** `System.Nullable`1[TValue] SumByNullable$W[T,Q,TValue](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TValue], Microsoft.FSharp.Core.FSharpFunc`2[TValue,Microsoft.FSharp.Core.FSharpFunc`2[TValue,TValue]], Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TValue]])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `source` | `QuerySource`2` | No | `` |  |
| `valueSelector` | `FSharpFunc`2` | No | `` |  |

---

### AverageByNullable (generic)

**Signature:** `System.Nullable`1[TValue] AverageByNullable[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TValue]])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### AverageByNullable$W (generic)

**Signature:** `System.Nullable`1[TValue] AverageByNullable$W[T,Q,TValue](Microsoft.FSharp.Core.FSharpFunc`2[TValue,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,TValue]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TValue], Microsoft.FSharp.Core.FSharpFunc`2[TValue,Microsoft.FSharp.Core.FSharpFunc`2[TValue,TValue]], Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TValue]])`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### AverageBy (generic)

**Signature:** `TValue AverageBy[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue])`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### AverageBy$W (generic)

**Signature:** `TValue AverageBy$W[T,Q,TValue](Microsoft.FSharp.Core.FSharpFunc`2[TValue,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,TValue]], Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TValue], Microsoft.FSharp.Core.FSharpFunc`2[TValue,Microsoft.FSharp.Core.FSharpFunc`2[TValue,TValue]], Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue])`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### SumBy (generic)

**Signature:** `TValue SumBy[T,Q,TValue](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue])`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### SumBy$W (generic)

**Signature:** `TValue SumBy$W[T,Q,TValue](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TValue], Microsoft.FSharp.Core.FSharpFunc`2[TValue,Microsoft.FSharp.Core.FSharpFunc`2[TValue,TValue]], Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue])`
**Return Type:** `TValue`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `source` | `QuerySource`2` | No | `` |  |
| `projection` | `FSharpFunc`2` | No | `` |  |

---

### GroupBy (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[System.Linq.IGrouping`2[TKey,T],Q] GroupBy[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TKey])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### SortBy (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] SortBy[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TKey])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### SortByDescending (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] SortByDescending[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TKey])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### ThenBy (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] ThenBy[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TKey])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### ThenByDescending (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] ThenByDescending[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TKey])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### SortByNullable (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] SortByNullable[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TKey]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### SortByNullableDescending (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] SortByNullableDescending[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TKey]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### ThenByNullable (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] ThenByNullable[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TKey]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### ThenByNullableDescending (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[T,Q] ThenByNullableDescending[T,Q,TKey](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,System.Nullable`1[TKey]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### GroupValBy (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[System.Linq.IGrouping`2[TKey,TValue],Q] GroupValBy[T,TKey,TValue,Q](Microsoft.FSharp.Linq.QuerySource`2[T,Q], Microsoft.FSharp.Core.FSharpFunc`2[T,TValue], Microsoft.FSharp.Core.FSharpFunc`2[T,TKey])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `source` | `QuerySource`2` | No | `` |  |
| `resultSelector` | `FSharpFunc`2` | No | `` |  |
| `keySelector` | `FSharpFunc`2` | No | `` |  |

---

### Join (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[TResult,Q] Join[TOuter,Q,TInner,TKey,TResult](Microsoft.FSharp.Linq.QuerySource`2[TOuter,Q], Microsoft.FSharp.Linq.QuerySource`2[TInner,Q], Microsoft.FSharp.Core.FSharpFunc`2[TOuter,TKey], Microsoft.FSharp.Core.FSharpFunc`2[TInner,TKey], Microsoft.FSharp.Core.FSharpFunc`2[TOuter,Microsoft.FSharp.Core.FSharpFunc`2[TInner,TResult]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `outerSource` | `QuerySource`2` | No | `` |  |
| `innerSource` | `QuerySource`2` | No | `` |  |
| `outerKeySelector` | `FSharpFunc`2` | No | `` |  |
| `innerKeySelector` | `FSharpFunc`2` | No | `` |  |
| `resultSelector` | `FSharpFunc`2` | No | `` |  |

---

### GroupJoin (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[TResult,Q] GroupJoin[TOuter,Q,TInner,TKey,TResult](Microsoft.FSharp.Linq.QuerySource`2[TOuter,Q], Microsoft.FSharp.Linq.QuerySource`2[TInner,Q], Microsoft.FSharp.Core.FSharpFunc`2[TOuter,TKey], Microsoft.FSharp.Core.FSharpFunc`2[TInner,TKey], Microsoft.FSharp.Core.FSharpFunc`2[TOuter,Microsoft.FSharp.Core.FSharpFunc`2[System.Collections.Generic.IEnumerable`1[TInner],TResult]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `outerSource` | `QuerySource`2` | No | `` |  |
| `innerSource` | `QuerySource`2` | No | `` |  |
| `outerKeySelector` | `FSharpFunc`2` | No | `` |  |
| `innerKeySelector` | `FSharpFunc`2` | No | `` |  |
| `resultSelector` | `FSharpFunc`2` | No | `` |  |

---

### LeftOuterJoin (generic)

**Signature:** `Microsoft.FSharp.Linq.QuerySource`2[TResult,Q] LeftOuterJoin[TOuter,Q,TInner,TKey,TResult](Microsoft.FSharp.Linq.QuerySource`2[TOuter,Q], Microsoft.FSharp.Linq.QuerySource`2[TInner,Q], Microsoft.FSharp.Core.FSharpFunc`2[TOuter,TKey], Microsoft.FSharp.Core.FSharpFunc`2[TInner,TKey], Microsoft.FSharp.Core.FSharpFunc`2[TOuter,Microsoft.FSharp.Core.FSharpFunc`2[System.Collections.Generic.IEnumerable`1[TInner],TResult]])`
**Return Type:** `QuerySource`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `outerSource` | `QuerySource`2` | No | `` |  |
| `innerSource` | `QuerySource`2` | No | `` |  |
| `outerKeySelector` | `FSharpFunc`2` | No | `` |  |
| `innerKeySelector` | `FSharpFunc`2` | No | `` |  |
| `resultSelector` | `FSharpFunc`2` | No | `` |  |

---

### Run (generic)

**Signature:** `System.Linq.IQueryable`1[T] Run[T](Microsoft.FSharp.Quotations.FSharpExpr`1[Microsoft.FSharp.Linq.QuerySource`2[T,System.Linq.IQueryable]])`
**Return Type:** `IQueryable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `q` | `FSharpExpr`1` | No | `` |  |

---