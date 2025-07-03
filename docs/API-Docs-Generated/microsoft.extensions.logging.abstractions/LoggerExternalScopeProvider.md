# LoggerExternalScopeProvider Class

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.LoggerExternalScopeProvider`
- **Implements:** `Microsoft.Extensions.Logging.IExternalScopeProvider`

Default implementation of .

## Methods

### ForEachScope (generic)

**Signature:** `Void ForEachScope[TState](System.Action`2[System.Object,TState], TState)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `callback` | `Action`2` | No | `` |  |
| `state` | `TState` | No | `` |  |

---

### Push

**Signature:** `System.IDisposable Push(System.Object)`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `Object` | No | `` |  |

---