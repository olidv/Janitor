@echo off
color 4F

rem verifica se os releases estao disponiveis para deploy:
:clocker
if not exist \\BLACK\clocker-1.0.zip goto janitor
cd /D C:\Apps\Infinite\Clocker
copy /Y \\BLACK\clocker-1.0.zip C:\Apps\Infinite\Clocker
7z x -y clocker-1.0.zip

:janitor
if not exist \\BLACK\janitor-1.0.zip goto colethon
cd /D C:\Apps\Infinite\Janitor
copy /Y \\BLACK\janitor-1.0.zip C:\Apps\Infinite\Janitor
7z x -y janitor-1.0.zip

:colethon
if not exist \\BLACK\colethon-1.0.zip goto lothon
cd /D C:\Apps\Infinite\Colethon
copy /Y \\BLACK\colethon-1.0.zip C:\Apps\Infinite\Colethon
7z x -y colethon-1.0.zip

:lothon
if not exist \\BLACK\lothon-1.0.zip goto quanthon
cd /D C:\Apps\Infinite\Lothon
copy /Y \\BLACK\lothon-1.0.zip C:\Apps\Infinite\Lothon
7z x -y lothon-1.0.zip

:quanthon
if not exist \\BLACK\quanthon-1.0.zip goto endbat
cd /D C:\Apps\Infinite\Quanthon
copy /Y \\BLACK\quanthon-1.0.zip C:\Apps\Infinite\Quanthon
7z x -y quanthon-1.0.zip

:endbat
rem Pausa final...
echo.
pause
