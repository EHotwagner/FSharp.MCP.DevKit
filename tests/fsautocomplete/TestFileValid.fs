// Test file with valid F# code for FsAutoComplete testing
module TestFileValid

open System
open System.Collections.Generic

// Valid function definitions
let add x y = x + y

let multiply x y = x * y

// Valid type definitions
type Person =
    { Name: string
      Age: int
      Email: string option }

// Valid pattern matching
let describeAge age =
    match age with
    | x when x < 13 -> "Child"
    | x when x < 20 -> "Teenager"
    | x when x < 65 -> "Adult"
    | _ -> "Senior"

// Valid recursive function
let rec factorial n =
    if n <= 1 then 1 else n * factorial (n - 1)

// Valid higher-order functions
let numbers = [ 1; 2; 3; 4; 5 ]

let evenNumbers =
    numbers |> List.filter (fun x -> x % 2 = 0) |> List.map (fun x -> x * x)

// Valid async computation
let fetchDataAsync () =
    async {
        do! Async.Sleep(100)
        return "Hello, World!"
    }

// Valid computation expression
let createPerson name age email =
    if String.IsNullOrWhiteSpace(name) then
        None
    elif age < 0 then
        None
    else
        Some
            { Name = name
              Age = age
              Email = email }
