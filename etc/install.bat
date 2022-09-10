@echo off
color F

echo Verificando a versao atual do Python no sistema
python --version
echo.

echo Verificando a versao atual do pip no sistema
pip --version
echo.

echo Atualizando o pip no sistema para evitar conflitos de versoes
python -m pip install --upgrade pip
echo.

echo Criando pasta do projeto
mkdir Janitor
echo.

echo Instalando ambiente virtual no projeto
python -m venv venv
echo.

echo Posicionando no diretorio raiz do projeto
cd Janitor
echo.

echo Ativando o ambiente virtual do projeto
call venv\Scripts\activate.bat
echo.

echo Instalando as dependencias do projeto no ambiente
@echo on
pip install -U setuptools
pip install -U wheel
pip install -U Pillow
pip install -U requests
pip install -U beautifulsoup4
pip install -U Send2Trash
pip install -U selenium
@echo off
echo.

echo Atualizando a lista de rdependencias do projeto [ requirements ]
python -m pip freeze > requirements.txt
echo.

rem Pausa final...
echo.
pause
