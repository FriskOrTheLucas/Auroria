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

        public static bool GetBool(string value)
        {
            string settingsjson = File.ReadAllText("PlayerSettings.json");
            JObject obj = JObject.Parse(settingsjson);
            bool response = (bool)obj[value];

            return response;
        }

        public static bool ShowWebserver => GetBool("ShowWebserver");
        public static string ServerAddress => GetInfo("ServerIP");
        public static string Name => GetInfo("PlayerName");
        public static string ID => GetInfo("UserID");
        public static string AssetURL => GetInfo("AssetURL");
        public static string GetMap => GetInfo("CurrentMap");
        public static string GetHat1 => GetInfo("HatSlot1");
        public static string GetHat2 => GetInfo("HatSlot2");
        public static string GetHat3 => GetInfo("HatSlot3");
        public static string GetHead => GetInfo("Head"); //ayo
        public static string GetFace => GetInfo("Face");
        public static string GetShirt => GetInfo("Shirt");
        public static string GetPants => GetInfo("Pants");
        public static string GetPackage => GetInfo("Package");
    }
}
