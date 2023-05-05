using BeHeroes.Blockchainification.Core.Cryptography.Algorithms;
using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms;

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
            var curve = (Secp256k1Curve)Algorithm.Curve;
            var parameters = (X9ECParameters)curve;
            var domainParams = new ECDomainParameters(parameters.Curve, parameters.G, parameters.N, parameters.H, parameters.GetSeed());
            var secureRandom = new SecureRandom();
            var keyParams = new ECKeyGenerationParameters(domainParams, secureRandom);
            var generator = new ECKeyPairGenerator(Algorithm.Identifier);

            generator.Init(keyParams);
            
            var keyPair = generator.GenerateKeyPair();
            var privateKeyParameter = (ECPrivateKeyParameters)keyPair.Private;
            var publicKeyParameter = (ECPublicKeyParameters)keyPair.Public;

            Private = new Secp256k1Key(privateKeyParameter.D.ToByteArrayUnsigned());
            Public = new Secp256k1Key(publicKeyParameter.Q.GetEncoded(), false);
        }

        public Secp256k1KeyPair(ECPrivateKeyParameters privateKeyParameter, ECPublicKeyParameters publicKeyParameter)
        {
            Private = new Secp256k1Key(privateKeyParameter.D.ToByteArrayUnsigned());
            Public = new Secp256k1Key(publicKeyParameter.Q.GetEncoded(), false);
        } 
    }
}