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
        public IAlgorithm Algorithm => new Ed25519Algorithm();

        public IKey Private { get; init; }

        public IKey Public { get; init; }

        public Ed25519KeyPair()
        {            
            var generator = new Ed25519KeyPairGenerator();
            
            generator.Init(new Ed25519KeyGenerationParameters(new SecureRandom()));

            var keyPair = generator.GenerateKeyPair();
            var privateKeyParameter = (Ed25519PrivateKeyParameters)keyPair.Private;
            var publicKeyParameter = (Ed25519PublicKeyParameters)keyPair.Public;

            Private = new Ed25519Key(privateKeyParameter.GetEncoded());
            Public = new Ed25519Key(publicKeyParameter.GetEncoded(), false);               
        }

        public Ed25519KeyPair(Ed25519PrivateKeyParameters privateKeyParameter, Ed25519PublicKeyParameters publicKeyParameter)
        {   
            Private = new Ed25519Key(privateKeyParameter.GetEncoded());
            Public = new Ed25519Key(publicKeyParameter.GetEncoded(), false);
        }
    }
}