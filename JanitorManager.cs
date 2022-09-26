using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using NLog;


namespace Janitor
{
    public class JanitorManager
    {
        // referencia ao logger do NLog para toda a classe:
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        // objeto timer para disparo de eventos e execucao de tarefas:
        private static System.Timers.Timer sTimer;

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

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime agora = DateTime.Now;

            // a cada minuto, executa o scheduler:
            if (agora.Second == 0)
            {
                // checkScheduler();
            }

            // se for 12:00:00, acerta o relogio (ao menos 1x por dia):
            if (agora.Second == 0 && agora.Minute == 0 && agora.Hour == 12)
            {
                Program.ResyncSystemTime();
            }
        }

        /*** SERVICO DE MONITORAMENTO DOS APLICATIVOS ***/

        /*** COTACOES DO FOREX INTERROMPIDAS PARA MEDIR CHECK DA PERFORMANCE DAS COTACOES DE MINI CONTRATOS ***/
        static readonly String MT5_XM = @"C:\Apps\B3\XM Global MT5\terminal64.exe";
        static readonly String MT5_MODAL = @"C:\Apps\B3\ModalMais MetaTrader 5\terminal64.exe";
        static readonly String MT5_GENIAL = @"C:\Apps\B3\MetaTrader 5\terminal64.exe";
        // TODO static readonly String TRYD_MODAL = @"C:\Apps\B3\Tryd6\trader.exe";
        static readonly String PYTHON_INFINITE = @"C:\Apps\B3\InFiniTe\bin\startup.bat";

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

        public void checkScheduler()
        {
            bool isMT5XmOn = false;
            Process procMT5Xm = null;

            bool isMT5ModalOn = false;
            Process procMT5Modal = null;

            bool isMT5GenialOn = false;
            Process procMT5Genial = null;

            //bool isTrydModalOn = false;
            //Process procTrydModal = null;

            bool isPythonOn = false;
            Process procPython = null;

            // busca o estado das instancias do MetaTrader (corretoras) em execucao:
            Process[] processes = Process.GetProcessesByName("terminal64");
            logger.Debug("Verificando processos em checkScheduler() | processes = Process[{}]", processes.Length);
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

            // busca o estado das instancias do Tryd (modalmais) em execucao:
            //processes = Process.GetProcessesByName("trader");
            //foreach (Process proc in processes)
            //{
            //    String title = proc.MainWindowTitle.ToUpper();
            //    if (title.Contains("TRYD"))
            //    {
            //        procPython = proc;
            //        isTrydModalOn = true;
            //    }
            //}

            // busca o estado das instancias do Python (scripts) em execucao:
            processes = Process.GetProcessesByName("python");
            if (processes.Any())
            { // referencia o primeiro script python em execucao:
                procPython = processes[0];
                isPythonOn = true;
            }
            logger.Debug("Verificando processos em checkScheduler() | isMT5GenialOn={} | isMT5ModalOn={} | isMT5XmOn={} | isPythonOn={}", isMT5GenialOn, isMT5ModalOn, isMT5XmOn, isPythonOn);

            // identifica o dia corrente para verificar os mercados:
            bool isB3Open = false,
                 isFeriadoB3 = false;
            bool isForexOpen = false,
                 isFeriadoForex = false;
            bool isInfiniteOk = false;
            DateTime now = DateTime.Now;
            int dia = now.Day,
                mes = now.Month,
                hor = now.Hour,
                min = now.Minute;
            DayOfWeek dow = now.DayOfWeek;

            // verifica se o dia corrente eh feriado no mercado forex e no mercado b3:
            foreach ((int dia, int mes) feriado in FERIADOS_FOREX)
            {
                if (dia == feriado.dia && mes == feriado.mes)
                {
                    isFeriadoForex = true;
                }
            }
            foreach ((int dia, int mes) feriado in FERIADOS_BR_B3)
            {
                if (dia == feriado.dia && mes == feriado.mes)
                {
                    isFeriadoB3 = true;
                }
            }

            // verifica se os mercados estao abertos ou fechados:
            switch (dow)
            {
                case DayOfWeek.Monday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 40) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 10));
                    isInfiniteOk = (hor >= 4 && hor <= 7) || (hor == 8 && min < 40);
                    break;
                case DayOfWeek.Tuesday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 40) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 10));
                    isInfiniteOk = (hor >= 4 && hor <= 7) || (hor == 8 && min < 40);
                    break;
                case DayOfWeek.Wednesday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 40) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 10));
                    isInfiniteOk = (hor >= 4 && hor <= 7) || (hor == 8 && min < 40);
                    break;
                case DayOfWeek.Thursday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 40) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 10));
                    isInfiniteOk = (hor >= 4 && hor <= 7) || (hor == 8 && min < 40);
                    break;
                case DayOfWeek.Friday:
                    isForexOpen = !isFeriadoForex && (hor < 19);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 40) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 10));
                    isInfiniteOk = (hor >= 4 && hor <= 7) || (hor == 8 && min < 40);
                    break;
                case DayOfWeek.Saturday:
                    isForexOpen = false;
                    isB3Open = false;
                    isInfiniteOk = (hor >= 4 && hor <= 8);
                    break;
                case DayOfWeek.Sunday:
                    isForexOpen = !isFeriadoForex && (hor >= 18);
                    isB3Open = false;
                    // eh necessario executar para ao menos baixar os sorteios do sabado
                    isInfiniteOk = (hor >= 4 && hor <= 8);
                    break;
            }
            logger.Debug("Verificando calendario em checkScheduler() | isFeriadoForex={} | isForexOpen={} | isFeriadoB3={} | isB3Open={} | isInfiniteOk={}", isFeriadoForex, isForexOpen, isFeriadoB3, isB3Open, isInfiniteOk);

            // ativacao ou suspensao do MT para Genial e ModalMais (B3):
            if (isB3Open)
            { // Bolsa do brasil aberta, executar MT5 e TRYD se nao estiverem em execucao:
                if (!isMT5GenialOn)
                {
                    procMT5Genial = openProgram(MT5_GENIAL);
                }
                if (!isMT5ModalOn)
                {
                    procMT5Modal = openProgram(MT5_MODAL);
                }
                //if (!isTrydModalOn)
                //{
                //    // TODO procTrydModal = Process.Start(TRYD_MODAL);
                //}
            }
            else
            { // Bolsa do brasil fechada, encerrar MT5 e TRYD se estiverem em execucao (e check-close ativo):
                if (isMT5GenialOn && ! Properties.Settings.Default.GeralFlagNotClose)
                {
                    closeProgram(procMT5Genial);
                }
                if (isMT5ModalOn && ! Properties.Settings.Default.GeralFlagNotClose)
                {
                    closeProgram(procMT5Modal);
                }
                //if (isTrydModalOn && ckbClose.Checked)
                //{
                //    // TODO closeProgram(procTrydModal);
                //}
            }

            // ativacao ou suspensao do MT para XM (Forex):
            if (isForexOpen)
            { // Mercado Forex aberto, executar MT5 se nao estiver em execucao (e check-close ativo):
                if (!isMT5XmOn)
                {
                    procMT5Xm = openProgram(MT5_XM);
                }
            }
            else
            { // Mercado Forex fechado, encerrar MT5 se estiver em execucao:
                if (isMT5XmOn && ! Properties.Settings.Default.GeralFlagNotClose)
                {
                    closeProgram(procMT5Xm);
                }
            }

            // ativacao ou suspensao do Infinite em Python (scripts):
            if (isInfiniteOk)
            { // Mercados estao fechados, pode executar scripts python de manutencao se ja nao estiverem executando:
                if (!isPythonOn)
                {
                    procPython = openBatch(PYTHON_INFINITE);
                }
            }
            else
            { // Mercados estao abertos, evita executar os scripts de manutencao
              // para nao sobrecarregar o computador e consumir muitos recursos:
                if (isPythonOn && ! Properties.Settings.Default.GeralFlagNotClose)
                {
                    closeProgram(procPython);
                }
            }
        }

        private static Process openProgram(String program)
        {
            Process proc = null;
            try
            {
                logger.Debug("Vai executar o programa {}", program);
                ProcessStartInfo startInfo = new ProcessStartInfo(program);
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;

                proc = Process.Start(startInfo);
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar executar programa {} | Erro: {}", program, e.Message);
            }

            return proc;
        }

        private static bool closeProgram(Process proc)
        {
            bool result = false;
            try
            {
                logger.Debug("Vai encerrar processo {} | Flag HasExited={}", proc.ProcessName, proc.HasExited);
                if (proc == null || proc.HasExited)
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

        private static Process openBatch(String batch)
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
                psi.WindowStyle = ProcessWindowStyle.Minimized;

                proc = Process.Start(psi);
                logger.Info("Programa batch {} executado com sucesso.", batch);
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar executar batch {} | Erro: {}", batch, e.Message);
            }

            return proc;
        }

    }
}
