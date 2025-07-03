# TypeProviderConfig Class

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig`

If the class that implements ITypeProvider has a constructor that accepts TypeProviderConfig
 then it will be constructed with an instance of TypeProviderConfig.

## Methods

### get_ResolutionFolder

**Signature:** `System.String get_ResolutionFolder()`
**Return Type:** `String`

---

### set_ResolutionFolder

**Signature:** `Void set_ResolutionFolder(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### get_RuntimeAssembly

**Signature:** `System.String get_RuntimeAssembly()`
**Return Type:** `String`

---

### set_RuntimeAssembly

**Signature:** `Void set_RuntimeAssembly(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### get_ReferencedAssemblies

**Signature:** `System.String[] get_ReferencedAssemblies()`
**Return Type:** `String[]`

---

### set_ReferencedAssemblies

**Signature:** `Void set_ReferencedAssemblies(System.String[])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String[]` | No | `` |  |

---

### get_TemporaryFolder

**Signature:** `System.String get_TemporaryFolder()`
**Return Type:** `String`

---

### set_TemporaryFolder

**Signature:** `Void set_TemporaryFolder(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `String` | No | `` |  |

---

### get_IsInvalidationSupported

**Signature:** `Boolean get_IsInvalidationSupported()`
**Return Type:** `Boolean`

---

### set_IsInvalidationSupported

**Signature:** `Void set_IsInvalidationSupported(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_IsHostedExecution

**Signature:** `Boolean get_IsHostedExecution()`
**Return Type:** `Boolean`

---

### set_IsHostedExecution

**Signature:** `Void set_IsHostedExecution(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Boolean` | No | `` |  |

---

### get_SystemRuntimeAssemblyVersion

**Signature:** `System.Version get_SystemRuntimeAssemblyVersion()`
**Return Type:** `Version`

---

### set_SystemRuntimeAssemblyVersion

**Signature:** `Void set_SystemRuntimeAssemblyVersion(System.Version)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `v` | `Version` | No | `` |  |

---

### SystemRuntimeContainsType

**Signature:** `Boolean SystemRuntimeContainsType(System.String)`
**Return Type:** `Boolean`

**Description:** Checks if given type exists in target system runtime library

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeName` | `String` | No | `` |  |

---

## Properties

### ResolutionFolder

**Type:** `String` (read/write)

**Description:** Get the full path to use to resolve relative paths in any file name arguments given to the type provider instance.

---

### RuntimeAssembly

**Type:** `String` (read/write)

**Description:** Get the full path to referenced assembly that caused this type provider instance to be created.

---

### ReferencedAssemblies

**Type:** `String[]` (read/write)

**Description:** Get the referenced assemblies for the type provider instance.

---

### TemporaryFolder

**Type:** `String` (read/write)

**Description:** Get the full path to use for temporary files for the type provider instance.

---

### IsInvalidationSupported

**Type:** `Boolean` (read/write)

**Description:** Indicates if the type provider host responds to invalidation events for type provider instances.

---

### IsHostedExecution

**Type:** `Boolean` (read/write)

**Description:** Indicates if the type provider instance is used in an environment which executes provided code such as F# Interactive.

---

### SystemRuntimeAssemblyVersion

**Type:** `Version` (read/write)

**Description:** version of referenced system runtime assembly

---