using BeHeroes.CodeOps.Abstractions.Cryptography;
using BeHeroes.CodeOps.Abstractions.Strings;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Secp256k1Key : Key
    {        
        public static readonly Secp256k1Key Empty = new Secp256k1Key(Array.Empty<byte>());

        public Secp256k1Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate: isPrivate)
        {
            
        }

        public override string ToString()
        {
            return (!IsPrivate) ? (HexString)_rawData : base.ToString();
        }
    }   
}