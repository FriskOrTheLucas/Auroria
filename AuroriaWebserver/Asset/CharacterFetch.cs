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

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to get CharacterFetch: " + ex);
            }
        }
    }
}
