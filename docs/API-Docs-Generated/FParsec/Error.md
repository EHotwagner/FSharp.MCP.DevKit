# Error Class

**Namespace:** `FParsec`
**Full Name:** `FParsec.Error`

## Methods

### |Expected|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |Expected|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |ExpectedString|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |ExpectedString|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |ExpectedStringCI|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |ExpectedStringCI|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |Unexpected|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |Unexpected|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |UnexpectedString|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |UnexpectedString|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |UnexpectedStringCI|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |UnexpectedStringCI|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |Message|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.String] |Message|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |NestedError|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`3[FParsec.Position,System.Object,FParsec.ErrorMessageList]] |NestedError|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |CompoundError|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Tuple`4[System.String,FParsec.Position,System.Object,FParsec.ErrorMessageList]] |CompoundError|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |OtherErrorMessage|_| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Object] |OtherErrorMessage|_|(FParsec.ErrorMessage)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `ErrorMessage` | No | `` |  |

---

### |ErrorMessageList|NoErrorMessages| (static)

**Signature:** `Microsoft.FSharp.Core.FSharpChoice`2[System.Tuple`2[FParsec.ErrorMessage,FParsec.ErrorMessageList],Microsoft.FSharp.Core.Unit] |ErrorMessageList|NoErrorMessages|(FParsec.ErrorMessageList)`
**Return Type:** `FSharpChoice`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `error` | `ErrorMessageList` | No | `` |  |

---

### isSingleErrorMessageOfType (static)

**Signature:** `Boolean isSingleErrorMessageOfType(FParsec.ErrorMessageType, FParsec.ErrorMessageList)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `ty` | `ErrorMessageType` | No | `` |  |
| `error` | `ErrorMessageList` | No | `` |  |

---

### expected (static)

**Signature:** `FParsec.ErrorMessageList expected(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `expectedError label` creates an `ErrorMessageList` with a single `Expected label` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `label` | `String` | No | `` |  |

---

### expectedString (static)

**Signature:** `FParsec.ErrorMessageList expectedString(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `expectedStringError str` creates an `ErrorMessageList` with a single `ExpectedString str` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### expectedStringCI (static)

**Signature:** `FParsec.ErrorMessageList expectedStringCI(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `expectedStringCIError str` creates an `ErrorMessageList` with a single `ExpectedStringCI str` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### unexpected (static)

**Signature:** `FParsec.ErrorMessageList unexpected(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `unexpectedError label` creates an `ErrorMessageList` with a single `Unexpected label` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `label` | `String` | No | `` |  |

---

### unexpectedString (static)

**Signature:** `FParsec.ErrorMessageList unexpectedString(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `unexpectedStringError str` creates an `ErrorMessageList` with a single `UnexpectedString str` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### unexpectedStringCI (static)

**Signature:** `FParsec.ErrorMessageList unexpectedStringCI(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `unexpectedStringCIError str` creates an `ErrorMessageList` with a single `UnexpectedStringCI str` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `str` | `String` | No | `` |  |

---

### messageError (static)

**Signature:** `FParsec.ErrorMessageList messageError(System.String)`
**Return Type:** `ErrorMessageList`

**Description:** `messageError msg` creates an `ErrorMessageList` with a single `Message msg` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `msg` | `String` | No | `` |  |

---

### otherError (static)

**Signature:** `FParsec.ErrorMessageList otherError(System.Object)`
**Return Type:** `ErrorMessageList`

**Description:** `otherError o` creates an `ErrorMessageList` with a single `OtherError o` message.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `obj` | `Object` | No | `` |  |

---

### nestedError (static) (generic)

**Signature:** `FParsec.ErrorMessageList nestedError[u](FParsec.CharStream`1[u], FParsec.ErrorMessageList)`
**Return Type:** `ErrorMessageList`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `stream` | `CharStream`1` | No | `` |  |
| `error` | `ErrorMessageList` | No | `` |  |

---

### compoundError (static) (generic)

**Signature:** `FParsec.ErrorMessageList compoundError[u](System.String, FParsec.CharStream`1[u], FParsec.ErrorMessageList)`
**Return Type:** `ErrorMessageList`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `label` | `String` | No | `` |  |
| `stream` | `CharStream`1` | No | `` |  |
| `error` | `ErrorMessageList` | No | `` |  |

---

### mergeErrors (static)

**Signature:** `FParsec.ErrorMessageList mergeErrors(FParsec.ErrorMessageList, FParsec.ErrorMessageList)`
**Return Type:** `ErrorMessageList`

**Description:** `mergeErrors error1 error2` is equivalent to `ErrorMessageList.Merge(error1, error2)`.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `errorMessages1` | `ErrorMessageList` | No | `` |  |
| `errorMessages2` | `ErrorMessageList` | No | `` |  |

---