@echo off
color 4F

rem Printa as instrucoes do Backup Diario da estacao de desenvolvimento.
echo.
echo BACKUP DIARIO DEV  [ C:\APPS\INFINITE\JANITOR\BIN\BACKUP_DIARIO_DEV.BAT ]
echo.
echo.

echo  *********************************************
echo  **  ATENCAO:  SALVAR NA PASTA  \DOCUMENTS  **
echo  *********************************************
echo.
echo     FAVORITOS:  CHROME,  BRAVE,  EDGE, FIREFOX
echo.
echo     SETTINGS DAS IDEs PYHARM E INTELLIJ EM ZIP
echo.
echo     FECHAR OUTLOOK, JOPLIN, ENCRYPTPAD, KINDLE
echo.
echo.

rem Obtem a data/hora atuais no formato AAAA-MM-DD:
set HOJE=%date:~-4%-%date:~3,2%-%date:~0,2%
echo Data de referencia para as movimentacoes:  %HOJE%
echo.

rem Executa rotina salvando tudo no diretorio temporario da estacao:
echo Criando pastas temporarias de backup:
set BKDEV=_BACKUP\DEV_%HOJE%
set BKPRD=_BACKUP\PRD_%HOJE%
mkdir E:\%BKDEV%\
mkdir E:\%BKPRD%\
echo.

echo Minimiza todas as janelas correntes, para captura da area de trabalho...
powershell -command "(new-object -com shell.application).minimizeall()"
echo.

echo Capturando copia da area de trabalho em imagem (print-screen)...
nircmd savescreenshotfull E:\%BKDEV%\Screenshot_%HOJE%.png
echo.

echo Exportando as variaveis de ambiente do Registry (System / User)...
reg export "HKEY_CURRENT_USER\Environment" E:\%BKDEV%\registry_user_env_%HOJE%.reg /y
reg export "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" E:\%BKDEV%\registry_system_env_%HOJE%.reg /y
echo.

echo Compactando e copiando conteudo da pasta Documentos: \Documents\*.*
7z a -t7z E:\%BKDEV%\Documents_%HOJE%.7z C:\Users\qdev\Documents
echo.

echo Compactando e copiando conteudo do 3M PS Notes: \AppData\Roaming\3M\PSNotes
7z a -t7z E:\%BKDEV%\PSNotes_%HOJE%.7z C:\Users\qdev\AppData\Roaming\3M\PSNotes
echo.

echo Compactando e copiando conteudo do Joplin Notes: \.config\joplin-desktop
7z a -t7z E:\%BKDEV%\Joplin_%HOJE%.7z C:\Users\qdev\.config\joplin-desktop
echo.

echo Compactando e copiando configuracao do VS Code: \AppData\Roaming\Code\User
7z a -t7z E:\%BKDEV%\VSCode_%HOJE%.7z C:\Users\qdev\AppData\Roaming\Code\User
echo.

echo Compactando e copiando configuracao do MetaTrader: \AppData\Roaming\MetaQuotes\Terminal\
7z a -t7z E:\%BKDEV%\MT5_9AA5A2E564E1326FB93349159C9D30A4_%HOJE%.7z C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9AA5A2E564E1326FB93349159C9D30A4\config
7z a -t7z E:\%BKDEV%\MT5_9352866EDE8D3BAA5CDBEF2EC84D2C07_%HOJE%.7z C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9352866EDE8D3BAA5CDBEF2EC84D2C07\config
7z a -t7z E:\%BKDEV%\MT5_886B601D7760693D209A707150753C26_%HOJE%.7z C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\886B601D7760693D209A707150753C26\config
echo.

echo Compactando e copiando configuracao do OBS Studio: \AppData\Roaming\obs-studio\basic
7z a -t7z E:\%BKDEV%\OBSStudio_%HOJE%.7z C:\Users\qdev\AppData\Roaming\obs-studio\basic
echo.

rem verifica se o notebook dell (PRD) esta conectado e aguarda ele finalizar o backup:
if not exist \\BLUE\Publico\BK_PRD goto endbat
echo Aguardando 100 segundos para copiar backup do notebook Dell (PRD):
timeout /t 100 /nobreak
move /y \\BLUE\Publico\BK_PRD\*.* E:\%BKPRD%\
rem rmdir /s /q \\BLUE\Publico\BK_PRD
echo.

rem ao final, executa as aplicacoes que foram fechadas para o backup:
start "" "C:\Users\qdev\AppData\Local\Programs\Joplin\Joplin.exe"
start "" "C:\Program Files (x86)\3M\PSNLite\PsnLite.exe" -RegRun
start "" "E:\Cloud\Documentos\Nosso Lar.xls"

:endbat
rem Pausa final...
echo.
pause