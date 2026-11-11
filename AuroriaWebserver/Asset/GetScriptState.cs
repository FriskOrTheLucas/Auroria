using AuroriaResources.Signing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace AuroriaWebserver.Asset
{
    internal static class GetScriptState
    {
        public static void DoThing(HttpListenerContext context)
        {
            HttpListenerResponse response = context.Response;
            string responseString = "0 0 0 0";

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
            response.Close();
        }
    }
}
