using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using AuroriaWebserver.Webserver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using AuroriaResources;

namespace AuroriaWebserver.Mains
{
    public static class ScriptsHandler
    {
        public static string InfoFilePath = "PlayerSettings.json";

        public static string GameServScript
        {
            get
            {
                string json = File.ReadAllText(InfoFilePath);
                JObject obj = JObject.Parse(json);
                string client = (string)obj["Client"];

                if (string.IsNullOrWhiteSpace(client))
                {
                    throw new Exception("client is null or empty.");
                }

                return Path.Combine("Clients", client, "Scripts", "gameserver.lua");
            }
        }

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
                string CurJsonDir = Path.Combine(Directory.GetCurrentDirectory(), InfoFilePath);
                Console.WriteLine("Getting Player Json.. " + CurJsonDir);
                Console.WriteLine("Getting Client Script: " + GameServScript);
                string ReadWriteGameServscript = File.ReadAllText(GameServScript);
                ReadWriteGameServscript = ReadWriteGameServscript.Replace("{port}", gameport.ToString());
                Console.WriteLine("Rewriting script port..");
                Console.WriteLine("Script port rewritten to: " + gameport.ToString());

                string responseString = ReadWriteGameServscript;

                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
                response.Close();
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                HttpListenerResponse response = context.Response;
                Console.WriteLine("Error in HandleHost: " + ex.Message);
                byte[] buffer = Encoding.UTF8.GetBytes("An unexpected error occured when getting the gameserver script: " + ex.Message);
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
                response.Close();
            }
        }
    }
}
