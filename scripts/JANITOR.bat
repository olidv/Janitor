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
move /Y infinite\www\IBOVDia_*.csv D:\B3\Data\B3\Carteira_IBOV\2022_Mai-Ago\%HOJE%
echo.

echo Copiando Arquivos ZIP contendo cotacoes intraday da Bolsa B3...
move /Y infinite\www\TradeIntraday_*.zip D:\B3\Data\B3\Cotacoes_TRADEINTRADAY\2022\%HOJE%
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

echo Posicionando no diretorio da aplicacao Lothon:
cd /D C:\Apps\B3\Lothon\bin
call palpites.bat
echo.

echo Copiando Arquivos CSV de papites para projeto WWW-Lothon...
cd /D C:\Apps\B3\Lothon\bin\data\palpites
copy /Y *.csv D:\Workspace\Loto365\www-lothon\data
copy /Y *.csv D:\Workspace\Loto365\cdn.lothon\data\palpites
echo.


:endbat
rem Pausa final...
echo.
pause
