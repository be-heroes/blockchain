using System.Security.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Ed25519 : Algorithm
    {
        public Ed25519() : base("EdDSA", 256, new KeySizes[]{ new KeySizes(256, 256, 0) }, new Ed25519Curve())
        {

        }
    }
}