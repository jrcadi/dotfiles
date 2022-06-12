@echo off

set srcPath=%~dp0*.cs
set exePath=%~dp0%~n0.exe

set dllPaths=system.dll,system.drawing.dll,system.windows.forms.dll,system.io.dll,System.Reflection.dll

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /optimize+ /out:%exePath% %srcPath% /r:%dllPaths%


if %ERRORLEVEL% == 0 (
  goto SUCCESS
) 
echo %ERRORLEVEL%
pause

:SUCCESS
%exePath%

