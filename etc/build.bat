@echo off
color E

rem Printa a apresentacao do build.
echo.
echo  BUILD DO JANITOR   [ D:\WORKSPACE\C#\JANITOR\ETC\BUILD.BAT ]
echo.
echo.

echo  *******************************************
echo  **  INICIANDO  COMPILACAO  DO  JANITOR.  **
echo  *******************************************
echo.
echo.

echo Posicionando no diretorio raiz do projeto
cd ..
echo.

echo Ativando o ambiente virtual do projeto
call venv\Scripts\activate.bat
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

echo Atualizando a lista de dependencias do projeto [ requirements ]
python -m pip freeze > requirements.txt
copy requirements.txt dist\  
echo.

echo Apagando os arquivos de byte-code temporarios [ __pycache__ ]
forfiles /p .\src\scripts /s /m __pycache__ /c "cmd /c rmdir /s /q @file"  1>nul  2>&1
echo.

echo Copiando para distribuicao os arquivos de resources e executaveis
copy bin\Release\*.*         dist\bin\
copy src\batches\*.*         dist\bin\
copy src\resources\*.ico     dist\bin\
copy src\resources\prod\*.*  dist\bin\
copy src\scripts\*.*         dist\scripts\
echo.

echo Compactando o build e gerando pacote de distribuicao da release [ ZIP ]
python -m zipfile -c janitor-1.0.zip dist\.
move janitor-1.0.zip dist\.  1>nul  2>&1
echo.

rem Pausa final...
echo.
pause
