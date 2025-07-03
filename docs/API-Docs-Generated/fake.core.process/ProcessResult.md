# ProcessResult Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ProcessResult`
- **Implements:** `System.IEquatable`1[[Fake.Core.ProcessResult, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.ProcessResult, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

A process result including error code, message log and errors.

## Methods

### get_ExitCode

**Signature:** `Int32 get_ExitCode()`
**Return Type:** `Int32`

---

### get_Results

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.ConsoleMessage] get_Results()`
**Return Type:** `FSharpList`1`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.ProcessResult)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ProcessResult` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Object)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### CompareTo

**Signature:** `Int32 CompareTo(System.Object, System.Collections.IComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode(System.Collections.IEqualityComparer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `comp` | `IEqualityComparer` | No | `` |  |

---

### GetHashCode

**Signature:** `Int32 GetHashCode()`
**Return Type:** `Int32`

---

### Equals

**Signature:** `Boolean Equals(System.Object, System.Collections.IEqualityComparer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |
| `comp` | `IEqualityComparer` | No | `` |  |

---

### get_OK

**Signature:** `Boolean get_OK()`
**Return Type:** `Boolean`

---

### get_Messages

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] get_Messages()`
**Return Type:** `FSharpList`1`

---

### get_Errors

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] get_Errors()`
**Return Type:** `FSharpList`1`

---

### New (static)

**Signature:** `Fake.Core.ProcessResult New(Int32, Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.ConsoleMessage])`
**Return Type:** `ProcessResult`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `exitCode` | `Int32` | No | `` |  |
| `results` | `FSharpList`1` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.ProcessResult)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ProcessResult` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(System.Object)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

## Properties

### ExitCode

**Type:** `Int32` (read-only)

---

### Results

**Type:** `FSharpList`1` (read-only)

---

### OK

**Type:** `Boolean` (read-only)

---

### Messages

**Type:** `FSharpList`1` (read-only)

---

### Errors

**Type:** `FSharpList`1` (read-only)

---