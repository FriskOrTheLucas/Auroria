using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

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
    }
}
