using System.Text;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace BeHeroes.Infrastructure.Exchanges.Bitfinex
{
    public class BitfinexSignatureProvider : SignatureProvider
    {
        public BitfinexSignatureProvider(Uri uri, Key key, IAlgorithm algorithm) : base(key, algorithm)
        {
        }

        public byte[] Sign(byte[] input, string? passphrase)
        {         
            var hmac = new HMac(new Sha384Digest());

            hmac.Init(new KeyParameter(Encoding.ASCII.GetBytes(passphrase ?? string.Empty)));
            hmac.BlockUpdate(input, 0, input.Length);
            
            var hmacDigest = new byte[hmac.GetMacSize()];

            hmac.DoFinal(hmacDigest, 0);

            return hmacDigest;
        }

        public override byte[] Sign(byte[] input)
        {            
            return Sign(input, null);
        }

        public override bool Verify(byte[] input, byte[] signature)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            return;
        }
    }
}