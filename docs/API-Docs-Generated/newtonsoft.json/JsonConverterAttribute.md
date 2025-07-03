# JsonConverterAttribute Class

**Namespace:** `Newtonsoft.Json`
**Full Name:** `Newtonsoft.Json.JsonConverterAttribute`
- **Base Type:** `System.Attribute`

Instructs the  to use the specified  when serializing the member or class.

## Methods

### get_ConverterType

**Signature:** `System.Type get_ConverterType()`
**Return Type:** `Type`

---

### get_ConverterParameters

**Signature:** `System.Object[] get_ConverterParameters()`
**Return Type:** `Object[]`

---

## Properties

### ConverterType

**Type:** `Type` (read-only)

**Description:** Gets the  of the .

---

### ConverterParameters

**Type:** `Object[]` (read-only)

**Description:** The parameter list to use when constructing the  described by ConverterType.  
            If null, the default constructor is used.

---