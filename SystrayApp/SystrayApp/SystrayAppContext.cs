using System;
using System.Windows.Forms;
using log4net;

namespace PhilipTenn.SystrayApp
{
    /// <summary>
    /// Custom Application Context for the sample Systray Application.
    /// </summary>
    public class SystrayAppContext : ApplicationContext
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SystrayAppContext));

        /// <summary>
        /// The NotifyIcon property is the entry point for the Systray application.
        /// </summary>
        public NotifyIcon NotifyIcon { get; set; }

        /// <summary>
        /// Default constructor, will instantiate and configure the NotifyIcon.
        /// </summary>
        public SystrayAppContext()
        {
            NotifyIcon = new NotifyIcon
            {
                Text = Properties.Resources.IconText,
                Icon = Properties.Resources.PlayIcon,
                ContextMenu = new ContextMenu(new []
                {
                    new MenuItem("Open", OpenHandler),
                    new MenuItem("Exit", ExitHandler)
                }),
                Visible = true
            };
        }

        /// <summary>
        /// OpenHandler delegate.  Will handle opening the Application from the System Tray.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OpenHandler(object sender, EventArgs e)
        {
            logger.Info("Open Executed");
        }


        /// <summary>
        /// ExitHandler delegate.  Will handle exiting the Application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExitHandler(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            NotifyIcon.Visible = false;

            Application.Exit();
        }
    }
}