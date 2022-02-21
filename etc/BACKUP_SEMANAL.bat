@echo off

rem Printa as instrucoes de Backup Semanal.
echo.
echo BACKUP SEMANAL  [ C:\APPS\B3\JANITOR\BIN\BACKUP_SEMANAL.BAT ]
echo.
echo.

call C:\Apps\Command\branco.bat
echo  *********************************************
echo  **  ATENCAO:  LIMPAR  DESTINO  \DOWNLOADS  **
echo  *********************************************
echo.
echo     PRINT DESKTOP  [ PRINTSCREEN ]  C/  POST-IT
echo.
echo     EXPORTAR FAVORITOS  CHROME,  EDGE E FIREFOX
echo.
echo     EXPORTAR SETTINGS DAS FERRAMENTAS JETBRAINS
echo.
echo     FECHAR  MS OUTLOOK,  NOTEPAD++,  ENCRYPTPAD
echo.
echo.

pause
echo.
echo.

rem Executa rotina no diretorio temporario da estacao:
echo Posicionando no diretorio C:\Users\qdev\Downloads
cd /D C:\Users\qdev\Downloads

rem Obtem a data/hora atuais no formato AAAA-MM-DD:
set HOJE=%date:~-4%-%date:~3,2%-%date:~0,2%
echo Data de referencia para as movimentacoes:  %HOJE%
echo.

rem copia os arquivos de backup para o HD externo:

echo Copiando arquivos de favoritos dos browsers (Edge, Chrome, Firefox)...
move /Y "favoritos_*. html.html" E:\Cloud\Softeca\Web\Edge\favoritos\edge_bookmarks_%HOJE%.html
move /Y favoritos_*.html E:\Cloud\Softeca\Web\Chrome\favoritos\chrome_favoritos_%HOJE%.html
move /Y bookmarks.html E:\Cloud\Softeca\Web\Firefox\favoritos\firefox_bookmarks_%HOJE%.html
echo.

rem mkdir E:\Cloud\OneNotes\%HOJE%
rem move /Y *.7z E:\Cloud\OneNotes\%HOJE%\

echo Copiando imagens de screenshot...
mkdir E:\Cloud\Softeca\Windows\Desktop\Screenshot_%HOJE%
move /Y *.png E:\Cloud\Softeca\Windows\Desktop\Screenshot_%HOJE%\
echo.

echo Copiando arquivos texto e documentos...
xcopy C:\Users\qdev\Documents\Encryptpad\*.* E:\Cloud\Documentos\Encryptpad\  /E /C /Q /H /R /Y
xcopy "C:\Users\qdev\Documents\My Kindle Content\*.*" E:\Cloud\eBooks\  /E /C /Q /H /R /Y
echo.

echo Copiando arquivos de email do MS Outlook...
xcopy "C:\Users\qdev\Documents\Arquivos do Outlook\*.pst"       "E:\Cloud\Documentos\Arquivos do Outlook\bk\"             /E /C /Q /H /R /Y
xcopy "C:\Users\qdev\AppData\Roaming\Microsoft\Assinaturas\*.*" "E:\Cloud\Documentos\Arquivos do Outlook\bk\Assinaturas"  /E /C /Q /H /R /Y
echo.

rem Exporta as variaveis de ambiente (system e user):
echo Copiando arquivos de backup do registry...
mkdir E:\Cloud\Softeca\Windows\Registry\Registry_%HOJE%
reg export "HKEY_CURRENT_USER\Environment" E:\Cloud\Softeca\Windows\Registry\Registry_%HOJE%\registry_user_env.reg /y
reg export "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" E:\Cloud\Softeca\Windows\Registry\Registry_%HOJE%\registry_system_env.reg /y
echo.

echo Copiando arquivos do PS Notes...
mkdir E:\Cloud\Softeca\3M\PSNotes_%HOJE%
xcopy C:\Users\qdev\AppData\Roaming\3M\PSNotes\*.* E:\Cloud\Softeca\3M\PSNotes_%HOJE%  /E /C /Q /H /R /Y
echo.

echo Copiando arquivos de configuração do MS Visual Studio Code...
xcopy C:\Users\qdev\AppData\Roaming\Code\User\*.* E:\Cloud\Softeca\Windows\VS-Code\User\  /E /C /Q /H /R /Y
echo.

echo Copiando pasta B3: Bolsa de Valores, Forex, ...
xcopy D:\B3\*.* E:\B3\  /E /C /Q /H /R /Y
echo.

rem Pausa final...
echo.
pause