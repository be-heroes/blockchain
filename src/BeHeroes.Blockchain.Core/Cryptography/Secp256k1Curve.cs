namespace BeHeroes.Blockchain.Core.Cryptography
{
    public sealed class Secp256k1Curve : BeHeroes.CodeOps.Abstractions.Cryptography.Structure
    {
        public static string Name => "secp256k1";

        public Secp256k1Curve(byte[]? seed = default) : base(Name, seed)
        {
            
        }
    }
}