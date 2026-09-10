using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Auroria.NT
{
    class hostsfile
    {
        public static string HostFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

        public static void WriteHosts()
        {
            string[] entries =
            {
                "",
                "127.0.0.1\troblox.com",
                "127.0.0.1\twww.roblox.com",
                "127.0.0.1\tapi.roblox.com",
                "127.0.0.1\tversioncompatibility.api.roblox.com",
            };

            try
            {
                File.AppendAllLines(HostFile, entries);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing hosts: {ex.Message}");
            }
        }

        public static void RemoveHosts()
        {
            try
            {
                if (!File.Exists(HostFile)) return;

                string[] lines = File.ReadAllLines(HostFile);

                var newLines = lines
                    .Where(line => line.IndexOf("roblox.com", StringComparison.OrdinalIgnoreCase) < 0)
                    .ToList();

                File.WriteAllLines(HostFile, newLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing hosts on close: {ex.Message}");
            }
        }
    }
}
