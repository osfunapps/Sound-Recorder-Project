using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.project;
using Sound_Recorder_Project.program;
using Sound_Recorder_Project.program.tools;
using Sound_Recorder_Project.Properties;

namespace Sound_Recorder_Project
{
    internal class AppCoordinator : SoundManager.RecordCallback
    {

        //instances
        private MemoryAllocator memoryAllocator;
        private SoundManager soundManager;
        private DateFolderCreator dateFolderCreatoer;

        //strings
        public static string LOG_TITLE = "Record log";

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

        public static string RecordLog { get; set; }
    }
}