namespace FSharp.MCP.DevKit.FsAutoComplete

open System.Text.Json.Serialization

/// Language Server Protocol types for communication with FsAutoComplete
module LspTypes =

    /// Position in a text document (0-based)
    type Position = { Line: int; Character: int }

    /// A range in a text document
    type Range = { Start: Position; End: Position }

    /// Text document identifier
    type TextDocumentIdentifier = { Uri: string }

    /// Versioned text document identifier
    type VersionedTextDocumentIdentifier = { Uri: string; Version: int }

    /// Text document position params
    type TextDocumentPositionParams =
        { TextDocument: TextDocumentIdentifier
          Position: Position }

    /// Diagnostic severity levels
    type DiagnosticSeverity =
        | Error = 1
        | Warning = 2
        | Information = 3
        | Hint = 4

    /// Diagnostic tags
    type DiagnosticTag =
        | Unnecessary = 1
        | Deprecated = 2

    /// Code description for diagnostics
    type CodeDescription = { Href: string }

    /// Diagnostic information
    type Diagnostic =
        { Range: Range
          Severity: DiagnosticSeverity option
          Code: string option
          CodeDescription: CodeDescription option
          Source: string option
          Message: string
          Tags: DiagnosticTag[] option
          RelatedInformation: DiagnosticRelatedInformation[] option
          Data: obj option }

    /// Related information for diagnostics
    and DiagnosticRelatedInformation = { Location: Location; Message: string }

    /// Location in source code
    and Location = { Uri: string; Range: Range }

    /// Publish diagnostics parameters
    type PublishDiagnosticsParams =
        { Uri: string
          Version: int option
          Diagnostics: Diagnostic[] }

    /// JSON-RPC request
    type JsonRpcRequest =
        { [<JsonPropertyName("jsonrpc")>]
          JsonRpc: string
          [<JsonPropertyName("id")>]
          Id: int
          [<JsonPropertyName("method")>]
          Method: string
          [<JsonPropertyName("params")>]
          Params: obj option }

    /// JSON-RPC notification (no id field)
    type JsonRpcNotification =
        { [<JsonPropertyName("jsonrpc")>]
          JsonRpc: string
          [<JsonPropertyName("method")>]
          Method: string
          [<JsonPropertyName("params")>]
          Params: obj option }

    /// JSON-RPC response
    type JsonRpcResponse =
        { [<JsonPropertyName("jsonrpc")>]
          JsonRpc: string
          [<JsonPropertyName("id")>]
          Id: int option
          [<JsonPropertyName("result")>]
          Result: obj option
          [<JsonPropertyName("error")>]
          Error: JsonRpcError option }

    /// JSON-RPC error
    and JsonRpcError =
        { [<JsonPropertyName("code")>]
          Code: int
          [<JsonPropertyName("message")>]
          Message: string
          [<JsonPropertyName("data")>]
          Data: obj option }

    /// Initialize parameters for LSP
    type InitializeParams =
        { ProcessId: int option
          RootPath: string option
          RootUri: string option
          InitializationOptions: obj option
          Capabilities: ClientCapabilities }

    /// Client capabilities
    and ClientCapabilities =
        { TextDocument: TextDocumentClientCapabilities option
          Workspace: WorkspaceClientCapabilities option }

    /// Text document client capabilities
    and TextDocumentClientCapabilities =
        { PublishDiagnostics: PublishDiagnosticsClientCapabilities option
          Synchronization: TextDocumentSyncClientCapabilities option
          Completion: CompletionClientCapabilities option
          Hover: HoverClientCapabilities option
          SignatureHelp: SignatureHelpClientCapabilities option
          Definition: DefinitionClientCapabilities option
          References: ReferenceClientCapabilities option
          DocumentHighlight: DocumentHighlightClientCapabilities option
          DocumentSymbol: DocumentSymbolClientCapabilities option
          CodeAction: CodeActionClientCapabilities option
          CodeLens: CodeLensClientCapabilities option
          Formatting: DocumentFormattingClientCapabilities option
          RangeFormatting: DocumentRangeFormattingClientCapabilities option
          OnTypeFormatting: DocumentOnTypeFormattingClientCapabilities option
          Rename: RenameClientCapabilities option
          DocumentLink: DocumentLinkClientCapabilities option }

    /// Workspace client capabilities
    and WorkspaceClientCapabilities =
        { ApplyEdit: bool option
          WorkspaceEdit: WorkspaceEditClientCapabilities option
          DidChangeConfiguration: DidChangeConfigurationClientCapabilities option
          DidChangeWatchedFiles: DidChangeWatchedFilesClientCapabilities option
          Symbol: WorkspaceSymbolClientCapabilities option
          ExecuteCommand: ExecuteCommandClientCapabilities option }

    /// Publish diagnostics client capabilities
    and PublishDiagnosticsClientCapabilities =
        { RelatedInformation: bool option
          TagSupport: PublishDiagnosticsTagSupport option
          VersionSupport: bool option
          CodeDescriptionSupport: bool option
          DataSupport: bool option }

    /// Publish diagnostics tag support
    and PublishDiagnosticsTagSupport = { ValueSet: DiagnosticTag[] }

    /// Text document sync client capabilities
    and TextDocumentSyncClientCapabilities =
        { DynamicRegistration: bool option
          WillSave: bool option
          WillSaveWaitUntil: bool option
          DidSave: bool option }

    /// Generic client capabilities
    and CompletionClientCapabilities = { DynamicRegistration: bool option }
    and HoverClientCapabilities = { DynamicRegistration: bool option }
    and SignatureHelpClientCapabilities = { DynamicRegistration: bool option }
    and DefinitionClientCapabilities = { DynamicRegistration: bool option }
    and ReferenceClientCapabilities = { DynamicRegistration: bool option }
    and DocumentHighlightClientCapabilities = { DynamicRegistration: bool option }
    and DocumentSymbolClientCapabilities = { DynamicRegistration: bool option }
    and CodeActionClientCapabilities = { DynamicRegistration: bool option }
    and CodeLensClientCapabilities = { DynamicRegistration: bool option }
    and DocumentFormattingClientCapabilities = { DynamicRegistration: bool option }
    and DocumentRangeFormattingClientCapabilities = { DynamicRegistration: bool option }
    and DocumentOnTypeFormattingClientCapabilities = { DynamicRegistration: bool option }
    and RenameClientCapabilities = { DynamicRegistration: bool option }
    and DocumentLinkClientCapabilities = { DynamicRegistration: bool option }
    and WorkspaceEditClientCapabilities = { DocumentChanges: bool option }
    and DidChangeConfigurationClientCapabilities = { DynamicRegistration: bool option }
    and DidChangeWatchedFilesClientCapabilities = { DynamicRegistration: bool option }
    and WorkspaceSymbolClientCapabilities = { DynamicRegistration: bool option }
    and ExecuteCommandClientCapabilities = { DynamicRegistration: bool option }

    /// Text document sync kind
    type TextDocumentSyncKind =
        | None = 0
        | Full = 1
        | Incremental = 2

    /// Did open text document params
    type DidOpenTextDocumentParams = { TextDocument: TextDocumentItem }

    /// Text document item
    and TextDocumentItem =
        { Uri: string
          LanguageId: string
          Version: int
          Text: string }

    /// Did change text document params
    type DidChangeTextDocumentParams =
        { TextDocument: VersionedTextDocumentIdentifier
          ContentChanges: TextDocumentContentChangeEvent[] }

    /// Text document content change event
    and TextDocumentContentChangeEvent =
        { Range: Range option
          RangeLength: int option
          Text: string }

    /// Did close text document params
    type DidCloseTextDocumentParams =
        { TextDocument: TextDocumentIdentifier }

    /// Hover result
    type Hover =
        { Contents: MarkupContent
          Range: Range option }

    /// Markup content
    and MarkupContent = { Kind: MarkupKind; Value: string }

    /// Markup kind
    and MarkupKind =
        | PlainText
        | Markdown

    /// Completion list
    type CompletionList =
        { IsIncomplete: bool
          Items: CompletionItem[] }

    /// Completion item
    and CompletionItem =
        { Label: string
          Kind: CompletionItemKind option
          Detail: string option
          Documentation: MarkupContent option
          Deprecated: bool option
          Preselect: bool option
          SortText: string option
          FilterText: string option
          InsertText: string option
          InsertTextFormat: InsertTextFormat option
          TextEdit: TextEdit option
          AdditionalTextEdits: TextEdit[] option
          CommitCharacters: string[] option
          Command: Command option
          Data: obj option }

    /// Completion item kind
    and CompletionItemKind =
        | Text = 1
        | Method = 2
        | Function = 3
        | Constructor = 4
        | Field = 5
        | Variable = 6
        | Class = 7
        | Interface = 8
        | Module = 9
        | Property = 10
        | Unit = 11
        | Value = 12
        | Enum = 13
        | Keyword = 14
        | Snippet = 15
        | Color = 16
        | File = 17
        | Reference = 18
        | Folder = 19
        | EnumMember = 20
        | Constant = 21
        | Struct = 22
        | Event = 23
        | Operator = 24
        | TypeParameter = 25

    /// Insert text format
    and InsertTextFormat =
        | PlainText = 1
        | Snippet = 2

    /// Text edit
    and TextEdit = { Range: Range; NewText: string }

    /// Command
    and Command =
        { Title: string
          Command: string
          Arguments: obj[] option }

    /// Location link (for go to definition)
    type LocationLink =
        { OriginSelectionRange: Range option
          TargetUri: string
          TargetRange: Range
          TargetSelectionRange: Range }

    /// Definition result (can be Location, Location[], or LocationLink[])
    type DefinitionResult =
        | SingleLocation of Location
        | MultipleLocations of Location[]
        | LocationLinks of LocationLink[]
