using AuroriaResources;
using AuroriaResources.Signing;
using System;
using System.IO;
using System.Net;
using System.Text;

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

            if (Directory.Exists(PathHelper.LocalGameAssetHelper))
            {
                foreach (var file in Directory.GetFiles(PathHelper.LocalGameAssetHelper))
                {
                    if (file.Contains(id + ".png") || file.Contains(id + ".rbxm") || file.Contains(id + ".mesh"))
                    {
                        try
                        {
                            Console.WriteLine("Local Game Asset Found: " + id);
                            byte[] buffer = File.ReadAllBytes(file);
                            response.ContentType = "application/octet-stream";
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                            response.OutputStream.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error occurred while getting Local Asset: " + ex.Message);
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            string jsonResponse = "{\"message\": \"An error has occurred while getting the asset. We are sorry.\"}";
                            Console.WriteLine("Sent error code and message.");
                            byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                            response.OutputStream.Close();
                            return;
                        }
                    }
                }
            }

            if (Directory.Exists(PathHelper.CoreScriptPath))
            {
                foreach (var file in Directory.GetFiles(PathHelper.CoreScriptPath))
                {
                    if (file.Contains(id + ".rbxm"))
                    {
                        try
                        {
                            Console.WriteLine("Local Asset Found: " + id);
                            byte[] buffer = File.ReadAllBytes(file);
                            response.ContentType = "application/octet-stream";
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                            response.OutputStream.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error occurred while getting Local Asset: " + ex.Message);
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            string jsonResponse = "{\"message\": \"An error has occurred while getting the asset. We are sorry.\"}";
                            Console.WriteLine("Sent error code and message.");
                            byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                            response.OutputStream.Close();
                            return;
                        }
                    }
                    else if (file.Contains(id + ".lua"))
                    {
                        try
                        {
                            Console.WriteLine("Local corescript Found: " + id);
                            string readcorescript = File.ReadAllText(file);
                            string script = ScriptSign.SignScript(readcorescript, id);
                            byte[] buffer = Encoding.UTF8.GetBytes(script);
                            response.ContentType = "application/octet-stream";
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                            response.OutputStream.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error occurred while getting Local corescript: " + ex);
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            string jsonResponse = "{\"message\": \"An error has occurred while getting the asset. We are sorry.\"}";
                            Console.WriteLine("Sent error code and message.");
                            byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                            response.OutputStream.Close();
                            return;
                        }
                    }
                }
            }

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
                    var cookie = new Cookie(".ROBLOSECURITY", cookiecheck, "/", ".roblox.com");
                    assetReq.AllowAutoRedirect = true;
                    assetReq.Method = "GET";
                    assetReq.UserAgent = "Roblox/WinInet";
                    assetReq.Headers.Add("Cookie", cookie.ToString()); 
                    Console.WriteLine("Requested URL with Cookie.");
                    HttpWebResponse assetResponse = (HttpWebResponse)assetReq.GetResponse(); 
                    Console.WriteLine("Received response from asset request.");
                    Stream ResponseStream = assetResponse.GetResponseStream();
                    ResponseStream.CopyTo(response.OutputStream);
                    response.OutputStream.Close();
                    Console.WriteLine("Asset delivery Finished!");
                    ResponseStream.Close();
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
