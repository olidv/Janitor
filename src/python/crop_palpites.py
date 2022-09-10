"""
   Package /scripts/.
   Module  crop_palpites.py

   Utilitario para corte de imagens de palpites.
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

    # se o comprimento esta acima de 1080, entao eh preciso fazer o resize:
    if iw > 1080:
        ratio = iw / 1080
        iw = 1080
        ih = int(ih / ratio)
        print(f"{file}: Vai redimensionar a imagem para : {iw} x {ih}")
        img.thumbnail((iw, ih))
        iw, ih = img.size
        print(f"{file}: Nova dimensao da imagem redimensionada: {iw} x {ih}")

    # se ja foi feito crop antes, entao ignora
    if ih <= 1920:
        print(f"{file}: A imagem ja esta com altura menor ou igual a 1920.")
        continue

    # efetua o crop da imagem e salva no mesmo arquivo:
    ih = 1920
    img = img.crop((0, 0, iw, ih))
    iw, ih = img.size
    print(f"{file}: Nova dimensao da imagem cortada: {iw} x {ih}")

    # salva a imagem no mesmo arquivo original:
    img.save(file, 'PNG')
