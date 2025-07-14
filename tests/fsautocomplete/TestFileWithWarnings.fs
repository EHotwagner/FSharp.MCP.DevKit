// Test file with warnings for FsAutoComplete diagnostic testing
module TestFileWithWarnings

open System

// Unused value warning
let unusedValue = "This value is never used"

// Unused function warning
let unusedFunction x = x * 2

// Missing pattern match cases (warning)
type Color =
    | Red
    | Green
    | Blue

let getColorName color =
    match color with
    | Red -> "red"
    | Green -> "green"
// Missing Blue case - generates warning

// Variable shadowing warning
let shadowingExample () =
    let x = 1
    let x = 2 // Warning: variable shadowing
    x

// Incomplete pattern match with option
let optionPatternMatch opt =
    match opt with
    | Some value -> value
// Missing None case - warning

// Deprecated attribute usage
[<System.Obsolete>]
let oldStyleFunction () = "deprecated"

// Using mutable when immutable would work
let mutableUsage () =
    let mutable x = 1
    x // Warning: mutable variable never mutated
