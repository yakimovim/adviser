using System;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Repository;
using Microsoft.VisualBasic.ApplicationServices;

namespace EdlinSoftware.Adviser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RunApplication();
        }

        private static void RunApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new SingleInstanceController();
            controller.Run(Environment.GetCommandLineArgs());
        }
    }

    /// <summary>
    /// Represents controller of single instance of the application.
    /// </summary>
    internal class SingleInstanceController : WindowsFormsApplicationBase
    {
        public SingleInstanceController()
        {
            IsSingleInstance = true;

            StartupNextInstance += OnStartupNextInstance;
        }

        private void OnStartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            var form = (AdviserMainForm)MainForm;
            form.RestoreWindow();
        }

        protected override void OnCreateMainForm()
        {
            MainForm = new AdviserMainForm();
        }

        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
            AdviserStorage.Current = new AdviserStorage();

            return base.OnStartup(eventArgs);
        }

        protected override void OnShutdown()
        {
            base.OnShutdown();

            if (AdviserStorage.Current != null)
            {
                AdviserStorage.Current.Dispose();
            }
        }
    }
}