"""
   Package /scripts/.
   Module  reduce_palpites.py

   Utilitario para reducao do tamanho de imagens de palpites.
"""

# ----------------------------------------------------------------------------
# DEPENDENCIAS
# ----------------------------------------------------------------------------

# Built-in/Generic modules
import os
import sys
import glob

# Libs/Frameworks modules
from PIL import Image


# ----------------------------------------------------------------------------
# CONSTANTES GLOBAIS
# ----------------------------------------------------------------------------

MODULE_PY = os.path.basename(__file__)


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit(f"{MODULE_PY}: Este modulo nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

# identifica o diretorio corrente e a relacao de arquivos neste:
cwDir = os.getcwd()
list_files = glob.glob("*.png")
len_files = len(list_files)
if len_files <= 0:
    sys.exit("ATENCAO: Nao ha imagens de palpites no diretorio corrente!")
elif len_files == 1:
    print(f"glob: Existe apenas 1 imagem de palpites no diretorio corrente '{cwDir}':\n"
          f"{list_files}")
else:
    print(f"glob: Existem {len_files} imagens de palpites no diretorio corrente '{cwDir}':\n"
          f"{list_files}")

# percorre a lista de arquivos para realizar o crop:
for file in list_files:
    # instancia o objeto da imagem para processamento:
    img = Image.open(file)
    iw, ih = img.size
    print(f"\n{file}: Dimensao original da imagem: {iw} x {ih}")

    # efetua a reducao da imagem para o comprimento padrao 1080, se for maior:
    if iw > 1080:
        ratio = iw / 1080
        iw = 1080
        ih = int(ih / ratio)
        print(f"{file}: Vai reduzir a imagem para: {iw} x {ih}")
        img.thumbnail((iw, ih))
        iw, ih = img.size
        print(f"{file}: Nova dimensao da imagem reduzida: {iw} x {ih}")

        # salva a imagem no mesmo arquivo original:
        img.save(file, 'PNG')
    else:
        print(f"{file}: Nao ha necessidade de reduzir a imagem")
