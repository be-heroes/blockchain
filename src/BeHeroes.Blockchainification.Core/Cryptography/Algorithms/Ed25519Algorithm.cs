using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography.Algorithms;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Ed25519Algorithm : Algorithm
    {
        public Ed25519Algorithm() : base("EdDSA", 256, new KeySizes[]{ new KeySizes(256, 256, 0) }, new Ed25519Curve())
        {
    
        }
    }
}