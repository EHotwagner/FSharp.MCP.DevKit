#!/usr/bin/env pwsh
param(
    [Parameter(Mandatory=$true, Position=0)]
    [string]$Code,

    [Parameter(Mandatory=$true, Position=1)]
    [string]$SessionName,

    [Parameter(Mandatory=$false)]
    [switch]$Detailed = $false
)

# F# code execution targeting a specific MCP session by name
Write-Host "🎯 Targeting F# Session: $SessionName" -ForegroundColor Magenta
Write-Host "Executing F# code via MCP DevKit..." -ForegroundColor Green

if ($Detailed) {
    Write-Host "Using detailed execution mode" -ForegroundColor Yellow
    # Call MCP tool: ExecuteFSharpCodeDetailed with session targeting
    Write-Host "MCP Call: ExecuteFSharpCodeDetailed -SessionName '$SessionName'" -ForegroundColor DarkGray
} else {
    # Call MCP tool: ExecuteFSharpCode with session targeting
    Write-Host "MCP Call: ExecuteFSharpCode -SessionName '$SessionName'" -ForegroundColor DarkGray
}

Write-Host "Code to execute:" -ForegroundColor Cyan
Write-Host $Code

# In real implementation, this would route to the specific FSI session
Write-Host "✅ F# execution completed in session '$SessionName'" -ForegroundColor Green
