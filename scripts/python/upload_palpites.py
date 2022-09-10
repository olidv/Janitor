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


# ----------------------------------------------------------------------------
# CONSTANTES GLOBAIS
# ----------------------------------------------------------------------------

LOG_PATH = r'C:\Apps\B3\Janitor\logs\gdriver.log'


# ----------------------------------------------------------------------------
# FUNCOES UTILITARIAS
# ----------------------------------------------------------------------------


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit("Este modulo 'crop_palpites.py' nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

# identifica o diretorio corrente e a relacao de arquivos neste:
cwDir = os.getcwd()
list_files = glob.glob("*.png")
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

