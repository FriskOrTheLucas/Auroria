using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AuroriaResources;

namespace AuroriaWebserver.Asset
{
    public static class CharacterFetch
    {
        public static void HandleFetch(HttpListenerContext context)
        {
            try
            {
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;


                string userID = request.QueryString["userID"] ?? "24-24-119-24-119-23";
                string[] array = userID.Split('_');

                Console.WriteLine("Recieved and split userID");

                string finalUrl = $"http://www.roblox.com/asset/bodycolors.ashx?userid={PathHelper.BodyColorsNoUrl}";
                foreach (var Item in array)
                {
                    if (Item == PathHelper.BodyColorsNoUrl)
                    {
                        finalUrl += "";
                    }
                    else
                    {
                        finalUrl += $";http://www.roblox.com/asset/?id={Item}";
                    }
                }
                Console.WriteLine("CharacterFetch Text = " + finalUrl);

                byte[] buffer = Encoding.UTF8.GetBytes(finalUrl);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
                response.Close();
                Console.WriteLine("Finished CharacterFetch");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get CharacterFetch: " + ex);
            }
        }
    }
}
