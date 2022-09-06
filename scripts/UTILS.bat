@echo off

rem Executa rotina no diretorio temporario da estacao:
mkdir C:\Temp\_backup  >NUL  2>NUL

JetBrains_set
Code_user
Outlook_pst
3M_PSNotes
registry_env
Encryptpad
Evernote
Browser_fav

cd /D C:\Temp\_backup


rem Obtem a data/hora atuais no formato AAAA-MM-DD HH:
set Mes=%date:~-4%-%date:~3,2%
set Dia=%date:~-4%-%date:~0,2%
set Hor=%time:~0,2%

set HOJE=%date:~-4%-%date:~3,2%-%date:~0,2%

rem Copia arquivos de configuracao para \Documents\Configuracoes\, para efetuar copia segura:
copy /Y C:\Users\ramon.oliveira\AppData\Roaming\3M\PSNotes\* C:\Users\ramon.oliveira\Documents\Configuracoes\3M\
copy /Y C:\Java\apache-maven-3.3.9\conf\*.xml C:\Users\ramon.oliveira\Documents\Configuracoes\apache-maven-3.3.9\
copy /Y C:\Users\ramon.oliveira\.m2\*.xml C:\Users\ramon.oliveira\Documents\Configuracoes\m2\
xcopy C:\Java\apache-tomcat-6.0.45\conf\*.* C:\Users\ramon.oliveira\Documents\Configuracoes\apache-tomcat-6.0.45\  /S /C /H /R /Y
xcopy C:\Java\etc\*.* C:\Users\ramon.oliveira\Documents\Configuracoes\Java\etc\  /S /C /H /R /Y
xcopy C:\Users\ramon.oliveira\AppData\Roaming\Microsoft\Assinaturas\*.* C:\Users\ramon.oliveira\Documents\Configuracoes\Outlook\Assinaturas\   /S /C /H /R /Y
xcopy C:\Tools\batch\*.* C:\Users\ramon.oliveira\Documents\Configuracoes\batch\  /S /C /H /R /Y


rem compacta o(s) diretorio(s) de Usuario:
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Documentos_%Mes%.7z"    C:\Users\ramon.oliveira\Documents
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Imagens_%Mes%.7z"       C:\Users\ramon.oliveira\Pictures
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Videos_%Mes%.7z"        C:\Users\ramon.oliveira\Videos
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Audios_%Mes%.7z"        C:\Users\ramon.oliveira\Music

"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Desktop!_%Mes%.7z"      C:\Users\ramon.oliveira\!
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Desktop_%Mes%.7z"       C:\Users\ramon.oliveira\Desktop
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Favoritos_%Mes%.7z"     C:\Users\ramon.oliveira\Favorites
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.MenuIniciar_%Mes%.7z"  "C:\Users\ramon.oliveira\AppData\Roaming\Microsoft\Windows\Start Menu"


rem Compacta os scripts para manutencao da estacao:
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.batch_%Mes%.7z" C:\Tools\batch

rem compacta o(s) projetos(s) em desenvolvimento:
rem mas antes, limpa quaisquer compilacoes que houverem em cada projeto.
cd /D D:\workspace\TreeSolution
call mvc
cd /D D:\workspace\TreeCommons
call mvc
cd /D D:\workspace\TreePortal
call mvc
cd /D C:\Temp\_backup
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Eclipse-Workspace_treesolution_%Dia%.7z"  D:\workspace\treesolution-parent  -xr!.svn
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Eclipse-Workspace_treecommons_%Dia%.7z"   D:\workspace\treecommons  -xr!.svn
"c:\Arquivos de Programas\7-Zip\7z" a "desk183.Eclipse-Workspace_treeportal_%Dia%.7z"    D:\workspace\TreePortal  -xr!.svn


rem Move todos os arquivos compactados (e na data atual) para diretorio de backup do projeto:
move /Y  *.7z  C:\Java\apache-ant-1.9.6\docs


rem Pula uma linha para melhor legibilidade.
rem echo[
