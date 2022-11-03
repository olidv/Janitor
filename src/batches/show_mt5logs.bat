@echo off
set HOJE=%1

rem Executa Explorer para verificar logs por conta propria.
start /max C:\Users\qdev\AppData\Roaming\MetaQuotes

rem Executa Notepad++ para exibir logs de todos os terminais MetaTrader 5.
start "" "C:\Program Files (x86)\Notepad++\notepad++.exe" -nosession "C:\Users\qdev\AppData\Roaming\MetaQuotes\Crashes\*.log" C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9AA5A2E564E1326FB93349159C9D30A4\logs\%HOJE%.log C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9AA5A2E564E1326FB93349159C9D30A4\MQL5\Logs\%HOJE%.log C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\886B601D7760693D209A707150753C26\logs\%HOJE%.log C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\886B601D7760693D209A707150753C26\MQL5\Logs\%HOJE%.log C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9352866EDE8D3BAA5CDBEF2EC84D2C07\logs\%HOJE%.log C:\Users\qdev\AppData\Roaming\MetaQuotes\Terminal\9352866EDE8D3BAA5CDBEF2EC84D2C07\MQL5\Logs\%HOJE%.log
