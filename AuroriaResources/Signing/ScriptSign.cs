using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

namespace AuroriaResources.Signing
{
    public static class ScriptSign
    {
        private static SignatureType sig => ClientSettings.ClientSignature();
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

        private static AsymmetricKeyParameter ReadPrivateKey()
        {
            using (var reader = File.OpenText(PathHelper.PrivateKey))
            {
                var pemreader = new PemReader(reader);
                object Obj = pemreader.ReadObject();

                if (Obj is AsymmetricCipherKeyPair keyPair)
                {
                    return keyPair.Private;
                }

                throw new InvalidDataException("Failed to get private key, format not recognized.");
            }
        }

        public static string SignScript(string Script, string AssetID)
        {
            if (sig == SignatureType.None)
            {
                return Script;
            }

            string sigformat = GetSignFormat(sig);
            string sigPre = GetPreFormat(sig, string.IsNullOrWhiteSpace(AssetID));
            Script = string.Format(sigPre, Script, AssetID);

            return Script; //temporary so i can push without build errors
        }
    }
}
