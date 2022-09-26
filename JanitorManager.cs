using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using NLog;

namespace Janitor
{
    public class JanitorManager
    {
        // referencia ao logger do NLog para toda a classe:
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        // referencia ao icone na sys-tray:
        private readonly NotifyIcon notifyIcon;

        public JanitorManager(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
        }

    }
}
