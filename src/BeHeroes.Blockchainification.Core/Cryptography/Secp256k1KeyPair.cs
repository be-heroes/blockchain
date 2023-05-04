using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms;
using BeHeroes.Blockchainification.Core.Cryptography.Algorithms;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Secp256k1KeyPair : IKeyPair
    {
        public IAlgorithm Algorithm => new Secp256k1Algorithm();

        public IKey Private { get; init; }

        public IKey Public { get; init; }

        public Secp256k1KeyPair()
        {            
            var curve = Algorithm.Curve as X9ECParameters;

            if(curve == null)
                throw new NullReferenceException();

            var domainParams = new ECDomainParameters(curve.Curve, curve.G, curve.N, curve.H, curve.GetSeed());
            var secureRandom = new SecureRandom();
            var keyParams = new ECKeyGenerationParameters(domainParams, secureRandom);
            var generator = new ECKeyPairGenerator(Algorithm.Identifier);

            generator.Init(keyParams);
            
            var keyPair = generator.GenerateKeyPair();
            var privateKey = keyPair.Private as ECPrivateKeyParameters;
            var publicKey = keyPair.Public as ECPublicKeyParameters;

            Private = new Secp256k1PrivateKey(privateKey?.D.ToByteArrayUnsigned() ?? Array.Empty<byte>());
            Public = new Secp256k1PublicKey(publicKey?.Q.GetEncoded() ?? Array.Empty<byte>());
        }

        public Secp256k1KeyPair(ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
        {
            Private = new Secp256k1PrivateKey(privateKey.D.ToByteArrayUnsigned() ?? Array.Empty<byte>());
            Public = new Secp256k1PublicKey(publicKey.Q.GetEncoded() ?? Array.Empty<byte>());
        }

        sealed class Secp256k1PrivateKey : Key
        {
            public override int KeySize => 256;

            public Secp256k1PrivateKey(byte[] rawData) : base(rawData, true)
            {
            }
        }   

        sealed class Secp256k1PublicKey : Key
        {
            public override int KeySize => 257;

            public Secp256k1PublicKey(byte[] rawData) : base(rawData, false)
            {
            }
        }  
    }
}