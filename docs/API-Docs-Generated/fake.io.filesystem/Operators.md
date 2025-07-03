# Operators Class

**Namespace:** `Fake.IO.Globbing`
**Full Name:** `Fake.IO.Globbing.Operators`

Contains operators to find and process files.
 This module is part of the Fake.IO.FileSystem package

## Methods

### op_PlusPlus (static)

**Signature:** `Fake.IO.IGlobbingPattern op_PlusPlus(Fake.IO.IGlobbingPattern, System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Add Include operator

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `IGlobbingPattern` | No | `` | The pattern to include |
| `pattern` | `String` | No | `` |  |

---

### op_MinusMinus (static)

**Signature:** `Fake.IO.IGlobbingPattern op_MinusMinus(Fake.IO.IGlobbingPattern, System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Exclude operator

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `IGlobbingPattern` | No | `` | The pattern to include |
| `pattern` | `String` | No | `` |  |

---

### op_BangBang (static)

**Signature:** `Fake.IO.IGlobbingPattern op_BangBang(System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Includes a single pattern and scans the files - !! x = AllFilesMatching x

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `x` | `String` | No | `` | The pattern to create globbing from |

---