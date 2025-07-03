# FSharpValue Class

**Namespace:** `Microsoft.FSharp.Reflection`
**Full Name:** `Microsoft.FSharp.Reflection.FSharpValue`

Contains operations associated with constructing and analyzing values associated with F# types
 such as records, unions and tuples.

## Methods

### MakeRecord (static)

**Signature:** `System.Object MakeRecord(System.Type, System.Object[], Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `values` | `Object[]` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### GetRecordField (static)

**Signature:** `System.Object GetRecordField(System.Object, System.Reflection.PropertyInfo)`
**Return Type:** `Object`

**Description:** Reads a field from a record value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `record` | `Object` | No | `` | The record object. |
| `info` | `PropertyInfo` | No | `` | The PropertyInfo describing the field to read. |

**Returns:** The field from the record.

---

### GetRecordFields (static)

**Signature:** `System.Object[] GetRecordFields(System.Object, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Object[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `record` | `Object` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeRecordFieldReader (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object] PreComputeRecordFieldReader(System.Reflection.PropertyInfo)`
**Return Type:** `FSharpFunc`2`

**Description:** Precompute a function for reading a particular field from a record.
 Assumes the given type is a RecordType with a field of the given name.
 If not,  is raised during pre-computation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `info` | `PropertyInfo` | No | `` | The PropertyInfo of the field to read. |

**Returns:** A function to read the specified field from the record.

---

### PreComputeRecordReader (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object[]] PreComputeRecordReader(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeRecordConstructor (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object[],System.Object] PreComputeRecordConstructor(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeRecordConstructorInfo (static)

**Signature:** `System.Reflection.ConstructorInfo PreComputeRecordConstructorInfo(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `ConstructorInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### MakeFunction (static)

**Signature:** `System.Object MakeFunction(System.Type, Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object])`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `functionType` | `Type` | No | `` |  |
| `implementation` | `FSharpFunc`2` | No | `` |  |

---

### MakeTuple (static)

**Signature:** `System.Object MakeTuple(System.Object[], System.Type)`
**Return Type:** `Object`

**Description:** Creates an instance of a tuple type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tupleElements` | `Object[]` | No | `` | The array of tuple fields. |
| `tupleType` | `Type` | No | `` | The tuple type to create. |

**Returns:** An instance of the tuple type with the given elements.

---

### GetTupleFields (static)

**Signature:** `System.Object[] GetTupleFields(System.Object)`
**Return Type:** `Object[]`

**Description:** Reads all fields from a tuple.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tuple` | `Object` | No | `` | The input tuple. |

**Returns:** An array of the fields from the given tuple.

---

### GetTupleField (static)

**Signature:** `System.Object GetTupleField(System.Object, Int32)`
**Return Type:** `Object`

**Description:** Reads a field from a tuple value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tuple` | `Object` | No | `` | The input tuple. |
| `index` | `Int32` | No | `` | The index of the field to read. |

**Returns:** The value of the field.

---

### PreComputeTupleReader (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object[]] PreComputeTupleReader(System.Type)`
**Return Type:** `FSharpFunc`2`

**Description:** Precompute a function for reading the values of a particular tuple type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tupleType` | `Type` | No | `` | The tuple type to read. |

**Returns:** A function to read values of the given tuple type.

---

### PreComputeTuplePropertyInfo (static)

**Signature:** `System.Tuple`2[System.Reflection.PropertyInfo,Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`2[System.Type,System.Int32]]] PreComputeTuplePropertyInfo(System.Type, Int32)`
**Return Type:** `Tuple`2`

**Description:** Gets information that indicates how to read a field of a tuple

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tupleType` | `Type` | No | `` | The input tuple type. |
| `index` | `Int32` | No | `` | The index of the tuple element to describe. |

**Returns:** The description of the tuple element and an optional type and index if the tuple is big.

---

### PreComputeTupleConstructor (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object[],System.Object] PreComputeTupleConstructor(System.Type)`
**Return Type:** `FSharpFunc`2`

**Description:** Precompute a function for reading the values of a particular tuple type

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tupleType` | `Type` | No | `` | The type of tuple to read. |

**Returns:** A function to read a particular tuple type.

---

### PreComputeTupleConstructorInfo (static)

**Signature:** `System.Tuple`2[System.Reflection.ConstructorInfo,Microsoft.FSharp.Core.FSharpOption`1[System.Type]] PreComputeTupleConstructorInfo(System.Type)`
**Return Type:** `Tuple`2`

**Description:** Gets a method that constructs objects of the given tuple type.
 For small tuples, no additional type will be returned.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `tupleType` | `Type` | No | `` | The input tuple type. |

**Returns:** The description of the tuple type constructor and an optional extra type
 for large tuples.

---

### MakeUnion (static)

**Signature:** `System.Object MakeUnion(Microsoft.FSharp.Reflection.UnionCaseInfo, System.Object[], Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `args` | `Object[]` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeUnionConstructor (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object[],System.Object] PreComputeUnionConstructor(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeUnionConstructorInfo (static)

**Signature:** `System.Reflection.MethodInfo PreComputeUnionConstructorInfo(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `MethodInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### GetUnionFields (static)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Reflection.UnionCaseInfo,System.Object[]] GetUnionFields(System.Object, System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |
| `unionType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeUnionTagReader (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Int32] PreComputeUnionTagReader(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeUnionTagMemberInfo (static)

**Signature:** `System.Reflection.MemberInfo PreComputeUnionTagMemberInfo(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `MemberInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionType` | `Type` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### PreComputeUnionReader (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object[]] PreComputeUnionReader(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---

### GetExceptionFields (static)

**Signature:** `System.Object[] GetExceptionFields(System.Object, Microsoft.FSharp.Core.FSharpOption`1[System.Reflection.BindingFlags])`
**Return Type:** `Object[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exn` | `Object` | No | `` |  |
| `bindingFlags` | `FSharpOption`1` | No | `` |  |

---