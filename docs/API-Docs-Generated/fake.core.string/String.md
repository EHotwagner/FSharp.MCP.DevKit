# String Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.String`

Contains basic functions for string manipulation.

## Methods

### productName (static)

**Signature:** `System.String productName()`
**Return Type:** `String`

**Description:** [omit]

---

### isNullOrEmpty (static)

**Signature:** `Boolean isNullOrEmpty(System.String)`
**Return Type:** `Boolean`

**Description:** Returns if the string is null or empty

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### isNotNullOrEmpty (static)

**Signature:** `Boolean isNotNullOrEmpty(System.String)`
**Return Type:** `Boolean`

**Description:** Returns if the string is not null or empty

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### isNullOrWhiteSpace (static)

**Signature:** `Boolean isNullOrWhiteSpace(System.String)`
**Return Type:** `Boolean`

**Description:** Returns if the string is null or empty or completely whitespace

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### replace (static)

**Signature:** `System.String replace(System.String, System.String, System.String)`
**Return Type:** `String`

**Description:** Replaces the given pattern in the given text with the replacement

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |
| `replacement` | `String` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### separated (static)

**Signature:** `System.String separated(System.String, System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `delimiter` | `String` | No | `` |  |
| `items` | `IEnumerable`1` | No | `` |  |

---

### trimSlash (static)

**Signature:** `System.String trimSlash(System.String)`
**Return Type:** `String`

**Description:** Removes the slashes from the end of the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### split (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] split(Char, System.String)`
**Return Type:** `FSharpList`1`

**Description:** Splits the given string at the given char delimiter

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `delimiter` | `Char` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### splitStr (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.String] splitStr(System.String, System.String)`
**Return Type:** `FSharpList`1`

**Description:** Splits the given string at the given string delimiter

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `delimiterStr` | `String` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### toLines (static)

**Signature:** `System.String toLines(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `IEnumerable`1` | No | `` |  |

---

### startsWith (static)

**Signature:** `Boolean startsWith(System.String, System.String)`
**Return Type:** `Boolean`

**Description:** Checks whether the given text starts with the given prefix

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `prefix` | `String` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### endsWith (static)

**Signature:** `Boolean endsWith(System.String, System.String)`
**Return Type:** `Boolean`

**Description:** Checks whether the given text ends with the given suffix

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `suffix` | `String` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### get_endsWithSlash (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,System.Boolean] get_endsWithSlash()`
**Return Type:** `FSharpFunc`2`

---

### replaceFirst (static)

**Signature:** `System.String replaceFirst(System.String, System.String, System.String)`
**Return Type:** `String`

**Description:** Replaces the first occurrence of the pattern with the given replacement.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |
| `replacement` | `String` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### getRegEx (static)

**Signature:** `System.Text.RegularExpressions.Regex getRegEx(System.String)`
**Return Type:** `Regex`

**Description:** [omit]

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |

---

### regex_replace (static)

**Signature:** `System.String regex_replace(System.String, System.String, System.String)`
**Return Type:** `String`

**Description:** [omit]

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |
| `replacement` | `String` | No | `` |  |
| `text` | `String` | No | `` |  |

---

### isUmlaut (static)

**Signature:** `Boolean isUmlaut(Char)`
**Return Type:** `Boolean`

**Description:** Checks whether the given char is a german umlaut.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### toLower (static)

**Signature:** `System.String toLower(System.String)`
**Return Type:** `String`

**Description:** Converts all characters in a string to lower case.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### get_charsAndDigits (static)

**Signature:** `Microsoft.FSharp.Collections.FSharpList`1[System.Char] get_charsAndDigits()`
**Return Type:** `FSharpList`1`

---

### isLetterOrDigit (static)

**Signature:** `Boolean isLetterOrDigit(Char)`
**Return Type:** `Boolean`

**Description:** Checks whether the given char is a standard char or digit.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### trimSeparator (static)

**Signature:** `System.String trimSeparator(System.String)`
**Return Type:** `String`

**Description:** Trims the given string with the DirectorySeparatorChar

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### trimSpecialChars (static)

**Signature:** `System.String trimSpecialChars(System.String)`
**Return Type:** `String`

**Description:** Trims all special characters from a string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |

---

### trim (static)

**Signature:** `System.String trim(System.String)`
**Return Type:** `String`

**Description:** Trims the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |

---

### trimChars (static)

**Signature:** `System.String trimChars(Char[], System.String)`
**Return Type:** `String`

**Description:** Trims the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `Char[]` | No | `` |  |
| `x` | `String` | No | `` |  |

---

### trimStartChars (static)

**Signature:** `System.String trimStartChars(Char[], System.String)`
**Return Type:** `String`

**Description:** Trims the start of the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `Char[]` | No | `` |  |
| `x` | `String` | No | `` |  |

---

### trimEndChars (static)

**Signature:** `System.String trimEndChars(Char[], System.String)`
**Return Type:** `String`

**Description:** Trims the end of the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `Char[]` | No | `` |  |
| `x` | `String` | No | `` |  |

---

### liftString (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] liftString(System.String)`
**Return Type:** `FSharpOption`1`

**Description:** Lifts a string to an option

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` |  |

---

### NormalizeVersion (static)

**Signature:** `System.String NormalizeVersion(System.String)`
**Return Type:** `String`

**Description:** Removes all trailing .0 from a version string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `version` | `String` | No | `` |  |

---

### get_Colon (static)

**Signature:** `Char get_Colon()`
**Return Type:** `Char`

---

### get_LinuxLineBreaks (static)

**Signature:** `System.String get_LinuxLineBreaks()`
**Return Type:** `String`

---

### get_WindowsLineBreaks (static)

**Signature:** `System.String get_WindowsLineBreaks()`
**Return Type:** `String`

---

### get_MacLineBreaks (static)

**Signature:** `System.String get_MacLineBreaks()`
**Return Type:** `String`

---

### convertTextToWindowsLineBreaks (static)

**Signature:** `System.String convertTextToWindowsLineBreaks(System.String)`
**Return Type:** `String`

**Description:** Converts all line breaks in a text to windows line breaks

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |

---

### convertFileToWindowsLineBreaksWithEncoding (static)

**Signature:** `Void convertFileToWindowsLineBreaksWithEncoding(System.Text.Encoding, System.String)`
**Return Type:** `Void`

**Description:** Reads a file line by line and replaces all line breaks to windows line breaks
 uses a temp file to store the contents in order to prevent OutOfMemory exceptions

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `encoding` | `Encoding` | No | `` |  |
| `fileName` | `String` | No | `` |  |

---

### convertFileToWindowsLineBreak (static)

**Signature:** `Void convertFileToWindowsLineBreak(System.Text.Encoding, System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `_arg1` | `Encoding` | No | `` |  |
| `fileName` | `String` | No | `` |  |

---

### removeLineBreaks (static)

**Signature:** `System.String removeLineBreaks(System.String)`
**Return Type:** `String`

**Description:** Removes linebreaks from the given string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |

---

### encapsulateApostrophe (static)

**Signature:** `System.String encapsulateApostrophe(System.String)`
**Return Type:** `String`

**Description:** Encapsulates the Apostrophe

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |

---

### decodeBase64Utf8String (static)

**Signature:** `System.String decodeBase64Utf8String(System.String)`
**Return Type:** `String`

**Description:** Decodes a Base64-encoded UTF-8-encoded string

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `text` | `String` | No | `` |  |

---

## Properties

### endsWithSlash (static)

**Type:** `FSharpFunc`2` (read-only)

**Description:** Determines whether the last character of the given 
 matches Path.DirectorySeparatorChar.

---

### charsAndDigits (static)

**Type:** `FSharpList`1` (read-only)

**Description:** Returns all standard chars and digits.

---

### Colon (static)

**Type:** `Char` (read-only)

**Description:** The colon character

---

### LinuxLineBreaks (static)

**Type:** `String` (read-only)

**Description:** Represents Linux line breaks

---

### WindowsLineBreaks (static)

**Type:** `String` (read-only)

**Description:** Represents Windows line breaks

---

### MacLineBreaks (static)

**Type:** `String` (read-only)

**Description:** Represents Mac line breaks

---