using BeHeroes.CodeOps.Abstractions.Cryptography;

namespace BeHeroes.Blockchainification.Core.Cryptography
{
    public sealed class Secp256k1Key : Key
    {        
        public static readonly Secp256k1Key Empty = new Secp256k1Key(Array.Empty<byte>());

        private readonly int _keySize;

        public override int KeySize 
        { 
            get
            {
                return _keySize;
            } 
        }

        public Secp256k1Key(byte[] rawData, bool isPrivate = true) : base(rawData, isPrivate)
        {
            _keySize = (isPrivate) ? 256 : 257;
        }
    }   
}