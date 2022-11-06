@echo off
color 4F

rem Printa as instrucoes da rotina de deploy na estacao de producao:
echo.
echo DEPLOY PROD  [ C:\APPS\INFINITE\JANITOR\BIN\DEPLOY_PROD.BAT ]
echo.
echo.

echo  ******************************************************
echo  **  ATENCAO: FECHAR APLICATIVOS  CLOCKER,  JANITOR  **
echo  ******************************************************
echo.

pause
echo.
echo.

rem verifica se os releases estao disponiveis para deploy:
:clocker
if not exist \\BLACK\Publico\clocker-1.0.zip goto janitor
cd /D C:\Apps\Infinite\Clocker
move /Y \\BLACK\Publico\clocker-1.0.zip C:\Apps\Infinite\Clocker
7z x -y clocker-1.0.zip

:janitor
if not exist \\BLACK\Publico\janitor-1.0.zip goto colethon
cd /D C:\Apps\Infinite\Janitor
move /Y \\BLACK\Publico\janitor-1.0.zip C:\Apps\Infinite\Janitor
7z x -y janitor-1.0.zip

:colethon
if not exist \\BLACK\Publico\colethon-1.0.zip goto lothon
cd /D C:\Apps\Infinite\Colethon
move /Y \\BLACK\Publico\colethon-1.0.zip C:\Apps\Infinite\Colethon
7z x -y colethon-1.0.zip

:lothon
if not exist \\BLACK\Publico\lothon-1.0.zip goto quanthon
cd /D C:\Apps\Infinite\Lothon
move /Y \\BLACK\Publico\lothon-1.0.zip C:\Apps\Infinite\Lothon
7z x -y lothon-1.0.zip

:quanthon
if not exist \\BLACK\Publico\quanthon-1.0.zip goto endbat
cd /D C:\Apps\Infinite\Quanthon
move /Y \\BLACK\Publico\quanthon-1.0.zip C:\Apps\Infinite\Quanthon
7z x -y quanthon-1.0.zip

:endbat
rem Pausa final...
echo.
pause
