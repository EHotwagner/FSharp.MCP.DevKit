# FSharpReflectionExtensions Class

**Namespace:** `Microsoft.FSharp.Reflection`
**Full Name:** `Microsoft.FSharp.Reflection.FSharpReflectionExtensions`

Defines further accessing additional information about F# types and F# values at runtime.

## Methods

### FSharpType.GetExceptionFields.Static (static)

**Signature:** `System.Reflection.PropertyInfo[] FSharpType.GetExceptionFields.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `PropertyInfo[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exceptionType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpType.IsExceptionRepresentation.Static (static)

**Signature:** `Boolean FSharpType.IsExceptionRepresentation.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exceptionType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpType.GetUnionCases.Static (static)

**Signature:** `Microsoft.FSharp.Reflection.UnionCaseInfo[] FSharpType.GetUnionCases.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `UnionCaseInfo[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpType.GetRecordFields.Static (static)

**Signature:** `System.Reflection.PropertyInfo[] FSharpType.GetRecordFields.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `PropertyInfo[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpType.IsUnion.Static (static)

**Signature:** `Boolean FSharpType.IsUnion.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpType.IsRecord.Static (static)

**Signature:** `Boolean FSharpType.IsRecord.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typ` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.MakeRecord.Static (static)

**Signature:** `System.Object FSharpValue.MakeRecord.Static(System.Type, System.Object[], Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `values` | `Object[]` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.GetRecordFields.Static (static)

**Signature:** `System.Object[] FSharpValue.GetRecordFields.Static(System.Object, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Object[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `record` | `Object` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeRecordReader.Static (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object[]] FSharpValue.PreComputeRecordReader.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeRecordConstructor.Static (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object[],System.Object] FSharpValue.PreComputeRecordConstructor.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeRecordConstructorInfo.Static (static)

**Signature:** `System.Reflection.ConstructorInfo FSharpValue.PreComputeRecordConstructorInfo.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `ConstructorInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `recordType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.MakeUnion.Static (static)

**Signature:** `System.Object FSharpValue.MakeUnion.Static(Microsoft.FSharp.Reflection.UnionCaseInfo, System.Object[], Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `args` | `Object[]` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeUnionConstructor.Static (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object[],System.Object] FSharpValue.PreComputeUnionConstructor.Static(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeUnionConstructorInfo.Static (static)

**Signature:** `System.Reflection.MethodInfo FSharpValue.PreComputeUnionConstructorInfo.Static(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `MethodInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeUnionTagMemberInfo.Static (static)

**Signature:** `System.Reflection.MemberInfo FSharpValue.PreComputeUnionTagMemberInfo.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `MemberInfo`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.GetUnionFields.Static (static)

**Signature:** `System.Tuple`2[Microsoft.FSharp.Reflection.UnionCaseInfo,System.Object[]] FSharpValue.GetUnionFields.Static(System.Object, System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Tuple`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` |  |
| `unionType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeUnionTagReader.Static (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Int32] FSharpValue.PreComputeUnionTagReader.Static(System.Type, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionType` | `Type` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.PreComputeUnionReader.Static (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object[]] FSharpValue.PreComputeUnionReader.Static(Microsoft.FSharp.Reflection.UnionCaseInfo, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `unionCase` | `UnionCaseInfo` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---

### FSharpValue.GetExceptionFields.Static (static)

**Signature:** `System.Object[] FSharpValue.GetExceptionFields.Static(System.Object, Microsoft.FSharp.Core.FSharpOption`1[System.Boolean])`
**Return Type:** `Object[]`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exn` | `Object` | No | `` |  |
| `allowAccessToPrivateRepresentation` | `FSharpOption`1` | No | `` |  |

---