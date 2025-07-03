# ImportData Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ImportData`
- **Implements:** `System.IEquatable`1[[Fake.Core.ImportData, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.ImportData, Fake.Core.Trace, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The types of data to import in build process
 Please consider not using a match on this type in code external to the fake repository.

## Methods

### get_BuildArtifact (static)

**Signature:** `Fake.Core.ImportData get_BuildArtifact()`
**Return Type:** `ImportData`

---

### get_IsBuildArtifact

**Signature:** `Boolean get_IsBuildArtifact()`
**Return Type:** `Boolean`

---

### NewBuildArtifactWithName (static)

**Signature:** `Fake.Core.ImportData NewBuildArtifactWithName(System.String)`
**Return Type:** `ImportData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_artifactName` | `String` | No | `` |  |

---

### get_IsBuildArtifactWithName

**Signature:** `Boolean get_IsBuildArtifactWithName()`
**Return Type:** `Boolean`

---

### NewDotNetCoverage (static)

**Signature:** `Fake.Core.ImportData NewDotNetCoverage(Fake.Core.DotNetCoverageTool)`
**Return Type:** `ImportData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `DotNetCoverageTool` | No | `` |  |

---

### get_IsDotNetCoverage

**Signature:** `Boolean get_IsDotNetCoverage()`
**Return Type:** `Boolean`

---

### get_DotNetDupFinder (static)

**Signature:** `Fake.Core.ImportData get_DotNetDupFinder()`
**Return Type:** `ImportData`

---

### get_IsDotNetDupFinder

**Signature:** `Boolean get_IsDotNetDupFinder()`
**Return Type:** `Boolean`

---

### get_PmdCpd (static)

**Signature:** `Fake.Core.ImportData get_PmdCpd()`
**Return Type:** `ImportData`

---

### get_IsPmdCpd

**Signature:** `Boolean get_IsPmdCpd()`
**Return Type:** `Boolean`

---

### get_Pmd (static)

**Signature:** `Fake.Core.ImportData get_Pmd()`
**Return Type:** `ImportData`

---

### get_IsPmd

**Signature:** `Boolean get_IsPmd()`
**Return Type:** `Boolean`

---

### get_FxCop (static)

**Signature:** `Fake.Core.ImportData get_FxCop()`
**Return Type:** `ImportData`

---

### get_IsFxCop

**Signature:** `Boolean get_IsFxCop()`
**Return Type:** `Boolean`

---

### get_ReSharperInspectCode (static)

**Signature:** `Fake.Core.ImportData get_ReSharperInspectCode()`
**Return Type:** `ImportData`

---

### get_IsReSharperInspectCode

**Signature:** `Boolean get_IsReSharperInspectCode()`
**Return Type:** `Boolean`

---

### get_Jslint (static)

**Signature:** `Fake.Core.ImportData get_Jslint()`
**Return Type:** `ImportData`

---

### get_IsJslint

**Signature:** `Boolean get_IsJslint()`
**Return Type:** `Boolean`

---

### get_FindBugs (static)

**Signature:** `Fake.Core.ImportData get_FindBugs()`
**Return Type:** `ImportData`

---

### get_IsFindBugs

**Signature:** `Boolean get_IsFindBugs()`
**Return Type:** `Boolean`

---

### get_Checkstyle (static)

**Signature:** `Fake.Core.ImportData get_Checkstyle()`
**Return Type:** `ImportData`

---

### get_IsCheckstyle

**Signature:** `Boolean get_IsCheckstyle()`
**Return Type:** `Boolean`

---

### get_Gtest (static)

**Signature:** `Fake.Core.ImportData get_Gtest()`
**Return Type:** `ImportData`

---

### get_IsGtest

**Signature:** `Boolean get_IsGtest()`
**Return Type:** `Boolean`

---

### get_Mstest (static)

**Signature:** `Fake.Core.ImportData get_Mstest()`
**Return Type:** `ImportData`

---

### get_IsMstest

**Signature:** `Boolean get_IsMstest()`
**Return Type:** `Boolean`

---

### get_Surefire (static)

**Signature:** `Fake.Core.ImportData get_Surefire()`
**Return Type:** `ImportData`

---

### get_IsSurefire

**Signature:** `Boolean get_IsSurefire()`
**Return Type:** `Boolean`

---

### get_Junit (static)

**Signature:** `Fake.Core.ImportData get_Junit()`
**Return Type:** `ImportData`

---

### get_IsJunit

**Signature:** `Boolean get_IsJunit()`
**Return Type:** `Boolean`

---

### get_Xunit (static)

**Signature:** `Fake.Core.ImportData get_Xunit()`
**Return Type:** `ImportData`

---

### get_IsXunit

**Signature:** `Boolean get_IsXunit()`
**Return Type:** `Boolean`

---

### NewNunit (static)

**Signature:** `Fake.Core.ImportData NewNunit(Fake.Core.NunitDataVersion)`
**Return Type:** `ImportData`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `NunitDataVersion` | No | `` |  |

---

### get_IsNunit

**Signature:** `Boolean get_IsNunit()`
**Return Type:** `Boolean`

---

### get_Tag

**Signature:** `Int32 get_Tag()`
**Return Type:** `Int32`

---

### CompareTo

**Signature:** `Int32 CompareTo(Fake.Core.ImportData)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ImportData` | No | `` |  |

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

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### Equals

**Signature:** `Boolean Equals(Fake.Core.ImportData)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `ImportData` | No | `` |  |

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

### BuildArtifact (static)

**Type:** `ImportData` (read-only)

---

### IsBuildArtifact

**Type:** `Boolean` (read-only)

---

### IsBuildArtifactWithName

**Type:** `Boolean` (read-only)

---

### IsDotNetCoverage

**Type:** `Boolean` (read-only)

---

### DotNetDupFinder (static)

**Type:** `ImportData` (read-only)

---

### IsDotNetDupFinder

**Type:** `Boolean` (read-only)

---

### PmdCpd (static)

**Type:** `ImportData` (read-only)

---

### IsPmdCpd

**Type:** `Boolean` (read-only)

---

### Pmd (static)

**Type:** `ImportData` (read-only)

---

### IsPmd

**Type:** `Boolean` (read-only)

---

### FxCop (static)

**Type:** `ImportData` (read-only)

---

### IsFxCop

**Type:** `Boolean` (read-only)

---

### ReSharperInspectCode (static)

**Type:** `ImportData` (read-only)

---

### IsReSharperInspectCode

**Type:** `Boolean` (read-only)

---

### Jslint (static)

**Type:** `ImportData` (read-only)

---

### IsJslint

**Type:** `Boolean` (read-only)

---

### FindBugs (static)

**Type:** `ImportData` (read-only)

---

### IsFindBugs

**Type:** `Boolean` (read-only)

---

### Checkstyle (static)

**Type:** `ImportData` (read-only)

---

### IsCheckstyle

**Type:** `Boolean` (read-only)

---

### Gtest (static)

**Type:** `ImportData` (read-only)

---

### IsGtest

**Type:** `Boolean` (read-only)

---

### Mstest (static)

**Type:** `ImportData` (read-only)

---

### IsMstest

**Type:** `Boolean` (read-only)

---

### Surefire (static)

**Type:** `ImportData` (read-only)

---

### IsSurefire

**Type:** `Boolean` (read-only)

---

### Junit (static)

**Type:** `ImportData` (read-only)

---

### IsJunit

**Type:** `Boolean` (read-only)

---

### Xunit (static)

**Type:** `ImportData` (read-only)

---

### IsXunit

**Type:** `Boolean` (read-only)

---

### IsNunit

**Type:** `Boolean` (read-only)

---

### Name

**Type:** `String` (read-only)

---