@echo off

rem Verifica os logs das tarefas do Janitor.
echo.
echo  VERIFICAR TAREFAS   [ C:\APPS\INFINITE\JANITOR\BIN\CHECK_TAREFAS.BAT ]
echo.
echo.

echo Posicionando no diretorio C:\Apps\Infinite\Janitor\data
cd /D C:\Apps\Infinite\Janitor\data

rem primeiro tem q verificar se houve avisos ou erros nos logs das tarefas:
echo Verificando se houve algum erro ou alerta nos logs das tarefas:
echo ********************  ALERTAS  ********************             > findWarnError.tmp 2>&1
echo ***************************************************            >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Clocker\logs\clocker.log            >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Clocker\logs\clocker-internal.log   >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Janitor\logs\janitor.log            >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Janitor\logs\janitor-internal.log   >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Colethon\logs\colethon.log          >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Lothon\logs\lothon.log              >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Quanthon\logs\quanthon.log          >> findWarnError.tmp 2>&1
echo.                                                               >> findWarnError.tmp 2>&1

echo.                                                               >> findWarnError.tmp 2>&1
echo *********************  ERROS  *********************            >> findWarnError.tmp 2>&1
echo ***************************************************            >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Clocker\logs\clocker.log           >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Clocker\logs\clocker-internal.log  >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Janitor\logs\janitor.log           >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Janitor\logs\janitor-internal.log  >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Colethon\logs\colethon.log         >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Lothon\logs\lothon.log             >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Quanthon\logs\quanthon.log         >> findWarnError.tmp 2>&1
echo.

@echo on
find /N "WARN"  findWarnError.tmp
find /N "ERROR" findWarnError.tmp
@echo off
echo.

rem Pausa final...
echo.
pause
