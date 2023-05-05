using Org.BouncyCastle.Asn1.X9;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public class Secp256k1Curve : ECCurve
    {
        public Secp256k1Curve() : base("secp256k1")
        {
            
        }

        public Secp256k1Curve(X9ECParameters parameters) : base("secp256k1", parameters)
        {

        }

        public static implicit operator X9ECParameters(Secp256k1Curve curve)
        {
            return curve.Parameters;
        }

        public static implicit operator Secp256k1Curve(X9ECParameters parameters)
        {
            return new Secp256k1Curve(parameters);
        }
    }
}