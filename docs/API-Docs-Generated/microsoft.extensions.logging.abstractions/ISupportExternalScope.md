# ISupportExternalScope Interface

**Namespace:** `Microsoft.Extensions.Logging`
**Full Name:** `Microsoft.Extensions.Logging.ISupportExternalScope`

Represents a  that is able to consume external scope information.

## Methods

### SetScopeProvider

**Signature:** `Void SetScopeProvider(Microsoft.Extensions.Logging.IExternalScopeProvider)`
**Return Type:** `Void`

**Description:** Sets external scope information source for logger provider.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `scopeProvider` | `IExternalScopeProvider` | No | `` | The provider of scope data. |

---