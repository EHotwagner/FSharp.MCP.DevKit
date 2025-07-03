# WebExtensions Class

**Namespace:** `Microsoft.FSharp.Control`
**Full Name:** `Microsoft.FSharp.Control.WebExtensions`

A module of extension members providing asynchronous operations for some basic Web operations.

## Methods

### AsyncGetResponse (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Net.WebResponse] AsyncGetResponse(System.Net.WebRequest)`
**Return Type:** `FSharpAsync`1`

**Description:** Returns an asynchronous computation that, when run, will wait for a response to the given WebRequest.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `` | `WebRequest` | No | `` |  |

**Returns:** An asynchronous computation that waits for response to the WebRequest.

---

### AsyncDownloadString (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.String] AsyncDownloadString(System.Net.WebClient, System.Uri)`
**Return Type:** `FSharpAsync`1`

**Description:** Returns an asynchronous computation that, when run, will wait for the download of the given URI.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `WebClient` | No | `` |  |
| `address` | `Uri` | No | `` | The URI to retrieve. |

**Returns:** An asynchronous computation that will wait for the download of the URI.

---

### AsyncDownloadData (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[System.Byte[]] AsyncDownloadData(System.Net.WebClient, System.Uri)`
**Return Type:** `FSharpAsync`1`

**Description:** Returns an asynchronous computation that, when run, will wait for the download of the given URI.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `WebClient` | No | `` |  |
| `address` | `Uri` | No | `` | The URI to retrieve. |

**Returns:** An asynchronous computation that will wait for the download of the URI.

---

### AsyncDownloadFile (static)

**Signature:** `Microsoft.FSharp.Control.FSharpAsync`1[Microsoft.FSharp.Core.Unit] AsyncDownloadFile(System.Net.WebClient, System.Uri, System.String)`
**Return Type:** `FSharpAsync`1`

**Description:** Returns an asynchronous computation that, when run, will wait for the download of the given URI to specified file.

**Parameters:**
| Parameter | Type | Optional | Default | Description |
|-----------|------|----------|---------|-------------|
| `this` | `WebClient` | No | `` |  |
| `address` | `Uri` | No | `` | The URI to retrieve. |
| `fileName` | `String` | No | `` | The file name to save download to. |

**Returns:** An asynchronous computation that will wait for the download of the URI to specified file.

---