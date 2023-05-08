using BeHeroes.CodeOps.Abstractions.Cryptography;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace BeHeroes.Blockchain.Core.Cryptography
{
    public sealed class Ed25519SignatureProvider : SignatureProvider
    {
        public Ed25519SignatureProvider(Ed25519Key key, Ed25519Algorithm algorithm) : base(key, algorithm)
        {
        }
        
        public override byte[] Sign(byte[] input)
        {
            Ed25519Key key = (Ed25519Key)Key;

            if(!key.IsPrivate)
                throw new CryptographyException("Do not use public keys to sign data. It is deterministic.");

            var signer = new Ed25519Signer();

            signer.Init(true, new Ed25519PrivateKeyParameters(key.RawData.ToArray()));
            signer.BlockUpdate(input, 0, input.Length);

            return signer.GenerateSignature();            
        }

        public override bool Verify(byte[] input, byte[] signature)
        {            
            Ed25519Key key = (Ed25519Key)Key;

            if(key.IsPrivate)
                return false;

            var validator = new Ed25519Signer();

            validator.Init(false, new Ed25519PublicKeyParameters(key.RawData.ToArray()));
            validator.BlockUpdate(input, 0, input.Length);

            return validator.VerifySignature(signature);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose();
        }
    }
}