module SimpleTest

let x = 42
let y = "hello"
let z = x + 1

type Person = { Name: string; Age: int }

let createPerson name age = { Name = name; Age = age }

// Test with an error
let errorTest = x + y // Type error: int + string
