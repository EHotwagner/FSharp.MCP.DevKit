# CompilationMappingAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.CompilationMappingAttribute`
- **Base Type:** `System.Attribute`

This attribute is inserted automatically by the F# compiler to tag types 
 and methods in the generated CLI code with flags indicating the correspondence 
 with original source constructs.

## Methods

### get_SourceConstructFlags

**Signature:** `Microsoft.FSharp.Core.SourceConstructFlags get_SourceConstructFlags()`
**Return Type:** `SourceConstructFlags`

---

### get_SequenceNumber

**Signature:** `Int32 get_SequenceNumber()`
**Return Type:** `Int32`

---

### get_VariantNumber

**Signature:** `Int32 get_VariantNumber()`
**Return Type:** `Int32`

---

### get_TypeDefinitions

**Signature:** `System.Type[] get_TypeDefinitions()`
**Return Type:** `Type[]`

---

### get_ResourceName

**Signature:** `System.String get_ResourceName()`
**Return Type:** `String`

---

## Properties

### SourceConstructFlags

**Type:** `SourceConstructFlags` (read-only)

**Description:** Indicates the relationship between the compiled entity and F# source code

---

### SequenceNumber

**Type:** `Int32` (read-only)

**Description:** Indicates the sequence number of the entity, if any, in a linear sequence of elements with F# source code

---

### VariantNumber

**Type:** `Int32` (read-only)

**Description:** Indicates the variant number of the entity, if any, in a linear sequence of elements with F# source code

---

### TypeDefinitions

**Type:** `Type[]` (read-only)

**Description:** Indicates the type definitions needed to resolve the source construct

---

### ResourceName

**Type:** `String` (read-only)

**Description:** Indicates the resource the source construct relates to

---