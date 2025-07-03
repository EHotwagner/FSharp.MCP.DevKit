# CreateProcess`1 Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.CreateProcess`1`
- **Generic Parameters:** `<TRes>`

Handle for creating a process and returning potential results.

## Methods

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

### get_CommandLine

**Signature:** `System.String get_CommandLine()`
**Return Type:** `String`

---

### get_Command

**Signature:** `Fake.Core.Command get_Command()`
**Return Type:** `Command`

---

### get_WorkingDirectory

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] get_WorkingDirectory()`
**Return Type:** `FSharpOption`1`

---

### get_Environment

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Collections.Immutable.IImmutableDictionary`2[System.String,System.String]] get_Environment()`
**Return Type:** `FSharpOption`1`

---

## Properties

### CommandLine

**Type:** `String` (read-only)

---

### Command

**Type:** `Command` (read-only)

---

### WorkingDirectory

**Type:** `FSharpOption`1` (read-only)

---

### Environment

**Type:** `FSharpOption`1` (read-only)

---