@echo off
color F

rem Executa o build...
echo  *******************************************
echo  **  INICIANDO  COMPILACAO  DO  JANITOR.  **
echo  *******************************************
echo.

echo Posicionando no diretorio raiz do projeto
cd ..
echo.

echo Apagando a pasta de distribuicao para nova release [ \dist ]
rmdir /s /q dist  1>nul  2>&1
echo.

echo Criando nova estrutura para distribuir o pacote do executavel
mkdir dist          1>nul  2>&1
mkdir dist\bin      1>nul  2>&1
mkdir dist\lib      1>nul  2>&1
mkdir dist\logs     1>nul  2>&1
mkdir dist\scripts  1>nul  2>&1
echo.

echo Copiando para distribuicao os arquivos de resources e executaveis
rem copy bin\Release\*.*         dist\bin
copy src\batches\*.*         dist\bin
copy src\scripts\*.*         dist\scripts
rem copy src\resources\prod\*.*  dist\scripts
echo.

echo Compactando o build e gerando pacote de distribuicao da release [ ZIP ]
python -m zipfile -c janitor-1.0.zip dist\.
move janitor-1.0.zip dist\.  1>nul  2>&1
echo.


rem em seguida o deploy do JANITOR:
echo  ********************************************
echo  **  INICIANDO  IMPLANTACAO  DO  JANITOR.  **
echo  ********************************************
echo.

echo Posicionando no diretorio raiz da aplicacao
cd /d C:\Apps\B3\Janitor
echo.

echo Limpando as pastas temporarias da aplicacao
rem del /f /q logs\*.*  1>nul  2>&1
echo.

echo Posicionando no diretorio do projeto
cd /d D:\Workspace\C#\Janitor
echo.

echo Copiando os arquivos do projeto
xcopy dist\*.* C:\Apps\B3\Janitor  /E /C /Q /H /R /Y
echo.
