using BeHeroes.CodeOps.Abstractions.Cryptography;

using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace BeHeroes.Blockchain.Core.Cryptography
{
    public sealed class Ed25519KeyPair : KeyPair
    {
        public Ed25519KeyPair() : this(new Ed25519Algorithm())
        {        

        }
        
        public Ed25519KeyPair(Ed25519Algorithm algorithm) : this(algorithm, Ed25519Key.Empty, Ed25519Key.Empty)
        {            
            var generator = new Ed25519KeyPairGenerator();
            var keyGenerationParams = new Ed25519KeyGenerationParameters(new SecureRandom());
            
            generator.Init(keyGenerationParams);

            var keyPair = generator.GenerateKeyPair();
            var privateKeyParameter = (Ed25519PrivateKeyParameters)keyPair.Private;
            var publicKeyParameter = (Ed25519PublicKeyParameters)keyPair.Public;

            Private = new Ed25519Key(privateKeyParameter.GetEncoded());
            Public = new Ed25519Key(publicKeyParameter.GetEncoded(), false);
        }
        
        public Ed25519KeyPair(Ed25519Algorithm algorithm, Ed25519Key privateKey, Ed25519Key publicKey) : base(algorithm, privateKey, publicKey)
        {
        }
    }
}