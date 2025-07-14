module DiagnosticTest

// Test file with intentional errors for diagnostic testing

let x = // syntax error - missing value

let y: int = "string" // type error

let z = undefinedFunction() // undefined symbol error

// Valid code
let validFunction a b = a + b
