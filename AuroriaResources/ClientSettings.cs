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

        public static string Description
        {
            get { string result = GetInfo("Description"); return result; }
        }

        public class Player
        {
            public static string Directory
            {
                get { string result = GetNestedInfo("Player", "Directory"); return result; }
            }
            public static string Client
            {
                get { string result = GetNestedInfo("Player", "Name"); return result; }
            }
            public static string Arguments
            {
                get { string result = GetNestedInfo("Player", "Arguments"); return result; }
            }
        }

        public class Host
        {
            public static string Directory
            {
                get { string result = GetNestedInfo("Host", "Directory"); return result; }
            }
            public static string Client
            {
                get { string result = GetNestedInfo("Host", "Name"); return result; }
            }
            public static string Arguments
            {
                get { string result = GetNestedInfo("Host", "Arguments"); return result; }
            }
        }

        public class Studio
        {
            public static string Directory
            {
                get { string result = GetNestedInfo("Studio", "Directory"); return result; }
            }
            public static string Client
            {
                get { string result = GetNestedInfo("Studio", "Name"); return result; }
            }
            public static string Arguments
            {
                get { string result = GetNestedInfo("Studio", "Arguments"); return result; }
            }
        }
    }
}
