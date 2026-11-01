using System.Net;
using System.Text;

namespace AuroriaWebserver.IDE
{
    public static class Landing
    {
        public static void HandleLanding(HttpListenerContext context)
        {
            HttpListenerResponse response = context.Response;

            string responseString = "<HTML><BODY align=\"center\"> <h1> Auroria Launcher </h1> <div> <p> If you see this then congrats! It means the webserver hasnt crapped itself! </p> <h2> I will put more here soon. Just gimmeh some retro gubby time </h2> </div> <div> <img src=\"http://www.roblox.com/staticassets/auroria.png\" alt=\"Auroria\"> </div></BODY></HTML>";

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }
    }
}
