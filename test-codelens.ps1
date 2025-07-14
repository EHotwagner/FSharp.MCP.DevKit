# Test CodeLens MCP Tools
# This script demonstrates the new CodeLens functionality

Write-Host "Testing CodeLens MCP Tools" -ForegroundColor Green
Write-Host "=========================" -ForegroundColor Green

$testFile = "tests\fsautocomplete\TestCodeLens.fsx"
$testFileFull = "$PWD\$testFile"

Write-Host "`nTesting with file: $testFile" -ForegroundColor Yellow

Write-Host "`n1. Starting FsAutoComplete..." -ForegroundColor Cyan
# Start FsAutoComplete (assuming MCP server is running)

Write-Host "`n2. Getting basic CodeLens information..." -ForegroundColor Cyan
Write-Host "Command: mcp call GetCodeLens --filePath `"$testFileFull`""

Write-Host "`n3. Getting detailed CodeLens with resolved commands..." -ForegroundColor Cyan
Write-Host "Command: mcp call GetDetailedCodeLens --filePath `"$testFileFull`""

Write-Host "`n4. Resolving specific CodeLens (index 0)..." -ForegroundColor Cyan
Write-Host "Command: mcp call ResolveCodeLens --filePath `"$testFileFull`" --codeLensIndex 0"

Write-Host "`n5. Testing with an F# source file with known references..." -ForegroundColor Cyan
$sourceFile = "tests\fsautocomplete\TestFileWithErrors.fs"
$sourceFileFull = "$PWD\$sourceFile"
Write-Host "Command: mcp call GetCodeLens --filePath `"$sourceFileFull`""

Write-Host "`nCodeLens Testing Commands:" -ForegroundColor Green
Write-Host "=========================" -ForegroundColor Green
Write-Host "Basic CodeLens:    mcp call GetCodeLens --filePath `"<filepath>`""
Write-Host "Detailed CodeLens: mcp call GetDetailedCodeLens --filePath `"<filepath>`""
Write-Host "Resolve CodeLens:  mcp call ResolveCodeLens --filePath `"<filepath>`" --codeLensIndex <index>"

Write-Host "`nCodeLens Features:" -ForegroundColor Green
Write-Host "- Shows references to functions, types, and members"
Write-Host "- Displays implementation counts for interfaces"
Write-Host "- Provides commands for navigation and analysis"
Write-Host "- Works with both .fs and .fsx files"
Write-Host "- Integrates with FsAutoComplete language server"

Write-Host "`nNote: Make sure FsAutoComplete is started and the project is loaded before running CodeLens commands." -ForegroundColor Yellow
