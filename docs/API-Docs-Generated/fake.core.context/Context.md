# Context Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Context`

This module tracks the context of the build.
 
 This allows us to run some modules without any context and change behavior depending on the context
 (For example Fake.Process kills all processes when the Fake Context exists, but it should not when used
 as library)

## Methods

### getExecutionContext (static)

**Signature:** `RuntimeContext getExecutionContext()`
**Return Type:** `RuntimeContext`

**Description:** Gets FAKE execution context

---

### setExecutionContext (static)

**Signature:** `Void setExecutionContext(RuntimeContext)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `RuntimeContext` | No | `` |  |

---

### removeExecutionContext (static)

**Signature:** `Void removeExecutionContext()`
**Return Type:** `Void`

**Description:** Remove execution context

---

### getFakeExecutionContext (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[Fake.Core.Context+FakeExecutionContext] getFakeExecutionContext(RuntimeContext)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `e` | `RuntimeContext` | No | `` |  |

---

### getFakeContext (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Object] getFakeContext(System.String, FakeExecutionContext)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `f` | `FakeExecutionContext` | No | `` |  |

---

### removeFakeContext (static)

**Signature:** `Microsoft.FSharp.Core.FSharpOption`1[System.Object] removeFakeContext(System.String, FakeExecutionContext)`
**Return Type:** `FSharpOption`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `f` | `FakeExecutionContext` | No | `` |  |

---

### setFakeContext (static)

**Signature:** `System.Object setFakeContext(System.String, System.Object, Microsoft.FSharp.Core.FSharpFunc`2[System.Object,System.Object], FakeExecutionContext)`
**Return Type:** `Object`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `v` | `Object` | No | `` |  |
| `updateF` | `FSharpFunc`2` | No | `` |  |
| `f` | `FakeExecutionContext` | No | `` |  |

---

### isFakeContext (static)

**Signature:** `Boolean isFakeContext()`
**Return Type:** `Boolean`

**Description:** Check if execution context is a FAKE execution context

---

### forceFakeContext (static)

**Signature:** `FakeExecutionContext forceFakeContext()`
**Return Type:** `FakeExecutionContext`

**Description:** Check and current context is a FAKE execution context and throws `InvalidOperationException`
 exception when not

---

### setExecutionContextFromCommandLineArgs (static)

**Signature:** `Void setExecutionContextFromCommandLineArgs(System.String)`
**Return Type:** `Void`

**Description:** Creates and sets the FAKE execution context from command line arguments.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `scriptFile` | `String` | No | `` |  |

---