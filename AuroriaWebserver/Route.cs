using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AuroriaWebserver.Mains;

namespace AuroriaWebserver
{
    internal class Route
    {
        public static void HandleRequest(HttpListenerContext context)
        {
            string AbsolutePath = context.Request.Url.AbsolutePath.ToLower();
            // I know thats kinda useless right now but that make the code looks more clean
            // -creds to rickkkkk for making this -Lucas

            if (AbsolutePath.Equals("/game/join.ashx"))
            {
                ScriptsHandler.HandleJoin(context);
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                context.Response.Close();
            }

            else if (AbsolutePath.Equals("/asset/"))
            {
                AssetDelivery.HandleDelivery(context);
            }
        }
    }
}