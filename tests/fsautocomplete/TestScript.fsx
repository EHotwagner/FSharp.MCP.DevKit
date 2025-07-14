// F# Script file for testing FsAutoComplete with scripts
#r "nuget: Newtonsoft.Json"

open System
open Newtonsoft.Json

// Script-specific errors for testing
let scriptError1 =
    let x = 1
    let y = "test"
    x + y // Type error: cannot add int and string

// Using undefined function in script
let scriptError2 = unknownFunction 42

// Valid script code
let validScriptFunction x = x * 2

let data = {| Name = "Test"; Value = 123 |}
let json = JsonConvert.SerializeObject(data)

printfn "JSON: %s" json

// Pattern match with missing case
type ScriptType =
    | TypeA
    | TypeB
    | TypeC

let processType t =
    match t with
    | TypeA -> "A"
    | TypeB -> "B"
// Missing TypeC case
