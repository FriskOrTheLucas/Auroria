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
            if (context.Request.Url.AbsolutePath == "/Game/Join.ashx" || context.Request.Url.AbsolutePath == "/game/join.ashx")
            {
                ScriptsHandler.HandleJoin(context);
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                context.Response.Close();
            }

            else if (context.Request.Url.AbsolutePath == "/asset/")
            {
                AssetDelivery.HandleDelivery(context);
            }
        }
    }
}
