# JObject Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JObject`
- **Base Type:** `Newtonsoft.Json.Linq.JContainer`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`, `System.Collections.Generic.IList`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.ICollection`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.ComponentModel.ITypedList`, `System.ComponentModel.IBindingList`, `System.Collections.IList`, `System.Collections.ICollection`, `System.Collections.Specialized.INotifyCollectionChanged`, `System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.ICollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]], System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]`, `System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]], System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]`, `System.ComponentModel.INotifyPropertyChanged`, `System.ComponentModel.ICustomTypeDescriptor`, `System.ComponentModel.INotifyPropertyChanging`

Represents a JSON object.

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

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JObject] LoadAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### LoadAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JObject] LoadAsync(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `settings` | `JsonLoadSettings` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### add_PropertyChanged

**Signature:** `Void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `PropertyChangedEventHandler` | No | `` |  |

---

### remove_PropertyChanged

**Signature:** `Void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `PropertyChangedEventHandler` | No | `` |  |

---

### add_PropertyChanging

**Signature:** `Void add_PropertyChanging(System.ComponentModel.PropertyChangingEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `PropertyChangingEventHandler` | No | `` |  |

---

### remove_PropertyChanging

**Signature:** `Void remove_PropertyChanging(System.ComponentModel.PropertyChangingEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `PropertyChangingEventHandler` | No | `` |  |

---

### get_Type

**Signature:** `Newtonsoft.Json.Linq.JTokenType get_Type()`
**Return Type:** `JTokenType`

---

### Properties

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JProperty] Properties()`
**Return Type:** `IEnumerable`1`

**Description:** Gets an  of this object's properties.

**Returns:** An  of this object's properties.

---

### Property

**Signature:** `Newtonsoft.Json.Linq.JProperty Property(System.String)`
**Return Type:** `JProperty`

**Description:** Gets a  the specified name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` | The property name. |

**Returns:** A  with the specified name or null.

---

### Property

**Signature:** `Newtonsoft.Json.Linq.JProperty Property(System.String, System.StringComparison)`
**Return Type:** `JProperty`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `name` | `String` | No | `` |  |
| `comparison` | `StringComparison` | No | `` |  |

---

### PropertyValues

**Signature:** `Newtonsoft.Json.Linq.JEnumerable`1[Newtonsoft.Json.Linq.JToken] PropertyValues()`
**Return Type:** `JEnumerable`1`

**Description:** Gets an  of this object's property values.

**Returns:** An  of this object's property values.

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

### get_Item

**Signature:** `Newtonsoft.Json.Linq.JToken get_Item(System.String)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` |  |

---

### set_Item

**Signature:** `Void set_Item(System.String, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` |  |
| `value` | `JToken` | No | `` |  |

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader)`
**Return Type:** `JObject`

**Description:** Loads an  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | A  that will be read for the content of the . |

**Returns:** A  that contains the JSON that was read from the specified .

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JObject`

**Description:** Loads an  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | A  that will be read for the content of the . |
| `settings` | `JsonLoadSettings` | No | `` | The  used to load the JSON.
            If this is null, default load settings will be used. |

**Returns:** A  that contains the JSON that was read from the specified .

---

### Parse (static)

**Signature:** `Newtonsoft.Json.Linq.JObject Parse(System.String)`
**Return Type:** `JObject`

**Description:** Load a  from a string that contains JSON.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | A  that contains JSON. |

**Returns:** A  populated from the string that contains JSON.

---

### Parse (static)

**Signature:** `Newtonsoft.Json.Linq.JObject Parse(System.String, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JObject`

**Description:** Load a  from a string that contains JSON.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | A  that contains JSON. |
| `settings` | `JsonLoadSettings` | No | `` | The  used to load the JSON.
            If this is null, default load settings will be used. |

**Returns:** A  populated from the string that contains JSON.

---

### FromObject (static)

**Signature:** `Newtonsoft.Json.Linq.JObject FromObject(System.Object)`
**Return Type:** `JObject`

**Description:** Creates a  from an object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` | The object that will be used to create . |

**Returns:** A  with the values of the specified object

---

### FromObject (static)

**Signature:** `Newtonsoft.Json.Linq.JObject FromObject(System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `JObject`

**Description:** Creates a  from an object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` | The object that will be used to create . |
| `jsonSerializer` | `JsonSerializer` | No | `` | The  that will be used to read the object. |

**Returns:** A  with the values of the specified object

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

### GetValue

**Signature:** `Newtonsoft.Json.Linq.JToken GetValue(System.String)`
**Return Type:** `JToken`

**Description:** Gets the  with the specified property name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | Name of the property. |

**Returns:** The  with the specified property name.

---

### GetValue

**Signature:** `Newtonsoft.Json.Linq.JToken GetValue(System.String, System.StringComparison)`
**Return Type:** `JToken`

**Description:** Gets the  with the specified property name.
            The exact property name will be searched for first and if no matching property is found then
            the  will be used to match a property.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | Name of the property. |
| `comparison` | `StringComparison` | No | `` | One of the enumeration values that specifies how the strings will be compared. |

**Returns:** The  with the specified property name.

---

### TryGetValue

**Signature:** `Boolean TryGetValue(System.String, System.StringComparison, Newtonsoft.Json.Linq.JToken ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` |  |
| `comparison` | `StringComparison` | No | `` |  |
| `value` | `JToken&` | No | `` |  |

---

### Add

**Signature:** `Void Add(System.String, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Description:** Adds the specified property name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | Name of the property. |
| `value` | `JToken` | No | `` | The value. |

---

### ContainsKey

**Signature:** `Boolean ContainsKey(System.String)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` |  |

---

### Remove

**Signature:** `Boolean Remove(System.String)`
**Return Type:** `Boolean`

**Description:** Removes the property with the specified name.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | Name of the property. |

**Returns:** true if item was successfully removed; otherwise, false.

---

### TryGetValue

**Signature:** `Boolean TryGetValue(System.String, Newtonsoft.Json.Linq.JToken ByRef)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` |  |
| `value` | `JToken&` | No | `` |  |

---

### GetEnumerator

**Signature:** `System.Collections.Generic.IEnumerator`1[System.Collections.Generic.KeyValuePair`2[System.String,Newtonsoft.Json.Linq.JToken]] GetEnumerator()`
**Return Type:** `IEnumerator`1`

**Description:** Returns an enumerator that iterates through the collection.

**Returns:** A  that can be used to iterate through the collection.

---

## Properties

### Type

**Type:** `JTokenType` (read-only)

**Description:** Gets the node type for this .

---

### Item

**Type:** `JToken` (read/write)

---

### Item

**Type:** `JToken` (read/write)

---