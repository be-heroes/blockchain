using Org.BouncyCastle.Asn1.X9;

namespace BeHeroes.Blockchainification.Core.Cryptography.Algorithms
{
    public sealed class Curve25519 : BeHeroes.CodeOps.Abstractions.Cryptography.Structure
    {
        public static string Name => "Curve25519";

        public Curve25519(byte[]? seed = default) : base(Name, seed ?? ECNamedCurveTable.GetByName(Name).GetSeed())
        {

        }
    }
}