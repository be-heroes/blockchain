using System.Security.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Secp256k1Algorithm : Algorithm
    {
        // Private keys are 256 bit, Public keys are 257 bit.
        public Secp256k1Algorithm() : base("ECDSA", 256, new KeySizes[]{ new KeySizes(256, 257, 1) }, new Secp256k1Curve())
        {

        }
    }
}