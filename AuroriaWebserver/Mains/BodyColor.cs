using System.Net;
using System.Text;

namespace AuroriaWebserver.Mains
{
    public static class BodyColor
    {

        public static void DoThing(HttpListenerContext context) // im sorry i couldnt come up with a better name
        {
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            string userID = request.QueryString["userID"] ?? "24-24-119-24-119-23";
            string[] array = userID.Split('-');

            string BodyColorHead = array[0];
            string BodyColorLeftArm = array[1];
            string BodyColorLeftLeg = array[2];
            string BodyColorRightArm = array[3];
            string BodyColorRightLeg = array[4];
            string BodyColorTorso = array[5];

            string FormattedText = $"<?xml version=\"1.0\" encoding=\"utf-8\"?><roblox xmlns:xmime=\"http://www.w3.org/2005/05/xmlmime\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"http://www.roblox.com/roblox.xsd\" version=\"4\"><External>null</External><External>nil</External><Item class=\"BodyColors\"><Properties><int name=\"HeadColor\">{BodyColorHead}</int><int name=\"LeftArmColor\">{BodyColorLeftArm}</int><int name=\"LeftLegColor\">{BodyColorLeftLeg}</int><string name=\"Name\">Body Colors</string><int name=\"RightArmColor\">{BodyColorRightArm}</int><int name=\"RightLegColor\">{BodyColorRightLeg}</int><int name=\"TorsoColor\">{BodyColorTorso}</int><bool name=\"archivable\">true</bool></Properties></Item></roblox>";
            byte[] buffer = Encoding.UTF8.GetBytes(FormattedText);
            response.ContentType = "text/xml";
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.Close();
        }
    }
}
