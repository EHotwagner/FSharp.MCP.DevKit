# FSharpType Class

**Namespace:** `Microsoft.FSharp.Reflection`
**Full Name:** `Microsoft.FSharp.Reflection.FSharpType`

Contains operations associated with constructing and analyzing F# types such as records, unions and tuples

## Methods

### IsTuple (static)

**Signature:** `Boolean IsTuple(System.Type)`
**Return Type:** `Boolean`

**Description:** Return true if the typ is a representation of an F# tuple type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` | The type to check. |

**Returns:** True if the type check succeeds.

---

### IsRecord (static)

**Signature:** `Boolean IsRecord(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### IsUnion (static)

**Signature:** `Boolean IsUnion(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### IsFunction (static)

**Signature:** `Boolean IsFunction(System.Type)`
**Return Type:** `Boolean`

**Description:** Return true if the typ is a representation of an F# function type or the runtime type of a closure implementing an F# function type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` | The type to check. |

**Returns:** True if the type check succeeds.

---

### IsModule (static)

**Signature:** `Boolean IsModule(System.Type)`
**Return Type:** `Boolean`

**Description:** Return true if the typ is a  value corresponding to the compiled form of an F# module

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` | The type to check. |

**Returns:** True if the type check succeeds.

---

### MakeFunctionType (static)

**Signature:** `System.Type MakeFunctionType(System.Type, System.Type)`
**Return Type:** `Type`

**Description:** Returns a  representing the F# function type with the given domain and range

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `domain` | `Type` | No | `` | The input type of the function. |
| `range` | `Type` | No | `` | The output type of the function. |

**Returns:** The function type with the given domain and range.

---

### MakeTupleType (static)

**Signature:** `System.Type MakeTupleType(System.Type[])`
**Return Type:** `Type`

**Description:** Returns a  representing an F# tuple type with the given element types

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `types` | `Type[]` | No | `` | An array of types for the tuple elements. |

**Returns:** The type representing the tuple containing the input elements.

---

### MakeTupleType (static)

**Signature:** `System.Type MakeTupleType(System.Reflection.Assembly, System.Type[])`
**Return Type:** `Type`

**Description:** Returns a  representing an F# tuple type with the given element types

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asm` | `Assembly` | No | `` | Runtime assembly containing System.Tuple definitions. |
| `types` | `Type[]` | No | `` | An array of types for the tuple elements. |

**Returns:** The type representing the tuple containing the input elements.

---

### MakeStructTupleType (static)

**Signature:** `System.Type MakeStructTupleType(System.Reflection.Assembly, System.Type[])`
**Return Type:** `Type`

**Description:** Returns a  representing an F# struct tuple type with the given element types

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `asm` | `Assembly` | No | `` | Runtime assembly containing System.ValueTuple definitions. |
| `types` | `Type[]` | No | `` | An array of types for the tuple elements. |

**Returns:** The type representing the struct tuple containing the input elements.

---

### MakeStructTupleType (static)

**Signature:** `System.Type MakeStructTupleType(System.Type[])`
**Return Type:** `Type`

**Description:** Returns a  representing an F# struct tuple type with the given element types

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `types` | `Type[]` | No | `` | An array of types for the tuple elements. |

**Returns:** The type representing the struct tuple containing the input elements.

---

### GetTupleElements (static)

**Signature:** `System.Type[] GetTupleElements(System.Type)`
**Return Type:** `Type[]`

**Description:** Gets the tuple elements from the representation of an F# tuple type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tupleType` | `Type` | No | `` | The input tuple type. |

**Returns:** An array of the types contained in the given tuple type.

---

### GetFunctionElements (static)

**Signature:** `System.Tuple`2[System.Type,System.Type] GetFunctionElements(System.Type)`
**Return Type:** `Tuple`2`

**Description:** Gets the domain and range types from an F# function type  or from the runtime type of a closure implementing an F# type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `functionType` | `Type` | No | `` | The input function type. |

**Returns:** A tuple of the domain and range types of the input function.

---

### GetRecordFields (static)

**Signature:** `System.Reflection.PropertyInfo[] GetRecordFields(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `PropertyInfo[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### GetUnionCases (static)

**Signature:** `Microsoft.FSharp.Reflection.UnionCaseInfo[] GetUnionCases(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `UnionCaseInfo[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### IsExceptionRepresentation (static)

**Signature:** `Boolean IsExceptionRepresentation(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exceptionType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### GetExceptionFields (static)

**Signature:** `System.Reflection.PropertyInfo[] GetExceptionFields(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `PropertyInfo[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exceptionType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---