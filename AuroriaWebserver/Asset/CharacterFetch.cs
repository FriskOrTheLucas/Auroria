using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AuroriaResources;
using System.Reflection.Emit;

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

                string finalUrl = $"http://www.roblox.com/asset/bodycolors.ashx?userid={PathHelper.BodyColors}";
                foreach (var Item in array)
                {
                    if (Item.Contains(PathHelper.BodyColors))
                    {
                        return;
                    }

                    finalUrl += Item;
                }
                Console.WriteLine("CharacterFetch Redirect = " + finalUrl);
                response.Redirect(finalUrl);
                Console.WriteLine("Redirected to BodyColors");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get CharacterFetch: " + ex);
            }
        }
    }
}
