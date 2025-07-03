# JContainer Class

**Namespace:** `Newtonsoft.Json.Linq`
**Full Name:** `Newtonsoft.Json.Linq.JContainer`
- **Base Type:** `Newtonsoft.Json.Linq.JToken`
- **Implements:** `Newtonsoft.Json.Linq.IJEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.IEnumerable`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.IEnumerable`, `Newtonsoft.Json.IJsonLineInfo`, `System.ICloneable`, `System.Dynamic.IDynamicMetaObjectProvider`, `System.Collections.Generic.IList`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.Collections.Generic.ICollection`1[[Newtonsoft.Json.Linq.JToken, Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed]]`, `System.ComponentModel.ITypedList`, `System.ComponentModel.IBindingList`, `System.Collections.IList`, `System.Collections.ICollection`, `System.Collections.Specialized.INotifyCollectionChanged`

Represents a token that can contain other tokens.

## Methods

### add_ListChanged

**Signature:** `Void add_ListChanged(System.ComponentModel.ListChangedEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ListChangedEventHandler` | No | `` |  |

---

### remove_ListChanged

**Signature:** `Void remove_ListChanged(System.ComponentModel.ListChangedEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ListChangedEventHandler` | No | `` |  |

---

### add_AddingNew

**Signature:** `Void add_AddingNew(System.ComponentModel.AddingNewEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `AddingNewEventHandler` | No | `` |  |

---

### remove_AddingNew

**Signature:** `Void remove_AddingNew(System.ComponentModel.AddingNewEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `AddingNewEventHandler` | No | `` |  |

---

### add_CollectionChanged

**Signature:** `Void add_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `NotifyCollectionChangedEventHandler` | No | `` |  |

---

### remove_CollectionChanged

**Signature:** `Void remove_CollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventHandler)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `NotifyCollectionChangedEventHandler` | No | `` |  |

---

### get_HasValues

**Signature:** `Boolean get_HasValues()`
**Return Type:** `Boolean`

---

### get_First

**Signature:** `Newtonsoft.Json.Linq.JToken get_First()`
**Return Type:** `JToken`

---

### get_Last

**Signature:** `Newtonsoft.Json.Linq.JToken get_Last()`
**Return Type:** `JToken`

---

### Children

**Signature:** `Newtonsoft.Json.Linq.JEnumerable`1[Newtonsoft.Json.Linq.JToken] Children()`
**Return Type:** `JEnumerable`1`

**Description:** Returns a collection of the child tokens of this token, in document order.

**Returns:** An  of  containing the child tokens of this , in document order.

---

### Values (generic)

**Signature:** `System.Collections.Generic.IEnumerable`1[T] Values[T]()`
**Return Type:** `IEnumerable`1`

---

### Descendants

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] Descendants()`
**Return Type:** `IEnumerable`1`

**Description:** Returns a collection of the descendant tokens for this token in document order.

**Returns:** An  containing the descendant tokens of the .

---

### DescendantsAndSelf

**Signature:** `System.Collections.Generic.IEnumerable`1[Newtonsoft.Json.Linq.JToken] DescendantsAndSelf()`
**Return Type:** `IEnumerable`1`

**Description:** Returns a collection of the tokens that contain this token, and all descendant tokens of this token, in document order.

**Returns:** An  containing this token, and all the descendant tokens of the .

---

### Add

**Signature:** `Void Add(System.Object)`
**Return Type:** `Void`

**Description:** Adds the specified content as children of this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | The content to be added. |

---

### AddFirst

**Signature:** `Void AddFirst(System.Object)`
**Return Type:** `Void`

**Description:** Adds the specified content as the first children of this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | The content to be added. |

---

### CreateWriter

**Signature:** `Newtonsoft.Json.JsonWriter CreateWriter()`
**Return Type:** `JsonWriter`

**Description:** Creates an  that can be used to add tokens to the .

**Returns:** An  that is ready to have content written to it.

---

### ReplaceAll

**Signature:** `Void ReplaceAll(System.Object)`
**Return Type:** `Void`

**Description:** Replaces the children nodes of this token with the specified content.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | The content. |

---

### RemoveAll

**Signature:** `Void RemoveAll()`
**Return Type:** `Void`

**Description:** Removes the child nodes from this token.

---

### Merge

**Signature:** `Void Merge(System.Object)`
**Return Type:** `Void`

**Description:** Merge the specified content into this .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | The content to be merged. |

---

### Merge

**Signature:** `Void Merge(System.Object, Newtonsoft.Json.Linq.JsonMergeSettings)`
**Return Type:** `Void`

**Description:** Merge the specified content into this  using .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `content` | `Object` | No | `` | The content to be merged. |
| `settings` | `JsonMergeSettings` | No | `` | The  used to merge the content. |

---

### get_Count

**Signature:** `Int32 get_Count()`
**Return Type:** `Int32`

---

## Properties

### HasValues

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether this token has child tokens.

---

### First

**Type:** `JToken` (read-only)

**Description:** Get the first child token of this token.

---

### Last

**Type:** `JToken` (read-only)

**Description:** Get the last child token of this token.

---

### Count

**Type:** `Int32` (read-only)

**Description:** Gets the count of child JSON tokens.

---