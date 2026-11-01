using System;
using System.Text;
using System.IO;
using System.Net;
using AuroriaResources;

namespace AuroriaWebserver.Asset
{
    public static class AssetDelivery
    {
        static readonly string cookie = @"data\cookie.txt";
        public static void HandleDelivery(HttpListenerContext context)
        {
            string cookiecheck = File.ReadAllText(cookie);
            HttpListenerResponse response = context.Response;
            HttpListenerRequest request = context.Request;

            string id = request.QueryString["id"] ?? "1818";
            string version = request.QueryString["version"] ?? "1";

            if (id == "1818")
            {
                Console.WriteLine("Map Asset 1818 has been called!");
                try
                {
                    byte[] buffer = File.ReadAllBytes(PlayerSettings.GetMap); // i think this is the way to do it?
                    response.ContentType = "application/octet-stream";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while getting map: " + ex.Message);
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    string jsonResponse = "{\"message\": \"An error has occurred while getting the map. We are sorry.\"}"; // fug
                    Console.WriteLine("Sent error code and message.");
                    byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                }
            }

            if (string.IsNullOrWhiteSpace(cookiecheck))
            {
                Console.WriteLine("No .ROBLOSECURITY token found in cookie.txt");
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                response.ContentType = "application/json";

                string jsonResponse = "{\"message\": \"IDIOT!!! NO ROBLOSECURITY TOKEN MY SONION!!\"}";
                Console.WriteLine("Sent error code and message.");
                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
                Console.WriteLine("Output has been closed.");
            }

            else
            {
                try
                {
                    string url = PlayerSettings.AssetURL + "id=" + id + "&version=" + version; 
                    Console.WriteLine("Requesting asset from: " + url); 

                    HttpWebRequest assetReq = (HttpWebRequest)WebRequest.Create(url);
                    assetReq.Headers.Add(HttpRequestHeader.Cookie, ".ROBLOSECURITY=" + cookiecheck); 
                    Console.WriteLine("Requested URL with Cookie.");

                    assetReq.AllowAutoRedirect = true; 
                    assetReq.Method = "GET"; 
                    assetReq.UserAgent = "Roblox/WinInet";
                    HttpWebResponse assetResponse = (HttpWebResponse)assetReq.GetResponse(); 
                    Console.WriteLine("Received response from asset request.");

                    Stream ResponseStream = assetResponse.GetResponseStream();
                    

                    ResponseStream.CopyTo(response.OutputStream); 
                    response.OutputStream.Close();
                    Console.WriteLine("Asset delivery Finished!"); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while handling asset delivery: " + ex.Message); 
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; 

                    string jsonResponse = "{\"message\": \"An error has occurred and Auroria cannot deliver the asset. We are sorry.\"}"; 
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
