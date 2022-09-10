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

# Libs/Frameworks modules
from pydrive2.auth import GoogleAuth
from pydrive2.drive import GoogleDrive


# ----------------------------------------------------------------------------
# CONSTANTES GLOBAIS
# ----------------------------------------------------------------------------

MODULE_PY = os.path.basename(__file__)

SETTINGS_PATH_DEV = r"D:\Workspace\C#\Janitor\src\resources\dev\settings.yaml"
SETTINGS_PATH_PRD = r"C:\Apps\B3\Janitor\scripts\settings.yaml"


# ----------------------------------------------------------------------------
# FUNCOES UTILITARIAS
# ----------------------------------------------------------------------------

# conecta a API do Google Drive via Oauth2:
def connect_google_drive() -> GoogleDrive:
    google_drive = None
    try:
        print(f"Iniciando conexao ao Google Driver...")
        # arquivo de configuracao contem os parametros para conexao a API do Google:
        gauth = GoogleAuth(settings_file=SETTINGS_PATH_PRD)
        gauth.LocalWebserverAuth()  # Creates local webserver and auto handles authentication.
        google_drive = GoogleDrive(gauth)
        print("Google Driver conectado com sucesso.")

    except Exception as ex:
        print(f"Erro ao tentar conectar com Google Driver:\n{repr(ex)}")

    return google_drive


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit(f"{MODULE_PY}: Este modulo nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

# conecta a API do Google Drive via Oauth2:
drive = connect_google_drive()

# FIXME: navegacao de teste:
# 1PjOJoHbueNMiNGKJHLP5tC7UEyuRRSvD
# file_list = drive.ListFile({'q': "'root' in parents and trashed=false"}).GetList()
file_list = drive.ListFile({'q': "'1PjOJoHbueNMiNGKJHLP5tC7UEyuRRSvD' in parents"}).GetList()
for file1 in file_list:
    print('\ntitle: %s, id: %s' % (file1['title'], file1['id']))

print("\n\n\n")

# # FIXME: navegacao de teste:
# # Paginate file lists by specifying number of max results
# for file_list in drive.ListFile({'q': 'trashed=false', 'maxResults': 10}):
#     print('\nReceived %s files from Files.list()' % len(file_list))  # <= 10
#     for file1 in file_list:
#         print('title: %s, id: %s' % (file1['title'], file1['id']))


# identifica o diretorio corrente e a relacao de arquivos neste:
# cwDir = os.getcwd()
# list_files = glob.glob("*.*")
# len_files = len(list_files)
# if len_files <= 0:
#     sys.exit("ATENCAO: Nao ha arquivos de palpites no diretorio corrente!")
# elif len_files == 1:
#     print(f"glob: Existe apenas 1 arquivo de palpites no diretorio corrente '{cwDir}':\n"
#           f"{list_files}\n")
# else:
#     print(f"glob: Existem {len_files} arquivos de palpites no diretorio corrente '{cwDir}':\n"
#           f"{list_files}\n")

# percorre a lista de arquivos para realizar o upload:
# for file in list_files:
#     print(f"\n{file}: Vai efetuar o upload do arquivo...")
#     # faz o upload do arquivo que ja existe no Google Drive:
#     objFile = gdrive.CreateFile({'title': file})
#     objFile.SetContentFile(file)
#     objFile.Upload()
#     print(objFile.values())
#
#     break
