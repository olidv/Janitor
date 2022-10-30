@echo off
color E

rem Printa a apresentacao do deploy:
echo.
echo  DEPLOY DO JANITOR   [ D:\WORKSPACE\INFINITE\JANITOR\ETC\DEPLOY.BAT ]
echo.
echo.

echo  ********************************************
echo  **  INICIANDO  IMPLANTACAO  DO  JANITOR.  **
echo  ********************************************
echo.
echo.

echo Posicionando no diretorio raiz da aplicacao
mkdir C:\Apps\Infinite\Janitor  1>nul  2>&1
cd /d C:\Apps\Infinite\Janitor
echo.

echo Limpando as pastas temporarias da aplicacao
rem del /f /q logs\*.*  1>nul  2>&1
echo.

echo Posicionando no diretorio do projeto
cd /d D:\Workspace\Infinite\Janitor
echo.

echo Copiando os arquivos do projeto
xcopy dist\*.* C:\Apps\Infinite\Janitor  /E /C /Q /H /R /Y
copy /y D:\Workspace\Infinite\Janitor\src\resources\dev\*.* C:\Apps\Infinite\Janitor\bin
echo.

echo Disponibilizando release da aplicacao para producao
copy /y dist\*.zip D:\Publico
echo.

rem Pausa final...
echo.
pause
