# NativePtrModule Class

**Namespace:** `Microsoft.FSharp.NativeInterop`
**Full Name:** `Microsoft.FSharp.NativeInterop.NativePtrModule`

Contains operations on native pointers. Use of these operators may
 result in the generation of unverifiable code.

## Methods

### OfNativeIntInlined (static) (generic)

**Signature:** `IntPtr OfNativeIntInlined[T](IntPtr)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### ToNativeIntInlined (static) (generic)

**Signature:** `IntPtr ToNativeIntInlined[T](IntPtr)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### OfVoidPtrInlined (static) (generic)

**Signature:** `IntPtr OfVoidPtrInlined[T](Void*)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `Void*` | No | `` |  |

---

### ToVoidPtrInlined (static) (generic)

**Signature:** `Void* ToVoidPtrInlined[T](IntPtr)`
**Return Type:** `Void*`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### OfILSigPtrInlined (static) (generic)

**Signature:** `IntPtr OfILSigPtrInlined[T](T*)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `T*` | No | `` |  |

---

### ToILSigPtrInlined (static) (generic)

**Signature:** `T* ToILSigPtrInlined[T](IntPtr)`
**Return Type:** `T*`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### ToByRefInlined (static) (generic)

**Signature:** `T& ToByRefInlined[T](IntPtr)`
**Return Type:** `T&`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### AddPointerInlined (static) (generic)

**Signature:** `IntPtr AddPointerInlined[T](IntPtr, Int32)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |
| `index` | `Int32` | No | `` |  |

---

### GetPointerInlined (static) (generic)

**Signature:** `T GetPointerInlined[T](IntPtr, Int32)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |
| `index` | `Int32` | No | `` |  |

---

### SetPointerInlined (static) (generic)

**Signature:** `Void SetPointerInlined[T](IntPtr, Int32, T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |
| `index` | `Int32` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### ReadPointerInlined (static) (generic)

**Signature:** `T ReadPointerInlined[T](IntPtr)`
**Return Type:** `T`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### WritePointerInlined (static) (generic)

**Signature:** `Void WritePointerInlined[T](IntPtr, T)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |
| `value` | `T` | No | `` |  |

---

### StackAllocate (static) (generic)

**Signature:** `IntPtr StackAllocate[T](Int32)`
**Return Type:** `IntPtr`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `count` | `Int32` | No | `` |  |

---

### NullPointer (static) (generic)

**Signature:** `IntPtr NullPointer[T]()`
**Return Type:** `IntPtr`

---

### IsNullPointer (static) (generic)

**Signature:** `Boolean IsNullPointer[T](IntPtr)`
**Return Type:** `Boolean`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### ClearPointerInlined (static) (generic)

**Signature:** `Void ClearPointerInlined[T](IntPtr)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |

---

### InitializeBlockInlined (static) (generic)

**Signature:** `Void InitializeBlockInlined[T](IntPtr, Byte, UInt32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `address` | `IntPtr` | No | `` |  |
| `value` | `Byte` | No | `` |  |
| `count` | `UInt32` | No | `` |  |

---

### CopyPointerInlined (static) (generic)

**Signature:** `Void CopyPointerInlined[T](IntPtr, IntPtr)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `destination` | `IntPtr` | No | `` |  |
| `source` | `IntPtr` | No | `` |  |

---

### CopyBlockInlined (static) (generic)

**Signature:** `Void CopyBlockInlined[T](IntPtr, IntPtr, Int32)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `destination` | `IntPtr` | No | `` |  |
| `source` | `IntPtr` | No | `` |  |
| `count` | `Int32` | No | `` |  |

---