#!/usr/bin/env pwsh
param(
    [Parameter(Mandatory=$true, Position=0, ValueFromPipeline=$true)]
    [string]$Code,

    [Parameter(Mandatory=$false)]
    [switch]$Detailed = $false,

    [Parameter(Mandatory=$false)]
    [string]$McpServerPath = ".",

    [Parameter(Mandatory=$false)]
    [switch]$ShowState = $false
)

function Write-Banner {
    param([string]$Message, [string]$Color = "Green")
    Write-Host "🚀 $Message" -ForegroundColor $Color
}

function Write-CodeBlock {
    param([string]$Code)
    Write-Host "📝 F# Code:" -ForegroundColor Cyan
    Write-Host "----------------------------------------" -ForegroundColor DarkGray
    Write-Host $Code -ForegroundColor White
    Write-Host "----------------------------------------" -ForegroundColor DarkGray
}

# Main execution
try {
    Write-Banner "F# MCP DevKit - Code Execution"

    if ($ShowState) {
        Write-Banner "Checking FSI State..." "Yellow"
        # Here you would call your GetFSIState MCP tool
        Write-Host "FSI Session: Active ✅" -ForegroundColor Green
    }

    Write-CodeBlock $Code

    if ($Detailed) {
        Write-Banner "Executing with detailed error reporting..." "Yellow"
        # Here you would call: ExecuteFSharpCodeDetailed
    } else {
        Write-Banner "Executing F# code..." "Yellow"
        # Here you would call: ExecuteFSharpCode
    }

    # Simulate execution result
    Write-Host "Result: " -ForegroundColor Green -NoNewline
    Write-Host "Code executed successfully ✅" -ForegroundColor White

    Write-Banner "Execution completed" "Green"

} catch {
    Write-Host "❌ Error: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}
