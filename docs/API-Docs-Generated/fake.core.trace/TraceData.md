# TraceData Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.TraceData`
- **Implements:** `System.IEquatable`1[[Fake.Core.TraceData, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.TraceData, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

Defines Tracing information for TraceListeners
 Please consider not using a match on this type in code external to the fake repository.

## Methods

### NewImportData (static)

**Signature:** `Fake.Core.TraceData NewImportData(Fake.Core.ImportData, System.String)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_typ` | `ImportData` | No | `` |  |
| `_path` | `String` | No | `` |  |

---

### get_IsImportData

**Signature:** `Boolean get_IsImportData()`
**Return Type:** `Boolean`

---

### NewBuildNumber (static)

**Signature:** `Fake.Core.TraceData NewBuildNumber(System.String)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_text` | `String` | No | `` |  |

---

### get_IsBuildNumber

**Signature:** `Boolean get_IsBuildNumber()`
**Return Type:** `Boolean`

---

### NewImportantMessage (static)

**Signature:** `Fake.Core.TraceData NewImportantMessage(System.String)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_text` | `String` | No | `` |  |

---

### get_IsImportantMessage

**Signature:** `Boolean get_IsImportantMessage()`
**Return Type:** `Boolean`

---

### NewErrorMessage (static)

**Signature:** `Fake.Core.TraceData NewErrorMessage(System.String)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_text` | `String` | No | `` |  |

---

### get_IsErrorMessage

**Signature:** `Boolean get_IsErrorMessage()`
**Return Type:** `Boolean`

---

### NewLogMessage (static)

**Signature:** `Fake.Core.TraceData NewLogMessage(System.String, Boolean)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_text` | `String` | No | `` |  |
| `_newLine` | `Boolean` | No | `` |  |

---

### get_IsLogMessage

**Signature:** `Boolean get_IsLogMessage()`
**Return Type:** `Boolean`

---

### NewTraceMessage (static)

**Signature:** `Fake.Core.TraceData NewTraceMessage(System.String, Boolean)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_text` | `String` | No | `` |  |
| `_newLine` | `Boolean` | No | `` |  |

---

### get_IsTraceMessage

**Signature:** `Boolean get_IsTraceMessage()`
**Return Type:** `Boolean`

---

### NewOpenTag (static)

**Signature:** `Fake.Core.TraceData NewOpenTag(Fake.Core.KnownTags, Microsoft.FSharp.Core.FSharpOption`1[System.String])`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item1` | `KnownTags` | No | `` |  |
| `_description` | `FSharpOption`1` | No | `` |  |

---

### get_IsOpenTag

**Signature:** `Boolean get_IsOpenTag()`
**Return Type:** `Boolean`

---

### NewTestStatus (static)

**Signature:** `Fake.Core.TraceData NewTestStatus(System.String, Fake.Core.TestStatus)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_testName` | `String` | No | `` |  |
| `_status` | `TestStatus` | No | `` |  |

---

### get_IsTestStatus

**Signature:** `Boolean get_IsTestStatus()`
**Return Type:** `Boolean`

---

### NewTestOutput (static)

**Signature:** `Fake.Core.TraceData NewTestOutput(System.String, System.String, System.String)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_testName` | `String` | No | `` |  |
| `_out` | `String` | No | `` |  |
| `_err` | `String` | No | `` |  |

---

### get_IsTestOutput

**Signature:** `Boolean get_IsTestOutput()`
**Return Type:** `Boolean`

---

### NewCloseTag (static)

**Signature:** `Fake.Core.TraceData NewCloseTag(Fake.Core.KnownTags, System.TimeSpan, Fake.Core.TagStatus)`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item1` | `KnownTags` | No | `` |  |
| `_time` | `TimeSpan` | No | `` |  |
| `item3` | `TagStatus` | No | `` |  |

---

### get_IsCloseTag

**Signature:** `Boolean get_IsCloseTag()`
**Return Type:** `Boolean`

---

### NewBuildState (static)

**Signature:** `Fake.Core.TraceData NewBuildState(Fake.Core.TagStatus, Microsoft.FSharp.Core.FSharpOption`1[System.String])`
**Return Type:** `TraceData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item1` | `TagStatus` | No | `` |  |
| `item2` | `FSharpOption`1` | No | `` |  |

---

### get_IsBuildState

**Signature:** `Boolean get_IsBuildState()`
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

**Signature:** `Int32 CompareTo(Fake.Core.TraceData)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `TraceData` | No | `` |  |

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

### get_NewLine

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Boolean] get_NewLine()`
**Return Type:** `FSharpOption`1`

---

### get_Message

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] get_Message()`
**Return Type:** `FSharpOption`1`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.TraceData)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `TraceData` | No | `` |  |

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

### IsImportData

**Type:** `Boolean` (read-only)

---

### IsBuildNumber

**Type:** `Boolean` (read-only)

---

### IsImportantMessage

**Type:** `Boolean` (read-only)

---

### IsErrorMessage

**Type:** `Boolean` (read-only)

---

### IsLogMessage

**Type:** `Boolean` (read-only)

---

### IsTraceMessage

**Type:** `Boolean` (read-only)

---

### IsOpenTag

**Type:** `Boolean` (read-only)

---

### IsTestStatus

**Type:** `Boolean` (read-only)

---

### IsTestOutput

**Type:** `Boolean` (read-only)

---

### IsCloseTag

**Type:** `Boolean` (read-only)

---

### IsBuildState

**Type:** `Boolean` (read-only)

---

### NewLine

**Type:** `FSharpOption`1` (read-only)

---

### Message

**Type:** `FSharpOption`1` (read-only)

---