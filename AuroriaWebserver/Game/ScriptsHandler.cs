using System;
using System.Text;
using System.Net;
using System.IO;
using AuroriaResources;

namespace AuroriaWebserver.Game
{
    public static class ScriptsHandler
    {
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
                Console.WriteLine("Getting Client Script: " + ClientSettings.JoinScript);
                string ReadWriteJoinscript = File.ReadAllText(ClientSettings.JoinScript);
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
                Console.WriteLine("Getting Client Script: " + ClientSettings.GameserverScript);
                string ReadWriteGameServscript = File.ReadAllText(ClientSettings.GameserverScript);
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
