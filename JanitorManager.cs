using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using NLog;
using Janitor.Properties;


namespace Janitor
{
    public class JanitorManager
    {
        // referencia ao logger do NLog para toda a classe:
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        // acesso mais agil as configuracoes da aplicacao (usuario):
        private static readonly Settings config = Properties.Settings.Default;

        // objeto timer para disparo de eventos e execucao de tarefas:
        private static System.Timers.Timer sTimer;

        /*** FERIADOS CONSIDERADOS PARA O AGENDAMENTO DE TAREFAS ***/

        static readonly string[] MESES = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

        static readonly (int dia, int mes)[] FERIADOS_FOREX = {( 1, 1),  // Ano Novo: Confraternizacao Universal
                                                               (25,12)}; // Natal
        /*** FERIADOS ANTECIPADOS 2021 e 2022 ***/
        static readonly (int dia, int mes)[] FERIADOS_BR_B3 = {( 1, 1),  // Ano Novo: Confraternizacao Universal
                                                               //(25, 1),  // Aniversario de Sao Paulo (SP)
                                                               (28, 2),  // Carnaval
                                                               ( 1, 3),  // Carnaval
                                                               //( 2, 3),  // Quarta-feira de Cinzas: Inicio as 13h
                                                               (15, 4),  // Paixao de Cristo
                                                               (21, 4),  // Tiradentes
                                                               ( 1, 5),  // Dia do Trabalho
                                                               (16, 6),  // Corpus Christi
                                                               //( 9, 7),  // Revolucao Constitucionalista (SP)
                                                               ( 7, 9),  // Independencia do Brasil
                                                               (12,10),  // Nossa Senhora Aparecida (Padroeira do Brasil)
                                                               ( 2,11),  // Finados
                                                               (15,11),  // Proclamacao da Republica
                                                               //(20,11),  // Consciencia Negra (SP)
                                                               //(24,12),  // Vespera de Natal
                                                               (25,12),  // Natal
                                                               (30,12) // Vespera de Ano Novo
                                                              };

        // referencia ao icone na sys-tray:
        private readonly NotifyIcon notifyIcon;

        public JanitorManager(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Create a timer with a two second interval.
            sTimer = new System.Timers.Timer(1000);

            // Hook up the Elapsed event for the timer. 
            sTimer.Elapsed += OnTimedEvent;
            sTimer.AutoReset = true;
            sTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;

            // verifica se o agendamento esta habilitado nas configuracoes:
            if (config.GeralFlagTasks)
            {
                // a cada minuto, executa o check-scheduler para todas as tarefas:
                if (now.Second == 0)
                {
                    // verifica se a execucao do MetaTrader esta habilitada nas configuracoes:
                    if (config.MT5FlagProgram) checkMetaTrader(now);

                    // verifica se a execucao do Colethon esta habilitada nas configuracoes:
                    if (config.ColetFlagProgram) checkColethon(now);

                    // verifica se a execucao do Lothon esta habilitada nas configuracoes:
                    if (config.LotoFlagProgram) checkLothon(now);

                    // verifica se a execucao do Quanthon esta habilitada nas configuracoes:
                    if (config.QuantFlagProgram) checkQuanthon(now);
                }
            }

            // verifica se o acerto das horas esta habilitado nas configuracoes:
            if (config.GeralFlagClocker)
            {
                // se for 12:00:00, acerta o relogio (ao menos 1x por dia):
                if (now.Second == 0 && now.Minute == 0 && now.Hour == 12)
                {
                    Program.ResyncSystemTime();
                }
            }
        }

        /*** SERVICO DE MONITORAMENTO DOS APLICATIVOS ***/

        public void checkMetaTrader(DateTime now)
        {
            // identifica informacoes sobre a data/dia corrente:
            var agora = (dia: now.Day,
                         mes: now.Month,
                         hor: now.Hour,
                         min: now.Minute,
                         dow: now.DayOfWeek,  // dia da semana
                         fb3: false,          // feriado B3
                         ob3: false,          // mercado B3 aberto (open B3)
                         ffx: false,          // feriado FOREX
                         ofx: false);         // mercado FOREX aberto (open FOREX)

            // verifica se o dia corrente eh feriado no mercado forex e no mercado b3:
            foreach ((int dia, int mes) feriado in FERIADOS_FOREX)
            {
                if (agora.dia == feriado.dia && agora.mes == feriado.mes)
                {
                    agora.ffx = true;
                }
            }
            foreach ((int dia, int mes) feriado in FERIADOS_BR_B3)
            {
                if (agora.dia == feriado.dia && agora.mes == feriado.mes)
                {
                    agora.fb3 = true;
                }
            }
            logger.Debug("Verificando calendario em checkMetaTrader() | isFeriadoForex={} | isFeriadoB3={}", agora.ffx, agora.fb3);

            // verifica se os mercados estao abertos ou fechados:
            switch (agora.dow)
            {
                case DayOfWeek.Monday:
                    agora.ofx = !agora.ffx;  // mercado forex esta aberto se nao for feriado internacional.
                    agora.ob3 = !agora.fb3 && ((agora.hor == 8 && agora.min >= 40) || (agora.hor >= 9 && agora.hor <= 17) || (agora.hor == 18 && agora.min <= 10));
                    break;
                case DayOfWeek.Tuesday:
                    agora.ofx = !agora.ffx;
                    agora.ob3 = !agora.fb3 && ((agora.hor == 8 && agora.min >= 40) || (agora.hor >= 9 && agora.hor <= 17) || (agora.hor == 18 && agora.min <= 10));
                    break;
                case DayOfWeek.Wednesday:
                    agora.ofx = !agora.ffx;
                    agora.ob3 = !agora.fb3 && ((agora.hor == 8 && agora.min >= 40) || (agora.hor >= 9 && agora.hor <= 17) || (agora.hor == 18 && agora.min <= 10));
                    break;
                case DayOfWeek.Thursday:
                    agora.ofx = !agora.ffx;
                    agora.ob3 = !agora.fb3 && ((agora.hor == 8 && agora.min >= 40) || (agora.hor >= 9 && agora.hor <= 17) || (agora.hor == 18 && agora.min <= 10));
                    break;
                case DayOfWeek.Friday:
                    agora.ofx = !agora.ffx && (agora.hor < 19);
                    agora.ob3 = !agora.fb3 && ((agora.hor == 8 && agora.min >= 40) || (agora.hor >= 9 && agora.hor <= 17) || (agora.hor == 18 && agora.min <= 10));
                    break;
                case DayOfWeek.Saturday:
                    agora.ofx = false;
                    agora.ob3 = false;
                    break;
                case DayOfWeek.Sunday:
                    agora.ofx = !agora.ffx && (agora.hor >= 18);
                    agora.ob3 = false;
                    break;
            }
            logger.Debug("Verificando mercados em checkMetaTrader() | isForexOpen={} | isB3Open={}", agora.ofx, agora.ob3);

            // busca o estado das instancias do MetaTrader (corretoras) em execucao:
            bool isMT5XmOn = false;
            Process procMT5Xm = null;

            bool isMT5ModalOn = false;
            Process procMT5Modal = null;

            bool isMT5GenialOn = false;
            Process procMT5Genial = null;

            Process[] processes = Process.GetProcessesByName("terminal64");
            logger.Debug("Verificando processos em checkMetaTrader() | processes = Process[{}]", processes.Length);
            foreach (Process proc in processes)
            {
                // Alterado para verificar pelo full-path pois o titulo as vezes vem em branco ""...
                string fullPath = proc.MainModule.FileName;
                logger.Debug("Path do Processo em execucao: {}", fullPath);

                if (fullPath.Contains("XM Global"))
                {
                    procMT5Xm = proc;
                    isMT5XmOn = true;
                }
                else if (fullPath.Contains("ModalMais"))
                {
                    procMT5Modal = proc;
                    isMT5ModalOn = true;
                }
                else  // GENIAL
                {
                    procMT5Genial = proc;
                    isMT5GenialOn = true;
                }
            }
            logger.Debug("Verificando processos em checkMetaTrader() | isMT5GenialOn={} | isMT5ModalOn={} | isMT5XmOn={}", isMT5GenialOn, isMT5ModalOn, isMT5XmOn);

            // ativacao ou suspensao do MT5 para Genial e ModalMais (B3):
            if (agora.ob3)
            { // Bolsa do brasil B3 aberta, executar MT5 se nao estiverem em execucao:
                if (!isMT5GenialOn)
                {
                    procMT5Genial = startProcess(config.MT5PathGenial, true);
                }
                if (!isMT5ModalOn)
                {
                    procMT5Modal = startProcess(config.MT5PathModal, true);
                }
            }
            else
            { // Bolsa do brasil fechada, encerrar MT5 se estiverem em execucao (e not-close desabilitado):
                if (isMT5GenialOn && !config.MT5FlagNotClose)
                {
                    stopProcess(procMT5Genial);
                }
                if (isMT5ModalOn && !config.MT5FlagNotClose)
                {
                    stopProcess(procMT5Modal);
                }
            }

            // ativacao ou suspensao do MT5 para XM (Forex):
            if (agora.ofx)
            { // Mercado Forex aberto, executar MT5 se nao estiver em execucao (e check-close ativo):
                if (!isMT5XmOn)
                {
                    procMT5Xm = startProcess(config.MT5PathXmglob, true);
                }
            }
            else
            { // Mercado Forex fechado, encerrar MT5 se estiver em execucao:
                if (isMT5XmOn && !config.MT5FlagNotClose)
                {
                    stopProcess(procMT5Xm);
                }
            }
        }

        /// o programa de coleta diario eh executado diariamente, mas apenas uma vez por dia:
        public void checkColethon(DateTime now)
        {
            // se a ultima execucao foi anterior a ontem, entao executa hoje:
            if (config.ColetLastExecute == null || config.ColetLastExecute.Date < now.Date)
            {
                // salva a ultima data de execucao como agora:
                config.ColetLastExecute = now;
                config.Save();

                // executa o batch do colethon:
                startProcess(config.ColetPathProgram, false);
            }
        }

        /// o programa de geracao de palpites eh executado diariamente, mas apenas uma vez por dia:
        public void checkLothon(DateTime now)
        {
            // se a ultima execucao foi anterior a ontem, entao executa hoje:
            if (config.LotoLastExecute == null || config.LotoLastExecute.Date < now.Date)
            {
                // para executar o lothon, eh preciso verificar se o arquivo de sinalizacao existe:
                if (String.IsNullOrWhiteSpace(config.LotoPathSignal) || File.Exists(config.LotoPathSignal))
                {
                    // salva a ultima data de execucao como agora:
                    config.LotoLastExecute = now;
                    config.Save();

                    // executa o batch do lothon:
                    startProcess(config.LotoPathProgram, false);
                }
            }
        }

        /// o programa de analise de dados eh executado diariamente, mas apenas uma vez por dia:
        public void checkQuanthon(DateTime now)
        {
            // se a ultima execucao foi anterior a ontem, entao executa hoje:
            if (config.QuantLastExecute == null || config.QuantLastExecute.Date < now.Date)
            {
                // para executar o quanthon, eh preciso verificar se o arquivo de sinalizacao existe:
                if (String.IsNullOrWhiteSpace(config.QuantPathSignal) || File.Exists(config.QuantPathSignal))
                {
                    // salva a ultima data de execucao como agora:
                    config.QuantLastExecute = now;
                    config.Save();

                    // executa o batch do quanthon:
                    startProcess(config.QuantPathProgram, false);
                }
            }
        }

        public static Process startProcess(String program, bool maxTela)
        {
            // verifica se eh um programa executavel ou batch:
            string extension = Path.GetExtension(program).ToLower();

            if (extension == ".exe" || extension == ".com")
                return runProgram(program, maxTela);
            else
                return runBatch(program, maxTela);
        }

        public static Process runProgram(String program, bool maxTela)
        {
            Process proc = null;
            try
            {
                logger.Debug("Vai executar o programa {}", program);
                ProcessStartInfo startInfo = new ProcessStartInfo(program);
                startInfo.WindowStyle = maxTela ? ProcessWindowStyle.Maximized : ProcessWindowStyle.Minimized;

                proc = Process.Start(startInfo);
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar executar programa {} | Erro: {}", program, e.Message);
            }

            return proc;
        }

        public static Process runBatch(String batch, bool maxTela)
        {
            Process proc = null;
            try
            {
                String file_batch = Path.GetFileName(batch);
                String path_batch = Path.GetDirectoryName(batch);

                logger.Debug("Vai executar o batch {} no diretorio {}...", batch, path_batch);

                var psi = new ProcessStartInfo("cmd.exe", "/C " + file_batch);
                // utilizar este codigo comentado para esconder a janela do batch executando...
                //psi.UseShellExecute = false;
                //psi.CreateNoWindow = true;
                psi.CreateNoWindow = false;
                psi.WorkingDirectory = path_batch;
                psi.WindowStyle = maxTela ? ProcessWindowStyle.Maximized : ProcessWindowStyle.Minimized;

                proc = Process.Start(psi);
                logger.Info("Programa batch {} executado com sucesso.", batch);
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar executar batch {} | Erro: {}", batch, e.Message);
            }

            return proc;
        }

        public static bool stopProcess(Process proc)
        {
            bool result = false;
            try
            {
                logger.Debug("Vai encerrar processo {} | Flag HasExited={}", proc.ProcessName, proc.HasExited);
                if (proc.HasExited)
                {
                    result = true; // indica que o programa foi encerrado (nao importa se foi antes).
                }
                else
                {
                    // inicialmente apenas fecha a janela principal do programa para encerrar seu processo...
                    result = proc.CloseMainWindow();
                    if (!result)  // mas se isso nao encerrar o processo, entao envia Kill() diretamente.
                    {
                        logger.Debug("Processo {} nao encerrou com CloseMainWindow(). Vai executar Kill()...", proc.ProcessName);
                        proc.Kill();
                    }
                }
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar encerrar processo {} | Erro: {}", proc.ProcessName, e.Message);
            }

            return result;
        }

        public static string ListFeriados()
        {
            string listaFeriados = "FERIADOS NACIONAIS (B3):\n";
            foreach ((int dia, int mes) in FERIADOS_BR_B3)
            {
                listaFeriados += "        " + dia.ToString("0#") + " / " + MESES[mes - 1] + "\n";
            }

            listaFeriados += "\nFERIADOS INTERNACIONAIS (FOREX):\n";
            foreach ((int dia, int mes) in FERIADOS_FOREX)
            {
                listaFeriados += "        " + dia.ToString("0#") + " / " + MESES[mes - 1] + "\n";
            }

            return listaFeriados;
        }

        public static void StopAllTaks()
        {
            // identifica os processos de  todas as instancias do MetaTrader e scripts Python:
            Process[] processesMt = Process.GetProcessesByName("terminal64");
            Process[] processesPy = Process.GetProcessesByName("python");
            Process[] processes = processesMt.Concat(processesPy).ToArray();
            logger.Debug("Verificando processos em StopAllTaks() | processes = Process[{}]", processes.Length);

            foreach (Process proc in processes)
            {
                // Alterado para verificar pelo full-path pois o titulo as vezes vem em branco ""...
                string fullPath = proc.MainModule.FileName;
                logger.Debug("Vai finalizar task em execucao: {}", fullPath);
                stopProcess(proc);
            }
        }
    }
}
