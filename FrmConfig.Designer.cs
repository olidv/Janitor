
namespace Janitor
{
    partial class FrmConfig
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbcPanel = new System.Windows.Forms.TabControl();
            this.tbpGeral = new System.Windows.Forms.TabPage();
            this.grbGeralAgendador = new System.Windows.Forms.GroupBox();
            this.btnGeralEncerrarTarefas = new System.Windows.Forms.Button();
            this.ckbGeralFlagClocker = new System.Windows.Forms.CheckBox();
            this.ckbGeralFlagNotClose = new System.Windows.Forms.CheckBox();
            this.ckbGeralFlagTasks = new System.Windows.Forms.CheckBox();
            this.tbpMetatrader = new System.Windows.Forms.TabPage();
            this.grpMetatraderTrading = new System.Windows.Forms.GroupBox();
            this.btnMT5ExibirFeriados = new System.Windows.Forms.Button();
            this.lblMT5PathModal = new System.Windows.Forms.Label();
            this.txbMT5PathModal = new System.Windows.Forms.TextBox();
            this.txbMT5PathXmglob = new System.Windows.Forms.TextBox();
            this.lblMT5PathXmglob = new System.Windows.Forms.Label();
            this.txbMT5PathGenial = new System.Windows.Forms.TextBox();
            this.lblMT5PathGenial = new System.Windows.Forms.Label();
            this.ckbMT5FlagProgram = new System.Windows.Forms.CheckBox();
            this.tbpColethon = new System.Windows.Forms.TabPage();
            this.grbColethonManutencao = new System.Windows.Forms.GroupBox();
            this.btnColetReexecutar = new System.Windows.Forms.Button();
            this.txbColetLastExecute = new System.Windows.Forms.TextBox();
            this.lblColetLastExecute = new System.Windows.Forms.Label();
            this.txbColetPathProgram = new System.Windows.Forms.TextBox();
            this.lblColetPathProgram = new System.Windows.Forms.Label();
            this.chbColetFlagProgram = new System.Windows.Forms.CheckBox();
            this.tbpQuanthon = new System.Windows.Forms.TabPage();
            this.grbQuanthonManutencao = new System.Windows.Forms.GroupBox();
            this.btnQuantReexecutar = new System.Windows.Forms.Button();
            this.txbQuantLastExecute = new System.Windows.Forms.TextBox();
            this.lblQuantLastExecute = new System.Windows.Forms.Label();
            this.txbQuantPathProgram = new System.Windows.Forms.TextBox();
            this.lblQuantPathProgram = new System.Windows.Forms.Label();
            this.chbQuantFlagProgram = new System.Windows.Forms.CheckBox();
            this.tbpLoto365 = new System.Windows.Forms.TabPage();
            this.grbLoto365Manutencao = new System.Windows.Forms.GroupBox();
            this.btnLotoReexecutar = new System.Windows.Forms.Button();
            this.txbLotoLastExecute = new System.Windows.Forms.TextBox();
            this.lblLotoLastExecute = new System.Windows.Forms.Label();
            this.txbLotoPathProgram = new System.Windows.Forms.TextBox();
            this.lblLotoPathProgram = new System.Windows.Forms.Label();
            this.ckbLotoFlagProgram = new System.Windows.Forms.CheckBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnGeralCheckTarefas = new System.Windows.Forms.Button();
            this.tbcPanel.SuspendLayout();
            this.tbpGeral.SuspendLayout();
            this.grbGeralAgendador.SuspendLayout();
            this.tbpMetatrader.SuspendLayout();
            this.grpMetatraderTrading.SuspendLayout();
            this.tbpColethon.SuspendLayout();
            this.grbColethonManutencao.SuspendLayout();
            this.tbpQuanthon.SuspendLayout();
            this.grbQuanthonManutencao.SuspendLayout();
            this.tbpLoto365.SuspendLayout();
            this.grbLoto365Manutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(194, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 100;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(277, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbcPanel
            // 
            this.tbcPanel.Controls.Add(this.tbpGeral);
            this.tbcPanel.Controls.Add(this.tbpMetatrader);
            this.tbcPanel.Controls.Add(this.tbpColethon);
            this.tbcPanel.Controls.Add(this.tbpLoto365);
            this.tbcPanel.Controls.Add(this.tbpQuanthon);
            this.tbcPanel.Location = new System.Drawing.Point(10, 10);
            this.tbcPanel.Name = "tbcPanel";
            this.tbcPanel.SelectedIndex = 0;
            this.tbcPanel.Size = new System.Drawing.Size(343, 183);
            this.tbcPanel.TabIndex = 1;
            // 
            // tbpGeral
            // 
            this.tbpGeral.Controls.Add(this.grbGeralAgendador);
            this.tbpGeral.Location = new System.Drawing.Point(4, 22);
            this.tbpGeral.Name = "tbpGeral";
            this.tbpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeral.Size = new System.Drawing.Size(335, 157);
            this.tbpGeral.TabIndex = 0;
            this.tbpGeral.Text = "Geral";
            this.tbpGeral.UseVisualStyleBackColor = true;
            // 
            // grbGeralAgendador
            // 
            this.grbGeralAgendador.Controls.Add(this.btnGeralCheckTarefas);
            this.grbGeralAgendador.Controls.Add(this.btnGeralEncerrarTarefas);
            this.grbGeralAgendador.Controls.Add(this.ckbGeralFlagClocker);
            this.grbGeralAgendador.Controls.Add(this.ckbGeralFlagNotClose);
            this.grbGeralAgendador.Controls.Add(this.ckbGeralFlagTasks);
            this.grbGeralAgendador.Location = new System.Drawing.Point(7, 9);
            this.grbGeralAgendador.Name = "grbGeralAgendador";
            this.grbGeralAgendador.Size = new System.Drawing.Size(319, 140);
            this.grbGeralAgendador.TabIndex = 0;
            this.grbGeralAgendador.TabStop = false;
            this.grbGeralAgendador.Text = "Agendador de Tarefas";
            // 
            // btnGeralEncerrarTarefas
            // 
            this.btnGeralEncerrarTarefas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeralEncerrarTarefas.Image = global::Janitor.Properties.Resources.png_close;
            this.btnGeralEncerrarTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeralEncerrarTarefas.Location = new System.Drawing.Point(163, 101);
            this.btnGeralEncerrarTarefas.Name = "btnGeralEncerrarTarefas";
            this.btnGeralEncerrarTarefas.Size = new System.Drawing.Size(146, 23);
            this.btnGeralEncerrarTarefas.TabIndex = 5;
            this.btnGeralEncerrarTarefas.Text = "Encerrar Tarefas...";
            this.btnGeralEncerrarTarefas.UseVisualStyleBackColor = true;
            this.btnGeralEncerrarTarefas.Click += new System.EventHandler(this.btnGeralEncerrarTarefas_Click);
            // 
            // ckbGeralFlagClocker
            // 
            this.ckbGeralFlagClocker.AutoSize = true;
            this.ckbGeralFlagClocker.Location = new System.Drawing.Point(11, 48);
            this.ckbGeralFlagClocker.Name = "ckbGeralFlagClocker";
            this.ckbGeralFlagClocker.Size = new System.Drawing.Size(252, 17);
            this.ckbGeralFlagClocker.TabIndex = 2;
            this.ckbGeralFlagClocker.Text = "Acertar as horas do computador periodicamente";
            this.ckbGeralFlagClocker.UseVisualStyleBackColor = true;
            // 
            // ckbGeralFlagNotClose
            // 
            this.ckbGeralFlagNotClose.AutoSize = true;
            this.ckbGeralFlagNotClose.Location = new System.Drawing.Point(11, 74);
            this.ckbGeralFlagNotClose.Name = "ckbGeralFlagNotClose";
            this.ckbGeralFlagNotClose.Size = new System.Drawing.Size(240, 17);
            this.ckbGeralFlagNotClose.TabIndex = 3;
            this.ckbGeralFlagNotClose.Text = "NÃO encerrar aplicativos ainda em execução";
            this.ckbGeralFlagNotClose.UseVisualStyleBackColor = true;
            this.ckbGeralFlagNotClose.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // ckbGeralFlagTasks
            // 
            this.ckbGeralFlagTasks.AutoSize = true;
            this.ckbGeralFlagTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGeralFlagTasks.Location = new System.Drawing.Point(11, 22);
            this.ckbGeralFlagTasks.Name = "ckbGeralFlagTasks";
            this.ckbGeralFlagTasks.Size = new System.Drawing.Size(249, 17);
            this.ckbGeralFlagTasks.TabIndex = 1;
            this.ckbGeralFlagTasks.Text = "Habilitar agendamento diário de tarefas";
            this.ckbGeralFlagTasks.UseVisualStyleBackColor = true;
            this.ckbGeralFlagTasks.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // tbpMetatrader
            // 
            this.tbpMetatrader.Controls.Add(this.grpMetatraderTrading);
            this.tbpMetatrader.Location = new System.Drawing.Point(4, 22);
            this.tbpMetatrader.Name = "tbpMetatrader";
            this.tbpMetatrader.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMetatrader.Size = new System.Drawing.Size(335, 157);
            this.tbpMetatrader.TabIndex = 2;
            this.tbpMetatrader.Text = "MetaTrader";
            this.tbpMetatrader.UseVisualStyleBackColor = true;
            // 
            // grpMetatraderTrading
            // 
            this.grpMetatraderTrading.Controls.Add(this.btnMT5ExibirFeriados);
            this.grpMetatraderTrading.Controls.Add(this.lblMT5PathModal);
            this.grpMetatraderTrading.Controls.Add(this.txbMT5PathModal);
            this.grpMetatraderTrading.Controls.Add(this.txbMT5PathXmglob);
            this.grpMetatraderTrading.Controls.Add(this.lblMT5PathXmglob);
            this.grpMetatraderTrading.Controls.Add(this.txbMT5PathGenial);
            this.grpMetatraderTrading.Controls.Add(this.lblMT5PathGenial);
            this.grpMetatraderTrading.Controls.Add(this.ckbMT5FlagProgram);
            this.grpMetatraderTrading.Location = new System.Drawing.Point(7, 9);
            this.grpMetatraderTrading.Name = "grpMetatraderTrading";
            this.grpMetatraderTrading.Size = new System.Drawing.Size(319, 140);
            this.grpMetatraderTrading.TabIndex = 0;
            this.grpMetatraderTrading.TabStop = false;
            this.grpMetatraderTrading.Text = "Algo Trading com Robôs";
            // 
            // btnMT5ExibirFeriados
            // 
            this.btnMT5ExibirFeriados.Image = global::Janitor.Properties.Resources.png_info;
            this.btnMT5ExibirFeriados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMT5ExibirFeriados.Location = new System.Drawing.Point(196, 18);
            this.btnMT5ExibirFeriados.Name = "btnMT5ExibirFeriados";
            this.btnMT5ExibirFeriados.Size = new System.Drawing.Size(112, 23);
            this.btnMT5ExibirFeriados.TabIndex = 2;
            this.btnMT5ExibirFeriados.Text = "Exibir Feriados...";
            this.btnMT5ExibirFeriados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMT5ExibirFeriados.UseVisualStyleBackColor = true;
            this.btnMT5ExibirFeriados.Click += new System.EventHandler(this.btnMT5ExibirFeriados_Click);
            // 
            // lblMT5PathModal
            // 
            this.lblMT5PathModal.AutoSize = true;
            this.lblMT5PathModal.Location = new System.Drawing.Point(7, 79);
            this.lblMT5PathModal.Name = "lblMT5PathModal";
            this.lblMT5PathModal.Size = new System.Drawing.Size(107, 13);
            this.lblMT5PathModal.TabIndex = 0;
            this.lblMT5PathModal.Text = "Corretora ModalMais:";
            this.lblMT5PathModal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbMT5PathModal
            // 
            this.txbMT5PathModal.Location = new System.Drawing.Point(115, 76);
            this.txbMT5PathModal.Name = "txbMT5PathModal";
            this.txbMT5PathModal.Size = new System.Drawing.Size(193, 20);
            this.txbMT5PathModal.TabIndex = 4;
            // 
            // txbMT5PathXmglob
            // 
            this.txbMT5PathXmglob.Location = new System.Drawing.Point(115, 103);
            this.txbMT5PathXmglob.Name = "txbMT5PathXmglob";
            this.txbMT5PathXmglob.Size = new System.Drawing.Size(193, 20);
            this.txbMT5PathXmglob.TabIndex = 5;
            // 
            // lblMT5PathXmglob
            // 
            this.lblMT5PathXmglob.AutoSize = true;
            this.lblMT5PathXmglob.Location = new System.Drawing.Point(7, 106);
            this.lblMT5PathXmglob.Name = "lblMT5PathXmglob";
            this.lblMT5PathXmglob.Size = new System.Drawing.Size(105, 13);
            this.lblMT5PathXmglob.TabIndex = 0;
            this.lblMT5PathXmglob.Text = "Corretora XM Global:";
            // 
            // txbMT5PathGenial
            // 
            this.txbMT5PathGenial.Location = new System.Drawing.Point(115, 49);
            this.txbMT5PathGenial.Name = "txbMT5PathGenial";
            this.txbMT5PathGenial.Size = new System.Drawing.Size(193, 20);
            this.txbMT5PathGenial.TabIndex = 3;
            // 
            // lblMT5PathGenial
            // 
            this.lblMT5PathGenial.AutoSize = true;
            this.lblMT5PathGenial.Location = new System.Drawing.Point(7, 52);
            this.lblMT5PathGenial.Name = "lblMT5PathGenial";
            this.lblMT5PathGenial.Size = new System.Drawing.Size(86, 13);
            this.lblMT5PathGenial.TabIndex = 0;
            this.lblMT5PathGenial.Text = "Corretora Genial:";
            this.lblMT5PathGenial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbMT5FlagProgram
            // 
            this.ckbMT5FlagProgram.AutoSize = true;
            this.ckbMT5FlagProgram.Location = new System.Drawing.Point(11, 22);
            this.ckbMT5FlagProgram.Name = "ckbMT5FlagProgram";
            this.ckbMT5FlagProgram.Size = new System.Drawing.Size(183, 17);
            this.ckbMT5FlagProgram.TabIndex = 1;
            this.ckbMT5FlagProgram.Text = "Executar MetaTrader diariamente";
            this.ckbMT5FlagProgram.UseVisualStyleBackColor = true;
            this.ckbMT5FlagProgram.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // tbpColethon
            // 
            this.tbpColethon.Controls.Add(this.grbColethonManutencao);
            this.tbpColethon.Location = new System.Drawing.Point(4, 22);
            this.tbpColethon.Name = "tbpColethon";
            this.tbpColethon.Padding = new System.Windows.Forms.Padding(3);
            this.tbpColethon.Size = new System.Drawing.Size(335, 157);
            this.tbpColethon.TabIndex = 4;
            this.tbpColethon.Text = "Colethon";
            this.tbpColethon.UseVisualStyleBackColor = true;
            // 
            // grbColethonManutencao
            // 
            this.grbColethonManutencao.Controls.Add(this.btnColetReexecutar);
            this.grbColethonManutencao.Controls.Add(this.txbColetLastExecute);
            this.grbColethonManutencao.Controls.Add(this.lblColetLastExecute);
            this.grbColethonManutencao.Controls.Add(this.txbColetPathProgram);
            this.grbColethonManutencao.Controls.Add(this.lblColetPathProgram);
            this.grbColethonManutencao.Controls.Add(this.chbColetFlagProgram);
            this.grbColethonManutencao.Location = new System.Drawing.Point(7, 9);
            this.grbColethonManutencao.Name = "grbColethonManutencao";
            this.grbColethonManutencao.Size = new System.Drawing.Size(319, 140);
            this.grbColethonManutencao.TabIndex = 1;
            this.grbColethonManutencao.TabStop = false;
            this.grbColethonManutencao.Text = "Coleta Diária de Dados";
            // 
            // btnColetReexecutar
            // 
            this.btnColetReexecutar.BackgroundImage = global::Janitor.Properties.Resources.png_clear;
            this.btnColetReexecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColetReexecutar.Location = new System.Drawing.Point(287, 102);
            this.btnColetReexecutar.Name = "btnColetReexecutar";
            this.btnColetReexecutar.Size = new System.Drawing.Size(22, 22);
            this.btnColetReexecutar.TabIndex = 3;
            this.btnColetReexecutar.UseVisualStyleBackColor = true;
            this.btnColetReexecutar.Click += new System.EventHandler(this.btnColetReexecutar_Click);
            // 
            // txbColetLastExecute
            // 
            this.txbColetLastExecute.Enabled = false;
            this.txbColetLastExecute.Location = new System.Drawing.Point(128, 103);
            this.txbColetLastExecute.Name = "txbColetLastExecute";
            this.txbColetLastExecute.Size = new System.Drawing.Size(155, 20);
            this.txbColetLastExecute.TabIndex = 0;
            // 
            // lblColetLastExecute
            // 
            this.lblColetLastExecute.AutoSize = true;
            this.lblColetLastExecute.Location = new System.Drawing.Point(7, 106);
            this.lblColetLastExecute.Name = "lblColetLastExecute";
            this.lblColetLastExecute.Size = new System.Drawing.Size(90, 13);
            this.lblColetLastExecute.TabIndex = 0;
            this.lblColetLastExecute.Text = "Última Execução:";
            // 
            // txbColetPathProgram
            // 
            this.txbColetPathProgram.Location = new System.Drawing.Point(11, 70);
            this.txbColetPathProgram.Name = "txbColetPathProgram";
            this.txbColetPathProgram.Size = new System.Drawing.Size(297, 20);
            this.txbColetPathProgram.TabIndex = 2;
            // 
            // lblColetPathProgram
            // 
            this.lblColetPathProgram.AutoSize = true;
            this.lblColetPathProgram.Location = new System.Drawing.Point(7, 52);
            this.lblColetPathProgram.Name = "lblColetPathProgram";
            this.lblColetPathProgram.Size = new System.Drawing.Size(99, 13);
            this.lblColetPathProgram.TabIndex = 0;
            this.lblColetPathProgram.Text = "Local do Programa:";
            this.lblColetPathProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbColetFlagProgram
            // 
            this.chbColetFlagProgram.AutoSize = true;
            this.chbColetFlagProgram.Location = new System.Drawing.Point(11, 22);
            this.chbColetFlagProgram.Name = "chbColetFlagProgram";
            this.chbColetFlagProgram.Size = new System.Drawing.Size(263, 17);
            this.chbColetFlagProgram.TabIndex = 1;
            this.chbColetFlagProgram.Text = "Executar programa diariamente para coletar dados";
            this.chbColetFlagProgram.UseVisualStyleBackColor = true;
            this.chbColetFlagProgram.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // tbpQuanthon
            // 
            this.tbpQuanthon.Controls.Add(this.grbQuanthonManutencao);
            this.tbpQuanthon.Location = new System.Drawing.Point(4, 22);
            this.tbpQuanthon.Name = "tbpQuanthon";
            this.tbpQuanthon.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQuanthon.Size = new System.Drawing.Size(335, 157);
            this.tbpQuanthon.TabIndex = 3;
            this.tbpQuanthon.Text = "Quanthon";
            this.tbpQuanthon.UseVisualStyleBackColor = true;
            // 
            // grbQuanthonManutencao
            // 
            this.grbQuanthonManutencao.Controls.Add(this.btnQuantReexecutar);
            this.grbQuanthonManutencao.Controls.Add(this.txbQuantLastExecute);
            this.grbQuanthonManutencao.Controls.Add(this.lblQuantLastExecute);
            this.grbQuanthonManutencao.Controls.Add(this.txbQuantPathProgram);
            this.grbQuanthonManutencao.Controls.Add(this.lblQuantPathProgram);
            this.grbQuanthonManutencao.Controls.Add(this.chbQuantFlagProgram);
            this.grbQuanthonManutencao.Location = new System.Drawing.Point(7, 9);
            this.grbQuanthonManutencao.Name = "grbQuanthonManutencao";
            this.grbQuanthonManutencao.Size = new System.Drawing.Size(319, 140);
            this.grbQuanthonManutencao.TabIndex = 0;
            this.grbQuanthonManutencao.TabStop = false;
            this.grbQuanthonManutencao.Text = "Análise de Dados Coletados";
            // 
            // btnQuantReexecutar
            // 
            this.btnQuantReexecutar.BackgroundImage = global::Janitor.Properties.Resources.png_clear;
            this.btnQuantReexecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantReexecutar.Location = new System.Drawing.Point(287, 102);
            this.btnQuantReexecutar.Name = "btnQuantReexecutar";
            this.btnQuantReexecutar.Size = new System.Drawing.Size(22, 22);
            this.btnQuantReexecutar.TabIndex = 3;
            this.btnQuantReexecutar.UseVisualStyleBackColor = true;
            this.btnQuantReexecutar.Click += new System.EventHandler(this.btnQuantReexecutar_Click);
            // 
            // txbQuantLastExecute
            // 
            this.txbQuantLastExecute.Enabled = false;
            this.txbQuantLastExecute.Location = new System.Drawing.Point(128, 103);
            this.txbQuantLastExecute.Name = "txbQuantLastExecute";
            this.txbQuantLastExecute.Size = new System.Drawing.Size(155, 20);
            this.txbQuantLastExecute.TabIndex = 0;
            // 
            // lblQuantLastExecute
            // 
            this.lblQuantLastExecute.AutoSize = true;
            this.lblQuantLastExecute.Location = new System.Drawing.Point(7, 106);
            this.lblQuantLastExecute.Name = "lblQuantLastExecute";
            this.lblQuantLastExecute.Size = new System.Drawing.Size(90, 13);
            this.lblQuantLastExecute.TabIndex = 0;
            this.lblQuantLastExecute.Text = "Última Execução:";
            // 
            // txbQuantPathProgram
            // 
            this.txbQuantPathProgram.Location = new System.Drawing.Point(11, 70);
            this.txbQuantPathProgram.Name = "txbQuantPathProgram";
            this.txbQuantPathProgram.Size = new System.Drawing.Size(297, 20);
            this.txbQuantPathProgram.TabIndex = 2;
            // 
            // lblQuantPathProgram
            // 
            this.lblQuantPathProgram.AutoSize = true;
            this.lblQuantPathProgram.Location = new System.Drawing.Point(7, 52);
            this.lblQuantPathProgram.Name = "lblQuantPathProgram";
            this.lblQuantPathProgram.Size = new System.Drawing.Size(99, 13);
            this.lblQuantPathProgram.TabIndex = 0;
            this.lblQuantPathProgram.Text = "Local do Programa:";
            this.lblQuantPathProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbQuantFlagProgram
            // 
            this.chbQuantFlagProgram.AutoSize = true;
            this.chbQuantFlagProgram.Location = new System.Drawing.Point(11, 22);
            this.chbQuantFlagProgram.Name = "chbQuantFlagProgram";
            this.chbQuantFlagProgram.Size = new System.Drawing.Size(267, 17);
            this.chbQuantFlagProgram.TabIndex = 1;
            this.chbQuantFlagProgram.Text = "Executar programa diariamente para analisar dados";
            this.chbQuantFlagProgram.UseVisualStyleBackColor = true;
            this.chbQuantFlagProgram.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // tbpLoto365
            // 
            this.tbpLoto365.Controls.Add(this.grbLoto365Manutencao);
            this.tbpLoto365.Location = new System.Drawing.Point(4, 22);
            this.tbpLoto365.Name = "tbpLoto365";
            this.tbpLoto365.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoto365.Size = new System.Drawing.Size(335, 157);
            this.tbpLoto365.TabIndex = 1;
            this.tbpLoto365.Text = "Loto365";
            this.tbpLoto365.UseVisualStyleBackColor = true;
            // 
            // grbLoto365Manutencao
            // 
            this.grbLoto365Manutencao.Controls.Add(this.btnLotoReexecutar);
            this.grbLoto365Manutencao.Controls.Add(this.txbLotoLastExecute);
            this.grbLoto365Manutencao.Controls.Add(this.lblLotoLastExecute);
            this.grbLoto365Manutencao.Controls.Add(this.txbLotoPathProgram);
            this.grbLoto365Manutencao.Controls.Add(this.lblLotoPathProgram);
            this.grbLoto365Manutencao.Controls.Add(this.ckbLotoFlagProgram);
            this.grbLoto365Manutencao.Location = new System.Drawing.Point(7, 9);
            this.grbLoto365Manutencao.Name = "grbLoto365Manutencao";
            this.grbLoto365Manutencao.Size = new System.Drawing.Size(319, 140);
            this.grbLoto365Manutencao.TabIndex = 0;
            this.grbLoto365Manutencao.TabStop = false;
            this.grbLoto365Manutencao.Text = "Publicação de Palpites";
            // 
            // btnLotoReexecutar
            // 
            this.btnLotoReexecutar.BackgroundImage = global::Janitor.Properties.Resources.png_clear;
            this.btnLotoReexecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotoReexecutar.Location = new System.Drawing.Point(287, 102);
            this.btnLotoReexecutar.Name = "btnLotoReexecutar";
            this.btnLotoReexecutar.Size = new System.Drawing.Size(22, 22);
            this.btnLotoReexecutar.TabIndex = 3;
            this.btnLotoReexecutar.UseVisualStyleBackColor = true;
            this.btnLotoReexecutar.Click += new System.EventHandler(this.btnLotoReexecutar_Click);
            // 
            // txbLotoLastExecute
            // 
            this.txbLotoLastExecute.Enabled = false;
            this.txbLotoLastExecute.Location = new System.Drawing.Point(128, 103);
            this.txbLotoLastExecute.Name = "txbLotoLastExecute";
            this.txbLotoLastExecute.Size = new System.Drawing.Size(155, 20);
            this.txbLotoLastExecute.TabIndex = 0;
            // 
            // lblLotoLastExecute
            // 
            this.lblLotoLastExecute.AutoSize = true;
            this.lblLotoLastExecute.Location = new System.Drawing.Point(7, 106);
            this.lblLotoLastExecute.Name = "lblLotoLastExecute";
            this.lblLotoLastExecute.Size = new System.Drawing.Size(90, 13);
            this.lblLotoLastExecute.TabIndex = 0;
            this.lblLotoLastExecute.Text = "Última Execução:";
            // 
            // txbLotoPathProgram
            // 
            this.txbLotoPathProgram.Location = new System.Drawing.Point(11, 70);
            this.txbLotoPathProgram.Name = "txbLotoPathProgram";
            this.txbLotoPathProgram.Size = new System.Drawing.Size(297, 20);
            this.txbLotoPathProgram.TabIndex = 2;
            // 
            // lblLotoPathProgram
            // 
            this.lblLotoPathProgram.AutoSize = true;
            this.lblLotoPathProgram.Location = new System.Drawing.Point(7, 52);
            this.lblLotoPathProgram.Name = "lblLotoPathProgram";
            this.lblLotoPathProgram.Size = new System.Drawing.Size(99, 13);
            this.lblLotoPathProgram.TabIndex = 0;
            this.lblLotoPathProgram.Text = "Local do Programa:";
            this.lblLotoPathProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbLotoFlagProgram
            // 
            this.ckbLotoFlagProgram.AutoSize = true;
            this.ckbLotoFlagProgram.Location = new System.Drawing.Point(11, 22);
            this.ckbLotoFlagProgram.Name = "ckbLotoFlagProgram";
            this.ckbLotoFlagProgram.Size = new System.Drawing.Size(262, 17);
            this.ckbLotoFlagProgram.TabIndex = 1;
            this.ckbLotoFlagProgram.Text = "Executar programa diariamente para gerar palpites";
            this.ckbLotoFlagProgram.UseVisualStyleBackColor = true;
            this.ckbLotoFlagProgram.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // btnGeralCheckTarefas
            // 
            this.btnGeralCheckTarefas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeralCheckTarefas.Image = global::Janitor.Properties.Resources.png_warn;
            this.btnGeralCheckTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeralCheckTarefas.Location = new System.Drawing.Point(10, 101);
            this.btnGeralCheckTarefas.Name = "btnGeralCheckTarefas";
            this.btnGeralCheckTarefas.Size = new System.Drawing.Size(145, 23);
            this.btnGeralCheckTarefas.TabIndex = 4;
            this.btnGeralCheckTarefas.Text = "Verificar Tarefas...";
            this.btnGeralCheckTarefas.UseVisualStyleBackColor = true;
            this.btnGeralCheckTarefas.Click += new System.EventHandler(this.btnGeralCheckTarefas_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 233);
            this.Controls.Add(this.tbcPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janitor  •  Configurações";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.tbcPanel.ResumeLayout(false);
            this.tbpGeral.ResumeLayout(false);
            this.grbGeralAgendador.ResumeLayout(false);
            this.grbGeralAgendador.PerformLayout();
            this.tbpMetatrader.ResumeLayout(false);
            this.grpMetatraderTrading.ResumeLayout(false);
            this.grpMetatraderTrading.PerformLayout();
            this.tbpColethon.ResumeLayout(false);
            this.grbColethonManutencao.ResumeLayout(false);
            this.grbColethonManutencao.PerformLayout();
            this.tbpQuanthon.ResumeLayout(false);
            this.grbQuanthonManutencao.ResumeLayout(false);
            this.grbQuanthonManutencao.PerformLayout();
            this.tbpLoto365.ResumeLayout(false);
            this.grbLoto365Manutencao.ResumeLayout(false);
            this.grbLoto365Manutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tbcPanel;
        private System.Windows.Forms.TabPage tbpGeral;
        private System.Windows.Forms.TabPage tbpLoto365;
        private System.Windows.Forms.TabPage tbpMetatrader;
        private System.Windows.Forms.TabPage tbpQuanthon;
        private System.Windows.Forms.GroupBox grbGeralAgendador;
        private System.Windows.Forms.CheckBox ckbGeralFlagTasks;
        private System.Windows.Forms.GroupBox grpMetatraderTrading;
        private System.Windows.Forms.Label lblMT5PathGenial;
        private System.Windows.Forms.CheckBox ckbMT5FlagProgram;
        private System.Windows.Forms.TextBox txbMT5PathGenial;
        private System.Windows.Forms.TextBox txbMT5PathXmglob;
        private System.Windows.Forms.Label lblMT5PathXmglob;
        private System.Windows.Forms.GroupBox grbLoto365Manutencao;
        private System.Windows.Forms.TextBox txbLotoLastExecute;
        private System.Windows.Forms.Label lblLotoLastExecute;
        private System.Windows.Forms.TextBox txbLotoPathProgram;
        private System.Windows.Forms.Label lblLotoPathProgram;
        private System.Windows.Forms.CheckBox ckbLotoFlagProgram;
        private System.Windows.Forms.GroupBox grbQuanthonManutencao;
        private System.Windows.Forms.TextBox txbQuantLastExecute;
        private System.Windows.Forms.Label lblQuantLastExecute;
        private System.Windows.Forms.TextBox txbQuantPathProgram;
        private System.Windows.Forms.Label lblQuantPathProgram;
        private System.Windows.Forms.CheckBox chbQuantFlagProgram;
        private System.Windows.Forms.CheckBox ckbGeralFlagClocker;
        private System.Windows.Forms.CheckBox ckbGeralFlagNotClose;
        private System.Windows.Forms.Label lblMT5PathModal;
        private System.Windows.Forms.TextBox txbMT5PathModal;
        private System.Windows.Forms.TabPage tbpColethon;
        private System.Windows.Forms.GroupBox grbColethonManutencao;
        private System.Windows.Forms.TextBox txbColetLastExecute;
        private System.Windows.Forms.Label lblColetLastExecute;
        private System.Windows.Forms.TextBox txbColetPathProgram;
        private System.Windows.Forms.Label lblColetPathProgram;
        private System.Windows.Forms.CheckBox chbColetFlagProgram;
        private System.Windows.Forms.Button btnGeralEncerrarTarefas;
        private System.Windows.Forms.Button btnColetReexecutar;
        private System.Windows.Forms.Button btnQuantReexecutar;
        private System.Windows.Forms.Button btnLotoReexecutar;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnMT5ExibirFeriados;
        private System.Windows.Forms.Button btnGeralCheckTarefas;
    }
}

