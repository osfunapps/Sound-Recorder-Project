using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Sound_Recorder_Project;

namespace Sound_Recorder_Project.program.tools

{
    class MyUtils
    {
        private static RecordingForm settingsForm;

        public static void ShowSettingsForm()
        {
            if (settingsForm != null && settingsForm.Visible) return;
            Thread mySTAThread = new Thread(new ThreadStart(ShowFormUI));
            try
            {
                mySTAThread.SetApartmentState(ApartmentState.STA);
            }
            catch (ThreadStateException ex)
            {
                MessageBox.Show("STA Failed", ex.Message);
            }
            mySTAThread.Start();

        }

        private static void ShowFormUI()
        {
            settingsForm = new RecordingForm();
            settingsForm.ShowDialog();
        }

        public static void ExitProgram()
        {
            Application.Exit();
            Environment.Exit(0);
        }

        internal static void RunOnStartup(bool run)
        {
            string appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (run)
                rk.SetValue(appName, Application.ExecutablePath.ToString());
            else
                rk.DeleteValue(appName, false);

        }
    }
}
