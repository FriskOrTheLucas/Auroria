using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AuroriaWebserver;

namespace AuroriaWebserver
{
    public static class Mains
    {
        public static void HandleJoin(HttpListenerRequest request, HttpListenerResponse response)
        {
            Console.WriteLine("Join Ashx was called!");
        }
    }
}
