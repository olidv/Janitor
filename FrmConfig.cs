using System;
using System.Drawing;
using System.Windows.Forms;

namespace Janitor
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        { // coleta as propriedades atuais para exibir na janela:
            // Aba Geral
            ckbGeralFlagTasks.Checked = Properties.Settings.Default.GeralFlagTasks;
            ckbGeralFlagClocker.Checked = Properties.Settings.Default.GeralFlagClocker;
            ckbGeralFlagNotClose.Checked = Properties.Settings.Default.GeralFlagNotClose;

            // Aba MetaTrader
            ckbMT5FlagProgram.Checked = Properties.Settings.Default.MT5FlagProgram;
            txbMT5PathGenial.Text = Properties.Settings.Default.MT5PathGenial;
            txbMT5PathModal.Text = Properties.Settings.Default.MT5PathModal;
            txbMT5PathXmglob.Text = Properties.Settings.Default.MT5PathXmglob;

            // Aba Colethon
            chbColetFlagProgram.Checked = Properties.Settings.Default.ColetFlagProgram;
            txbColetPathProgram.Text = Properties.Settings.Default.ColetPathProgram;
            txbColetLastExecute.Text = Properties.Settings.Default.ColetLastExecute;

            // Aba Quanthon
            chbQuantFlagProgram.Checked = Properties.Settings.Default.QuantFlagProgram;
            txbQuantPathProgram.Text = Properties.Settings.Default.QuantPathProgram;
            txbQuantLastExecute.Text = Properties.Settings.Default.QuantLastExecute;

            // Aba Loto365
            ckbLotoFlagProgram.Checked = Properties.Settings.Default.LotoFlagProgram;
            txbLotoPathProgram.Text = Properties.Settings.Default.LotoPathProgram;
            txbLotoLastExecute.Text = Properties.Settings.Default.LotoLastExecute;

            // atualiza a aparencia da tela conforme as propriedades:
            FrmConfig_Refresh(null, null);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {  // coleta as propriedades modificadas e salva:
            // Aba Geral
            Properties.Settings.Default.GeralFlagTasks = ckbGeralFlagTasks.Checked;
            Properties.Settings.Default.GeralFlagClocker = ckbGeralFlagClocker.Checked;
            Properties.Settings.Default.GeralFlagNotClose = ckbGeralFlagNotClose.Checked;

            // Aba MetaTrader
            Properties.Settings.Default.MT5FlagProgram = ckbMT5FlagProgram.Checked;
            Properties.Settings.Default.MT5PathGenial = txbMT5PathGenial.Text;
            Properties.Settings.Default.MT5PathModal = txbMT5PathModal.Text;
            Properties.Settings.Default.MT5PathXmglob = txbMT5PathXmglob.Text;

            // Aba Colethon
            Properties.Settings.Default.ColetFlagProgram = chbColetFlagProgram.Checked;
            Properties.Settings.Default.ColetPathProgram = txbColetPathProgram.Text;

            // Aba Quanthon
            Properties.Settings.Default.QuantFlagProgram = chbQuantFlagProgram.Checked;
            Properties.Settings.Default.QuantPathProgram = txbQuantPathProgram.Text;

            // Aba Loto365
            Properties.Settings.Default.LotoFlagProgram = ckbLotoFlagProgram.Checked;
            Properties.Settings.Default.LotoPathProgram = txbLotoPathProgram.Text;

            // Salva as propriedades.
            Properties.Settings.Default.Save();

            // fecha o formulario:
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // fecha o formulario:
            this.Close();
        }

        private void btn_ga_encerrar_Click(object sender, EventArgs e)
        {
            // encerra todas as tarefas em execucao:
            DialogResult dialogResult = MessageBox.Show("Deseja encerrar todas as tarefas em execução?",
                                                        "Atenção: Encerrar Todas as Tarefas",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

            }
        }

        private void btn_ga_feriados_Click(object sender, EventArgs e)
        {
            string feriados = "Feriados Nacionais (B3):\n";
            feriados += "\t07/09\n";
            feriados += "\nFeriados Internacionais (FOREX):\n";
            feriados += "\t25/12\n";

            // exibe os feriados considerados no ano corrente:
            MessageBox.Show(feriados,
                            "Relação de Feriados 2022 (Dia/Mês)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        /// atualiza a aparencia da tela conforme as propriedades:
        private void FrmConfig_Refresh(object sender, EventArgs e)
        {  
            // Aba Geral
            ckbGeralFlagTasks.ForeColor = ckbGeralFlagTasks.Checked ? Color.Blue : Color.DarkGray;
            ckbGeralFlagNotClose.ForeColor = ckbGeralFlagNotClose.Checked ? Color.Red : Color.Black;

            // Aba MetaTrader
            txbMT5PathGenial.Enabled = ckbMT5FlagProgram.Checked;
            txbMT5PathModal.Enabled = ckbMT5FlagProgram.Checked;
            txbMT5PathXmglob.Enabled = ckbMT5FlagProgram.Checked;

            // Aba Colethon
            txbColetPathProgram.Enabled = chbColetFlagProgram.Checked;
            btnColetReexecutar.Enabled = chbColetFlagProgram.Checked;

            // Aba Quanthon
            txbQuantPathProgram.Enabled = chbQuantFlagProgram.Checked;
            btnQuantReexecutar.Enabled = chbQuantFlagProgram.Checked;

            // Aba Loto365
            txbLotoPathProgram.Enabled = ckbLotoFlagProgram.Checked;
            btnLotoReexecutar.Enabled = ckbLotoFlagProgram.Checked;
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
                Properties.Settings.Default.ColetLastExecute = null;

                // Salva as propriedades.
                Properties.Settings.Default.Save();
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
                Properties.Settings.Default.QuantLastExecute = null;

                // Salva as propriedades.
                Properties.Settings.Default.Save();
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
                Properties.Settings.Default.LotoLastExecute = null;

                // Salva as propriedades.
                Properties.Settings.Default.Save();
            }
        }
    }
}
