# Glob Class

**Namespace:** `Fake.IO.Globbing`
**Full Name:** `Fake.IO.Globbing.Glob`

This module contains a file pattern globbing implementation.
 This module is part of the Fake.IO.FileSystem package

## Methods

### normalizePath (static)

**Signature:** `System.String normalizePath(System.String)`
**Return Type:** `String`

**Description:** Normalizes path for different OS

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `path` | `String` | No | `` | The path to normalize |

---

### isMatch (static)

**Signature:** `Boolean isMatch(System.String, System.String)`
**Return Type:** `Boolean`

**Description:** Check if the given path follows the given pattern

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `pattern` | `String` | No | `` | The glob pattern to use |
| `path` | `String` | No | `` | The path to check |

---