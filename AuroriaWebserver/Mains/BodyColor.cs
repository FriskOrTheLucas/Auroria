using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace AuroriaWebserver.Mains
{
    public static class BodyColor
    {
        static string InfoFilePath = "PlayerSettings.json";

        private static string[] bodycolors = new string[6]
        {   "Head",
            "LeftArm",
            "LeftLeg",
            "RightArm",
            "RightLeg",
            "Torso"
        };

        public static void DoThing(HttpListenerContext context) // im sorry i couldnt come up with a better name
        {

        }
    }
}
