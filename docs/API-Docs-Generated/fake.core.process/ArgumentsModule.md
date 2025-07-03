# ArgumentsModule Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.ArgumentsModule`

Module for working with an `Arguments` instance

## Methods

### toWindowsCommandLine (static)

**Signature:** `System.String toWindowsCommandLine(Fake.Core.Arguments)`
**Return Type:** `String`

**Description:** This is the reverse of https://msdn.microsoft.com/en-us/library/17w5ykft.aspx

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `Arguments` | No | `` |  |

---

### toLinuxShellCommandLine (static)

**Signature:** `System.String toLinuxShellCommandLine(Fake.Core.Arguments)`
**Return Type:** `String`

**Description:** Escape the given argument list according to a unix shell (bash)

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `Arguments` | No | `` |  |

---

### toStartInfo (static)

**Signature:** `System.String toStartInfo(Fake.Core.Arguments)`
**Return Type:** `String`

**Description:** Create a new command line string which can be used in a ProcessStartInfo object.
 If given, returns the exact input of `OfWindowsCommandLine` otherwise `ToWindowsCommandLine` (with some special code for `mono`) is used.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `Arguments` | No | `` |  |

---

### withPrefix (static)

**Signature:** `Fake.Core.Arguments withPrefix(System.Collections.Generic.IEnumerable`1[System.String], Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `IEnumerable`1` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### append (static)

**Signature:** `Fake.Core.Arguments append(System.Collections.Generic.IEnumerable`1[System.String], Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `IEnumerable`1` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendRaw (static)

**Signature:** `Fake.Core.Arguments appendRaw(System.String, Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Description:** Appends the given raw argument to the command line, you can not use other methods for this to work
 This method is only required if you NEED quotes WITHIN your argument (some old Microsoft Tools).
 "raw" methods are not compatible with non-raw methods.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendRawEscaped (static)

**Signature:** `Fake.Core.Arguments appendRawEscaped(System.String, System.String, Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Description:** Appends the given raw argument to the command line, you can not use other methods for this to work
 This allows unusal quoting with the given prefix, like /k:"myarg" ("/k:" would be the argPrefix)
 This method is only required if you NEED quotes WITHIN your argument (some old Microsoft Tools).
 "raw" methods are not compatible with non-raw methods.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `argPrefix` | `String` | No | `` |  |
| `paramValue` | `String` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendRawEscapedIf (static)

**Signature:** `Fake.Core.Arguments appendRawEscapedIf(Boolean, System.String, System.String, Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Description:** Append an argument prefixed by another if the value is Some.
 This method is only required if you NEED quotes WITHIN your argument (some old Microsoft Tools).
 "raw" methods are not compatible with non-raw methods.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `b` | `Boolean` | No | `` |  |
| `argPrefix` | `String` | No | `` |  |
| `paramValue` | `String` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendRawEscapedOption (static)

**Signature:** `Fake.Core.Arguments appendRawEscapedOption(System.String, Microsoft.FSharp.Core.FSharpOption`1[System.String], Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `argPrefix` | `String` | No | `` |  |
| `paramValue` | `FSharpOption`1` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendRawEscapedNotEmpty (static)

**Signature:** `Fake.Core.Arguments appendRawEscapedNotEmpty(System.String, System.String, Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Description:** Append an argument prefixed by another if the value is Some.
 This method is only required if you NEED quotes WITHIN your argument (some old Microsoft Tools).
 "raw" methods are not compatible with non-raw methods.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `argPrefix` | `String` | No | `` |  |
| `paramValue` | `String` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendOption (static)

**Signature:** `Fake.Core.Arguments appendOption(System.String, Microsoft.FSharp.Core.FSharpOption`1[System.String], Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `paramName` | `String` | No | `` |  |
| `paramValue` | `FSharpOption`1` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendIf (static)

**Signature:** `Fake.Core.Arguments appendIf(Boolean, System.String, Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Description:** Append an argument to a command line if a condition is true.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |
| `paramName` | `String` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### appendNotEmpty (static)

**Signature:** `Fake.Core.Arguments appendNotEmpty(System.String, System.String, Fake.Core.Arguments)`
**Return Type:** `Arguments`

**Description:** Append an argument prefixed by another if the value is not null or empty

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `paramName` | `String` | No | `` |  |
| `paramValue` | `String` | No | `` |  |
| `a` | `Arguments` | No | `` |  |

---

### toList (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] toList(Fake.Core.Arguments)`
**Return Type:** `FSharpList`1`

**Description:** Convert the arguments instance to a string list

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `Arguments` | No | `` |  |

---

### toArray (static)

**Signature:** `System.String[] toArray(Fake.Core.Arguments)`
**Return Type:** `String[]`

**Description:** Convert the arguments instance to a string array

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `Arguments` | No | `` |  |

---

### ofList (static)

**Signature:** `Fake.Core.Arguments ofList(Microsoft.FSharp.Collections.FSharpList`1[System.String])`
**Return Type:** `Arguments`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `a` | `FSharpList`1` | No | `` |  |

---