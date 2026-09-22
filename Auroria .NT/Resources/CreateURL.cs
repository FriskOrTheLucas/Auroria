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
            string url = "http://rbxweb.lol/game/gameserver.ashx?port=" + port;
            return url;

        }
    }
}
