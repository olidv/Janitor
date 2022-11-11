@echo off
color 4F

rem Printa as instrucoes da rotina de deploy na estacao de producao:
echo.
echo DEPLOY PROD  [ C:\APPS\INFINITE\JANITOR\BIN\DEPLOY_PROD.BAT ]
echo.
echo.

echo  *****************************************************
echo  ** ATENCAO: ENCERRAR APLICATIVOS CLOCKER E JANITOR **
echo  *****************************************************
echo.

rem Tenta encerrar aplicacoes para evitar erro de conflitos durante o deploy...
taskkill /im Janitor.exe /t /f  1>nul  2>&1
taskkill /im Clocker.exe /t /f  1>nul  2>&1

echo Aguarda 30 segundos para encerrar completamente as aplicacoes:
timeout /t 30 /nobreak
echo.

rem verifica se os releases estao disponiveis para deploy:
:janitor
if not exist \\BLACK\Publico\janitor-1.0.zip goto clocker
echo Efetuando deploy do JANITOR...
cd /D C:\Apps\Infinite\Janitor
move /Y \\BLACK\Publico\janitor-1.0.zip C:\Apps\Infinite\Janitor
7z x -y janitor-1.0.zip
echo.

:clocker
if not exist \\BLACK\Publico\clocker-1.0.zip goto colethon
echo Efetuando deploy do CLOCKER...
cd /D C:\Apps\Infinite\Clocker
move /Y \\BLACK\Publico\clocker-1.0.zip C:\Apps\Infinite\Clocker
7z x -y clocker-1.0.zip
echo.

:colethon
if not exist \\BLACK\Publico\colethon-1.0.zip goto lothon
echo Efetuando deploy do COLETHON...
cd /D C:\Apps\Infinite\Colethon
move /Y \\BLACK\Publico\colethon-1.0.zip C:\Apps\Infinite\Colethon
7z x -y colethon-1.0.zip
echo.

:lothon
if not exist \\BLACK\Publico\lothon-1.0.zip goto quanthon
echo Efetuando deploy do LOTHON...
cd /D C:\Apps\Infinite\Lothon
move /Y \\BLACK\Publico\lothon-1.0.zip C:\Apps\Infinite\Lothon
7z x -y lothon-1.0.zip
echo.

:quanthon
if not exist \\BLACK\Publico\quanthon-1.0.zip goto endbat
echo Efetuando deploy do QUANTHON...
cd /D C:\Apps\Infinite\Quanthon
move /Y \\BLACK\Publico\quanthon-1.0.zip C:\Apps\Infinite\Quanthon
7z x -y quanthon-1.0.zip
echo.

:endbat
echo Aguarda 10 segundos para que o deploy seja finalizado:
timeout /t 10 /nobreak
echo.

echo Executando as aplicacoes que foram fechadas para o backup...
start "" "C:\Apps\Infinite\Janitor\bin\Janitor.exe"
start "" /max "C:\Apps\Infinite\Clocker\bin\Clocker.exe"
echo.

rem Pausa final...
pause
