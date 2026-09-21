using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
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

        public static void HandleGameserver(HttpListenerContext context, ushort gameport = 53640)
        {
            try
            {
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                string port = request.QueryString["port"] ?? "53640";
                gameport = ushort.Parse(port);

                Console.WriteLine("Host URL was called!");
                string GameSerScript = Paths.GameSer;
                string ReadWriteGameServscript = File.ReadAllText(GameSerScript);
                ReadWriteGameServscript = ReadWriteGameServscript.Replace("{port}", gameport.ToString());
                Console.WriteLine("Rewriting script port..");
                Console.WriteLine("Script port rewritten to: " + gameport.ToString());

                string responseString = ReadWriteGameServscript;

                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
                Console.WriteLine("Done!");
                Console.WriteLine("result:", responseString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in HandleHost: " + ex.Message);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.Close();
            }
        }
    }
}
