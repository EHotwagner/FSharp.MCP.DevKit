# CharStream Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.CharStream`
- **Implements:** `System.IDisposable`

Provides read‐access to a sequence of UTF‐16 chars.

## Methods

### get_BlockOverlap

**Signature:** `Int32 get_BlockOverlap()`
**Return Type:** `Int32`

---

### get_MinRegexSpace

**Signature:** `Int32 get_MinRegexSpace()`
**Return Type:** `Int32`

---

### set_MinRegexSpace

**Signature:** `Void set_MinRegexSpace(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` |  |

---

### get_IndexOfFirstChar

**Signature:** `Int64 get_IndexOfFirstChar()`
**Return Type:** `Int64`

---

### get_IndexOfLastCharPlus1

**Signature:** `Int64 get_IndexOfLastCharPlus1()`
**Return Type:** `Int64`

---

### get_Index

**Signature:** `Int64 get_Index()`
**Return Type:** `Int64`

---

### get_IsBeginOfStream

**Signature:** `Boolean get_IsBeginOfStream()`
**Return Type:** `Boolean`

---

### get_IsEndOfStream

**Signature:** `Boolean get_IsEndOfStream()`
**Return Type:** `Boolean`

---

### get_Line

**Signature:** `Int64 get_Line()`
**Return Type:** `Int64`

---

### SetLine_WithoutCheckAndWithoutIncrementingTheStateTag

**Signature:** `Void SetLine_WithoutCheckAndWithoutIncrementingTheStateTag(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `line` | `Int64` | No | `` |  |

---

### get_LineBegin

**Signature:** `Int64 get_LineBegin()`
**Return Type:** `Int64`

---

### SetLineBegin_WithoutCheckAndWithoutIncrementingTheStateTag

**Signature:** `Void SetLineBegin_WithoutCheckAndWithoutIncrementingTheStateTag(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lineBegin` | `Int64` | No | `` |  |

---

### get_Column

**Signature:** `Int64 get_Column()`
**Return Type:** `Int64`

---

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### set_Name

**Signature:** `Void set_Name(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_Encoding

**Signature:** `System.Text.Encoding get_Encoding()`
**Return Type:** `Encoding`

---

### get_Position

**Signature:** `FParsec.Position get_Position()`
**Return Type:** `Position`

---

### Dispose

**Signature:** `Void Dispose()`
**Return Type:** `Void`

**Description:** The low trust version of the CharStream class implements the IDisposable
            interface only for API compatibility. The Dispose method does not need to be called on
            low trust CharStream instances, because the instances hold no resources that need to be disposed.

---

### ParseString (static) (generic)

**Signature:** `T ParseString[T,TUserState](System.String, Int32, Int32, Microsoft.FSharp.Core.FSharpFunc`2[FParsec.CharStream`1[TUserState],T], TUserState, System.String)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `String` | No | `` |  |
| `index` | `Int32` | No | `` |  |
| `length` | `Int32` | No | `` |  |
| `parser` | `FSharpFunc`2` | No | `` |  |
| `userState` | `TUserState` | No | `` |  |
| `streamName` | `String` | No | `` |  |

---

### Seek

**Signature:** `Void Seek(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int64` | No | `` |  |

---

### get_IndexToken

**Signature:** `FParsec.CharStreamIndexToken get_IndexToken()`
**Return Type:** `CharStreamIndexToken`

---

### Seek

**Signature:** `Void Seek(FParsec.CharStreamIndexToken)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `indexToken` | `CharStreamIndexToken` | No | `` |  |

---

### ReadFrom

**Signature:** `System.String ReadFrom(FParsec.CharStreamIndexToken)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `indexToken` | `CharStreamIndexToken` | No | `` |  |

---

### RegisterNewline

**Signature:** `Void RegisterNewline()`
**Return Type:** `Void`

---

### RegisterNewlines

**Signature:** `Void RegisterNewlines(Int32, Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lineOffset` | `Int32` | No | `` |  |
| `newColumnMinus1` | `Int32` | No | `` |  |

---

### RegisterNewlines

**Signature:** `Void RegisterNewlines(Int64, Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `lineOffset` | `Int64` | No | `` |  |
| `newColumnMinus1` | `Int64` | No | `` |  |

---

### Peek

**Signature:** `Char Peek()`
**Return Type:** `Char`

---

### Skip

**Signature:** `Void Skip()`
**Return Type:** `Void`

---

### Read

**Signature:** `Char Read()`
**Return Type:** `Char`

---

### SkipAndPeek

**Signature:** `Char SkipAndPeek()`
**Return Type:** `Char`

---

### Peek2

**Signature:** `FParsec.TwoChars Peek2()`
**Return Type:** `TwoChars`

---

### Peek

**Signature:** `Char Peek(UInt32)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `UInt32` | No | `` |  |

---

### Skip

**Signature:** `Void Skip(UInt32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `UInt32` | No | `` |  |

---

### SkipAndPeek

**Signature:** `Char SkipAndPeek(UInt32)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `UInt32` | No | `` |  |

---

### Peek

**Signature:** `Char Peek(Int32)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `Int32` | No | `` |  |

---

### Skip

**Signature:** `Void Skip(Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `Int32` | No | `` |  |

---

### Skip

**Signature:** `Void Skip(Int64)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `Int64` | No | `` |  |

---

### SkipAndPeek

**Signature:** `Char SkipAndPeek(Int32)`
**Return Type:** `Char`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `utf16Offset` | `Int32` | No | `` |  |

---

### PeekString

**Signature:** `System.String PeekString(Int32)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length` | `Int32` | No | `` |  |

---

### Read

**Signature:** `System.String Read(Int32)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `length` | `Int32` | No | `` |  |

---

### PeekString

**Signature:** `Int32 PeekString(Char[], Int32, Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `buffer` | `Char[]` | No | `` |  |
| `bufferIndex` | `Int32` | No | `` |  |
| `length` | `Int32` | No | `` |  |

---

### Read

**Signature:** `Int32 Read(Char[], Int32, Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `buffer` | `Char[]` | No | `` |  |
| `bufferIndex` | `Int32` | No | `` |  |
| `length` | `Int32` | No | `` |  |

---

### Match

**Signature:** `Boolean Match(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---

### MatchCaseFolded

**Signature:** `Boolean MatchCaseFolded(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `caseFoldedChar` | `Char` | No | `` |  |

---

### Skip

**Signature:** `Boolean Skip(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ch` | `Char` | No | `` |  |

---

### SkipCaseFolded

**Signature:** `Boolean SkipCaseFolded(Char)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `caseFoldedChar` | `Char` | No | `` |  |

---

### Skip

**Signature:** `Boolean Skip(FParsec.TwoChars)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `twoChars` | `TwoChars` | No | `` |  |

---

### Match

**Signature:** `Boolean Match(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `String` | No | `` |  |

---

### Skip

**Signature:** `Boolean Skip(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `String` | No | `` |  |

---

### MatchCaseFolded

**Signature:** `Boolean MatchCaseFolded(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `caseFoldedChars` | `String` | No | `` |  |

---

### SkipCaseFolded

**Signature:** `Boolean SkipCaseFolded(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `caseFoldedChars` | `String` | No | `` |  |

---

### Match

**Signature:** `Boolean Match(Char[], Int32, Int32)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `Char[]` | No | `` |  |
| `charsIndex` | `Int32` | No | `` |  |
| `length` | `Int32` | No | `` |  |

---

### Skip

**Signature:** `Boolean Skip(Char[], Int32, Int32)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `chars` | `Char[]` | No | `` |  |
| `charsIndex` | `Int32` | No | `` |  |
| `length` | `Int32` | No | `` |  |

---

### Match

**Signature:** `System.Text.RegularExpressions.Match Match(System.Text.RegularExpressions.Regex)`
**Return Type:** `Match`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `regex` | `Regex` | No | `` |  |

---

### SkipWhitespace

**Signature:** `Boolean SkipWhitespace()`
**Return Type:** `Boolean`

---

### SkipUnicodeWhitespace

**Signature:** `Boolean SkipUnicodeWhitespace()`
**Return Type:** `Boolean`

---

### SkipNewline

**Signature:** `Boolean SkipNewline()`
**Return Type:** `Boolean`

---

### SkipUnicodeNewline

**Signature:** `Boolean SkipUnicodeNewline()`
**Return Type:** `Boolean`

---

### SkipNewlineThenWhitespace

**Signature:** `Int32 SkipNewlineThenWhitespace(Int32, Boolean)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `powerOf2TabStopDistance` | `Int32` | No | `` |  |
| `allowFormFeed` | `Boolean` | No | `` |  |

---

### SkipRestOfLine

**Signature:** `Void SkipRestOfLine(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skipNewline` | `Boolean` | No | `` |  |

---

### ReadRestOfLine

**Signature:** `System.String ReadRestOfLine(Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `skipNewline` | `Boolean` | No | `` |  |

---

### ReadCharOrNewline

**Signature:** `Char ReadCharOrNewline()`
**Return Type:** `Char`

---

### SkipCharsOrNewlines

**Signature:** `Int32 SkipCharsOrNewlines(Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `maxCharsOrNewlines` | `Int32` | No | `` |  |

---

### ReadCharsOrNewlines

**Signature:** `System.String ReadCharsOrNewlines(Int32, Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `normalizeNewlinesInReturnString` | `Boolean` | No | `` |  |

---

### SkipCharsOrNewlinesWhile

**Signature:** `Int32 SkipCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |

---

### SkipCharsOrNewlinesWhile

**Signature:** `Int32 SkipCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean])`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |

---

### ReadCharsOrNewlinesWhile

**Signature:** `System.String ReadCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `normalizeNewlines` | `Boolean` | No | `` |  |

---

### ReadCharsOrNewlinesWhile

**Signature:** `System.String ReadCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `normalizeNewlinesInReturnString` | `Boolean` | No | `` |  |

---

### SkipCharsOrNewlinesWhile

**Signature:** `Int32 SkipCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Int32, Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `minCharsOrNewlines` | `Int32` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |

---

### SkipCharsOrNewlinesWhile

**Signature:** `Int32 SkipCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Int32, Int32)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `minCharsOrNewlines` | `Int32` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |

---

### ReadCharsOrNewlinesWhile

**Signature:** `System.String ReadCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Int32, Int32, Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f` | `FSharpFunc`2` | No | `` |  |
| `minCharsOrNewlines` | `Int32` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `normalizeNewlinesInReturnString` | `Boolean` | No | `` |  |

---

### ReadCharsOrNewlinesWhile

**Signature:** `System.String ReadCharsOrNewlinesWhile(Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Microsoft.FSharp.Core.FSharpFunc`2[System.Char,System.Boolean], Int32, Int32, Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `f1` | `FSharpFunc`2` | No | `` |  |
| `f` | `FSharpFunc`2` | No | `` |  |
| `minCharsOrNewlines` | `Int32` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `normalizeNewlinesInReturnString` | `Boolean` | No | `` |  |

---

### SkipCharsOrNewlinesUntilString

**Signature:** `Int32 SkipCharsOrNewlinesUntilString(System.String, Int32, Boolean ByRef)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `foundString` | `Boolean&` | No | `` |  |

---

### SkipCharsOrNewlinesUntilString

**Signature:** `Int32 SkipCharsOrNewlinesUntilString(System.String, Int32, Boolean, System.String ByRef)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `normalizeNewlinesInOutString` | `Boolean` | No | `` |  |
| `skippedCharsIfStringFoundOtherwiseNull` | `String&` | No | `` |  |

---

### SkipCharsOrNewlinesUntilCaseFoldedString

**Signature:** `Int32 SkipCharsOrNewlinesUntilCaseFoldedString(System.String, Int32, Boolean ByRef)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `caseFoldedString` | `String` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `foundString` | `Boolean&` | No | `` |  |

---

### SkipCharsOrNewlinesUntilCaseFoldedString

**Signature:** `Int32 SkipCharsOrNewlinesUntilCaseFoldedString(System.String, Int32, Boolean, System.String ByRef)`
**Return Type:** `Int32`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `caseFoldedString` | `String` | No | `` |  |
| `maxCharsOrNewlines` | `Int32` | No | `` |  |
| `normalizeNewlinesInOutString` | `Boolean` | No | `` |  |
| `skippedCharsIfStringFoundOtherwiseNull` | `String&` | No | `` |  |

---

## Properties

### BlockOverlap

**Type:** `Int32` (read-only)

---

### MinRegexSpace

**Type:** `Int32` (read/write)

---

### IndexOfFirstChar

**Type:** `Int64` (read-only)

---

### IndexOfLastCharPlus1

**Type:** `Int64` (read-only)

---

### Index

**Type:** `Int64` (read-only)

---

### IsBeginOfStream

**Type:** `Boolean` (read-only)

**Description:** Indicates whether the Iterator points to the beginning of the CharStream.
            If the CharStream is empty, this property is always true.

---

### IsEndOfStream

**Type:** `Boolean` (read-only)

**Description:** Indicates whether the Iterator points to the end of the CharStream,
            i.e. whether it points to one char beyond the last char in the CharStream.

---

### Line

**Type:** `Int64` (read-only)

---

### LineBegin

**Type:** `Int64` (read-only)

---

### Column

**Type:** `Int64` (read-only)

**Description:** The UTF‐16 column number of the next char, i.e. Index ‐ LineBegin  + 1.

---

### Name

**Type:** `String` (read/write)

---

### Encoding

**Type:** `Encoding` (read/write)

---

### Position

**Type:** `Position` (read-only)

---

### IndexToken

**Type:** `CharStreamIndexToken` (read-only)

---