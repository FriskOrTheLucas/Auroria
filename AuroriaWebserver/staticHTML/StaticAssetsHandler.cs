using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Drawing;

namespace AuroriaWebserver.staticHTML
{
    public static class StaticAssetsHandler
    {
        public static void logo(HttpListenerContext context)
        {
            HttpListenerResponse response = context.Response;

            Bitmap bmp = Properties.Resources.AuroriaLogo;

            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] buffer = ms.ToArray();

                response.ContentType = "image/png";
                response.ContentLength64 = buffer.Length;

                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
            }
        }
    }
}
