using BeHeroes.CodeOps.Abstractions.Cryptography;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Secp256k1KeyPair : KeyPair
    {
        public Secp256k1KeyPair() : this(new Secp256k1Algorithm())
        {   
        }

        public Secp256k1KeyPair(Secp256k1Algorithm algorithm) : this(algorithm, Secp256k1Key.Empty, Secp256k1Key.Empty)
        {
            var curve = Algorithm.Structure as Secp256k1Curve;

            if(curve == null)
                throw new CryptographyException($"Unsupported structure identified in algorithm {nameof(Secp256k1Algorithm)}. Expected {nameof(Secp256k1Curve)}");

            var seed = curve.GetSeed();
            X9ECParameters curveParameters;

            if(seed.Length == 0)
            {
                curveParameters = ECNamedCurveTable.GetByName(curve.Identifier);
            }
            else
            {
                //TODO: Test that this actually works if we pass a preconfigured Secp256k1Curve to the algorith before generating a keypair
                var seq = (Asn1Sequence)Asn1Object.FromByteArray(seed);
			    curveParameters = new X9ECParameters(seq);
            }

            var domainParams = new ECDomainParameters(curveParameters.Curve, curveParameters.G, curveParameters.N, curveParameters.H, curveParameters.GetSeed());            
            var keyParams = new ECKeyGenerationParameters(domainParams, new SecureRandom());
            var generator = new ECKeyPairGenerator(Algorithm.Identifier);

            generator.Init(keyParams);
            
            var keyPair = generator.GenerateKeyPair();
            var privateKeyParameter = (ECPrivateKeyParameters)keyPair.Private;
            var publicKeyParameter = (ECPublicKeyParameters)keyPair.Public;

            Private = new Secp256k1Key(privateKeyParameter.D.ToByteArrayUnsigned());
            Public = new Secp256k1Key(publicKeyParameter.Q.GetEncoded(), false);
        }
        
        public Secp256k1KeyPair(Secp256k1Algorithm algorithm, Secp256k1Key privateKey, Secp256k1Key publicKey) : base(algorithm, privateKey, publicKey)
        {
        }
    }
}