@echo off

rem Printa a apresentacao do Janitor.
echo.
echo  JANITOR   [ C:\APPS\B3\JANITOR\BIN\JANITOR.BAT ]
echo.
echo.

rem verifica se o flag indicativo de processamento existe:
if exist D:\Publico\infinite\safeToDelete.tmp goto yesfile

:nofile
call C:\Apps\Command\vermelho.bat
echo  ************************************************
echo  ** ATENCAO: FLAG safeToDelete NAO ENCONTRADO! **
echo  ************************************************
echo  **     ESTA  ROTINA  BATCH  SERA  ABOTADA.    **
echo  ************************************************
echo.
goto endbat

:yesfile
call C:\Apps\Command\ciano.bat
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

echo Copiando Arquivos HTM contendo resultados das loterias da Caixa EF...
move /Y caixa\*.htm D:\Workspace\Python\Lothon\data\
echo.

echo Copiando Arquivos CSV contendo a carteira do IBOVESP da bolsa B3...
move /Y infinite\www\*.csv D:\B3\Data\B3\Carteira_IBOV\2022_Jan-Abr\%HOJE%
echo.

echo Copiando Arquivos ZIP contendo cotacoes intrady da bolsa B3...
move /Y infinite\www\*.zip D:\B3\Data\B3\Cotacoes_TRADEINTRADAY\2022\%HOJE%
echo.

echo Copiando Arquivos de cotacoes e logging da corretora GENIAL...
move /Y genial\mql5_files\*.* D:\B3\Data\Brasil\Clear_BookTick\mql5_files
move /Y genial\mql5_logs\*.* D:\B3\Data\Brasil\Clear_BookTick\mql5_logs
move /Y genial\terminal_logs\*.* D:\B3\Data\Brasil\Clear_BookTick\terminal_logs
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
move /Y infinite\logs\*.* D:\B3\Data\Infinite\logs
echo.

echo Copiando Arquivos LOG da aplicacao D-Clock...
move /Y infinite\clock\*.* D:\B3\Data\Infinite\clock
echo.

echo Removendo arquivo flag [safeToDelete.tmp]...
del /F /Q infinite\safeToDelete.tmp
echo.


:endbat
rem pausa final...
echo.
pause