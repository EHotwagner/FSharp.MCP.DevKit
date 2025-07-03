# CharParsers Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.CharParsers`

## Methods

### foldCase (static)

**Signature:** `System.String foldCase(System.String)`
**Return Type:** `String`

**Description:** `foldCase str` returns a case-folded version of `str`
 with all chars mappend using the (non-Turkic) Unicode 1-to-1 case folding mappings
 for chars below 0x10000. If the argument is `null`, `null` is returned.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg00` | `String` | No | `` |  |

---

### normalizeNewlines (static)

**Signature:** `System.String normalizeNewlines(System.String)`
**Return Type:** `String`

**Description:** `normalizeNewlines str` returns a version of `str`
 with all occurances of "\r\n" and "\r" replaced by "\n".
 If the argument is `null`, `null` is returned.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg00` | `String` | No | `` |  |

---

### floatToHexString (static)

**Signature:** `System.String floatToHexString(Double)`
**Return Type:** `String`

**Description:** Returns a hexadecimal string representation of the `float` argument.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg00` | `Double` | No | `` |  |

---

### floatOfHexString (static)

**Signature:** `Double floatOfHexString(System.String)`
**Return Type:** `Double`

**Description:** Returns the `float` value represented by the given string in hexadecimal format.
 Raises a `System.FormatException` in case the string representation is invalid.
 Raises a `System.OverflowException` if the (absolute) value is too large to be represented by a `float`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg00` | `String` | No | `` |  |

---

### float32ToHexString (static)

**Signature:** `System.String float32ToHexString(Single)`
**Return Type:** `String`

**Description:** Returns a hexadecimal string representation of the `float32` argument.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg00` | `Single` | No | `` |  |

---

### float32OfHexString (static)

**Signature:** `Single float32OfHexString(System.String)`
**Return Type:** `Single`

**Description:** Returns the `float32` value represented by the given string in hexadecimal format.
 Raises a `System.FormatException` in case the string representation is invalid.
 Raises a `System.OverflowException` if the (absolute) value is too large to be represented by a `float32`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `arg00` | `String` | No | `` |  |

---

### runParserOnString (static) (generic)

**Signature:** `ParserResult`2 runParserOnString[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], u, System.String, System.String)`
**Return Type:** `ParserResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parser` | `FSharpFunc`2` | No | `` |  |
| `ustate` | `u` | No | `` |  |
| `streamName` | `String` | No | `` |  |
| `chars` | `String` | No | `` |  |

---

### runParserOnSubstring (static) (generic)

**Signature:** `ParserResult`2 runParserOnSubstring[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], u, System.String, System.String, Int32, Int32)`
**Return Type:** `ParserResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parser` | `FSharpFunc`2` | No | `` |  |
| `ustate` | `u` | No | `` |  |
| `streamName` | `String` | No | `` |  |
| `chars` | `String` | No | `` |  |
| `index` | `Int32` | No | `` |  |
| `length` | `Int32` | No | `` |  |

---

### runParserOnStream (static) (generic)

**Signature:** `ParserResult`2 runParserOnStream[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], u, System.String, System.IO.Stream, System.Text.Encoding)`
**Return Type:** `ParserResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parser` | `FSharpFunc`2` | No | `` |  |
| `ustate` | `u` | No | `` |  |
| `streamName` | `String` | No | `` |  |
| `byteStream` | `Stream` | No | `` |  |
| `encoding` | `Encoding` | No | `` |  |

---

### runParserOnFile (static) (generic)

**Signature:** `ParserResult`2 runParserOnFile[a,u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]], u, System.String, System.Text.Encoding)`
**Return Type:** `ParserResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parser` | `FSharpFunc`2` | No | `` |  |
| `ustate` | `u` | No | `` |  |
| `path` | `String` | No | `` |  |
| `encoding` | `Encoding` | No | `` |  |

---

### run (static) (generic)

**Signature:** `ParserResult`2 run[Result](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[Microsoft.FSharp.Core.Unit],FParsec.Reply`1[Result]], System.String)`
**Return Type:** `ParserResult`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `parser` | `FSharpFunc`2` | No | `` |  |
| `string` | `String` | No | `` |  |

---

### getPosition (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[FParsec.Position]] getPosition[u]()`
**Return Type:** `FSharpFunc`2`

---

### getUserState (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[u]] getUserState[u]()`
**Return Type:** `FSharpFunc`2`

---

### setUserState (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] setUserState[u](u)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `newUserState` | `u` | No | `` |  |

---

### updateUserState (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] updateUserState[u](Microsoft.FSharp.Core.FSharpFunc`2[u,u])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### userStateSatisfies (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] userStateSatisfies[u](Microsoft.FSharp.Core.FSharpFunc`2[u,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### newlineReturn (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] newlineReturn[a,u](a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `a` | No | `` |  |

---

### newline (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] newline[u]()`
**Return Type:** `FSharpFunc`2`

---

### skipNewline (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipNewline[u]()`
**Return Type:** `FSharpFunc`2`

---

### unicodeNewlineReturn (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] unicodeNewlineReturn[a,u](a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `result` | `a` | No | `` |  |

---

### unicodeNewline (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] unicodeNewline[u]()`
**Return Type:** `FSharpFunc`2`

---

### skipUnicodeNewline (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipUnicodeNewline[u]()`
**Return Type:** `FSharpFunc`2`

---

### charReturn (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] charReturn[a,u](Char, a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |
| `result` | `a` | No | `` |  |

---

### pchar (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] pchar[u](Char)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### skipChar (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipChar[u](Char)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### anyChar (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] anyChar[u]()`
**Return Type:** `FSharpFunc`2`

---

### skipAnyChar (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipAnyChar[u]()`
**Return Type:** `FSharpFunc`2`

---

### satisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] satisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### satisfyL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] satisfyL[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### skipSatisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipSatisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipSatisfyL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipSatisfyL[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### isAnyOf (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean] isAnyOf(System.Collections.Generic.IEnumerable`1[System.Char])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `IEnumerable`1` | No | `` |  |

---

### isNoneOf (static)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean] isNoneOf(System.Collections.Generic.IEnumerable`1[System.Char])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `IEnumerable`1` | No | `` |  |

---

### anyOf (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] anyOf[u](System.Collections.Generic.IEnumerable`1[System.Char])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `IEnumerable`1` | No | `` |  |

---

### skipAnyOf (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipAnyOf[u](System.Collections.Generic.IEnumerable`1[System.Char])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `IEnumerable`1` | No | `` |  |

---

### noneOf (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] noneOf[u](System.Collections.Generic.IEnumerable`1[System.Char])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `IEnumerable`1` | No | `` |  |

---

### skipNoneOf (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipNoneOf[u](System.Collections.Generic.IEnumerable`1[System.Char])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `IEnumerable`1` | No | `` |  |

---

### isAsciiUpper (static)

**Signature:** `Boolean isAsciiUpper(Char)`
**Return Type:** `Boolean`

**Description:** Returns `true` for any char in the range 'A' - 'Z' and `false` for all other chars.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isAsciiLower (static)

**Signature:** `Boolean isAsciiLower(Char)`
**Return Type:** `Boolean`

**Description:** Returns `true` for any char in the range 'a' - 'z' and `false` for all other chars.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isAsciiLetter (static)

**Signature:** `Boolean isAsciiLetter(Char)`
**Return Type:** `Boolean`

**Description:** Returns `true` for any char in the range 'a' - 'z', 'A' - 'Z' and `false` for all other chars.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isUpper (static)

**Signature:** `Boolean isUpper(Char)`
**Return Type:** `Boolean`

**Description:** `isUpper` is equivalent to `System.Char.IsUpper`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isLower (static)

**Signature:** `Boolean isLower(Char)`
**Return Type:** `Boolean`

**Description:** `isLower` is equivalent to `System.Char.IsLower`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isLetter (static)

**Signature:** `Boolean isLetter(Char)`
**Return Type:** `Boolean`

**Description:** `isLetter` is equivalent to `System.Char.IsLetter`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isDigit (static)

**Signature:** `Boolean isDigit(Char)`
**Return Type:** `Boolean`

**Description:** Returns `true` for any char in the range '0' - '9' and `false` for all other chars.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isHex (static)

**Signature:** `Boolean isHex(Char)`
**Return Type:** `Boolean`

**Description:** Returns `true` for any char in the range '0' - '9', 'a' - 'f', 'A' - 'F' and `false` for all other chars.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### isOctal (static)

**Signature:** `Boolean isOctal(Char)`
**Return Type:** `Boolean`

**Description:** Returns `true` for any char in the range '0' - '7' and `false` for all other chars.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Char` | No | `` |  |

---

### asciiUpper (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] asciiUpper[u]()`
**Return Type:** `FSharpFunc`2`

---

### asciiLower (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] asciiLower[u]()`
**Return Type:** `FSharpFunc`2`

---

### asciiLetter (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] asciiLetter[u]()`
**Return Type:** `FSharpFunc`2`

---

### upper (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] upper[u]()`
**Return Type:** `FSharpFunc`2`

---

### lower (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] lower[u]()`
**Return Type:** `FSharpFunc`2`

---

### letter (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] letter[u]()`
**Return Type:** `FSharpFunc`2`

---

### digit (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] digit[u]()`
**Return Type:** `FSharpFunc`2`

---

### hex (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] hex[u]()`
**Return Type:** `FSharpFunc`2`

---

### octal (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] octal[u]()`
**Return Type:** `FSharpFunc`2`

---

### tab (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]] tab[u]()`
**Return Type:** `FSharpFunc`2`

---

### spaces (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] spaces[u]()`
**Return Type:** `FSharpFunc`2`

---

### spaces1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] spaces1[u]()`
**Return Type:** `FSharpFunc`2`

---

### unicodeSpaces (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] unicodeSpaces[u]()`
**Return Type:** `FSharpFunc`2`

---

### unicodeSpaces1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] unicodeSpaces1[u]()`
**Return Type:** `FSharpFunc`2`

---

### eof (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] eof[u]()`
**Return Type:** `FSharpFunc`2`

---

### stringReturn (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] stringReturn[a,u](System.String, a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `result` | `a` | No | `` |  |

---

### pstring (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] pstring[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### skipString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipString[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### pstringCI (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] pstringCI[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### stringCIReturn (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]] stringCIReturn[a,u](System.String, a)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `result` | `a` | No | `` |  |

---

### skipStringCI (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipStringCI[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |

---

### anyString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] anyString[u](Int32)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `n` | `Int32` | No | `` |  |

---

### skipAnyString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipAnyString[u](Int32)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `n` | `Int32` | No | `` |  |

---

### restOfLine (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] restOfLine[u](Boolean)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skipNewline` | `Boolean` | No | `` |  |

---

### skipRestOfLine (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipRestOfLine[u](Boolean)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skipNewline` | `Boolean` | No | `` |  |

---

### charsTillString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] charsTillString[u](System.String, Boolean, Int32)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `skipString` | `Boolean` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |

---

### charsTillStringCI (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] charsTillStringCI[u](System.String, Boolean, Int32)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `skipString` | `Boolean` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |

---

### skipCharsTillString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipCharsTillString[u](System.String, Boolean, Int32)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `skipString` | `Boolean` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |

---

### skipCharsTillStringCI (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipCharsTillStringCI[u](System.String, Boolean, Int32)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `s` | `String` | No | `` |  |
| `skipString` | `Boolean` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |

---

### manySatisfy2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manySatisfy2[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### many1Satisfy2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Satisfy2[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### many1Satisfy2L (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Satisfy2L[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### skipManySatisfy2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManySatisfy2[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipMany1Satisfy2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany1Satisfy2[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipMany1Satisfy2L (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany1Satisfy2L[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### manySatisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manySatisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### many1Satisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Satisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### many1SatisfyL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1SatisfyL[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### skipManySatisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManySatisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipMany1Satisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany1Satisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipMany1SatisfyL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipMany1SatisfyL[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### manyMinMaxSatisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyMinMaxSatisfy[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### manyMinMaxSatisfyL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyMinMaxSatisfyL[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### manyMinMaxSatisfy2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyMinMaxSatisfy2[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### manyMinMaxSatisfy2L (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyMinMaxSatisfy2L[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### skipManyMinMaxSatisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManyMinMaxSatisfy[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipManyMinMaxSatisfyL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManyMinMaxSatisfyL[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### skipManyMinMaxSatisfy2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManyMinMaxSatisfy2[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### skipManyMinMaxSatisfy2L (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] skipManyMinMaxSatisfy2L[u](Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `minCount` | `Int32` | No | `` |  |
| `maxCount` | `Int32` | No | `` |  |
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### regex (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] regex[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |

---

### regexL (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] regexL[u](System.String, System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### identifier (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] identifier[u](IdentifierOptions)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `identifierOptions` | `IdentifierOptions` | No | `` |  |

---

### manyChars2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyChars2[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### manyChars (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyChars[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### many1Chars2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Chars2[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### many1Chars (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Chars[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### manyCharsTillApply2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]] manyCharsTillApply2[u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[b,c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### manyCharsTillApply (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]] manyCharsTillApply[u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[b,c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### manyCharsTill2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyCharsTill2[u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### manyCharsTill (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyCharsTill[u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### many1CharsTillApply2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]] many1CharsTillApply2[u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[b,c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### many1CharsTillApply (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[c]] many1CharsTillApply[u,b,c](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]], Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[b,c]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### many1CharsTill2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1CharsTill2[u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### many1CharsTill (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1CharsTill[u,b](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Char]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `endp` | `FSharpFunc`2` | No | `` |  |

---

### manyStrings2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyStrings2[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### manyStrings (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] manyStrings[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### many1Strings2 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Strings2[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p1` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### many1Strings (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] many1Strings[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### stringsSepBy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] stringsSepBy[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### stringsSepBy1 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] stringsSepBy1[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |
| `sep` | `FSharpFunc`2` | No | `` |  |

---

### skipped (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.String]] skipped[u](Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `p` | `FSharpFunc`2` | No | `` |  |

---

### withSkippedString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[b]] withSkippedString[a,b,u](Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.FSharpFunc`2[a,b]], Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[a]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `p` | `FSharpFunc`2` | No | `` |  |

---

### numberLiteralE (static) (generic)

**Signature:** `FParsec.Reply`1[FParsec.CharParsers+NumberLiteral] numberLiteralE[u](NumberLiteralOptions, FParsec.ErrorMessageList, FParsec.CharStream`1[u])`
**Return Type:** `Reply`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `opt` | `NumberLiteralOptions` | No | `` |  |
| `errorInCaseNoLiteralFound` | `ErrorMessageList` | No | `` |  |
| `stream` | `CharStream`1` | No | `` |  |

---

### numberLiteral (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[FParsec.CharParsers+NumberLiteral]] numberLiteral[u](NumberLiteralOptions, System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `opt` | `NumberLiteralOptions` | No | `` |  |
| `label` | `String` | No | `` |  |

---

### pfloat (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Double]] pfloat[u]()`
**Return Type:** `FSharpFunc`2`

---

### pint64 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Int64]] pint64[u]()`
**Return Type:** `FSharpFunc`2`

---

### pint32 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Int32]] pint32[u]()`
**Return Type:** `FSharpFunc`2`

---

### pint16 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Int16]] pint16[u]()`
**Return Type:** `FSharpFunc`2`

---

### pint8 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.SByte]] pint8[u]()`
**Return Type:** `FSharpFunc`2`

---

### puint64 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.UInt64]] puint64[u]()`
**Return Type:** `FSharpFunc`2`

---

### puint32 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.UInt32]] puint32[u]()`
**Return Type:** `FSharpFunc`2`

---

### puint16 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.UInt16]] puint16[u]()`
**Return Type:** `FSharpFunc`2`

---

### puint8 (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[System.Byte]] puint8[u]()`
**Return Type:** `FSharpFunc`2`

---

### notFollowedByEof (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] notFollowedByEof[u]()`
**Return Type:** `FSharpFunc`2`

---

### followedByNewline (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] followedByNewline[u]()`
**Return Type:** `FSharpFunc`2`

---

### notFollowedByNewline (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] notFollowedByNewline[u]()`
**Return Type:** `FSharpFunc`2`

---

### followedByString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] followedByString[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### followedByStringCI (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] followedByStringCI[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### notFollowedByString (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] notFollowedByString[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### notFollowedByStringCI (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] notFollowedByStringCI[u](System.String)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### previousCharSatisfies (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] previousCharSatisfies[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### previousCharSatisfiesNot (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] previousCharSatisfiesNot[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### nextCharSatisfies (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] nextCharSatisfies[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### nextCharSatisfiesNot (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] nextCharSatisfiesNot[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### next2CharsSatisfy (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] next2CharsSatisfy[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### next2CharsSatisfyNot (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[u],FParsec.Reply`1[Microsoft.FSharp.Core.Unit]] next2CharsSatisfyNot[u](Microsoft.FSharp.Core.FSharpFunc`2[System.Char,Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean]])`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---