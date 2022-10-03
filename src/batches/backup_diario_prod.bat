@echo off
color 4F

rem Printa as instrucoes do Backup Diario da estacao de producao.
echo.
echo BACKUP DIARIO PROD  [ C:\APPS\INFINITE\JANITOR\BIN\BACKUP_DIARIO_PROD.BAT ]
echo.
echo.

echo  *********************************************
echo  **  ATENCAO:  SALVAR NA PASTA  \DOCUMENTS  **
echo  *********************************************
echo.
echo     FAVORITOS: GOOGLE CHROME,  MOZILLA FIREFOX
echo.
echo.

rem Obtem a data/hora atuais no formato AAAA-MM-DD:
set HOJE=%date:~-4%-%date:~3,2%-%date:~0,2%
echo Data de referencia para as movimentacoes:  %HOJE%
echo.

rem Executa rotina salvando tudo no diretorio temporario da estacao:
echo Criando pasta temporaria de backup:
set BKPRD=Publico\BK_PRD
mkdir C:\%BKPRD%\
echo.

echo Capturando copia da area de trabalho em imagem (print-screen)...
nircmd savescreenshotfull C:\%BKPRD%\Screenshot_%HOJE%.png
echo.

echo Exportando as variaveis de ambiente do Registry (System / User)...
reg export "HKEY_CURRENT_USER\Environment" C:\%BKPRD%\registry_user_env_%HOJE%.reg /y
reg export "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" C:\%BKPRD%\registry_system_env_%HOJE%.reg /y
echo.

echo Compactando e copiando conteudo da pasta Documentos: \Documents\*.*
7z a -t7z C:\%BKPRD%\Documents_%HOJE%.7z C:\Users\qdev\Documents
echo.

echo Compactando e copiando conteudo do 3M PS Notes: \AppData\Roaming\3M\PSNotes
7z a -t7z C:\%BKPRD%\PSNotes_%HOJE%.7z C:\Users\qdev\AppData\Roaming\3M\PSNotes
echo.

echo Compactando e copiando configuracao do MetaTrader: \AppData\Roaming\MetaQuotes\Terminal\
7z a -t7z C:\%BKPRD%\MT5_9AA5A2E564E1326FB93349159C9D30A4_%HOJE%.7z C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9AA5A2E564E1326FB93349159C9D30A4\config
7z a -t7z C:\%BKPRD%\MT5_9352866EDE8D3BAA5CDBEF2EC84D2C07_%HOJE%.7z C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9352866EDE8D3BAA5CDBEF2EC84D2C07\config
7z a -t7z C:\%BKPRD%\MT5_886B601D7760693D209A707150753C26_%HOJE%.7z C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\886B601D7760693D209A707150753C26\config
echo.

echo Compactando e copiando configuracao do OBS Studio: \AppData\Roaming\obs-studio\basic
7z a -t7z C:\%BKPRD%\OBSStudio_%HOJE%.7z C:\Users\qdev\AppData\Roaming\obs-studio\basic
echo.

rem Pausa final...
echo.
pause