@echo off

rem Printa a apresentacao do Janitor.
echo.
echo  JANITOR   [ C:\APPS\B3\JANITOR\BIN\JANITOR.BAT ]
echo.
echo.

rem verifica se o flag indicativo de processamento existe:
if exist D:\Publico\infinite\safeToDelete.tmp goto yesfile

:nofile
color C
echo  ************************************************
echo  ** ATENCAO: FLAG safeToDelete NAO ENCONTRADO! **
echo  ************************************************
echo  **    ESTA  ROTINA  BATCH  SERA  ABORTADA.    **
echo  ************************************************
echo.
goto endbat

:yesfile
color B
echo  ************************************************
echo  **  FLAG OK: ARQUIVO safeToDelete ENCONTRADO. **
echo  ************************************************
echo  **  PREPARANDO PARA MOVER ARQUIVOS COLETADOS  **
echo  ************************************************
echo.
echo.

pause
echo.
echo.

echo Posicionando no diretorio D:\Publico
cd /D D:\Publico

rem Obtem a data/hora atuais no formato AAAA-MM-DD:
set YYYY=%date:~-4%
set HOJE=%date:~-4%-%date:~3,2%
echo Data de referencia para as movimentacoes:  %HOJE%
echo.

rem primeiro tem q verificar se houve avisos ou erros nos processamentos:
echo Verificando se houve algum erro ou alerta nos processamentos:
echo ********************  ALERTAS  ********************    > infinite\findWarnError.tmp 2>&1
echo ***************************************************   >> infinite\findWarnError.tmp 2>&1
find /N "WARN" genial\mql5_logs\*.*                        >> infinite\findWarnError.tmp 2>&1
find /N "WARN" genial\terminal_logs\*.*                    >> infinite\findWarnError.tmp 2>&1
find /N "WARN" modal\mql5_logs\*.*                         >> infinite\findWarnError.tmp 2>&1
find /N "WARN" modal\terminal_logs\*.*                     >> infinite\findWarnError.tmp 2>&1
find /N "WARN" xm\mql5_logs\*.*                            >> infinite\findWarnError.tmp 2>&1
find /N "WARN" xm\terminal_logs\*.*                        >> infinite\findWarnError.tmp 2>&1
find /N "WARN" genial\mql5_logs\*.*                        >> infinite\findWarnError.tmp 2>&1
find /N "WARN" genial\terminal_logs\*.*                    >> infinite\findWarnError.tmp 2>&1
find /N "WARN" infinite\clock\clock.log                    >> infinite\findWarnError.tmp 2>&1
find /N "WARN" infinite\clock\clock-internal.log           >> infinite\findWarnError.tmp 2>&1
find /N "WARN" infinite\logs\infinite.log                  >> infinite\findWarnError.tmp 2>&1
echo.                                                      >> infinite\findWarnError.tmp 2>&1

echo.                                                      >> infinite\findWarnError.tmp 2>&1
echo *********************  ERROS  *********************   >> infinite\findWarnError.tmp 2>&1
echo ***************************************************   >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" genial\mql5_logs\*.*                       >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" genial\terminal_logs\*.*                   >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" modal\mql5_logs\*.*                        >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" modal\terminal_logs\*.*                    >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" xm\mql5_logs\*.*                           >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" xm\terminal_logs\*.*                       >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" genial\mql5_logs\*.*                       >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" genial\terminal_logs\*.*                   >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" infinite\clock\clock.log                   >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" infinite\clock\clock-internal.log          >> infinite\findWarnError.tmp 2>&1
find /N "ERROR" infinite\logs\infinite.log                 >> infinite\findWarnError.tmp 2>&1
echo.

echo Copiando Arquivos HTM contendo resultados das loterias da Caixa EF...
copy /y caixa\D_*.htm C:\Apps\B3\Lothon\data\caixa
move /Y caixa\D_*.htm D:\Workspace\Python\Lothon\data\caixa\
echo.
copy /Y infinite\www\D_*.csv C:\Apps\B3\Lothon\data\cache\
copy /Y infinite\www\D_*.csv D:\Workspace\Java\jLothon\data\cache\
move /Y infinite\www\D_*.csv D:\Workspace\Python\Lothon\data\cache\
echo.
copy /Y infinite\www\JC_*.csv C:\Apps\B3\Lothon\data\cache\
move /Y infinite\www\JC_*.csv D:\Workspace\Python\Lothon\data\cache\
echo.

echo Copiando Arquivos CSV contendo a carteira do IBOVESP da Bolsa B3...
move /Y infinite\www\IBOVDia_*.csv D:\B3\Data\B3\Carteira_IBOV\%YYYY%\%HOJE%
echo.

echo Copiando Arquivos ZIP contendo cotacoes intraday da Bolsa B3...
move /Y infinite\www\TradeIntraday_*.zip D:\B3\Data\B3\Cotacoes_TRADEINTRADAY\%YYYY%\%HOJE%
echo.

echo Copiando Arquivos de cotacoes e logging da corretora GENIAL...
move /Y genial\mql5_files\*.* D:\B3\Data\Brasil\Genial_BookTick\mql5_files
move /Y genial\mql5_logs\*.* D:\B3\Data\Brasil\Genial_BookTick\mql5_logs
move /Y genial\terminal_logs\*.* D:\B3\Data\Brasil\Genial_BookTick\terminal_logs
echo.

echo Copiando Arquivos de cotacoes e logging da corretora MODAL...
move /Y modal\mql5_files\*.* D:\B3\Data\Brasil\Modal_BookTick\mql5_files
move /Y modal\mql5_logs\*.* D:\B3\Data\Brasil\Modal_BookTick\mql5_logs
move /Y modal\terminal_logs\*.* D:\B3\Data\Brasil\Modal_BookTick\terminal_logs
echo.

echo Copiando Arquivos de cotacoes e logging da corretora XM...
move /Y xm\mql5_files\*.* D:\B3\Data\Exterior\XM_Tick\mql5_files
move /Y xm\mql5_logs\*.* D:\B3\Data\Exterior\XM_Tick\mql5_logs
move /Y xm\terminal_logs\*.* D:\B3\Data\Exterior\XM_Tick\terminal_logs
echo.

echo Copiando Arquivos LOG da aplicacao Infinite...
move /Y infinite\logs\*.* C:\Apps\B3\Infinite\logs
echo.

echo Copiando Arquivos LOG da aplicacao D-Clock...
move /Y infinite\clock\*.* C:\Apps\B3\Digital-Clock\logs
echo.

echo Removendo arquivo flag [safeToDelete.tmp]...
del /F /Q infinite\safeToDelete.tmp
echo.

@echo on
find /N "WARN"  infinite\findWarnError.tmp
find /N "ERROR" infinite\findWarnError.tmp
@echo off
echo.

rem Pausa antes de gerar os palpites do Lothon...
pause
echo.

echo Posicionando no diretorio da aplicacao Lothon para geracao de palpites:
cd /D C:\Apps\B3\Lothon\bin
call palpites.bat
echo.

echo Copiando Arquivos CSV de papites para projeto CDN-Lothon...
cd /D C:\Apps\B3\Lothon\data\palpite
copy /Y *.csv D:\Workspace\Loto365\cdn-lothon\data\palpites
echo.

echo Capturando as telas de consulta dos palpites da Web...
cd /D D:\Workspace\Loto365\cdn-lothon\data\palpites
shot_palpites.py
echo.

echo Reduzindo as imagens capturadas para tamanho de mobile...
cd /D D:\Workspace\Loto365\cdn-lothon\data\palpites
reduce_palpites.py
echo.

echo Efetuando commit do projeto CDN-Lothon no repositorio GitHub...
cd /D D:\Workspace\Loto365\cdn-lothon
git commit -am "Novos palpites gerados diariamente pelo Lothon."
git push origin main
echo.

rem TODO: A lib pydrive2 nao esta conseguindo acessar arquivos dentro de folders...
rem echo Efetuando upload dos arquivos de palpites para o Google Drive...
rem cd /D D:\Workspace\Loto365\cdn-lothon\data\palpites
rem upload_palpites.py
rem echo.

echo Cortando as imagens capturadas para o tamanho do video mobile...
cd /D D:\Workspace\Loto365\docs-templates\Video
del /F /Q *.txt *.png *.mp3 *.mp4
copy /Y D:\Workspace\Loto365\cdn-lothon\data\palpites\*.png .
crop_palpites.py
resize_palpites.py
echo.

echo Preparando recursos para criacao de video e publicacao nas redes sociais...
cd /D D:\Workspace\Loto365\docs-templates\Video
social_palpites.py
echo.

echo Executando Firefox para verificar Loto365.com.br e atualizar Redes Sociais...
cd /D D:\Workspace\Loto365\docs-templates\Video
start "" "C:\Program Files\Mozilla Firefox\firefox.exe" -url "https://www.Loto365.com.br/#palpites" "https://drive.google.com/drive/folders/1PjOJoHbueNMiNGKJHLP5tC7UEyuRRSvD" "https://web.whatsapp.com/" "https://web.telegram.org/z/#-1488280660" "https://twitter.com/compose/tweet" "https://www.tiktok.com/upload" "https://studio.youtube.com/channel/UCiiGBkWJiej2eAfwcqiI77A/videos/upload" "https://www.linkedin.com/company/85606564/admin/"
echo.


:endbat
rem Pausa final...
echo.
pause
