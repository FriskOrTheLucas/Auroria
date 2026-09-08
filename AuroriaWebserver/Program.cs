using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace AuroriaWebserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // note that this is all just me testing as im still learning httplistener
            Console.WriteLine("hallo test?");

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost/");
            listener.Prefixes.Add("http://roblox.com/");
            listener.Prefixes.Add("http://rbxweb.lol/");
            listener.Start();

            Console.WriteLine("Http listener started! listening on http://localhost/");
            Console.WriteLine("Dont worry lucas. you got this.");

            while (true)
            {
                HttpListenerContext context = listener.GetContext();

                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                if (request.Url.AbsolutePath == "/Game/Join.ashx")
                {
                    Mains.HandleJoin(request, response);
                    Console.WriteLine("Join url was called!");
                }
                else if (request.Url.AbsolutePath == "/IDE/Start.aspx")
                {
                    Console.WriteLine("Start aspx was called and has launched successfully.");
                    Console.WriteLine("Domain URL");

                    // temporary response so the browser doesn't get index.html
                    string message = "Start.aspx was called!";

                    byte[] buffer = Encoding.UTF8.GetBytes(message);

                    response.ContentType = "text/plain";
                    response.ContentLength64 = buffer.Length;

                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                }
                else
                {
                    // everything else gets the sht
                    string indexdir = "www\\index.html";

                    byte[] buffer = File.ReadAllBytes(indexdir);

                    response.ContentLength64 = buffer.Length;
                    response.ContentType = "text/html";

                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                }
            }
        }
    }
}
