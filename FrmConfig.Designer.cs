
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_agendador = new System.Windows.Forms.CheckBox();
            this.tbc_panel.SuspendLayout();
            this.tbp_geral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(194, 252);
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
            this.btn_cancel.Location = new System.Drawing.Point(277, 252);
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
            this.tbc_panel.Size = new System.Drawing.Size(343, 234);
            this.tbc_panel.TabIndex = 2;
            // 
            // tbp_geral
            // 
            this.tbp_geral.Controls.Add(this.groupBox1);
            this.tbp_geral.Location = new System.Drawing.Point(4, 22);
            this.tbp_geral.Name = "tbp_geral";
            this.tbp_geral.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_geral.Size = new System.Drawing.Size(335, 208);
            this.tbp_geral.TabIndex = 0;
            this.tbp_geral.Text = "Geral";
            this.tbp_geral.UseVisualStyleBackColor = true;
            // 
            // tbp_loto365
            // 
            this.tbp_loto365.Location = new System.Drawing.Point(4, 22);
            this.tbp_loto365.Name = "tbp_loto365";
            this.tbp_loto365.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_loto365.Size = new System.Drawing.Size(335, 208);
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
            this.tbp_infinite.Location = new System.Drawing.Point(4, 22);
            this.tbp_infinite.Name = "tbp_infinite";
            this.tbp_infinite.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_infinite.Size = new System.Drawing.Size(335, 208);
            this.tbp_infinite.TabIndex = 2;
            this.tbp_infinite.Text = "Infinite";
            this.tbp_infinite.UseVisualStyleBackColor = true;
            // 
            // tbp_quanthon
            // 
            this.tbp_quanthon.Location = new System.Drawing.Point(4, 22);
            this.tbp_quanthon.Name = "tbp_quanthon";
            this.tbp_quanthon.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_quanthon.Size = new System.Drawing.Size(335, 208);
            this.tbp_quanthon.TabIndex = 3;
            this.tbp_quanthon.Text = "Quanthon";
            this.tbp_quanthon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_agendador);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendador de Tarefas";
            // 
            // ckb_agendador
            // 
            this.ckb_agendador.AutoSize = true;
            this.ckb_agendador.Location = new System.Drawing.Point(11, 22);
            this.ckb_agendador.Name = "ckb_agendador";
            this.ckb_agendador.Size = new System.Drawing.Size(210, 17);
            this.ckb_agendador.TabIndex = 0;
            this.ckb_agendador.Text = "Habilitar agendamento diário de tarefas";
            this.ckb_agendador.UseVisualStyleBackColor = true;
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 284);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_agendador;
    }
}

