# ExecParams Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ExecParams`
- **Implements:** `System.IEquatable`1[[Fake.Core.ExecParams, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.ExecParams, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

Parameter type for process execution.

## Methods

### get_Program

**Signature:** `System.String get_Program()`
**Return Type:** `String`

---

### get_WorkingDir

**Signature:** `System.String get_WorkingDir()`
**Return Type:** `String`

---

### get_CommandLine

**Signature:** `System.String get_CommandLine()`
**Return Type:** `String`

---

### get_Args

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Tuple`2[System.String,System.String]] get_Args()`
**Return Type:** `FSharpList`1`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.ExecParams)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ExecParams` | No | `` |  |

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

### get_Empty (static)

**Signature:** `Fake.Core.ExecParams get_Empty()`
**Return Type:** `ExecParams`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.ExecParams)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ExecParams` | No | `` |  |

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

### Program

**Type:** `String` (read-only)

**Description:** The path to the executable, without arguments.

---

### WorkingDir

**Type:** `String` (read-only)

**Description:** The working directory for the program. Defaults to "".

---

### CommandLine

**Type:** `String` (read-only)

**Description:** Command-line parameters in a string.

---

### Args

**Type:** `FSharpList`1` (read-only)

**Description:** Command-line argument pairs. The value will be quoted if it contains
 a string, and the result will be appended to the CommandLine property.
 If the key ends in a letter or number, a space will be inserted between
 the key and the value.

---

### Empty (static)

**Type:** `ExecParams` (read-only)

**Description:** Default parameters for process execution.

---