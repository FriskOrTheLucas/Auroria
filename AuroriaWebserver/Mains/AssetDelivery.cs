using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace AuroriaWebserver.Mains
{
    public static class AssetDelivery
    {
        static string cookie = @"data\cookie.txt";
        public static void HandleDelivery(HttpListenerContext context)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            string cookiecheck = File.ReadAllText(cookie);
            HttpListenerResponse response = context.Response;
            HttpListenerRequest request = context.Request;

            string id = request.QueryString["id"] ?? "1818";
            string version = request.QueryString["version"] ?? "1";

            if (cookiecheck == null)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                response.ContentType = "application/json";

                string jsonResponse = "{\"message\": \"IDIOT!!! NO ROBLOSECURITY TOKEN MY SONION!!\"}";
                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
            }

            else
            {
                string url = "https://assetdelivery.roblox.com/v1/asset/?version=" + version + "&id=" + id;

                HttpWebRequest assetReq = (HttpWebRequest)WebRequest.Create(url);
                assetReq.Headers.Add(HttpRequestHeader.Cookie, ".ROBLOSECURITY=" + cookiecheck);

                assetReq.AllowAutoRedirect = true;
                assetReq.UserAgent = "Roblox/WinInet";
                HttpWebResponse assetResponse = (HttpWebResponse)assetReq.GetResponse();

                StreamReader reader = new StreamReader(assetResponse.GetResponseStream());
                string result = reader.ReadToEnd();
                result = result.Replace("roblox.com", "rbxweb.lol");

                byte[] buffer = Encoding.UTF8.GetBytes(result);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
            }
        }
    }
}
