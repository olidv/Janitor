﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using NLog;

namespace Janitor
{
    static class Program
    {
        // referencia ao logger do NLog para toda a classe:
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        
        // utilitario para atualizacao do horario do windows:
        private static readonly String W32TM = @"C:\Windows\System32\w32tm.exe";

        private static Janitor.frm_config frmConfig = null;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            logger.Info("Iniciando aplicacao Clock.exe.");
            // captura evento do sistema para identificar retorno (resume) da hibernacao/suspensao do computador:
            SystemEvents.PowerModeChanged += OnPowerModeChange;

            // aproveita para sincronizar o relogio do sistema na carga deste aplicativo:
            logger.Trace("Ao iniciar, atualiza o relogio do sistema.");
            ResyncSystemTime();

            // Carga da aplicacao e apresentacao da tela inicial:
            logger.Trace("Configuracao inicial para apresentacao da tela de configuração.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            logger.Trace("Abrindo tela de configuração do Janitor.exe.");
            frmConfig = new frm_config();
            frmConfig.Show();
            Application.Run();
        }

        private static void OnPowerModeChange(object s, PowerModeChangedEventArgs e)
        {
            // efetua nova sincronizacao do relogio do sistema ao retornar da hibernacao/suspensao:
            if (e.Mode == PowerModes.Resume)
            {
                logger.Info("Reativando programa Clock apos suspensao.");
                ResyncSystemTime();
            }
        }

        private static void ResyncSystemTime()
        {
            logger.Trace("Vai acertar a hora do computador com servidores do MS Windows...");
            try
            {
                // configura a sincronizacao do relogio do computador para "time.windows.com":
                ProcessStartInfo startInfoConfig = new ProcessStartInfo(W32TM);
                startInfoConfig.WindowStyle = ProcessWindowStyle.Hidden;
                // indica a lista de dominios a serem utilizados na sincronizacao e efetiva a configuracao:
                startInfoConfig.Arguments = "/config /syncfromflags:MANUAL /manualpeerlist:time.windows.com /reliable:YES";
                // executa o servico timer do windows para a sincronizacao do relogio do sistema:
                Process.Start(startInfoConfig);

                // executa novamente o servico timer do windows para efetivar a configuracao:
                ProcessStartInfo startInfoUpdate = new ProcessStartInfo(W32TM);
                startInfoUpdate.WindowStyle = ProcessWindowStyle.Hidden;
                // apenas indica o argumento /update para persistir a configuracao:
                startInfoUpdate.Arguments = "/config /update";
                Process.Start(startInfoUpdate);

                // executa o servico timer do windows para a sincronizacao do relogio do sistema:
                ProcessStartInfo startInfoResync = new ProcessStartInfo(W32TM);
                startInfoResync.WindowStyle = ProcessWindowStyle.Hidden;
                // forca a sincronizacao do relogio do sistema:
                startInfoResync.Arguments = "/resync";
                Process.Start(startInfoResync);
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar acertar a hora do computador: {}", e.Message);
            }
        }
    }
}
