using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AuroriaResources
{
    public static class ClientSettings
    {
        public static string Client
        {
            get
            {
                string json = File.ReadAllText("PlayerSettings.json");
                JObject obj = JObject.Parse(json);
                string client = (string)obj["Client"];

                if (string.IsNullOrWhiteSpace(client))
                {
                    throw new Exception("client is null or empty.");
                }

                return client;
            }
        }

        public static string thumbnail => Path.Combine("Clients", Client, "thumbnail.png");
        public static string config => Path.Combine("Clients", Client, "ClientInfo.json");
        public static string scripts => Path.Combine("Clients", Client, "Scripts");
        public static string JoinScript => Path.Combine("Clients", Client, "Scripts", "join.lua");
        public static string GameserverScript => Path.Combine("Clients", Client, "Scripts", "gameserver.lua");
        public static string VisitScript => Path.Combine("Clients", Client, "Scripts", "visit.lua");

        public static string GetInfo(string info)
        {
            string settingsjson = File.ReadAllText(config);
            JObject obj = JObject.Parse(settingsjson);
            string response = (string)obj[info];
            return response;
        }

        public static string GetNestedInfo(string parent, string child)
        {
            string settingsjson = File.ReadAllText(config);
            JObject obj = JObject.Parse(settingsjson);
            string response = (string)obj[parent]?[child];
            return response;
        }

        public static bool GetNestedBool(string parent, string child)
        {
            string settingsjson = File.ReadAllText(config);
            JObject obj = JObject.Parse(settingsjson);
            bool response = (bool)obj[parent]?[child];
            return response;
        }

        public static string Description => GetInfo("Description");

        // made code like a million times more readable 
        public class Player
        {
            public static string Directory => GetNestedInfo("Player", "Directory");
            public static string Client => GetNestedInfo("Player", "Name");
            public static string Arguments => GetNestedInfo("Player", "Arguments");
        }

        public class Host
        {
            public static string Directory => GetNestedInfo("Host", "Directory");
            public static string Client => GetNestedInfo("Host", "Name");
            public static string Arguments => GetNestedInfo("Host", "Arguments");
        }

        public class Studio
        {
            public static string Directory => GetNestedInfo("Studio", "Directory");
            public static string Client => GetNestedInfo("Studio", "Name");
            public static string Arguments => GetNestedInfo("Studio", "Arguments");
        }

        public class Appearance
        {
            public static bool SupportsAccesory => GetNestedBool("Appearance", "Accesory");
            public static bool SupportsFace => GetNestedBool("Appearance", "Face");
            public static bool SupportsHeads => GetNestedBool("Appearance", "Heads");
            public static bool SupportsShirts => GetNestedBool("Appearance", "Shirts");
            public static bool SupportsPants => GetNestedBool("Appearance", "Pants");
            public static bool SupportsPackages => GetNestedBool("Appearance", "Packages");
        }
    }
}
