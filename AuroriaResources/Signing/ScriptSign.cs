using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
        private static byte[] Sign(byte[] data)
        {
            using (var reader = File.OpenText(PathHelper.PrivateKey))
            {
                PemReader pemReader = new PemReader(reader);
                AsymmetricCipherKeyPair keyPair =
                    (AsymmetricCipherKeyPair)pemReader.ReadObject();

                ISigner signer = SignerUtilities.GetSigner("SHA1withRSA");

                signer.Init(true, keyPair.Private);
                signer.BlockUpdate(data, 0, data.Length);

                return signer.GenerateSignature();
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
            byte[] data = Encoding.Default.GetBytes(Script);
            byte[] inArray = Sign(data);
            return string.Format(sigformat, Convert.ToBase64String(inArray)) + Script;
        }
    }
}
