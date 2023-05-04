using System.Security.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public abstract class Algorithm : BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms.Algorithm
    {
        public override Curve Curve => (Curve)base.Curve;

        protected Algorithm(string identifier, int keySize, KeySizes[] legalKeySizes, Curve curve) : base(identifier, keySize, legalKeySizes, curve)
        {
        }
    }
}