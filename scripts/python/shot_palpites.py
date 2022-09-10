"""
   Package /scripts/.
   Module  shot_palpites.py

   Utilitario para screenshot de consultas de palpites.
"""

# ----------------------------------------------------------------------------
# DEPENDENCIAS
# ----------------------------------------------------------------------------

# Built-in/Generic modules
import sys
import time

# Libs/Frameworks modules
from selenium import webdriver
from selenium.webdriver import Firefox
from selenium.webdriver.firefox.service import Service
from selenium.webdriver.firefox.options import Options
from selenium.common.exceptions import WebDriverException


# ----------------------------------------------------------------------------
# CONSTANTES GLOBAIS
# ----------------------------------------------------------------------------

LOTERIAS = ["dia-de-sorte", "dupla-sena", "lotofacil", "lotomania", "mega-sena",
            "quina", "super-sete", "timemania", "mais-milionaria"]

PALPITES_URL = "https://www.loto365.com.br/palpites.html?loteria="

LOG_PATH = r'C:\Apps\B3\Janitor\logs\geckodriver.log'

# por enquanto nao fez diferenca...
# PROFILE_PATH = r'C:\Users\qdev\AppData\Roaming\Mozilla\Firefox\Profiles\z4zg1uf3.default-release'


# ----------------------------------------------------------------------------
# FUNCOES UTILITARIAS
# ----------------------------------------------------------------------------

# abre o navegador Firefox e configura as opcoes para download automatico e direto:
def open_webdriver_firefox() -> webdriver.Firefox:
    # utiliza as preferencias especificas do Firefox para abrir a Web Console:
    service = Service(log_path=LOG_PATH)
    options = Options()
    options.log.level = "trace"
    # options.set_preference('profile', PROFILE_PATH)  # vai usar o profile default do Firefox

    # vai abrir o navegador do Firefox escondido do usuario:
    driver_firefox = None
    try:
        print(f"Iniciando WebDriver do Firefox com FirefoxOptions: {options.arguments}...")
        driver_firefox = Firefox(service=service, options=options)
        print("WebDriver do Firefox inicializado com sucesso.")

    except WebDriverException as ex:
        # o WebDriver do Firefox pode nao estar instalado ou presente no PATH:
        print(f"Erro ao tentar inicializar o WebDriver do Firefox:\n{repr(ex)}")
        # if ex.msg == 'firefox not reachable':
        #     print("*** ATENCAO: NECESSARIO ATUALIZAR VERSAO DO WEBDRIVER DO FIREFOX. ***")

    return driver_firefox


# ----------------------------------------------------------------------------
# MAIN ENTRY-POINT
# ----------------------------------------------------------------------------

# Este modulo nao pode ser carregado por outro modulo
if __name__ != '__main__':
    sys.exit("Este modulo 'shot_palpites.py' nao pode ser carregado por outro modulo!")
# prossegue somente se este programa foi executado como entry-point...

# abre o Firefox pelo selenium web driver:
browser = open_webdriver_firefox()

# salva as telas de todas as loterias:
for loteria in LOTERIAS:
    print(f"\n{loteria}: Capturando tela da loteria...")
    loteria_url = PALPITES_URL + loteria
    loteria_png = loteria + ".png"

    # acessa a pagina de palpites da loteria:
    browser.get(loteria_url)
    time.sleep(5)  # aguarda 5 segundos para a pagina carregar totalmente antes do screenshot
    browser.save_full_page_screenshot(loteria_png)  # salva o arquivo (imagem) no diretorio corrente

# ao final, fecha o browser:
browser.quit()
