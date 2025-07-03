# LanguagePrimitives Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.LanguagePrimitives`

Language primitives associated with the F# language

## Methods

### GenericEquality (static) (generic)

**Signature:** `Boolean GenericEquality[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericEqualityER (static) (generic)

**Signature:** `Boolean GenericEqualityER[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericEqualityWithComparer (static) (generic)

**Signature:** `Boolean GenericEqualityWithComparer[T](System.Collections.IEqualityComparer, T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IEqualityComparer` | No | `` |  |
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericComparison (static) (generic)

**Signature:** `Int32 GenericComparison[T](T, T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericComparisonWithComparer (static) (generic)

**Signature:** `Int32 GenericComparisonWithComparer[T](System.Collections.IComparer, T, T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IComparer` | No | `` |  |
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericLessThan (static) (generic)

**Signature:** `Boolean GenericLessThan[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericGreaterThan (static) (generic)

**Signature:** `Boolean GenericGreaterThan[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericLessOrEqual (static) (generic)

**Signature:** `Boolean GenericLessOrEqual[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericGreaterOrEqual (static) (generic)

**Signature:** `Boolean GenericGreaterOrEqual[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericMinimum (static) (generic)

**Signature:** `T GenericMinimum[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### GenericMaximum (static) (generic)

**Signature:** `T GenericMaximum[T](T, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### PhysicalEquality (static) (generic)

**Signature:** `Boolean PhysicalEquality[T](T, T)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e1` | `T` | No | `` |  |
| `e2` | `T` | No | `` |  |

---

### PhysicalHash (static) (generic)

**Signature:** `Int32 PhysicalHash[T](T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `T` | No | `` |  |

---

### get_GenericComparer (static)

**Signature:** `System.Collections.IComparer get_GenericComparer()`
**Return Type:** `IComparer`

---

### get_GenericEqualityComparer (static)

**Signature:** `System.Collections.IEqualityComparer get_GenericEqualityComparer()`
**Return Type:** `IEqualityComparer`

---

### get_GenericEqualityERComparer (static)

**Signature:** `System.Collections.IEqualityComparer get_GenericEqualityERComparer()`
**Return Type:** `IEqualityComparer`

---

### GenericHash (static) (generic)

**Signature:** `Int32 GenericHash[T](T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `T` | No | `` |  |

---

### GenericLimitedHash (static) (generic)

**Signature:** `Int32 GenericLimitedHash[T](Int32, T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `limit` | `Int32` | No | `` |  |
| `obj` | `T` | No | `` |  |

---

### GenericHashWithComparer (static) (generic)

**Signature:** `Int32 GenericHashWithComparer[T](System.Collections.IEqualityComparer, T)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comparer` | `IEqualityComparer` | No | `` |  |
| `obj` | `T` | No | `` |  |

---

### FastGenericEqualityComparerFromTable (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] FastGenericEqualityComparerFromTable[T]()`
**Return Type:** `IEqualityComparer`1`

---

### FastGenericEqualityComparer (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] FastGenericEqualityComparer[T]()`
**Return Type:** `IEqualityComparer`1`

---

### FastLimitedGenericEqualityComparer (static) (generic)

**Signature:** `System.Collections.Generic.IEqualityComparer`1[T] FastLimitedGenericEqualityComparer[T](Int32)`
**Return Type:** `IEqualityComparer`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `limit` | `Int32` | No | `` |  |

---

### FastGenericComparerFromTable (static) (generic)

**Signature:** `System.Collections.Generic.IComparer`1[T] FastGenericComparerFromTable[T]()`
**Return Type:** `IComparer`1`

---

### FastGenericComparer (static) (generic)

**Signature:** `System.Collections.Generic.IComparer`1[T] FastGenericComparer[T]()`
**Return Type:** `IComparer`1`

---

### EnumOfValue (static) (generic)

**Signature:** `TEnum EnumOfValue[T,TEnum](T)`
**Return Type:** `TEnum`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### EnumToValue (static) (generic)

**Signature:** `T EnumToValue[TEnum,T](TEnum)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `enum` | `TEnum` | No | `` |  |

---

### FloatWithMeasure (static)

**Signature:** `Double FloatWithMeasure(Double)`
**Return Type:** `Double`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Double` | No | `` |  |

---

### Float32WithMeasure (static)

**Signature:** `Single Float32WithMeasure(Single)`
**Return Type:** `Single`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Single` | No | `` |  |

---

### DecimalWithMeasure (static)

**Signature:** `System.Decimal DecimalWithMeasure(System.Decimal)`
**Return Type:** `Decimal`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Decimal` | No | `` |  |

---

### Int32WithMeasure (static)

**Signature:** `Int32 Int32WithMeasure(Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Int32` | No | `` |  |

---

### Int16WithMeasure (static)

**Signature:** `Int16 Int16WithMeasure(Int16)`
**Return Type:** `Int16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Int16` | No | `` |  |

---

### SByteWithMeasure (static)

**Signature:** `SByte SByteWithMeasure(SByte)`
**Return Type:** `SByte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `SByte` | No | `` |  |

---

### Int64WithMeasure (static)

**Signature:** `Int64 Int64WithMeasure(Int64)`
**Return Type:** `Int64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Int64` | No | `` |  |

---

### IntPtrWithMeasure (static)

**Signature:** `IntPtr IntPtrWithMeasure(IntPtr)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `IntPtr` | No | `` |  |

---

### UInt32WithMeasure (static)

**Signature:** `UInt32 UInt32WithMeasure(UInt32)`
**Return Type:** `UInt32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `UInt32` | No | `` |  |

---

### UInt16WithMeasure (static)

**Signature:** `UInt16 UInt16WithMeasure(UInt16)`
**Return Type:** `UInt16`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `UInt16` | No | `` |  |

---

### UInt64WithMeasure (static)

**Signature:** `UInt64 UInt64WithMeasure(UInt64)`
**Return Type:** `UInt64`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `UInt64` | No | `` |  |

---

### ByteWithMeasure (static)

**Signature:** `Byte ByteWithMeasure(Byte)`
**Return Type:** `Byte`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `Byte` | No | `` |  |

---

### UIntPtrWithMeasure (static)

**Signature:** `UIntPtr UIntPtrWithMeasure(UIntPtr)`
**Return Type:** `UIntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `UIntPtr` | No | `` |  |

---

### ParseUInt32 (static)

**Signature:** `UInt32 ParseUInt32(System.String)`
**Return Type:** `UInt32`

**Description:** Parse an uint32 according to the rules used by the overloaded 'uint32' conversion operator when applied to strings

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` | The input string. |

**Returns:** The parsed value.

---

### ParseInt32 (static)

**Signature:** `Int32 ParseInt32(System.String)`
**Return Type:** `Int32`

**Description:** Parse an int32 according to the rules used by the overloaded 'int32' conversion operator when applied to strings

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` | The input string. |

**Returns:** The parsed value.

---

### ParseInt64 (static)

**Signature:** `Int64 ParseInt64(System.String)`
**Return Type:** `Int64`

**Description:** Parse an int64 according to the rules used by the overloaded 'int64' conversion operator when applied to strings

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` | The input string. |

**Returns:** The parsed value.

---

### ParseUInt64 (static)

**Signature:** `UInt64 ParseUInt64(System.String)`
**Return Type:** `UInt64`

**Description:** Parse an uint64 according to the rules used by the overloaded 'uint64' conversion operator when applied to strings

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` | The input string. |

**Returns:** The parsed value.

---

### GenericZeroDynamic (static) (generic)

**Signature:** `T GenericZeroDynamic[T]()`
**Return Type:** `T`

---

### GenericOneDynamic (static) (generic)

**Signature:** `T GenericOneDynamic[T]()`
**Return Type:** `T`

---

### GenericZero (static) (generic)

**Signature:** `T GenericZero[T]()`
**Return Type:** `T`

---

### GenericZero$W (static) (generic)

**Signature:** `T GenericZero$W[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_Zero` | `FSharpFunc`2` | No | `` |  |

---

### GenericOne (static) (generic)

**Signature:** `T GenericOne[T]()`
**Return Type:** `T`

---

### GenericOne$W (static) (generic)

**Signature:** `T GenericOne$W[T](Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.Unit,T])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `get_One` | `FSharpFunc`2` | No | `` |  |

---

### AdditionDynamic (static) (generic)

**Signature:** `TResult AdditionDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### SubtractionDynamic (static) (generic)

**Signature:** `TResult SubtractionDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### MultiplyDynamic (static) (generic)

**Signature:** `TResult MultiplyDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### DivisionDynamic (static) (generic)

**Signature:** `TResult DivisionDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### ModulusDynamic (static) (generic)

**Signature:** `TResult ModulusDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### UnaryNegationDynamic (static) (generic)

**Signature:** `TResult UnaryNegationDynamic[T,TResult](T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### CheckedAdditionDynamic (static) (generic)

**Signature:** `TResult CheckedAdditionDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### CheckedSubtractionDynamic (static) (generic)

**Signature:** `TResult CheckedSubtractionDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### CheckedMultiplyDynamic (static) (generic)

**Signature:** `TResult CheckedMultiplyDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### CheckedUnaryNegationDynamic (static) (generic)

**Signature:** `TResult CheckedUnaryNegationDynamic[T,TResult](T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### LeftShiftDynamic (static) (generic)

**Signature:** `TResult LeftShiftDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T1` | No | `` |  |
| `shift` | `T2` | No | `` |  |

---

### RightShiftDynamic (static) (generic)

**Signature:** `TResult RightShiftDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T1` | No | `` |  |
| `shift` | `T2` | No | `` |  |

---

### BitwiseAndDynamic (static) (generic)

**Signature:** `TResult BitwiseAndDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### BitwiseOrDynamic (static) (generic)

**Signature:** `TResult BitwiseOrDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### ExclusiveOrDynamic (static) (generic)

**Signature:** `TResult ExclusiveOrDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### LogicalNotDynamic (static) (generic)

**Signature:** `TResult LogicalNotDynamic[T,TResult](T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### ExplicitDynamic (static) (generic)

**Signature:** `TResult ExplicitDynamic[T,TResult](T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### CheckedExplicitDynamic (static) (generic)

**Signature:** `TResult CheckedExplicitDynamic[T,TResult](T)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `T` | No | `` |  |

---

### LessThanDynamic (static) (generic)

**Signature:** `TResult LessThanDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### GreaterThanDynamic (static) (generic)

**Signature:** `TResult GreaterThanDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### LessThanOrEqualDynamic (static) (generic)

**Signature:** `TResult LessThanOrEqualDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### GreaterThanOrEqualDynamic (static) (generic)

**Signature:** `TResult GreaterThanOrEqualDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### EqualityDynamic (static) (generic)

**Signature:** `TResult EqualityDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### InequalityDynamic (static) (generic)

**Signature:** `TResult InequalityDynamic[T1,T2,TResult](T1, T2)`
**Return Type:** `TResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T1` | No | `` |  |
| `y` | `T2` | No | `` |  |

---

### DivideByIntDynamic (static) (generic)

**Signature:** `T DivideByIntDynamic[T](T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `n` | `Int32` | No | `` |  |

---

### DivideByInt (static) (generic)

**Signature:** `T DivideByInt[T](T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `T` | No | `` |  |
| `y` | `Int32` | No | `` |  |

---

### DivideByInt$W (static) (generic)

**Signature:** `T DivideByInt$W[T](Microsoft.FSharp.Core.FSharpFunc`2[T,Microsoft.FSharp.Core.FSharpFunc`2[System.Int32,T]], T, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `divideByInt` | `FSharpFunc`2` | No | `` |  |
| `x` | `T` | No | `` |  |
| `y` | `Int32` | No | `` |  |

---

## Properties

### GenericComparer (static)

**Type:** `IComparer` (read-only)

**Description:** A static F# comparer object

---

### GenericEqualityComparer (static)

**Type:** `IEqualityComparer` (read-only)

**Description:** Return an F# comparer object suitable for hashing and equality. This hashing behaviour
 of the returned comparer is not limited by an overall node count when hashing F#
 records, lists and union types.

---

### GenericEqualityERComparer (static)

**Type:** `IEqualityComparer` (read-only)

**Description:** Return an F# comparer object suitable for hashing and equality. This hashing behaviour
 of the returned comparer is not limited by an overall node count when hashing F#
 records, lists and union types. This equality comparer has equivalence 
 relation semantics ([nan] = [nan]).

---