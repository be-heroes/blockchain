using System.Runtime.Versioning;
using BeHeroes.Blockchainification.Core.Cryptography.Algorithms;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms;

using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Ed25519KeyPair : IKeyPair
    {
        private readonly Ed25519Algorithm _algorithm = new Ed25519Algorithm();

        [UnsupportedOSPlatformGuard("android")]
        [UnsupportedOSPlatformGuard("browser")]
        [UnsupportedOSPlatformGuard("ios")]
        [UnsupportedOSPlatformGuard("tvos")]
        [UnsupportedOSPlatformGuard("windows")]
        public static bool IsSupported { get; }

        public IAlgorithm Algorithm => _algorithm;

        public IKey Private { get; init; }

        public IKey Public { get; init; } = new Ed25519PublicKey(Array.Empty<byte>());

        public Ed25519KeyPair()
        {            
            var generator = new Ed25519KeyPairGenerator();
            
            generator.Init(new Ed25519KeyGenerationParameters(new SecureRandom()));

            var keyPair = generator.GenerateKeyPair();
            var privateKeyParameter = (Ed25519PrivateKeyParameters)keyPair.Private;
            var publicKeyParameter = (Ed25519PublicKeyParameters)keyPair.Public;

            Private = new Ed25519PrivateKey(privateKeyParameter.GetEncoded());
            Public = new Ed25519PublicKey(publicKeyParameter.GetEncoded());
        }

        public Ed25519KeyPair(Ed25519PrivateKeyParameters privateKeyParameter, Ed25519PublicKeyParameters publicKeyParameter)
        {   
            Private = new Ed25519PrivateKey(privateKeyParameter.GetEncoded());
            Public = new Ed25519PublicKey(publicKeyParameter.GetEncoded());            
        }

        sealed class Ed25519PrivateKey : Key
        {
            public override int KeySize => 256;

            public Ed25519PrivateKey(byte[] rawData) : base(rawData, true)
            {
            }
        }   

        sealed class Ed25519PublicKey : Key
        {
            public override int KeySize => 256;

            public Ed25519PublicKey(byte[] rawData) : base(rawData, false)
            {
            }
        }  
    }
}