using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Ed25519Key : Key
    {
        public static readonly Ed25519Key Empty = new Ed25519Key(Array.Empty<byte>());
        
        public override int KeySize => 256;

        public Ed25519Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate)
        {
        }
    }   
}