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
                "127.0.0.1\trbxweb.lol",
                "127.0.0.1\twww.rbxweb.lol",
                "127.0.0.1\tapi.rbxweb.lol",
                "127.0.0.1\tversioncompatibility.api.rbxweb.lol",
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
                    .Where(line => line.IndexOf("rbxweb.lol", StringComparison.OrdinalIgnoreCase) < 0)
                    .ToList();

                File.WriteAllLines(HostFile, newLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured with the remove hosts: {ex.Message}");
            }
        }
    }
}
