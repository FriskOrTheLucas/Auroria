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
        private static string CombineAssetUrl(string ID)
        {
            return $";http://www.roblox.com/asset/?id={ID}";
        }

        public static void HandleFetch(HttpListenerContext context)
        {
            try
            {
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;


                string userID = request.QueryString["userID"] ?? "24-24-119-24-119-23";
                string[] array = userID.Split('_');
                Console.WriteLine("Recieved and split userID");
                string AllItems()
                {
                    foreach (var item in array)
                    {
                        return CombineAssetUrl(item);
                    }
                    return "";
                }
                string finalUrl = $"http://www.roblox.com/asset/bodycolors.ashx?userid={PathHelper.BodyColors}" + AllItems();
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
