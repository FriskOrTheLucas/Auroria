using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Auroria.NT
{
    class Apache
    {
        private static Process apacheProcess;

        public static string apachewebdir = Directory.GetCurrentDirectory() + @"\webserver\bin";
        public static string serverroot = Directory.GetCurrentDirectory() + @"\webserver\";
        public static string httpdconf = Directory.GetCurrentDirectory() + @"\webserver\conf\httpd.conf";
        public static string phproot = Directory.GetCurrentDirectory() + @"\php\winphp\";
        public static string phpdll = Directory.GetCurrentDirectory() + @"\php\winphp\php5apache2_4.dll";
        public static string httpdtemplate = Directory.GetCurrentDirectory() + @"\template\httpd.template.txt";

        public static void Install()
        {
            Process.Start("CMD.exe", "/c cd /d \"" + apachewebdir + "\" && httpd -k install");
        }

        public static void StartService()
        {
            ProcessStartInfo StartInfo = new ProcessStartInfo();

            StartInfo.FileName = Path.Combine(apachewebdir, "httpd.exe");
            StartInfo.WorkingDirectory = apachewebdir;
            StartInfo.CreateNoWindow = true;
            StartInfo.UseShellExecute = false;

            apacheProcess = Process.Start(StartInfo);
        }

        public static void StopService()
        {
            if (apacheProcess != null && !apacheProcess.HasExited)
            {
                apacheProcess.Kill();
                apacheProcess = null;
            }
        }

        public static void WriteHTTPDconf()
        {
            string ReadText = File.ReadAllText(httpdtemplate);
            string ApacheRoot = serverroot.Replace("\\", "/");
            string PHPRoot = phproot.Replace("\\", "/");
            string PHPDll = phpdll.Replace("\\", "/");
            ReadText = ReadText.Replace("%SRVROOT%", ApacheRoot);
            ReadText = ReadText.Replace("%PHPDIR%", PHPRoot);
            ReadText = ReadText.Replace("%PHPmodDir%", PHPDll);
            File.WriteAllText(httpdconf, ReadText);
        }
    }
}