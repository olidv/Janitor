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
from datetime import date, timedelta

# Libs/Frameworks modules
import send2trash


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
    'Segunda-feira',
    'Terça-feira',
    'Quarta-feira',
    'Quinta-Feira',
    'Sexta-feira',
    'Sábado',
    'Segunda-feira'  # como nao tem sorteio no domingo, processa como se fosse segunda-feira...
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
def delete_social_dir_file() -> bool:
    # identifica no diretorio corrente (SOCIAL_DIR) a relacao de arquivos ainda presentes:
    list_files = glob.glob("*.*")
    len_files = len(list_files)

    # qualquer arquivo anterior no diretorio social deve ser apagado:
    if len_files > 0:
        nro_arquivos = "um arquivo" if len_files == 1 else f"os {len_files} arquivos"
        print(f"{SOCIAL_DIR}: Movendo para lixeira {nro_arquivos} no diretorio social...")
        for file in list_files:
            print(f"\t{file}: Movendo arquivo para lixeira...")
            path_file = os.path.join(SOCIAL_DIR, file)
            delete_file(path_file)
        return True

    else:
        print(f"{SOCIAL_DIR}: Nenhum arquivo encontrado no diretorio social...")
        return False


# copia os arquivos do diretorio para o diretorio social:
def copy_to_social_dir(from_dir):
    files_from_dir = glob.glob('*.*', root_dir=from_dir)
    size_from_dir = len(files_from_dir)
    # qualquer arquivo dentro do diretorio sera copiado:
    if size_from_dir > 0:
        nro_arquivos = "um arquivo" if size_from_dir == 1 else f"{size_from_dir} arquivos"
        print(f"{from_dir}: Copiando {nro_arquivos} para o diretorio social...")
        for file_from_dir in files_from_dir:
            print(f"\t{file_from_dir}: Copiando arquivo para o diretorio social...")
            from_dir_file = os.path.join(from_dir, file_from_dir)
            shutil.copy(from_dir_file, SOCIAL_DIR)
    else:
        print(f"{from_dir}: Nenhum arquivo encontrado no diretorio...")


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit(f"{MODULE_PY}: Este modulo nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

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

# posiciona no diretorio social usado para gravacao de videos:
os.chdir(SOCIAL_DIR)

# qualquer arquivo anterior no diretorio social deve ser apagado:
delete_social_dir_file()

# verifica quais as loterias que terao sorteio hoje:
loterias_hoje = LOTERIAS_SEMANA[int_dia]
len_loterias_hoje = len(loterias_hoje)

# copia para o diretorio social as imagens das loterias de hoje:
print(f"{REPO_DIR}: Copiando {len_loterias_hoje} imagens de loterias para o diretorio social...")
for id_loteria in loterias_hoje:
    file_img = file_loteria(id_loteria, "png")
    print(f"\t{file_img}: Copiando arquivo de imagem...")
    from_file_img = os.path.join(REPO_DIR, file_img)
    shutil.copy(from_file_img, SOCIAL_DIR)

# obtem os arquivos que sao comuns a todos os dias, usados diariamente (daily):
copy_to_social_dir(TEMPLATES_DIR)

# busca os demais arquivos do diretorio correspondente ao dia de hoje:
from_dir_dia = os.path.join(VIDEOS_DIR, dir_dia)
copy_to_social_dir(from_dir_dia)

# processa o descritivo do video, substituindo a data do dia e as loterias que tem sorteio:
path_desc_file = os.path.join(SOCIAL_DIR, "_descricao.txt")
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

# printa o texto para simples conferencia:
print(desc_content)
