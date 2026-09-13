using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace AuroriaWebserver
{
    internal class Program
    {
        static void Main()
        {
            HttpListener Server = new HttpListener();

            Server.Prefixes.Add("http://localhost/");
            Server.Start();

            Console.WriteLine("Server started. Listening on http://localhost/");

            while (true)
            {
                HttpListenerContext Context = Server.GetContext();

                Route.HandleRequest(Context);
            }
        }
    }
}
