using Org.BouncyCastle.Asn1.X9;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public abstract class ECCurve : BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms.Curve
    {
        public override X9ECParameters Parameters => (X9ECParameters)base.Parameters;

        protected ECCurve(string identifier) : this(identifier, ECNamedCurveTable.GetByName(identifier))
        {

        }

        protected ECCurve(string identifier, X9ECParameters parameters) : base(identifier, parameters)
        {

        }

        public override byte[] GetSeed()
        {
            return Parameters.GetSeed();
        }
    }
}