using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Auroria.NT
{
    public static class Webserver
    {
        static Process WebserverProcess;

        public static void StartWebserver()
        {
            ProcessStartInfo StartInfo = new ProcessStartInfo();

            StartInfo.FileName = Path.Combine("AuroriaWebserver.exe");
            StartInfo.UseShellExecute = true;
            StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            WebserverProcess = Process.Start(StartInfo);
        }

        public static void StopWebserver()
        {
            if (WebserverProcess != null && !WebserverProcess.HasExited)
            {
                WebserverProcess.Kill();
                WebserverProcess = null;
            }
        }
    }
}
