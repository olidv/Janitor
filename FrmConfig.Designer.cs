
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_config));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tbc_panel = new System.Windows.Forms.TabControl();
            this.tbp_geral = new System.Windows.Forms.TabPage();
            this.tbp_loto365 = new System.Windows.Forms.TabPage();
            this.tmr_clock = new System.Windows.Forms.Timer(this.components);
            this.tbp_infinite = new System.Windows.Forms.TabPage();
            this.tbp_quanthon = new System.Windows.Forms.TabPage();
            this.grb_geral_agendador = new System.Windows.Forms.GroupBox();
            this.ckb_ga_habilitar = new System.Windows.Forms.CheckBox();
            this.lbl_ga_estacao = new System.Windows.Forms.Label();
            this.cmb_ga_estacao = new System.Windows.Forms.ComboBox();
            this.lbl_im_programa = new System.Windows.Forms.Label();
            this.ckb_im_executar = new System.Windows.Forms.CheckBox();
            this.grp_infinite_manutencao = new System.Windows.Forms.GroupBox();
            this.txb_im_programa = new System.Windows.Forms.TextBox();
            this.lbl_im_execucao = new System.Windows.Forms.Label();
            this.txb_im_execucao = new System.Windows.Forms.TextBox();
            this.grb_loto365_manutencao = new System.Windows.Forms.GroupBox();
            this.txb_lm_execucao = new System.Windows.Forms.TextBox();
            this.lbl_lm_execucao = new System.Windows.Forms.Label();
            this.txb_lm_programa = new System.Windows.Forms.TextBox();
            this.lbl_lm_programa = new System.Windows.Forms.Label();
            this.ckb_lm_executar = new System.Windows.Forms.CheckBox();
            this.grb_quanthon_manutencao = new System.Windows.Forms.GroupBox();
            this.txb_qm_execucao = new System.Windows.Forms.TextBox();
            this.lbl_qm_execucao = new System.Windows.Forms.Label();
            this.txb_qm_programa = new System.Windows.Forms.TextBox();
            this.lbl_qm_programa = new System.Windows.Forms.Label();
            this.chb_qm_executar = new System.Windows.Forms.CheckBox();
            this.tbc_panel.SuspendLayout();
            this.tbp_geral.SuspendLayout();
            this.tbp_loto365.SuspendLayout();
            this.tbp_infinite.SuspendLayout();
            this.tbp_quanthon.SuspendLayout();
            this.grb_geral_agendador.SuspendLayout();
            this.grp_infinite_manutencao.SuspendLayout();
            this.grb_loto365_manutencao.SuspendLayout();
            this.grb_quanthon_manutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(194, 200);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(277, 200);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tbc_panel
            // 
            this.tbc_panel.Controls.Add(this.tbp_geral);
            this.tbc_panel.Controls.Add(this.tbp_infinite);
            this.tbc_panel.Controls.Add(this.tbp_loto365);
            this.tbc_panel.Controls.Add(this.tbp_quanthon);
            this.tbc_panel.Location = new System.Drawing.Point(10, 10);
            this.tbc_panel.Name = "tbc_panel";
            this.tbc_panel.SelectedIndex = 0;
            this.tbc_panel.Size = new System.Drawing.Size(343, 182);
            this.tbc_panel.TabIndex = 2;
            // 
            // tbp_geral
            // 
            this.tbp_geral.Controls.Add(this.grb_geral_agendador);
            this.tbp_geral.Location = new System.Drawing.Point(4, 22);
            this.tbp_geral.Name = "tbp_geral";
            this.tbp_geral.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_geral.Size = new System.Drawing.Size(335, 156);
            this.tbp_geral.TabIndex = 0;
            this.tbp_geral.Text = "Geral";
            this.tbp_geral.UseVisualStyleBackColor = true;
            // 
            // tbp_loto365
            // 
            this.tbp_loto365.Controls.Add(this.grb_loto365_manutencao);
            this.tbp_loto365.Location = new System.Drawing.Point(4, 22);
            this.tbp_loto365.Name = "tbp_loto365";
            this.tbp_loto365.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_loto365.Size = new System.Drawing.Size(335, 156);
            this.tbp_loto365.TabIndex = 1;
            this.tbp_loto365.Text = "Loto365";
            this.tbp_loto365.UseVisualStyleBackColor = true;
            // 
            // tmr_clock
            // 
            this.tmr_clock.Tick += new System.EventHandler(this.tmr_clock_Tick);
            // 
            // tbp_infinite
            // 
            this.tbp_infinite.Controls.Add(this.grp_infinite_manutencao);
            this.tbp_infinite.Location = new System.Drawing.Point(4, 22);
            this.tbp_infinite.Name = "tbp_infinite";
            this.tbp_infinite.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_infinite.Size = new System.Drawing.Size(335, 156);
            this.tbp_infinite.TabIndex = 2;
            this.tbp_infinite.Text = "Infinite";
            this.tbp_infinite.UseVisualStyleBackColor = true;
            // 
            // tbp_quanthon
            // 
            this.tbp_quanthon.Controls.Add(this.grb_quanthon_manutencao);
            this.tbp_quanthon.Location = new System.Drawing.Point(4, 22);
            this.tbp_quanthon.Name = "tbp_quanthon";
            this.tbp_quanthon.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_quanthon.Size = new System.Drawing.Size(335, 156);
            this.tbp_quanthon.TabIndex = 3;
            this.tbp_quanthon.Text = "Quanthon";
            this.tbp_quanthon.UseVisualStyleBackColor = true;
            // 
            // grb_geral_agendador
            // 
            this.grb_geral_agendador.Controls.Add(this.cmb_ga_estacao);
            this.grb_geral_agendador.Controls.Add(this.lbl_ga_estacao);
            this.grb_geral_agendador.Controls.Add(this.ckb_ga_habilitar);
            this.grb_geral_agendador.Location = new System.Drawing.Point(7, 9);
            this.grb_geral_agendador.Name = "grb_geral_agendador";
            this.grb_geral_agendador.Size = new System.Drawing.Size(319, 139);
            this.grb_geral_agendador.TabIndex = 1;
            this.grb_geral_agendador.TabStop = false;
            this.grb_geral_agendador.Text = "Agendador de Tarefas";
            // 
            // ckb_ga_habilitar
            // 
            this.ckb_ga_habilitar.AutoSize = true;
            this.ckb_ga_habilitar.Location = new System.Drawing.Point(11, 22);
            this.ckb_ga_habilitar.Name = "ckb_ga_habilitar";
            this.ckb_ga_habilitar.Size = new System.Drawing.Size(210, 17);
            this.ckb_ga_habilitar.TabIndex = 0;
            this.ckb_ga_habilitar.Text = "Habilitar agendamento diário de tarefas";
            this.ckb_ga_habilitar.UseVisualStyleBackColor = true;
            // 
            // lbl_ga_estacao
            // 
            this.lbl_ga_estacao.AutoSize = true;
            this.lbl_ga_estacao.Location = new System.Drawing.Point(7, 52);
            this.lbl_ga_estacao.Name = "lbl_ga_estacao";
            this.lbl_ga_estacao.Size = new System.Drawing.Size(109, 13);
            this.lbl_ga_estacao.TabIndex = 1;
            this.lbl_ga_estacao.Text = "Estação de Trabalho:";
            this.lbl_ga_estacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ga_estacao
            // 
            this.cmb_ga_estacao.FormattingEnabled = true;
            this.cmb_ga_estacao.Location = new System.Drawing.Point(126, 49);
            this.cmb_ga_estacao.Name = "cmb_ga_estacao";
            this.cmb_ga_estacao.Size = new System.Drawing.Size(182, 21);
            this.cmb_ga_estacao.Sorted = true;
            this.cmb_ga_estacao.TabIndex = 2;
            // 
            // lbl_im_programa
            // 
            this.lbl_im_programa.AutoSize = true;
            this.lbl_im_programa.Location = new System.Drawing.Point(7, 52);
            this.lbl_im_programa.Name = "lbl_im_programa";
            this.lbl_im_programa.Size = new System.Drawing.Size(99, 13);
            this.lbl_im_programa.TabIndex = 1;
            this.lbl_im_programa.Text = "Local do Programa:";
            this.lbl_im_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckb_im_executar
            // 
            this.ckb_im_executar.AutoSize = true;
            this.ckb_im_executar.Location = new System.Drawing.Point(11, 22);
            this.ckb_im_executar.Name = "ckb_im_executar";
            this.ckb_im_executar.Size = new System.Drawing.Size(220, 17);
            this.ckb_im_executar.TabIndex = 0;
            this.ckb_im_executar.Text = "Executar programa de manutenção diária";
            this.ckb_im_executar.UseVisualStyleBackColor = true;
            // 
            // grp_infinite_manutencao
            // 
            this.grp_infinite_manutencao.Controls.Add(this.txb_im_execucao);
            this.grp_infinite_manutencao.Controls.Add(this.lbl_im_execucao);
            this.grp_infinite_manutencao.Controls.Add(this.txb_im_programa);
            this.grp_infinite_manutencao.Controls.Add(this.lbl_im_programa);
            this.grp_infinite_manutencao.Controls.Add(this.ckb_im_executar);
            this.grp_infinite_manutencao.Location = new System.Drawing.Point(7, 9);
            this.grp_infinite_manutencao.Name = "grp_infinite_manutencao";
            this.grp_infinite_manutencao.Size = new System.Drawing.Size(319, 139);
            this.grp_infinite_manutencao.TabIndex = 2;
            this.grp_infinite_manutencao.TabStop = false;
            this.grp_infinite_manutencao.Text = "Manutenção Diária";
            // 
            // txb_im_programa
            // 
            this.txb_im_programa.Location = new System.Drawing.Point(11, 69);
            this.txb_im_programa.Name = "txb_im_programa";
            this.txb_im_programa.Size = new System.Drawing.Size(297, 20);
            this.txb_im_programa.TabIndex = 2;
            // 
            // lbl_im_execucao
            // 
            this.lbl_im_execucao.AutoSize = true;
            this.lbl_im_execucao.Location = new System.Drawing.Point(7, 105);
            this.lbl_im_execucao.Name = "lbl_im_execucao";
            this.lbl_im_execucao.Size = new System.Drawing.Size(90, 13);
            this.lbl_im_execucao.TabIndex = 3;
            this.lbl_im_execucao.Text = "Última Execução:";
            // 
            // txb_im_execucao
            // 
            this.txb_im_execucao.Enabled = false;
            this.txb_im_execucao.Location = new System.Drawing.Point(128, 102);
            this.txb_im_execucao.Name = "txb_im_execucao";
            this.txb_im_execucao.Size = new System.Drawing.Size(180, 20);
            this.txb_im_execucao.TabIndex = 4;
            // 
            // grb_loto365_manutencao
            // 
            this.grb_loto365_manutencao.Controls.Add(this.txb_lm_execucao);
            this.grb_loto365_manutencao.Controls.Add(this.lbl_lm_execucao);
            this.grb_loto365_manutencao.Controls.Add(this.txb_lm_programa);
            this.grb_loto365_manutencao.Controls.Add(this.lbl_lm_programa);
            this.grb_loto365_manutencao.Controls.Add(this.ckb_lm_executar);
            this.grb_loto365_manutencao.Location = new System.Drawing.Point(7, 9);
            this.grb_loto365_manutencao.Name = "grb_loto365_manutencao";
            this.grb_loto365_manutencao.Size = new System.Drawing.Size(319, 139);
            this.grb_loto365_manutencao.TabIndex = 3;
            this.grb_loto365_manutencao.TabStop = false;
            this.grb_loto365_manutencao.Text = "Manutenção Diária";
            // 
            // txb_lm_execucao
            // 
            this.txb_lm_execucao.Enabled = false;
            this.txb_lm_execucao.Location = new System.Drawing.Point(128, 102);
            this.txb_lm_execucao.Name = "txb_lm_execucao";
            this.txb_lm_execucao.Size = new System.Drawing.Size(180, 20);
            this.txb_lm_execucao.TabIndex = 4;
            // 
            // lbl_lm_execucao
            // 
            this.lbl_lm_execucao.AutoSize = true;
            this.lbl_lm_execucao.Location = new System.Drawing.Point(7, 105);
            this.lbl_lm_execucao.Name = "lbl_lm_execucao";
            this.lbl_lm_execucao.Size = new System.Drawing.Size(90, 13);
            this.lbl_lm_execucao.TabIndex = 3;
            this.lbl_lm_execucao.Text = "Última Execução:";
            // 
            // txb_lm_programa
            // 
            this.txb_lm_programa.Location = new System.Drawing.Point(11, 69);
            this.txb_lm_programa.Name = "txb_lm_programa";
            this.txb_lm_programa.Size = new System.Drawing.Size(297, 20);
            this.txb_lm_programa.TabIndex = 2;
            // 
            // lbl_lm_programa
            // 
            this.lbl_lm_programa.AutoSize = true;
            this.lbl_lm_programa.Location = new System.Drawing.Point(7, 52);
            this.lbl_lm_programa.Name = "lbl_lm_programa";
            this.lbl_lm_programa.Size = new System.Drawing.Size(99, 13);
            this.lbl_lm_programa.TabIndex = 1;
            this.lbl_lm_programa.Text = "Local do Programa:";
            this.lbl_lm_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckb_lm_executar
            // 
            this.ckb_lm_executar.AutoSize = true;
            this.ckb_lm_executar.Location = new System.Drawing.Point(11, 22);
            this.ckb_lm_executar.Name = "ckb_lm_executar";
            this.ckb_lm_executar.Size = new System.Drawing.Size(220, 17);
            this.ckb_lm_executar.TabIndex = 0;
            this.ckb_lm_executar.Text = "Executar programa de manutenção diária";
            this.ckb_lm_executar.UseVisualStyleBackColor = true;
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
            this.grb_quanthon_manutencao.Size = new System.Drawing.Size(319, 139);
            this.grb_quanthon_manutencao.TabIndex = 4;
            this.grb_quanthon_manutencao.TabStop = false;
            this.grb_quanthon_manutencao.Text = "Manutenção Diária";
            // 
            // txb_qm_execucao
            // 
            this.txb_qm_execucao.Enabled = false;
            this.txb_qm_execucao.Location = new System.Drawing.Point(128, 102);
            this.txb_qm_execucao.Name = "txb_qm_execucao";
            this.txb_qm_execucao.Size = new System.Drawing.Size(180, 20);
            this.txb_qm_execucao.TabIndex = 4;
            // 
            // lbl_qm_execucao
            // 
            this.lbl_qm_execucao.AutoSize = true;
            this.lbl_qm_execucao.Location = new System.Drawing.Point(7, 105);
            this.lbl_qm_execucao.Name = "lbl_qm_execucao";
            this.lbl_qm_execucao.Size = new System.Drawing.Size(90, 13);
            this.lbl_qm_execucao.TabIndex = 3;
            this.lbl_qm_execucao.Text = "Última Execução:";
            // 
            // txb_qm_programa
            // 
            this.txb_qm_programa.Enabled = false;
            this.txb_qm_programa.Location = new System.Drawing.Point(11, 69);
            this.txb_qm_programa.Name = "txb_qm_programa";
            this.txb_qm_programa.Size = new System.Drawing.Size(297, 20);
            this.txb_qm_programa.TabIndex = 2;
            // 
            // lbl_qm_programa
            // 
            this.lbl_qm_programa.AutoSize = true;
            this.lbl_qm_programa.Location = new System.Drawing.Point(7, 52);
            this.lbl_qm_programa.Name = "lbl_qm_programa";
            this.lbl_qm_programa.Size = new System.Drawing.Size(99, 13);
            this.lbl_qm_programa.TabIndex = 1;
            this.lbl_qm_programa.Text = "Local do Programa:";
            this.lbl_qm_programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chb_qm_executar
            // 
            this.chb_qm_executar.AutoSize = true;
            this.chb_qm_executar.Enabled = false;
            this.chb_qm_executar.Location = new System.Drawing.Point(11, 22);
            this.chb_qm_executar.Name = "chb_qm_executar";
            this.chb_qm_executar.Size = new System.Drawing.Size(220, 17);
            this.chb_qm_executar.TabIndex = 0;
            this.chb_qm_executar.Text = "Executar programa de manutenção diária";
            this.chb_qm_executar.UseVisualStyleBackColor = true;
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 232);
            this.Controls.Add(this.tbc_panel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janitor  •  Configuração";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.tbc_panel.ResumeLayout(false);
            this.tbp_geral.ResumeLayout(false);
            this.tbp_loto365.ResumeLayout(false);
            this.tbp_infinite.ResumeLayout(false);
            this.tbp_quanthon.ResumeLayout(false);
            this.grb_geral_agendador.ResumeLayout(false);
            this.grb_geral_agendador.PerformLayout();
            this.grp_infinite_manutencao.ResumeLayout(false);
            this.grp_infinite_manutencao.PerformLayout();
            this.grb_loto365_manutencao.ResumeLayout(false);
            this.grb_loto365_manutencao.PerformLayout();
            this.grb_quanthon_manutencao.ResumeLayout(false);
            this.grb_quanthon_manutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TabControl tbc_panel;
        private System.Windows.Forms.TabPage tbp_geral;
        private System.Windows.Forms.TabPage tbp_loto365;
        private System.Windows.Forms.Timer tmr_clock;
        private System.Windows.Forms.TabPage tbp_infinite;
        private System.Windows.Forms.TabPage tbp_quanthon;
        private System.Windows.Forms.GroupBox grb_geral_agendador;
        private System.Windows.Forms.CheckBox ckb_ga_habilitar;
        private System.Windows.Forms.ComboBox cmb_ga_estacao;
        private System.Windows.Forms.Label lbl_ga_estacao;
        private System.Windows.Forms.GroupBox grp_infinite_manutencao;
        private System.Windows.Forms.Label lbl_im_programa;
        private System.Windows.Forms.CheckBox ckb_im_executar;
        private System.Windows.Forms.TextBox txb_im_programa;
        private System.Windows.Forms.TextBox txb_im_execucao;
        private System.Windows.Forms.Label lbl_im_execucao;
        private System.Windows.Forms.GroupBox grb_loto365_manutencao;
        private System.Windows.Forms.TextBox txb_lm_execucao;
        private System.Windows.Forms.Label lbl_lm_execucao;
        private System.Windows.Forms.TextBox txb_lm_programa;
        private System.Windows.Forms.Label lbl_lm_programa;
        private System.Windows.Forms.CheckBox ckb_lm_executar;
        private System.Windows.Forms.GroupBox grb_quanthon_manutencao;
        private System.Windows.Forms.TextBox txb_qm_execucao;
        private System.Windows.Forms.Label lbl_qm_execucao;
        private System.Windows.Forms.TextBox txb_qm_programa;
        private System.Windows.Forms.Label lbl_qm_programa;
        private System.Windows.Forms.CheckBox chb_qm_executar;
    }
}

