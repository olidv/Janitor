using System;
using System.Drawing;
using System.Windows.Forms;

namespace Janitor
{
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        {
            // coleta as propriedades atuais para exibir na janela:
            // Aba Geral
            ckb_ga_habilitar.Checked = Properties.Settings.Default.GeralFlagTasks;
            ckb_ga_acertar.Checked = Properties.Settings.Default.GeralFlagClock;
            ckb_ga_nao_encerrar.Checked = Properties.Settings.Default.GeralFlagNotClose;

            // Aba MetaTrader
            ckb_mc_executar.Checked = Properties.Settings.Default.MT5FlagProgram;
            txb_mc_genial.Text = Properties.Settings.Default.MT5PathGenial;
            txb_mc_modal.Text = Properties.Settings.Default.MT5PathModal;
            txb_mc_xmg.Text = Properties.Settings.Default.MT5PathXmglob;

            // Aba Infinite
            chb_im_executar.Checked = Properties.Settings.Default.InfiFlagProgram;
            txb_im_programa.Text = Properties.Settings.Default.InfiPathProgram;
            txb_im_execucao.Text = Properties.Settings.Default.InfiLastExecute;

            // Aba Quanthon
            chb_qm_executar.Checked = Properties.Settings.Default.QuantFlagProgram;
            txb_qm_programa.Text = Properties.Settings.Default.QuantPathProgram;
            txb_qm_execucao.Text = Properties.Settings.Default.QuantLastExecute;

            // Aba Loto365
            ckb_lp_executar.Checked = Properties.Settings.Default.LotoFlagProgram;
            txb_lp_programa.Text = Properties.Settings.Default.LotoPathProgram;
            txb_lp_execucao.Text = Properties.Settings.Default.LotoLastExecute;

            // Aplica cor no checkbox principal conforme configuracao atual:
            ckb_ga_habilitar.ForeColor = ckb_ga_habilitar.Checked ? Color.Green : Color.Red;
        }

        private void tmr_clock_Tick(object sender, EventArgs e)
        {
            // a cada minuto, executa a varredura do scheduler:
            // if (DateTime.Now.Second == 0) checkScheduler();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // coleta as propriedades modificadas e salva:
            // Aba Geral
            Properties.Settings.Default.GeralFlagTasks = ckb_ga_habilitar.Checked;
            Properties.Settings.Default.GeralFlagClock = ckb_ga_acertar.Checked;
            Properties.Settings.Default.GeralFlagNotClose = ckb_ga_nao_encerrar.Checked;

            // Aba MetaTrader
            Properties.Settings.Default.MT5FlagProgram = ckb_mc_executar.Checked;
            Properties.Settings.Default.MT5PathGenial = txb_mc_genial.Text;
            Properties.Settings.Default.MT5PathModal = txb_mc_modal.Text;
            Properties.Settings.Default.MT5PathXmglob = txb_mc_xmg.Text;

            // Aba Infinite
            Properties.Settings.Default.InfiFlagProgram = chb_im_executar.Checked;
            Properties.Settings.Default.InfiPathProgram = txb_im_programa.Text;

            // Aba Quanthon
            Properties.Settings.Default.QuantFlagProgram = chb_qm_executar.Checked;
            Properties.Settings.Default.QuantPathProgram = txb_qm_programa.Text;

            // Aba Loto365
            Properties.Settings.Default.LotoFlagProgram = ckb_lp_executar.Checked;
            Properties.Settings.Default.LotoPathProgram = txb_lp_programa.Text;

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

        private void ckb_ga_habilitar_CheckedChanged(object sender, EventArgs e)
        {
            ckb_ga_habilitar.ForeColor = ckb_ga_habilitar.Checked ? Color.Green : Color.Red;
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
    }
}
