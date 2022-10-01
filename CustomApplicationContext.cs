using System;
using System.Windows.Forms;
using System.Reflection;
using NLog;
using Janitor.Properties;

namespace Janitor
{

    /// <summary>
    /// Framework for running application as a tray app.
    /// </summary>
    public class CustomApplicationContext : ApplicationContext
    {
        // referencia ao logger do NLog para toda a classe:
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        // acesso mais agil as configuracoes da aplicacao (usuario):
        private static readonly Settings config = Properties.Settings.Default;

        private readonly JanitorManager janitorManager;
        private System.ComponentModel.IContainer components;	// a list of components to dispose when the context is disposed
        private NotifyIcon notifyIcon;				            // the icon that sits in the system tray
        private FrmConfig frmConfig;

        /// <summary>
		/// This class should be created and passed into Application.Run( ... )
		/// </summary>
		public CustomApplicationContext()
        {
            InitializeContext();
            janitorManager = new JanitorManager(notifyIcon);
            //janitorManager.BuildServerAssociations();
            // ao executar o Janitor, sempre mostra a tela de configuracoes:
            ShowConfigForm(); 
        }

        private void InitializeContext()
        {
            components = new System.ComponentModel.Container();
            notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = true
            };
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripMenuItem("Abrir &Configurações...", Properties.Resources.png_configuration, showConfigItem_Click));
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            notifyIcon.ContextMenuStrip.Items.Add(new ToolStripMenuItem("Sai&r", Properties.Resources.png_exit, exitItem_Click));
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            notifyIcon.MouseUp += notifyIcon_MouseUp;
            // atualiza o icone da sys-tray conforme a configuracao corrente.
            notifyIcon_Refresh();
        }

        private void ShowConfigForm()
        {
            if (frmConfig == null)
            {
                frmConfig = new FrmConfig();
                frmConfig.Closed += frmConfig_Closed; // avoid reshowing a disposed form
                frmConfig.Show();
            }
            else
            {
                frmConfig.Activate();
            }
        }

        //--- EVENTOS DO TRAY-ICON --------------------------------------------

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowConfigForm();
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(notifyIcon, null);
            }
        }

        private void notifyIcon_Refresh()
        {  // atualiza o icone da sys-tray:
            if (config.GeralFlagTasks)
            {  // se estiver habilitado o agendamento de tarefas:
                notifyIcon.Icon = Properties.Resources.ico_janitor;
                notifyIcon.Text = "OK: AGENDAMENTO DE TAREFAS HABILITADO.";
            }
            else  // se estiver desabilitado o agendamento de tarefas:
            {
                notifyIcon.Icon = Properties.Resources.ico_off_janitor;
                notifyIcon.Text = "*** ATENÇÃO: AGENDAMENTO DE TAREFAS DESABILITADO. ***";
            }
        }

        //--- EVENTOS DO CONTEXT-MENU -----------------------------------------

        // attach to context menu items
        private void showConfigItem_Click(object sender, EventArgs e)
        {
            ShowConfigForm();
        }

        /// <summary>
        /// When the exit menu item is clicked, make a call to terminate the ApplicationContext.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        //--- EVENTOS DA TELA DE CONFIGURACAO ---------------------------------

        // null out the forms so we know to create a new one.
        private void frmConfig_Closed(object sender, EventArgs e) {
            // verifica se o usuario clicou no OK ou no Cancel:
            if (frmConfig.DialogResult == DialogResult.OK)
            { // se modificou alguma propriedade, atualiza o icone da sys-tray:
                notifyIcon_Refresh();
            }
            frmConfig = null; 
        }

        //--- APLICACAO FINALIZADA --------------------------------------------

        /// <summary>
        /// When the application context is disposed, dispose things like the notify icon.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) { 
                components.Dispose(); 
            }
        }

        /// <summary>
        /// If we are presently showing a form, clean it up.
        /// </summary>
        protected override void ExitThreadCore()
        {
            // before we exit, let forms clean themselves up.
            if (frmConfig != null) { 
                frmConfig.Close(); 
            }

            notifyIcon.Visible = false; // should remove lingering tray icon
            base.ExitThreadCore();
        }
    }
}
