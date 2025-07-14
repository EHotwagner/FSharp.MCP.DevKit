# FsAutoComplete Request/Response Pattern Analysis

This document analyzes the issues with the current implementation of the Language Server Protocol (LSP) request/response handling for FsAutoComplete within the FSharp.MCP.DevKit.

## Problem Description

The existing tools for interacting with FsAutoComplete can successfully send requests (e.g., for hover information, completions, etc.) to the LSP server. However, the corresponding responses are not being received, cached, or processed. This makes the integration non-functional, as the client never gets the information it asks for.

The core of the issue seems to be in the mechanism that reads, parses, and correlates responses from the `fsautocomplete` process's standard output stream with the original requests sent via its standard input stream.

## Research and External Examples

To understand the correct approach, several existing and successful FsAutoComplete client implementations were reviewed:

* **Ionide-Vim / FsAutoComplete LSP Tests**: [https://github.com/ionide/FsAutoComplete/tree/main/test/FsAutoComplete.Tests.Lsp](https://github.com/ionide/FsAutoComplete/tree/main/test/FsAutoComplete.Tests.Lsp)
* **Vim-FSharp (Archive)**: [https://github.com/fsharp/zarchive-vim-fsharp](https://github.com/fsharp/zarchive-vim-fsharp)
* **Emacs F# Mode**: [https://github.com/fsharp/emacs-fsharp-mode](https://github.com/fsharp/emacs-fsharp-mode)
* **Ionide/FsAutoComplete Source**: [https://github.com/ionide/FsAutoComplete](https://github.com/ionide/FsAutoComplete)

### Key Findings from Research

1. **FsAutoComplete Test Infrastructure**: The official FsAutoComplete test suite uses a direct in-process approach via `AdaptiveFSharpLspServer`, not the external process communication pattern that our MCP DevKit is attempting.

2. **Successful LSP Communication Patterns**: Working LSP clients typically use:
   * **Separate Request/Response Correlation**: A dictionary or map to track pending requests by ID
   * **Background Message Reader**: A continuous loop reading from stdout that dispatches responses to waiting requests
   * **TaskCompletionSource Pattern**: Each outgoing request creates a `TaskCompletionSource` that gets completed when the corresponding response arrives
   * **UTF-8 Encoding Enforcement**: Explicit encoding configuration to prevent character corruption

3. **Microsoft LSP Documentation**: The Microsoft docs emphasize that LSP communication uses JSON-RPC 2.0 over streams, with strict content-length header requirements and proper encoding handling.

4. **Stream JsonRpc Libraries**: Most production LSP clients use libraries like `StreamJsonRpc` or similar to handle the low-level protocol details, rather than implementing the parsing manually.

## Analysis of the Current Implementation

The current implementation is split across several files:

* `src/FSharp.MCP.DevKit.FsAutoComplete/ProcessManager.fs`: Handles the lifecycle of the `fsautocomplete` process.
* `src/FSharp.MCP.DevKit.FsAutoComplete/LspCommunication.fs`: Manages the LSP message protocol, including sending requests and reading responses.
* `src/FSharp.MCP.DevKit.FsAutoComplete/FsAutoCompleteWrapper.fs`: Provides a higher-level API over the LSP communication.

### Key Observations

**Process Management**: The `ProcessManager` correctly starts the `fsautocomplete` process and redirects its standard I/O streams. However, it does not explicitly set UTF-8 encoding, which can cause issues on systems where UTF-8 is not the default.

**Request Sending**: `LspCommunication.SendRequest` correctly formats a JSON-RPC request, assigns a unique ID, and writes it to the process's standard input with proper Content-Length headers.

**Response Reading**: `LspCommunication.StartMessageReaderAsync` launches a background loop to read from the process's standard output. It correctly reads the `Content-Length` header and then the message body. However, there are several critical issues:

1. **Character Encoding**: The streams are not explicitly configured for UTF-8, which can lead to corruption
2. **Fragile Parsing**: The line-by-line reading approach is vulnerable to non-LSP output from the process
3. **No Response Correlation**: The current `WaitForResponseAsync` method uses a simple channel reader that may miss responses due to timing issues

**Response Handling**: Parsed messages are pushed into a `System.Threading.Channels.Channel`. The `WaitForResponseAsync` method attempts to pull a specific response from this channel based on its ID, but this approach is fundamentally flawed because:
* Multiple requests can be pending simultaneously
* Responses may arrive out of order
* The channel reading loop may miss the response if it arrives before the wait begins
* No cleanup mechanism for timed-out requests

**Wrapper Integration**: The `FsAutoCompleteWrapper` correctly orchestrates the process startup and LSP initialization, but it relies on the broken request/response mechanism in `LspCommunication`.

## Hypothesis on the Root Cause

Based on the analysis, the primary hypothesis is that **the request/response correlation mechanism is fundamentally broken** due to the following issues:

### 1. Race Condition in Response Waiting

The current `WaitForResponseAsync` method starts reading from the channel *after* the request is sent, creating a race condition where:
* The response might arrive and be processed by the background reader before `WaitForResponseAsync` starts listening
* The response gets consumed by the channel but never reaches the waiting caller
* This explains why requests appear to send successfully but responses are never received

### 2. Lack of Proper Request Tracking

The current implementation doesn't maintain a proper correlation between outgoing requests and their expected responses:
* No dictionary/map to track pending requests by ID
* No `TaskCompletionSource` pattern to wake up specific waiting threads
* No timeout handling for abandoned requests

### 3. Character Encoding Issues

The process streams are not explicitly configured for UTF-8 encoding:
* This can cause corruption in the Content-Length header parsing
* JSON message content may be corrupted, leading to parse failures
* The issue may be system-dependent (more likely on Windows systems with non-UTF-8 defaults)

### 4. Insufficient Error Handling

The current implementation lacks robust error handling for:
* Malformed LSP messages from the server
* Process crashes during communication
* Network-like timeouts in the communication layer

## Proposed Solution

To fix these issues, I propose a comprehensive refactoring of the LSP communication layer with the following changes:

### 1. Implement Proper Request/Response Correlation

**Replace the channel-based approach with a dictionary-based correlation system:**

```fsharp
type PendingRequest = {
    RequestId: int
    Method: string
    SentAt: DateTime
    CompletionSource: TaskCompletionSource<JsonRpcResponse>
}

// In LspCommunication class
let mutable pendingRequests = ConcurrentDictionary<int, PendingRequest>()
```

**When sending a request:**

1. Generate a unique request ID
2. Create a `TaskCompletionSource<JsonRpcResponse>`
3. Store it in the `pendingRequests` dictionary
4. Send the request
5. Return the `Task` from the `TaskCompletionSource`

**When receiving a response:**

1. Parse the response and extract the ID
2. Look up the corresponding `TaskCompletionSource` in `pendingRequests`
3. Complete the task with the response
4. Remove the entry from `pendingRequests`

### 2. Fix Character Encoding Issues

**Explicitly configure UTF-8 encoding in `ProcessManager.fs`:**

```fsharp
startInfo.StandardInputEncoding <- System.Text.Encoding.UTF8
startInfo.StandardOutputEncoding <- System.Text.Encoding.UTF8
startInfo.StandardErrorEncoding <- System.Text.Encoding.UTF8
```

### 3. Improve Stream Reading Robustness

**Enhance the message reading loop to handle:**
* Partial reads
* Non-LSP output (log it and continue)
* Encoding errors
* Process termination

### 4. Add Comprehensive Timeout Handling

**Implement a cleanup mechanism for timed-out requests:**
* Background timer to check for expired requests
* Configurable timeout per request type
* Proper disposal of `TaskCompletionSource` objects

### 5. Enhanced Error Handling and Logging

**Add detailed logging for:**
* All sent requests and received responses
* Parse errors with content snippets
* Correlation failures
* Timeout events

### 6. Alternative: Consider Using StreamJsonRpc

**For a more robust long-term solution, consider replacing the custom LSP implementation with Microsoft's `StreamJsonRpc` library:**
* Handles all the low-level protocol details
* Mature, well-tested implementation
* Built-in request/response correlation
* Automatic timeout handling
* Better error reporting

## Implementation Plan

1. **Phase 1: Fix Encoding Issues**
   * Update `ProcessManager.fs` to explicitly set UTF-8 encoding
   * Test with simple requests to see if this resolves some issues

2. **Phase 2: Implement Proper Correlation**
   * Refactor `LspCommunication.fs` to use the dictionary-based approach
   * Replace `WaitForResponseAsync` with proper `TaskCompletionSource` handling

3. **Phase 3: Add Timeout and Cleanup**
   * Implement background cleanup for timed-out requests
   * Add comprehensive error handling

4. **Phase 4: Enhanced Logging and Debugging**
   * Add detailed logging to help diagnose any remaining issues
   * Create test cases to verify the fix

5. **Phase 5: Consider StreamJsonRpc Migration**
   * Evaluate the effort required to migrate to `StreamJsonRpc`
   * Implement as a separate branch for comparison

## Test Verification Strategy

To verify the fix:

1. **Unit Tests**: Create tests that verify request/response correlation under various scenarios
2. **Integration Tests**: Test with actual FsAutoComplete processes
3. **Stress Tests**: Send multiple concurrent requests to verify correlation works under load
4. **Error Tests**: Test behavior when the process crashes or sends malformed responses

## Conclusion

The request/response correlation issue in the FsAutoComplete integration is primarily due to a race condition in the current channel-based response waiting mechanism, combined with character encoding issues. The proposed solution implements a proper correlation system using `TaskCompletionSource` and concurrent dictionaries, which should resolve the core issue and make the integration functional.

The fix is critical for making the MCP DevKit's FsAutoComplete tools usable, as currently they can send requests but never receive responses, rendering them effectively non-functional.
