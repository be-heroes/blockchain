using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchain.Core.Cryptography.Secp256k1
{
    public sealed class Secp256k1Algorithm : Algorithm
    {
        public static string Name => "ECDSA";

        public Secp256k1Algorithm() : this(new Secp256k1Curve())
        {
            
        }

        public Secp256k1Algorithm(Secp256k1Curve curve) : base(Name, 256, new KeySizes[]{ new KeySizes(256, 256, 0) }, curve)
        {

        }
    }
}