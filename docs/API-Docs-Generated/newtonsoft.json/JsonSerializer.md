# JsonSerializer Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonSerializer`

Serializes and deserializes objects into and from the JSON format.
            The  enables you to control how objects are encoded into JSON.

## Methods

### add_Error

**Signature:** `Void add_Error(System.EventHandler`1[Newtonsoft.Json.Serialization.ErrorEventArgs])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `EventHandler`1` | No | `` |  |

---

### remove_Error

**Signature:** `Void remove_Error(System.EventHandler`1[Newtonsoft.Json.Serialization.ErrorEventArgs])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `EventHandler`1` | No | `` |  |

---

### get_ReferenceResolver

**Signature:** `Newtonsoft.Json.Serialization.IReferenceResolver get_ReferenceResolver()`
**Return Type:** `IReferenceResolver`

---

### set_ReferenceResolver

**Signature:** `Void set_ReferenceResolver(Newtonsoft.Json.Serialization.IReferenceResolver)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `IReferenceResolver` | No | `` |  |

---

### get_Binder

**Signature:** `System.Runtime.Serialization.SerializationBinder get_Binder()`
**Return Type:** `SerializationBinder`

---

### set_Binder

**Signature:** `Void set_Binder(System.Runtime.Serialization.SerializationBinder)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `SerializationBinder` | No | `` |  |

---

### get_SerializationBinder

**Signature:** `Newtonsoft.Json.Serialization.ISerializationBinder get_SerializationBinder()`
**Return Type:** `ISerializationBinder`

---

### set_SerializationBinder

**Signature:** `Void set_SerializationBinder(Newtonsoft.Json.Serialization.ISerializationBinder)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ISerializationBinder` | No | `` |  |

---

### get_TraceWriter

**Signature:** `Newtonsoft.Json.Serialization.ITraceWriter get_TraceWriter()`
**Return Type:** `ITraceWriter`

---

### set_TraceWriter

**Signature:** `Void set_TraceWriter(Newtonsoft.Json.Serialization.ITraceWriter)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ITraceWriter` | No | `` |  |

---

### get_EqualityComparer

**Signature:** `System.Collections.IEqualityComparer get_EqualityComparer()`
**Return Type:** `IEqualityComparer`

---

### set_EqualityComparer

**Signature:** `Void set_EqualityComparer(System.Collections.IEqualityComparer)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `IEqualityComparer` | No | `` |  |

---

### get_TypeNameHandling

**Signature:** `Newtonsoft.Json.TypeNameHandling get_TypeNameHandling()`
**Return Type:** `TypeNameHandling`

---

### set_TypeNameHandling

**Signature:** `Void set_TypeNameHandling(Newtonsoft.Json.TypeNameHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TypeNameHandling` | No | `` |  |

---

### get_TypeNameAssemblyFormat

**Signature:** `System.Runtime.Serialization.Formatters.FormatterAssemblyStyle get_TypeNameAssemblyFormat()`
**Return Type:** `FormatterAssemblyStyle`

---

### set_TypeNameAssemblyFormat

**Signature:** `Void set_TypeNameAssemblyFormat(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FormatterAssemblyStyle` | No | `` |  |

---

### get_TypeNameAssemblyFormatHandling

**Signature:** `Newtonsoft.Json.TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling()`
**Return Type:** `TypeNameAssemblyFormatHandling`

---

### set_TypeNameAssemblyFormatHandling

**Signature:** `Void set_TypeNameAssemblyFormatHandling(Newtonsoft.Json.TypeNameAssemblyFormatHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TypeNameAssemblyFormatHandling` | No | `` |  |

---

### get_PreserveReferencesHandling

**Signature:** `Newtonsoft.Json.PreserveReferencesHandling get_PreserveReferencesHandling()`
**Return Type:** `PreserveReferencesHandling`

---

### set_PreserveReferencesHandling

**Signature:** `Void set_PreserveReferencesHandling(Newtonsoft.Json.PreserveReferencesHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `PreserveReferencesHandling` | No | `` |  |

---

### get_ReferenceLoopHandling

**Signature:** `Newtonsoft.Json.ReferenceLoopHandling get_ReferenceLoopHandling()`
**Return Type:** `ReferenceLoopHandling`

---

### set_ReferenceLoopHandling

**Signature:** `Void set_ReferenceLoopHandling(Newtonsoft.Json.ReferenceLoopHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ReferenceLoopHandling` | No | `` |  |

---

### get_MissingMemberHandling

**Signature:** `Newtonsoft.Json.MissingMemberHandling get_MissingMemberHandling()`
**Return Type:** `MissingMemberHandling`

---

### set_MissingMemberHandling

**Signature:** `Void set_MissingMemberHandling(Newtonsoft.Json.MissingMemberHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `MissingMemberHandling` | No | `` |  |

---

### get_NullValueHandling

**Signature:** `Newtonsoft.Json.NullValueHandling get_NullValueHandling()`
**Return Type:** `NullValueHandling`

---

### set_NullValueHandling

**Signature:** `Void set_NullValueHandling(Newtonsoft.Json.NullValueHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `NullValueHandling` | No | `` |  |

---

### get_DefaultValueHandling

**Signature:** `Newtonsoft.Json.DefaultValueHandling get_DefaultValueHandling()`
**Return Type:** `DefaultValueHandling`

---

### set_DefaultValueHandling

**Signature:** `Void set_DefaultValueHandling(Newtonsoft.Json.DefaultValueHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DefaultValueHandling` | No | `` |  |

---

### get_ObjectCreationHandling

**Signature:** `Newtonsoft.Json.ObjectCreationHandling get_ObjectCreationHandling()`
**Return Type:** `ObjectCreationHandling`

---

### set_ObjectCreationHandling

**Signature:** `Void set_ObjectCreationHandling(Newtonsoft.Json.ObjectCreationHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ObjectCreationHandling` | No | `` |  |

---

### get_ConstructorHandling

**Signature:** `Newtonsoft.Json.ConstructorHandling get_ConstructorHandling()`
**Return Type:** `ConstructorHandling`

---

### set_ConstructorHandling

**Signature:** `Void set_ConstructorHandling(Newtonsoft.Json.ConstructorHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `ConstructorHandling` | No | `` |  |

---

### get_MetadataPropertyHandling

**Signature:** `Newtonsoft.Json.MetadataPropertyHandling get_MetadataPropertyHandling()`
**Return Type:** `MetadataPropertyHandling`

---

### set_MetadataPropertyHandling

**Signature:** `Void set_MetadataPropertyHandling(Newtonsoft.Json.MetadataPropertyHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `MetadataPropertyHandling` | No | `` |  |

---

### get_Converters

**Signature:** `Newtonsoft.Json.JsonConverterCollection get_Converters()`
**Return Type:** `JsonConverterCollection`

---

### get_ContractResolver

**Signature:** `Newtonsoft.Json.Serialization.IContractResolver get_ContractResolver()`
**Return Type:** `IContractResolver`

---

### set_ContractResolver

**Signature:** `Void set_ContractResolver(Newtonsoft.Json.Serialization.IContractResolver)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `IContractResolver` | No | `` |  |

---

### get_Context

**Signature:** `System.Runtime.Serialization.StreamingContext get_Context()`
**Return Type:** `StreamingContext`

---

### set_Context

**Signature:** `Void set_Context(System.Runtime.Serialization.StreamingContext)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `StreamingContext` | No | `` |  |

---

### get_Formatting

**Signature:** `Newtonsoft.Json.Formatting get_Formatting()`
**Return Type:** `Formatting`

---

### set_Formatting

**Signature:** `Void set_Formatting(Newtonsoft.Json.Formatting)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Formatting` | No | `` |  |

---

### get_DateFormatHandling

**Signature:** `Newtonsoft.Json.DateFormatHandling get_DateFormatHandling()`
**Return Type:** `DateFormatHandling`

---

### set_DateFormatHandling

**Signature:** `Void set_DateFormatHandling(Newtonsoft.Json.DateFormatHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateFormatHandling` | No | `` |  |

---

### get_DateTimeZoneHandling

**Signature:** `Newtonsoft.Json.DateTimeZoneHandling get_DateTimeZoneHandling()`
**Return Type:** `DateTimeZoneHandling`

---

### set_DateTimeZoneHandling

**Signature:** `Void set_DateTimeZoneHandling(Newtonsoft.Json.DateTimeZoneHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeZoneHandling` | No | `` |  |

---

### get_DateParseHandling

**Signature:** `Newtonsoft.Json.DateParseHandling get_DateParseHandling()`
**Return Type:** `DateParseHandling`

---

### set_DateParseHandling

**Signature:** `Void set_DateParseHandling(Newtonsoft.Json.DateParseHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateParseHandling` | No | `` |  |

---

### get_FloatParseHandling

**Signature:** `Newtonsoft.Json.FloatParseHandling get_FloatParseHandling()`
**Return Type:** `FloatParseHandling`

---

### set_FloatParseHandling

**Signature:** `Void set_FloatParseHandling(Newtonsoft.Json.FloatParseHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FloatParseHandling` | No | `` |  |

---

### get_FloatFormatHandling

**Signature:** `Newtonsoft.Json.FloatFormatHandling get_FloatFormatHandling()`
**Return Type:** `FloatFormatHandling`

---

### set_FloatFormatHandling

**Signature:** `Void set_FloatFormatHandling(Newtonsoft.Json.FloatFormatHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `FloatFormatHandling` | No | `` |  |

---

### get_StringEscapeHandling

**Signature:** `Newtonsoft.Json.StringEscapeHandling get_StringEscapeHandling()`
**Return Type:** `StringEscapeHandling`

---

### set_StringEscapeHandling

**Signature:** `Void set_StringEscapeHandling(Newtonsoft.Json.StringEscapeHandling)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `StringEscapeHandling` | No | `` |  |

---

### get_DateFormatString

**Signature:** `System.String get_DateFormatString()`
**Return Type:** `String`

---

### set_DateFormatString

**Signature:** `Void set_DateFormatString(System.String)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### get_Culture

**Signature:** `System.Globalization.CultureInfo get_Culture()`
**Return Type:** `CultureInfo`

---

### set_Culture

**Signature:** `Void set_Culture(System.Globalization.CultureInfo)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `CultureInfo` | No | `` |  |

---

### get_MaxDepth

**Signature:** `System.Nullable`1[System.Int32] get_MaxDepth()`
**Return Type:** `Nullable`1`

---

### set_MaxDepth

**Signature:** `Void set_MaxDepth(System.Nullable`1[System.Int32])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Nullable`1` | No | `` |  |

---

### get_CheckAdditionalContent

**Signature:** `Boolean get_CheckAdditionalContent()`
**Return Type:** `Boolean`

---

### set_CheckAdditionalContent

**Signature:** `Void set_CheckAdditionalContent(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### Create (static)

**Signature:** `Newtonsoft.Json.JsonSerializer Create()`
**Return Type:** `JsonSerializer`

**Description:** Creates a new  instance.
            The  will not use default settings 
            from .

**Returns:** A new  instance.
            The  will not use default settings 
            from .

---

### Create (static)

**Signature:** `Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `JsonSerializer`

**Description:** Creates a new  instance using the specified .
            The  will not use default settings 
            from .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `settings` | `JsonSerializerSettings` | No | `` | The settings to be applied to the . |

**Returns:** A new  instance using the specified .
            The  will not use default settings 
            from .

---

### CreateDefault (static)

**Signature:** `Newtonsoft.Json.JsonSerializer CreateDefault()`
**Return Type:** `JsonSerializer`

**Description:** Creates a new  instance.
            The  will use default settings 
            from .

**Returns:** A new  instance.
            The  will use default settings 
            from .

---

### CreateDefault (static)

**Signature:** `Newtonsoft.Json.JsonSerializer CreateDefault(Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `JsonSerializer`

**Description:** Creates a new  instance using the specified .
            The  will use default settings 
            from  as well as the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `settings` | `JsonSerializerSettings` | No | `` | The settings to be applied to the . |

**Returns:** A new  instance using the specified .
            The  will use default settings 
            from  as well as the specified .

---

### Populate

**Signature:** `Void Populate(System.IO.TextReader, System.Object)`
**Return Type:** `Void`

**Description:** Populates the JSON values onto the target object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `TextReader` | No | `` | The  that contains the JSON structure to reader values from. |
| `target` | `Object` | No | `` | The target object to populate values onto. |

---

### Populate

**Signature:** `Void Populate(Newtonsoft.Json.JsonReader, System.Object)`
**Return Type:** `Void`

**Description:** Populates the JSON values onto the target object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  that contains the JSON structure to reader values from. |
| `target` | `Object` | No | `` | The target object to populate values onto. |

---

### Deserialize

**Signature:** `System.Object Deserialize(Newtonsoft.Json.JsonReader)`
**Return Type:** `Object`

**Description:** Deserializes the JSON structure contained by the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  that contains the JSON structure to deserialize. |

**Returns:** The  being deserialized.

---

### Deserialize

**Signature:** `System.Object Deserialize(System.IO.TextReader, System.Type)`
**Return Type:** `Object`

**Description:** Deserializes the JSON structure contained by the specified 
            into an instance of the specified type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `TextReader` | No | `` | The  containing the object. |
| `objectType` | `Type` | No | `` | The  of object being deserialized. |

**Returns:** The instance of  being deserialized.

---

### Deserialize (generic)

**Signature:** `T Deserialize[T](Newtonsoft.Json.JsonReader)`
**Return Type:** `T`

**Description:** Deserializes the JSON structure contained by the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  that contains the JSON structure to deserialize. |

**Returns:** The  being deserialized.

---

### Deserialize

**Signature:** `System.Object Deserialize(Newtonsoft.Json.JsonReader, System.Type)`
**Return Type:** `Object`

**Description:** Deserializes the JSON structure contained by the specified 
            into an instance of the specified type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `reader` | `JsonReader` | No | `` | The  containing the object. |
| `objectType` | `Type` | No | `` | The  of object being deserialized. |

**Returns:** The instance of  being deserialized.

---

### Serialize

**Signature:** `Void Serialize(System.IO.TextWriter, System.Object)`
**Return Type:** `Void`

**Description:** Serializes the specified  and writes the JSON structure
            to a Stream using the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `textWriter` | `TextWriter` | No | `` | The  used to write the JSON structure. |
| `value` | `Object` | No | `` | The  to serialize. |

---

### Serialize

**Signature:** `Void Serialize(Newtonsoft.Json.JsonWriter, System.Object, System.Type)`
**Return Type:** `Void`

**Description:** Serializes the specified  and writes the JSON structure
            to a Stream using the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `jsonWriter` | `JsonWriter` | No | `` | The  used to write the JSON structure. |
| `value` | `Object` | No | `` | The  to serialize. |
| `objectType` | `Type` | No | `` | The type of the value being serialized.
            This parameter is used when  is Auto to write out the type name if the type of the value does not match.
            Specifing the type is optional. |

---

### Serialize

**Signature:** `Void Serialize(System.IO.TextWriter, System.Object, System.Type)`
**Return Type:** `Void`

**Description:** Serializes the specified  and writes the JSON structure
            to a Stream using the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `textWriter` | `TextWriter` | No | `` | The  used to write the JSON structure. |
| `value` | `Object` | No | `` | The  to serialize. |
| `objectType` | `Type` | No | `` | The type of the value being serialized.
            This parameter is used when  is Auto to write out the type name if the type of the value does not match.
            Specifing the type is optional. |

---

### Serialize

**Signature:** `Void Serialize(Newtonsoft.Json.JsonWriter, System.Object)`
**Return Type:** `Void`

**Description:** Serializes the specified  and writes the JSON structure
            to a Stream using the specified .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `jsonWriter` | `JsonWriter` | No | `` | The  used to write the JSON structure. |
| `value` | `Object` | No | `` | The  to serialize. |

---

## Properties

### ReferenceResolver

**Type:** `IReferenceResolver` (read/write)

**Description:** Gets or sets the  used by the serializer when resolving references.

---

### Binder

**Type:** `SerializationBinder` (read/write)

**Description:** Gets or sets the  used by the serializer when resolving type names.

---

### SerializationBinder

**Type:** `ISerializationBinder` (read/write)

---

### TraceWriter

**Type:** `ITraceWriter` (read/write)

**Description:** Gets or sets the  used by the serializer when writing trace messages.

---

### EqualityComparer

**Type:** `IEqualityComparer` (read/write)

**Description:** Gets or sets the equality comparer used by the serializer when comparing references.

---

### TypeNameHandling

**Type:** `TypeNameHandling` (read/write)

**Description:** Gets or sets how type name writing and reading is handled by the serializer.

---

### TypeNameAssemblyFormat

**Type:** `FormatterAssemblyStyle` (read/write)

**Description:** Gets or sets how a type name assembly is written and resolved by the serializer.

---

### TypeNameAssemblyFormatHandling

**Type:** `TypeNameAssemblyFormatHandling` (read/write)

---

### PreserveReferencesHandling

**Type:** `PreserveReferencesHandling` (read/write)

**Description:** Gets or sets how object references are preserved by the serializer.

---

### ReferenceLoopHandling

**Type:** `ReferenceLoopHandling` (read/write)

**Description:** Get or set how reference loops (e.g. a class referencing itself) is handled.

---

### MissingMemberHandling

**Type:** `MissingMemberHandling` (read/write)

**Description:** Get or set how missing members (e.g. JSON contains a property that isn't a member on the object) are handled during deserialization.

---

### NullValueHandling

**Type:** `NullValueHandling` (read/write)

**Description:** Get or set how null values are handled during serialization and deserialization.

---

### DefaultValueHandling

**Type:** `DefaultValueHandling` (read/write)

**Description:** Get or set how null default are handled during serialization and deserialization.

---

### ObjectCreationHandling

**Type:** `ObjectCreationHandling` (read/write)

**Description:** Gets or sets how objects are created during deserialization.

---

### ConstructorHandling

**Type:** `ConstructorHandling` (read/write)

**Description:** Gets or sets how constructors are used during deserialization.

---

### MetadataPropertyHandling

**Type:** `MetadataPropertyHandling` (read/write)

**Description:** Gets or sets how metadata properties are used during deserialization.

---

### Converters

**Type:** `JsonConverterCollection` (read-only)

**Description:** Gets a collection  that will be used during serialization.

---

### ContractResolver

**Type:** `IContractResolver` (read/write)

**Description:** Gets or sets the contract resolver used by the serializer when
            serializing .NET objects to JSON and vice versa.

---

### Context

**Type:** `StreamingContext` (read/write)

**Description:** Gets or sets the  used by the serializer when invoking serialization callback methods.

---

### Formatting

**Type:** `Formatting` (read/write)

**Description:** Indicates how JSON text output is formatted.

---

### DateFormatHandling

**Type:** `DateFormatHandling` (read/write)

**Description:** Get or set how dates are written to JSON text.

---

### DateTimeZoneHandling

**Type:** `DateTimeZoneHandling` (read/write)

**Description:** Get or set how  time zones are handling during serialization and deserialization.

---

### DateParseHandling

**Type:** `DateParseHandling` (read/write)

**Description:** Get or set how date formatted strings, e.g. "\/Date(1198908717056)\/" and "2012-03-21T05:40Z", are parsed when reading JSON.

---

### FloatParseHandling

**Type:** `FloatParseHandling` (read/write)

**Description:** Get or set how floating point numbers, e.g. 1.0 and 9.9, are parsed when reading JSON text.

---

### FloatFormatHandling

**Type:** `FloatFormatHandling` (read/write)

**Description:** Get or set how special floating point numbers, e.g. ,
             and ,
            are written as JSON text.

---

### StringEscapeHandling

**Type:** `StringEscapeHandling` (read/write)

**Description:** Get or set how strings are escaped when writing JSON text.

---

### DateFormatString

**Type:** `String` (read/write)

**Description:** Get or set how  and  values are formatted when writing JSON text, and the expected date format when reading JSON text.

---

### Culture

**Type:** `CultureInfo` (read/write)

**Description:** Gets or sets the culture used when reading JSON. Defaults to .

---

### MaxDepth

**Type:** `Nullable`1` (read/write)

**Description:** Gets or sets the maximum depth allowed when reading JSON. Reading past this depth will throw a .

---

### CheckAdditionalContent

**Type:** `Boolean` (read/write)

**Description:** Gets a value indicating whether there will be a check for additional JSON content after deserializing an object.

---