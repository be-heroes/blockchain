using System;
using System.Linq;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Request
{
    public class KrakenRpcRequest : HttpRequestMessage
    {
        public DateTime TimeStamp => DateTime.Now;

        public string GetSignature(string passphrase)
        {
            var message = Content?.ReadAsStringAsync().Result;
            var base64DecodedSecred = Convert.FromBase64String(passphrase);
            var nonce = message.Substring(6);
            var hashInput = Encoding.UTF8.GetBytes(nonce + message);
            var hash = new Sha256Digest();

            hash.BlockUpdate(hashInput, 0, hashInput.Length);

            var hashDigest = new byte[hash.GetDigestSize()];

            hash.DoFinal(hashDigest, 0);

            var hmac = new HMac(new Sha512Digest());
            var hmacInput = Encoding.UTF8.GetBytes(RequestUri.AbsolutePath).Concat(hashDigest).ToArray();

            hmac.Init(new KeyParameter(base64DecodedSecred));
            hmac.BlockUpdate(hmacInput, 0, hmacInput.Length);

            var hmacDigest = new byte[hmac.GetMacSize()];

            hmac.DoFinal(hmacDigest, 0);

            var base64Digest = Convert.ToBase64String(hmacDigest);

            return base64Digest;
        }

    }
}
