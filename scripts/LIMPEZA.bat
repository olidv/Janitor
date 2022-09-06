@echo off

rem DEL /F /S /Q %HOMEPATH%\Config~1\Temp\*.*
DEL /F /S /Q %WINDIR%\Temp\*.*
DEL /F /S /Q %WINDIR%\Prefetch\*.*

rem utiliza utilitario externo para limpar as lixeiras de todos os drivers.
nircmd emptybin

rem Pula uma linha para melhor legibilidade.
rem echo[
rem pause