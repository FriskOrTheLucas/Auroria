using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AuroriaWebserver.Mains;
using AuroriaWebserver.IDE;
using AuroriaWebserver.staticHTML;

namespace AuroriaWebserver
{
    internal class Route
    {
        public static void HandleRequest(HttpListenerContext context)
        {
            string AbsolutePath = context.Request.Url.AbsolutePath.ToLower();
            // I know thats kinda useless right now but that make the code looks more clean
            // -creds to rickkkkk for making this -Lucas
            Console.WriteLine($"Request: {AbsolutePath}");

            if (AbsolutePath.Equals("/game/join.ashx"))
            {
                ScriptsHandler.HandleJoin(context);
            }

            if (AbsolutePath.Equals("/ide/clienttoolbox.aspx"))
            {
                Console.WriteLine("Toolbox request sent");
                Toolbox.HandleToolbox(context);
            }

            if (AbsolutePath.Equals("/ide/landing.aspx") || AbsolutePath.Equals("/ide/start.aspx"))
            {
                Console.WriteLine("Landing Request sent");
                Landing.HandleLanding(context);
            }

            if (AbsolutePath.Equals("/staticassets/auroria.png"))
            {
                Console.WriteLine("Logo request Sent");
                StaticAssetsHandler.logo(context);
            }

            if (AbsolutePath.Equals("/game/gameserver.ashx"))
            {
                ScriptsHandler.HandleGameserver(context);
            }

            if (AbsolutePath.Equals("/asset/bodycolors.ashx"))
            {
                BodyColor.DoThing(context);
            }

            if (AbsolutePath.Equals("/asset/")) 
            {
                AssetDelivery.HandleDelivery(context);
            }
        }
    }
}