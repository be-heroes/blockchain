using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Secp256k1Algorithm : Algorithm
    {
        public Secp256k1Algorithm() : base("ECDSA", 256, new KeySizes[]{ new KeySizes(256, 257, 1) }, new Secp256k1Curve())
        {

        }
    }
}