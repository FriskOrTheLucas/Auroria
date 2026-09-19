using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AuroriaResources
{
    public static class PathHelper
    {
        public static string InfoFilePath = "PlayerSettings.json";

        public static string GetClient
        {
            get
            {
                string json = File.ReadAllText(InfoFilePath);
                JObject obj = JObject.Parse(json);

                string client = (string)obj["Client"];
                return client;
            }
        }
    }
}
