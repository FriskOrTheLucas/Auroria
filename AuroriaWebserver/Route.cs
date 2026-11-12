using AuroriaWebserver.Asset;
using AuroriaWebserver.Game;
using AuroriaWebserver.IDE;
using AuroriaWebserver.staticHTML;
using System;
using System.Net;
using System.Text;
using System.IO;


namespace AuroriaWebserver
{
    internal class Route
    {
        public static void HandleRequest(HttpListenerContext context)
        {
            string AbsolutePath = context.Request.Url.AbsolutePath.ToLower();
            // I know thats kinda useless right now but that make the code looks more clean
            // -creds to rickkkkk for making this -Lucas
            Console.WriteLine($"Request: {context.Request.RawUrl}");

            if (AbsolutePath.Equals("/game/join.ashx"))
            {
                ScriptsHandler.HandleJoin(context);
            }

            if (AbsolutePath.Equals("/ide/clienttoolbox.aspx"))
            {
                Console.WriteLine("Toolbox request sent");
                Toolbox.HandleToolbox(context);
            }

            if (AbsolutePath.Equals("/ide/landing.aspx") || AbsolutePath.Equals("/ide/start.aspx"))
            {
                Console.WriteLine("Landing Request sent");
                Landing.HandleLanding(context);
            }

            if (AbsolutePath.Equals("/ide/style.css"))
            {
                Console.WriteLine("Style Request sent");
                HttpListenerResponse response = context.Response;

                byte[] buffer = File.ReadAllBytes(@"Data\Static\Landing\style.css");
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
            }

            if (AbsolutePath.Equals("/staticassets/"))
            {
                Console.WriteLine("Logo request Sent");
                StaticAssetsHandler.HandleStatic(context);
            }

            if (AbsolutePath.Equals("/game/gameserver.ashx"))
            {
                ScriptsHandler.HandleGameserver(context);
            }

            if (AbsolutePath.Equals("/game/visit.ashx"))
            {
                ScriptsHandler.HandleVisit(context);
            }

            if (AbsolutePath.Equals("/game/studio.ashx"))
            {
                ScriptsHandler.HandleStudio(context);
            }

            if (AbsolutePath.Equals("/asset/bodycolors.ashx"))
            {
                BodyColor.HandleBodyColor(context);
            }

            if (AbsolutePath.Equals("/asset/characterfetch.ashx"))
            {
                Console.WriteLine("Character Fetch recieved.");
                CharacterFetch.HandleFetch(context);
            }

            if (AbsolutePath.Equals("/asset/getscriptstate.ashx"))
            {
                GetScriptState.DoThing(context);
            }

            if (AbsolutePath.Equals("/error/reportdialog.aspx"))
            {
                Console.WriteLine("report dialog recieved.");
                HttpListenerResponse response = context.Response;

                string responseString = "just close out of this lol";

                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();
            }

            if (AbsolutePath.Equals("/asset/"))
            {
                AssetDelivery.HandleDelivery(context);
            }

            if (AbsolutePath.Equals("/game/machineconfiguration.ashx"))
            {
                context.Response.StatusCode = 200;
                context.Response.ContentLength64 = 0;
                context.Response.OutputStream.Close();
            }

            if (AbsolutePath.Equals("/game/keepalivepinger.ashx"))
            {
                context.Response.StatusCode = 200;
                context.Response.ContentLength64 = 0;
                context.Response.OutputStream.Close();
            }

            if (AbsolutePath.Equals("/analytics/measurement.ashx"))
            {
                context.Response.StatusCode = 200;
                context.Response.ContentLength64 = 0;
                context.Response.OutputStream.Close();
                Console.WriteLine("Responded /analytics/measurement.ashx correctly");
            }
        }
    }
}