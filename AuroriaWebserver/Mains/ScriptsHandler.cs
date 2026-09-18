using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AuroriaWebserver.Webserver;

namespace AuroriaWebserver.Mains
{
    public static class ScriptsHandler
    {
        public static void HandleJoin(HttpListenerContext context)
        {
            HttpListenerResponse response = context.Response;
            HttpListenerRequest request = context.Request;

            string responseString = "<HTML><BODY> If you see this it means the test worked.</BODY></HTML>";

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
            Console.WriteLine("if you see this it means it worked.");
        }

        public static void HandleHost(HttpListenerContext context, ushort gameport = 53640)
        {
            HttpListenerResponse response = context.Response;

            Console.WriteLine("Host URL was called!");
            string HostScript = Paths.HostScript;
            HostScript = HostScript.Replace("{port}", gameport.ToString());
            Console.WriteLine("Rewriting script port..");

            string responseString = HostScript;

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
            Console.WriteLine("Done!");
        }
    }
}
