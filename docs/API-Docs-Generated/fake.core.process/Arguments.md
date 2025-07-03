# Arguments Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Arguments`
- **Implements:** `System.IEquatable`1[[Fake.Core.Arguments, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.Arguments, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

Represents a list of arguments

## Methods

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.Arguments)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Arguments` | No | `` |  |

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

**Signature:** `Fake.Core.Arguments get_Empty()`
**Return Type:** `Arguments`

---

### OfWindowsCommandLine (static)

**Signature:** `Fake.Core.Arguments OfWindowsCommandLine(System.String)`
**Return Type:** `Arguments`

**Description:** See https://msdn.microsoft.com/en-us/library/17w5ykft.aspx

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cmd` | `String` | No | `` |  |

---

### get_ToWindowsCommandLine

**Signature:** `System.String get_ToWindowsCommandLine()`
**Return Type:** `String`

---

### get_ToLinuxShellCommandLine

**Signature:** `System.String get_ToLinuxShellCommandLine()`
**Return Type:** `String`

---

### OfArgs (static)

**Signature:** `Fake.Core.Arguments OfArgs(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `Arguments`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `IEnumerable`1` | No | `` |  |

---

### OfStartInfo (static)

**Signature:** `Fake.Core.Arguments OfStartInfo(System.String)`
**Return Type:** `Arguments`

**Description:** Create a new arguments object from a given startinfo-conforming-escaped command line string.
 Same as `OfWindowsCommandLine`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cmd` | `String` | No | `` |  |

---

### get_ToStartInfo

**Signature:** `System.String get_ToStartInfo()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.Arguments)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Arguments` | No | `` |  |

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

### Empty (static)

**Type:** `Arguments` (read-only)

---

### ToWindowsCommandLine

**Type:** `String` (read-only)

**Description:** This is the reverse of https://msdn.microsoft.com/en-us/library/17w5ykft.aspx

---

### ToLinuxShellCommandLine

**Type:** `String` (read-only)

**Description:** Escape the given argument list according to a unix shell (bash)

---

### ToStartInfo

**Type:** `String` (read-only)

**Description:** Create a new command line string which can be used in a ProcessStartInfo object.
 If given, returns the exact input of `OfWindowsCommandLine` otherwise `ToWindowsCommandLine` (with some special code for `mono`) is used.

---