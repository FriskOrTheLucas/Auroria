using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auroria.NT.Resources
{
    internal class CreateURL
    {
        public static string CreateGameServURL(ushort port)
        {
            string url = "http://www.roblox.com/game/gameserver.ashx?port=" + port;
            return url;
        }

        public static string CreateJoinUrl(string IP, string port, string username, string ID)
        {
            string url = $"http://www.roblox.com/game/join.ashx?serverIP={IP}&serverPort={port}&userName={username}&userID={ID}";
            return url;
        }
    }
}
