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
    'segunda-feira',
    'terça-feira',
    'quarta-feira',
    'quinta-Feira',
    'sexta-feira',
    'sábado',
    'segunda-feira'  # como nao tem sorteio no domingo, processa como se fosse segunda-feira...
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

REPO_DIR = r"C:\Users\qdev\Loto365\cdn-lothon\data\palpites"
DIADESORTE_CSV_FILE = os.path.join(REPO_DIR, "dia-de-sorte.csv")

SOCIAL_DIR = r"C:\Users\qdev\Loto365\cdn-lothon\social"
TEXTO_FILE = os.path.join(SOCIAL_DIR, "mensagem.txt")

MSG_4AF = "Bom dia Pessoal.\nConfiram nossos palpites para os sorteios das loterias da Caixa " \
          "que acontecem hoje, {data_extenso}:\n\n{list_loterias}.\n\nEstas imagens facilitam " \
          "o compartilhamento, mas contém um número menor de jogos. Em nosso site é possível " \
          "consultar todos os palpites:\nhttps://www.loto365.com.br/#palpites\n\nE se quiserem " \
          "baixar arquivos CSV ou PDF, acessem nosso Google Drive:\n" \
          "https://www.bit.ly/Loto365-Palpites\n\n" \
          "Desejamos Boa $orte e $uce$$o a todos!"
MSG_DOM = "Bom dia Pessoal.\nNo domingo não há sorteios da Caixa, mas nosso robô gera novos " \
          "palpites com base nos sorteios de sábado.\n\nAtualizamos os palpites em nosso site:\n" \
          "https://www.loto365.com.br/#palpites\n\nE salvamos os arquivos em nosso Google " \
          "Drive:\nhttps://www.bit.ly/Loto365-Palpites\n\n" \
          "Boa $orte e $uce$$o a todos!"
MSG_DIA = "Bom dia Pessoal.\nGeramos novos palpites para os sorteios das loterias da Caixa " \
          "que acontecem hoje, {data_extenso}:\n\n{list_loterias}.\n\n" \
          "Desejamos Boa $orte e $uce$$o a todos!"


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
def delete_social_dir_files(social_dir) -> bool:
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


# identifica a mensagem a ser postada nas redes sociais, com base no dia corrente da semana.
def get_mensagem_texto(dia_semana):
    # o texto a ser utilizado depende do dia da semana:
    if dia_semana == 2:  # quarta-feira
        return MSG_4AF
    elif dia_semana == 6:  # domingo
        return MSG_DOM
    else:  # segunda, terca, quinta, sexta, sabado
        return MSG_DIA


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
# qual a data corrente:
int_dd = hoje.day
str_dd = f"{int_dd:02}"
str_mes = MESES_ANO[hoje.month - 1]
str_mmm = str_mes[:3].upper()
int_aaaa = hoje.year
print(f"{str_dd}/{str_mmm}/{int_aaaa}: {str_dia}, {int_dd} de {str_mes} de {int_aaaa}.")

# qualquer arquivo anterior no diretorio social deve ser apagado:
delete_social_dir_files(SOCIAL_DIR)

# verifica quais as loterias que terao sorteio hoje:
loterias_hoje = LOTERIAS_SEMANA[int_dia]

# copia para o diretorio social as imagens das loterias de hoje:
copy_images_from_repo(loterias_hoje, SOCIAL_DIR)  # estas serao usadas no WhatsApp e Telegram

# processa o descritivo do video, substituindo a data do dia e as loterias que tem sorteio:
print(f"{TEXTO_FILE.upper()}: Formatando a descricao para postagem em redes sociais...")

# esta lendo , para nao alterar o original:

# efetua as substituicoes de interpolacao no arquivo TXT dentro do diretorio social:
ddmmmaaaa = f"{str_dd}/{str_mmm}/{int_aaaa}"
data_extenso = f"{str_dia}, {int_dd} de {str_mes} de {int_aaaa}"
hash_loterias = ', '.join([hashtag_loteria(n) for n in loterias_hoje])
list_loterias = ', '.join([LOTERIAS[n] for n in loterias_hoje]).upper()
desc_content = get_mensagem_texto(int_dia)
desc_content = desc_content.format(ddmmmaaaa=ddmmmaaaa, data_extenso=data_extenso,
                                   hash_loterias=hash_loterias, list_loterias=list_loterias)

# regrava o arquivo no diretorio social, sem alterar o original no diretorio _daily:
with open(TEXTO_FILE, "wt") as f:
    f.write(desc_content)
