# JsonConvert Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonConvert`

Provides methods for converting between common language runtime types and JSON types.

## Methods

### get_DefaultSettings (static)

**Signature:** `System.Func`1[Newtonsoft.Json.JsonSerializerSettings] get_DefaultSettings()`
**Return Type:** `Func`1`

---

### set_DefaultSettings (static)

**Signature:** `Void set_DefaultSettings(System.Func`1[Newtonsoft.Json.JsonSerializerSettings])`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Func`1` | No | `` |  |

---

### ToString (static)

**Signature:** `System.String ToString(System.DateTime)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTime` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.DateTime, Newtonsoft.Json.DateFormatHandling, Newtonsoft.Json.DateTimeZoneHandling)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation using the  specified.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTime` | No | `` | The value to convert. |
| `format` | `DateFormatHandling` | No | `` | The format the date will be converted to. |
| `timeZoneHandling` | `DateTimeZoneHandling` | No | `` | The time zone handling when the date is converted to a string. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.DateTimeOffset)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeOffset` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.DateTimeOffset, Newtonsoft.Json.DateFormatHandling)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation using the  specified.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `DateTimeOffset` | No | `` | The value to convert. |
| `format` | `DateFormatHandling` | No | `` | The format the date will be converted to. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Boolean)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Char)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Char` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.Enum)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Enum` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Int32)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int32` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Int16)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int16` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(UInt16)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt16` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(UInt32)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt32` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Int64)`
**Return Type:** `String`

**Description:** Converts the   to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Int64` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(UInt64)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `UInt64` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Single)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Single` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Double)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Double` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(Byte)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Byte` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(SByte)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `SByte` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.Decimal)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Decimal` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.Guid)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Guid` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.TimeSpan)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `TimeSpan` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.Uri)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Uri` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.String)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.String, Char)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The value to convert. |
| `delimiter` | `Char` | No | `` | The string delimiter character. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.String, Char, Newtonsoft.Json.StringEscapeHandling)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The value to convert. |
| `delimiter` | `Char` | No | `` | The string delimiter character. |
| `stringEscapeHandling` | `StringEscapeHandling` | No | `` | The string escape handling. |

**Returns:** A JSON string representation of the .

---

### ToString (static)

**Signature:** `System.String ToString(System.Object)`
**Return Type:** `String`

**Description:** Converts the  to its JSON string representation.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The value to convert. |

**Returns:** A JSON string representation of the .

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object)`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, Newtonsoft.Json.Formatting)`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using formatting.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using a collection of .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `converters` | `JsonConverter[]` | No | `` | A collection converters used while serializing. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, Newtonsoft.Json.Formatting, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using formatting and a collection of .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |
| `converters` | `JsonConverter[]` | No | `` | A collection converters used while serializing. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to serialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, System.Type, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using a type, formatting and .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `type` | `Type` | No | `` | The type of the value being serialized.
            This parameter is used when  is Auto to write out the type name if the type of the value does not match.
            Specifing the type is optional. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to serialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, Newtonsoft.Json.Formatting, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using formatting and .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to serialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** A JSON string representation of the object.

---

### SerializeObject (static)

**Signature:** `System.String SerializeObject(System.Object, System.Type, Newtonsoft.Json.Formatting, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `String`

**Description:** Serializes the specified object to a JSON string using a type, formatting and .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Object` | No | `` | The object to serialize. |
| `type` | `Type` | No | `` | The type of the value being serialized.
            This parameter is used when  is Auto to write out the type name if the type of the value does not match.
            Specifing the type is optional. |
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to serialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** A JSON string representation of the object.

---

### DeserializeObject (static)

**Signature:** `System.Object DeserializeObject(System.String)`
**Return Type:** `Object`

**Description:** Deserializes the JSON to a .NET object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |

**Returns:** The deserialized object from the JSON string.

---

### DeserializeObject (static)

**Signature:** `System.Object DeserializeObject(System.String, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `Object`

**Description:** Deserializes the JSON to a .NET object using .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to deserialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** The deserialized object from the JSON string.

---

### DeserializeObject (static)

**Signature:** `System.Object DeserializeObject(System.String, System.Type)`
**Return Type:** `Object`

**Description:** Deserializes the JSON to the specified .NET type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |
| `type` | `Type` | No | `` | The  of object being deserialized. |

**Returns:** The deserialized object from the JSON string.

---

### DeserializeObject (static) (generic)

**Signature:** `T DeserializeObject[T](System.String)`
**Return Type:** `T`

**Description:** Deserializes the JSON to a .NET object.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |

**Returns:** The deserialized object from the JSON string.

---

### DeserializeAnonymousType (static) (generic)

**Signature:** `T DeserializeAnonymousType[T](System.String, T)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `anonymousTypeObject` | `T` | No | `` |  |

---

### DeserializeAnonymousType (static) (generic)

**Signature:** `T DeserializeAnonymousType[T](System.String, T, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `anonymousTypeObject` | `T` | No | `` |  |
| `settings` | `JsonSerializerSettings` | No | `` |  |

---

### DeserializeObject (static) (generic)

**Signature:** `T DeserializeObject[T](System.String, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `converters` | `JsonConverter[]` | No | `` |  |

---

### DeserializeObject (static) (generic)

**Signature:** `T DeserializeObject[T](System.String, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `T`

**Description:** Deserializes the JSON to a .NET object using .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to deserialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** The deserialized object from the JSON string.

---

### DeserializeObject (static)

**Signature:** `System.Object DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonConverter[])`
**Return Type:** `Object`

**Description:** Deserializes the JSON to the specified .NET type using a collection of .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |
| `type` | `Type` | No | `` | The type of the object to deserialize. |
| `converters` | `JsonConverter[]` | No | `` | Converters to use while deserializing. |

**Returns:** The deserialized object from the JSON string.

---

### DeserializeObject (static)

**Signature:** `System.Object DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `Object`

**Description:** Deserializes the JSON to the specified .NET type using .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to deserialize. |
| `type` | `Type` | No | `` | The type of the object to deserialize to. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to deserialize the object.
            If this is null, default serialization settings will be used. |

**Returns:** The deserialized object from the JSON string.

---

### PopulateObject (static)

**Signature:** `Void PopulateObject(System.String, System.Object)`
**Return Type:** `Void`

**Description:** Populates the object with values from the JSON string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to populate values from. |
| `target` | `Object` | No | `` | The target object to populate values onto. |

---

### PopulateObject (static)

**Signature:** `Void PopulateObject(System.String, System.Object, Newtonsoft.Json.JsonSerializerSettings)`
**Return Type:** `Void`

**Description:** Populates the object with values from the JSON string using .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON to populate values from. |
| `target` | `Object` | No | `` | The target object to populate values onto. |
| `settings` | `JsonSerializerSettings` | No | `` | The  used to deserialize the object.
            If this is null, default serialization settings will be used. |

---

### SerializeXmlNode (static)

**Signature:** `System.String SerializeXmlNode(System.Xml.XmlNode)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `node` | `XmlNode` | No | `` |  |

---

### SerializeXmlNode (static)

**Signature:** `System.String SerializeXmlNode(System.Xml.XmlNode, Newtonsoft.Json.Formatting)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `node` | `XmlNode` | No | `` |  |
| `formatting` | `Formatting` | No | `` |  |

---

### SerializeXmlNode (static)

**Signature:** `System.String SerializeXmlNode(System.Xml.XmlNode, Newtonsoft.Json.Formatting, Boolean)`
**Return Type:** `String`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `node` | `XmlNode` | No | `` |  |
| `formatting` | `Formatting` | No | `` |  |
| `omitRootObject` | `Boolean` | No | `` |  |

---

### DeserializeXmlNode (static)

**Signature:** `System.Xml.XmlDocument DeserializeXmlNode(System.String)`
**Return Type:** `XmlDocument`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |

---

### DeserializeXmlNode (static)

**Signature:** `System.Xml.XmlDocument DeserializeXmlNode(System.String, System.String)`
**Return Type:** `XmlDocument`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `deserializeRootElementName` | `String` | No | `` |  |

---

### DeserializeXmlNode (static)

**Signature:** `System.Xml.XmlDocument DeserializeXmlNode(System.String, System.String, Boolean)`
**Return Type:** `XmlDocument`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `deserializeRootElementName` | `String` | No | `` |  |
| `writeArrayAttribute` | `Boolean` | No | `` |  |

---

### DeserializeXmlNode (static)

**Signature:** `System.Xml.XmlDocument DeserializeXmlNode(System.String, System.String, Boolean, Boolean)`
**Return Type:** `XmlDocument`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `deserializeRootElementName` | `String` | No | `` |  |
| `writeArrayAttribute` | `Boolean` | No | `` |  |
| `encodeSpecialCharacters` | `Boolean` | No | `` |  |

---

### SerializeXNode (static)

**Signature:** `System.String SerializeXNode(System.Xml.Linq.XObject)`
**Return Type:** `String`

**Description:** Serializes the  to a JSON string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `node` | `XObject` | No | `` | The node to convert to JSON. |

**Returns:** A JSON string of the XNode.

---

### SerializeXNode (static)

**Signature:** `System.String SerializeXNode(System.Xml.Linq.XObject, Newtonsoft.Json.Formatting)`
**Return Type:** `String`

**Description:** Serializes the  to a JSON string using formatting.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `node` | `XObject` | No | `` | The node to convert to JSON. |
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |

**Returns:** A JSON string of the XNode.

---

### SerializeXNode (static)

**Signature:** `System.String SerializeXNode(System.Xml.Linq.XObject, Newtonsoft.Json.Formatting, Boolean)`
**Return Type:** `String`

**Description:** Serializes the  to a JSON string using formatting and omits the root object if  is true.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `node` | `XObject` | No | `` | The node to serialize. |
| `formatting` | `Formatting` | No | `` | Indicates how the output is formatted. |
| `omitRootObject` | `Boolean` | No | `` | Omits writing the root object. |

**Returns:** A JSON string of the XNode.

---

### DeserializeXNode (static)

**Signature:** `System.Xml.Linq.XDocument DeserializeXNode(System.String)`
**Return Type:** `XDocument`

**Description:** Deserializes the  from a JSON string.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON string. |

**Returns:** The deserialized XNode

---

### DeserializeXNode (static)

**Signature:** `System.Xml.Linq.XDocument DeserializeXNode(System.String, System.String)`
**Return Type:** `XDocument`

**Description:** Deserializes the  from a JSON string nested in a root elment specified by .

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON string. |
| `deserializeRootElementName` | `String` | No | `` | The name of the root element to append when deserializing. |

**Returns:** The deserialized XNode

---

### DeserializeXNode (static)

**Signature:** `System.Xml.Linq.XDocument DeserializeXNode(System.String, System.String, Boolean)`
**Return Type:** `XDocument`

**Description:** Deserializes the  from a JSON string nested in a root elment specified by 
            and writes a .NET array attribute for collections.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` | The JSON string. |
| `deserializeRootElementName` | `String` | No | `` | The name of the root element to append when deserializing. |
| `writeArrayAttribute` | `Boolean` | No | `` | A flag to indicate whether to write the Json.NET array attribute.
            This attribute helps preserve arrays when converting the written XML back to JSON. |

**Returns:** The deserialized XNode

---

### DeserializeXNode (static)

**Signature:** `System.Xml.Linq.XDocument DeserializeXNode(System.String, System.String, Boolean, Boolean)`
**Return Type:** `XDocument`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `String` | No | `` |  |
| `deserializeRootElementName` | `String` | No | `` |  |
| `writeArrayAttribute` | `Boolean` | No | `` |  |
| `encodeSpecialCharacters` | `Boolean` | No | `` |  |

---

## Properties

### DefaultSettings (static)

**Type:** `Func`1` (read/write)

**Description:** Gets or sets a function that creates default .
            Default settings are automatically used by serialization methods on ,
            and  and  on .
            To serialize without using any default settings create a  with
            .

---