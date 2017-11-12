using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using WindowsFormsApp1.project;
using Sound_Recorder_Project.program;
using Sound_Recorder_Project.program.tools;
using Sound_Recorder_Project.program.tools.keyboardhook;

namespace Sound_Recorder_Project
{
    static class Program
    {
        private static RecordingForm recordingForm;
        private static string INITIATED = "program initiated :)\n";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
              MessageBox.Show(INITIATED, Logger.TITLE);
              AppCoordinator.RecordLog += INITIATED;

              //visualize stuff
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);

            KeyboardActionListener keyboardActionListener = new KeyboardActionListener();

            Task t = Task.Run(() =>
            {
                keyboardActionListener.RunHook();
            });

            AppCoordinator appCoordinator = new AppCoordinator();
              appCoordinator.Coordinate();
      

            ///run action listener
            /*ActionListener actionListener = new ActionListener();
            actionListener.ListinToUserCommands();

            KeyboardIntercepter.Hook();
            */

            

        }
    }
}