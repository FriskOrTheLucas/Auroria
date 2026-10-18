using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


namespace AuroriaWebserver.IDE
{
    public static class Toolbox
    {
        public static void HandleToolbox(HttpListenerContext context)
        {
            Console.WriteLine("Toolbox request received");
            HttpListenerResponse response = context.Response;

            string responseString = "<HTML><BODY> no.</BODY></HTML>";

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }
    }
}
