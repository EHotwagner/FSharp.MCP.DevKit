# ChannelsModule Class

**Namespace:** `Garnet.Composition`
**Full Name:** `Garnet.Composition.ChannelsModule`

## Methods

### IChannels.GetSender (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit] IChannels.GetSender[a](Garnet.Composition.IChannels)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `IChannels` | No | `` |  |

---

### IChannels.Send (static) (generic)

**Signature:** `Void IChannels.Send[a](Garnet.Composition.IChannels, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### IChannels.OnAll (static) (generic)

**Signature:** `System.IDisposable IChannels.OnAll[a](Garnet.Composition.IChannels, Microsoft.FSharp.Core.FSharpFunc`2[System.ReadOnlyMemory`1[a],Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `handler` | `FSharpFunc`2` | No | `` |  |

---

### IChannels.Publish (static) (generic)

**Signature:** `Void IChannels.Publish[a](Garnet.Composition.IChannels, a)`
**Return Type:** `Void`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `event` | `a` | No | `` |  |

---

### IChannels.OnAll (static) (generic)

**Signature:** `Microsoft.FSharp.Core.FSharpFunc`2[Microsoft.FSharp.Core.FSharpFunc`2[System.ReadOnlyMemory`1[a],Microsoft.FSharp.Core.Unit],System.IDisposable] IChannels.OnAll[a](Garnet.Composition.IChannels)`
**Return Type:** `FSharpFunc`2`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `IChannels` | No | `` |  |

---

### IChannels.On (static) (generic)

**Signature:** `System.IDisposable IChannels.On[a](Garnet.Composition.IChannels, Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `handle` | `FSharpFunc`2` | No | `` |  |

---

### IChannels.BufferOnAll (static) (generic)

**Signature:** `System.IDisposable IChannels.BufferOnAll[a](Garnet.Composition.IChannels, Garnet.Composition.IChannels, Microsoft.FSharp.Core.FSharpFunc`2[System.ReadOnlyMemory`1[a],Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `buffer` | `IChannels` | No | `` |  |
| `handler` | `FSharpFunc`2` | No | `` |  |

---

### IChannels.BufferOn (static) (generic)

**Signature:** `System.IDisposable IChannels.BufferOn[a](Garnet.Composition.IChannels, Garnet.Composition.IChannels, Microsoft.FSharp.Core.FSharpFunc`2[a,Microsoft.FSharp.Core.Unit])`
**Return Type:** `IDisposable`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `buffer` | `IChannels` | No | `` |  |
| `handle` | `FSharpFunc`2` | No | `` |  |

---

### Channel`1.Wait (static) (generic)

**Signature:** `Garnet.Composition.Wait Channel`1.Wait[a](Garnet.Composition.Channel`1[a], a)`
**Return Type:** `Wait`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `Channel`1` | No | `` |  |
| `msg` | `a` | No | `` |  |

---

### IChannels.Wait (static) (generic)

**Signature:** `Garnet.Composition.Wait IChannels.Wait[a](Garnet.Composition.IChannels, a)`
**Return Type:** `Wait`

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `c` | `IChannels` | No | `` |  |
| `msg` | `a` | No | `` |  |

---