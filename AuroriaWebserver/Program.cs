using System;
using System.Net;

namespace AuroriaWebserver
{
    internal class Program
    {
        static void Main()
        {
            HttpListener Server = new HttpListener();

            Server.Prefixes.Add("http://roblox.com/");
            Server.Prefixes.Add("http://www.roblox.com/");
            Server.Prefixes.Add("http://api.roblox.com/");
            Server.Prefixes.Add("http://versioncompatibility.api.roblox.com/");

            Server.Start();

            Console.WriteLine("Server started. Listening on Auroria Webserver Domain");

            while (true)
            {
                HttpListenerContext Context = Server.GetContext();

                Route.HandleRequest(Context);
            }
        }
    }
}
