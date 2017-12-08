using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.project
{
    internal class Logger
    {
        internal static string TITLE = "program log";

        internal static string GetTxt()
        {
            return "Version 1.1" +
                   "\n- added ear on task tray" +
                   "\n- added ear menu items: file path, task scheduler and exit" +
                   "\n- added a fix so the app will not run again and again after each entry" +
                   "\n\nVersion 1.0 - launch";
        }
    }
}
