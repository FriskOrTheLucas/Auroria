using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Auroria.NT.Resources;

namespace AuroriaWebserver.Webserver
{
    public static class Paths
    {
        private static string _joinscrpt;
        private static string _hostscrpt;
        private static string Client => PathHelper.Client;

        public static string Join => _joinscrpt ?? (_joinscrpt = Path.Combine("Scripts", "join.lua"));
        public static string HostScript => _hostscrpt ?? (_hostscrpt = Path.Combine("Scripts", "host.lua"));
    }
}
