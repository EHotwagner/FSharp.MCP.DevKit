# Args Class

**Namespace:** `Fake.Core`
**Full Name:** `Fake.Core.Args`

Helper functions for proper command line parsing

## Methods

### toWindowsCommandLine (static)

**Signature:** `System.String toWindowsCommandLine(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `IEnumerable`1` | No | `` |  |

---

### toLinuxShellCommandLine (static)

**Signature:** `System.String toLinuxShellCommandLine(System.Collections.Generic.IEnumerable`1[System.String])`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `args` | `IEnumerable`1` | No | `` |  |

---

### fromWindowsCommandLine (static)

**Signature:** `System.String[] fromWindowsCommandLine(System.String)`
**Return Type:** `String[]`

**Description:** Read a windows command line string into its arguments

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `cmd` | `String` | No | `` | The command to construct |

---