using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchain.Core.Cryptography.Ed25519
{
    public sealed class Ed25519Algorithm : Algorithm
    {
        public static string Name => "EdDSA";

        public Ed25519Algorithm(int keySize = 256) : base(Name, keySize, new KeySizes[]{ new KeySizes(256, 512, 256) }, null)
        {
            
        }
    }
}