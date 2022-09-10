"""
   Package /scripts/.
   Module  crop_palpites.py

   Utilitario para redimensionamento e tratamento de imagens.
"""

# ----------------------------------------------------------------------------
# DEPENDENCIAS
# ----------------------------------------------------------------------------

# Built-in/Generic modules
import sys
import getopt

# Libs/Frameworks modules


# ----------------------------------------------------------------------------
# CODIGOS DE RETORNO DO SCRIPT
# ----------------------------------------------------------------------------

# Possiveis erros que podem ocorrer na execucao da aplicacao para retorno no sys.exit():
EXIT_ERROR_INVALID_ARGS = 1
EXIT_ERROR_NO_ARGS = 2
EXIT_ERROR_CONFIG_LOGGING = 3
EXIT_ERROR_CONFIG_INI = 4
EXIT_ERROR_MAIN = "O modulo 'crop_palpites.py' nao pode ser carregado por outro modulo!"

EXIT_SUCCESS = 0  # informa que nao ocorreu erro, executou com sucesso.


# ----------------------------------------------------------------------------
# ARGUMENTOS DE LINHA DE COMANDO
# ----------------------------------------------------------------------------

# configuracao dos argumentos da linha de comando:
CMD_LINE_ARGS = "crw:h:f:"

# parametros obtidos dos argumentos da linha de comando:
opt_crop: bool = False    # Flag para indicar que fara crop imagem
opt_resize: bool = False  # Flag para indicar que fara resize imagem
opt_width: int = 0        # nova medida do comprimento, em pixels
opt_height: int = 0       # nova medida da altura, em pixels
opt_files: str = ''      # um ou mais arquivos de imagens a serem processados


# exibe ao usuario a forma correta de execucao do programa:
def print_usage():
    print('\n'
          'Uso:\n'
          '  crop_palpites.py [opcoes]\n'
          '\n'
          'Opcoes Gerais:\n'
          '  -c               Corta a imagem conforme os parametros -w e -h\n'
          '  -r               (Default) Redimensiona a imagem conforme os parametros -w e -h\n'
          '  -w <val>         Novo comprimento da imagem, medido em pixels\n'
          '  -h <val>         Nova altura da imagem, medida em pixels\n'
          '  -f <arquivo(s)>  Um ou mais arquivos de imagens a serem processados\n')


def exit_error(msg, exit_code):
    print(msg)
    # exibe ao usuario a forma correta de execucao do programa:
    print_usage()
    sys.exit(exit_code)  # aborta apos avisar usuario


# faz o parsing das opcoes e argumentos da linha de comando:
def parse_args(sys_argv):
    global opt_crop, opt_resize, opt_width, opt_height, opt_files
    opts, args = None, None
    try:
        # se parsing feito com sucesso - programa ira prosseguir:
        opts, args = getopt.getopt(sys_argv, CMD_LINE_ARGS)

    except getopt.GetoptError as ex:
        exit_error(f"Erro no parsing dos argumentos da linha de comando:\n{repr(ex)}",
                   EXIT_ERROR_INVALID_ARGS)

    # se nenhuma opcao de execucao foi fornecida na linha de comando:
    if (opts is None) or (len(opts) == 0):
        exit_error("Erro no parsing dos argumentos da linha de comando...",
                   EXIT_ERROR_NO_ARGS)

    # identifica o comando/tarefa/job do Infinite a ser executado:
    for opt, val in opts:
        if opt == '-c':
            opt_crop = True
        elif opt == '-l':
            opt_resize = True
        elif opt == '-w':
            opt_width = valid_pixels(val)
        elif opt == '-h':
            opt_height = valid_pixels(val)
        elif opt == '-f':
            opt_files = val

    # o comando default eh o 'resize':
    if not opt_crop and not opt_resize:
        opt_resize = True

    # valida as medidas: ao menos uma deve ser fornecida:
    if opt_width <= 0 and opt_height <= 0:
        exit_error("ERRO: Indique ao menos um valor para as medidas: -w ou -h",
                   EXIT_ERROR_NO_ARGS)

    # valida os arquivos de imagens: ao menos um arquivo deve ser fornecido:
    if len(opt_files) == 0:
        exit_error("ERRO: Indique ao menos um arquivo de imagem para processar",
                   EXIT_ERROR_NO_ARGS)


# ----------------------------------------------------------------------------
# FUNCOES UTILITARIAS
# ----------------------------------------------------------------------------

def valid_pixels(val):
    try:
        pix: int = int(val)
        return pix if pix > 0 else 0

    except ValueError:
        return 0


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit(EXIT_ERROR_MAIN)
# prossegue somente se este programa foi executado como entry-point...

# faz o parsing das opcoes e argumentos da linha de comando:
parse_args(sys.argv[1:])


# ----------------------------------------------------------------------------
