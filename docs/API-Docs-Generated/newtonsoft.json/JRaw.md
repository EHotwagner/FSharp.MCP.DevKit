# JRaw Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JRaw`
- **Base Type:** `Newtonsoft.Json.Linq.JValue`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`, `System.IEquatable`1[[Newtonsoft.Json.Linq.JValue, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.IFormattable`, `System.IComparable`, `System.IComparable`1[[Newtonsoft.Json.Linq.JValue, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.IConvertible`

Represents a raw JSON string.

## Methods

### CreateAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JRaw] CreateAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### Create (static)

**Signature:** `Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader)`
**Return Type:** `JRaw`

**Description:** Creates an instance of  with the content of the reader's current token.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The reader. |

**Returns:** An instance of  with the content of the reader's current token.

---