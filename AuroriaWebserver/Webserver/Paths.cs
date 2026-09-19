using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AuroriaResources;

namespace AuroriaWebserver.Webserver
{
    public static class Paths
    {
        private static string _joinscrpt;
        private static string _hostscrpt;
        private static string _gameservcrpt;
        private static string Client => PathHelper.GetClient;

        public static string Join => _joinscrpt ?? (_joinscrpt = Path.Combine("Clients\\" + Client + "\\Scripts", "join.lua"));
        public static string HostScript => _hostscrpt ?? (_hostscrpt = Path.Combine("Clients\\" + Client + "\\Scripts", "host.lua"));
        public static string GameSer => _gameservcrpt ?? (_gameservcrpt = Path.Combine("Clients\\" + Client + "\\Scripts", "gameserver.lua"));
    }
}
