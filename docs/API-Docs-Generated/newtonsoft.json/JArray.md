# JArray Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JArray`
- **Base Type:** `Newtonsoft.Json.Linq.JContainer`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`, `System.Collections.Generic.IList`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.ICollection`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.ComponentModel.ITypedList`, `System.ComponentModel.IBindingList`, `System.Collections.IList`, `System.Collections.ICollection`, `System.Collections.Specialized.INotifyCollectionChanged`

Represents a JSON array.

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

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JArray] LoadAsync(Newtonsoft.Json.JsonReader, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### LoadAsync (static)

**Signature:** `System.Threading.Tasks.Task`1[Newtonsoft.Json.Linq.JArray] LoadAsync(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings, System.Threading.CancellationToken)`
**Return Type:** `Task`1`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` |  |
| `settings` | `JsonLoadSettings` | No | `` |  |
| `cancellationToken` | `CancellationToken` | Yes | `null` |  |

---

### get_Type

**Signature:** `Newtonsoft.Json.Linq.JTokenType get_Type()`
**Return Type:** `JTokenType`

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader)`
**Return Type:** `JArray`

**Description:** Loads an  from a .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | A  that will be read for the content of the . |

**Returns:** A  that contains the JSON that was read from the specified .

---

### Load (static)

**Signature:** `Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JArray`

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

**Signature:** `Newtonsoft.Json.Linq.JArray Parse(System.String)`
**Return Type:** `JArray`

**Description:** Load a  from a string that contains JSON.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `json` | `String` | No | `` | A  that contains JSON. |

**Returns:** A  populated from the string that contains JSON.

---

### Parse (static)

**Signature:** `Newtonsoft.Json.Linq.JArray Parse(System.String, Newtonsoft.Json.Linq.JsonLoadSettings)`
**Return Type:** `JArray`

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

**Signature:** `Newtonsoft.Json.Linq.JArray FromObject(System.Object)`
**Return Type:** `JArray`

**Description:** Creates a  from an object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `o` | `Object` | No | `` | The object that will be used to create . |

**Returns:** A  with the values of the specified object

---

### FromObject (static)

**Signature:** `Newtonsoft.Json.Linq.JArray FromObject(System.Object, Newtonsoft.Json.JsonSerializer)`
**Return Type:** `JArray`

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

**Signature:** `Newtonsoft.Json.Linq.JToken get_Item(Int32)`
**Return Type:** `JToken`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |

---

### set_Item

**Signature:** `Void set_Item(Int32, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` |  |
| `value` | `JToken` | No | `` |  |

---

### IndexOf

**Signature:** `Int32 IndexOf(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Int32`

**Description:** Determines the index of a specific item in the .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `JToken` | No | `` | The object to locate in the . |

**Returns:** The index of  if found in the list; otherwise, -1.

---

### Insert

**Signature:** `Void Insert(Int32, Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Description:** Inserts an item to the  at the specified index.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` | The zero-based index at which  should be inserted. |
| `item` | `JToken` | No | `` | The object to insert into the . |

---

### RemoveAt

**Signature:** `Void RemoveAt(Int32)`
**Return Type:** `Void`

**Description:** Removes the  item at the specified index.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `index` | `Int32` | No | `` | The zero-based index of the item to remove. |

---

### GetEnumerator

**Signature:** `System.Collections.Generic.IEnumerator`1[Newtonsoft.Json.Linq.JToken] GetEnumerator()`
**Return Type:** `IEnumerator`1`

**Description:** Returns an enumerator that iterates through the collection.

**Returns:** A  that can be used to iterate through the collection.

---

### Add

**Signature:** `Void Add(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Void`

**Description:** Adds an item to the .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `JToken` | No | `` | The object to add to the . |

---

### Clear

**Signature:** `Void Clear()`
**Return Type:** `Void`

**Description:** Removes all items from the .

---

### Contains

**Signature:** `Boolean Contains(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Boolean`

**Description:** Determines whether the  contains a specific value.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `JToken` | No | `` | The object to locate in the . |

**Returns:** true if  is found in the ; otherwise, false.

---

### CopyTo

**Signature:** `Void CopyTo(Newtonsoft.Json.Linq.JToken[], Int32)`
**Return Type:** `Void`

**Description:** Copies to.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `array` | `JToken[]` | No | `` | The array. |
| `arrayIndex` | `Int32` | No | `` | Index of the array. |

---

### get_IsReadOnly

**Signature:** `Boolean get_IsReadOnly()`
**Return Type:** `Boolean`

---

### Remove

**Signature:** `Boolean Remove(Newtonsoft.Json.Linq.JToken)`
**Return Type:** `Boolean`

**Description:** Removes the first occurrence of a specific object from the .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `item` | `JToken` | No | `` | The object to remove from the . |

**Returns:** true if  was successfully removed from the ; otherwise, false. This method also returns false if  is not found in the original .

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

### IsReadOnly

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether the  is read-only.

---