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
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();

            Console.WriteLine("Http listener started! listening on http://localhost:8080/");
            Console.WriteLine("Dont worry lucas. you got this.");

            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerResponse response = context.Response;
                string indexdir = "www\\index.html";

                byte[] buffer = File.ReadAllBytes(indexdir);

                response.ContentLength64 = buffer.Length;
                response.ContentType = "text/html";

                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);

                output.Close();
            }
        }
    }
}
