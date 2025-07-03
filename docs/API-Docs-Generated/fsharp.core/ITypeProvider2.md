# ITypeProvider2 Interface

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.ITypeProvider2`

Represents additional, optional information for a type provider component

## Methods

### GetStaticParametersForMethod

**Signature:** `System.Reflection.ParameterInfo[] GetStaticParametersForMethod(System.Reflection.MethodBase)`
**Return Type:** `ParameterInfo[]`

**Description:** Get the static parameters for a provided method.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `methodWithoutArguments` | `MethodBase` | No | `` | A method returned by GetMethod on a provided type |

**Returns:** The static parameters of the provided method, if any

---

### ApplyStaticArgumentsForMethod

**Signature:** `System.Reflection.MethodBase ApplyStaticArgumentsForMethod(System.Reflection.MethodBase, System.String, System.Object[])`
**Return Type:** `MethodBase`

**Description:** Apply static arguments to a provided method that accepts static arguments.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `methodWithoutArguments` | `MethodBase` | No | `` | the provided method definition which has static parameters |
| `methodNameWithArguments` | `String` | No | `` | the full name of the method that must be returned, including encoded representations of static parameters |
| `staticArguments` | `Object[]` | No | `` | the values of the static parameters, indexed by name |

**Returns:** The provided method definition corresponding to the given static parameter values

---