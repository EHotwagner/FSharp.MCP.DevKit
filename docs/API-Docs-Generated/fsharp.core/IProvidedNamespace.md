# IProvidedNamespace Interface

**Namespace:** `Microsoft.FSharp.Core.CompilerServices`
**Full Name:** `Microsoft.FSharp.Core.CompilerServices.IProvidedNamespace`

Represents a namespace provided by a type provider component.

## Methods

### get_NamespaceName

**Signature:** `System.String get_NamespaceName()`
**Return Type:** `String`

---

### GetNestedNamespaces

**Signature:** `Microsoft.FSharp.Core.CompilerServices.IProvidedNamespace[] GetNestedNamespaces()`
**Return Type:** `IProvidedNamespace[]`

**Description:** The sub-namespaces in this namespace. An optional member to prevent generation of namespaces until an outer namespace is explored.

---

### GetTypes

**Signature:** `System.Type[] GetTypes()`
**Return Type:** `Type[]`

**Description:** The top-level types

**Returns:** 

---

### ResolveTypeName

**Signature:** `System.Type ResolveTypeName(System.String)`
**Return Type:** `Type`

**Description:** Compilers call this method to query a type provider for a type name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `typeName` | `String` | No | `` |  |

**Returns:** 

---

## Properties

### NamespaceName

**Type:** `String` (read-only)

**Description:** Namespace name the provider injects types into.

---