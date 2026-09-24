using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AuroriaWebserver.Mains
{
    public static class AssetDelivery
    {
        static string cookie = @"data\cookie.txt";
        static string InfoFilePath = "PlayerSettings.json";

        static string json = File.ReadAllText(InfoFilePath);
        static JObject obj = JObject.Parse(json);
        static string AsstUrl = (string)obj["AssetURL"];
        static string MapDirectory = (string)obj["CurrentMap"];
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
                    byte[] buffer = File.ReadAllBytes(MapDirectory); // i think this is the way to do it?
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
                    response.ContentType = "application/octet-stream";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                }
            }

            if (cookiecheck == null)
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
                    // i gotta add notes to this code so then JayJay can understand
                    // + incase someone needs to read it and understand it
                    // also then i can laugh at funny comments later

                    string url = AsstUrl + id + "&version=" + version; //gets the asset url and id (version too for older stuff i think)
                    Console.WriteLine("Requesting asset from: " + url); 

                    HttpWebRequest assetReq = (HttpWebRequest)WebRequest.Create(url);
                    assetReq.Headers.Add(HttpRequestHeader.Cookie, ".ROBLOSECURITY=" + cookiecheck); // requests the asset url along with the cookie
                    Console.WriteLine("Requested URL with Cookie.");

                    assetReq.AllowAutoRedirect = true; //dont know what this was i just got told to use it
                    assetReq.Method = "GET"; //same here
                    assetReq.UserAgent = "Roblox/WinInet"; //I learned that if youre requesting it from the actual roblox assetdelivery url then this is needed
                    HttpWebResponse assetResponse = (HttpWebResponse)assetReq.GetResponse(); // Gets the response from the asset delivery url
                    Console.WriteLine("Received response from asset request.");

                    Stream ResponseStream = assetResponse.GetResponseStream(); 
                    ResponseStream.CopyTo(response.OutputStream); // Takes the respone from the asset url and copies it to the output
                    response.OutputStream.Close();
                    Console.WriteLine("Asset delivery Finished!"); // yaaay
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while handling asset delivery: " + ex.Message); // frick.
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // returns 404

                    string jsonResponse = "{\"message\": \"An error has occurred and Auroria cannot deliver the asset. We are sorry.\"}"; // i cry
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
