"""
   Package /scripts/.
   Module  social_palpites.py

   Utilitario para preparacao da gravacao de video de palpites.
"""

# ----------------------------------------------------------------------------
# DEPENDENCIAS
# ----------------------------------------------------------------------------

# Built-in/Generic modules
import os
import sys
import glob
import shutil
import subprocess
import webbrowser
import time
from datetime import date, timedelta

# Libs/Frameworks modules
import send2trash
from PIL import Image


# ----------------------------------------------------------------------------
# CONSTANTES GLOBAIS
# ----------------------------------------------------------------------------

MODULE_PY = os.path.basename(__file__)

MESES_ANO = [
    'janeiro',
    'fevereiro',
    'março',
    'abril',
    'maio',
    'junho',
    'julho',
    'agosto',
    'setembro',
    'outubro',
    'novembro',
    'dezembro'
]

DIAS_SEMANA = [
    'segunda-feira',
    'terça-feira',
    'quarta-feira',
    'quinta-Feira',
    'sexta-feira',
    'sábado',
    'segunda-feira'  # como nao tem sorteio no domingo, processa como se fosse segunda-feira...
]

DIAS_DIR = [
    '2af',
    '3af',
    '4af',
    '5af',
    '6af',
    'Sab',
    '2af'  # como nao tem sorteio no domingo, processa como se fosse segunda-feira...
]

LOTERIAS = [
    'Dia de Sorte',
    'Dupla Sena',
    'Lotofácil',
    'Lotomania',
    'Mega-Sena',
    'Quina',
    'Super Sete',
    'Timemania',
    '+Milionária'
]

DIA_SORTE = 0
DUPLA_SENA = 1
LOTOFACIL = 2
LOTOMANIA = 3
MEGA_SENA = 4
QUINA = 5
SUPER_SETE = 6
TIMEMANIA = 7
MILIONARIA = 8

LOTERIAS_SEMANA = [
    [LOTOFACIL, LOTOMANIA, QUINA, SUPER_SETE],  # 0 segunda-feira
    [DIA_SORTE, DUPLA_SENA, LOTOFACIL, QUINA, TIMEMANIA],  # 1 terca-feira
    [LOTOFACIL, LOTOMANIA, MEGA_SENA, QUINA, SUPER_SETE],  # 2 quarta-feira
    [DIA_SORTE, DUPLA_SENA, LOTOFACIL, QUINA, TIMEMANIA],  # 3 quinta-feira
    [LOTOFACIL, LOTOMANIA, QUINA, SUPER_SETE],  # 4 sexta-feira
    [DIA_SORTE, DUPLA_SENA, LOTOFACIL, MEGA_SENA, QUINA, TIMEMANIA, MILIONARIA],  # 5 sabado
    [LOTOFACIL, LOTOMANIA, QUINA, SUPER_SETE]  # 6 domingo -> segunda-feira
    # como nao tem sorteio no domingo, processa como se fosse segunda-feira...
]

CANTORES = [
    "Coma-Media",
    "Anton_Vlasov",
    "Alex_MakeMusic",
    "AudioCoffee",
    "Anton_Vlasov",
    "Prazkhanal",
    "Coma-Media"  # como nao tem sorteio no domingo, processa como se fosse segunda-feira...
]

REPO_DIR = r"D:\Workspace\Loto365\cdn-lothon\data\palpites"

VIDEOS_DIR = r"D:\Workspace\Loto365\docs-templates\Videos"
TEMPLATES_DIR = r"D:\Workspace\Loto365\docs-templates\Videos\Templates"

SOCIAL_DIR = r"D:\Workspace\Loto365\docs-templates\Social"
SLIDES_DIR = r"D:\Workspace\Loto365\docs-templates\Social\slides"

OBS_HOME = r"C:\Program Files\obs-studio\bin\64bit"
OBS_STUDIO = "obs64.exe"
OBS_PARMS = " --scene {cena} --startrecording"


# ----------------------------------------------------------------------------
# FUNCOES UTILITARIAS
# ----------------------------------------------------------------------------

# formata a loteria para o descritivo do video:
def hashtag_loteria(idx_loteria):
    str_loteria = LOTERIAS[idx_loteria].replace('á', 'a').replace(' ', '-')
    return '#' + str_loteria.upper()


def file_loteria(idx_loteria, file_ext):
    str_loteria = LOTERIAS[idx_loteria].replace('á', 'a').replace(' ', '-').replace('+', 'mais-')
    return str_loteria.lower() + '.' + file_ext


# deleta o arquivo e envia para lixeira:
def delete_file(file_name: str) -> bool:
    # exclui o arquivo, enviando-o para a lixeira:
    try:
        send2trash.send2trash(file_name)
        return True

    # se ocorrer qualquer erro na exclusao, entao ignora:
    except Exception as ex:
        # apenas imprime o erro no log e prossegue:
        print(f"{file_name}: Erro ao tentar excluir arquivo e enviar para a lixeira:\n{repr(ex)}")
        return False


# deleta os arquivos anteriores no diretorio social:
def delete_social_dir_file(social_dir) -> bool:
    # identifica no diretorio corrente (SOCIAL_DIR) a relacao de arquivos ainda presentes:
    list_files = glob.glob("*.*", root_dir=social_dir)
    len_files = len(list_files)

    # qualquer arquivo anterior no diretorio social deve ser apagado:
    if len_files > 0:
        nro_arquivos = "um arquivo" if len_files == 1 else f"os {len_files} arquivos"
        print(f"{social_dir}: Movendo para lixeira {nro_arquivos} no diretorio social...")
        for file in list_files:
            print(f"\t{file}: Movendo arquivo para lixeira...")
            path_file = os.path.join(social_dir, file)
            delete_file(path_file)
        return True

    else:
        print(f"{social_dir}: Nenhum arquivo encontrado no diretorio social...")
        return False


# copia para o diretorio social as imagens das loterias de hoje:
def copy_images_from_repo(list_loterias_hoje, to_dir):
    nr_loterias = len(list_loterias_hoje)
    print(f"{REPO_DIR}: Copiando {nr_loterias} imagens de loterias para o diretorio social...")
    for id_loteria in loterias_hoje:
        file_img = file_loteria(id_loteria, "png")
        print(f"\t{file_img}: Copiando arquivo de imagem...")
        from_file_img = os.path.join(REPO_DIR, file_img)
        shutil.copy(from_file_img, to_dir)


# copia os arquivos do diretorio para o diretorio social:
def copy_to_social_dir(from_dir, to_dir, pathnames):
    files_from_dir = glob.glob(pathnames, root_dir=from_dir)
    size_from_dir = len(files_from_dir)
    # qualquer arquivo dentro do diretorio sera copiado:
    if size_from_dir > 0:
        nro_arquivos = "um arquivo" if size_from_dir == 1 else f"{size_from_dir} arquivos"
        print(f"{from_dir}: Copiando {nro_arquivos} para o diretorio social...")
        for file_from_dir in files_from_dir:
            print(f"\t{file_from_dir}: Copiando arquivo para o diretorio social...")
            from_dir_file = os.path.join(from_dir, file_from_dir)
            shutil.copy(from_dir_file, to_dir)
    else:
        print(f"{from_dir}: Nenhum arquivo encontrado no diretorio...")


def crop_images_dir(dir_images):
    list_files = glob.glob("*.png", root_dir=dir_images)
    list_files.extend(glob.glob("*.jpg", root_dir=dir_images))
    len_files = len(list_files)
    if len_files <= 0:
        sys.exit(f"{dir_images}: Nao ha imagens de palpites no diretorio!")
    elif len_files == 1:
        print(f"{dir_images}: Existe apenas 1 imagem de palpites no diretorio:\n"
              f"{list_files}")
    else:
        print(f"{dir_images}: Existem {len_files} imagens de palpites no diretorio:\n"
              f"{list_files}")

    # percorre a lista de arquivos para realizar o crop:
    for file in list_files:
        update_flag = False
        # instancia o objeto da imagem para processamento:
        crop_file_img = os.path.join(dir_images, file)
        img = Image.open(crop_file_img)
        iw, ih = img.size
        print(f"\n\t{file}: Dimensao original da imagem: {iw} x {ih}")

        # efetua a reducao da imagem para o comprimento padrao 1080, se for maior:
        if iw > 1080:
            ratio = iw / 1080
            iw = 1080
            ih = int(ih / ratio)
            print(f"\t{file}: Vai reduzir a imagem para: {iw} x {ih}")
            img.thumbnail((iw, ih))
            iw, ih = img.size
            print(f"\t{file}: Nova dimensao da imagem reduzida: {iw} x {ih}")
            update_flag = True

        # efetua o corte da imagem para a altura limite de 1920, se for maior:
        if ih > 1920:
            # efetua o crop da imagem e salva no mesmo arquivo:
            ih = 1920
            img = img.crop((0, 0, iw, ih))
            iw, ih = img.size
            print(f"\t{file}: Nova dimensao da imagem cortada: {iw} x {ih}")
            update_flag = True
        else:  # se ja foi feito crop antes, entao ignora
            print(f"\t{file}: A imagem ja esta com altura menor ou igual a 1920.")

        # se fez alteracoes, salva a imagem no mesmo arquivo original:
        if update_flag:
            img.save(crop_file_img, 'PNG')


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit(f"{MODULE_PY}: Este modulo nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

# ja posiciona no diretorio social usado para gravacao de videos:
os.chdir(SOCIAL_DIR)

# identifica o dia da semana, para obter os recursos proprios para a data:
hoje = date.today()
int_dia = hoje.weekday()
# se for domingo, pula para a segunda-feira seguinte:
if int_dia == 6:  # 6 == domingo
    hoje += timedelta(days=1)
    int_dia = 0   # 0 == segunda-feira
# qual o dia da semana:
str_dia = DIAS_SEMANA[int_dia]
dir_dia = DIAS_DIR[int_dia]
# qual a data corrente:
int_dd = hoje.day
str_dd = f"{int_dd:02}"
str_mes = MESES_ANO[hoje.month - 1]
str_mmm = str_mes[:3].upper()
int_aaaa = hoje.year
print(f"{str_dd}/{str_mmm}/{int_aaaa}: {str_dia}, {int_dd} de {str_mes} de {int_aaaa}. "
      f"Diretorio do Dia = /{dir_dia}")

# qualquer arquivo anterior no diretorio social deve ser apagado:
delete_social_dir_file(SOCIAL_DIR)
delete_social_dir_file(SLIDES_DIR)

# verifica quais as loterias que terao sorteio hoje:
loterias_hoje = LOTERIAS_SEMANA[int_dia]

# copia para o diretorio social as imagens das loterias de hoje:
copy_images_from_repo(loterias_hoje, SOCIAL_DIR)  # estas serao usadas no WhatsApp e Telegram
copy_images_from_repo(loterias_hoje, SLIDES_DIR)  # estas serao usadas para gravar o video

# obtem os arquivos que sao comuns a todos os dias, usados diariamente (daily):
copy_to_social_dir(TEMPLATES_DIR, SOCIAL_DIR, "*.txt")
copy_to_social_dir(TEMPLATES_DIR, SLIDES_DIR, "*.jpg")

# busca os demais arquivos do diretorio correspondente ao dia de hoje:
from_dir_dia = os.path.join(VIDEOS_DIR, dir_dia)
copy_to_social_dir(from_dir_dia, SLIDES_DIR, "*.jpg")

# efetua crop das imagens/slides antes da gravacao:
crop_images_dir(SLIDES_DIR)

# processa o descritivo do video, substituindo a data do dia e as loterias que tem sorteio:
path_desc_file = os.path.join(SOCIAL_DIR, "descricao.txt")
print(f"{path_desc_file}: Formatando a descricao para postagem em redes sociais...")

# esta lendo o arquivo TXT no diretorio social, para nao alterar o original:
with open(path_desc_file, "rt") as f:
    desc_content = f.read()

# efetua as substituicoes de interpolacao:
ddmmmaaaa = f"{str_dd}/{str_mmm}/{int_aaaa}"
data_extenso = f"{str_dia}, {int_dd} de {str_mes} de {int_aaaa}"
hash_loterias = ', '.join([hashtag_loteria(n) for n in loterias_hoje])
list_loterias = ', '.join([LOTERIAS[n] for n in loterias_hoje]).upper()
nome_cantor = CANTORES[int_dia]
desc_content = desc_content.format(ddmmmaaaa=ddmmmaaaa, data_extenso=data_extenso,
                                   hash_loterias=hash_loterias, list_loterias=list_loterias,
                                   nome_cantor=nome_cantor)

# regrava o arquivo no diretorio social, sem alterar o original no diretorio _daily:
with open(path_desc_file, "wt") as f:
    f.write(desc_content)

# exibe o texto em editor proprio, para simples conferencia e copy/paste:
webbrowser.open(path_desc_file)

# executa o OBS Studio para gravacao de video com slides do dia:
cena_dir = f"Cena_{dir_dia}"
obs_exe = OBS_STUDIO + OBS_PARMS.format(cena=cena_dir)
print(f"{OBS_HOME}: Executando o programa do OBS Studio: {obs_exe}")
subprocess.Popen(obs_exe, cwd=OBS_HOME, shell=True)
