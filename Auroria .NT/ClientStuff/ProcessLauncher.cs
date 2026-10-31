using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Auroria.NT.Resources;
using AuroriaResources;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auroria.NT.ClientStuff
{
    internal static class ProcessLauncher
    {
        public static void LaunchClient(ProcessTypes LaunchType)
        {
            if (LaunchType == ProcessTypes.Play)
            {
                if (string.IsNullOrWhiteSpace(ClientSettings.Client))
                {
                    MessageBox.Show("Error: No Client Selected.");
                    return;
                }

                if (string.IsNullOrEmpty(ClientSettings.Player.Client))
                {
                    MessageBox.Show("The selected client does not have a player.");
                    return;
                }

                string text1 = Path.Combine(Directory.GetCurrentDirectory(), "Clients", ClientSettings.Client);
                string text2 = Path.Combine(text1, ClientSettings.Player.Directory);
                if (!Directory.Exists(text2))
                {
                    MessageBox.Show($"Failed to get client player folder {text2}, Directory does not exist.");
                }
                string fullclientdir = Path.Combine(text2, ClientSettings.Player.Client);
                if (!File.Exists(fullclientdir))
                {
                    MessageBox.Show($"Failed to get client executable {fullclientdir}, Directory does not exist.");
                }

                string IpAndPort = PlayerSettings.ServerAddress;
                string[] parts = IpAndPort.Split(':');
                string serverip = parts[0];
                string serverport = parts[1];

                string args = CreateURL.CreateJoinUrl(serverip, serverport, PlayerSettings.Name, PlayerSettings.ID);

                try
                {
                    Process LaunchedProcess = new Process();
                    LaunchedProcess.StartInfo.FileName = fullclientdir;
                    LaunchedProcess.StartInfo.WorkingDirectory = text2;
                    LaunchedProcess.StartInfo.Arguments = string.Format(ClientSettings.Player.Arguments, args);
                    LaunchedProcess.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to launch client, error: {ex}");
                }
            }

            if (LaunchType == ProcessTypes.Host)
            {

            }

            if (LaunchType != ProcessTypes.Studio)
            {

            }
        }
    }
}
