
namespace Janitor
{
    partial class frm_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_config));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tbc_panel = new System.Windows.Forms.TabControl();
            this.tbp_geral = new System.Windows.Forms.TabPage();
            this.grb_geral_agendador = new System.Windows.Forms.GroupBox();
            this.ckb_ga_acertar = new System.Windows.Forms.CheckBox();
            this.ckb_ga_nao_encerrar = new System.Windows.Forms.CheckBox();
            this.ckb_ga_habilitar = new System.Windows.Forms.CheckBox();
            this.tbp_metatrader = new System.Windows.Forms.TabPage();
            this.grp_metatrader_coleta = new System.Windows.Forms.GroupBox();
            this.lbl_mc_modal = new System.Windows.Forms.Label();
            this.txb_mc_modal = new System.Windows.Forms.TextBox();
            this.txb_mc_xmg = new System.Windows.Forms.TextBox();
            this.lbl_mc_xmg = new System.Windows.Forms.Label();
            this.txb_mc_genial = new System.Windows.Forms.TextBox();
            this.lbl_mc_genial = new System.Windows.Forms.Label();
            this.ckb_mc_executar = new System.Windows.Forms.CheckBox();
            this.tbp_loto365 = new System.Windows.Forms.TabPage();
            this.grb_loto365_palpites = new System.Windows.Forms.GroupBox();
            this.txb_lp_execucao = new System.Windows.Forms.TextBox();
            this.lbl_lp_execucao = new System.Windows.Forms.Label();
            this.txb_lp_programa = new System.Windows.Forms.TextBox();
            this.lbl_lp_programa = new System.Windows.Forms.Label();
            this.ckb_lp_executar = new System.Windows.Forms.CheckBox();
            this.tbp_quanthon = new System.Windows.Forms.TabPage();
            this.grb_quanthon_manutencao = new System.Windows.Forms.GroupBox();
            this.txb_qm_execucao = new System.Windows.Forms.TextBox();
            this.lbl_qm_execucao = new System.Windows.Forms.Label();
            this.txb_qm_programa = new System.Windows.Forms.TextBox();
            this.lbl_qm_programa = new System.Windows.Forms.Label();
            this.chb_qm_executar = new System.Windows.Forms.CheckBox();
            this.tbp_infinite = new System.Windows.Forms.TabPage();
            this.grb_infinite_manutencao = new System.Windows.Forms.GroupBox();
            this.txb_im_execucao = new System.Windows.Forms.TextBox();
            this.lbl_im_execucao = new System.Windows.Forms.Label();
            this.txb_im_programa = new System.Windows.Forms.TextBox();
            this.lbl_im_programa = new System.Windows.Forms.Label();
            this.chb_im_executar = new System.Windows.Forms.CheckBox();
            this.btn_ga_feriados = new System.Windows.Forms.Button();
            this.btn_ga_encerrar = new System.Windows.Forms.Button();
            this.tbc_panel.SuspendLayout();
            this.tbp_geral.SuspendLayout();
            this.grb_geral_agendador.SuspendLayout();
            this.tbp_metatrader.SuspendLayout();
            this.grp_metatrader_coleta.SuspendLayout();
            this.tbp_loto365.SuspendLayout();
            this.grb_loto365_palpites.SuspendLayout();
            this.tbp_quanthon.SuspendLayout();
            this.grb_quanthon_manutencao.SuspendLayout();
            this.tbp_infinite.SuspendLayout();
            this.grb_infinite_manutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(194, 201);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 100;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(277, 201);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 101;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tbc_panel
            // 
            this.tbc_panel.Controls.Add(this.tbp_geral);
            this.tbc_panel.Controls.Add(this.tbp_metatrader);
            this.tbc_panel.Controls.Add(this.tbp_infinite);
            this.tbc_panel.Controls.Add(this.tbp_quanthon);
            this.tbc_panel.Controls.Add(this.tbp_loto365);
            this.tbc_panel.Location = new System.Drawing.Point(10, 10);
            this.tbc_panel.Name = "tbc_panel";
            this.tbc_panel.SelectedIndex = 0;
            this.tbc_panel.Size = new System.Drawing.Size(343, 183);
            this.tbc_panel.TabIndex = 1;
            // 
            // tbp_geral
            // 
            this.tbp_geral.Controls.Add(this.grb_geral_agendador);
            this.tbp_geral.Location = new System.Drawing.Point(4, 22);
            this.tbp_geral.Name = "tbp_geral";
            this.tbp_geral.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_geral.Size = new System.Drawing.Size(335, 157);
            this.tbp_geral.TabIndex = 0;
            this.tbp_geral.Text = "Geral";
            this.tbp_geral.UseVisualStyleBackColor = true;
            // 
            // grb_geral_agendador
            // 
            this.grb_geral_agendador.Controls.Add(this.btn_ga_feriados);
            this.grb_geral_agendador.Controls.Add(this.btn_ga_encerrar);
            this.grb_geral_agendador.Controls.Add(this.ckb_ga_acertar);
            this.grb_geral_agendador.Controls.Add(this.ckb_ga_nao_encerrar);
            this.grb_geral_agendador.Controls.Add(this.ckb_ga_habilitar);
            this.grb_geral_agendador.Location = new System.Drawing.Point(7, 9);
            this.grb_geral_agendador.Name = "grb_geral_agendador";
            this.grb_geral_agendador.Size = new System.Drawing.Size(319, 140);
            this.grb_geral_agendador.TabIndex = 0;
            this.grb_geral_agendador.TabStop = false;
            this.grb_geral_agendador.Text = "Agendador de Tarefas";
            // 
            // ckb_ga_acertar
            // 
            this.ckb_ga_acertar.AutoSize = true;
            this.ckb_ga_acertar.Location = new System.Drawing.Point(11, 48);
            this.ckb_ga_acertar.Name = "ckb_ga_acertar";
            this.ckb_ga_acertar.Size = new System.Drawing.Size(252, 17);
            this.ckb_ga_acertar.TabIndex = 3;
            this.ckb_ga_acertar.Text = "Acertar as horas do computador periodicamente";
            this.ckb_ga_acertar.UseVisualStyleBackColor = true;
            // 
            // ckb_ga_nao_encerrar
            // 
            this.ckb_ga_nao_encerrar.AutoSize = true;
            this.ckb_ga_nao_encerrar.Location = new System.Drawing.Point(11, 74);
            this.ckb_ga_nao_encerrar.Name = "ckb_ga_nao_encerrar";
            this.ckb_ga_nao_encerrar.Size = new System.Drawing.Size(240, 17);
            this.ckb_ga_nao_encerrar.TabIndex = 4;
            this.ckb_ga_nao_encerrar.Text = "NÃO encerrar aplicativos ainda em execução";
            this.ckb_ga_nao_encerrar.UseVisualStyleBackColor = true;
            // 
            // ckb_ga_habilitar
            // 
            this.ckb_ga_habilitar.AutoSize = true;
            this.ckb_ga_habilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_ga_habilitar.Location = new System.Drawing.Point(11, 22);
            this.ckb_ga_habilitar.Name = "ckb_ga_habilitar";
            this.ckb_ga_habilitar.Size = new System.Drawing.Size(249, 17);
            this.ckb_ga_habilitar.TabIndex = 2;
            this.ckb_ga_habilitar.Text = "Habilitar agendamento diário de tarefas";
            this.ckb_ga_habilitar.UseVisualStyleBackColor = true;
            this.ckb_ga_habilitar.CheckedChanged += new System.EventHandler(this.ckb_ga_habilitar_CheckedChanged);
            // 
            // tbp_metatrader
            // 
            this.tbp_metatrader.Controls.Add(this.grp_metatrader_coleta);
            this.tbp_metatrader.Location = new System.Drawing.Point(4, 22);
            this.tbp_metatrader.Name = "tbp_metatrader";
            this.tbp_metatrader.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_metatrader.Size = new System.Drawing.Size(335, 157);
            this.tbp_metatrader.TabIndex = 2;
            this.tbp_metatrader.Text = "MetaTrader";
            this.tbp_metatrader.UseVisualStyleBackColor = true;
            // 
            // grp_metatrader_coleta
            // 
            this.grp_metatrader_coleta.Controls.Add(this.lbl_mc_modal);
            this.grp_metatrader_coleta.Controls.Add(this.txb_mc_modal);
            this.grp_metatrader_coleta.Controls.Add(this.txb_mc_xmg);
            this.grp_metatrader_coleta.Controls.Add(this.lbl_mc_xmg);
            this.grp_metatrader_coleta.Controls.Add(this.txb_mc_genial);
            this.grp_metatrader_coleta.Controls.Add(this.lbl_mc_genial);
            this.grp_metatrader_coleta.Controls.Add(this.ckb_mc_executar);
            this.grp_metatrader_coleta.Location = new System.Drawing.Point(7, 9);
            this.grp_metatrader_coleta.Name = "grp_metatrader_coleta";
            this.grp_metatrader_coleta.Size = new System.Drawing.Size(319, 140);
            this.grp_metatrader_coleta.TabIndex = 0;
            this.grp_metatrader_coleta.TabStop = false;
            this.grp_metatrader_coleta.Text = "Coleta de Dados";
            // 
            // lbl_mc_modal
            // 
            this.lbl_mc_modal.AutoSize = true;
            this.lbl_mc_modal.Location = new System.Drawing.Point(7, 79);
            this.lbl_mc_modal.Name = "lbl_mc_modal";
            this.lbl_mc_modal.Size = new System.Drawing.Size(107, 13);
            this.lbl_mc_modal.TabIndex = 0;
            this.lbl_mc_modal.Text = "Corretora ModalMais:";
            this.lbl_mc_modal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_mc_modal
            // 
            this.txb_mc_modal.Location = new System.Drawing.Point(115, 76);
            this.txb_mc_modal.Name = "txb_mc_modal";
            this.txb_mc_modal.Size = new System.Drawing.Size(193, 20);
            this.txb_mc_modal.TabIndex = 3;
            // 
            // txb_mc_xmg
            // 
            this.txb_mc_xmg.Location = new System.Drawing.Point(115, 103);
            this.txb_mc_xmg.Name = "txb_mc_xmg";
            this.txb_mc_xmg.Size = new System.Drawing.Size(193, 20);
            this.txb_mc_xmg.TabIndex = 4;
            // 
            // lbl_mc_xmg
            // 
            this.lbl_mc_xmg.AutoSize = true;
            this.lbl_mc_xmg.Location = new System.Drawing.Point(7, 106);
            this.lbl_mc_xmg.Name = "lbl_mc_xmg";
            this.lbl_mc_xmg.Size = new System.Drawing.Size(105, 13);
            this.lbl_mc_xmg.TabIndex = 0;
            this.lbl_mc_xmg.Text = "Corretora XM Global:";
            // 
            // txb_mc_genial
            // 
            this.txb_mc_genial.Location = new System.Drawing.Point(115, 49);
            this.txb_mc_genial.Name = "txb_mc_genial";
            this.txb_mc_genial.Size = new System.Drawing.Size(193, 20);
            this.txb_mc_genial.TabIndex = 2;
            // 
            // lbl_mc_genial
            // 
            this.lbl_mc_genial.AutoSize = true;
            this.lbl_mc_genial.Location = new System.Drawing.Point(7, 52);
            this.lbl_mc_genial.Name = "lbl_mc_genial";
            this.lbl_mc_genial.Size = new System.Drawing.Size(86, 13);
            this.lbl_mc_genial.TabIndex = 0;
            this.lbl_mc_genial.Text = "Corretora Genial:";
            this.lbl_mc_genial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckb_mc_executar
            // 
            this.ckb_mc_executar.AutoSize = true;
            this.ckb_mc_executar.Location = new System.Drawing.Point(11, 22);
            this.ckb_mc_executar.Name = "ckb_mc_executar";
            this.ckb_mc_executar.Size = new System.Drawing.Size(217, 17);
            this.ckb_mc_executar.TabIndex = 1;
            this.ckb_mc_executar.Text = "Executar MetaTrader para coletar dados";
            this.ckb_mc_executar.UseVisualStyleBackColor = true;
            // 
            // tbp_loto365
            // 
            this.tbp_loto365.Controls.Add(this.grb_loto365_palpites);
            this.tbp_loto365.Location = new System.Drawing.Point(4, 22);
            this.tbp_loto365.Name = "tbp_loto365";
            this.tbp_loto365.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_loto365.Size = new System.Drawing.Size(335, 157);
            this.tbp_loto365.TabIndex = 1;
            this.tbp_loto365.Text = "Loto365";
            this.tbp_loto365.UseVisualStyleBackColor = true;
            // 
            // grb_loto365_palpites
            // 
            this.grb_loto365_palpites.Controls.Add(this.txb_lp_execucao);
            this.grb_loto365_palpites.Controls.Add(this.lbl_lp_execucao);
            this.grb_loto365_palpites.Controls.Add(this.txb_lp_programa);
            this.grb_loto365_palpites.Controls.Add(this.lbl_lp_programa);
            this.grb_loto365_palpites.Controls.Add(this.ckb_lp_executar);
            this.grb_loto365_palpites.Location = new System.Drawing.Point(7, 9);
            this.grb_loto365_palpites.Name = "grb_loto365_palpites";
            this.grb_loto365_palpites.Size = new System.Drawing.Size(319, 140);
            this.grb_loto365_palpites.TabIndex = 0;
            this.grb_loto365_palpites.TabStop = false;
            this.grb_loto365_palpites.Text = "Publicação de Palpites";
            // 
            // txb_lp_execucao
            // 
            this.txb_lp_execucao.Enabled = false;
            this.txb_lp_execucao.Location = new System.Drawing.Point(128, 103);
            this.txb_lp_execucao.Name = "txb_lp_execucao";
            this.txb_lp_execucao.Size = new System.Drawing.Size(180, 20);
            this.txb_lp_execucao.TabIndex = 0;
            // 
            // lbl_lp_execucao
            // 
            this.lbl_lp_execucao.AutoSize = true;
            this.lbl_lp_execucao.Location = new System.Drawing.Point(7, 106);
            this.lbl_lp_execucao.Name = "lbl_lp_execucao";
            this.lbl_lp_execucao.Size = new System.Drawing.Size(90, 13);
            this.lbl_lp_execucao.TabIndex = 0;
            this.lbl_lp_execucao.Text = "Última Execução:";
            // 
            // txb_lp_programa
            // 
            this.txb_lp_programa.Location = new System.Drawing.Point(11, 70);
            this.txb_lp_programa.Name = "txb_lp_programa";
            this.txb_lp_programa.Size = new System.Drawing.Size(297, 20);
            this.txb_lp_programa.TabIndex = 3;
            // 
            // lbl_lp_programa
            // 
            this.lbl_lp_programa.AutoSize = true;
            this.lbl_lp_programa.Location = new System.Drawing.Point(7, 52);
            this.lbl_lp_programa.Name = "lbl_lp_programa";
            this.lbl_lp_programa.Size = new System.Drawing.Size(99, 13);
            this.lbl_lp_programa.TabIndex = 0;
            this.lbl_lp_programa.Text = "Local do Programa:";
            this.lbl_lp_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckb_lp_executar
            // 
            this.ckb_lp_executar.AutoSize = true;
            this.ckb_lp_executar.Location = new System.Drawing.Point(11, 22);
            this.ckb_lp_executar.Name = "ckb_lp_executar";
            this.ckb_lp_executar.Size = new System.Drawing.Size(262, 17);
            this.ckb_lp_executar.TabIndex = 2;
            this.ckb_lp_executar.Text = "Executar programa para gerar palpites diariamente";
            this.ckb_lp_executar.UseVisualStyleBackColor = true;
            // 
            // tbp_quanthon
            // 
            this.tbp_quanthon.Controls.Add(this.grb_quanthon_manutencao);
            this.tbp_quanthon.Location = new System.Drawing.Point(4, 22);
            this.tbp_quanthon.Name = "tbp_quanthon";
            this.tbp_quanthon.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_quanthon.Size = new System.Drawing.Size(335, 157);
            this.tbp_quanthon.TabIndex = 3;
            this.tbp_quanthon.Text = "Quanthon";
            this.tbp_quanthon.UseVisualStyleBackColor = true;
            // 
            // grb_quanthon_manutencao
            // 
            this.grb_quanthon_manutencao.Controls.Add(this.txb_qm_execucao);
            this.grb_quanthon_manutencao.Controls.Add(this.lbl_qm_execucao);
            this.grb_quanthon_manutencao.Controls.Add(this.txb_qm_programa);
            this.grb_quanthon_manutencao.Controls.Add(this.lbl_qm_programa);
            this.grb_quanthon_manutencao.Controls.Add(this.chb_qm_executar);
            this.grb_quanthon_manutencao.Location = new System.Drawing.Point(7, 9);
            this.grb_quanthon_manutencao.Name = "grb_quanthon_manutencao";
            this.grb_quanthon_manutencao.Size = new System.Drawing.Size(319, 140);
            this.grb_quanthon_manutencao.TabIndex = 0;
            this.grb_quanthon_manutencao.TabStop = false;
            this.grb_quanthon_manutencao.Text = "Manutenção Diária";
            // 
            // txb_qm_execucao
            // 
            this.txb_qm_execucao.Enabled = false;
            this.txb_qm_execucao.Location = new System.Drawing.Point(128, 103);
            this.txb_qm_execucao.Name = "txb_qm_execucao";
            this.txb_qm_execucao.Size = new System.Drawing.Size(180, 20);
            this.txb_qm_execucao.TabIndex = 0;
            // 
            // lbl_qm_execucao
            // 
            this.lbl_qm_execucao.AutoSize = true;
            this.lbl_qm_execucao.Location = new System.Drawing.Point(7, 106);
            this.lbl_qm_execucao.Name = "lbl_qm_execucao";
            this.lbl_qm_execucao.Size = new System.Drawing.Size(90, 13);
            this.lbl_qm_execucao.TabIndex = 0;
            this.lbl_qm_execucao.Text = "Última Execução:";
            // 
            // txb_qm_programa
            // 
            this.txb_qm_programa.Location = new System.Drawing.Point(11, 70);
            this.txb_qm_programa.Name = "txb_qm_programa";
            this.txb_qm_programa.Size = new System.Drawing.Size(297, 20);
            this.txb_qm_programa.TabIndex = 3;
            // 
            // lbl_qm_programa
            // 
            this.lbl_qm_programa.AutoSize = true;
            this.lbl_qm_programa.Location = new System.Drawing.Point(7, 52);
            this.lbl_qm_programa.Name = "lbl_qm_programa";
            this.lbl_qm_programa.Size = new System.Drawing.Size(99, 13);
            this.lbl_qm_programa.TabIndex = 0;
            this.lbl_qm_programa.Text = "Local do Programa:";
            this.lbl_qm_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chb_qm_executar
            // 
            this.chb_qm_executar.AutoSize = true;
            this.chb_qm_executar.Location = new System.Drawing.Point(11, 22);
            this.chb_qm_executar.Name = "chb_qm_executar";
            this.chb_qm_executar.Size = new System.Drawing.Size(220, 17);
            this.chb_qm_executar.TabIndex = 2;
            this.chb_qm_executar.Text = "Executar programa de manutenção diária";
            this.chb_qm_executar.UseVisualStyleBackColor = true;
            // 
            // tbp_infinite
            // 
            this.tbp_infinite.Controls.Add(this.grb_infinite_manutencao);
            this.tbp_infinite.Location = new System.Drawing.Point(4, 22);
            this.tbp_infinite.Name = "tbp_infinite";
            this.tbp_infinite.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_infinite.Size = new System.Drawing.Size(335, 157);
            this.tbp_infinite.TabIndex = 4;
            this.tbp_infinite.Text = "Infinite";
            this.tbp_infinite.UseVisualStyleBackColor = true;
            // 
            // grb_infinite_manutencao
            // 
            this.grb_infinite_manutencao.Controls.Add(this.txb_im_execucao);
            this.grb_infinite_manutencao.Controls.Add(this.lbl_im_execucao);
            this.grb_infinite_manutencao.Controls.Add(this.txb_im_programa);
            this.grb_infinite_manutencao.Controls.Add(this.lbl_im_programa);
            this.grb_infinite_manutencao.Controls.Add(this.chb_im_executar);
            this.grb_infinite_manutencao.Location = new System.Drawing.Point(7, 9);
            this.grb_infinite_manutencao.Name = "grb_infinite_manutencao";
            this.grb_infinite_manutencao.Size = new System.Drawing.Size(319, 140);
            this.grb_infinite_manutencao.TabIndex = 1;
            this.grb_infinite_manutencao.TabStop = false;
            this.grb_infinite_manutencao.Text = "Coleta Diária de Dados";
            // 
            // txb_im_execucao
            // 
            this.txb_im_execucao.Enabled = false;
            this.txb_im_execucao.Location = new System.Drawing.Point(128, 103);
            this.txb_im_execucao.Name = "txb_im_execucao";
            this.txb_im_execucao.Size = new System.Drawing.Size(180, 20);
            this.txb_im_execucao.TabIndex = 0;
            // 
            // lbl_im_execucao
            // 
            this.lbl_im_execucao.AutoSize = true;
            this.lbl_im_execucao.Location = new System.Drawing.Point(7, 106);
            this.lbl_im_execucao.Name = "lbl_im_execucao";
            this.lbl_im_execucao.Size = new System.Drawing.Size(90, 13);
            this.lbl_im_execucao.TabIndex = 0;
            this.lbl_im_execucao.Text = "Última Execução:";
            // 
            // txb_im_programa
            // 
            this.txb_im_programa.Location = new System.Drawing.Point(11, 70);
            this.txb_im_programa.Name = "txb_im_programa";
            this.txb_im_programa.Size = new System.Drawing.Size(297, 20);
            this.txb_im_programa.TabIndex = 3;
            // 
            // lbl_im_programa
            // 
            this.lbl_im_programa.AutoSize = true;
            this.lbl_im_programa.Location = new System.Drawing.Point(7, 52);
            this.lbl_im_programa.Name = "lbl_im_programa";
            this.lbl_im_programa.Size = new System.Drawing.Size(99, 13);
            this.lbl_im_programa.TabIndex = 0;
            this.lbl_im_programa.Text = "Local do Programa:";
            this.lbl_im_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chb_im_executar
            // 
            this.chb_im_executar.AutoSize = true;
            this.chb_im_executar.Location = new System.Drawing.Point(11, 22);
            this.chb_im_executar.Name = "chb_im_executar";
            this.chb_im_executar.Size = new System.Drawing.Size(247, 17);
            this.chb_im_executar.TabIndex = 2;
            this.chb_im_executar.Text = "Executar programa para coletar dados da Web";
            this.chb_im_executar.UseVisualStyleBackColor = true;
            // 
            // btn_ga_feriados
            // 
            this.btn_ga_feriados.Location = new System.Drawing.Point(164, 101);
            this.btn_ga_feriados.Name = "btn_ga_feriados";
            this.btn_ga_feriados.Size = new System.Drawing.Size(145, 23);
            this.btn_ga_feriados.TabIndex = 6;
            this.btn_ga_feriados.Text = "Exibir Feriados 2022...";
            this.btn_ga_feriados.UseVisualStyleBackColor = true;
            this.btn_ga_feriados.Click += new System.EventHandler(this.btn_ga_feriados_Click);
            // 
            // btn_ga_encerrar
            // 
            this.btn_ga_encerrar.Location = new System.Drawing.Point(10, 101);
            this.btn_ga_encerrar.Name = "btn_ga_encerrar";
            this.btn_ga_encerrar.Size = new System.Drawing.Size(145, 23);
            this.btn_ga_encerrar.TabIndex = 5;
            this.btn_ga_encerrar.Text = "Encerrar Todas Tarefas...";
            this.btn_ga_encerrar.UseVisualStyleBackColor = true;
            this.btn_ga_encerrar.Click += new System.EventHandler(this.btn_ga_encerrar_Click);
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 233);
            this.Controls.Add(this.tbc_panel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janitor  •  Configurações";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.tbc_panel.ResumeLayout(false);
            this.tbp_geral.ResumeLayout(false);
            this.grb_geral_agendador.ResumeLayout(false);
            this.grb_geral_agendador.PerformLayout();
            this.tbp_metatrader.ResumeLayout(false);
            this.grp_metatrader_coleta.ResumeLayout(false);
            this.grp_metatrader_coleta.PerformLayout();
            this.tbp_loto365.ResumeLayout(false);
            this.grb_loto365_palpites.ResumeLayout(false);
            this.grb_loto365_palpites.PerformLayout();
            this.tbp_quanthon.ResumeLayout(false);
            this.grb_quanthon_manutencao.ResumeLayout(false);
            this.grb_quanthon_manutencao.PerformLayout();
            this.tbp_infinite.ResumeLayout(false);
            this.grb_infinite_manutencao.ResumeLayout(false);
            this.grb_infinite_manutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TabControl tbc_panel;
        private System.Windows.Forms.TabPage tbp_geral;
        private System.Windows.Forms.TabPage tbp_loto365;
        private System.Windows.Forms.TabPage tbp_metatrader;
        private System.Windows.Forms.TabPage tbp_quanthon;
        private System.Windows.Forms.GroupBox grb_geral_agendador;
        private System.Windows.Forms.CheckBox ckb_ga_habilitar;
        private System.Windows.Forms.GroupBox grp_metatrader_coleta;
        private System.Windows.Forms.Label lbl_mc_genial;
        private System.Windows.Forms.CheckBox ckb_mc_executar;
        private System.Windows.Forms.TextBox txb_mc_genial;
        private System.Windows.Forms.TextBox txb_mc_xmg;
        private System.Windows.Forms.Label lbl_mc_xmg;
        private System.Windows.Forms.GroupBox grb_loto365_palpites;
        private System.Windows.Forms.TextBox txb_lp_execucao;
        private System.Windows.Forms.Label lbl_lp_execucao;
        private System.Windows.Forms.TextBox txb_lp_programa;
        private System.Windows.Forms.Label lbl_lp_programa;
        private System.Windows.Forms.CheckBox ckb_lp_executar;
        private System.Windows.Forms.GroupBox grb_quanthon_manutencao;
        private System.Windows.Forms.TextBox txb_qm_execucao;
        private System.Windows.Forms.Label lbl_qm_execucao;
        private System.Windows.Forms.TextBox txb_qm_programa;
        private System.Windows.Forms.Label lbl_qm_programa;
        private System.Windows.Forms.CheckBox chb_qm_executar;
        private System.Windows.Forms.CheckBox ckb_ga_acertar;
        private System.Windows.Forms.CheckBox ckb_ga_nao_encerrar;
        private System.Windows.Forms.Label lbl_mc_modal;
        private System.Windows.Forms.TextBox txb_mc_modal;
        private System.Windows.Forms.TabPage tbp_infinite;
        private System.Windows.Forms.GroupBox grb_infinite_manutencao;
        private System.Windows.Forms.TextBox txb_im_execucao;
        private System.Windows.Forms.Label lbl_im_execucao;
        private System.Windows.Forms.TextBox txb_im_programa;
        private System.Windows.Forms.Label lbl_im_programa;
        private System.Windows.Forms.CheckBox chb_im_executar;
        private System.Windows.Forms.Button btn_ga_feriados;
        private System.Windows.Forms.Button btn_ga_encerrar;
    }
}

