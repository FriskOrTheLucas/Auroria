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
        public static string PlayerInfoPath = "PlayerSettings.json";
        public static string HeadColor
        {
            get
            {
                string json = File.ReadAllText(PlayerInfoPath);
                JObject obj = JObject.Parse(json);
                string result = (string)obj["Headcolor"];

                return result;
            }
        }

        public static string LeftArmcolor
        {
            get
            {
                string json = File.ReadAllText(PlayerInfoPath);
                JObject obj = JObject.Parse(json);
                string result = (string)obj["LeftArmcolor"];

                return result;
            }
        }

        public static string LeftLegcolor
        {
            get
            {
                string json = File.ReadAllText(PlayerInfoPath);
                JObject obj = JObject.Parse(json);
                string result = (string)obj["LeftLegcolor"];

                return result;
            }
        }

        public static string RightArmcolor
        {
            get
            {
                string json = File.ReadAllText(PlayerInfoPath);
                JObject obj = JObject.Parse(json);
                string result = (string)obj["RightArmcolor"];

                return result;
            }
        }

        public static string RightLegcolor
        {
            get
            {
                string json = File.ReadAllText(PlayerInfoPath);
                JObject obj = JObject.Parse(json);
                string result = (string)obj["RightLegcolor"];

                return result;
            }
        }

        public static string TorsoColor
        {
            get
            {
                string json = File.ReadAllText(PlayerInfoPath);
                JObject obj = JObject.Parse(json);
                string result = (string)obj["Torsocolor"];

                return result;
            }
        }

        public static string GenerateBodyColorAshxURL
        {
            get
            {
                string result = $"http://www.roblox.com/asset/BodyColors.ashx?userID={HeadColor}-{LeftArmcolor}-{LeftLegcolor}-{RightArmcolor}-{RightLegcolor}-{TorsoColor}";
                return result;
            }
        }

        public static string GenerateCharacterAccesoryURL
        {
            get
            {
                string result = CustomizationHelper.AvatarHat1 + CustomizationHelper.AvatarHat2 + CustomizationHelper.AvatarHat3 + CustomizationHelper.Shirt + CustomizationHelper.Tshirt + CustomizationHelper.Pants;
                if (string.IsNullOrWhiteSpace(result))
                {
                    return "";
                }
                return result;
            }
        }
    }
}
