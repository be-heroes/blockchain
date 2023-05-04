using Org.BouncyCastle.Asn1.X9;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public class Ed25519Curve : Curve
    {
        public Ed25519Curve() : base("Curve25519")
        {
            
        }

        public Ed25519Curve(X9ECParameters parameters) : base("Curve25519", parameters)
        {

        }

        public static implicit operator X9ECParameters(Ed25519Curve curve)
        {
            return curve.Parameters;
        }

        public static implicit operator Ed25519Curve(X9ECParameters parameters)
        {
            return new Ed25519Curve(parameters);
        }
    }
}