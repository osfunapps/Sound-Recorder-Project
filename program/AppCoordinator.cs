using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.project;
using Sound_Recorder_Project.program;
using Sound_Recorder_Project.program.tools;
using Sound_Recorder_Project.Properties;

namespace Sound_Recorder_Project
{
    internal class AppCoordinator : SoundManager.RecordCallback, ITrayCallback
    {

        //instances
        private MemoryAllocator memoryAllocator;
        private SoundManager soundManager;
        private DateFolderCreator dateFolderCreatoer;
        private TrayManager _trayManager;

        //strings
        public static string LOG_TITLE = "Record log";
        public static string RecordLog { get; set; }

        public AppCoordinator()
        {
            this.memoryAllocator = new MemoryAllocator();
            this.dateFolderCreatoer = new DateFolderCreator();
            this.soundManager = new SoundManager(this);
        }


        public void Coordinate()
        {

            if (Settings.Default.recordsPath.Equals(""))
            {
                MyUtils.ShowSettingsForm();
                return;
            }

            var myThread = new Thread(delegate ()
            {
                _trayManager = new TrayManager(this);
                _trayManager.CreateNotifyicon(null);

                Application.Run();
            });

            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();

            HandleUnExistsRecordsDir();
            double recordsDir = PathSizeMeasurer.GetPathSize(Settings.Default.recordsPath);
            if (recordsDir > Settings.Default.memoryAllocation)
                memoryAllocator.AllocateMemory();

            string todaysDate = dateFolderCreatoer.CreateDateFolder();
            soundManager.StartRecording(Settings.Default.recordsPath + "\\" + todaysDate);
        }

        private void HandleUnExistsRecordsDir()
        {
            if (!Directory.Exists(Settings.Default.recordsPath))
                Directory.CreateDirectory(Settings.Default.recordsPath);
        }

        public void onRecordFinish()
        {
            Coordinate();
        }

        //tray methods
        public void OnExitClicked()
        {
            MyUtils.ExitProgram();
        }

        public void OnShowClicked()
        {
            MyUtils.ShowSettingsForm();
        }

        public void OnGoToPathClicked()
        {
            String moshe = @Directory.GetCurrentDirectory();
            Process.Start(moshe);
        }

        public void OnSettingsClicked()
        {
            MyUtils.ShowSettingsForm();
        }
    }
}