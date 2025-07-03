# DefaultContractResolver Class

**Namespace:** `Newtonsoft.Json.Serialization`
**Full Name:** `Newtonsoft.Json.Serialization.DefaultContractResolver`
- **Implements:** `Newtonsoft.Json.Serialization.IContractResolver`

Used by  to resolves a  for a given .

## Methods

### get_DynamicCodeGeneration

**Signature:** `Boolean get_DynamicCodeGeneration()`
**Return Type:** `Boolean`

---

### get_DefaultMembersSearchFlags

**Signature:** `System.Reflection.BindingFlags get_DefaultMembersSearchFlags()`
**Return Type:** `BindingFlags`

---

### set_DefaultMembersSearchFlags

**Signature:** `Void set_DefaultMembersSearchFlags(System.Reflection.BindingFlags)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `BindingFlags` | No | `` |  |

---

### get_SerializeCompilerGeneratedMembers

**Signature:** `Boolean get_SerializeCompilerGeneratedMembers()`
**Return Type:** `Boolean`

---

### set_SerializeCompilerGeneratedMembers

**Signature:** `Void set_SerializeCompilerGeneratedMembers(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_IgnoreSerializableInterface

**Signature:** `Boolean get_IgnoreSerializableInterface()`
**Return Type:** `Boolean`

---

### set_IgnoreSerializableInterface

**Signature:** `Void set_IgnoreSerializableInterface(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_IgnoreSerializableAttribute

**Signature:** `Boolean get_IgnoreSerializableAttribute()`
**Return Type:** `Boolean`

---

### set_IgnoreSerializableAttribute

**Signature:** `Void set_IgnoreSerializableAttribute(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_IgnoreIsSpecifiedMembers

**Signature:** `Boolean get_IgnoreIsSpecifiedMembers()`
**Return Type:** `Boolean`

---

### set_IgnoreIsSpecifiedMembers

**Signature:** `Void set_IgnoreIsSpecifiedMembers(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_IgnoreShouldSerializeMembers

**Signature:** `Boolean get_IgnoreShouldSerializeMembers()`
**Return Type:** `Boolean`

---

### set_IgnoreShouldSerializeMembers

**Signature:** `Void set_IgnoreShouldSerializeMembers(Boolean)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `Boolean` | No | `` |  |

---

### get_NamingStrategy

**Signature:** `Newtonsoft.Json.Serialization.NamingStrategy get_NamingStrategy()`
**Return Type:** `NamingStrategy`

---

### set_NamingStrategy

**Signature:** `Void set_NamingStrategy(Newtonsoft.Json.Serialization.NamingStrategy)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `value` | `NamingStrategy` | No | `` |  |

---

### ResolveContract

**Signature:** `Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type)`
**Return Type:** `JsonContract`

**Description:** Resolves the contract for a given type.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `type` | `Type` | No | `` | The type to resolve a contract for. |

**Returns:** The contract for a given type.

---

### GetResolvedPropertyName

**Signature:** `System.String GetResolvedPropertyName(System.String)`
**Return Type:** `String`

**Description:** Gets the resolved name of the property.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `propertyName` | `String` | No | `` | Name of the property. |

**Returns:** Name of the property.

---

## Properties

### DynamicCodeGeneration

**Type:** `Boolean` (read-only)

**Description:** Gets a value indicating whether members are being get and set using dynamic code generation.
            This value is determined by the runtime permissions available.

---

### DefaultMembersSearchFlags

**Type:** `BindingFlags` (read/write)

---

### SerializeCompilerGeneratedMembers

**Type:** `Boolean` (read/write)

**Description:** Gets or sets a value indicating whether compiler generated members should be serialized.

---

### IgnoreSerializableInterface

**Type:** `Boolean` (read/write)

---

### IgnoreSerializableAttribute

**Type:** `Boolean` (read/write)

---

### IgnoreIsSpecifiedMembers

**Type:** `Boolean` (read/write)

---

### IgnoreShouldSerializeMembers

**Type:** `Boolean` (read/write)

---

### NamingStrategy

**Type:** `NamingStrategy` (read/write)

**Description:** Gets or sets the naming strategy used to resolve how property names and dictionary keys are serialized.

---