open System
open System.Diagnostics
open System.IO

let runCommand (command: string) (args: string) (input: string option) =
    let processStartInfo = ProcessStartInfo()
    processStartInfo.FileName <- command
    processStartInfo.Arguments <- args
    processStartInfo.RedirectStandardInput <- true
    processStartInfo.RedirectStandardOutput <- true
    processStartInfo.RedirectStandardError <- true
    processStartInfo.UseShellExecute <- false
    processStartInfo.CreateNoWindow <- true

    use proc = new Process()
    proc.StartInfo <- processStartInfo

    proc.Start() |> ignore

    input
    |> Option.iter (fun inputText ->
        use inputStream = proc.StandardInput
        inputStream.WriteLine(inputText))

    use outputStream = proc.StandardOutput
    let output = outputStream.ReadToEnd()

    use errorStream = proc.StandardError
    let errorOutput = errorStream.ReadToEnd()

    proc.WaitForExit()

    (output, errorOutput, proc.ExitCode)

// Example usage:
let scriptPath = Path.Combine(__SOURCE_DIRECTORY__, "InputTest.fsx")
let command = "dotnet"
let args = sprintf "fsi \"%s\"" scriptPath
let inputText = Some "Hello from the generic runner!"

let (output, error, exitCode) = runCommand command args inputText

printfn "Exit Code: %d" exitCode
printfn "Output:\n%s" output

if not (String.IsNullOrEmpty(error)) then
    printfn "Error Output:\n%s" error
