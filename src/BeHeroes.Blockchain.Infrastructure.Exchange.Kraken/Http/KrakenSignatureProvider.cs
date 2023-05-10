using System.Text;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace BeHeroes.Infrastructure.Exchanges.Kraken
{
    public class KrakenSignatureProvider : SignatureProvider
    {
        public KrakenSignatureProvider(Uri uri, Key key, IAlgorithm algorithm) : base(key, algorithm)
        {
        }

        public byte[] Sign(byte[] input, Uri? uri)
        {         
            var hash = new Sha256Digest();

            hash.BlockUpdate(input, 0, input.Length);

            var hashDigest = new byte[hash.GetDigestSize()];

            hash.DoFinal(hashDigest, 0);

            var hmac = new HMac(new Sha512Digest());
            var pathSalt = Encoding.UTF8.GetBytes(uri?.AbsolutePath ?? string.Empty);
            var hmacInput = (pathSalt != null) ? pathSalt.Concat(hashDigest).ToArray() : hashDigest;

            //extract key data using reflection.
            var rawDataField = Key.GetType().GetField("_rawData", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var rawDataValue = rawDataField?.GetValue(Key) as byte[];
            
            if(rawDataValue == null)
                throw new NullReferenceException(nameof(rawDataValue));

            hmac.Init(new KeyParameter(rawDataValue));
            hmac.BlockUpdate(hmacInput, 0, hmacInput.Length);

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