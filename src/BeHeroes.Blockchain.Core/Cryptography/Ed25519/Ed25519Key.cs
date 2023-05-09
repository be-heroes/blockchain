using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Strings;

namespace BeHeroes.Blockchain.Core.Cryptography.Ed25519
{
    public sealed class Ed25519Key : Key
    {
        public static readonly Ed25519Key Empty = new Ed25519Key(Array.Empty<byte>());

        internal IReadOnlyCollection<byte> RawData => _rawData.AsReadOnly();

        public Ed25519Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate: isPrivate)
        {
        }

        public override string ToString()
        {
            return (!IsPrivate) ? (HexString)_rawData : base.ToString();
        }
    }   
}