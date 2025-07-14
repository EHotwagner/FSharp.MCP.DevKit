// Test file with intentional type errors for FsAutoComplete diagnostic testing
module TestFileWithErrors

open System

// Type mismatch error: trying to add int and string
let typeError1 =
    let x = 42
    let y = "hello"
    x + y // Error: The type 'string' does not match the type 'int'

// Undefined function error
let undefinedFunctionError = someUndefinedFunction 123 // Error: The value or constructor 'someUndefinedFunction' is not defined

// Type annotation mismatch
let typeAnnotationError: string = 42 // Error: This expression was expected to have type 'string' but here has type 'int'

// Pattern matching incompleteness (should generate warning)
let incompletePatternMatch x =
    match x with
    | Some value -> value
// Missing None case - should generate warning

// Recursive function without proper termination condition
let rec infiniteRecursion x = infiniteRecursion (x + 1) // Warning: possible infinite recursion

// Using deprecated function
[<System.Obsolete("This function is deprecated")>]
let deprecatedFunction () = "old"

let usingDeprecatedFunction () = deprecatedFunction () // Warning: deprecated usage
