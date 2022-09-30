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

echo Copiando Arquivos para publicacao dos palpites do dia...
move /Y Social\*.* C:\Users\qdev\Loto365\docs-templates\Social
echo.

echo Recuperando ultimo commit dos arquivos PNG e PDF no repositorio GitHub...
cd /D C:\Users\qdev\Loto365\cdn-lothon
git pull origin main
echo.

echo Executando Firefox para verificar Loto365.com.br e atualizar Google Drive e Redes Sociais...
cd /D C:\Users\qdev\Loto365\docs-templates\Social
start "" "C:\Program Files (x86)\Notepad++\notepad++.exe" "C:\Users\qdev\Loto365\docs-templates\Social\descricao.txt" "C:\Users\qdev\Loto365\cdn-lothon\data\palpites\dia-de-sorte.csv"
start "" "C:\Program Files\Mozilla Firefox\firefox.exe" -url "https://www.Loto365.com.br/#palpites" "https://drive.google.com/drive/folders/1PjOJoHbueNMiNGKJHLP5tC7UEyuRRSvD" "https://web.whatsapp.com/" "https://web.telegram.org/z/#-1488280660" "https://twitter.com/compose/tweet" "https://www.facebook.com/Loto365br" "https://www.instagram.com/loto365br/" "https://studio.youtube.com/channel/UCiiGBkWJiej2eAfwcqiI77A/videos/upload" "https://www.linkedin.com/company/loto365br/?share=true" "https://br.pinterest.com/pin-builder/"
start .
echo.

echo Removendo arquivos flag [safeToDelete.tmp]...
del /F /Q Lothon\data
del /F /Q Quanthon\data
echo.

:endbat
rem Pausa final...
echo.
pause
