# BuildServerModule Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.BuildServerModule`

Contains functions which allow build scripts to interact with a build server.

## Methods

### get_localBuildLabel (static)

**Signature:** `System.String get_localBuildLabel()`
**Return Type:** `String`

---

### get_xmlOutputFile (static)

**Signature:** `System.String get_xmlOutputFile()`
**Return Type:** `String`

---

### set_xmlOutputFile (static)

**Signature:** `Void set_xmlOutputFile(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_bambooBuildNumber (static)

**Signature:** `System.String get_bambooBuildNumber()`
**Return Type:** `String`

---

### get_isBambooBuild (static)

**Signature:** `Boolean get_isBambooBuild()`
**Return Type:** `Boolean`

---

### get_isTFBuild (static)

**Signature:** `Boolean get_isTFBuild()`
**Return Type:** `Boolean`

---

### get_tfBuildNumber (static)

**Signature:** `System.String get_tfBuildNumber()`
**Return Type:** `String`

---

### get_tcBuildNumber (static)

**Signature:** `System.String get_tcBuildNumber()`
**Return Type:** `String`

---

### get_travisBuildNumber (static)

**Signature:** `System.String get_travisBuildNumber()`
**Return Type:** `String`

---

### get_isGitlabCI (static)

**Signature:** `Boolean get_isGitlabCI()`
**Return Type:** `Boolean`

---

### get_gitlabCIBuildNumber (static)

**Signature:** `System.String get_gitlabCIBuildNumber()`
**Return Type:** `String`

---

### get_isGitHubActionsBuild (static)

**Signature:** `Boolean get_isGitHubActionsBuild()`
**Return Type:** `Boolean`

---

### get_gitHubActionsBuildNumber (static)

**Signature:** `System.String get_gitHubActionsBuildNumber()`
**Return Type:** `String`

---

### get_jenkinsBuildNumber (static)

**Signature:** `System.String get_jenkinsBuildNumber()`
**Return Type:** `String`

---

### get_ccBuildLabel (static)

**Signature:** `System.String get_ccBuildLabel()`
**Return Type:** `String`

---

### get_appVeyorBuildVersion (static)

**Signature:** `System.String get_appVeyorBuildVersion()`
**Return Type:** `String`

---

### get_buildServer (static)

**Signature:** `Fake.Core.BuildServer get_buildServer()`
**Return Type:** `BuildServer`

---

### get_buildVersion (static)

**Signature:** `System.String get_buildVersion()`
**Return Type:** `String`

---

### get_isLocalBuild (static)

**Signature:** `Boolean get_isLocalBuild()`
**Return Type:** `Boolean`

---

### get_ansiColorSupport (static)

**Signature:** `Boolean get_ansiColorSupport()`
**Return Type:** `Boolean`

---

### set_ansiColorSupport (static)

**Signature:** `Void set_ansiColorSupport(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### install (static)

**Signature:** `Void install(Microsoft.FSharp.Collections.FSharpList`1[Fake.Core.BuildServerInstaller])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `servers` | `FSharpList`1` | No | `` |  |

---

## Properties

### localBuildLabel (static)

**Type:** `String` (read-only)

**Description:** A constant label for local builds

---

### xmlOutputFile (static)

**Type:** `String` (read/write)

**Description:** Defines the XML output file - used for build servers like CruiseControl.NET.
 This output file can be specified by using the *logfile* build parameter.

---

### bambooBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from Bamboo

---

### isBambooBuild (static)

**Type:** `Boolean` (read-only)

**Description:** Checks if we are on Bamboo

---

### isTFBuild (static)

**Type:** `Boolean` (read-only)

**Description:** Checks if we are on Team Foundation

---

### tfBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from Team Foundation

---

### tcBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from TeamCity

---

### travisBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from Travis

---

### isGitlabCI (static)

**Type:** `Boolean` (read-only)

**Description:** Checks if we are on GitLab CI

---

### gitlabCIBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from GitLab CI

---

### isGitHubActionsBuild (static)

**Type:** `Boolean` (read-only)

**Description:** Checks if we are on GitHub Actions
 </summary>
 [omit]

---

### gitHubActionsBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from GitHub Actions

---

### jenkinsBuildNumber (static)

**Type:** `String` (read-only)

**Description:** Build number retrieved from Jenkins

---

### ccBuildLabel (static)

**Type:** `String` (read-only)

**Description:** CruiseControl.NET Build label

---

### appVeyorBuildVersion (static)

**Type:** `String` (read-only)

**Description:** AppVeyor build number

---

### buildServer (static)

**Type:** `BuildServer` (read-only)

**Description:** The current build server

---

### buildVersion (static)

**Type:** `String` (read-only)

**Description:** The current build version as detected from the current build server.

---

### isLocalBuild (static)

**Type:** `Boolean` (read-only)

**Description:** Is true when the current build is a local build.

---

### ansiColorSupport (static)

**Type:** `Boolean` (read/write)

---