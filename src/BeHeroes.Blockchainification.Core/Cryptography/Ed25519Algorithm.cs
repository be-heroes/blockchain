using System.Security.Cryptography;
using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Ed25519Algorithm : Algorithm
    {
        public static string Name => "EdDSA";

        public Ed25519Algorithm() : base(Name, 256, new KeySizes[]{ new KeySizes(256, 256, 0) }, null)
        {
        }
    }
}