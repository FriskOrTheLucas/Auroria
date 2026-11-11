using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Drawing;

namespace AuroriaWebserver.staticHTML
{
    public static class StaticAssetsHandler
    {
        public static void HandleStatic(HttpListenerContext context)
        {
            HttpListenerRequest request = context.Request; 
            HttpListenerResponse response = context.Response;

            string asset = request.QueryString["FileName"] ?? "AuroriaLogo";
            string StaticAssetDirectory = @"Data\Static";

            foreach (var file in Directory.GetFiles(StaticAssetDirectory))
            {
                Console.WriteLine("Getting Static Asset Directory: " + file);
                if (Directory.Exists(file))
                {
                    return;
                }

                if (file.Contains(asset))
                {
                    try
                    {
                        Console.WriteLine("Static Asset Found.");
                        byte[] buffer = File.ReadAllBytes(file);
                        response.ContentType = "application/octet-stream";
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        response.OutputStream.Close();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error occurred while getting Static Asset: " + ex.Message);
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        string jsonResponse = "{\"message\": \"An error has occurred while getting the asset. We are sorry.\"}";
                        Console.WriteLine("Sent error code and message.");
                        byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        response.OutputStream.Close();
                    }
                }
            }
        }
    }
}
