using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace RGBuilder_Launcher_Csharp
{
    class Variables
    {
        public static string LocalPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)+"\\"; //path to launcher
        public static string CPUkey;
        public static string NandPath;
        //public static string HackType;
       // public static string Kernel;
    }
}
