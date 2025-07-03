#!/usr/bin/env pwsh
param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string]$Code,

    [Parameter(Mandatory = $false)]
    [switch]$Detailed = $false,

    [Parameter(Mandatory = $false)]
    [string]$TerminalId = "default",

    [Parameter(Mandatory = $false)]
    [string]$SessionName = "",

    [Parameter(Mandatory = $false)]
    [int]$TerminalIndex = -1
)

# F# code execution script for MCP integration
# This script can be whitelisted for terminal auto-approval

Write-Host "Executing F# code via MCP DevKit..." -ForegroundColor Green

# Determine target session/terminal
$targetInfo = ""
if ($SessionName -ne "") {
    $targetInfo = "Session: $SessionName"
}
elseif ($TerminalIndex -ge 0) {
    $targetInfo = "Terminal Index: $TerminalIndex"
}
else {
    $targetInfo = "Terminal ID: $TerminalId"
}

Write-Host "Target: $targetInfo" -ForegroundColor Magenta

if ($Detailed) {
    # Use detailed execution for better error reporting
    Write-Host "Using detailed execution mode" -ForegroundColor Yellow
    # You would call your MCP tool here - this is a placeholder
    Write-Host "Code to execute:" -ForegroundColor Cyan
    Write-Host $Code
}
else {
    # Use standard execution
    Write-Host "Code to execute:" -ForegroundColor Cyan
    Write-Host $Code
}

# In a real implementation, this would call your MCP ExecuteFSharpCode tool
# For now, this demonstrates the concept
Write-Host "✅ F# execution completed" -ForegroundColor Green
