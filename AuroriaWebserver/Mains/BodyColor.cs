using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace AuroriaWebserver.Mains
{
    public static class BodyColor
    {
        private static string[] bodycolors = new string[]
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
