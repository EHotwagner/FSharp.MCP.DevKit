// Test file for CodeLens functionality
// This file demonstrates how CodeLens can show references, implementations, etc.

module TestCodeLens

open System

// This function should have CodeLens showing references
let addNumbers x y = x + y

// This type should have CodeLens showing implementations
type Calculator =
    { Name: string
      Version: string }

    // This member should have CodeLens showing references
    member this.Add(a: int, b: int) = addNumbers a b

    // This member should have CodeLens showing references
    member this.Multiply(a: int, b: int) = a * b

// This should show references to Calculator type
let createCalculator name version = { Name = name; Version = version }

// These usages should show up in CodeLens for the functions above
let calculator = createCalculator "Basic" "1.0"
let result1 = calculator.Add(5, 3)
let result2 = calculator.Multiply(4, 6)
let result3: int = addNumbers 10 20

// This interface should show implementations
type IProcessor =
    abstract Process: string -> string

// This should show up as implementation of IProcessor
type StringProcessor() =
    interface IProcessor with
        member this.Process(input: string) = input.ToUpper()

// Usage of the interface
let processor: IProcessor = StringProcessor()
let processed = processor.Process("hello world")

printfn "Calculator: %s v%s" calculator.Name calculator.Version
printfn "Results: %d, %d, %d" result1 result2 result3
printfn "Processed: %s" processed
