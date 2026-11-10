using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle;

namespace AuroriaResources.Signing
{
    internal static class ScriptSign
    {
        private static RSA newRSA;
        private static string GetSignFormat(SignatureType Format)
        {
            if (Format == SignatureType.None)
            {
                return string.Empty;
            }
            else if (Format == SignatureType.Legacy)
            {
                return "%{0}%";
            }
            else if (Format == SignatureType.Rbxsig)
            {
                return "--rbxsig%{0}%";
            }
            else
            {
                throw new Exception("Signature not recognized");
            }
        }

        private static string GetPreFormat(SignatureType Format, bool AssetID)
        {
            if (!AssetID)
            {
                return "\r\n{0}";
            }
            if (Format == SignatureType.None)
            {
                return string.Empty;
            }
            else if (Format == SignatureType.Legacy)
            {
                return "%{1}%\r\n{0}";
            }
            else if (Format == SignatureType.Rbxsig)
            {
                return "\r\n--rbxassetid%{1}%\r\n{0}";
            }
            else
            {
                throw new Exception("Signature not recognized");
            }
        }

        //public static string SignScript(string Script, string AssetID)
        //{
            //string ThePemFile = File.ReadAllText(PathHelper.PrivateKey);

           //newRSA = RSA.Create();
        //}
    }
}
