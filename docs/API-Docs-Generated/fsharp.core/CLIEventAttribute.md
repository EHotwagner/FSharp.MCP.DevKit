# CLIEventAttribute Class

**Namespace:** `Microsoft.FSharp.Core`
**Full Name:** `Microsoft.FSharp.Core.CLIEventAttribute`
- **Base Type:** `System.Attribute`

Adding this attribute to a property with event type causes it to be compiled with as a CLI
 metadata event, through a syntactic translation to a pair of 'add_EventName' and 
 'remove_EventName' methods.