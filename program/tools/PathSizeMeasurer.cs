using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sound_Recorder_Project.program.tools
{
    class PathSizeMeasurer
    {
        public static double GetPathSize(string path)
        {
            long calculatedBytes = CalculateSizeRecursively(path);
            size = 0;
            return BytesToMb(calculatedBytes);

        }

        private static long size = 0;

        private static long CalculateSizeRecursively(string directory)
        {
            foreach (string dir in Directory.GetDirectories(directory))
            {
                CalculateSizeRecursively(dir);
            }

            foreach (FileInfo file in new DirectoryInfo(directory).GetFiles())
            {
                size += file.Length;
            }

            return size;
        }

        static double BytesToMb(long bytes)
        {
            return ((bytes / 1024f) / 1024f);
        }

    }
}
