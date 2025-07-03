# GlobbingPatternExtensions Class

**Namespace:** `Fake.IO`
**Full Name:** `Fake.IO.GlobbingPatternExtensions`

Contains extensions for glob pattern module.

## Methods

### IGlobbingPattern.Resolve (static)

**Signature:** `Fake.IO.IGlobbingPattern IGlobbingPattern.Resolve(Fake.IO.IGlobbingPattern)`
**Return Type:** `IGlobbingPattern`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `IGlobbingPattern` | No | `` |  |

---

### IGlobbingPattern.And (static)

**Signature:** `Fake.IO.IGlobbingPattern IGlobbingPattern.And(Fake.IO.IGlobbingPattern, System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Adds the given pattern to the file includes

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `IGlobbingPattern` | No | `` |  |
| `pattern` | `String` | No | `` |  |

---

### IGlobbingPattern.ButNot (static)

**Signature:** `Fake.IO.IGlobbingPattern IGlobbingPattern.ButNot(Fake.IO.IGlobbingPattern, System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Ignores files with the given pattern

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `IGlobbingPattern` | No | `` |  |
| `pattern` | `String` | No | `` |  |

---

### IGlobbingPattern.SetBaseDirectory (static)

**Signature:** `Fake.IO.IGlobbingPattern IGlobbingPattern.SetBaseDirectory(Fake.IO.IGlobbingPattern, System.String)`
**Return Type:** `IGlobbingPattern`

**Description:** Sets a directory as BaseDirectory.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `IGlobbingPattern` | No | `` |  |
| `dir` | `String` | No | `` |  |

---

### IGlobbingPattern.IsMatch (static)

**Signature:** `Boolean IGlobbingPattern.IsMatch(Fake.IO.IGlobbingPattern, System.String)`
**Return Type:** `Boolean`

**Description:** Checks if a particular file is matched

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `IGlobbingPattern` | No | `` |  |
| `path` | `String` | No | `` |  |

---