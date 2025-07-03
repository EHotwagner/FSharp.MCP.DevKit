# PrintPublisherOptions Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.PrintPublisherOptions`

## Methods

### get_EnableLog

**Signature:** `Boolean get_EnableLog()`
**Return Type:** `Boolean`

---

### get_LogLabel

**Signature:** `System.String get_LogLabel()`
**Return Type:** `String`

---

### get_MessageSizeLimit

**Signature:** `Int32 get_MessageSizeLimit()`
**Return Type:** `Int32`

---

### get_MinDurationMicroseconds

**Signature:** `Int32 get_MinDurationMicroseconds()`
**Return Type:** `Int32`

---

### get_SendLog

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.String,Microsoft.FSharp.Core.Unit] get_SendLog()`
**Return Type:** `FSharpFunc`2`

---

### get_SendTiming

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Garnet.Composition.Timing,Microsoft.FSharp.Core.Unit] get_SendTiming()`
**Return Type:** `FSharpFunc`2`

---

### get_CanSendLog

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Type,System.Boolean] get_CanSendLog()`
**Return Type:** `FSharpFunc`2`

---

### get_CanSendTiming

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[System.Type,System.Boolean] get_CanSendTiming()`
**Return Type:** `FSharpFunc`2`

---

### get_BasePublisher

**Signature:** `Garnet.Composition.IPublisher get_BasePublisher()`
**Return Type:** `IPublisher`

---

### get_Formatter

**Signature:** `Garnet.Composition.IFormatter get_Formatter()`
**Return Type:** `IFormatter`

---

### ToString

**Signature:** `System.String ToString()`
**Return Type:** `String`

---

## Properties

### EnableLog

**Type:** `Boolean` (read-only)

---

### LogLabel

**Type:** `String` (read-only)

---

### MessageSizeLimit

**Type:** `Int32` (read-only)

---

### MinDurationMicroseconds

**Type:** `Int32` (read-only)

---

### SendLog

**Type:** `FSharpFunc`2` (read-only)

---

### SendTiming

**Type:** `FSharpFunc`2` (read-only)

---

### CanSendLog

**Type:** `FSharpFunc`2` (read-only)

---

### CanSendTiming

**Type:** `FSharpFunc`2` (read-only)

---

### BasePublisher

**Type:** `IPublisher` (read-only)

---

### Formatter

**Type:** `IFormatter` (read-only)

---