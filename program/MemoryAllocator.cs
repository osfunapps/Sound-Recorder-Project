using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sound_Recorder_Project.program.tools;
using Sound_Recorder_Project.Properties;

namespace Sound_Recorder_Project
{
    internal class MemoryAllocator
    {
        private string MSG_EMPTY_DIR_DELETE = "- Deleted empty folder: ";
        private string MSG_OLDEST_FILE_DELETE = "- Not room. Deleted oldest file: ";

        /**
         * 1) sort all folders by date
         * 2) sort all files in the oldest folder, by date
         * 3) delete the oldest file
         **/
        public void AllocateMemory()
        {
            string oldestDirectory = RemoveOldestFile();
            if(PathSizeMeasurer.GetPathSize(oldestDirectory) == 0)
            {
                AppCoordinator.RecordLog += MSG_EMPTY_DIR_DELETE + oldestDirectory+"\n\n";
                Directory.Delete(oldestDirectory);
            }
        }

        private string RemoveOldestFile()
        {
            List<DirectoryInfo> dateDirectories = SortDirectoriesByDescending(Settings.Default.recordsPath);
            List<FileInfo> dateRecordedFiles = SortFilesByDescending(dateDirectories[0].FullName);
            AppCoordinator.RecordLog += MSG_OLDEST_FILE_DELETE + dateRecordedFiles[0].FullName + "\n";
            File.Delete(dateRecordedFiles[0].FullName);
            return dateDirectories[0].FullName;
        }

        private List<DirectoryInfo> SortDirectoriesByDescending(string path)
        {
            return new DirectoryInfo(path).GetDirectories()
                .OrderBy(f => f.LastWriteTime)
                .ToList();

        }


        private List<FileInfo> SortFilesByDescending(string path)
        {
            return new DirectoryInfo(path).GetFiles()
                .OrderBy(f => f.LastWriteTime)
                .ToList();
        }

    }
}