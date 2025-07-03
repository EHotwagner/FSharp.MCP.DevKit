# BuildServer Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.BuildServer`
- **Implements:** `System.IEquatable`1[[Fake.Core.BuildServer, Fake.Core.Environment, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.Collections.IStructuralEquatable`, `System.IComparable`1[[Fake.Core.BuildServer, Fake.Core.Environment, Version=6.1.3.0, Culture=neutral, PublicKeyToken=null]]`, `System.IComparable`, `System.Collections.IStructuralComparable`

The server type option.

## Methods

### get_TeamFoundation (static)

**Signature:** `Fake.Core.BuildServer get_TeamFoundation()`
**Return Type:** `BuildServer`

---

### get_IsTeamFoundation

**Signature:** `Boolean get_IsTeamFoundation()`
**Return Type:** `Boolean`

---

### get_TeamCity (static)

**Signature:** `Fake.Core.BuildServer get_TeamCity()`
**Return Type:** `BuildServer`

---

### get_IsTeamCity

**Signature:** `Boolean get_IsTeamCity()`
**Return Type:** `Boolean`

---

### get_CCNet (static)

**Signature:** `Fake.Core.BuildServer get_CCNet()`
**Return Type:** `BuildServer`

---

### get_IsCCNet

**Signature:** `Boolean get_IsCCNet()`
**Return Type:** `Boolean`

---

### get_Jenkins (static)

**Signature:** `Fake.Core.BuildServer get_Jenkins()`
**Return Type:** `BuildServer`

---

### get_IsJenkins

**Signature:** `Boolean get_IsJenkins()`
**Return Type:** `Boolean`

---

### get_Travis (static)

**Signature:** `Fake.Core.BuildServer get_Travis()`
**Return Type:** `BuildServer`

---

### get_IsTravis

**Signature:** `Boolean get_IsTravis()`
**Return Type:** `Boolean`

---

### get_AppVeyor (static)

**Signature:** `Fake.Core.BuildServer get_AppVeyor()`
**Return Type:** `BuildServer`

---

### get_IsAppVeyor

**Signature:** `Boolean get_IsAppVeyor()`
**Return Type:** `Boolean`

---

### get_GitLabCI (static)

**Signature:** `Fake.Core.BuildServer get_GitLabCI()`
**Return Type:** `BuildServer`

---

### get_IsGitLabCI

**Signature:** `Boolean get_IsGitLabCI()`
**Return Type:** `Boolean`

---

### get_GitHubActions (static)

**Signature:** `Fake.Core.BuildServer get_GitHubActions()`
**Return Type:** `BuildServer`

---

### get_IsGitHubActions

**Signature:** `Boolean get_IsGitHubActions()`
**Return Type:** `Boolean`

---

### get_Bamboo (static)

**Signature:** `Fake.Core.BuildServer get_Bamboo()`
**Return Type:** `BuildServer`

---

### get_IsBamboo

**Signature:** `Boolean get_IsBamboo()`
**Return Type:** `Boolean`

---

### get_BitbucketPipelines (static)

**Signature:** `Fake.Core.BuildServer get_BitbucketPipelines()`
**Return Type:** `BuildServer`

---

### get_IsBitbucketPipelines

**Signature:** `Boolean get_IsBitbucketPipelines()`
**Return Type:** `Boolean`

---

### get_LocalBuild (static)

**Signature:** `Fake.Core.BuildServer get_LocalBuild()`
**Return Type:** `BuildServer`

---

### get_IsLocalBuild

**Signature:** `Boolean get_IsLocalBuild()`
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

**Signature:** `Int32 CompareTo(Fake.Core.BuildServer)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `BuildServer` | No | `` |  |

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

### Equals

**Signature:** `Boolean Equals(Fake.Core.BuildServer)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `BuildServer` | No | `` |  |

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

### TeamFoundation (static)

**Type:** `BuildServer` (read-only)

---

### IsTeamFoundation

**Type:** `Boolean` (read-only)

---

### TeamCity (static)

**Type:** `BuildServer` (read-only)

---

### IsTeamCity

**Type:** `Boolean` (read-only)

---

### CCNet (static)

**Type:** `BuildServer` (read-only)

---

### IsCCNet

**Type:** `Boolean` (read-only)

---

### Jenkins (static)

**Type:** `BuildServer` (read-only)

---

### IsJenkins

**Type:** `Boolean` (read-only)

---

### Travis (static)

**Type:** `BuildServer` (read-only)

---

### IsTravis

**Type:** `Boolean` (read-only)

---

### AppVeyor (static)

**Type:** `BuildServer` (read-only)

---

### IsAppVeyor

**Type:** `Boolean` (read-only)

---

### GitLabCI (static)

**Type:** `BuildServer` (read-only)

---

### IsGitLabCI

**Type:** `Boolean` (read-only)

---

### GitHubActions (static)

**Type:** `BuildServer` (read-only)

---

### IsGitHubActions

**Type:** `Boolean` (read-only)

---

### Bamboo (static)

**Type:** `BuildServer` (read-only)

---

### IsBamboo

**Type:** `Boolean` (read-only)

---

### BitbucketPipelines (static)

**Type:** `BuildServer` (read-only)

---

### IsBitbucketPipelines

**Type:** `Boolean` (read-only)

---

### LocalBuild (static)

**Type:** `BuildServer` (read-only)

---

### IsLocalBuild

**Type:** `Boolean` (read-only)

---