using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NLog;
using Janitor.Properties;

namespace Janitor
{
    public partial class FrmConfig : Form
    {
        // referencia ao logger do NLog para toda a classe:
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        // acesso mais agil as configuracoes da aplicacao (usuario):
        private static readonly Settings config = Properties.Settings.Default;

        // arquivos de logging dos programas Infinite e Lothon:
        private static readonly String LOG_FILE_COLETHON = @"C:\Apps\Infinite\Colethon\logs\colethon.log";
        private static readonly String LOG_FILE_LOTHON = @"C:\Apps\Loto365\Lothon\logs\lothon.log";
        private static readonly String LOG_FILE_QUANTHON = @"C:\Apps\Infinite\Quanthon\logs\quanthon.log";

        // rotinas batch executadas:
        private static readonly String BATCH_SHOW_MT5_LOGS = @"C:\Apps\Infinite\Janitor\bin\show_mt5logs.bat";

        // Filtros utilizados ao abrir o dialogo para procurar programas ou arquivos:
        private static readonly String DIALOG_INITIAL_DIR = @"C:\Apps\Infinite\";
        private static readonly String DIALOG_FILTER_PROGRAMAS = "Batches (*.bat;*.cmd)|*.bat;*.cmd|Programas (*.exe;*.com)|*.exe;*.com|Todos os arquivos (*.*)|*.*";
        private static readonly String DIALOG_FILTER_ARQUIVOS = "Todos os arquivos (*.*)|*.*";

        /* --- INICIALIZACAO ------------------------------------------------------------------- */

        public FrmConfig()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        { // coleta as propriedades atuais para exibir na janela:

            // Aba Geral
            ckbGeralFlagTasks.Checked = config.GeralFlagTasks;
            ckbGeralFlagClocker.Checked = config.GeralFlagClocker;
            ckbGeralFlagBackup.Checked = config.GeralFlagBackup;
            txbGeralPathBackup.Text = config.GeralPathBackup;
            toolTips.SetToolTip(ckbGeralFlagTasks, "Clique para habilitar ou desabilitar o agendamento das tarefas.");
            toolTips.SetToolTip(ckbGeralFlagClocker, "Clique para habilitar ou desabilitar a correção do relógio interno.");
            toolTips.SetToolTip(ckbGeralFlagBackup, "Clique para habilitar ou desabilitar o backup diário.");
            toolTips.SetToolTip(lblGeralPathBackup, "Caminho completo da rotina de backup diário.");
            toolTips.SetToolTip(txbGeralPathBackup, "Caminho completo da rotina de backup diário.");
            toolTips.SetToolTip(btnGeralOpenBackup, "Clique para localizar a rotina de backup diário.");
            toolTips.SetToolTip(btnGeralRunBackup, "Clique para executar a rotina de backup diário.");
            toolTips.SetToolTip(btnGeralRerunBackup, "Clique para tornar a rotina de backup elegível para nova execução.");
            toolTips.SetToolTip(btnGeralCheckTarefas, "Clique para exibir alertas e errors ocorridos nas tarefas.");
            toolTips.SetToolTip(btnGeralEncerrarTarefas, "Clique para encerrar todas as tarefas em execução.");

            // Aba MetaTrader
            ckbMT5FlagProgram.Checked = config.MT5FlagProgram;
            ckbMT5FlagNotClose.Checked = config.MT5FlagNotClose;
            txbMT5PathGenial.Text = config.MT5PathGenial;
            txbMT5PathModal.Text = config.MT5PathModal;
            txbMT5PathXmglob.Text = config.MT5PathXmglob;
            toolTips.SetToolTip(ckbMT5FlagProgram, "Clique para habilitar ou desabilitar a execução do MetaTrader.");
            toolTips.SetToolTip(ckbMT5FlagNotClose, "Clique para ignorar ou não o encerramento do MetaTrader.");
            toolTips.SetToolTip(lblMT5PathGenial, "Caminho completo do MetaTrader da corretora Genial.");
            toolTips.SetToolTip(txbMT5PathGenial, "Caminho completo do MetaTrader da corretora Genial.");
            toolTips.SetToolTip(btnMT5OpenGenial, "Clique para localizar o MetaTrader da corretora Genial.");
            toolTips.SetToolTip(btnMT5RunGenial, "Clique para executar o MetaTrader da corretora Genial.");
            toolTips.SetToolTip(lblMT5PathModal, "Caminho completo do MetaTrader da corretora ModalMais.");
            toolTips.SetToolTip(txbMT5PathModal, "Caminho completo do MetaTrader da corretora ModalMais.");
            toolTips.SetToolTip(btnMT5OpenModal, "Clique para localizar o MetaTrader da corretora ModalMais.");
            toolTips.SetToolTip(btnMT5RunModal, "Clique para executar o MetaTrader da corretora ModalMais.");
            toolTips.SetToolTip(lblMT5PathXmglob, "Caminho completo do MetaTrader da corretora XM Global.");
            toolTips.SetToolTip(txbMT5PathXmglob, "Caminho completo do MetaTrader da corretora XM Global.");
            toolTips.SetToolTip(btnMT5OpenXmglob, "Clique para localizar o MetaTrader da corretora XM Global.");
            toolTips.SetToolTip(btnMT5RunXmglob, "Clique para executar o MetaTrader da corretora XM Global.");
            toolTips.SetToolTip(btnMT5ExibirLogs, "Clique para exibir os loggings de todos os terminais MetaTrader.");
            toolTips.SetToolTip(btnMT5ExibirFeriados, "Clique para exibir os feriados nacionais (B3) e internacionais (FOREX).");

            // Aba Colethon
            ckbColetFlagProgram.Checked = config.ColetFlagProgram;
            txbColetPathProgram.Text = config.ColetPathProgram;
            txbColetPathSignal.Text = config.ColetPathSignal;
            if (config.ColetLastExecute > DateTime.MinValue)
                txbColetLastExecute.Text = config.ColetLastExecute.ToString("dddd, dd MMMM yyyy, HH:mm");
            toolTips.SetToolTip(ckbColetFlagProgram, "Clique para habilitar ou desabilitar a execução do Colethon.");
            toolTips.SetToolTip(lblColetPathProgram, "Caminho completo do executável Colethon.");
            toolTips.SetToolTip(txbColetPathProgram, "Caminho completo do executável Colethon.");
            toolTips.SetToolTip(btnColetOpenProgram, "Clique para localizar o executável Colethon.");
            toolTips.SetToolTip(btnColetRunProgram, "Clique para executar o programa Colethon.");

            toolTips.SetToolTip(lblColetPathSignal, "Caminho completo da pasta compartilhada entre notebooks.");
            toolTips.SetToolTip(txbColetPathSignal, "Caminho completo da pasta compartilhada entre notebooks.");
            toolTips.SetToolTip(btnColetOpenSignal, "Clique para selecionar a pasta compartilhada entre notebooks.");
            toolTips.SetToolTip(btnColetDelSignal, "Clique para excluir o arquivo de sinalização.");

            toolTips.SetToolTip(lblColetLastExecute, "Última data/hora de execução do Colethon.");
            toolTips.SetToolTip(txbColetLastExecute, "Última data/hora de execução do Colethon.");
            toolTips.SetToolTip(btnColetReexecutar, "Clique para executar novamente o Colethon.");
            toolTips.SetToolTip(btnColetShowLog, "Clique para exibir o arquivo de logging do Colethon.");

            // Aba Loto365
            ckbLotoFlagProgram.Checked = config.LotoFlagProgram;
            txbLotoPathProgram.Text = config.LotoPathProgram;
            txbLotoPathSignal.Text = config.LotoPathSignal;
            if (config.LotoLastExecute > DateTime.MinValue)
                txbLotoLastExecute.Text = config.LotoLastExecute.ToString("dddd, dd MMMM yyyy, HH:mm");
            toolTips.SetToolTip(ckbLotoFlagProgram, "Clique para habilitar ou desabilitar a execução do Lothon.");
            toolTips.SetToolTip(lblLotoPathProgram, "Caminho completo do executável Lothon.");
            toolTips.SetToolTip(txbLotoPathProgram, "Caminho completo do executável Lothon.");
            toolTips.SetToolTip(btnLotoOpenProgram, "Clique para localizar o executável Lothon.");
            toolTips.SetToolTip(btnLotoRunProgram, "Clique para executar o programa Lothon.");

            toolTips.SetToolTip(lblLotoPathSignal, "Caminho completo do arquivo de sinalização do Lothon.");
            toolTips.SetToolTip(txbLotoPathSignal, "Caminho completo do arquivo de sinalização do Lothon.");
            toolTips.SetToolTip(btnLotoOpenSignal, "Clique para localizar o arquivo de sinalização do Lothon.");
            toolTips.SetToolTip(btnLotoDelSignal, "Clique para excluir o arquivo de sinalização.");

            toolTips.SetToolTip(lblLotoLastExecute, "Última data/hora de execução do Lothon.");
            toolTips.SetToolTip(txbLotoLastExecute, "Última data/hora de execução do Lothon.");
            toolTips.SetToolTip(btnLotoReexecutar, "Clique para executar novamente o Lothon.");
            toolTips.SetToolTip(btnLotoShowLog, "Clique para exibir o arquivo de logging do Lothon.");

            // Aba Quanthon
            ckbQuantFlagProgram.Checked = config.QuantFlagProgram;
            txbQuantPathProgram.Text = config.QuantPathProgram;
            txbQuantPathSignal.Text = config.QuantPathSignal;
            if (config.QuantLastExecute > DateTime.MinValue)
                txbQuantLastExecute.Text = config.QuantLastExecute.ToString("dddd, dd MMMM yyyy, HH:mm");
            toolTips.SetToolTip(ckbQuantFlagProgram, "Clique para habilitar ou desabilitar a execução do Quanthon.");
            toolTips.SetToolTip(lblQuantPathProgram, "Caminho completo do executável Quanthon.");
            toolTips.SetToolTip(txbQuantPathProgram, "Caminho completo do executável Quanthon.");
            toolTips.SetToolTip(btnQuantOpenProgram, "Clique para localizar o executável Quanthon.");
            toolTips.SetToolTip(btnQuantRunProgram, "Clique para executar o programa Quanthon.");

            toolTips.SetToolTip(lblQuantPathSignal, "Caminho completo do arquivo de sinalização do Quanthon.");
            toolTips.SetToolTip(txbQuantPathSignal, "Caminho completo do arquivo de sinalização do Quanthon.");
            toolTips.SetToolTip(btnQuantOpenSignal, "Clique para localizar o arquivo de sinalização do Quanthon.");
            toolTips.SetToolTip(btnQuantDelSignal, "Clique para excluir o arquivo de sinalização.");

            toolTips.SetToolTip(lblQuantLastExecute, "Última data/hora de execução do Quanthon.");
            toolTips.SetToolTip(txbQuantLastExecute, "Última data/hora de execução do Quanthon.");
            toolTips.SetToolTip(btnQuantReexecutar, "Clique para executar novamente o Quanthon.");
            toolTips.SetToolTip(btnQuantShowLog, "Clique para exibir o arquivo de logging do Quanthon.");

            // Botoes da janela de dialogo (OK / Cancel):
            toolTips.SetToolTip(btnOk, "Clique para aplicar as alterações nas configurações e fechar a janela.");
            toolTips.SetToolTip(btnCancel, "Clique para ignorar as alterações e fechar a janela.");

            // atualiza a aparencia da tela conforme as propriedades:
            FrmConfig_Refresh(null, null);
        }

        /// atualiza a aparencia da tela conforme as propriedades:
        private void FrmConfig_Refresh(object sender, EventArgs e)
        {
            // Aba Geral
            ckbGeralFlagTasks.ForeColor = ckbGeralFlagTasks.Checked ? Color.Blue : Color.DarkGray;
            txbGeralPathBackup.Enabled = ckbGeralFlagBackup.Checked;
            btnGeralOpenBackup.Enabled = ckbGeralFlagBackup.Checked;
            btnGeralRunBackup.Enabled = ckbGeralFlagBackup.Checked && !String.IsNullOrWhiteSpace(txbGeralPathBackup.Text);
            btnGeralRerunBackup.Enabled = ckbGeralFlagBackup.Checked && !String.IsNullOrWhiteSpace(txbGeralPathBackup.Text);

            // Aba MetaTrader
            ckbMT5FlagNotClose.ForeColor = ckbMT5FlagNotClose.Checked ? Color.Red : Color.Black;
            txbMT5PathGenial.Enabled = ckbMT5FlagProgram.Checked;
            btnMT5OpenGenial.Enabled = ckbMT5FlagProgram.Checked;
            btnMT5RunGenial.Enabled = ckbMT5FlagProgram.Checked && !String.IsNullOrWhiteSpace(txbMT5PathGenial.Text);
            txbMT5PathModal.Enabled = ckbMT5FlagProgram.Checked;
            btnMT5OpenModal.Enabled = ckbMT5FlagProgram.Checked;
            btnMT5RunModal.Enabled = ckbMT5FlagProgram.Checked && !String.IsNullOrWhiteSpace(txbMT5PathModal.Text);
            txbMT5PathXmglob.Enabled = ckbMT5FlagProgram.Checked;
            btnMT5OpenXmglob.Enabled = ckbMT5FlagProgram.Checked;
            btnMT5RunXmglob.Enabled = ckbMT5FlagProgram.Checked && !String.IsNullOrWhiteSpace(txbMT5PathXmglob.Text);

            // Aba Colethon
            txbColetPathProgram.Enabled = ckbColetFlagProgram.Checked;
            btnColetOpenProgram.Enabled = ckbColetFlagProgram.Checked;
            btnColetRunProgram.Enabled = ckbColetFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbColetPathProgram.Text);
            txbColetPathSignal.Enabled = ckbColetFlagProgram.Checked;
            btnColetOpenSignal.Enabled = ckbColetFlagProgram.Checked;
            btnColetDelSignal.Enabled = ckbColetFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbColetPathSignal.Text);
            btnColetReexecutar.Enabled = ckbColetFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbColetLastExecute.Text);
            btnColetShowLog.Enabled = !String.IsNullOrWhiteSpace(txbColetLastExecute.Text);

            // Aba Loto365
            txbLotoPathProgram.Enabled = ckbLotoFlagProgram.Checked;
            btnLotoOpenProgram.Enabled = ckbLotoFlagProgram.Checked;
            btnLotoRunProgram.Enabled = ckbLotoFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbLotoPathProgram.Text);
            txbLotoPathSignal.Enabled = ckbLotoFlagProgram.Checked;
            btnLotoOpenSignal.Enabled = ckbLotoFlagProgram.Checked;
            btnLotoDelSignal.Enabled = ckbLotoFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbLotoPathSignal.Text);
            btnLotoReexecutar.Enabled = ckbLotoFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbLotoLastExecute.Text);
            btnLotoShowLog.Enabled = !String.IsNullOrWhiteSpace(txbLotoLastExecute.Text);

            // Aba Quanthon
            txbQuantPathProgram.Enabled = ckbQuantFlagProgram.Checked;
            btnQuantOpenProgram.Enabled = ckbQuantFlagProgram.Checked;
            btnQuantRunProgram.Enabled = ckbQuantFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbQuantPathProgram.Text);
            txbQuantPathSignal.Enabled = ckbQuantFlagProgram.Checked;
            btnQuantOpenSignal.Enabled = ckbQuantFlagProgram.Checked;
            btnQuantDelSignal.Enabled = ckbQuantFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbQuantPathSignal.Text);
            btnQuantReexecutar.Enabled = ckbQuantFlagProgram.Checked && !String.IsNullOrWhiteSpace(txbQuantLastExecute.Text);
            btnQuantShowLog.Enabled = !String.IsNullOrWhiteSpace(txbQuantLastExecute.Text);
        }

        /* --- OK / CANCEL --------------------------------------------------------------------- */

        private void btnOk_Click(object sender, EventArgs e)
        { // coleta as propriedades modificadas e salva:
            // Aba Geral
            config.GeralFlagTasks = ckbGeralFlagTasks.Checked;
            config.GeralFlagClocker = ckbGeralFlagClocker.Checked;
            config.GeralFlagBackup = ckbGeralFlagBackup.Checked;
            config.GeralPathBackup = txbGeralPathBackup.Text;

            // Aba MetaTrader
            config.MT5FlagProgram = ckbMT5FlagProgram.Checked;
            config.MT5FlagNotClose = ckbMT5FlagNotClose.Checked;
            config.MT5PathGenial = txbMT5PathGenial.Text;
            config.MT5PathModal = txbMT5PathModal.Text;
            config.MT5PathXmglob = txbMT5PathXmglob.Text;

            // Aba Colethon
            config.ColetFlagProgram = ckbColetFlagProgram.Checked;
            config.ColetPathProgram = txbColetPathProgram.Text;
            config.ColetPathSignal = txbColetPathSignal.Text;

            // Aba Quanthon
            config.QuantFlagProgram = ckbQuantFlagProgram.Checked;
            config.QuantPathProgram = txbQuantPathProgram.Text;
            config.LotoPathSignal = txbLotoPathSignal.Text;

            // Aba Loto365
            config.LotoFlagProgram = ckbLotoFlagProgram.Checked;
            config.LotoPathProgram = txbLotoPathProgram.Text;
            config.QuantPathSignal = txbQuantPathSignal.Text;

            // Salva as propriedades.
            config.Save();

            // fecha o formulario:
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // fecha o formulario:
            this.Close();
        }

        /* --- ABA GERAL ----------------------------------------------------------------------- */

        private void btnGeralOpenBackup_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Rotina de Backup", txbGeralPathBackup, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnGeralRunBackup_Click(object sender, EventArgs e)
        {
            // executa a rotina de backup diario, se estiver definida:
            if (!String.IsNullOrWhiteSpace(config.GeralPathBackup))
            {
                // executa a rotina de backup minimizada porque vai tirar um print-screen da tela.
                JanitorManager.startProcess(config.GeralPathBackup, false);

                // Salva este momento como a ultima data de execucao:
                config.GeralLastBackup = DateTime.Now;
                config.Save();
            }
        }

        private void btnGeralRerunBackup_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // verifica se a rotina de backup ja foi executada hoje:
            if (config.GeralLastBackup == null || config.GeralLastBackup.Date < now.Date)
            {
                // se ainda nao foi executada, entao basta esperar:
                MessageBox.Show("A rotina de backup ainda não foi executada hoje,\nmas está elegível para execução.\n",
                                "Geral: Rotina de Backup Diário",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // a rotina ja foi executada! informa a data-hora da ultima execucao,
            string msgBackup = "A última execução da rotina de backup foi\n" +
                               config.GeralLastBackup.ToString("dddd, dd MMMM yyyy, HH:mm") + ".\n\n" +
                               "Deseja executar novamente a rotina de backup?";

            // e questiona o usuario se deseja executar novamente:
            DialogResult dialogResult = MessageBox.Show(msgBackup, "Geral: Rotina de Backup Diário",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {  // torna a rotina de backup elegivel para executar ainda hoje:
                config.GeralLastBackup = DateTime.MinValue;

                // Salva as propriedades.
                config.Save();
            }
        }

        private void btnGeralCheckTarefas_Click(object sender, EventArgs e)
        {
            // Executa o batch que verifica o logging das tarefas em busca de alertas (WARN) e erros (ERROR).
            JanitorManager.runBatch(config.GeralCheckProgram, true);
        }

        private void btnGeralEncerrarTarefas_Click(object sender, EventArgs e)
        {
            // encerra todas as tarefas em execucao:
            DialogResult dialogResult = MessageBox.Show("Deseja encerrar todas as tarefas em execução?",
                                                        "Atenção: Encerrar Todas as Tarefas",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {  // Comunica ao Manager para encerrar todas as tarefas em execucao:
                JanitorManager.ListFeriados();
            }
        }

        /* --- ABA METATRADER ------------------------------------------------------------------ */

        private void btnMT5OpenGenial_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar MetaTrader da Corretora Genial", txbMT5PathGenial, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnMT5RunGenial_Click(object sender, EventArgs e)
        {
            // executa o MetaTrader da corretora Genial, se estiver definido:
            if (!String.IsNullOrWhiteSpace(config.MT5PathGenial))
                JanitorManager.startProcess(config.MT5PathGenial, true);
        }

        private void btnMT5OpenModal_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar MetaTrader da Corretora Modal", txbMT5PathModal, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnMT5RunModal_Click(object sender, EventArgs e)
        {
            // executa o MetaTrader da corretora ModalMais, se estiver definido:
            if (!String.IsNullOrWhiteSpace(config.MT5PathModal))
                JanitorManager.startProcess(config.MT5PathModal, true);
        }

        private void btnMT5OpenXmglob_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar MetaTrader da Corretora XM Global", txbMT5PathXmglob, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnMT5RunXmglob_Click(object sender, EventArgs e)
        {
            // executa o MetaTrader da corretora XM Global, se estiver definido:
            if (!String.IsNullOrWhiteSpace(config.MT5PathXmglob))
                JanitorManager.startProcess(config.MT5PathXmglob, true);
        }

        private void btnMT5ExibirLogs_Click(object sender, EventArgs e)
        {
            // identifica a data do dia, para abrir o respectivo log:
            string logToday = DateTime.Now.ToString(" yyyyMMdd") + ".log";

            // Executa o batch que abre notepad++ com arquivos de logs...
            JanitorManager.runBatch(BATCH_SHOW_MT5_LOGS + logToday, false);

        }

        private void btnMT5ExibirFeriados_Click(object sender, EventArgs e)
        {
            // exibe os feriados considerados no ano corrente:
            MessageBox.Show(JanitorManager.ListFeriados(),
                            "Relação de Feriados 2022 (Dia/Mês)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        /* --- ABA COLETHON -------------------------------------------------------------------- */

        private void btnColetOpenProgram_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Programa Colethon", txbColetPathProgram, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnColetRunProgram_Click(object sender, EventArgs e)
        {
            // executa o programa do colethon, se estiver definido:
            if (!String.IsNullOrWhiteSpace(config.ColetPathProgram))
            {
                JanitorManager.startProcess(config.ColetPathProgram, true);

                // Salva este momento como a ultima data de execucao:
                config.ColetLastExecute = DateTime.Now;
                config.Save();
                txbColetLastExecute.Text = config.ColetLastExecute.ToString("dddd, dd MMMM yyyy, HH:mm");
            }
        }

        private void btnColetOpenSignal_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Arquivo de Sinalização", txbColetPathSignal, DIALOG_FILTER_ARQUIVOS);
        }

        private void btnColetDelSignal_Click(object sender, EventArgs e)
        {
            // pede confirmacao ao usuario antes de apagar o arquivo de sinalizacao:
            DialogResult dialogResult = MessageBox.Show("Confirma a exclusão do arquivo de sinalização?",
                                                        "Colethon: Excluir Arquivo de Sinalização",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            // se o usuario confirmar, apaga o arquivo:
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(config.ColetPathSignal);
            }
        }

        private void btnColetReexecutar_Click(object sender, EventArgs e)
        {
            // limpa a ultima execucao para executar novamente o programa de manutencao:
            DialogResult dialogResult = MessageBox.Show("Deseja executar novamente o programa Colethon para coletar dados?",
                                                        "Colethon: Limpar Última Execução",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            // Limpa o texto do input-text e tambem diretamente da propriedade:
            if (dialogResult == DialogResult.Yes)
            {
                txbColetLastExecute.Text = "";
                config.ColetLastExecute = DateTime.MinValue;

                // Salva as propriedades.
                config.Save();
            }
        }

        private void btnColetShowLog_Click(object sender, EventArgs e)
        {
            // Abre o logging do Colethon, utilizando o utilitario Baretail.
            JanitorManager.runBatch(LOG_FILE_COLETHON, false);
        }

        /* --- ABA LOTHON ---------------------------------------------------------------------- */

        private void btnLotoOpenProgram_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Programa Lothon", txbLotoPathProgram, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnLotoRunProgram_Click(object sender, EventArgs e)
        {
            // executa o programa do lothon, se estiver definido:
            if (!String.IsNullOrWhiteSpace(config.LotoPathProgram))
            {
                JanitorManager.startProcess(config.LotoPathProgram, true);

                // Salva este momento como a ultima data de execucao:
                config.LotoLastExecute = DateTime.Now;
                config.Save();
                txbLotoLastExecute.Text = config.LotoLastExecute.ToString("dddd, dd MMMM yyyy, HH:mm");
            }
        }

        private void btnLotoOpenSignal_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Arquivo de Sinalização", txbLotoPathSignal, DIALOG_FILTER_ARQUIVOS);
        }

        private void btnLotoDelSignal_Click(object sender, EventArgs e)
        {
            // pede confirmacao ao usuario antes de apagar o arquivo de sinalizacao:
            DialogResult dialogResult = MessageBox.Show("Confirma a exclusão do arquivo de sinalização?",
                                                        "Lothon: Excluir Arquivo de Sinalização",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            // se o usuario confirmar, apaga o arquivo:
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(config.LotoPathSignal);
            }
        }

        private void btnLotoReexecutar_Click(object sender, EventArgs e)
        {
            // limpa a ultima execucao para executar novamente o programa de manutencao:
            DialogResult dialogResult = MessageBox.Show("Deseja executar novamente o programa Lothon para gerar palpites?",
                                                        "Lothon: Limpar Última Execução",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            // Limpa o texto do input-text e tambem diretamente da propriedade:
            if (dialogResult == DialogResult.Yes)
            {
                txbLotoLastExecute.Text = "";
                config.LotoLastExecute = DateTime.MinValue;

                // Salva as propriedades.
                config.Save();
            }
        }

        private void btnLotoShowLog_Click(object sender, EventArgs e)
        {
            // Abre o logging do Lothon, utilizando o utilitario Baretail.
            JanitorManager.runBatch(LOG_FILE_LOTHON, false);
        }

        /* --- ABA QUANTHON -------------------------------------------------------------------- */

        private void btnQuantOpenProgram_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Programa Quanthon", txbQuantPathProgram, DIALOG_FILTER_PROGRAMAS);
        }

        private void btnQuantRunProgram_Click(object sender, EventArgs e)
        {
            // executa o programa do quanthon, se estiver definido:
            if (!String.IsNullOrWhiteSpace(config.QuantPathProgram))
            {
                JanitorManager.startProcess(config.QuantPathProgram, true);

                // Salva este momento como a ultima data de execucao:
                config.QuantLastExecute = DateTime.Now;
                config.Save();
                txbQuantLastExecute.Text = config.QuantLastExecute.ToString("dddd, dd MMMM yyyy, HH:mm");
            }
        }

        private void btnQuantOpenSignal_Click(object sender, EventArgs e)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            OpenFileTextBox("Procurar Arquivo de Sinalização", txbQuantPathSignal, DIALOG_FILTER_ARQUIVOS);
        }

        private void btnQuantDelSignal_Click(object sender, EventArgs e)
        {
            // pede confirmacao ao usuario antes de apagar o arquivo de sinalizacao:
            DialogResult dialogResult = MessageBox.Show("Confirma a exclusão do arquivo de sinalização?",
                                                        "Quanthon: Excluir Arquivo de Sinalização",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            // se o usuario confirmar, apaga o arquivo:
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(config.QuantPathSignal);
            }
        }

        private void btnQuantReexecutar_Click(object sender, EventArgs e)
        {
            // limpa a ultima execucao para executar novamente o programa de manutencao:
            DialogResult dialogResult = MessageBox.Show("Deseja executar novamente o programa Quanthon para analisar dados?",
                                                        "Quanthon: Limpar Última Execução",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            // Limpa o texto do input-text e tambem diretamente da propriedade:
            if (dialogResult == DialogResult.Yes)
            {
                txbQuantLastExecute.Text = "";
                config.QuantLastExecute = DateTime.MinValue;

                // Salva as propriedades.
                config.Save();
            }
        }

        private void btnQuantShowLog_Click(object sender, EventArgs e)
        {
            // Abre o logging do Quanthon, utilizando o utilitario Baretail.
            JanitorManager.runBatch(LOG_FILE_QUANTHON, false);
        }

        /* --- HELPERS ------------------------------------------------------------------------- */

        // rotina utilitaria para exibir uma janela de dialogo e atualizar um text-box associado:
        private bool OpenFileTextBox(string titulo, TextBox textBox, string filtro)
        {
            // vai abrir o dialogo ja apontando pro arquivo atual:
            string initialDir, fileName;
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                initialDir = DIALOG_INITIAL_DIR;
                fileName = "";
            }
            else
            {
                initialDir = Path.GetDirectoryName(textBox.Text);
                fileName = Path.GetFileName(textBox.Text);
            }

            fileName = OpenDialogFind(titulo, initialDir, fileName, filtro);
            if (String.IsNullOrWhiteSpace(fileName))
                return false;
            else
            {
                // ja preenche o text-box com o arquivo selecionado:
                textBox.Text = fileName;

                // atualiza a aparencia da tela, ja que preencheu o text-box:
                FrmConfig_Refresh(null, null);

                return true;
            }
        }

        // rotina utilitaria para exibir a tela de dialogo para procurar um arquivo ou programa executavel.
        private static string OpenDialogFind(string titulo, string initialDir, string fileName, string filtro)
        {
            string extension = String.IsNullOrWhiteSpace(fileName) ? "" : Path.GetExtension(fileName).ToLower();

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = titulo,
                InitialDirectory = initialDir,
                FileName = fileName,
                Filter = filtro,
                FilterIndex = (extension == ".exe" || extension == ".com") ? 2 : 1,
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            // abre o dialogo e retorna o arquivo escolhido, ou null se cancelou.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            } else
            {
                return null;
            }
        }

        // rotina utilitaria para exibir uma janela de dialogo e atualizar um text-box associado:
        private static bool OpenFolderTextBox(TextBox textBox)
        {
            // vai abrir o dialogo ja apontando pro diretorio atual:
            string selectedPath = String.IsNullOrWhiteSpace(textBox.Text) ? DIALOG_INITIAL_DIR
                                                                          : Path.GetDirectoryName(textBox.Text);

            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.SelectedPath = selectedPath;

            // abre o dialogo e retorna o arquivo escolhido, ou "" se cancelou.
            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFolderDialog.SelectedPath;
                return true;
            }
            else
                return false;
        }
    }
}
