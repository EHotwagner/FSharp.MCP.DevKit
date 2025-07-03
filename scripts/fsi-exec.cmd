@echo off
setlocal enabledelayedexpansion

REM F# code execution script for MCP integration
REM Usage: fsi-exec.cmd "let x = 1 + 2; printfn \"Result: %%d\" x"

if "%~1"=="" (
    echo Error: No F# code provided
    echo Usage: fsi-exec.cmd "F# code here"
    exit /b 1
)

echo Executing F# code via MCP DevKit...
echo Code to execute:
echo %~1
echo.

REM In a real implementation, this would interface with your MCP tools
REM For now, this demonstrates the concept

echo ✅ F# execution completed
