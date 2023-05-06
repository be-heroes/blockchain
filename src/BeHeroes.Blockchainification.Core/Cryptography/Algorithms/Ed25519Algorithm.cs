using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Ed25519Algorithm : Algorithm
    {
        public static string Name => "EdDSA";

        public Ed25519Algorithm() : this(new Curve25519())
        {
        }

        public Ed25519Algorithm(Curve25519 curve) : base(Name, 256, new KeySizes[]{ new KeySizes(256, 256, 0) }, curve)
        {
    
        }
    }
}