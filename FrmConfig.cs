﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Janitor.Properties;

namespace Janitor
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        { 
            // coleta as propriedades atuais para exibir na janela:
            Settings config = Properties.Settings.Default;

            // Aba Geral
            ckbGeralFlagTasks.Checked = config.GeralFlagTasks;
            ckbGeralFlagClocker.Checked = config.GeralFlagClocker;
            ckbGeralFlagNotClose.Checked = config.GeralFlagNotClose;
            toolTips.SetToolTip(ckbGeralFlagTasks, "Clique para habilitar ou desabilitar o agendamento das tarefas.");
            toolTips.SetToolTip(ckbGeralFlagClocker, "Clique para habilitar ou desabilitar a correção do relógio interno.");
            toolTips.SetToolTip(ckbGeralFlagNotClose, "Clique para ignorar ou não o encerramento das tarefas.");
            toolTips.SetToolTip(btnGeralEncerrarTarefas, "Clique para encerrar todas as tarefas em execução.");
            toolTips.SetToolTip(btnMT5ExibirFeriados, "Clique para exibir os feriados nacionais (B3) e internacionais (FOREX).");

            // Aba MetaTrader
            ckbMT5FlagProgram.Checked = config.MT5FlagProgram;
            txbMT5PathGenial.Text = config.MT5PathGenial;
            txbMT5PathModal.Text = config.MT5PathModal;
            txbMT5PathXmglob.Text = config.MT5PathXmglob;
            toolTips.SetToolTip(ckbMT5FlagProgram, "Clique para habilitar ou desabilitar a execução do MetaTrader.");
            toolTips.SetToolTip(txbMT5PathGenial, "Caminho completo do MetaTrader da corretora Genial.");
            toolTips.SetToolTip(lblMT5PathGenial, "Caminho completo do MetaTrader da corretora Genial.");
            toolTips.SetToolTip(txbMT5PathModal, "Caminho completo do MetaTrader da corretora ModalMais.");
            toolTips.SetToolTip(lblMT5PathModal, "Caminho completo do MetaTrader da corretora ModalMais.");
            toolTips.SetToolTip(txbMT5PathXmglob, "Caminho completo do MetaTrader da corretora XM Global.");
            toolTips.SetToolTip(lblMT5PathXmglob, "Caminho completo do MetaTrader da corretora XM Global.");

            // Aba Colethon
            chbColetFlagProgram.Checked = config.ColetFlagProgram;
            txbColetPathProgram.Text = config.ColetPathProgram;
            if (config.ColetLastExecute > DateTime.MinValue) 
                txbColetLastExecute.Text = config.ColetLastExecute.ToString("dddd, dd MMMM yyyy | HH:mm:ss");
            toolTips.SetToolTip(chbColetFlagProgram, "Clique para habilitar ou desabilitar a execução do Colethon.");
            toolTips.SetToolTip(txbColetPathProgram, "Caminho completo do executável Colethon.");
            toolTips.SetToolTip(lblColetPathProgram, "Caminho completo do executável Colethon.");
            toolTips.SetToolTip(txbColetLastExecute, "Última data/hora de execução do Colethon.");
            toolTips.SetToolTip(lblColetLastExecute, "Última data/hora de execução do Colethon.");
            toolTips.SetToolTip(btnColetReexecutar, "Clique para executar novamente o Colethon.");

            // Aba Quanthon
            chbQuantFlagProgram.Checked = config.QuantFlagProgram;
            txbQuantPathProgram.Text = config.QuantPathProgram;
            if (config.ColetLastExecute > DateTime.MinValue) 
                txbQuantLastExecute.Text = config.QuantLastExecute.ToString("dddd, dd MMMM yyyy | HH:mm:ss");
            toolTips.SetToolTip(chbQuantFlagProgram, "Clique para habilitar ou desabilitar a execução do Quanthon.");
            toolTips.SetToolTip(txbQuantPathProgram, "Caminho completo do executável Quanthon.");
            toolTips.SetToolTip(lblQuantPathProgram, "Caminho completo do executável Quanthon.");
            toolTips.SetToolTip(txbQuantLastExecute, "Última data/hora de execução do Quanthon.");
            toolTips.SetToolTip(lblQuantLastExecute, "Última data/hora de execução do Quanthon.");
            toolTips.SetToolTip(btnQuantReexecutar, "Clique para executar novamente o Quanthon.");

            // Aba Loto365
            ckbLotoFlagProgram.Checked = config.LotoFlagProgram;
            txbLotoPathProgram.Text = config.LotoPathProgram;
            if (config.ColetLastExecute > DateTime.MinValue) 
                txbLotoLastExecute.Text = config.LotoLastExecute.ToString("dddd, dd MMMM yyyy | HH:mm:ss");
            toolTips.SetToolTip(ckbLotoFlagProgram, "Clique para habilitar ou desabilitar a execução do Lothon.");
            toolTips.SetToolTip(txbLotoPathProgram, "Caminho completo do executável Lothon.");
            toolTips.SetToolTip(lblLotoPathProgram, "Caminho completo do executável Lothon.");
            toolTips.SetToolTip(txbLotoLastExecute, "Última data/hora de execução do Lothon.");
            toolTips.SetToolTip(lblLotoLastExecute, "Última data/hora de execução do Lothon.");
            toolTips.SetToolTip(btnLotoReexecutar, "Clique para executar novamente o Lothon.");

            //
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            // coleta as propriedades modificadas e salva:
            Settings config = Properties.Settings.Default;

            // Aba Geral
            config.GeralFlagTasks = ckbGeralFlagTasks.Checked;
            config.GeralFlagClocker = ckbGeralFlagClocker.Checked;
            config.GeralFlagNotClose = ckbGeralFlagNotClose.Checked;

            // Aba MetaTrader
            config.MT5FlagProgram = ckbMT5FlagProgram.Checked;
            config.MT5PathGenial = txbMT5PathGenial.Text;
            config.MT5PathModal = txbMT5PathModal.Text;
            config.MT5PathXmglob = txbMT5PathXmglob.Text;

            // Aba Colethon
            config.ColetFlagProgram = chbColetFlagProgram.Checked;
            config.ColetPathProgram = txbColetPathProgram.Text;

            // Aba Quanthon
            config.QuantFlagProgram = chbQuantFlagProgram.Checked;
            config.QuantPathProgram = txbQuantPathProgram.Text;

            // Aba Loto365
            config.LotoFlagProgram = ckbLotoFlagProgram.Checked;
            config.LotoPathProgram = txbLotoPathProgram.Text;

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

        private void btnGeralCheckTarefas_Click(object sender, EventArgs e)
        {
            Settings config = Properties.Settings.Default;

            // Executa o batch que verifica o logging das tarefas em busca de alertas (WARN) e erros (ERROR).
            JanitorManager.openBatch(config.GeralCheckProgram, true);
        }

        private void btnGeralEncerrarTarefas_Click(object sender, EventArgs e)
        {
            // encerra todas as tarefas em execucao:
            DialogResult dialogResult = MessageBox.Show("Deseja encerrar todas as tarefas em execução?",
                                                        "Atenção: Encerrar Todas as Tarefas",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {  // Comunica ao Manager para encerrar todas as tarefas em execucao:
                JanitorManager.ListFeriados();
            }
        }

        private void btnMT5ExibirFeriados_Click(object sender, EventArgs e)
        {
            // exibe os feriados considerados no ano corrente:
            MessageBox.Show(JanitorManager.ListFeriados(),
                            "Relação de Feriados 2022 (Dia/Mês)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
        }

        private void btnColetReexecutar_Click(object sender, EventArgs e)
        {
            Settings config = Properties.Settings.Default;

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

        private void btnQuantReexecutar_Click(object sender, EventArgs e)
        {
            Settings config = Properties.Settings.Default;

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

        private void btnLotoReexecutar_Click(object sender, EventArgs e)
        {
            Settings config = Properties.Settings.Default;

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
    }
}
