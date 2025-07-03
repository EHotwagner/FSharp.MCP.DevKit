# ReflectionValueProvider Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.ReflectionValueProvider`
- **Implements:** `Newtonsoft.Json.Serialization.IValueProvider`

Get and set values for a  using reflection.

## Methods

### SetValue

**Signature:** `Void SetValue(System.Object, System.Object)`
**Return Type:** `Void`

**Description:** Sets the value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `Object` | No | `` | The target to set the value on. |
| `value` | `Object` | No | `` | The value to set on the target. |

---

### GetValue

**Signature:** `System.Object GetValue(System.Object)`
**Return Type:** `Object`

**Description:** Gets the value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `target` | `Object` | No | `` | The target to get the value from. |

**Returns:** The value.

---