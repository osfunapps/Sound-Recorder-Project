using System;
using System.Globalization;
using System.IO;
using System.Linq;
using Sound_Recorder_Project.Properties;

namespace Sound_Recorder_Project
{
    internal class DateFolderCreator
    {
        private string MSG_NEW_FOLDER = "- New folder created in: ";

        internal string CreateDateFolder()
        {
            string nonUtcDate = DateTime.Now.ToShortDateString().Replace('/', '.');
            int monthEnd = nonUtcDate.IndexOf('.');
            int dayEnd = nonUtcDate.IndexOf('.', monthEnd + 1);
            string month = nonUtcDate.Substring(0, monthEnd);
            string day = nonUtcDate.Substring(monthEnd+1, dayEnd-monthEnd-1);

            string todaysDate = day + "." + month + "."+nonUtcDate.Substring(dayEnd + 1);

            bool folderExist = false;
            string newFoldersPath = Settings.Default.recordsPath + "\\" + todaysDate;
            foreach (string currDir in Directory.GetDirectories(Settings.Default.recordsPath))
            {
                if (currDir.Equals(newFoldersPath))
                    return todaysDate;
            }

            Directory.CreateDirectory(newFoldersPath);
            AppCoordinator.RecordLog += MSG_NEW_FOLDER + newFoldersPath + "\n";
            return todaysDate;

        }
    }
}