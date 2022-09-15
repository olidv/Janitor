using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void tmr_clock_Tick(object sender, EventArgs e)
        {
            // a cada minuto, executa a varredura do scheduler:
            // if (DateTime.Now.Second == 0) checkScheduler();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // fecha o formulario:
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // fecha o formulario:
            this.Close();
        }
    }
}
