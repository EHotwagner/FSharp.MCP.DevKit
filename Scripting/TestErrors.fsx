// Test file with intentional F# errors for testing diagnostics
let x: int = "hello" // Type error: string assigned to int
let y = undefinedVariable // Undefined variable error
let z = 5 / 0 // Mathematical issue that should be caught

// Function with type mismatch
let addNumbers (a: int) (b: int) : int = a + "world" // Type error: can't add int and string

// Missing parameter
let incompleteFunction () = someUndefinedFunction // Undefined function
