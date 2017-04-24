using System;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using PhilipTenn.SystrayApp;

namespace SystrayApp
{
    static class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XmlConfigurator.Configure();
            logger.Info("Begin execution of Program");
            Application.Run(new SystrayAppContext());
        }
    }
}
