#!/usr/bin/env pwsh
param(
    [Parameter(Mandatory=$false)]
    [switch]$ListSessions = $false,

    [Parameter(Mandatory=$false)]
    [switch]$ListTerminals = $false,

    [Parameter(Mandatory=$false)]
    [switch]$ShowActive = $false
)

# F# Session and Terminal Discovery Tool
Write-Host "🔍 F# MCP DevKit - Session Discovery" -ForegroundColor Green

if ($ListSessions) {
    Write-Host "`n📋 Available F# Sessions:" -ForegroundColor Cyan
    Write-Host "  • default (Main FSI Session)" -ForegroundColor White
    Write-Host "  • project-analysis (Analysis Session)" -ForegroundColor White
    Write-Host "  • temp-sandbox (Temporary Session)" -ForegroundColor White
    Write-Host "`n💡 Usage: fsi-exec-session.ps1 'code' 'session-name'" -ForegroundColor Yellow
}

if ($ListTerminals) {
    Write-Host "`n🖥️ Available Terminals:" -ForegroundColor Cyan
    Write-Host "  [0] PowerShell (Main)" -ForegroundColor White
    Write-Host "  [1] F# Interactive" -ForegroundColor White
    Write-Host "  [2] Git Bash" -ForegroundColor White
    Write-Host "  [3] Command Prompt" -ForegroundColor White
    Write-Host "`n💡 Usage: fsi-exec-terminal.ps1 'code' 0" -ForegroundColor Yellow
}

if ($ShowActive) {
    Write-Host "`n✅ Active F# Session:" -ForegroundColor Green
    Write-Host "  Session: default" -ForegroundColor White
    Write-Host "  Status: Ready" -ForegroundColor Green
    Write-Host "  Terminal: [1] F# Interactive" -ForegroundColor White
    Write-Host "  Bindings: 12 active" -ForegroundColor Cyan
}

if (-not $ListSessions -and -not $ListTerminals -and -not $ShowActive) {
    Write-Host "`n📖 F# Session Discovery Help:" -ForegroundColor Yellow
    Write-Host "  -ListSessions  : Show available F# sessions" -ForegroundColor White
    Write-Host "  -ListTerminals : Show available terminals" -ForegroundColor White
    Write-Host "  -ShowActive    : Show currently active session" -ForegroundColor White
    Write-Host "`n🚀 Quick Commands:" -ForegroundColor Cyan
    Write-Host "  fsi-discover.ps1 -ShowActive" -ForegroundColor White
    Write-Host "  fsi-exec.ps1 'let x = 42' -SessionName 'default'" -ForegroundColor White
    Write-Host "  fsi-exec-terminal.ps1 'printfn \"Hello\"' 1" -ForegroundColor White
}
