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
echo.                                                                > findWarnError.tmp 2>&1

echo *********************  F A T A L  *********************        >> findWarnError.tmp 2>&1
echo *******************************************************        >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Clocker\logs\clocker.log           >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Clocker\logs\clocker-internal.log  >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Janitor\logs\janitor.log           >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Janitor\logs\janitor-internal.log  >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Colethon\logs\colethon.log         >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Lothon\logs\lothon.log             >> findWarnError.tmp 2>&1
find /N "FATAL" C:\Apps\Infinite\Quanthon\logs\quanthon.log         >> findWarnError.tmp 2>&1
echo.

echo *********************  E R R O  **********************         >> findWarnError.tmp 2>&1
echo ******************************************************         >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Clocker\logs\clocker.log           >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Clocker\logs\clocker-internal.log  >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Janitor\logs\janitor.log           >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Janitor\logs\janitor-internal.log  >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Colethon\logs\colethon.log         >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Lothon\logs\lothon.log             >> findWarnError.tmp 2>&1
find /N "ERROR" C:\Apps\Infinite\Quanthon\logs\quanthon.log         >> findWarnError.tmp 2>&1
echo.

echo ********************  W A R N  ***********************         >> findWarnError.tmp 2>&1
echo ******************************************************         >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Clocker\logs\clocker.log            >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Clocker\logs\clocker-internal.log   >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Janitor\logs\janitor.log            >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Janitor\logs\janitor-internal.log   >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Colethon\logs\colethon.log          >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Lothon\logs\lothon.log              >> findWarnError.tmp 2>&1
find /N "WARN" C:\Apps\Infinite\Quanthon\logs\quanthon.log          >> findWarnError.tmp 2>&1
echo.                                                               >> findWarnError.tmp 2>&1

@echo on
find /N "FATAL" findWarnError.tmp
find /N "ERROR" findWarnError.tmp
find /N "WARN"  findWarnError.tmp
@echo off
echo.

rem Pausa final...
echo.
pause
