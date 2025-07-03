# Operators Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.Operators`

Basic F# Operators. This module is automatically opened in all F# code.

## Methods

### CreateSequence (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] CreateSequence[T](System.Collections.Generic.IEnumerable`1[T])`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sequence` | `IEnumerable`1` | No | `` |  |

---

### Unbox (static) (generic)

**Signature:** `T Unbox[T](System.Object)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |

---

### Box (static) (generic)

**Signature:** `System.Object Box[T](T)`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### TryUnbox (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[T] TryUnbox[T](System.Object)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |

---

### IsNull (static) (generic)

**Signature:** `Boolean IsNull[T](T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### IsNullV (static) (generic)

**Signature:** `Boolean IsNullV[T](System.Nullable`1[T])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### NonNull (static) (generic)

**Signature:** `T NonNull[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### NonNullV (static) (generic)

**Signature:** `T NonNullV[T](System.Nullable`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### NullMatchPattern (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`2[Microsoft.FSharp.Core.Unit,T] NullMatchPattern[T](T)`
**Return Type:** `FSharpChoice`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### NullValueMatchPattern (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`2[Microsoft.FSharp.Core.Unit,T] NullValueMatchPattern[T](System.Nullable`1[T])`
**Return Type:** `FSharpChoice`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### NonNullQuickPattern (static) (generic)

**Signature:** `T NonNullQuickPattern[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### NonNullQuickValuePattern (static) (generic)

**Signature:** `T NonNullQuickValuePattern[T](System.Nullable`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### WithNull (static) (generic)

**Signature:** `T WithNull[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### WithNullV (static) (generic)

**Signature:** `System.Nullable`1[T] WithNullV[T](T)`
**Return Type:** `Nullable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### NullV (static) (generic)

**Signature:** `System.Nullable`1[T] NullV[T]()`
**Return Type:** `Nullable`1`

---

### NullArgCheck (static) (generic)

**Signature:** `T NullArgCheck[T](System.String, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `argumentName` | `String` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Raise (static) (generic)

**Signature:** `T Raise[T](System.Exception)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exn` | `Exception` | No | `` |  |

---

### Failure (static)

**Signature:** `System.Exception Failure(System.String)`
**Return Type:** `Exception`

**Description:** Builds a  object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `String` | No | `` | The message for the Exception. |

**Returns:** A System.Exception.

---

### FailurePattern (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] FailurePattern(System.Exception)`
**Return Type:** `FSharpOption`1`

**Description:** Matches  objects whose runtime type is precisely

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `error` | `Exception` | No | `` | The input exception. |

**Returns:** A string option.

---

### op_LessThan (static) (generic)

**Signature:** `Boolean op_LessThan[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_GreaterThan (static) (generic)

**Signature:** `Boolean op_GreaterThan[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_GreaterThanOrEqual (static) (generic)

**Signature:** `Boolean op_GreaterThanOrEqual[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_LessThanOrEqual (static) (generic)

**Signature:** `Boolean op_LessThanOrEqual[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_Equality (static) (generic)

**Signature:** `Boolean op_Equality[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_Inequality (static) (generic)

**Signature:** `Boolean op_Inequality[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### Compare (static) (generic)

**Signature:** `Int32 Compare[T](T, T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### Max (static) (generic)

**Signature:** `T Max[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### Min (static) (generic)

**Signature:** `T Min[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### FailWith (static) (generic)

**Signature:** `T FailWith[T](System.String)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `String` | No | `` |  |

---

### InvalidArg (static) (generic)

**Signature:** `T InvalidArg[T](System.String, System.String)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `argumentName` | `String` | No | `` |  |
| `message` | `String` | No | `` |  |

---

### NullArg (static) (generic)

**Signature:** `T NullArg[T](System.String)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `argumentName` | `String` | No | `` |  |

---

### InvalidOp (static) (generic)

**Signature:** `T InvalidOp[T](System.String)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `message` | `String` | No | `` |  |

---

### Rethrow (static) (generic)

**Signature:** `T Rethrow[T]()`
**Return Type:** `T`

---

### Reraise (static) (generic)

**Signature:** `T Reraise[T]()`
**Return Type:** `T`

---

### Fst (static) (generic)

**Signature:** `T1 Fst[T1,T2](System.Tuple`2[T1,T2])`
**Return Type:** `T1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `Tuple`2` | No | `` |  |

---

### Snd (static) (generic)

**Signature:** `T2 Snd[T1,T2](System.Tuple`2[T1,T2])`
**Return Type:** `T2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tuple` | `Tuple`2` | No | `` |  |

---

### Ignore (static) (generic)

**Signature:** `Void Ignore[T](T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Ref (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpRef`1[T] Ref[T](T)`
**Return Type:** `FSharpRef`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### op_ColonEquals (static) (generic)

**Signature:** `Void op_ColonEquals[T](Microsoft.FSharp.Core.FSharpRef`1[T], T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cell` | `FSharpRef`1` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### op_Dereference (static) (generic)

**Signature:** `T op_Dereference[T](Microsoft.FSharp.Core.FSharpRef`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cell` | `FSharpRef`1` | No | `` |  |

---

### op_PipeRight (static) (generic)

**Signature:** `TResult op_PipeRight[T1,TResult](T1, Microsoft.FSharp.Core.FSharpFunc`2[T1,TResult])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg` | `T1` | No | `` |  |
| `func` | `FSharpFunc`2` | No | `` |  |

---

### op_PipeRight2 (static) (generic)

**Signature:** `TResult op_PipeRight2[T1,T2,TResult](T1, T2, Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg1` | `T1` | No | `` |  |
| `arg2` | `T2` | No | `` |  |
| `func` | `FSharpFunc`2` | No | `` |  |

---

### op_PipeRight3 (static) (generic)

**Signature:** `TResult op_PipeRight3[T1,T2,T3,TResult](T1, T2, T3, Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg1` | `T1` | No | `` |  |
| `arg2` | `T2` | No | `` |  |
| `arg3` | `T3` | No | `` |  |
| `func` | `FSharpFunc`2` | No | `` |  |

---

### op_PipeLeft (static) (generic)

**Signature:** `TResult op_PipeLeft[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T` | No | `` |  |

---

### op_PipeLeft2 (static) (generic)

**Signature:** `TResult op_PipeLeft2[T1,T2,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,TResult]], T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T1` | No | `` |  |
| `arg2` | `T2` | No | `` |  |

---

### op_PipeLeft3 (static) (generic)

**Signature:** `TResult op_PipeLeft3[T1,T2,T3,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,Microsoft.FSharp.Core.FSharpFunc`2[T3,TResult]]], T1, T2, T3)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func` | `FSharpFunc`2` | No | `` |  |
| `arg1` | `T1` | No | `` |  |
| `arg2` | `T2` | No | `` |  |
| `arg3` | `T3` | No | `` |  |

---

### op_ComposeRight (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,T3] op_ComposeRight[T1,T2,T3](Microsoft.FSharp.Core.FSharpFunc`2[T1,T2], Microsoft.FSharp.Core.FSharpFunc`2[T2,T3])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func1` | `FSharpFunc`2` | No | `` |  |
| `func2` | `FSharpFunc`2` | No | `` |  |

---

### op_ComposeLeft (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[T1,T3] op_ComposeLeft[T2,T3,T1](Microsoft.FSharp.Core.FSharpFunc`2[T2,T3], Microsoft.FSharp.Core.FSharpFunc`2[T1,T2])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `func2` | `FSharpFunc`2` | No | `` |  |
| `func1` | `FSharpFunc`2` | No | `` |  |

---

### op_Concatenate (static)

**Signature:** `System.String op_Concatenate(System.String, System.String)`
**Return Type:** `String`

**Description:** Concatenate two strings. The operator '+' may also be used.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s1` | `String` | No | `` |  |
| `s2` | `String` | No | `` |  |

---

### DefaultArg (static) (generic)

**Signature:** `T DefaultArg[T](Microsoft.FSharp.Core.FSharpOption`1[T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg` | `FSharpOption`1` | No | `` |  |
| `defaultValue` | `T` | No | `` |  |

---

### DefaultValueArg (static) (generic)

**Signature:** `T DefaultValueArg[T](Microsoft.FSharp.Core.FSharpValueOption`1[T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg` | `FSharpValueOption`1` | No | `` |  |
| `defaultValue` | `T` | No | `` |  |

---

### DefaultIfNull (static) (generic)

**Signature:** `T DefaultIfNull[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `defaultValue` | `T` | No | `` |  |
| `arg` | `T` | No | `` |  |

---

### DefaultIfNullV (static) (generic)

**Signature:** `T DefaultIfNullV[T](T, System.Nullable`1[T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `defaultValue` | `T` | No | `` |  |
| `arg` | `Nullable`1` | No | `` |  |

---

### op_UnaryNegation (static) (generic)

**Signature:** `T op_UnaryNegation[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `n` | `T` | No | `` |  |

---

### op_UnaryNegation$W (static) (generic)

**Signature:** `T op_UnaryNegation$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_UnaryNegation` | `FSharpFunc`2` | No | `` |  |
| `n` | `T` | No | `` |  |

---

### op_Addition (static) (generic)

**Signature:** `T3 op_Addition[T1,T2,T3](T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Addition$W (static) (generic)

**Signature:** `T3 op_Addition$W[T1,T2,T3](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,T3]], T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Subtraction (static) (generic)

**Signature:** `T3 op_Subtraction[T1,T2,T3](T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Subtraction$W (static) (generic)

**Signature:** `T3 op_Subtraction$W[T1,T2,T3](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,T3]], T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Subtraction` | `FSharpFunc`2` | No | `` |  |
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Multiply (static) (generic)

**Signature:** `T3 op_Multiply[T1,T2,T3](T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Multiply$W (static) (generic)

**Signature:** `T3 op_Multiply$W[T1,T2,T3](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,T3]], T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Multiply` | `FSharpFunc`2` | No | `` |  |
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Division (static) (generic)

**Signature:** `T3 op_Division[T1,T2,T3](T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Division$W (static) (generic)

**Signature:** `T3 op_Division$W[T1,T2,T3](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,T3]], T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Division` | `FSharpFunc`2` | No | `` |  |
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Modulus (static) (generic)

**Signature:** `T3 op_Modulus[T1,T2,T3](T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_Modulus$W (static) (generic)

**Signature:** `T3 op_Modulus$W[T1,T2,T3](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T2,T3]], T1, T2)`
**Return Type:** `T3`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Modulus` | `FSharpFunc`2` | No | `` |  |
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### op_UnaryPlus (static) (generic)

**Signature:** `T op_UnaryPlus[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### op_UnaryPlus$W (static) (generic)

**Signature:** `T op_UnaryPlus$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_UnaryPlus` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### op_LeftShift (static) (generic)

**Signature:** `T op_LeftShift[T](T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `shift` | `Int32` | No | `` |  |

---

### op_LeftShift$W (static) (generic)

**Signature:** `T op_LeftShift$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]], T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_LeftShift` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |
| `shift` | `Int32` | No | `` |  |

---

### op_RightShift (static) (generic)

**Signature:** `T op_RightShift[T](T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |
| `shift` | `Int32` | No | `` |  |

---

### op_RightShift$W (static) (generic)

**Signature:** `T op_RightShift$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]], T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_RightShift` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |
| `shift` | `Int32` | No | `` |  |

---

### op_BitwiseAnd (static) (generic)

**Signature:** `T op_BitwiseAnd[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_BitwiseAnd$W (static) (generic)

**Signature:** `T op_BitwiseAnd$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_BitwiseAnd` | `FSharpFunc`2` | No | `` |  |
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_BitwiseOr (static) (generic)

**Signature:** `T op_BitwiseOr[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_BitwiseOr$W (static) (generic)

**Signature:** `T op_BitwiseOr$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_BitwiseOr` | `FSharpFunc`2` | No | `` |  |
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_ExclusiveOr (static) (generic)

**Signature:** `T op_ExclusiveOr[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_ExclusiveOr$W (static) (generic)

**Signature:** `T op_ExclusiveOr$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_ExclusiveOr` | `FSharpFunc`2` | No | `` |  |
| `x` | `T` | No | `` |  |
| `y` | `T` | No | `` |  |

---

### op_LogicalNot (static) (generic)

**Signature:** `T op_LogicalNot[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### op_LogicalNot$W (static) (generic)

**Signature:** `T op_LogicalNot$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_LogicalNot` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### op_Append (static) (generic)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[T] op_Append[T](Microsoft.FSharp.Collections.FSharpList`1[T], Microsoft.FSharp.Collections.FSharpList`1[T])`
**Return Type:** `FSharpList`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `list1` | `FSharpList`1` | No | `` |  |
| `list2` | `FSharpList`1` | No | `` |  |

---

### Increment (static)

**Signature:** `Void Increment(Microsoft.FSharp.Core.FSharpRef`1[System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cell` | `FSharpRef`1` | No | `` |  |

---

### Decrement (static)

**Signature:** `Void Decrement(Microsoft.FSharp.Core.FSharpRef`1[System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cell` | `FSharpRef`1` | No | `` |  |

---

### Exit (static) (generic)

**Signature:** `T Exit[T](Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exitcode` | `Int32` | No | `` |  |

---

### ToByte (static) (generic)

**Signature:** `Byte ToByte[T](T)`
**Return Type:** `Byte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToByte$W (static) (generic)

**Signature:** `Byte ToByte$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Byte], T)`
**Return Type:** `Byte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToSByte (static) (generic)

**Signature:** `SByte ToSByte[T](T)`
**Return Type:** `SByte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToSByte$W (static) (generic)

**Signature:** `SByte ToSByte$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.SByte], T)`
**Return Type:** `SByte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToUInt16 (static) (generic)

**Signature:** `UInt16 ToUInt16[T](T)`
**Return Type:** `UInt16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToUInt16$W (static) (generic)

**Signature:** `UInt16 ToUInt16$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.UInt16], T)`
**Return Type:** `UInt16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToInt16 (static) (generic)

**Signature:** `Int16 ToInt16[T](T)`
**Return Type:** `Int16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToInt16$W (static) (generic)

**Signature:** `Int16 ToInt16$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int16], T)`
**Return Type:** `Int16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToUInt32 (static) (generic)

**Signature:** `UInt32 ToUInt32[T](T)`
**Return Type:** `UInt32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToUInt32$W (static) (generic)

**Signature:** `UInt32 ToUInt32$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.UInt32], T)`
**Return Type:** `UInt32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToInt32 (static) (generic)

**Signature:** `Int32 ToInt32[T](T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToInt32$W (static) (generic)

**Signature:** `Int32 ToInt32$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32], T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToInt (static) (generic)

**Signature:** `Int32 ToInt[T](T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToInt$W (static) (generic)

**Signature:** `Int32 ToInt$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32], T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToUInt (static) (generic)

**Signature:** `UInt32 ToUInt[T](T)`
**Return Type:** `UInt32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToUInt$W (static) (generic)

**Signature:** `UInt32 ToUInt$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.UInt32], T)`
**Return Type:** `UInt32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToEnum (static) (generic)

**Signature:** `TResult ToEnum[TResult](Int32)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` |  |

---

### KeyValuePattern (static) (generic)

**Signature:** `System.Tuple`2[TKey,TValue] KeyValuePattern[TKey,TValue](System.Collections.Generic.KeyValuePair`2[TKey,TValue])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `keyValuePair` | `KeyValuePair`2` | No | `` |  |

---

### get_Infinity (static)

**Signature:** `Double get_Infinity()`
**Return Type:** `Double`

---

### get_NaN (static)

**Signature:** `Double get_NaN()`
**Return Type:** `Double`

---

### get_InfinitySingle (static)

**Signature:** `Single get_InfinitySingle()`
**Return Type:** `Single`

---

### get_NaNSingle (static)

**Signature:** `Single get_NaNSingle()`
**Return Type:** `Single`

---

### ToUInt64 (static) (generic)

**Signature:** `UInt64 ToUInt64[T](T)`
**Return Type:** `UInt64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToUInt64$W (static) (generic)

**Signature:** `UInt64 ToUInt64$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.UInt64], T)`
**Return Type:** `UInt64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToInt64 (static) (generic)

**Signature:** `Int64 ToInt64[T](T)`
**Return Type:** `Int64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToInt64$W (static) (generic)

**Signature:** `Int64 ToInt64$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int64], T)`
**Return Type:** `Int64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToSingle (static) (generic)

**Signature:** `Single ToSingle[T](T)`
**Return Type:** `Single`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToSingle$W (static) (generic)

**Signature:** `Single ToSingle$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Single], T)`
**Return Type:** `Single`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToDouble (static) (generic)

**Signature:** `Double ToDouble[T](T)`
**Return Type:** `Double`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToDouble$W (static) (generic)

**Signature:** `Double ToDouble$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Double], T)`
**Return Type:** `Double`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToDecimal (static) (generic)

**Signature:** `System.Decimal ToDecimal[T](T)`
**Return Type:** `Decimal`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToDecimal$W (static) (generic)

**Signature:** `System.Decimal ToDecimal$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Decimal], T)`
**Return Type:** `Decimal`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToUIntPtr (static) (generic)

**Signature:** `UIntPtr ToUIntPtr[T](T)`
**Return Type:** `UIntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToUIntPtr$W (static) (generic)

**Signature:** `UIntPtr ToUIntPtr$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.UIntPtr], T)`
**Return Type:** `UIntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToIntPtr (static) (generic)

**Signature:** `IntPtr ToIntPtr[T](T)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToIntPtr$W (static) (generic)

**Signature:** `IntPtr ToIntPtr$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.IntPtr], T)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ToString (static) (generic)

**Signature:** `System.String ToString[T](T)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToChar (static) (generic)

**Signature:** `Char ToChar[T](T)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ToChar$W (static) (generic)

**Signature:** `Char ToChar$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Char], T)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `op_Explicit` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Lock (static) (generic)

**Signature:** `T Lock[TLock,T](TLock, Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lockObject` | `TLock` | No | `` |  |
| `action` | `FSharpFunc`2` | No | `` |  |

---

### Using (static) (generic)

**Signature:** `TResult Using[T,TResult](T, Microsoft.FSharp.Core.FSharpFunc`2[T,TResult])`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `resource` | `T` | No | `` |  |
| `action` | `FSharpFunc`2` | No | `` |  |

---

### TypeOf (static) (generic)

**Signature:** `System.Type TypeOf[T]()`
**Return Type:** `Type`

---

### NameOf (static) (generic)

**Signature:** `System.String NameOf[T](T)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_arg1` | `T` | No | `` |  |

---

### TypeDefOf (static) (generic)

**Signature:** `System.Type TypeDefOf[T]()`
**Return Type:** `Type`

---

### SizeOf (static) (generic)

**Signature:** `Int32 SizeOf[T]()`
**Return Type:** `Int32`

---

### Hash (static) (generic)

**Signature:** `Int32 Hash[T](T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `T` | No | `` |  |

---

### limitedHash (static) (generic)

**Signature:** `Int32 limitedHash[T](Int32, T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `limit` | `Int32` | No | `` |  |
| `obj` | `T` | No | `` |  |

---

### Identity (static) (generic)

**Signature:** `T Identity[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |

---

### Not (static)

**Signature:** `Boolean Not(Boolean)`
**Return Type:** `Boolean`

**Description:** Negate a logical value. Not True equals False and not False equals True

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` | The value to negate. |

**Returns:** The result of the negation.

---

### ConsoleIn (static) (generic)

**Signature:** `System.IO.TextReader ConsoleIn[T]()`
**Return Type:** `TextReader`

---

### ConsoleOut (static) (generic)

**Signature:** `System.IO.TextWriter ConsoleOut[T]()`
**Return Type:** `TextWriter`

---

### ConsoleError (static) (generic)

**Signature:** `System.IO.TextWriter ConsoleError[T]()`
**Return Type:** `TextWriter`

---

### op_Range (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] op_Range[T](T, T)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `start` | `T` | No | `` |  |
| `finish` | `T` | No | `` |  |

---

### op_Range$W (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] op_Range$W[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T, T)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_One` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `start` | `T` | No | `` |  |
| `finish` | `T` | No | `` |  |

---

### op_RangeStep (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] op_RangeStep[T,TStep](T, TStep, T)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `start` | `T` | No | `` |  |
| `step` | `TStep` | No | `` |  |
| `finish` | `T` | No | `` |  |

---

### op_RangeStep$W (static) (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] op_RangeStep$W[T,TStep](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,TStep], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TStep,T]], T, TStep, T)`
**Return Type:** `IEnumerable`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |
| `op_Addition` | `FSharpFunc`2` | No | `` |  |
| `start` | `T` | No | `` |  |
| `step` | `TStep` | No | `` |  |
| `finish` | `T` | No | `` |  |

---

### Abs (static) (generic)

**Signature:** `T Abs[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Abs$W (static) (generic)

**Signature:** `T Abs$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `abs` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Acos (static) (generic)

**Signature:** `T Acos[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Acos$W (static) (generic)

**Signature:** `T Acos$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `acos` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Asin (static) (generic)

**Signature:** `T Asin[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Asin$W (static) (generic)

**Signature:** `T Asin$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asin` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Atan (static) (generic)

**Signature:** `T Atan[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Atan$W (static) (generic)

**Signature:** `T Atan$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `atan` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Atan2 (static) (generic)

**Signature:** `T2 Atan2[T1,T2](T1, T1)`
**Return Type:** `T2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `y` | `T1` | No | `` |  |
| `x` | `T1` | No | `` |  |

---

### Atan2$W (static) (generic)

**Signature:** `T2 Atan2$W[T1,T2](Microsoft.FSharp.Core.FSharpFunc`2[T1,Microsoft.FSharp.Core.FSharpFunc`2[T1,T2]], T1, T1)`
**Return Type:** `T2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `atan2` | `FSharpFunc`2` | No | `` |  |
| `y` | `T1` | No | `` |  |
| `x` | `T1` | No | `` |  |

---

### Ceiling (static) (generic)

**Signature:** `T Ceiling[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Ceiling$W (static) (generic)

**Signature:** `T Ceiling$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ceiling` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Exp (static) (generic)

**Signature:** `T Exp[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Exp$W (static) (generic)

**Signature:** `T Exp$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exp` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Floor (static) (generic)

**Signature:** `T Floor[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Floor$W (static) (generic)

**Signature:** `T Floor$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `floor` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Truncate (static) (generic)

**Signature:** `T Truncate[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Truncate$W (static) (generic)

**Signature:** `T Truncate$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `truncate` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Round (static) (generic)

**Signature:** `T Round[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Round$W (static) (generic)

**Signature:** `T Round$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `round` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Sign (static) (generic)

**Signature:** `Int32 Sign[T](T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Sign$W (static) (generic)

**Signature:** `Int32 Sign$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,System.Int32], T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Sign` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Log (static) (generic)

**Signature:** `T Log[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Log$W (static) (generic)

**Signature:** `T Log$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `log` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Log10 (static) (generic)

**Signature:** `T Log10[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Log10$W (static) (generic)

**Signature:** `T Log10$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `log10` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Sqrt (static) (generic)

**Signature:** `TResult Sqrt[T,TResult](T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Sqrt$W (static) (generic)

**Signature:** `TResult Sqrt$W[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,TResult], T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sqrt` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Cos (static) (generic)

**Signature:** `T Cos[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Cos$W (static) (generic)

**Signature:** `T Cos$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cos` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Cosh (static) (generic)

**Signature:** `T Cosh[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Cosh$W (static) (generic)

**Signature:** `T Cosh$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cosh` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Sin (static) (generic)

**Signature:** `T Sin[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Sin$W (static) (generic)

**Signature:** `T Sin$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sin` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Sinh (static) (generic)

**Signature:** `T Sinh[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Sinh$W (static) (generic)

**Signature:** `T Sinh$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `sinh` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Tan (static) (generic)

**Signature:** `T Tan[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Tan$W (static) (generic)

**Signature:** `T Tan$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tan` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### Tanh (static) (generic)

**Signature:** `T Tanh[T](T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### Tanh$W (static) (generic)

**Signature:** `T Tanh$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,T], T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tanh` | `FSharpFunc`2` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### op_Exponentiation (static) (generic)

**Signature:** `T op_Exponentiation[T,TResult](T, TResult)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `TResult` | No | `` |  |

---

### op_Exponentiation$W (static) (generic)

**Signature:** `T op_Exponentiation$W[T,TResult](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[TResult,T]], T, TResult)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pow` | `FSharpFunc`2` | No | `` |  |
| `x` | `T` | No | `` |  |
| `y` | `TResult` | No | `` |  |

---

### PowInteger (static) (generic)

**Signature:** `T PowInteger[T](T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `n` | `Int32` | No | `` |  |

---

### PowInteger$W (static) (generic)

**Signature:** `T PowInteger$W[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[T,T]], T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_One` | `FSharpFunc`2` | No | `` |  |
| `op_Division` | `FSharpFunc`2` | No | `` |  |
| `op_Multiply` | `FSharpFunc`2` | No | `` |  |
| `x` | `T` | No | `` |  |
| `n` | `Int32` | No | `` |  |

---

## Properties

### Infinity (static)

**Type:** `Double` (read-only)

**Description:** Equivalent to

---

### NaN (static)

**Type:** `Double` (read-only)

**Description:** Equivalent to

---

### InfinitySingle (static)

**Type:** `Single` (read-only)

**Description:** Equivalent to

---

### NaNSingle (static)

**Type:** `Single` (read-only)

**Description:** Equivalent to

---