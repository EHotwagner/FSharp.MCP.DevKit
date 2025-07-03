# ITypeProvider Interface

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ITypeProvider`
- **Implements:** `System.IDisposable`

Represents an instantiation of a type provider component.

## Methods

### GetNamespaces

**Signature:** `Microsoft.FSharp.Core.CompilerServices.IProvidedNamespace[] GetNamespaces()`
**Return Type:** `IProvidedNamespace[]`

**Description:** Gets the namespaces provided by the type provider.

---

### GetStaticParameters

**Signature:** `System.Reflection.ParameterInfo[] GetStaticParameters(System.Type)`
**Return Type:** `ParameterInfo[]`

**Description:** Get the static parameters for a provided type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeWithoutArguments` | `Type` | No | `` | A type returned by GetTypes or ResolveTypeName |

**Returns:** 

---

### ApplyStaticArguments

**Signature:** `System.Type ApplyStaticArguments(System.Type, System.String[], System.Object[])`
**Return Type:** `Type`

**Description:** Apply static arguments to a provided type that accepts static arguments.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeWithoutArguments` | `Type` | No | `` | the provided type definition which has static parameters |
| `typePathWithArguments` | `String[]` | No | `` | the full path of the type, including encoded representations of static parameters |
| `staticArguments` | `Object[]` | No | `` | the static parameters, indexed by name |

**Returns:** 

---

### GetInvokerExpression

**Signature:** `Microsoft.FSharp.Quotations.FSharpExpr GetInvokerExpression(System.Reflection.MethodBase, Microsoft.FSharp.Quotations.FSharpExpr[])`
**Return Type:** `FSharpExpr`

**Description:** Called by the compiler to ask for an Expression tree to replace the given MethodBase with.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `syntheticMethodBase` | `MethodBase` | No | `` | MethodBase that was given to the compiler by a type returned by a GetType(s) call. |
| `parameters` | `FSharpExpr[]` | No | `` | Expressions that represent the parameters to this call. |

**Returns:** An expression that the compiler will use in place of the given method base.

---

### add_Invalidate

**Signature:** `Void add_Invalidate(System.EventHandler)`
**Return Type:** `Void`

**Description:** Triggered when an assumption changes that invalidates the resolutions so far reported by the provider

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `EventHandler` | No | `` |  |

---

### remove_Invalidate

**Signature:** `Void remove_Invalidate(System.EventHandler)`
**Return Type:** `Void`

**Description:** Triggered when an assumption changes that invalidates the resolutions so far reported by the provider

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `EventHandler` | No | `` |  |

---

### GetGeneratedAssemblyContents

**Signature:** `Byte[] GetGeneratedAssemblyContents(System.Reflection.Assembly)`
**Return Type:** `Byte[]`

**Description:** Get the physical contents of the given logical provided assembly.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `assembly` | `Assembly` | No | `` |  |

---