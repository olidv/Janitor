
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
            this.btnGeralRunBackup = new System.Windows.Forms.Button();
            this.lblGeralPathBackup = new System.Windows.Forms.Label();
            this.btnGeralOpenBackup = new System.Windows.Forms.Button();
            this.txbGeralPathBackup = new System.Windows.Forms.TextBox();
            this.ckbGeralFlagBackup = new System.Windows.Forms.CheckBox();
            this.btnGeralCheckTarefas = new System.Windows.Forms.Button();
            this.btnGeralEncerrarTarefas = new System.Windows.Forms.Button();
            this.ckbGeralFlagClocker = new System.Windows.Forms.CheckBox();
            this.ckbGeralFlagTasks = new System.Windows.Forms.CheckBox();
            this.tbpMetatrader = new System.Windows.Forms.TabPage();
            this.grpMetatraderTrading = new System.Windows.Forms.GroupBox();
            this.btnMT5RunXmglob = new System.Windows.Forms.Button();
            this.btnMT5RunModal = new System.Windows.Forms.Button();
            this.btnMT5RunGenial = new System.Windows.Forms.Button();
            this.btnMT5OpenXmglob = new System.Windows.Forms.Button();
            this.btnMT5OpenModal = new System.Windows.Forms.Button();
            this.btnMT5OpenGenial = new System.Windows.Forms.Button();
            this.ckbMT5FlagNotClose = new System.Windows.Forms.CheckBox();
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
            this.btnColetRunProgram = new System.Windows.Forms.Button();
            this.btnColetOpenProgram = new System.Windows.Forms.Button();
            this.btnColetOpenSignal = new System.Windows.Forms.Button();
            this.txbColetPathSignal = new System.Windows.Forms.TextBox();
            this.lblColetPathSignal = new System.Windows.Forms.Label();
            this.btnColetReexecutar = new System.Windows.Forms.Button();
            this.txbColetLastExecute = new System.Windows.Forms.TextBox();
            this.lblColetLastExecute = new System.Windows.Forms.Label();
            this.txbColetPathProgram = new System.Windows.Forms.TextBox();
            this.lblColetPathProgram = new System.Windows.Forms.Label();
            this.chbColetFlagProgram = new System.Windows.Forms.CheckBox();
            this.tbpLoto365 = new System.Windows.Forms.TabPage();
            this.grbLoto365Manutencao = new System.Windows.Forms.GroupBox();
            this.btnLotoRunProgram = new System.Windows.Forms.Button();
            this.btnLotoOpenSignal = new System.Windows.Forms.Button();
            this.btnLotoOpenProgram = new System.Windows.Forms.Button();
            this.txbLotoPathSignal = new System.Windows.Forms.TextBox();
            this.lblLotoPathSignal = new System.Windows.Forms.Label();
            this.btnLotoReexecutar = new System.Windows.Forms.Button();
            this.txbLotoLastExecute = new System.Windows.Forms.TextBox();
            this.lblLotoLastExecute = new System.Windows.Forms.Label();
            this.txbLotoPathProgram = new System.Windows.Forms.TextBox();
            this.lblLotoPathProgram = new System.Windows.Forms.Label();
            this.ckbLotoFlagProgram = new System.Windows.Forms.CheckBox();
            this.tbpQuanthon = new System.Windows.Forms.TabPage();
            this.grbQuanthonManutencao = new System.Windows.Forms.GroupBox();
            this.btnQuantRunProgram = new System.Windows.Forms.Button();
            this.btnQuantOpenProgram = new System.Windows.Forms.Button();
            this.btnQuantOpenSignal = new System.Windows.Forms.Button();
            this.txbQuantPathSignal = new System.Windows.Forms.TextBox();
            this.lblQuantPathSignal = new System.Windows.Forms.Label();
            this.btnQuantReexecutar = new System.Windows.Forms.Button();
            this.txbQuantLastExecute = new System.Windows.Forms.TextBox();
            this.lblQuantLastExecute = new System.Windows.Forms.Label();
            this.txbQuantPathProgram = new System.Windows.Forms.TextBox();
            this.lblQuantPathProgram = new System.Windows.Forms.Label();
            this.chbQuantFlagProgram = new System.Windows.Forms.CheckBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.tbcPanel.SuspendLayout();
            this.tbpGeral.SuspendLayout();
            this.grbGeralAgendador.SuspendLayout();
            this.tbpMetatrader.SuspendLayout();
            this.grpMetatraderTrading.SuspendLayout();
            this.tbpColethon.SuspendLayout();
            this.grbColethonManutencao.SuspendLayout();
            this.tbpLoto365.SuspendLayout();
            this.grbLoto365Manutencao.SuspendLayout();
            this.tbpQuanthon.SuspendLayout();
            this.grbQuanthonManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(194, 251);
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
            this.btnCancel.Location = new System.Drawing.Point(277, 251);
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
            this.tbcPanel.Size = new System.Drawing.Size(343, 233);
            this.tbcPanel.TabIndex = 1;
            // 
            // tbpGeral
            // 
            this.tbpGeral.Controls.Add(this.grbGeralAgendador);
            this.tbpGeral.Location = new System.Drawing.Point(4, 22);
            this.tbpGeral.Name = "tbpGeral";
            this.tbpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeral.Size = new System.Drawing.Size(335, 207);
            this.tbpGeral.TabIndex = 0;
            this.tbpGeral.Text = "Geral";
            this.tbpGeral.UseVisualStyleBackColor = true;
            // 
            // grbGeralAgendador
            // 
            this.grbGeralAgendador.Controls.Add(this.btnGeralRunBackup);
            this.grbGeralAgendador.Controls.Add(this.lblGeralPathBackup);
            this.grbGeralAgendador.Controls.Add(this.btnGeralOpenBackup);
            this.grbGeralAgendador.Controls.Add(this.txbGeralPathBackup);
            this.grbGeralAgendador.Controls.Add(this.ckbGeralFlagBackup);
            this.grbGeralAgendador.Controls.Add(this.btnGeralCheckTarefas);
            this.grbGeralAgendador.Controls.Add(this.btnGeralEncerrarTarefas);
            this.grbGeralAgendador.Controls.Add(this.ckbGeralFlagClocker);
            this.grbGeralAgendador.Controls.Add(this.ckbGeralFlagTasks);
            this.grbGeralAgendador.Location = new System.Drawing.Point(7, 9);
            this.grbGeralAgendador.Name = "grbGeralAgendador";
            this.grbGeralAgendador.Size = new System.Drawing.Size(319, 190);
            this.grbGeralAgendador.TabIndex = 0;
            this.grbGeralAgendador.TabStop = false;
            this.grbGeralAgendador.Text = "Agendador de Tarefas";
            // 
            // btnGeralRunBackup
            // 
            this.btnGeralRunBackup.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnGeralRunBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeralRunBackup.Location = new System.Drawing.Point(287, 115);
            this.btnGeralRunBackup.Name = "btnGeralRunBackup";
            this.btnGeralRunBackup.Size = new System.Drawing.Size(22, 22);
            this.btnGeralRunBackup.TabIndex = 9;
            this.btnGeralRunBackup.UseVisualStyleBackColor = true;
            this.btnGeralRunBackup.Click += new System.EventHandler(this.btnGeralRunBackup_Click);
            // 
            // lblGeralPathBackup
            // 
            this.lblGeralPathBackup.AutoSize = true;
            this.lblGeralPathBackup.Location = new System.Drawing.Point(7, 98);
            this.lblGeralPathBackup.Name = "lblGeralPathBackup";
            this.lblGeralPathBackup.Size = new System.Drawing.Size(140, 13);
            this.lblGeralPathBackup.TabIndex = 8;
            this.lblGeralPathBackup.Text = "Local da Rotina de Backup:";
            this.lblGeralPathBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGeralOpenBackup
            // 
            this.btnGeralOpenBackup.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnGeralOpenBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeralOpenBackup.Location = new System.Drawing.Point(262, 115);
            this.btnGeralOpenBackup.Name = "btnGeralOpenBackup";
            this.btnGeralOpenBackup.Size = new System.Drawing.Size(22, 22);
            this.btnGeralOpenBackup.TabIndex = 5;
            this.btnGeralOpenBackup.UseVisualStyleBackColor = true;
            this.btnGeralOpenBackup.Click += new System.EventHandler(this.btnGeralOpenBackup_Click);
            // 
            // txbGeralPathBackup
            // 
            this.txbGeralPathBackup.Location = new System.Drawing.Point(11, 116);
            this.txbGeralPathBackup.Name = "txbGeralPathBackup";
            this.txbGeralPathBackup.Size = new System.Drawing.Size(247, 20);
            this.txbGeralPathBackup.TabIndex = 4;
            // 
            // ckbGeralFlagBackup
            // 
            this.ckbGeralFlagBackup.AutoSize = true;
            this.ckbGeralFlagBackup.Location = new System.Drawing.Point(11, 70);
            this.ckbGeralFlagBackup.Name = "ckbGeralFlagBackup";
            this.ckbGeralFlagBackup.Size = new System.Drawing.Size(208, 17);
            this.ckbGeralFlagBackup.TabIndex = 3;
            this.ckbGeralFlagBackup.Text = "Executar rotina de backup diariamente";
            this.ckbGeralFlagBackup.UseVisualStyleBackColor = true;
            this.ckbGeralFlagBackup.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // btnGeralCheckTarefas
            // 
            this.btnGeralCheckTarefas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeralCheckTarefas.Image = global::Janitor.Properties.Resources.png_warn;
            this.btnGeralCheckTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeralCheckTarefas.Location = new System.Drawing.Point(10, 151);
            this.btnGeralCheckTarefas.Name = "btnGeralCheckTarefas";
            this.btnGeralCheckTarefas.Size = new System.Drawing.Size(145, 23);
            this.btnGeralCheckTarefas.TabIndex = 6;
            this.btnGeralCheckTarefas.Text = " Verificar Tarefas...";
            this.btnGeralCheckTarefas.UseVisualStyleBackColor = true;
            this.btnGeralCheckTarefas.Click += new System.EventHandler(this.btnGeralCheckTarefas_Click);
            // 
            // btnGeralEncerrarTarefas
            // 
            this.btnGeralEncerrarTarefas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeralEncerrarTarefas.Image = global::Janitor.Properties.Resources.png_close;
            this.btnGeralEncerrarTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeralEncerrarTarefas.Location = new System.Drawing.Point(163, 151);
            this.btnGeralEncerrarTarefas.Name = "btnGeralEncerrarTarefas";
            this.btnGeralEncerrarTarefas.Size = new System.Drawing.Size(146, 23);
            this.btnGeralEncerrarTarefas.TabIndex = 7;
            this.btnGeralEncerrarTarefas.Text = "Encerrar Tarefas...";
            this.btnGeralEncerrarTarefas.UseVisualStyleBackColor = true;
            this.btnGeralEncerrarTarefas.Click += new System.EventHandler(this.btnGeralEncerrarTarefas_Click);
            // 
            // ckbGeralFlagClocker
            // 
            this.ckbGeralFlagClocker.AutoSize = true;
            this.ckbGeralFlagClocker.Location = new System.Drawing.Point(11, 46);
            this.ckbGeralFlagClocker.Name = "ckbGeralFlagClocker";
            this.ckbGeralFlagClocker.Size = new System.Drawing.Size(252, 17);
            this.ckbGeralFlagClocker.TabIndex = 2;
            this.ckbGeralFlagClocker.Text = "Acertar as horas do computador periodicamente";
            this.ckbGeralFlagClocker.UseVisualStyleBackColor = true;
            this.ckbGeralFlagClocker.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
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
            this.tbpMetatrader.Size = new System.Drawing.Size(335, 207);
            this.tbpMetatrader.TabIndex = 2;
            this.tbpMetatrader.Text = "MetaTrader";
            this.tbpMetatrader.UseVisualStyleBackColor = true;
            // 
            // grpMetatraderTrading
            // 
            this.grpMetatraderTrading.Controls.Add(this.btnMT5RunXmglob);
            this.grpMetatraderTrading.Controls.Add(this.btnMT5RunModal);
            this.grpMetatraderTrading.Controls.Add(this.btnMT5RunGenial);
            this.grpMetatraderTrading.Controls.Add(this.btnMT5OpenXmglob);
            this.grpMetatraderTrading.Controls.Add(this.btnMT5OpenModal);
            this.grpMetatraderTrading.Controls.Add(this.btnMT5OpenGenial);
            this.grpMetatraderTrading.Controls.Add(this.ckbMT5FlagNotClose);
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
            this.grpMetatraderTrading.Size = new System.Drawing.Size(319, 190);
            this.grpMetatraderTrading.TabIndex = 0;
            this.grpMetatraderTrading.TabStop = false;
            this.grpMetatraderTrading.Text = "Algo Trading com Robôs";
            // 
            // btnMT5RunXmglob
            // 
            this.btnMT5RunXmglob.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnMT5RunXmglob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMT5RunXmglob.Location = new System.Drawing.Point(287, 122);
            this.btnMT5RunXmglob.Name = "btnMT5RunXmglob";
            this.btnMT5RunXmglob.Size = new System.Drawing.Size(22, 22);
            this.btnMT5RunXmglob.TabIndex = 12;
            this.btnMT5RunXmglob.UseVisualStyleBackColor = true;
            this.btnMT5RunXmglob.Click += new System.EventHandler(this.btnMT5RunXmglob_Click);
            // 
            // btnMT5RunModal
            // 
            this.btnMT5RunModal.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnMT5RunModal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMT5RunModal.Location = new System.Drawing.Point(287, 95);
            this.btnMT5RunModal.Name = "btnMT5RunModal";
            this.btnMT5RunModal.Size = new System.Drawing.Size(22, 22);
            this.btnMT5RunModal.TabIndex = 11;
            this.btnMT5RunModal.UseVisualStyleBackColor = true;
            this.btnMT5RunModal.Click += new System.EventHandler(this.btnMT5RunModal_Click);
            // 
            // btnMT5RunGenial
            // 
            this.btnMT5RunGenial.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnMT5RunGenial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMT5RunGenial.Location = new System.Drawing.Point(287, 68);
            this.btnMT5RunGenial.Name = "btnMT5RunGenial";
            this.btnMT5RunGenial.Size = new System.Drawing.Size(22, 22);
            this.btnMT5RunGenial.TabIndex = 10;
            this.btnMT5RunGenial.UseVisualStyleBackColor = true;
            this.btnMT5RunGenial.Click += new System.EventHandler(this.btnMT5RunGenial_Click);
            // 
            // btnMT5OpenXmglob
            // 
            this.btnMT5OpenXmglob.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnMT5OpenXmglob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMT5OpenXmglob.Location = new System.Drawing.Point(262, 122);
            this.btnMT5OpenXmglob.Name = "btnMT5OpenXmglob";
            this.btnMT5OpenXmglob.Size = new System.Drawing.Size(22, 22);
            this.btnMT5OpenXmglob.TabIndex = 8;
            this.btnMT5OpenXmglob.UseVisualStyleBackColor = true;
            this.btnMT5OpenXmglob.Click += new System.EventHandler(this.btnMT5OpenXmglob_Click);
            // 
            // btnMT5OpenModal
            // 
            this.btnMT5OpenModal.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnMT5OpenModal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMT5OpenModal.Location = new System.Drawing.Point(262, 95);
            this.btnMT5OpenModal.Name = "btnMT5OpenModal";
            this.btnMT5OpenModal.Size = new System.Drawing.Size(22, 22);
            this.btnMT5OpenModal.TabIndex = 6;
            this.btnMT5OpenModal.UseVisualStyleBackColor = true;
            this.btnMT5OpenModal.Click += new System.EventHandler(this.btnMT5OpenModal_Click);
            // 
            // btnMT5OpenGenial
            // 
            this.btnMT5OpenGenial.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnMT5OpenGenial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMT5OpenGenial.Location = new System.Drawing.Point(262, 68);
            this.btnMT5OpenGenial.Name = "btnMT5OpenGenial";
            this.btnMT5OpenGenial.Size = new System.Drawing.Size(22, 22);
            this.btnMT5OpenGenial.TabIndex = 4;
            this.btnMT5OpenGenial.UseVisualStyleBackColor = true;
            this.btnMT5OpenGenial.Click += new System.EventHandler(this.btnMT5OpenGenial_Click);
            // 
            // ckbMT5FlagNotClose
            // 
            this.ckbMT5FlagNotClose.AutoSize = true;
            this.ckbMT5FlagNotClose.Location = new System.Drawing.Point(11, 46);
            this.ckbMT5FlagNotClose.Name = "ckbMT5FlagNotClose";
            this.ckbMT5FlagNotClose.Size = new System.Drawing.Size(245, 17);
            this.ckbMT5FlagNotClose.TabIndex = 2;
            this.ckbMT5FlagNotClose.Text = "NÃO encerrar MetaTrader ainda em execução";
            this.ckbMT5FlagNotClose.UseVisualStyleBackColor = true;
            this.ckbMT5FlagNotClose.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // btnMT5ExibirFeriados
            // 
            this.btnMT5ExibirFeriados.Image = global::Janitor.Properties.Resources.png_info;
            this.btnMT5ExibirFeriados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMT5ExibirFeriados.Location = new System.Drawing.Point(163, 151);
            this.btnMT5ExibirFeriados.Name = "btnMT5ExibirFeriados";
            this.btnMT5ExibirFeriados.Size = new System.Drawing.Size(146, 23);
            this.btnMT5ExibirFeriados.TabIndex = 9;
            this.btnMT5ExibirFeriados.Text = "     Exibir Feriados 2022...";
            this.btnMT5ExibirFeriados.UseVisualStyleBackColor = true;
            this.btnMT5ExibirFeriados.Click += new System.EventHandler(this.btnMT5ExibirFeriados_Click);
            // 
            // lblMT5PathModal
            // 
            this.lblMT5PathModal.AutoSize = true;
            this.lblMT5PathModal.Location = new System.Drawing.Point(7, 99);
            this.lblMT5PathModal.Name = "lblMT5PathModal";
            this.lblMT5PathModal.Size = new System.Drawing.Size(61, 13);
            this.lblMT5PathModal.TabIndex = 0;
            this.lblMT5PathModal.Text = "ModalMais:";
            this.lblMT5PathModal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbMT5PathModal
            // 
            this.txbMT5PathModal.Location = new System.Drawing.Point(72, 96);
            this.txbMT5PathModal.Name = "txbMT5PathModal";
            this.txbMT5PathModal.Size = new System.Drawing.Size(186, 20);
            this.txbMT5PathModal.TabIndex = 5;
            // 
            // txbMT5PathXmglob
            // 
            this.txbMT5PathXmglob.Location = new System.Drawing.Point(72, 123);
            this.txbMT5PathXmglob.Name = "txbMT5PathXmglob";
            this.txbMT5PathXmglob.Size = new System.Drawing.Size(186, 20);
            this.txbMT5PathXmglob.TabIndex = 7;
            // 
            // lblMT5PathXmglob
            // 
            this.lblMT5PathXmglob.AutoSize = true;
            this.lblMT5PathXmglob.Location = new System.Drawing.Point(7, 126);
            this.lblMT5PathXmglob.Name = "lblMT5PathXmglob";
            this.lblMT5PathXmglob.Size = new System.Drawing.Size(59, 13);
            this.lblMT5PathXmglob.TabIndex = 0;
            this.lblMT5PathXmglob.Text = "XM Global:";
            // 
            // txbMT5PathGenial
            // 
            this.txbMT5PathGenial.Location = new System.Drawing.Point(72, 69);
            this.txbMT5PathGenial.Name = "txbMT5PathGenial";
            this.txbMT5PathGenial.Size = new System.Drawing.Size(186, 20);
            this.txbMT5PathGenial.TabIndex = 3;
            // 
            // lblMT5PathGenial
            // 
            this.lblMT5PathGenial.AutoSize = true;
            this.lblMT5PathGenial.Location = new System.Drawing.Point(7, 72);
            this.lblMT5PathGenial.Name = "lblMT5PathGenial";
            this.lblMT5PathGenial.Size = new System.Drawing.Size(40, 13);
            this.lblMT5PathGenial.TabIndex = 0;
            this.lblMT5PathGenial.Text = "Genial:";
            this.lblMT5PathGenial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbMT5FlagProgram
            // 
            this.ckbMT5FlagProgram.AutoSize = true;
            this.ckbMT5FlagProgram.Location = new System.Drawing.Point(11, 22);
            this.ckbMT5FlagProgram.Name = "ckbMT5FlagProgram";
            this.ckbMT5FlagProgram.Size = new System.Drawing.Size(265, 17);
            this.ckbMT5FlagProgram.TabIndex = 1;
            this.ckbMT5FlagProgram.Text = "Executar MetaTrader diariamente para algo trading";
            this.ckbMT5FlagProgram.UseVisualStyleBackColor = true;
            this.ckbMT5FlagProgram.CheckedChanged += new System.EventHandler(this.FrmConfig_Refresh);
            // 
            // tbpColethon
            // 
            this.tbpColethon.Controls.Add(this.grbColethonManutencao);
            this.tbpColethon.Location = new System.Drawing.Point(4, 22);
            this.tbpColethon.Name = "tbpColethon";
            this.tbpColethon.Padding = new System.Windows.Forms.Padding(3);
            this.tbpColethon.Size = new System.Drawing.Size(335, 207);
            this.tbpColethon.TabIndex = 4;
            this.tbpColethon.Text = "Colethon";
            this.tbpColethon.UseVisualStyleBackColor = true;
            // 
            // grbColethonManutencao
            // 
            this.grbColethonManutencao.Controls.Add(this.btnColetRunProgram);
            this.grbColethonManutencao.Controls.Add(this.btnColetOpenProgram);
            this.grbColethonManutencao.Controls.Add(this.btnColetOpenSignal);
            this.grbColethonManutencao.Controls.Add(this.txbColetPathSignal);
            this.grbColethonManutencao.Controls.Add(this.lblColetPathSignal);
            this.grbColethonManutencao.Controls.Add(this.btnColetReexecutar);
            this.grbColethonManutencao.Controls.Add(this.txbColetLastExecute);
            this.grbColethonManutencao.Controls.Add(this.lblColetLastExecute);
            this.grbColethonManutencao.Controls.Add(this.txbColetPathProgram);
            this.grbColethonManutencao.Controls.Add(this.lblColetPathProgram);
            this.grbColethonManutencao.Controls.Add(this.chbColetFlagProgram);
            this.grbColethonManutencao.Location = new System.Drawing.Point(7, 9);
            this.grbColethonManutencao.Name = "grbColethonManutencao";
            this.grbColethonManutencao.Size = new System.Drawing.Size(319, 190);
            this.grbColethonManutencao.TabIndex = 1;
            this.grbColethonManutencao.TabStop = false;
            this.grbColethonManutencao.Text = "Coleta Diária de Dados";
            // 
            // btnColetRunProgram
            // 
            this.btnColetRunProgram.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnColetRunProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColetRunProgram.Location = new System.Drawing.Point(287, 68);
            this.btnColetRunProgram.Name = "btnColetRunProgram";
            this.btnColetRunProgram.Size = new System.Drawing.Size(22, 22);
            this.btnColetRunProgram.TabIndex = 10;
            this.btnColetRunProgram.UseVisualStyleBackColor = true;
            this.btnColetRunProgram.Click += new System.EventHandler(this.btnColetRunProgram_Click);
            // 
            // btnColetOpenProgram
            // 
            this.btnColetOpenProgram.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnColetOpenProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColetOpenProgram.Location = new System.Drawing.Point(262, 68);
            this.btnColetOpenProgram.Name = "btnColetOpenProgram";
            this.btnColetOpenProgram.Size = new System.Drawing.Size(22, 22);
            this.btnColetOpenProgram.TabIndex = 3;
            this.btnColetOpenProgram.UseVisualStyleBackColor = true;
            this.btnColetOpenProgram.Click += new System.EventHandler(this.btnColetOpenProgram_Click);
            // 
            // btnColetOpenSignal
            // 
            this.btnColetOpenSignal.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnColetOpenSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColetOpenSignal.Location = new System.Drawing.Point(287, 116);
            this.btnColetOpenSignal.Name = "btnColetOpenSignal";
            this.btnColetOpenSignal.Size = new System.Drawing.Size(22, 22);
            this.btnColetOpenSignal.TabIndex = 5;
            this.btnColetOpenSignal.UseVisualStyleBackColor = true;
            this.btnColetOpenSignal.Click += new System.EventHandler(this.btnColetOpenSignal_Click);
            // 
            // txbColetPathSignal
            // 
            this.txbColetPathSignal.Location = new System.Drawing.Point(11, 117);
            this.txbColetPathSignal.Name = "txbColetPathSignal";
            this.txbColetPathSignal.Size = new System.Drawing.Size(272, 20);
            this.txbColetPathSignal.TabIndex = 4;
            // 
            // lblColetPathSignal
            // 
            this.lblColetPathSignal.AutoSize = true;
            this.lblColetPathSignal.Location = new System.Drawing.Point(7, 99);
            this.lblColetPathSignal.Name = "lblColetPathSignal";
            this.lblColetPathSignal.Size = new System.Drawing.Size(115, 13);
            this.lblColetPathSignal.TabIndex = 4;
            this.lblColetPathSignal.Text = "Aquivo de Sinalização:";
            this.lblColetPathSignal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnColetReexecutar
            // 
            this.btnColetReexecutar.BackgroundImage = global::Janitor.Properties.Resources.png_redo;
            this.btnColetReexecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColetReexecutar.Location = new System.Drawing.Point(287, 152);
            this.btnColetReexecutar.Name = "btnColetReexecutar";
            this.btnColetReexecutar.Size = new System.Drawing.Size(22, 22);
            this.btnColetReexecutar.TabIndex = 6;
            this.btnColetReexecutar.UseVisualStyleBackColor = true;
            this.btnColetReexecutar.Click += new System.EventHandler(this.btnColetReexecutar_Click);
            // 
            // txbColetLastExecute
            // 
            this.txbColetLastExecute.Enabled = false;
            this.txbColetLastExecute.Location = new System.Drawing.Point(95, 153);
            this.txbColetLastExecute.Name = "txbColetLastExecute";
            this.txbColetLastExecute.Size = new System.Drawing.Size(188, 20);
            this.txbColetLastExecute.TabIndex = 0;
            // 
            // lblColetLastExecute
            // 
            this.lblColetLastExecute.AutoSize = true;
            this.lblColetLastExecute.Location = new System.Drawing.Point(7, 156);
            this.lblColetLastExecute.Name = "lblColetLastExecute";
            this.lblColetLastExecute.Size = new System.Drawing.Size(90, 13);
            this.lblColetLastExecute.TabIndex = 0;
            this.lblColetLastExecute.Text = "Última Execução:";
            // 
            // txbColetPathProgram
            // 
            this.txbColetPathProgram.Location = new System.Drawing.Point(11, 69);
            this.txbColetPathProgram.Name = "txbColetPathProgram";
            this.txbColetPathProgram.Size = new System.Drawing.Size(247, 20);
            this.txbColetPathProgram.TabIndex = 2;
            // 
            // lblColetPathProgram
            // 
            this.lblColetPathProgram.AutoSize = true;
            this.lblColetPathProgram.Location = new System.Drawing.Point(7, 51);
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
            // tbpLoto365
            // 
            this.tbpLoto365.Controls.Add(this.grbLoto365Manutencao);
            this.tbpLoto365.Location = new System.Drawing.Point(4, 22);
            this.tbpLoto365.Name = "tbpLoto365";
            this.tbpLoto365.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoto365.Size = new System.Drawing.Size(335, 207);
            this.tbpLoto365.TabIndex = 1;
            this.tbpLoto365.Text = "Loto365";
            this.tbpLoto365.UseVisualStyleBackColor = true;
            // 
            // grbLoto365Manutencao
            // 
            this.grbLoto365Manutencao.Controls.Add(this.btnLotoRunProgram);
            this.grbLoto365Manutencao.Controls.Add(this.btnLotoOpenSignal);
            this.grbLoto365Manutencao.Controls.Add(this.btnLotoOpenProgram);
            this.grbLoto365Manutencao.Controls.Add(this.txbLotoPathSignal);
            this.grbLoto365Manutencao.Controls.Add(this.lblLotoPathSignal);
            this.grbLoto365Manutencao.Controls.Add(this.btnLotoReexecutar);
            this.grbLoto365Manutencao.Controls.Add(this.txbLotoLastExecute);
            this.grbLoto365Manutencao.Controls.Add(this.lblLotoLastExecute);
            this.grbLoto365Manutencao.Controls.Add(this.txbLotoPathProgram);
            this.grbLoto365Manutencao.Controls.Add(this.lblLotoPathProgram);
            this.grbLoto365Manutencao.Controls.Add(this.ckbLotoFlagProgram);
            this.grbLoto365Manutencao.Location = new System.Drawing.Point(7, 9);
            this.grbLoto365Manutencao.Name = "grbLoto365Manutencao";
            this.grbLoto365Manutencao.Size = new System.Drawing.Size(319, 190);
            this.grbLoto365Manutencao.TabIndex = 0;
            this.grbLoto365Manutencao.TabStop = false;
            this.grbLoto365Manutencao.Text = "Publicação de Palpites";
            // 
            // btnLotoRunProgram
            // 
            this.btnLotoRunProgram.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnLotoRunProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotoRunProgram.Location = new System.Drawing.Point(287, 68);
            this.btnLotoRunProgram.Name = "btnLotoRunProgram";
            this.btnLotoRunProgram.Size = new System.Drawing.Size(22, 22);
            this.btnLotoRunProgram.TabIndex = 10;
            this.btnLotoRunProgram.UseVisualStyleBackColor = true;
            this.btnLotoRunProgram.Click += new System.EventHandler(this.btnLotoRunProgram_Click);
            // 
            // btnLotoOpenSignal
            // 
            this.btnLotoOpenSignal.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnLotoOpenSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotoOpenSignal.Location = new System.Drawing.Point(287, 116);
            this.btnLotoOpenSignal.Name = "btnLotoOpenSignal";
            this.btnLotoOpenSignal.Size = new System.Drawing.Size(22, 22);
            this.btnLotoOpenSignal.TabIndex = 5;
            this.btnLotoOpenSignal.UseVisualStyleBackColor = true;
            this.btnLotoOpenSignal.Click += new System.EventHandler(this.btnLotoOpenSignal_Click);
            // 
            // btnLotoOpenProgram
            // 
            this.btnLotoOpenProgram.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnLotoOpenProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotoOpenProgram.Location = new System.Drawing.Point(262, 68);
            this.btnLotoOpenProgram.Name = "btnLotoOpenProgram";
            this.btnLotoOpenProgram.Size = new System.Drawing.Size(22, 22);
            this.btnLotoOpenProgram.TabIndex = 3;
            this.btnLotoOpenProgram.UseVisualStyleBackColor = true;
            this.btnLotoOpenProgram.Click += new System.EventHandler(this.btnLotoOpenProgram_Click);
            // 
            // txbLotoPathSignal
            // 
            this.txbLotoPathSignal.Location = new System.Drawing.Point(11, 117);
            this.txbLotoPathSignal.Name = "txbLotoPathSignal";
            this.txbLotoPathSignal.Size = new System.Drawing.Size(272, 20);
            this.txbLotoPathSignal.TabIndex = 4;
            // 
            // lblLotoPathSignal
            // 
            this.lblLotoPathSignal.AutoSize = true;
            this.lblLotoPathSignal.Location = new System.Drawing.Point(7, 99);
            this.lblLotoPathSignal.Name = "lblLotoPathSignal";
            this.lblLotoPathSignal.Size = new System.Drawing.Size(115, 13);
            this.lblLotoPathSignal.TabIndex = 4;
            this.lblLotoPathSignal.Text = "Aquivo de Sinalização:";
            this.lblLotoPathSignal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLotoReexecutar
            // 
            this.btnLotoReexecutar.BackgroundImage = global::Janitor.Properties.Resources.png_redo;
            this.btnLotoReexecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotoReexecutar.Location = new System.Drawing.Point(287, 152);
            this.btnLotoReexecutar.Name = "btnLotoReexecutar";
            this.btnLotoReexecutar.Size = new System.Drawing.Size(22, 22);
            this.btnLotoReexecutar.TabIndex = 6;
            this.btnLotoReexecutar.UseVisualStyleBackColor = true;
            this.btnLotoReexecutar.Click += new System.EventHandler(this.btnLotoReexecutar_Click);
            // 
            // txbLotoLastExecute
            // 
            this.txbLotoLastExecute.Enabled = false;
            this.txbLotoLastExecute.Location = new System.Drawing.Point(95, 153);
            this.txbLotoLastExecute.Name = "txbLotoLastExecute";
            this.txbLotoLastExecute.Size = new System.Drawing.Size(188, 20);
            this.txbLotoLastExecute.TabIndex = 0;
            // 
            // lblLotoLastExecute
            // 
            this.lblLotoLastExecute.AutoSize = true;
            this.lblLotoLastExecute.Location = new System.Drawing.Point(7, 156);
            this.lblLotoLastExecute.Name = "lblLotoLastExecute";
            this.lblLotoLastExecute.Size = new System.Drawing.Size(90, 13);
            this.lblLotoLastExecute.TabIndex = 0;
            this.lblLotoLastExecute.Text = "Última Execução:";
            // 
            // txbLotoPathProgram
            // 
            this.txbLotoPathProgram.Location = new System.Drawing.Point(11, 69);
            this.txbLotoPathProgram.Name = "txbLotoPathProgram";
            this.txbLotoPathProgram.Size = new System.Drawing.Size(247, 20);
            this.txbLotoPathProgram.TabIndex = 2;
            // 
            // lblLotoPathProgram
            // 
            this.lblLotoPathProgram.AutoSize = true;
            this.lblLotoPathProgram.Location = new System.Drawing.Point(7, 51);
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
            // tbpQuanthon
            // 
            this.tbpQuanthon.Controls.Add(this.grbQuanthonManutencao);
            this.tbpQuanthon.Location = new System.Drawing.Point(4, 22);
            this.tbpQuanthon.Name = "tbpQuanthon";
            this.tbpQuanthon.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQuanthon.Size = new System.Drawing.Size(335, 207);
            this.tbpQuanthon.TabIndex = 3;
            this.tbpQuanthon.Text = "Quanthon";
            this.tbpQuanthon.UseVisualStyleBackColor = true;
            // 
            // grbQuanthonManutencao
            // 
            this.grbQuanthonManutencao.Controls.Add(this.btnQuantRunProgram);
            this.grbQuanthonManutencao.Controls.Add(this.btnQuantOpenProgram);
            this.grbQuanthonManutencao.Controls.Add(this.btnQuantOpenSignal);
            this.grbQuanthonManutencao.Controls.Add(this.txbQuantPathSignal);
            this.grbQuanthonManutencao.Controls.Add(this.lblQuantPathSignal);
            this.grbQuanthonManutencao.Controls.Add(this.btnQuantReexecutar);
            this.grbQuanthonManutencao.Controls.Add(this.txbQuantLastExecute);
            this.grbQuanthonManutencao.Controls.Add(this.lblQuantLastExecute);
            this.grbQuanthonManutencao.Controls.Add(this.txbQuantPathProgram);
            this.grbQuanthonManutencao.Controls.Add(this.lblQuantPathProgram);
            this.grbQuanthonManutencao.Controls.Add(this.chbQuantFlagProgram);
            this.grbQuanthonManutencao.Location = new System.Drawing.Point(7, 9);
            this.grbQuanthonManutencao.Name = "grbQuanthonManutencao";
            this.grbQuanthonManutencao.Size = new System.Drawing.Size(319, 190);
            this.grbQuanthonManutencao.TabIndex = 0;
            this.grbQuanthonManutencao.TabStop = false;
            this.grbQuanthonManutencao.Text = "Análise de Dados Coletados";
            // 
            // btnQuantRunProgram
            // 
            this.btnQuantRunProgram.BackgroundImage = global::Janitor.Properties.Resources.png_run;
            this.btnQuantRunProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantRunProgram.Location = new System.Drawing.Point(287, 68);
            this.btnQuantRunProgram.Name = "btnQuantRunProgram";
            this.btnQuantRunProgram.Size = new System.Drawing.Size(22, 22);
            this.btnQuantRunProgram.TabIndex = 10;
            this.btnQuantRunProgram.UseVisualStyleBackColor = true;
            this.btnQuantRunProgram.Click += new System.EventHandler(this.btnQuantRunProgram_Click);
            // 
            // btnQuantOpenProgram
            // 
            this.btnQuantOpenProgram.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnQuantOpenProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantOpenProgram.Location = new System.Drawing.Point(262, 68);
            this.btnQuantOpenProgram.Name = "btnQuantOpenProgram";
            this.btnQuantOpenProgram.Size = new System.Drawing.Size(22, 22);
            this.btnQuantOpenProgram.TabIndex = 3;
            this.btnQuantOpenProgram.UseVisualStyleBackColor = true;
            this.btnQuantOpenProgram.Click += new System.EventHandler(this.btnQuantOpenProgram_Click);
            // 
            // btnQuantOpenSignal
            // 
            this.btnQuantOpenSignal.BackgroundImage = global::Janitor.Properties.Resources.png_find;
            this.btnQuantOpenSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantOpenSignal.Location = new System.Drawing.Point(287, 116);
            this.btnQuantOpenSignal.Name = "btnQuantOpenSignal";
            this.btnQuantOpenSignal.Size = new System.Drawing.Size(22, 22);
            this.btnQuantOpenSignal.TabIndex = 5;
            this.btnQuantOpenSignal.UseVisualStyleBackColor = true;
            this.btnQuantOpenSignal.Click += new System.EventHandler(this.btnQuantOpenSignal_Click);
            // 
            // txbQuantPathSignal
            // 
            this.txbQuantPathSignal.Location = new System.Drawing.Point(11, 117);
            this.txbQuantPathSignal.Name = "txbQuantPathSignal";
            this.txbQuantPathSignal.Size = new System.Drawing.Size(272, 20);
            this.txbQuantPathSignal.TabIndex = 4;
            // 
            // lblQuantPathSignal
            // 
            this.lblQuantPathSignal.AutoSize = true;
            this.lblQuantPathSignal.Location = new System.Drawing.Point(7, 99);
            this.lblQuantPathSignal.Name = "lblQuantPathSignal";
            this.lblQuantPathSignal.Size = new System.Drawing.Size(115, 13);
            this.lblQuantPathSignal.TabIndex = 4;
            this.lblQuantPathSignal.Text = "Aquivo de Sinalização:";
            this.lblQuantPathSignal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuantReexecutar
            // 
            this.btnQuantReexecutar.BackgroundImage = global::Janitor.Properties.Resources.png_redo;
            this.btnQuantReexecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantReexecutar.Location = new System.Drawing.Point(287, 152);
            this.btnQuantReexecutar.Name = "btnQuantReexecutar";
            this.btnQuantReexecutar.Size = new System.Drawing.Size(22, 22);
            this.btnQuantReexecutar.TabIndex = 6;
            this.btnQuantReexecutar.UseVisualStyleBackColor = true;
            this.btnQuantReexecutar.Click += new System.EventHandler(this.btnQuantReexecutar_Click);
            // 
            // txbQuantLastExecute
            // 
            this.txbQuantLastExecute.Enabled = false;
            this.txbQuantLastExecute.Location = new System.Drawing.Point(95, 153);
            this.txbQuantLastExecute.Name = "txbQuantLastExecute";
            this.txbQuantLastExecute.Size = new System.Drawing.Size(188, 20);
            this.txbQuantLastExecute.TabIndex = 0;
            // 
            // lblQuantLastExecute
            // 
            this.lblQuantLastExecute.AutoSize = true;
            this.lblQuantLastExecute.Location = new System.Drawing.Point(7, 156);
            this.lblQuantLastExecute.Name = "lblQuantLastExecute";
            this.lblQuantLastExecute.Size = new System.Drawing.Size(90, 13);
            this.lblQuantLastExecute.TabIndex = 0;
            this.lblQuantLastExecute.Text = "Última Execução:";
            // 
            // txbQuantPathProgram
            // 
            this.txbQuantPathProgram.Location = new System.Drawing.Point(11, 69);
            this.txbQuantPathProgram.Name = "txbQuantPathProgram";
            this.txbQuantPathProgram.Size = new System.Drawing.Size(247, 20);
            this.txbQuantPathProgram.TabIndex = 2;
            // 
            // lblQuantPathProgram
            // 
            this.lblQuantPathProgram.AutoSize = true;
            this.lblQuantPathProgram.Location = new System.Drawing.Point(7, 51);
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
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 283);
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
            this.tbpLoto365.ResumeLayout(false);
            this.grbLoto365Manutencao.ResumeLayout(false);
            this.grbLoto365Manutencao.PerformLayout();
            this.tbpQuanthon.ResumeLayout(false);
            this.grbQuanthonManutencao.ResumeLayout(false);
            this.grbQuanthonManutencao.PerformLayout();
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
        private System.Windows.Forms.CheckBox ckbMT5FlagNotClose;
        private System.Windows.Forms.TextBox txbColetPathSignal;
        private System.Windows.Forms.Label lblColetPathSignal;
        private System.Windows.Forms.TextBox txbLotoPathSignal;
        private System.Windows.Forms.Label lblLotoPathSignal;
        private System.Windows.Forms.TextBox txbQuantPathSignal;
        private System.Windows.Forms.Label lblQuantPathSignal;
        private System.Windows.Forms.Button btnGeralOpenBackup;
        private System.Windows.Forms.TextBox txbGeralPathBackup;
        private System.Windows.Forms.CheckBox ckbGeralFlagBackup;
        private System.Windows.Forms.Button btnMT5OpenXmglob;
        private System.Windows.Forms.Button btnMT5OpenModal;
        private System.Windows.Forms.Button btnMT5OpenGenial;
        private System.Windows.Forms.Button btnColetOpenProgram;
        private System.Windows.Forms.Button btnColetOpenSignal;
        private System.Windows.Forms.Button btnLotoOpenSignal;
        private System.Windows.Forms.Button btnLotoOpenProgram;
        private System.Windows.Forms.Button btnQuantOpenProgram;
        private System.Windows.Forms.Button btnQuantOpenSignal;
        private System.Windows.Forms.Label lblGeralPathBackup;
        private System.Windows.Forms.Button btnGeralRunBackup;
        private System.Windows.Forms.Button btnMT5RunXmglob;
        private System.Windows.Forms.Button btnMT5RunModal;
        private System.Windows.Forms.Button btnMT5RunGenial;
        private System.Windows.Forms.Button btnColetRunProgram;
        private System.Windows.Forms.Button btnLotoRunProgram;
        private System.Windows.Forms.Button btnQuantRunProgram;
    }
}

