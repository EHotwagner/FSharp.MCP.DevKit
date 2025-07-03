# ConsoleMessage Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ConsoleMessage`
- **Implements:** `System.IEquatable`1[[Fake.Core.ConsoleMessage, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.ConsoleMessage, Fake.Core.Process, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

A record type which captures console messages

## Methods

### get_IsError

**Signature:** `Boolean get_IsError()`
**Return Type:** `Boolean`

---

### get_Message

**Signature:** `System.String get_Message()`
**Return Type:** `String`

---

### get_Timestamp

**Signature:** `System.DateTimeOffset get_Timestamp()`
**Return Type:** `DateTimeOffset`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.ConsoleMessage)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ConsoleMessage` | No | `` |  |

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

### Create (static)

**Signature:** `Fake.Core.ConsoleMessage Create(Boolean, System.String)`
**Return Type:** `ConsoleMessage`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `isError` | `Boolean` | No | `` |  |
| `msg` | `String` | No | `` |  |

---

### CreateError (static)

**Signature:** `Fake.Core.ConsoleMessage CreateError(System.String)`
**Return Type:** `ConsoleMessage`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |

---

### CreateOut (static)

**Signature:** `Fake.Core.ConsoleMessage CreateOut(System.String)`
**Return Type:** `ConsoleMessage`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.ConsoleMessage)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ConsoleMessage` | No | `` |  |

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

### IsError

**Type:** `Boolean` (read-only)

---

### Message

**Type:** `String` (read-only)

---

### Timestamp

**Type:** `DateTimeOffset` (read-only)

---