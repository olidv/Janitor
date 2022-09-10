"""
   Package /scripts/.
   Module  upload_palpites.py

   Utilitario para upload no Google Drive de arquivos palpites.
"""

# ----------------------------------------------------------------------------
# DEPENDENCIAS
# ----------------------------------------------------------------------------

# Built-in/Generic modules
import os
import sys
import glob

# Libs/Frameworks modules
from pydrive2.auth import GoogleAuth
from pydrive2.drive import GoogleDrive


# ----------------------------------------------------------------------------
# CONSTANTES GLOBAIS
# ----------------------------------------------------------------------------

SETTINGS_PATH_DEV = r"D:\Workspace\C#\Janitor\etc\settings.yaml"
SETTINGS_PATH_PRD = r"C:\Apps\B3\Janitor\scripts\settings.yaml"


# ----------------------------------------------------------------------------
# FUNCOES UTILITARIAS
# ----------------------------------------------------------------------------

# conecta a API do Google Drive via Oauth2:
def connect_google_drive() -> GoogleDrive:
    # arquivo de configuracao contem os parametros para conexao a API:
    gauth = GoogleAuth(settings_file=SETTINGS_PATH_DEV)
    gauth.LocalWebserverAuth()  # Creates local webserver and auto handles authentication.
    google_drive = GoogleDrive(gauth)

    return google_drive


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit("Este modulo 'crop_palpites.py' nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

# conecta a API do Google Drive via Oauth2:
gdrive = connect_google_drive()

# identifica o diretorio corrente e a relacao de arquivos neste:
cwDir = os.getcwd()
list_files = glob.glob("*.*")
len_files = len(list_files)
if len_files <= 0:
    sys.exit("ATENCAO: Nao ha arquivos de palpites no diretorio corrente!")
elif len_files == 1:
    print(f"glob: Existe apenas 1 arquivo de palpites no diretorio corrente '{cwDir}':\n"
          f"{list_files}\n")
else:
    print(f"glob: Existem {len_files} arquivos de palpites no diretorio corrente '{cwDir}':\n"
          f"{list_files}\n")

# percorre a lista de arquivos para realizar o upload:
for file in list_files:
    print(f"\n{file}: Vai efetuar o upload do arquivo...")
