# IExternalScopeProvider Interface

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.IExternalScopeProvider`

Represents a storage of common scope data.

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

**Description:** Adds scope object to the list.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `state` | `Object` | No | `` | The scope object. |

**Returns:** The  token that removes scope on dispose.

---