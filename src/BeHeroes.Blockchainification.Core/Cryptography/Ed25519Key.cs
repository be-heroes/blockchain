using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Strings;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Ed25519Key : Key
    {
        public static readonly Ed25519Key Empty = new Ed25519Key(Array.Empty<byte>());

        public Ed25519Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate: isPrivate)
        {
        }

        public override string ToString()
        {
            return (!IsPrivate) ? (HexString)_rawData : base.ToString();
        }
    }   
}