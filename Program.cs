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
using System.Diagnostics;

namespace Sound_Recorder_Project
{
    static class Program
    {
        private static RecordingForm recordingForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String thisprocessname = Process.GetCurrentProcess().ProcessName;
        if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            return;

            //visualize stuff
            Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);

            KeyboardActionListener keyboardActionListener = new KeyboardActionListener();

            Task t = Task.Run(() =>
            {
                keyboardActionListener.RunHook();
            });

            AppCoordinator appCoordinator = new AppCoordinator();
              appCoordinator.PrepareCoordination();


            ///run action listener
            /*ActionListener actionListener = new ActionListener();
            actionListener.ListinToUserCommands();

            KeyboardIntercepter.Hook();
            */



        }
    }
}
