using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AuroriaResources
{
    public static class PlayerSettings
    {
        public static string GetInfo(string value)
        {
            string settingsjson = File.ReadAllText("PlayerSettings.json");
            JObject obj = JObject.Parse(settingsjson);
            string response = (string)obj[value];

            return response;
        }

        public static string ServerAddress => GetInfo("ServerIP");

        public static string Name => GetInfo("PlayerName");

        public static string ID => GetInfo("UserID");

        public static string AssetURL => GetInfo("AssetURL");

        public static string GetMap => GetInfo("CurrentMap");
    }
}
