using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

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

        public static string JoinScript
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

                return Path.Combine("Clients", client, "Scripts", "join.lua");
            }
        }

        public static void HandleJoin(HttpListenerContext context)
        {
            try
            {
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                string ip = request.QueryString["serverIP"] ?? "localhost";
                string port = request.QueryString["serverPort"] ?? "53640";
                string playername = request.QueryString["userName"] ?? "Player";
                string playerid = request.QueryString["userID"] ?? "1";
                string bodycolorurl = AuroriaResources.PathHelper.GenerateBodyColorAshxURL;

                Console.WriteLine("Join URL was called!");
                string CurJsonDir = Path.Combine(Directory.GetCurrentDirectory(), InfoFilePath);
                Console.WriteLine("Getting Player Json.. " + CurJsonDir);
                Console.WriteLine("Getting Client Script: " + JoinScript);
                string ReadWriteJoinscript = File.ReadAllText(JoinScript);
                ReadWriteJoinscript = ReadWriteJoinscript.Replace("{userid}", playerid);
                ReadWriteJoinscript = ReadWriteJoinscript.Replace("{username}", playername);
                ReadWriteJoinscript = ReadWriteJoinscript.Replace("{charapp}", bodycolorurl);
                ReadWriteJoinscript = ReadWriteJoinscript.Replace("{ip}", ip);
                ReadWriteJoinscript = ReadWriteJoinscript.Replace("{port}", port);
                Console.WriteLine("Rewriting script values..");

                string responseString = ReadWriteJoinscript;

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

        public static void HandleGameserver(HttpListenerContext context)
        {
            try
            {
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                string port = request.QueryString["port"] ?? "53640";

                Console.WriteLine("Host URL was called!");
                string CurJsonDir = Path.Combine(Directory.GetCurrentDirectory(), InfoFilePath);
                Console.WriteLine("Getting Player Json.. " + CurJsonDir);
                Console.WriteLine("Getting Client Script: " + GameServScript);
                string ReadWriteGameServscript = File.ReadAllText(GameServScript);
                ReadWriteGameServscript = ReadWriteGameServscript.Replace("{port}", port);
                Console.WriteLine("Rewriting script port..");
                Console.WriteLine("Script port rewritten to: " + port);

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
