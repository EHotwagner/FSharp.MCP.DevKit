// Simple CodeLens test
module CodeLensTest

let testFunction x = x + 1

let anotherFunction () = testFunction 42

// This should show reference count for testFunction
let usage = testFunction 5
