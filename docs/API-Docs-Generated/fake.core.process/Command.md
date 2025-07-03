# Command Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Command`
- **Implements:** `System.IEquatable`1[[Fake.Core.Command, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.Command, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The type of command to execute

## Methods

### NewShellCommand (static)

**Signature:** `Fake.Core.Command NewShellCommand(System.String)`
**Return Type:** `Command`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `String` | No | `` |  |

---

### get_IsShellCommand

**Signature:** `Boolean get_IsShellCommand()`
**Return Type:** `Boolean`

---

### NewRawCommand (static)

**Signature:** `Fake.Core.Command NewRawCommand(System.String, Fake.Core.Arguments)`
**Return Type:** `Command`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_executable` | `String` | No | `` |  |
| `_arguments` | `Arguments` | No | `` |  |

---

### get_IsRawCommand

**Signature:** `Boolean get_IsRawCommand()`
**Return Type:** `Boolean`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.Command)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Command` | No | `` |  |

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

### get_CommandLine

**Signature:** `System.String get_CommandLine()`
**Return Type:** `String`

---

### get_Arguments

**Signature:** `Fake.Core.Arguments get_Arguments()`
**Return Type:** `Arguments`

---

### get_Executable

**Signature:** `System.String get_Executable()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.Command)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Command` | No | `` |  |

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

### Tag

**Type:** `Int32` (read-only)

---

### IsShellCommand

**Type:** `Boolean` (read-only)

---

### IsRawCommand

**Type:** `Boolean` (read-only)

---

### CommandLine

**Type:** `String` (read-only)

---

### Arguments

**Type:** `Arguments` (read-only)

---

### Executable

**Type:** `String` (read-only)

---