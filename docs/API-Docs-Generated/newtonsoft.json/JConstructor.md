# JConstructor Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JConstructor`
- **Base Type:** `Newtonsoft.Json.Linq.JContainer`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`, `System.Collections.Generic.IList`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.ICollection`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.ComponentModel.ITypedList`, `System.ComponentModel.IBindingList`, `System.Collections.IList`, `System.Collections.ICollection`, `System.Collections.Specialized.INotifyCollectionChanged`

Represents a JSON constructor.

## Methods

### WriteToAsync

**Signature:** `System.Threading.Tasks.Task WriteToAsync(Newtonsoft.Json.JsonWriter, System.Threading.CancellationToken, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `Task`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` |  |
| `cancellationToken` | `CancellationToken` | No | `` |  |
| `converters` | `JsonConverter[]` | No | `` |  |

---

### LoadAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JConstructor] LoadAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### LoadAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JConstructor] LoadAsync(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `settings` | `JsonLoadSettings` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### get_Name

**Signature:** `System.String get_Name()`
**Return Type:** `String`

---

### set_Name

**Signature:** `Void set_Name(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_Type

**Signature:** `Newtonsoft.Json.Linq.JTokenType get_Type()`
**Return Type:** `JTokenType`

---

### WriteTo

**Signature:** `Void WriteTo(Newtonsoft.Json.JsonWriter, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `Void`

**Description:** Writes this token to a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `writer` | `JsonWriter` | No | `` | A  into which this method will write. |
| `converters` | `JsonConverter[]` | No | `` | A collection of  which will be used when writing the token. |

---

### get_Item

**Signature:** `Newtonsoft.Json.Linq.JToken get_Item(System.Object)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `Object` | No | `` |  |

---

### set_Item

**Signature:** `Void set_Item(System.Object, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `key` | `Object` | No | `` |  |
| `value` | `JToken` | No | `` |  |

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader)`
**Return Type:** `JConstructor`

**Description:** Loads an  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | A  that will be read for the content of the . |

**Returns:** A  that contains the JSON that was read from the specified .

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JConstructor`

**Description:** Loads an  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | A  that will be read for the content of the . |
| `settings` | `JsonLoadSettings` | No | `` | The  used to load the JSON.
            If this is null, default load settings will be used. |

**Returns:** A  that contains the JSON that was read from the specified .

---

## Properties

### Name

**Type:** `String` (read/write)

**Description:** Gets or sets the name of this constructor.

---

### Type

**Type:** `JTokenType` (read-only)

**Description:** Gets the node type for this .

---

### Item

**Type:** `JToken` (read/write)

---