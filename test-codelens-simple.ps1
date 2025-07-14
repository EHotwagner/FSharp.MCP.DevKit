# Simple CodeLens test script
Write-Host "Testing CodeLens with our fixes..." -ForegroundColor Green

# Create the test file path
$testFile = (Get-Item "tests\fsautocomplete\TestCodeLens.fsx").FullName

# Create MCP request
$request = @{
    jsonrpc = "2.0"
    id      = 1
    method  = "tools/call"
    params  = @{
        name      = "GetCodeLens"
        arguments = @{
            filePath       = $testFile
            timeoutSeconds = 30
        }
    }
} | ConvertTo-Json -Depth 5

Write-Host "Sending request for file: $testFile" -ForegroundColor Cyan
Write-Host "Request: $request" -ForegroundColor Yellow

# Send to MCP server and capture response
$response = $request | .\src\FSharp.MCP.DevKit.Server\bin\Debug\net10.0\FSharp.MCP.DevKit.exe 2>&1

Write-Host "`nResponse:" -ForegroundColor Green
$response | ForEach-Object { Write-Host $_ }

Write-Host "`nCodeLens test completed." -ForegroundColor Green
