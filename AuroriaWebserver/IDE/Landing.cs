using System.Net;
using System.Text;
using System.IO;

namespace AuroriaWebserver.IDE
{
    public static class Landing
    {
        public static void HandleLanding(HttpListenerContext context)
        {
            HttpListenerResponse response = context.Response;

            string indexpath = @"Data\Static\Landing\index.html";

            byte[] buffer = File.ReadAllBytes(indexpath);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }
    }
}
