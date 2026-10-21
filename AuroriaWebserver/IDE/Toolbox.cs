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

            string responseString = "<HTML><BODY align=\"center\"> <h1> Welcome to Auroria. </h1> <div> <h3>If you're seeing this it means youre probably doin crap with the toolbox.</h3> <p> Sadly, toolbox isnt ready yet. Comeback when it is! :P </p> </div></BODY></HTML>";

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }
    }
}
