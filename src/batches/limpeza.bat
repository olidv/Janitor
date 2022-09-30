@echo off

rem Excluindo arquivos de diretorios temporarios...
rem DEL /F /S /Q %HOMEPATH%\Config~1\Temp\*.*
DEL /F /S /Q %WINDIR%\Temp\*.*
DEL /F /S /Q %WINDIR%\Prefetch\*.*

rem Executando utilitario para limpar as lixeiras de todos os drivers...
nircmd emptybin

rem Pausa final...
echo.
pause
