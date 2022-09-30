@echo off

rem Printa a apresentacao do Janitor para o notebook Samsung.
echo.
echo  JANITOR_SAMSUNG   [ C:\APPS\INFINITE\JANITOR\BIN\JANITOR_SAMSUNG.BAT ]
echo.
echo.

rem verifica se o flag indicativo de processamento existe no Lothon ou Quanthon:
if exist D:\Publico\Lothon\data\safeToDelete.tmp   goto yesfile
if exist D:\Publico\Quanthon\data\safeToDelete.tmp goto yesfile

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

echo Posicionando no diretorio D:\Publico
cd /D D:\Publico

rem Obtem a data/hora atuais no formato AAAA-MM-DD:
set YYYY=%date:~-4%
set HOJE=%date:~-4%-%date:~3,2%
echo Data de referencia para as movimentacoes:  %HOJE%
echo.

echo Copiando Arquivos HTM contendo resultados das loterias da Caixa EF...
copy /y Lothon\data\caixa\D_*.htm C:\Apps\Infinite\Lothon\data\caixa
move /Y Lothon\data\caixa\D_*.htm D:\Workspace\Python\Lothon\data\caixa\
echo.
copy /Y Lothon\data\cache\D_*.csv C:\Apps\Infinite\Lothon\data\cache\
copy /Y Lothon\data\cache\D_*.csv D:\Workspace\Python\Lothon\data\cache\
move /Y Lothon\data\cache\D_*.csv D:\Workspace\Java\jLothon\data\cache\
echo.
copy /Y Lothon\data\cache\JC_*.csv C:\Apps\Infinite\Lothon\data\cache\
move /Y Lothon\data\cache\JC_*.csv D:\Workspace\Python\Lothon\data\cache\
echo.

echo Copiando Arquivo CSV contendo a carteira do IBOVESP da Bolsa B3...
move /Y Quanthon\data\b3\ibovespa\IBOVDia_*.csv D:\B3\Data\B3\Carteira_IBOV\%YYYY%\%HOJE%
echo.

echo Copiando Arquivos ZIP contendo cotacoes intraday da Bolsa B3...
move /Y Quanthon\data\b3\cotacoes\TradeIntraday_*.zip D:\B3\Data\B3\Cotacoes_TRADEINTRADAY\%YYYY%\%HOJE%
echo.

echo Copiando Arquivos de cotacoes das corretoras...
move /Y Quanthon\data\mt5\genial\*.* D:\B3\Data\Brasil\Genial_BookTick\mql5_files
move /Y Quanthon\data\mt5\modal\*.*  D:\B3\Data\Brasil\Modal_BookTick\mql5_files
move /Y Quanthon\data\mt5\xm\*.*     D:\B3\Data\Exterior\XM_Tick\mql5_files
echo.

echo Removendo arquivos flag [safeToDelete.tmp]...
del /F /Q Lothon\data
del /F /Q Quanthon\data
echo.

:endbat
rem Pausa final...
echo.
pause
